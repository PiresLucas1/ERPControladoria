using System.Data;
using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;

namespace ERP_FISCAL.Repositories.ExportarXmlRepositories
{
    public class ImportaXmlWebPosto
    {
        public async Task<DataTable> Executar(DateTime dataInicio, DateTime dataFim, string localExportacao, string modeloDocumento, int exportarTudo, IProgress<string> progress = null)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.WebPosto);            

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    conn.FireInfoMessageEventOnUserErrors = true;
                    conn.InfoMessage += (s, e) =>
                    {
                        foreach (SqlError err in e.Errors)
                            progress?.Report(err.Message);
                        // aqui seria onde vai atualizar a mensagem;
                    };
                    using (SqlCommand cmd = new SqlCommand("dbo.uspExportarArquivoXML", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;
                        //SqlParameter p;
                        cmd.Parameters.AddWithValue("@INdatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataFim", dataFim);
                        cmd.Parameters.AddWithValue("@INvchLocal", localExportacao);
                        if(modeloDocumento == "")
                        {
                            cmd.Parameters.AddWithValue("@INModeloDocumento", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@INModeloDocumento", modeloDocumento);
                        }
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
