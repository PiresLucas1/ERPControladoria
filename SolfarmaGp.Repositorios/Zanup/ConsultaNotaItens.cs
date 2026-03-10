using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace ERP_FISCAL.Repositories.ConsultaSaldoNotasZanup
{
    public class ConsultaNotaItens
    {
        public async Task<DataTable> Executar(DateTime dataInicio, DateTime dataFim,string cnpjCpf ,string idProduto = null)
        {
            //uspZanConsultaNotaItens
            DataTable dataTable = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using(SqlCommand cmd = new SqlCommand("dbo.uspZanConsultaNotaItens", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@INdatDataEmissaoInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataEmissaoFim", dataFim);
                        if(cnpjCpf != null)
                            cmd.Parameters.AddWithValue("@INvchCnpjCpf", cnpjCpf);
                        else                       
                            cmd.Parameters.AddWithValue("@INvchCnpjCpf", DBNull.Value);
                        
                        if (idProduto != null)                        
                            cmd.Parameters.AddWithValue("@INintIdProduto", idProduto);
                        
                        
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dataTable.Load(reader);
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
