using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_FISCAL.Repositories;

namespace ERP_FISCAL.Controller
{
    internal class ProdutoServicoController: UIController
    {
        public async Task<DataTable> CarregaTodos() {

            ProdutoServicoRepositories produtoServico = new ProdutoServicoRepositories();
            DataTable tabelaDados = new DataTable();


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.EncontrarTodos();
            });

            return tabelaDados;
        }
        public async Task<DataTable> CarregaComOcorrencia(string valor)
        {
            ProdutoServicoRepositories produtoServico = new ProdutoServicoRepositories();
            DataTable tabelaDados = new DataTable();


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.EncontrarComOcorrencia(valor);
            });

            return tabelaDados;
        }

    }
}
