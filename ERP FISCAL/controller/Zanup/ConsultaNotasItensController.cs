using ERP_FISCAL.Repositories.ConsultaSaldoNotasZanup;
using ERP_FISCAL.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.Controller.ConsultaSaldoNotasFiscais
{
    public class ConsultaNotasZanupItemController
    {
        public async Task<DataTable> ConsultaNotasZanupItem(DateTime dtInicio, DateTime dtFim, string cnpjCpf, int idProduto = 0)
        {
            

            ConsultaNotaItensZanupRepositories consultaNotaItensZanupRepositories = new ConsultaNotaItensZanupRepositories();
            DataTable retorno = await consultaNotaItensZanupRepositories.ConsultaNotaItens(dtInicio, dtFim, cnpjCpf, idProduto == 0 ? null : idProduto.ToString());
            
            return retorno;
            
        }
        //public void CriaNotaZanup(List<NotaProdutoDTO> listaNotas)
        //{


        //}
    }
}
