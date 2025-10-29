using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ERP_FISCAL.Repositories.ConsultaSaldoNotasZanup;
using System.Threading.Tasks;

namespace ERP_FISCAL.Controller.ConsultaSaldoNotasZanup
{
    public class ConsultaSaldoNotasZanupController
    {
        public async Task <DataTable> ConsultaSaldoNotas(int IDProduto) 
        {
            ConsultaSaldoNotasZanupRepositories consultaSaldoNotas = new ConsultaSaldoNotasZanupRepositories();
            DataTable retorno = await consultaSaldoNotas.ConsultaSaldoNotas(IDProduto);
            return retorno;
        }
    }
}
