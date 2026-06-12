using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Contabil.BuscaDadosCalculoCustoProduto
{
    public class BuscaIcmsSt
    {
        public async Task<DataTable> ExecutarAsync(DateTime dataInicio, DateTime dataFim)
        {
            DataTable dt = new DataTable();
            DbConexaoConfig conexao = new DbConexaoConfig(DbName.Totvs);

            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspCustoContabilProduto_BuscaDadosERP_ST", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;
                        cmd.Parameters.AddWithValue("@INdatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataFim", dataFim);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dt.Load(reader);
                        }
                    }
                    conexao.FecharConexao(conn);
                }

            }
            catch (SqlException ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
            return dt;

        }
    }
}
