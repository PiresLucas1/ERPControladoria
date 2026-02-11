using Microsoft.Data.SqlClient;
using System.Data;
using SolfarmaGp.Infraestrutura;

namespace SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultarProdutoFiscal.ConsultarProdutoPorDescricao
{
    public class ConsultarProdutoPorDescricao
    {
        public async Task<DataTable> Executar(string valor)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadConsultaProdutoIDDescricao", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p;
                        p = new SqlParameter("@INvchDescricaoProduto", SqlDbType.NVarChar);
                        p.Value = valor;
                        SqlParameter r = new SqlParameter("@INbitTipoPesquisa", SqlDbType.NVarChar);
                        r.Value = 1;
                        cmd.Parameters.Add(p);
                        cmd.Parameters.Add(r);
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
