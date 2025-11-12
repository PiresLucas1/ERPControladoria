using SeuProjeto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Repositories.SegCadastroRepositories
{
    public class SegCadastroRepositories
    {
        public async Task<DataTable> ListaDadosPorNome(string nomeUsuario)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosGestaoProcessos conexaoBanco = new ConexaoBancoDeDadosGestaoProcessos();
            string stringDeConexao = conexaoBanco.GetConexaoString();
            try
            {
                using (SqlConnection conn = new SqlConnection(stringDeConexao)) // <<< apenas cria
                {
                    await conn.OpenAsync(); // <<< abre uma vez aqui

                    using (SqlCommand cmd = new SqlCommand("dbo.uspSegConsultarUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INvchNomeUsuario", nomeUsuario);                        
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return tabela;
        }

        public async Task<DataTable> ListaDadosPorPerfil(string nomeUsuario)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosGestaoProcessos conexaoBanco = new ConexaoBancoDeDadosGestaoProcessos();
            string stringDeConexao = conexaoBanco.GetConexaoString();
            try
            {
                using (SqlConnection conn = new SqlConnection(stringDeConexao)) // <<< apenas cria
                {
                    await conn.OpenAsync(); // <<< abre uma vez aqui

                    using (SqlCommand cmd = new SqlCommand("dbo.uspSegConsultarUsuarioPerfil", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INvchUsuarioPerfil", nomeUsuario);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return tabela;
        }

        public async Task<DataTable> ListaDadosPorMenu(string nomeUsuario)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosGestaoProcessos conexaoBanco = new ConexaoBancoDeDadosGestaoProcessos();
            string stringDeConexao = conexaoBanco.GetConexaoString();
            try
            {
                using (SqlConnection conn = new SqlConnection(stringDeConexao)) // <<< apenas cria
                {
                    await conn.OpenAsync(); // <<< abre uma vez aqui

                    using (SqlCommand cmd = new SqlCommand("dbo.uspSegConsultarMenu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INvchNomeMenu", nomeUsuario);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return tabela;
        }
        public async Task<DataTable> InserirPerfil(string nomePerfil)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosGestaoProcessos conexaoBanco = new ConexaoBancoDeDadosGestaoProcessos();
            string stringDeConexao = conexaoBanco.GetConexaoString();
            try
            {
                using (SqlConnection conn = new SqlConnection(stringDeConexao)) // <<< apenas cria
                {
                    await conn.OpenAsync(); // <<< abre uma vez aqui

                    using (SqlCommand cmd = new SqlCommand("dbo.uspSegInserirUsuarioPerfil", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INvchNomePerfil", nomePerfil);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return tabela;
        }   
        public async Task<DataTable> InserirMenu(string nomeMenu, string nomeAplicacao)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosGestaoProcessos conexaoBanco = new ConexaoBancoDeDadosGestaoProcessos();
            string stringDeConexao = conexaoBanco.GetConexaoString();
            try
            {
                using (SqlConnection conn = new SqlConnection(stringDeConexao)) // <<< apenas cria
                {
                    await conn.OpenAsync(); // <<< abre uma vez aqui

                    using (SqlCommand cmd = new SqlCommand("dbo.uspSegInserirMenu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INvchNomeMenu", nomeMenu);
                        cmd.Parameters.AddWithValue("@INvchAplicacao", nomeMenu);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);

                throw;
            }            
            return tabela;
        }
    }


    
}
