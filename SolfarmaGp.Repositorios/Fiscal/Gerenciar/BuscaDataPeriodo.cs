using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.Gerenciar
{
    public class BuscaDataPeriodo
    {
       public async Task<DataTable> Execute()
        {
            DataTable dtRetorno = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    string sql = @"
                        SELECT
                            tbl.DataApuracaoInicio,
                            tbl.DataApuracaoFim,
                            tbl.StatusApuracao
                        FROM tblConfiguracaoPeriodo tbl
                        WHERE tbl.StatusApuracao = 1";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dtRetorno.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return dtRetorno;
        }
    }
}
