using ERP_FISCAL;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.AlteraTipoMovimentoTotvs
{
    public class ALteraTipoMovimentoEmLista
    {
        public async Task<DataTable> AlteraTipoMovimentoEmBloco(int codMovimento, int coligada, string codTmovimento)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadAlteraEmBlocoCodMovimentoTotvsTESTE", conn))
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
