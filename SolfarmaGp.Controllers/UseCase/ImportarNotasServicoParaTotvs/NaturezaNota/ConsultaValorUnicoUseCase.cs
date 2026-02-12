using SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultaNaturezaFiscal.ConsultaNaturezaPorID;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.NaturezaNota
{
    public class ConsultaValorUnicoUseCase
    {
        
        public async Task<DataTable> Executar(string valor)
        {
            ConsultaNaturezaPorID cfops = new ConsultaNaturezaPorID();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.Executar(valor);
            });
            return dataTable;
        }
    }
}
