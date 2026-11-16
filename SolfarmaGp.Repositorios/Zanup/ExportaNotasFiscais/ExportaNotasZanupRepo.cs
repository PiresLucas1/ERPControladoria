using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Zanup.ExportaNotasFiscais
{
    /// <summary>Filtros da exportação Zanup -> Totvs. Todas as procedures usam o mesmo período.</summary>
    public class ParametrosExportaNotasZanup
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string? CodTmv { get; set; }
        public string NumeroDocumentos { get; set; } = "";
    }

    /// <summary>Tudo que uma procedure devolveu: todos os result sets + mensagens de progresso (RAISERROR severidade 0).</summary>
    public class RetornoProcedureZanup
    {
        public List<DataTable> Tabelas { get; set; } = new List<DataTable>();
        public List<string> Log { get; set; } = new List<string>();
    }

    /// <summary>
    /// Erro de SQL que preserva o log de progresso emitido ANTES da falha
    /// (sem isso, a mensagem do que já foi processado se perderia).
    /// </summary>
    public class ErroProcedureZanupException : Exception
    {
        public List<string> Log { get; }

        public ErroProcedureZanupException(string mensagem, List<string> log, Exception inner)
            : base(mensagem, inner)
        {
            Log = log;
        }
    }

    /// <summary>
    /// Executa, no banco Zanup, as procedures que levam as notas da Zanup para o Totvs.
    /// Todas rodam com @INbitExibeLog = 1: o sucesso vem como result set "RESULTADO" e o erro tratado
    /// pela procedure vem como result set "ErrorMessage" (não lança SqlException). Erros sem tratamento
    /// (ex.: período maior que 90 dias) lançam SqlException.
    /// </summary>
    public class ExportaNotasZanupRepo
    {
        // --- Preparação -------------------------------------------------------------------------

        public Task<RetornoProcedureZanup> ConsultaSituacaoNFeEmitidas() =>
            Executar("dbo.uspConsultarSituacaoNFeEmitidasSefaz", cmd =>
            {
                cmd.Parameters.AddWithValue("@INbitExibeLog", true);
            });

        public Task<RetornoProcedureZanup> ConsultaSituacaoNFeRecebidas() =>
            Executar("dbo.uspConsultarSituacaoNFeRecebidasSefaz", cmd =>
            {
                cmd.Parameters.AddWithValue("@INbitExibeLog", true);
            });

        public Task<RetornoProcedureZanup> VinculaPedidoVendaArquivoXml() =>
            Executar("dbo.uspVinculaPedidoVendaArquivoXML", cmd =>
            {
                cmd.Parameters.AddWithValue("@INbitExibeLog", true);
            });

        public Task<RetornoProcedureZanup> AtualizaNotasCanceladas(ParametrosExportaNotasZanup p) =>
            Executar("dbo.uspExportaTotvsAtualizaNotasCanceladas", cmd =>
            {
                cmd.Parameters.AddWithValue("@INdatDataInicio", p.DataInicio);
                cmd.Parameters.AddWithValue("@INdatDataFim", p.DataFim);
                cmd.Parameters.AddWithValue("@INbitExibeLog", true);
            });

        // --- Exportação -------------------------------------------------------------------------

        // Nunca substitui registros existentes.
        public Task<RetornoProcedureZanup> ExportaClienteFornecedor(ParametrosExportaNotasZanup p) =>
            Executar("dbo.uspUsuExportarTotvsClienteFornedor", cmd =>
            {
                cmd.Parameters.AddWithValue("@INbitSubstituir", false);
                cmd.Parameters.AddWithValue("@INvchCNPJCPF", DBNull.Value);
                cmd.Parameters.AddWithValue("@INbitExibeLog", true);
                cmd.Parameters.AddWithValue("@INdatDataInicio", p.DataInicio);
                cmd.Parameters.AddWithValue("@INdatDataFim", p.DataFim);
            });

        public Task<RetornoProcedureZanup> ExportaProdutos(ParametrosExportaNotasZanup p) =>
            Executar("dbo.uspUsuExportarTotvsProdutos", cmd =>
            {
                cmd.Parameters.AddWithValue("@INbitSubstituir", false);
                cmd.Parameters.AddWithValue("@INvchCODPRODUTO", DBNull.Value);
                cmd.Parameters.AddWithValue("@INdatDataInicio", p.DataInicio);
                cmd.Parameters.AddWithValue("@INbitExibeLog", true);
            });

        public Task<RetornoProcedureZanup> ExportaDocumentoFiscal(ParametrosExportaNotasZanup p) =>
            Executar("dbo.uspUsuExportarTotvsDocumentoFiscal", cmd =>
            {
                cmd.Parameters.AddWithValue("@INdatDataInicio", p.DataInicio);
                cmd.Parameters.AddWithValue("@INdatDataFim", p.DataFim);
                cmd.Parameters.AddWithValue("@INbitSubstituir", false);
                cmd.Parameters.AddWithValue("@INvchCodTmv", string.IsNullOrWhiteSpace(p.CodTmv) ? DBNull.Value : p.CodTmv);
                cmd.Parameters.AddWithValue("@INvchNumeroDocumentos",
                    string.IsNullOrWhiteSpace(p.NumeroDocumentos) ? DBNull.Value : p.NumeroDocumentos);
                cmd.Parameters.AddWithValue("@INbitExibeLog", true);
            });

        private async Task<RetornoProcedureZanup> Executar(string nomeProcedure, Action<SqlCommand> configuraParametros)
        {
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.ZanupTotvs);
            var retorno = new RetornoProcedureZanup();

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
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
                            // A procedure de documento fiscal devolve DOIS result sets (resumo + notas).
                            // DataTable.Load já avança sozinho para o próximo result set e fecha o reader no fim.
                            while (!reader.IsClosed)
                            {
                                var tabela = new DataTable();
                                tabela.Load(reader);
                                retorno.Tabelas.Add(tabela);
                            }
                        }
                    }
                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (SqlException ex)
            {
                List<string> logAteAqui;
                lock (retorno.Log)
                {
                    logAteAqui = new List<string>(retorno.Log);
                }
                throw new ErroProcedureZanupException(ex.Message, logAteAqui, ex);
            }

            return retorno;
        }
    }
}
