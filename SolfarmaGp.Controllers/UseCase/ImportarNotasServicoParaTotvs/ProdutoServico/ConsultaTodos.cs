using SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultarProdutoFiscal.ConsultarTodosProdutos;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ProdutoServico
{
    public class ConsultaTodos
    {
        public async Task<DataTable> Consultar(int codColigada)
        {

            ConsultarTodosProdutos produtoServico = new ConsultarTodosProdutos();
            DataTable tabelaDados = new DataTable();


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.Consultar(codColigada);
            });

            return tabelaDados;
        }
    }
}
