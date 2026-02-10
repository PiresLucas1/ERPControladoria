using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultaNaturezaFiscalRepositorio
{
    public class ConsultaNaturezaPorOcorrenciaRepo
    {
        public DataTable Executar(string valor, int codColigada, bool valorEmNumero)
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
                        if (valorEmNumero)
                        {
                            p = new SqlParameter("@INvchIDNatureza", SqlDbType.NVarChar);
                        }
                        else
                        {
                            p = new SqlParameter("@INvchDescricaoNatureza", SqlDbType.NVarChar);
                        }
                        p.Value = valor;
                        cmd.Parameters.Add(p);
                        cmd.Parameters.AddWithValue("@INCodColigada", codColigada);
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
