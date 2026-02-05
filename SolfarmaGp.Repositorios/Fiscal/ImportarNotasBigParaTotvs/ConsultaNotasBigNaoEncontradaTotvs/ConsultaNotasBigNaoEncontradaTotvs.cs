using ERP_FISCAL;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasServicoParaTotvs.ConsultaNotasBigNaoEncontradaTotvs
{
    public class ConsultaNotasBigNaoEncontradaTotvs
    {
        public async Task<DataTable> Consulta(DateTime dataInicio, DateTime dataFim, int filial, char conferida)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.DfeTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspConsultaNotasBigNaoEncontradasTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //SqlParameter p;
                        cmd.Parameters.AddWithValue("@INdatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataFim", dataFim);
                        if (filial == 0)
                        {
                            cmd.Parameters.AddWithValue("@INintFilial", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@INintFilial", filial);
                        }
                        cmd.Parameters.AddWithValue("@INchaNaoConferida", conferida);
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
