using SolfarmaGp.Repositorios.Fiscal.ImportarNotasServicoParaTotvs.ConsultaNotasBigNaoEncontradaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarDadosBigTotvs.ConsultaNotasNaoEncontradas
{
    public class ConsultaNotaFiltroUseCase
    {
        public async Task<DataTable> Executar(DateTime dataInicio, DateTime dataFim, int filial, char conferida)
        {
            ConsultaNotasFiltroRepo exportaDadosBigRepositories = new ConsultaNotasFiltroRepo();
            DataTable dataRetorno = await exportaDadosBigRepositories.Executar(dataInicio, dataFim, filial, conferida);

            return dataRetorno;

        }
    }
}
