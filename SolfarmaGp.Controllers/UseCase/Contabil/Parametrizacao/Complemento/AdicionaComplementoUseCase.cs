using SolfarmaGp.Repositorios.Contabil.Parametrizacao.Complemento;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Complemento
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
