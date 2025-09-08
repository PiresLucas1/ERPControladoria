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
        public DataTable EncontrarTodos()
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosDfe conexaoBanco = new ConexaoBancoDeDadosDfe();
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspConsultaProduto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable EncontrarComOcorrencia(string valor)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosDfe conexaoBanco = new ConexaoBancoDeDadosDfe();
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspConsultaProduto", conn))
                    {
                        
                        
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p;
                        p = new SqlParameter("@INintIDProduto", SqlDbType.NVarChar);
                        p.Value = valor;
                        cmd.Parameters.Add(p);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                        int linhas = adapter.Fill(tabela);

                            if(linhas > 0)
                                adapter.Fill(tabela);
                            else
                            {

                                cmd.Parameters.Clear();
                                cmd.Parameters.Add(new SqlParameter("@INvchDescricaoProduto", SqlDbType.NVarChar) { Value= valor });
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
