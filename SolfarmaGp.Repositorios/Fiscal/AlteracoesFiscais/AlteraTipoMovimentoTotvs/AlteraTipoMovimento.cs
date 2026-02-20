using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.AlteraTipoMovimentoTotvs
{
    public class AlteraTipoMovimento
    {
        public async Task<DataTable> Executar(int codMovimento, int coligada, string codTmovimento)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadAlteraCodMovimentoTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //SqlParameter p;
                        cmd.Parameters.AddWithValue("@INintIDMov", codMovimento);
                        cmd.Parameters.AddWithValue("@INintCodColigada", coligada);
                        cmd.Parameters.AddWithValue("@INvchCodTmv", codTmovimento);

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
