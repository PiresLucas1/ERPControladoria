using SolfarmaGp.Repositorios.Contabil.Parametrizacao;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao
{
    public class AdicionaContaUseCase
    {
        public async void Execute(string valorConta, string planoContas)
        {
            AdicionaConta repository = new AdicionaConta();
            await repository.Executar(valorConta, planoContas);
        }
    }
}
