using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultaNotasUseCase
    {
        public async Task<DataTable> Execute(DateTime dataInicio, DateTime dataFim)
        {
            ConsultarNotas repositorio = new ConsultarNotas();
            DataTable result = await repositorio.Executar(dataInicio, dataFim);
            return result;
        }
    }
}
