using ERP_FISCAL.Repositories.ExportarXmlRepositories;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportaXml.WebPostoXml
{
    public class ImportaXmlPostoUseCase
    {
        public async Task<DataTable> ExportaXmlPostoLago(DateTime dataInicio, DateTime dataFim, string localExportacao, string modeloDocumento, int exportarTudo, Progress<string> valor = null)
        {
            ImportaXmlWebPosto exportarXmlRepositorio = new ImportaXmlWebPosto();
            DataTable retorno = new DataTable();
            retorno = await exportarXmlRepositorio.Executar(dataInicio, dataFim, localExportacao, modeloDocumento, exportarTudo, valor);

            return retorno;

        }
    }
}
