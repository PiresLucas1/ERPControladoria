using ERP_FISCAL;
using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.TiposDeConsultas.ConsultaMovTotvsTrocaTipoMovimento
{
    public class ConsultaMovTotvsTrocaTipoMovimento
    {
        public async Task<DataTable> Executar(int codMovimento, int coligada)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadConsultaIDMovTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // SqlParameter p;
                        cmd.Parameters.AddWithValue("@INintIDMOV", codMovimento);
                        if (coligada == 0)
                        {
                            cmd.Parameters.AddWithValue("@INintCodColigada", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@INintCodColigada", coligada);
                        }
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


            return tabela;
        }
    }
}
