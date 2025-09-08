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
         DataTable EncontrarTodos();
         DataTable EncontrarComOcorrencia(string valor);


    }
}
