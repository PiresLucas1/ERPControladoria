using SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultarProdutoFiscal.ConsultarProdutoPorId;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ProdutoServico
{
    public class ListaProdutoIdUseCase
    {
        public async Task<DataTable> Executar(string valor)
        {
            ConsultarProdutoPorId produtoServico = new ConsultarProdutoPorId();
            DataTable tabelaDados = new DataTable();


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.Executar(valor);
            });

            return tabelaDados;
        }
    }
}
