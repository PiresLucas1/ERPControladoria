using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Contabil.Parametrizacao
{
    public class AlteraLancamentoParametrizado
    {
        public async Task<Boolean> Execute(DataTable dt, string user)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspSalvaContabilConferenciaRecebimentosLancamentosParametrizados", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter param = new SqlParameter("@INTypeLancamentos", dt);
                        param.SqlDbType = SqlDbType.Structured;
                        param.TypeName = "TpLancamentoContabilParametrizado";
                        cmd.Parameters.Add(param);
                        cmd.Parameters.AddWithValue("@INvchUsuario", user);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }
                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
            return true;
        }
    }
}
