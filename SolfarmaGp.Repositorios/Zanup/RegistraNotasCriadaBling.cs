using Microsoft.Data.SqlClient;
using SolfarmaGp.Communication.Zanup.Bling;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Zanup
{
    public class RegistraNotasCriadaBling
    {
        public async Task<DataTable> Execute(ControleNotasCriadas.JsonParaDadoTabela nota)
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
