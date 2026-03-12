using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.InclusaoNotaIndividuak
{
    public class InclusaoNotaIndividualRepo
    {
        public async Task<(DataTable, string)> Execute(string numeroDocumentos, DateTime dataInicio, DateTime dataFim)
        {
            DataTable dtresultado = new DataTable();
            DataTable dtnotas = new DataTable();
            SqlParameter msgRetorno;
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

                        msgRetorno = new SqlParameter("OUTvchMsgRetorno", SqlDbType.VarChar, -1)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msgRetorno);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                                dtresultado.Load(reader);
                        }

                        conexao.FecharConexao(conn);

                    }

                }
            } catch (SqlException ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
            return (dtresultado, msgRetorno.Value.ToString());
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

