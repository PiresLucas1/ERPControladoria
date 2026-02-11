using ERP_FISCAL;
using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.ConsultaMovTotvsTrocaTipoMovimento
{
    public class ConsultaMultiMovTotvsTrocaMovimento
    {
        public async Task<DataTable> Consulta(string codMovimento, int coligada)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadConsultaMultiplosIDMovTotvs", conn))
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
