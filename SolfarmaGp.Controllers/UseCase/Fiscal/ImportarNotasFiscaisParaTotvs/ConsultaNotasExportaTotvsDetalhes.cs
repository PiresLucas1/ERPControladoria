using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultaNotasExportaTotvsDetalhes
    {
        public async Task<DataTable>Executar(int IDQiveArquivoXML)
        {
            ConsultaNotasExportaDetalhes repo = new ConsultaNotasExportaDetalhes();
            DataTable dtRetorno = await repo.Executar(IDQiveArquivoXML);

            
            return dtRetorno;
        }
    }
}
