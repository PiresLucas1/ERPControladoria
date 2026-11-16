using SolfarmaGp.Repositorios.DrogaCentro.Fiscal.ExportaNotasAlpha7;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.DrogaCentro.Fiscal.ExportaNotasAlpha7
{
    public class EtapaExportacaoAlpha7
    {
        public string Nome { get; set; } = "";
        public string Mensagem { get; set; } = "";
        public bool Sucesso { get; set; }
        /// <summary>Etapa concluída (Sucesso = true), mas com ressalvas que o usuário precisa ver.</summary>
        public bool ComAviso { get; set; }
        /// <summary>Mensagens de progresso emitidas pela procedure (ex.: "01 de 10 - 12345").</summary>
        public List<string> Log { get; set; } = new List<string>();
    }

    public class ExportaNotasAlpha7UseCase
    {
        /// <summary>
        /// Executa em sequência: [Sincronização, opcional] -> Produtos -> Cliente/Fornecedor -> Notas Fiscais.
        /// A ordem importa: a sincronização alimenta as tabelas espelho lidas pelas demais, e a nota
        /// depende de produto e cliente/fornecedor já cadastrados.
        /// Se uma etapa falhar, as seguintes não rodam.
        /// </summary>
        public async Task<List<EtapaExportacaoAlpha7>> Execute(
            ParametrosNotaFiscalAlpha7 parametrosNota,
            bool sincronizarAntes,
            int diasRetroativos,
            Action<string>? aoIniciarEtapa = null)
        {
            var repo = new ExportaAlpha7Repo();

            var etapas = new List<(string Nome, Func<Task<RetornoProcedureAlpha7>> Executar, bool EhSincronizacao)>();
            if (sincronizarAntes)
                etapas.Add(("Sincronização da base", () => repo.SincronizaBase(diasRetroativos), true));
            etapas.Add(("Produtos", () => repo.ExportaProdutos(), false));
            etapas.Add(("Cliente/Fornecedor", () => repo.ExportaClienteFornecedor(), false));
            etapas.Add(("Notas Fiscais", () => repo.ExportaNotaFiscal(parametrosNota), false));

            return await ExecutaEtapas(etapas, aoIniciarEtapa);
        }

        /// <summary>Roda somente a sincronização da base Alpha7.</summary>
        public async Task<List<EtapaExportacaoAlpha7>> ExecuteSomenteSincronizacao(
            int diasRetroativos,
            Action<string>? aoIniciarEtapa = null)
        {
            var repo = new ExportaAlpha7Repo();
            var etapas = new List<(string Nome, Func<Task<RetornoProcedureAlpha7>> Executar, bool EhSincronizacao)>
            {
                ("Sincronização da base", () => repo.SincronizaBase(diasRetroativos), true)
            };
            return await ExecutaEtapas(etapas, aoIniciarEtapa);
        }

        private static async Task<List<EtapaExportacaoAlpha7>> ExecutaEtapas(
            List<(string Nome, Func<Task<RetornoProcedureAlpha7>> Executar, bool EhSincronizacao)> etapas,
            Action<string>? aoIniciarEtapa)
        {
            var resultados = new List<EtapaExportacaoAlpha7>();

            foreach (var (nome, executar, ehSincronizacao) in etapas)
            {
                aoIniciarEtapa?.Invoke(nome);
                var etapa = new EtapaExportacaoAlpha7 { Nome = nome };

                try
                {
                    RetornoProcedureAlpha7 retorno = await executar();
                    etapa.Log = retorno.Log;

                    if (ehSincronizacao)
                        InterpretaRetornoSincronizacao(etapa, retorno.Dados);
                    else
                        InterpretaRetornoExportacao(etapa, retorno.Dados);
                }
                catch (Exception ex)
                {
                    etapa.Sucesso = false;
                    etapa.Mensagem = ex.Message;
                }

                resultados.Add(etapa);

                if (!etapa.Sucesso)
                    break; // não segue para a próxima etapa
            }

            return resultados;
        }

        /// <summary>
        /// Erro fatal da procedure: result set com ErrorNumber, ErrorSeverity, ErrorState,
        /// ErrorProcedure, ErrorLine, ErrorMessage. Devolve true e preenche a etapa se for esse o caso.
        /// </summary>
        private static bool TrataErroFatal(EtapaExportacaoAlpha7 etapa, DataTable dados)
        {
            if (!dados.Columns.Contains("ErrorMessage"))
                return false;

            etapa.Sucesso = false;
            if (dados.Rows.Count > 0)
            {
                DataRow erro = dados.Rows[0];
                etapa.Mensagem =
                    $"Erro {erro["ErrorNumber"]} (linha {erro["ErrorLine"]} de {erro["ErrorProcedure"]}): {erro["ErrorMessage"]}";
            }
            else
            {
                etapa.Mensagem = "A procedure retornou erro sem detalhes.";
            }
            return true;
        }

        /// <summary>
        /// Exportações (produtos, cliente/fornecedor, notas):
        ///  - sucesso: RESULTADO, [REGISTRO(S) PROCESSADO(S)], [REGISTRO(S) INSERIDOS(S)], [REGISTRO(S) ALTERADOS(S)]
        ///  - erro: result set de erro fatal (ver TrataErroFatal)
        /// </summary>
        private static void InterpretaRetornoExportacao(EtapaExportacaoAlpha7 etapa, DataTable dados)
        {
            if (TrataErroFatal(etapa, dados))
                return;

            if (dados.Columns.Contains("RESULTADO") && dados.Rows.Count > 0)
            {
                DataRow r = dados.Rows[0];
                etapa.Sucesso = true;
                etapa.Mensagem =
                    $"{r["RESULTADO"]?.ToString()?.Trim()} " +
                    $"Processados: {r["REGISTRO(S) PROCESSADO(S)"]} | " +
                    $"Inseridos: {r["REGISTRO(S) INSERIDOS(S)"]} | " +
                    $"Alterados: {r["REGISTRO(S) ALTERADOS(S)"]}";
                return;
            }

            // Formato inesperado: não dá para afirmar sucesso.
            etapa.Sucesso = false;
            etapa.Mensagem = "A procedure não devolveu o resultado esperado (nem sucesso nem erro).";
        }

        /// <summary>
        /// Sincronização: devolve uma linha por tabela (NomeTabelaEspelho, Dominio, UltimoStatus,
        /// QtdRegistrosUltimaExecucao, UltimaMensagemErro, UltimaExecucao). Falha de uma tabela NÃO gera
        /// erro de SQL: aparece como UltimoStatus = 'ERRO'. Tabela com erro gera AVISO (ComAviso) e a
        /// exportação segue; só o erro fatal da procedure interrompe.
        /// </summary>
        private static void InterpretaRetornoSincronizacao(EtapaExportacaoAlpha7 etapa, DataTable dados)
        {
            if (TrataErroFatal(etapa, dados))
                return;

            if (!dados.Columns.Contains("UltimoStatus"))
            {
                etapa.Sucesso = false;
                etapa.Mensagem = "A sincronização não devolveu o resultado esperado (nem sucesso nem erro).";
                return;
            }

            var comErro = dados.AsEnumerable()
                .Where(r => string.Equals(r["UltimoStatus"]?.ToString()?.Trim(), "ERRO", StringComparison.OrdinalIgnoreCase))
                .ToList();

            int total = dados.Rows.Count;

            if (comErro.Count == 0)
            {
                etapa.Sucesso = true;
                etapa.Mensagem = $"{total} tabela(s) sincronizada(s) sem erro.";
                return;
            }

            // Avisa, mas não reprova: a exportação segue (decisão do usuário).
            etapa.Sucesso = true;
            etapa.ComAviso = true;
            const int maxTabelas = 10;
            var detalhes = comErro
                .Take(maxTabelas)
                .Select(r => $"  - {r["NomeTabelaEspelho"]}: {r["UltimaMensagemErro"]}");
            etapa.Mensagem =
                $"ATENÇÃO: {comErro.Count} de {total} tabela(s) com erro na sincronização (a exportação segue):\n" +
                string.Join("\n", detalhes) +
                (comErro.Count > maxTabelas ? $"\n  ... e mais {comErro.Count - maxTabelas}" : "");
        }
    }
}
