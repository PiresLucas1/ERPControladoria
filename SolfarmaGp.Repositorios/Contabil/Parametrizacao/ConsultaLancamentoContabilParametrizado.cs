using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Contabil.Parametrizacao
{
    public class ConsultaLancamentoContabilParametrizado
    {
        public async Task<DataTable> Execute()
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspContabilConferenciaRecebimentosLancamentosParametrizados", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INchCodigoContaDebito", DBNull.Value);
                        cmd.Parameters.AddWithValue("@INchCodigoContaCredito", DBNull.Value);
                        cmd.Parameters.AddWithValue("@INchCodigoHistorico", DBNull.Value);
                        cmd.Parameters.AddWithValue("@INvchDescricaoComplemento", DBNull.Value);
                        cmd.Parameters.AddWithValue("@INvchDescricaoExtrato", DBNull.Value);
                        cmd.Parameters.AddWithValue("@INintFilial", DBNull.Value);
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
