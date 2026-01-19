using System;
using System.Data.SqlClient;

namespace ERP_FISCAL
{

    public enum DbName
    {
        DfeTotvs,
        Totvs,
        GpTotvs,
        GpWithLoginTotvs,
        BigCentral,
        GpDbsol,
        ZanupTotvs,
        WebPosto,
        GpDbsolWithLogin
    }

    public class DbConexaoConfig
    {
        private readonly string connectionString;

        public DbConexaoConfig(DbName dbConexao)
        {
            switch (dbConexao)
            {
                case DbName.DfeTotvs:
                    connectionString = "Server=dbtotvs\\dbtotvs;Database=DFE;Integrated Security=True;";
                    break;

                case DbName.Totvs:
                    connectionString = "Server=dbtotvs\\dbtotvs;Database=CORPORERM_PRODUCAO;Integrated Security=True;";
                    break;

                case DbName.GpTotvs:
                    connectionString = "Server=dbtotvs\\dbtotvs;Database=GestaoProcessos;Integrated Security=True;";
                    break;

                case DbName.GpWithLoginTotvs:
                    connectionString = "Server=dbtotvs\\dbtotvs;Database=GestaoProcessos;User Id=rm;Password=rm;Encrypt=True;TrustServerCertificate=True;Connection Timeout=0;";
                    break;

                case DbName.BigCentral:
                    connectionString = "Server=dbtotvs\\dbtotvs;Database=BigCentral;Integrated Security=True;";
                    break;

                case DbName.GpDbsol:
                    connectionString = "Server=dbsol\\dbsol;Database=GS300GP;Integrated Security=True;";
                    break;

                case DbName.ZanupTotvs:
                    connectionString = "Server=dbtotvs\\dbtotvs;Database=Zanup;User Id=rm;Password=rm;Encrypt=True;TrustServerCertificate=True;Connection Timeout=0;";
                    break;

                case DbName.WebPosto:
                    connectionString = "Server=dbtotvs\\dbtotvs;Database=PostoLago_WebPosto;User Id=rm;Password=rm;Encrypt=True;TrustServerCertificate=True;Connection Timeout=0;";
                    break;

                case DbName.GpDbsolWithLogin:
                    connectionString = "Server=dbsol\\dbsol;Database=GS300GP;User Id=rm;Password=rm;Integrated Security=True;";
                    break;

                default:
                    throw new ArgumentException("Banco de dados inválido.");
            }
        }

        public SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }

        public void FecharConexao(SqlConnection conexao)
        {
            if (conexao?.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
