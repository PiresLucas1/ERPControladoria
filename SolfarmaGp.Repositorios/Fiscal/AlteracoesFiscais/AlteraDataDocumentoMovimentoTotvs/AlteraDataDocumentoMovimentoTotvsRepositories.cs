using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;


namespace SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.AlteraDataDocumentoMovimentoTotvs
{
    public class AlteraDataDocumentoMovimentoTotvsRepositories
    {
     
        public async Task<DataTable> Executar(DataTable dtIdMovs)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspFisAlteraDataDocumentoTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        var param = cmd.Parameters.AddWithValue("@tblIDMovsNovaData", dtIdMovs);
                        param.SqlDbType = SqlDbType.Structured;
                        param.TypeName = "dbo.IDMovimentoParaTrocarData";

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
