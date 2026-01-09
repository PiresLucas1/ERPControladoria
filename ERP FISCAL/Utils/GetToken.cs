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
                using (SqlCommand cmd = new SqlCommand("DBO.uspConsultaAutenticaBearerTokenBling", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;

                    // Parâmetro de entrada
                    cmd.Parameters.Add(new SqlParameter("@INvchURL", SqlDbType.VarChar, 100)
                    {
                        Value = "Aplicação GP - POST DEV https://api.bling.com.br/Api/v3/nfe" /* POPULA TABELA DE LOGS TBLLOGREQUESICAOAPIBLING */
                    });

                    // Parâmetro de saída
                    SqlParameter paramToken = new SqlParameter("@OUTvchBearerToken", SqlDbType.VarChar, 100)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(paramToken);

                    await cmd.ExecuteNonQueryAsync();

                    if (paramToken.Value != DBNull.Value)
                    {
                        token = paramToken.Value.ToString();

                        if (token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                            token = token.Substring(7);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar token via procedure: " + ex.Message, ex);
            }

            return token;
        }
    }
}
