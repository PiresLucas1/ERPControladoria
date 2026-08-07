using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class CadastrarProdutoTotvs
    {
        public async Task<DataTable> Executar(string codProduto ,string descricao, string ncm, string cest, string codUnidade, decimal preco, string origem, string cnpjFornecedor)
        {
            DataTable dataTable = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisCriaNovoProdutoTotvsGP", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
                        cmd.Parameters.AddWithValue("@NCM", ncm);                        
                        if (cest != null)
                        {
                            cmd.Parameters.AddWithValue("@CEST", cest);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@CEST", DBNull.Value);
                        }                        
                        cmd.Parameters.AddWithValue("@CODUND", codUnidade);
                        cmd.Parameters.AddWithValue("@PRECO", preco);
                        cmd.Parameters.AddWithValue("@ORIGEM", origem);
                        cmd.Parameters.AddWithValue("@CNPJFORNECEDOR", cnpjFornecedor);
                        cmd.Parameters.AddWithValue("@CODIGOPRD_FORNECEDOR", codProduto);
                        
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
