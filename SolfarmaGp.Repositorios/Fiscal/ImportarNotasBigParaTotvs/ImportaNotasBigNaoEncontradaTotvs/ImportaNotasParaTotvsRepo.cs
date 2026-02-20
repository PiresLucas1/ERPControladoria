using ERP_FISCAL;
using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasServicoParaTotvs.ImportaNotasServicoParaTotvs
{
    public class ImportaNotasParaTotvsRepo
    {
        public async Task<(string mensagem, DataTable DtRetorno)> Executar(string notas, DateTime dataInicio, DateTime dataFim, int substituir, int conferida, int filial)
        {
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            DataTable tabelaRetorno = new DataTable();            
            string retornoMensagem = "";
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.upsIntegracaoTotvsExportaNotaFiscalSat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;
                        //SqlParameter p;
                        cmd.Parameters.AddWithValue("@INdatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataFim", dataFim);
                        cmd.Parameters.AddWithValue("@INintFilial", filial);
                        cmd.Parameters.AddWithValue("@INbitSubstituir", substituir);
                        cmd.Parameters.AddWithValue("@INbitNaoConferida", conferida);
                        cmd.Parameters.AddWithValue("@INvchNumeroDocumentos", notas);

                        var msgRetorno = new SqlParameter("@OUTvchMsgRetorno", SqlDbType.VarChar, 1000)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msgRetorno);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                                tabelaRetorno.Load(reader);
                        }

                        retornoMensagem = msgRetorno.Value?.ToString();
                    }

                    if (tabelaRetorno.Columns.Count <= 0)
                    {
                        string retorno = tabelaRetorno.Rows[0].ToString() ?? "Nada Encontrado";
                    }
                    conexaoBanco.FecharConexao(conn);
                    return (retornoMensagem , tabelaRetorno);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
        }
    }
}

