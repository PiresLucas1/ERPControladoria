using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultaNotasUseCase
    {
        // Tipo de pesquisa da procedure: 1 = padrão, 2 = filtra pela data de lançamento do ERP
        private const int TipoPesquisaPadrao = 1;
        private const int TipoPesquisaDataLancamentoErp = 2;

        public async Task<DataTable> Execute(DateTime dataInicio, DateTime dataFim, bool porDataLancamentoErp = false)
        {
            int tipoPesquisa = porDataLancamentoErp ? TipoPesquisaDataLancamentoErp : TipoPesquisaPadrao;

            ConsultarNotasUsoConsumoGP repositorio = new ConsultarNotasUsoConsumoGP();
            DataTable result = await repositorio.Executar(dataInicio, dataFim, tipoPesquisa);
            return result;
        }
    }
}
