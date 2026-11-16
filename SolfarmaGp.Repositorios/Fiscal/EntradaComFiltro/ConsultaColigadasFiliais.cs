using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.EntradasComFiltro
{
    /// <summary>Uma filial cadastrada no Totvs (GFILIAL).</summary>
    public class FilialColigada
    {
        public int Coligada { get; set; }
        public int Filial { get; set; }
        public string Nome { get; set; } = "";
    }

    /// <summary>Lista as coligadas/filiais que existem de fato, para validar o filtro antes da consulta pesada.</summary>
    public class ConsultaColigadasFiliais
    {
        public async Task<List<FilialColigada>> ExecutarAsync()
        {
            var lista = new List<FilialColigada>();
            DbConexaoConfig conexao = new DbConexaoConfig(DbName.Totvs);

            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT CODCOLIGADA, CODFILIAL, NOMEFANTASIA FROM GFILIAL (NOLOCK) ORDER BY CODCOLIGADA, CODFILIAL",
                        conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 60;

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                lista.Add(new FilialColigada
                                {
                                    Coligada = Convert.ToInt32(reader["CODCOLIGADA"]),
                                    Filial = Convert.ToInt32(reader["CODFILIAL"]),
                                    Nome = reader["NOMEFANTASIA"]?.ToString()?.Trim() ?? ""
                                });
                            }
                        }
                    }
                    conexao.FecharConexao(conn);
                }
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return lista;
        }
    }
}
