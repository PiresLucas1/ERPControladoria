using SolfarmaGp.Repositorios.Contabil.Parametrizacao;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao
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
