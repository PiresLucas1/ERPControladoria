using SolfarmaGp.Infraestrutura;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultaNaturezaFiscal.ConsultaNaturezaPorID
{
    public class ConsultaNaturezaPorID
    {
        public async Task<DataTable> Executar(string valor)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisConsultaNaturezaFiscal", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p;
                        p = new SqlParameter("@INvchIDNatureza", SqlDbType.NVarChar);
                        p.Value = valor;
                        cmd.Parameters.Add(p);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabela);
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
