using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ERP_FISCAL.Repositories.ConsultaSaldoNotasZanup
{
    public class ConsultaSaldoNotasZanupRepositories
    {

        public async Task<DataTable> ConsultaSaldoNotas(int IdProduto,int NumDoc)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpDbsol);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspConsultaSaldoNotasZanup", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // SqlParameter p;
                        if (IdProduto == 0)
                        {
                            cmd.Parameters.AddWithValue("@INintNumNota", NumDoc);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@INintIDProduto", IdProduto);
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
