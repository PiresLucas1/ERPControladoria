using System.Threading.Tasks;

namespace SolfarmaGp.Controllers.UseCase.Contabil.BuscaDadosCalculoCustoProduto
{
    public class BuscaAqsValorTransferenciaUsecase
    {
        public async Task<string> ExecuteAsync(DateTime dataInicio, DateTime dataFim)
        {
            BuscaAqsValorTransferenciaUsecase repo = new BuscaAqsValorTransferenciaUsecase();
            var resultado = await repo.ExecuteAsync(dataInicio, dataFim);
            return resultado.ToString();
        }
    }
}
