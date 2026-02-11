using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;
using static SolfarmaGp.Repositorios.Zanup.Interfaces.ControleNotaBling;

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

        public async Task<DataTable> RegistraNotasCriadasNoBlink(JsonParaDadoTabela nota)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspRegistraNotasCriadasNoSistemaGP", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // SqlParameter p;
                        cmd.Parameters.AddWithValue("@intIdNota", nota.id);
                        cmd.Parameters.AddWithValue("@intNumDocumento", nota.numero);
                        cmd.Parameters.AddWithValue("@vchSerie", nota.serie);
                        cmd.Parameters.AddWithValue("@vchContato", nota.contato);
                        

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
