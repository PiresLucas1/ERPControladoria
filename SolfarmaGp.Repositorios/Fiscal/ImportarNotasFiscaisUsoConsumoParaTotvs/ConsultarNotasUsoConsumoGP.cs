using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultarNotasUsoConsumoGP
    {
        public async Task<DataTable> Executar(DateTime dataInicio, DateTime dataFim, int tipoPesquisa)
        {
            DataTable tabela = new DataTable();
            //DataSet dataSet = new DataSet();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisConsultarContasPagarParcelaGP", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;                        
                        cmd.Parameters.AddWithValue("@INdatDataLancamentoInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataLancamentoFim", dataFim);
                        cmd.Parameters.Add("@INtipoPesquisa", SqlDbType.Int).Value = tipoPesquisa;
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
