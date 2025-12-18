using SeuProjeto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Repositories.ExportarXmlRepositories
{
    public class ExportarXmlRepositorio
    {
        public async Task<DataTable> ExportaXmlPostoLago(DateTime dataInicio, DateTime dataFim, string localExportacao, string modeloDocumento, int exportarTudo)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.WebPosto);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspExportarArquivoXML", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //SqlParameter p;
                        cmd.Parameters.AddWithValue("@INdatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataFim", dataFim);
                        cmd.Parameters.AddWithValue("@INvchLocal", localExportacao);
                        cmd.Parameters.AddWithValue("@INModeloDocumento", modeloDocumento);
                        cmd.Parameters.AddWithValue("@INbitExportarTudo", exportarTudo);
                        cmd.Parameters.AddWithValue("@INbitExibeLog", 0);

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
