using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeuProjeto;

namespace ERP_FISCAL.Repositories
{
    internal class ProdutoServicoRepositories: UIRepositories
    {
        public DataTable EncontrarTodos(int codColigada)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosGestaoProcessos conexaoBanco = new ConexaoBancoDeDadosGestaoProcessos();
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadConsultaProduto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INCodColigada", codColigada);
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
        public DataTable EncontrarComOcorrencia(string valor, int codColigada)
        {
            DataTable tabela = new DataTable();
            tabela = tabela.DefaultView.ToTable(true);
            ConexaoBancoDeDadosGestaoProcessos conexaoBanco = new ConexaoBancoDeDadosGestaoProcessos();
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

        public DataTable PegaValorPeloCodigo(string valor)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosDfe conexaoBanco = new ConexaoBancoDeDadosDfe();
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
        public DataTable PegaValorPelaDescricao(string valor)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosDfe conexaoBanco = new ConexaoBancoDeDadosDfe();
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
