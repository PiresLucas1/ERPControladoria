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
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.TotvsTeste);
            SqlConnection conn = null;

            try
            {
                conn = conexaoBanco.AbrirConexao();

                using (var cmd = new SqlCommand(
                   @"SELECT
	                    produto.CODCFO,
	                    produto.CODNOFORN 
                    FROM 
	                    TPRDCFO produto WITH(NOLOCK) 
                    LEFT JOIN
	                    FCFO fornecedor WITH(NOLOCK) ON fornecedor.CODCFO = produto.CODCFO
                    WHERE 
	                    fornecedor.CGCCFO = @CGCCFO and 
	                    produto.CODNOFORN = @CODNOFORN 
	                    AND produto.CODCOLIGADA = 2", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@CODNOFORN", SqlDbType.VarChar, 20).Value = codNoForn;
                    cmd.Parameters.Add("@CGCCFO", SqlDbType.VarChar, 14).Value = cnpjFornecedor;

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        tabela.Load(reader);
                    }
                }

                return tabela;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
            finally
            {
                if (conn != null)
                    conexaoBanco.FecharConexao(conn);
            }
        }
    }
}
