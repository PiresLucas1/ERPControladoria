using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.InclusaoNotaIndividuak
{
    public class InclusaoNotaIndividualRepo
    {
        public async Task<(DataTable, DataTable)> Execute(string numeroDocumentos, DateTime dataInicio, DateTime dataFim)
        {
            DataTable dtresultado = new DataTable();
            DataTable dtnotas = new DataTable();
            DbConexaoConfig conexao = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("upsIntegracaoTotvsExportaNotaFiscalSat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INdatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataFim", dataFim);
                        cmd.Parameters.AddWithValue("@INintFilial", 0);
                        cmd.Parameters.AddWithValue("@INbitSubstituir", DBNull.Value);
                        cmd.Parameters.AddWithValue("@INbitNaoConferida", DBNull.Value);
                        cmd.Parameters.AddWithValue("@INvchCodTmv", DBNull.Value);
                        cmd.Parameters.AddWithValue("@INvchNumeroDocumentos", numeroDocumentos ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@INbitRetornaDados", true);

                        var msgRetorno = new SqlParameter("OUTvchMsgRetorno", SqlDbType.VarChar, -1)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msgRetorno);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            // primeiro SELECT (#tblNotasImportadas)
                            dtresultado.Load(reader);

                            // segundo SELECT (#tblNotasNaoimportadas)
                            if (await reader.NextResultAsync())
                            {
                                dtnotas.Load(reader);
                            }
                        }
                        
                        conexao.FecharConexao(conn);

                    }

                }
            } catch (SqlException ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
            return (dt,dt);
        }
    }
}

//@INdatDataInicio datetime,
//@INdatDataFim					datetime,
//@INintFilial					int = NULL,
//@INbitSubstituir				bit = NULL,
//@INbitNaoConferida				bit = NULL,
//@INvchCodTmv					varchar(20) = NULL,
//@INvchNumeroDocumentos			varchar(max) = NULL,
//@INbitRetornaDados				bit = 1,
//@OUTvchMsgRetorno				varchar(max) OUT 

