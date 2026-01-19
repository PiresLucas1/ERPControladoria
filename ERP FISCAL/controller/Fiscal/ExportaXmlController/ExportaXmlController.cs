using ERP_FISCAL.Repositories.ExportarXmlRepositories;
using System;
using System.Data;


using System.Threading.Tasks;

namespace ERP_FISCAL.Controller.ExportaXmlController
{
    public class ExportaXmlController
    {
        public async Task<DataTable> ExportaXmlPostoLago(DateTime dataInicio, DateTime dataFim, string localExportacao, string modeloDocumento, int exportarTudo, Progress<string> valor)
        {
            ExportarXmlRepositorio exportarXmlRepositorio = new ExportarXmlRepositorio();
            DataTable retorno = new DataTable();
            retorno = await exportarXmlRepositorio.ExportaXmlPostoLago(dataInicio,dataFim,localExportacao,modeloDocumento,exportarTudo, valor);

            return retorno;

        }
    }
}
