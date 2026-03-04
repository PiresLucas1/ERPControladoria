using SolfarmaGp.Repositorios.Contabil.Parametrizacao;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao
{
    public class AdicionaComplementoUseCase
    {
        public async void Execute(string valor)
        {
            AdicionaComplemento repository = new AdicionaComplemento();
            await repository.Executar(valor);
            return;
        }
    }
}
