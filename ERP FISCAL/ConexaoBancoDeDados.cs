using dotenv.net;
using dotenv.net.Utilities;
using System;
using System.Data.SqlClient;


namespace SeuProjeto
{
    public class ConexaoBancoDeDadosDfe
    {
        private readonly string connectionString;

        public ConexaoBancoDeDadosDfe()
        {
            connectionString = "Server=dbtotvs\\dbtotvs;Database=DFE;Integrated Security=True;";
            //connectionString = Environment.GetEnvironmentVariable("CONEXAO_BANCO_DFE");
        }

        public SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                throw;
            }
        }

        public void FecharConexao(SqlConnection conexao)
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada.");
            }
        }
    }

    public class ConexaoBancoDeDadosTOTVS
    {
        private readonly string connectionString;

        public ConexaoBancoDeDadosTOTVS()
        {
            connectionString = "Server=dbtotvs\\dbtotvs;Database=CORPORERM_PRODUCAO;Integrated Security=True;";
            //connectionString = Environment.GetEnvironmentVariable("CONEXAO_BANCO_TOTVS");
        }

        public SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                throw;
            }
        }

        public void FecharConexao(SqlConnection conexao)
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada.");
            }
        }

    }
    public class ConexaoBancoDeDadosGestaoProcessos
    {
        private readonly string connectionString;
        private readonly string connectionStringRm;

        public ConexaoBancoDeDadosGestaoProcessos()
        {
            connectionString = "Server=dbtotvs\\dbtotvs;Database=GestaoProcessos;Integrated Security=True;";
            connectionStringRm = "Server=dbtotvs\\dbtotvs;Database=GestaoProcessos;User Id=rm;Password=rm;Encrypt=True;TrustServerCertificate=True;Connection Timeout=0;";
            //connectionString = Environment.GetEnvironmentVariable("CONEXAO_BANCO_GESTAOPROCESSOS");
            //connectionStringRm = Environment.GetEnvironmentVariable("CONEXAO_BANCO_GESTAOPROCESSOS_RM");
        }
        public string GetConexaoString()
        {
            return connectionString;
        }

        public SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                throw;
            }
        }
        public SqlConnection AbrirConexaoRm()
        {
            SqlConnection conexao = new SqlConnection(connectionStringRm);

            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                throw;
            }
        }

        public void FecharConexao(SqlConnection conexao)
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada.");
            }
        }

    }
    public class ConexaoBancoDeDadosBigCentral
    {
        private readonly string connectionString;

        public ConexaoBancoDeDadosBigCentral()
        {
            connectionString = "Server=dbtotvs\\dbtotvs;Database=BigCentral;Integrated Security=True;";
            //connectionString = Environment.GetEnvironmentVariable("CONEXAO_BANCO_BIGCENTRAL");
        }
        public string GetConexaoString()
        {
            return connectionString;
        }

        public SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                throw;
            }
        }

        public void FecharConexao(SqlConnection conexao)
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada.");
            }
        }

    }

    public class ConexaoBancoDeDadosGestaoProcessosSol
    {
        private readonly string connectionString;
        private readonly string connectionStringRm;

        public ConexaoBancoDeDadosGestaoProcessosSol()
        {
            connectionString = "Server=dbsol\\dbsol;Database=GS300GP;Integrated Security=True;";
            //connectionString = Environment.GetEnvironmentVariable("CONEXAO_BANCO_GESTAOPROCESSOS_SOL");
        }
        public string GetConexaoString()
        {
            return connectionString;
        }

        public SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                throw;
            }
        }
        public SqlConnection AbrirConexaoRm()
        {
            SqlConnection conexao = new SqlConnection(connectionStringRm);

            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                throw;
            }
        }

        public void FecharConexao(SqlConnection conexao)
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada.");
            }
        }

    }

    public class ConexaoBancoDeDadosZanup
    {
        private readonly string connectionString;
        private readonly string connectionStringRm;

        public ConexaoBancoDeDadosZanup()
        {
            connectionString = "Server=dbtotvs\\dbtotvs;Database=Zanup;Integrated Security=True;";
            //connectionString = Environment.GetEnvironmentVariable("CONEXAO_BANCO_ZANUP");
        }
        public string GetConexaoString()
        {
            return connectionString;
        }

        public SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                throw;
            }
        }
        public SqlConnection AbrirConexaoRm()
        {
            SqlConnection conexao = new SqlConnection(connectionStringRm);

            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                throw;
            }
        }

        public void FecharConexao(SqlConnection conexao)
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada.");
            }
        }

    }

}
