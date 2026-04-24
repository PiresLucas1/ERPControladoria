using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultarNotas
    {
        public async Task<DataTable> Executar(DateTime dataInicio, DateTime dataFim)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspUsuConsultarContasPagarParcelaGP", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;                        
                        cmd.Parameters.AddWithValue("@INdatDataLancamentoInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataLancamentoFim", dataFim);                       
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
