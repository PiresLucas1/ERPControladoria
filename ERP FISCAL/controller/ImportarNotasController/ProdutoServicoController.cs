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
        public async Task<DataTable> CarregaTodos(int codColigada) {

            ProdutoServicoRepositories produtoServico = new ProdutoServicoRepositories();
            DataTable tabelaDados = new DataTable();


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.EncontrarTodos(codColigada);
            });

            return tabelaDados;
        }
        public async Task<DataTable> CarregaComOcorrencia(string valor, int codColigada)
        {
            ProdutoServicoRepositories produtoServico = new ProdutoServicoRepositories();
            DataTable tabelaDados = new DataTable();
            tabelaDados = tabelaDados.DefaultView.ToTable(true);


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.EncontrarComOcorrencia(valor, codColigada);
            });

            return tabelaDados;
        }

        public async Task<DataTable> PegaValorUnicoPeloCodigo(string valor)
        {
            ProdutoServicoRepositories produtoServico = new ProdutoServicoRepositories();
            DataTable tabelaDados = new DataTable();


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.PegaValorPeloCodigo(valor);
            });

            return tabelaDados;
        }
    }
}
