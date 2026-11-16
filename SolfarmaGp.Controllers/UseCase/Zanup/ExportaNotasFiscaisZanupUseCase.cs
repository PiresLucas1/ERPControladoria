using SolfarmaGp.Repositorios.Zanup.ExportaNotasFiscais;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

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
        /// <summary>Notas que não exportaram, com o motivo (ex.: produto ou fornecedor não cadastrado).</summary>
        public List<PendenciaNotaZanup> Pendencias { get; set; } = new List<PendenciaNotaZanup>();
    }

    /// <summary>Uma nota que ficou com erro na exportação do documento fiscal.</summary>
    public class PendenciaNotaZanup
    {
        public const string Produto = "Produto";
        public const string ClienteFornecedor = "Cliente/Fornecedor";
        public const string Idnat = "IDNAT";
        public const string Natureza = "Natureza";
        public const string Outros = "Outros";

        public string Categoria { get; set; } = Outros;
        /// <summary>O que precisa ser cadastrado/corrigido: ID do produto, CODCFO ou CFOP.</summary>
        public string Codigo { get; set; } = "";
        public string Item { get; set; } = "";
        public string ChaveAcesso { get; set; } = "";
        public string Serie { get; set; } = "";
        public DateTime? Emissao { get; set; }
        public string NaturezaOperacao { get; set; } = "";
        public bool Cancelado { get; set; }
        public string Mensagem { get; set; } = "";

        // Dados do XML da nota (buscados pela chave de acesso).
        public string CnpjEmitente { get; set; } = "";
        public string NomeEmitente { get; set; } = "";
        public string DocDestinatario { get; set; } = "";
        public string NomeDestinatario { get; set; } = "";
        public string UfDestinatario { get; set; } = "";
        // Do item do produto que deu erro (só na categoria Produto).
        public string DescricaoProduto { get; set; } = "";
        public string CfopItem { get; set; } = "";
        public string Quantidade { get; set; } = "";
        public string ValorTotal { get; set; } = "";
    }

    /// <summary>Etapas que podem ser executadas isoladamente.</summary>
    public enum EtapaManualZanup
    {
        ClienteFornecedor,
        Produtos,
        DocumentoFiscal
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
        /// Ordem fixa. Primeiro a preparação (situação na Sefaz e notas canceladas), depois
        /// cliente/fornecedor e produtos, e por último o documento fiscal, que depende de todos eles.
        /// Se uma etapa falhar, as seguintes não rodam.
        /// </summary>
        public Task<List<EtapaExportacaoZanup>> Execute(
            ParametrosExportaNotasZanup p,
            Action<string>? aoIniciarEtapa = null) =>
            ExecutaEtapas(p, null, aoIniciarEtapa);

        /// <summary>Roda somente uma etapa de exportação, sem as demais (execução manual).</summary>
        public Task<List<EtapaExportacaoZanup>> ExecuteManual(
            ParametrosExportaNotasZanup p,
            EtapaManualZanup etapa,
            Action<string>? aoIniciarEtapa = null) =>
            ExecutaEtapas(p, etapa, aoIniciarEtapa);

        private async Task<List<EtapaExportacaoZanup>> ExecutaEtapas(
            ParametrosExportaNotasZanup p,
            EtapaManualZanup? somente,
            Action<string>? aoIniciarEtapa)
        {
            var repo = new ExportaNotasZanupRepo();

            var etapas = new List<(string Nome, Func<Task<RetornoProcedureZanup>> Executar, bool EhDocumentoFiscal)>();

            if (somente == null)
            {
                etapas.Add(("NF-e emitidas", () => repo.ConsultaSituacaoNFeEmitidas(), false));
                etapas.Add(("NF-e recebidas", () => repo.ConsultaSituacaoNFeRecebidas(), false));
                etapas.Add(("Notas canceladas", () => repo.AtualizaNotasCanceladas(p), false));
            }
            if (somente == null || somente == EtapaManualZanup.ClienteFornecedor)
                etapas.Add(("Cliente/Fornecedor", () => repo.ExportaClienteFornecedor(p), false));
            if (somente == null || somente == EtapaManualZanup.Produtos)
                etapas.Add(("Produtos", () => repo.ExportaProdutos(p), false));
            if (somente == null || somente == EtapaManualZanup.DocumentoFiscal)
                etapas.Add(("Documento fiscal", () => repo.ExportaDocumentoFiscal(p), true));

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

                    if (etapa.Pendencias.Count > 0)
                        await EnriquecePendencias(etapa);
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

            // Segundo result set: uma linha por nota que ficou com erro (ResultadoExportacaoTotvs preenchido).
            var notas = tabelas.FirstOrDefault(t => t.Columns.Contains("ResultadoExportacaoTotvs"));
            if (notas != null)
            {
                foreach (DataRow n in notas.Rows)
                {
                    string res = n["ResultadoExportacaoTotvs"]?.ToString()?.Trim() ?? "";
                    if (res.Length == 0)
                        continue;
                    etapa.Pendencias.Add(CriaPendencia(n, res));
                }
            }

            bool temErroNoResumo = resumo.Columns.Contains("REGISTRO(S) COM ERRO")
                && int.TryParse(linha["REGISTRO(S) COM ERRO"]?.ToString(), out int comErro)
                && comErro > 0;

            if (temErroNoResumo || etapa.Pendencias.Count > 0)
                etapa.ComAviso = true;
        }

        /// <summary>
        /// Completa cada pendência com os dados do XML da nota (pela chave de acesso): emitente, destinatário
        /// e, para produto não encontrado, a descrição/CFOP/quantidade/valor do item. Se essa consulta falhar,
        /// a exportação NÃO é afetada: as pendências só ficam sem os dados extras.
        /// </summary>
        private static async Task EnriquecePendencias(EtapaExportacaoZanup etapa)
        {
            try
            {
                DataTable dados = await new ConsultaDadosNotasZanup().ExecutarAsync(etapa.Pendencias.Select(p => p.ChaveAcesso));
                if (dados.Rows.Count == 0)
                    return;

                var porChave = dados.AsEnumerable().ToLookup(r => Texto(r, "ChaveAcesso"));

                foreach (var p in etapa.Pendencias)
                {
                    var linhas = porChave[p.ChaveAcesso].ToList();
                    if (linhas.Count == 0)
                        continue;

                    DataRow cab = linhas[0];
                    p.CnpjEmitente = Texto(cab, "CNPJEmitente");
                    p.NomeEmitente = Texto(cab, "NomeEmitente");
                    string cnpj = Texto(cab, "CNPJDestinatario");
                    p.DocDestinatario = cnpj.Length > 0 ? cnpj : Texto(cab, "CPFDestinatario");
                    p.NomeDestinatario = Texto(cab, "NomeDestinatario");
                    p.UfDestinatario = Texto(cab, "UFEnderecoDestinatario");

                    if (p.Categoria == PendenciaNotaZanup.Produto)
                    {
                        // O mesmo produto pode aparecer em mais de um item: junta todos.
                        var itens = linhas.Where(r => Texto(r, "CodigoProduto") == p.Codigo).ToList();
                        if (itens.Count > 0)
                        {
                            p.DescricaoProduto = Texto(itens[0], "DescricaoProduto");
                            p.CfopItem = string.Join(", ", itens.Select(r => Texto(r, "CFOP")).Distinct());
                            p.Quantidade = string.Join(" + ", itens.Select(r => FormataNumero(r, "QuantidadeTributavel")));
                            p.ValorTotal = string.Join(" + ", itens.Select(r => FormataNumero(r, "ValorTotalProduto")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                etapa.Log.Add("Aviso: não foi possível buscar os dados do XML das notas com erro: " + ex.Message);
            }
        }

        private static string FormataNumero(DataRow r, string coluna) =>
            r.Table.Columns.Contains(coluna) && r[coluna] is decimal d ? d.ToString("0.##") : Texto(r, coluna);

        private static string Texto(DataRow r, string coluna) =>
            r.Table.Columns.Contains(coluna) && r[coluna] != DBNull.Value ? r[coluna].ToString()!.Trim() : "";

        /// <summary>Classifica a mensagem de erro da nota e extrai o código que precisa ser cadastrado/corrigido.</summary>
        private static PendenciaNotaZanup CriaPendencia(DataRow n, string mensagem)
        {
            string categoria;
            string codigo;
            string item = Regex.Match(mensagem, @"NUM\.\s*ITEM\s*(\d+)", RegexOptions.IgnoreCase).Groups[1].Value;

            if (mensagem.Contains("PRODUTO NÃO ENCONTRADO", StringComparison.OrdinalIgnoreCase))
            {
                categoria = PendenciaNotaZanup.Produto;
                codigo = Regex.Match(mensagem, @"ID\.\s*(\S+)").Groups[1].Value;
            }
            else if (mensagem.Contains("CLIENTE/FORNECEDOR NÃO ENCONTRADO", StringComparison.OrdinalIgnoreCase))
            {
                categoria = PendenciaNotaZanup.ClienteFornecedor;
                codigo = Regex.Match(mensagem, @"CODCFO\s+(\S+)").Groups[1].Value;
            }
            else if (mensagem.Contains("IDNAT", StringComparison.OrdinalIgnoreCase))
            {
                categoria = PendenciaNotaZanup.Idnat;
                codigo = Regex.Match(mensagem, @"CFOP\s+(\S+)").Groups[1].Value;
            }
            else if (mensagem.Contains("REGRA ICMS", StringComparison.OrdinalIgnoreCase)
                  || mensagem.Contains("CFOP", StringComparison.OrdinalIgnoreCase))
            {
                categoria = PendenciaNotaZanup.Natureza;
                codigo = Regex.Match(mensagem, @"CFOP\s+(\S+)").Groups[1].Value;
            }
            else
            {
                categoria = PendenciaNotaZanup.Outros;
                codigo = "";
            }

            DateTime? emissao = n.Table.Columns.Contains("DataHoraEmissao") && n["DataHoraEmissao"] is DateTime d ? d : null;

            return new PendenciaNotaZanup
            {
                Categoria = categoria,
                Codigo = codigo,
                Item = item,
                ChaveAcesso = Texto(n, "ChaveAcesso"),
                Serie = Texto(n, "SerieNota"),
                Emissao = emissao,
                NaturezaOperacao = Texto(n, "NaturezaOperacao"),
                Cancelado = Texto(n, "Cancelado") is "1" or "True",
                Mensagem = mensagem
            };
        }
    }
}
