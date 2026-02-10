using Microsoft.Data.SqlClient;
using System.Data;
using SolfarmaGp.Infraestrutura;

namespace SolfarmaGp.Repositorios.Fiscal.ImportaNotasServicoTotvs.ConsultaNotasNfeServico.ConsultarNotasNfeServicoPorNumero
{
    public class ConsultarNotasNfeServicoPorNumero
    {
        public DataTable Executar(string noteId)
        {
            DataTable table = new DataTable();
           DbConexaoConfig connectionDataBase = new DbConexaoConfig(DbName.DfeTotvs);

            using (SqlConnection conn = connectionDataBase.AbrirConexao())
            {
                using (SqlCommand cmd = new SqlCommand("uspQiveProcuraNotaIndividual", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@INvchrChaveDeAcesso", noteId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }

                connectionDataBase.FecharConexao(conn);
            }
            return table;
        }
    }
}
