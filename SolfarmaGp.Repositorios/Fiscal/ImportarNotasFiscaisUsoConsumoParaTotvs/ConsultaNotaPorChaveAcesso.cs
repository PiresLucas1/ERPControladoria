using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    public class ConsultaNotaPorChaveAcesso
    {
        public async Task<DataTable> Executar(string chaveAcesso)
        {
            DataTable dataTable = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisConsultaDocumentoPorChaveAcesso", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INvchChaveAcesso", chaveAcesso);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {

                            DataTable tabela1 = new DataTable();
                            tabela1.Load(reader);
                            dataTable = tabela1;
                        }
                    }

                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }


            return dataTable;
        }
    }
}
