using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Contabil.Parametrizacao.Conta
{
    public class AdicionaConta()
    {
        public async Task<DataTable> Executar(string valorCodigo, string planoContas)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspContabilConferenciaRecebimentosCadastraContaContabil", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        var param1 = cmd.Parameters.AddWithValue("@INvchCodigo", valorCodigo);
                        var param2 = cmd.Parameters.AddWithValue("@INvchDescricaoConta", DBNull.Value);
                        var param3 = cmd.Parameters.AddWithValue("@INvchPlanoContas", planoContas);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }
                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
            return tabela;
        }
    }
}
