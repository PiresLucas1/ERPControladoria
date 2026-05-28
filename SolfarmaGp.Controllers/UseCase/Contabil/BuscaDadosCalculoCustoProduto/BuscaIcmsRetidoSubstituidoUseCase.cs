using SolfarmaGp.Repositorios.Contabil.BuscaDadosCalculoCustoProduto;

namespace SolfarmaGp.Controllers.UseCase.Contabil.BuscaDadosCalculoCustoProduto
{
    public class BuscaIcmsRetidoSubstituidoUseCase
    {
        public async Task<string> ExecuteAsync(DateTime dataInicio, DateTime dataFim)
        {
            // Lógica para buscar dados de ICMS retido e substituído
            BuscaIcmsRetidoSubstituido repo = new BuscaIcmsRetidoSubstituido();
            var resultado = await repo.ExecutarAsync(dataInicio, dataFim);
            return resultado.ToString();
        }
    }
}
