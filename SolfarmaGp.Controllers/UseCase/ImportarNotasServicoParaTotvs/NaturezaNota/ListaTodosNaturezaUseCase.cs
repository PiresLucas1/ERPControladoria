using SolfarmaGp.Controllers.Utils.AjudataDataGrid;
using SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultaNaturezaFiscal.ConsultaTodos;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.NaturezaNota
{
    public class ListaTodosNaturezaUseCase
    {
        public async Task<DataTable> Executar(int codColigada)
        {

            ConsultaTodasNatureza cfops = new ConsultaTodasNatureza();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.Executar(codColigada);
            });
            AjustaDataGridView ajusta = new AjustaDataGridView();
            var resultado = ajusta.AjusteDataGrid(dataTable);
            return resultado.DatatableNatureza;
        }
    }
}
