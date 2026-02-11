using SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultarProdutoFiscal.ConsultarProdutoPorOcorrencia;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ProdutoServico
{
    public class ListaProdutoFiltroUseCase
    {
        public async Task<DataTable> Executar(string valor, int codColigada)
        {
            ConsultarProdutoPorOcorrencia produtoServico = new ConsultarProdutoPorOcorrencia();
            DataTable tabelaDados = new DataTable();
            tabelaDados = tabelaDados.DefaultView.ToTable(true);


            tabelaDados = await Task.Run(() =>
            {
                return produtoServico.Consultar(valor, codColigada);
            });

            return tabelaDados;
        }
    }
}
