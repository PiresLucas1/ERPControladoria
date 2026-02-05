using SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultarProdutoFiscal.ConsultarProdutoPorId;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ProdutoServico
{
    public class ConsultaPorId
    {
        public async Task<DataTable> Consultar(string valor)
        {
            ConsultarProdutoPorId produtoServico = new ConsultarProdutoPorId();
            DataTable tabelaDados = new DataTable();


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.Consulta(valor);
            });

            return tabelaDados;
        }
    }
}
