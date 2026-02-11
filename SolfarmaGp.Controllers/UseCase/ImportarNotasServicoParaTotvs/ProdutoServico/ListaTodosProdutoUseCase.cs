using SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultarProdutoFiscal.ConsultarTodosProdutos;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ProdutoServico
{
    public class ListaTodosProdutoUseCase
    {
        public async Task<DataTable> Executar(int codColigada)
        {

            ConsultarTodosProdutos produtoServico = new ConsultarTodosProdutos();
            DataTable tabelaDados = new DataTable();


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.Executar(codColigada);
            });

            return tabelaDados;
        }
    }
}
