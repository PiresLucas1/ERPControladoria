using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.AlteraTipoMovimentoTotvs
{
    public class ALteraTipoMovimentoEmLista
    {
        public async Task<DataTable> Executar(DataTable data)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisAlteraTipoMovimento", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TMP", data);
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
