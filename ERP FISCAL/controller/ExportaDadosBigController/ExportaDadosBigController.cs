using ERP_FISCAL.Repositories.ExportaDadosBigRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Controller.ExportaDadosBigController
{
    internal class ExportaDadosBigController
    {
        public async Task<DataTable> BuscaNotasDoBigNaoEncontradoNaTotvs(DateTime dataInicio, DateTime dataFim, int filial, char conferida)
        {
            ExportaDadosBigRepositories exportaDadosBigRepositories = new ExportaDadosBigRepositories();
            DataTable dataRetorno = await exportaDadosBigRepositories.BuscaNotasDoBigNaoEncontradoNaTotvs(dataInicio, dataFim, filial, conferida);

            return dataRetorno;

        }
    }
}
