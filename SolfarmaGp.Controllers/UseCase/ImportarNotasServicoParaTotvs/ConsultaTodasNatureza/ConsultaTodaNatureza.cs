using System.Data;
using SolfarmaGp.Controllers.Utils.AjudataDataGrid;
using SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultaNaturezaFiscal.ConsultaTodos;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ConsultaTodasNaturezaConsultaTodasNatureza
{
    public class ConsultaTodaNatureza
    {
        public async Task<DataTable> Executar(int codColigada)
        {

            ConsultaTodasNatureza cfops = new ConsultaTodasNatureza();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.Consultar(codColigada);
            });
            AjustaDataGridView ajusta = new AjustaDataGridView();
            var resultado = ajusta.AjusteDataGrid(dataTable);
            return resultado.DatatableNatureza;
        }
    }
}
