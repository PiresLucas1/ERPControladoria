using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultaProdutoTotvs
    {
        public async Task<DataTable> Executar(string codNoForn, string cnpjFornecedor)
        {
            DataTable tabela = new DataTable();
            //DataSet dataSet = new DataSet();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);            

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisConsultaProdutoForncedorTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INvchCnpjForncedor", cnpjFornecedor);
                        cmd.Parameters.AddWithValue("@INvchCodProdutoForncedor", codNoForn);
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
