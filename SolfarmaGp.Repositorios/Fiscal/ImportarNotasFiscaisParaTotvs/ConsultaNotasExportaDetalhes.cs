using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultaNotasExportaDetalhes
    {
        public async Task<DataSet> Executar(int IDQiveArquivoXML)
        {
            DataSet dataSet = new DataSet();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisConsultaItensNotaQive", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDQiveArquivoXML", IDQiveArquivoXML);                        
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {

                            // Carrega a primeira tabela
                            DataTable tabela1 = new DataTable();
                            tabela1.Load(reader);
                            dataSet.Tables.Add(tabela1);

                            // Avança para o próximo result set e carrega a segunda tabela
                            if (!reader.IsClosed)
                            {
                                DataTable tabela2 = new DataTable();
                                tabela2.Load(reader);
                                dataSet.Tables.Add(tabela2);
                            }
                        }
                    }

                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }


            return dataSet;
        }
    }
}
