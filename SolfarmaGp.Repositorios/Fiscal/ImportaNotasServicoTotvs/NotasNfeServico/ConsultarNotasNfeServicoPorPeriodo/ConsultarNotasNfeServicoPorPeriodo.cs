using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportaNotasServicoTotvs.ConsultaNotasNfeServico.ConsultarNotasNfeServicoPorPeriodo
{
    public class ConsultarNotasNfeServicoPorPeriodo
    {
        public async Task<DataTable> Executar(DateTime dataInicio, DateTime dataFim, int codColigada, int bitExisteErp)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {

                using (SqlConnection conexao = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisConsultarNfeServico", conexao))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 1200; /* 20 minutos */
                        cmd.Parameters.AddWithValue("@INDatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INDatDataFim", dataFim);
                        cmd.Parameters.AddWithValue("@INCodColigada", codColigada);
                        cmd.Parameters.AddWithValue("@INTBitConstaNoErp", bitExisteErp);


                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabela);
                    }

                    conexaoBanco.FecharConexao(conexao);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);                
                throw new ArgumentException("Falha ao executar a operação", e);

            }

            return tabela;
        }
    }
}
