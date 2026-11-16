using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.BaseCheia
{
    public class AlteracaoBaseCheia
    {
        public async Task<bool> Execute(DateTime dataInicio, DateTime dataFim)
        {
            DataTable dtRetorno = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspFisArrumaBaseCheiaTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INdtDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdtDataFim", dataFim);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dtRetorno.Load(reader);
                        }
                    }
                    conexaoBanco.FecharConexao(conn);
                }

                return true;
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("Erro ao Recalcular: " + ex.Message, ex);
            }
        }
    }
}
