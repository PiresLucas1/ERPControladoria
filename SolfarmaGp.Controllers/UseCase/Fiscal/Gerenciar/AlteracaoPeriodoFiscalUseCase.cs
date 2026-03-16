using SolfarmaGp.Repositorios.Fiscal.Gerenciar;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.Gerenciar
{
    public class AlteracaoPeriodoFiscalUseCase
    {
        public async Task<bool> Execute(DateTime dataInicio, DateTime dataFim, bool statusApuracao, string usuario)
        {
            AlteracaoPeriodoFiscal repo = new AlteracaoPeriodoFiscal();
            var retorno = await repo.Execute(dataInicio,dataFim,statusApuracao,usuario);

            return retorno;
        }
    }
}
