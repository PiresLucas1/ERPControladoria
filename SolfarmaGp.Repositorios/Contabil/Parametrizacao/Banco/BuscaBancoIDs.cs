using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Contabil.Parametrizacao.Banco
{
    public class BuscaBancoIDs
    {
        public async Task<DataTable> Execute()
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.BigCentral);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    string query = @"
                SELECT
                    tblBanco.bancos_id
                FROM
                    tblBancosContas tblBanco (NOLOCK)
                WHERE
                    tblBanco.bancos_id IS NOT NULL
                    AND tblBanco.bancos_id <> ''";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
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
