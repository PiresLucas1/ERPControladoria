using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_FISCAL.Repositories;

namespace ERP_FISCAL.Controller
{
    internal class ProdutoServicoController
    {
        public async Task<DataTable> CarregaProdutoServicoController() {

            ProdutoServicoRepositories produtoServico = new ProdutoServicoRepositories();
            DataTable tabelaDados = new DataTable();


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.CarregaProdutoServico();
            });

            return tabelaDados;
        }
    }
}
