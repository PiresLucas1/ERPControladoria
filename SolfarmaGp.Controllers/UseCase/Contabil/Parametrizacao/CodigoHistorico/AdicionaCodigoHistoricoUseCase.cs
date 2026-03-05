using SolfarmaGp.Repositorios.Contabil.Parametrizacao.CodigoHistorico;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.CodigoHistorico
{
    public class AdicionaCodigoHistoricoUseCase
    {
        public async void Execute(string valor)
        {
            AdicionaCodigoHistorico repository = new AdicionaCodigoHistorico();
            await repository.Executar(valor);
            return;
        }
    }
}
