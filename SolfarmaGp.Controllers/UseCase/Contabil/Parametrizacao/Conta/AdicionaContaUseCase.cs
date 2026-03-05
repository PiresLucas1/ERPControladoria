using SolfarmaGp.Repositorios.Contabil.Parametrizacao.Conta;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Conta
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
