using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultaNotasExportaTotvsDetalhes
    {
        public async Task<(DataTable, DataTable)> Executar(int IDQiveArquivoXML)
        {
            ConsultaNotasExportaDetalhes repo = new ConsultaNotasExportaDetalhes();
            DataSet dataSetRetorno = await repo.Executar(IDQiveArquivoXML);
            DataTable dtNotaItens = dataSetRetorno.Tables[0];
            DataTable dtNotaContaFinanceira = dataSetRetorno.Tables[1];



            return (dtNotaItens, dtNotaContaFinanceira);
        }
    }
}
