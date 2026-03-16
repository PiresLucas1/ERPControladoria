using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.Gerenciar
{
    public class AlteracaoPeriodoFiscal
    {
        public async Task<bool> Execute(DateTime dataInicio, DateTime dataFim, bool statusApuracao, string usuario)
        {
            DataTable dtRetorno = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspFisGerencialAlteraDataApuracao", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DataApuracaoInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@DataApuracaoFim", dataFim);
                        cmd.Parameters.AddWithValue("@StatusApuracao", statusApuracao);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dtRetorno.Load(reader);
                        }
                    }
                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (SqlException ex) 
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
            return true;
        }
    }
}
