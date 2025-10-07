using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Controller
{
    public interface UIController
    {
        Task<DataTable> CarregaTodos(int codColigada);
        Task<DataTable> CarregaComOcorrencia(string valor, int codColigada);
        Task<DataTable> PegaValorUnicoPeloCodigo(string valor);

    }
}
