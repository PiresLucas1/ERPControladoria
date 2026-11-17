using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.DrogaCentro.Fiscal.ExportaNotasAlpha7
{
    /// <summary>Parâmetros da upsIntegracaoTotvsExportaNotaFiscalAlpha7 (null = NULL na procedure).</summary>
    public class ParametrosNotaFiscalAlpha7
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int? Filial { get; set; }
        public bool Substituir { get; set; }
        public bool? NaoConferida { get; set; }
        public string? CodTmv { get; set; }
        public string NumeroDocumentos { get; set; } = "";
    }

    /// <summary>Retorno de uma procedure: result set final + mensagens de progresso (RAISERROR severidade 0).</summary>
    public class RetornoProcedureAlpha7
    {
        public DataTable Dados { get; set; } = new DataTable();
        public List<string> Log { get; set; } = new List<string>();
    }

    /// <summary>
    /// Executa as procedures de integração Alpha7 -> Totvs (banco BigCentral).
    /// Nenhuma delas tem parâmetro de saída. Com @INbitRetornaDados = 1 (padrão da procedure)
    /// o sucesso volta como result set "RESULTADO" e o erro volta como result set "ErrorMessage"
    /// (a procedure captura o erro internamente, então NÃO lança SqlException).
    /// </summary>
    public class ExportaAlpha7Repo
    {
        // uspAlpha7SincronizaTudo (alimenta as tabelas espelho Alpha7_* via linked server)
        //   @INintDiasRetroativos, @INvchDominio = NULL (todos), @INvchNomeTabelaOrigem = NULL (todas)
        //   (@INbitRetornaDados usa o padrão = 1)
        public Task<RetornoProcedureAlpha7> SincronizaBase(int diasRetroativos)
        {
            return Executar("dbo.uspAlpha7SincronizaTudo", cmd =>
            {
                cmd.Parameters.AddWithValue("@INintDiasRetroativos", diasRetroativos);
                cmd.Parameters.AddWithValue("@INvchDominio", DBNull.Value);
                cmd.Parameters.AddWithValue("@INvchNomeTabelaOrigem", DBNull.Value);
            });
        }

        // Produtos e Cliente/Fornecedor: sempre desde o 1º dia do mês atual e nunca substituem.
        private static DateTime PrimeiroDiaDoMesAtual() =>
            new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

        // upsIntegracaoTotvsExportaProdutosAlpha7
        //   @INbitSubstituir, @INdatDataInicioCadastro, @INvchCODPRODUTO (@INbitRetornaDados usa o padrão = 1)
        public Task<RetornoProcedureAlpha7> ExportaProdutos()
        {
            return Executar("dbo.upsIntegracaoTotvsExportaProdutosAlpha7", cmd =>
            {
                cmd.Parameters.AddWithValue("@INbitSubstituir", 0);
                cmd.Parameters.AddWithValue("@INdatDataInicioCadastro", PrimeiroDiaDoMesAtual());
                cmd.Parameters.AddWithValue("@INvchCODPRODUTO", DBNull.Value);
            });
        }

        // upsIntegracaoTotvsExportaClienteFornecedorAlpha7
        //   @INbitSubstituir, @INdatDataInicioCadastro, @INvchCODCFO (@INbitRetornaDados usa o padrão = 1)
        public Task<RetornoProcedureAlpha7> ExportaClienteFornecedor()
        {
            return Executar("dbo.upsIntegracaoTotvsExportaClienteFornecedorAlpha7", cmd =>
            {
                cmd.Parameters.AddWithValue("@INbitSubstituir", 0);
                cmd.Parameters.AddWithValue("@INdatDataInicioCadastro", PrimeiroDiaDoMesAtual());
                cmd.Parameters.AddWithValue("@INvchCODCFO", DBNull.Value);
            });
        }

        // upsIntegracaoTotvsExportaNotaFiscalAlpha7
        //   @INdatDataInicio, @INdatDataFim, @INintFilial, @INbitSubstituir, @INbitNaoConferida,
        //   @INvchCodTmv, @INvchNumeroDocumentos (@INbitRetornaDados usa o padrão = 1)
        public Task<RetornoProcedureAlpha7> ExportaNotaFiscal(ParametrosNotaFiscalAlpha7 p)
        {
            return Executar("dbo.upsIntegracaoTotvsExportaNotaFiscalAlpha7", cmd =>
            {
                cmd.Parameters.AddWithValue("@INdatDataInicio", p.DataInicio);
                cmd.Parameters.AddWithValue("@INdatDataFim", p.DataFim);
                cmd.Parameters.AddWithValue("@INintFilial", (object?)p.Filial ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@INbitSubstituir", p.Substituir);
                cmd.Parameters.AddWithValue("@INbitNaoConferida", (object?)p.NaoConferida ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@INvchCodTmv", string.IsNullOrWhiteSpace(p.CodTmv) ? DBNull.Value : p.CodTmv);
                // A tela trabalha com 192;193;194, mas a ufnTextoTabela da procedure separa por VÍRGULA.
                cmd.Parameters.AddWithValue("@INvchNumeroDocumentos", (p.NumeroDocumentos ?? "").Replace(';', ','));
            });
        }

        private async Task<RetornoProcedureAlpha7> Executar(string nomeProcedure, Action<SqlCommand> configuraParametros)
        {
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.BigCentral);
            var retorno = new RetornoProcedureAlpha7();

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    // Mensagens de progresso da procedure (RAISERROR ... WITH NOWAIT, severidade 0).
                    conn.InfoMessage += (s, e) =>
                    {
                        lock (retorno.Log)
                        {
                            retorno.Log.Add(e.Message);
                        }
                    };

                    using (SqlCommand cmd = new SqlCommand(nomeProcedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;
                        configuraParametros(cmd);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                                retorno.Dados.Load(reader);
                        }
                    }
                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return retorno;
        }
    }
}
