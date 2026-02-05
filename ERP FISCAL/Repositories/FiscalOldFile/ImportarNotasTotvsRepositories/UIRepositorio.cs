using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Repositories
{
    public interface UIRepositories
    {
         DataTable EncontrarTodos(int codColigada);
         DataTable EncontrarComOcorrencia(string valor, int codColigada);

         DataTable PegaValorPeloCodigo(string valor);


    }
}
