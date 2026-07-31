using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultaProdutoTotvs
    {
        public async Task<DataTable> Executar(int codNoForn)
        {
            DataTable tabela = new DataTable();
            //DataSet dataSet = new DataSet();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);
            SqlConnection conn = null;

            try
            {
                conn = conexaoBanco.AbrirConexao();

                using (var cmd = new SqlCommand(
                    "SELECT * FROM TPRDCFO t WHERE t.CODNOFORN = @CODNOFORN", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@CODNOFORN", SqlDbType.VarChar, 20).Value = codNoForn;

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
