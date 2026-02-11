using Microsoft.Data.SqlClient;
using System.Data;
using SolfarmaGp.Infraestrutura;

namespace SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultarProdutoFiscal.ConsultarProdutoPorId
{
    public class ConsultarProdutoPorId
    {
        public async Task<DataTable> Executar(string valor)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.DfeTotvs);
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadConsultaProdutoIDDescricao", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p = new SqlParameter("@INintIDProduto", SqlDbType.NVarChar);
                        p.Value = valor;
                        cmd.Parameters.Add(p);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabela);
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
