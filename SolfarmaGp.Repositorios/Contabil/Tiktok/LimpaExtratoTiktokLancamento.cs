using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Contabil.Tiktok
{
    public class LimpaExtratoTiktokLancamento
    {
        public async Task<int> Execute()
        {
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    string query = @"
                        DELETE FROM
                            tblExtratoTiktokLancamento
                     ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;

                        int linhasAfetadas = await cmd.ExecuteNonQueryAsync();

                        conexaoBanco.FecharConexao(conn);
                        return linhasAfetadas;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
        }
    }
}
