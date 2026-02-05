using ERP_FISCAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultarProdutoFiscal.ConsultarProdutoPorOcorrencia
{
    public class ConsultarProdutoPorOcorrencia
    {
        public DataTable Consultar(string valor, int codColigada)
        {
            DataTable tabela = new DataTable();
            tabela = tabela.DefaultView.ToTable(true);
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadConsultaProduto", conn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p;
                        p = new SqlParameter("@INintIDProduto", SqlDbType.NVarChar);
                        p.Value = valor;
                        cmd.Parameters.Add(p);
                        cmd.Parameters.AddWithValue("@INCodColigada", codColigada);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            int linhas = adapter.Fill(tabela);

                            if (linhas == 0)
                            {
                                tabela.Clear();
                                cmd.Parameters.Clear();
                                cmd.Parameters.Add(new SqlParameter("@INvchDescricaoProduto", SqlDbType.NVarChar) { Value = valor });
                                cmd.Parameters.AddWithValue("@INCodColigada", codColigada);
                                adapter.Fill(tabela);
                            }
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
