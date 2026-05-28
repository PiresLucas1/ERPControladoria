using SolfarmaGp.Repositorios.Contabil.BuscaDadosCalculoCustoProduto;

namespace SolfarmaGp.Controllers.UseCase.Contabil.BuscaDadosCalculoCustoProduto
{
    public class BuscaIcmsStUseCase
    {
        public async Task<string> ExecuteAsync(DateTime dataInicio, DateTime dataFim)
        {
            // Lógica para buscar dados de ICMS ST
            BuscaIcmsSt repo = new BuscaIcmsSt();
            var resultado = await repo.ExecutarAsync(dataInicio, dataFim);
            return resultado.ToString();
        }
    }
}
