using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ERP_FISCAL.Utils
{
        public class GetToken
        {
            public async Task<string> ObterTokenAsync()
            {
                string token = null;
                var conexaoBanco = new DbConexaoConfig(DbName.ZanupTotvs);

                try
                {
                    using (SqlConnection conn = conexaoBanco.AbrirConexao())
                    using (SqlCommand cmd = new SqlCommand(@"
                                                            SELECT 
                                                                TOP 1 tblAutBling.Token
                                                            FROM   
                                                                Zanup.dbo.tblAutenticacaoBling tblAutBling (NOLOCK)
                                                            WHERE 
                                                                tblAutBling.Ativo = 1
                                                             ", conn
                                                            ))
                    {
                        cmd.CommandType = CommandType.Text;

                        var result = await cmd.ExecuteScalarAsync();

                        if (result != null && result != DBNull.Value)
                            token = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao consultar token: " + ex.Message, ex);
                }

                return token;
            }
        }

}
