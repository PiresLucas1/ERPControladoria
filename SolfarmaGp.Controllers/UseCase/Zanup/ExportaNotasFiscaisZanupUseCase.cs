using SolfarmaGp.Repositorios.Zanup.ExportaNotasFiscais;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Zanup
{
    public class EtapaExportacaoZanup
    {
        public string Nome { get; set; } = "";
        public string Mensagem { get; set; } = "";
        public bool Sucesso { get; set; }
        /// <summary>Etapa terminou, mas com registros que deram erro (precisa ser vista pelo usuário).</summary>
        public bool ComAviso { get; set; }
        /// <summary>Mensagens de progresso emitidas pela procedure.</summary>
        public List<string> Log { get; set; } = new List<string>();
        /// <summary>Detalhes extras (ex.: notas que falharam e o motivo).</summary>
        public List<string> Detalhes { get; set; } = new List<string>();
    }

    public class ExportaNotasFiscaisZanupUseCase
    {
        private const int MaxDiasPeriodo = 90; // limite da uspUsuExportarTotvsDocumentoFiscal

        /// <summary>Devolve a mensagem de erro do período, ou null se estiver válido.</summary>
        public static string? ValidaPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            if (dataInicio > dataFim)
                return "A data inicial não pode ser maior que a data final.";
            if ((dataFim - dataInicio).TotalDays > MaxDiasPeriodo)
                return $"O período não pode ser maior do que {MaxDiasPeriodo} dias.";
            return null;
        }

        /// <summary>
        /// Ordem fixa. Primeiro a preparação (situação na Sefaz, vínculo de pedido, canceladas), depois
        /// cliente/fornecedor e produtos, e por último o documento fiscal, que depende de todos eles.
        /// Se uma etapa falhar, as seguintes não rodam.
        /// </summary>
        public async Task<List<EtapaExportacaoZanup>> Execute(
            ParametrosExportaNotasZanup p,
            Action<string>? aoIniciarEtapa = null)
        {
            var repo = new ExportaNotasZanupRepo();

            var etapas = new List<(string Nome, Func<Task<RetornoProcedureZanup>> Executar, bool EhDocumentoFiscal)>
            {
                ("Situação NF-e emitidas (Sefaz)",   () => repo.ConsultaSituacaoNFeEmitidas(), false),
                ("Situação NF-e recebidas (Sefaz)",  () => repo.ConsultaSituacaoNFeRecebidas(), false),
                ("Vínculo pedido de venda x XML",    () => repo.VinculaPedidoVendaArquivoXml(), false),
                ("Atualização de notas canceladas",  () => repo.AtualizaNotasCanceladas(p), false),
                ("Cliente/Fornecedor",               () => repo.ExportaClienteFornecedor(p), false),
                ("Produtos",                         () => repo.ExportaProdutos(p), false),
                ("Documento fiscal",                 () => repo.ExportaDocumentoFiscal(p), true),
            };

            var resultados = new List<EtapaExportacaoZanup>();

            foreach (var (nome, executar, ehDocumentoFiscal) in etapas)
            {
                aoIniciarEtapa?.Invoke(nome);
                var etapa = new EtapaExportacaoZanup { Nome = nome };

                try
                {
                    RetornoProcedureZanup retorno = await executar();
                    etapa.Log = retorno.Log;
                    Interpreta(etapa, retorno.Tabelas, ehDocumentoFiscal);
                }
                catch (ErroProcedureZanupException ex)
                {
                    etapa.Sucesso = false;
                    etapa.Mensagem = ex.Message;
                    etapa.Log = ex.Log; // o que a procedure já tinha processado antes de falhar
                }
                catch (Exception ex)
                {
                    etapa.Sucesso = false;
                    etapa.Mensagem = ex.Message;
                }

                resultados.Add(etapa);

                if (!etapa.Sucesso)
                    break;
            }

            return resultados;
        }

        private static void Interpreta(EtapaExportacaoZanup etapa, List<DataTable> tabelas, bool ehDocumentoFiscal)
        {
            // Erro tratado pela procedure (CATCH): ErrorNumber, ErrorSeverity, ErrorState, ErrorProcedure, ErrorLine, ErrorMessage.
            var erro = tabelas.FirstOrDefault(t => t.Columns.Contains("ErrorMessage"));
            if (erro != null)
            {
                etapa.Sucesso = false;
                if (erro.Rows.Count > 0)
                {
                    DataRow r = erro.Rows[0];
                    etapa.Mensagem = $"Erro {r["ErrorNumber"]} (linha {r["ErrorLine"]} de {r["ErrorProcedure"]}): {r["ErrorMessage"]}";
                }
                else
                {
                    etapa.Mensagem = "A procedure retornou erro sem detalhes.";
                }
                return;
            }

            var resumo = tabelas.FirstOrDefault(t => t.Columns.Contains("RESULTADO") && t.Rows.Count > 0);
            if (resumo == null)
            {
                // Procedures de preparação não devolvem resumo: terminar sem erro é o sucesso.
                if (ehDocumentoFiscal)
                {
                    etapa.Sucesso = false;
                    etapa.Mensagem = "A procedure não devolveu o resultado esperado (nem sucesso nem erro).";
                }
                else
                {
                    etapa.Sucesso = true;
                    etapa.Mensagem = "Concluída.";
                }
                return;
            }

            DataRow linha = resumo.Rows[0];
            etapa.Sucesso = true;

            string texto = (linha["RESULTADO"]?.ToString() ?? "").Trim();
            var contagens = new[]
                {
                    ("REGISTRO(S) PROCESSADO(S)", "Processados"),
                    ("REGISTRO(S) INSERIDOS(S)", "Inseridos"),
                    ("REGISTRO(S) ALTERADOS(S)", "Alterados"),
                    ("REGISTRO(S) COM ERRO", "Com erro"),
                }
                .Where(c => resumo.Columns.Contains(c.Item1))
                .Select(c => $"{c.Item2}: {linha[c.Item1]}");
            etapa.Mensagem = $"{texto} {string.Join(" | ", contagens)}".Trim();

            if (resumo.Columns.Contains("REGISTRO(S) COM ERRO")
                && int.TryParse(linha["REGISTRO(S) COM ERRO"]?.ToString(), out int comErro)
                && comErro > 0)
            {
                etapa.ComAviso = true;

                // Segundo result set: uma linha por nota, com o resultado da exportação de cada uma.
                var notas = tabelas.FirstOrDefault(t => t.Columns.Contains("ResultadoExportacaoTotvs"));
                if (notas != null)
                {
                    foreach (DataRow n in notas.Rows)
                    {
                        string res = n["ResultadoExportacaoTotvs"]?.ToString()?.Trim() ?? "";
                        if (res.Length == 0 || res.Contains("SUCESSO", StringComparison.OrdinalIgnoreCase))
                            continue;
                        etapa.Detalhes.Add($"{n["ChaveAcesso"]}: {res}");
                    }
                }
            }
        }
    }
}
