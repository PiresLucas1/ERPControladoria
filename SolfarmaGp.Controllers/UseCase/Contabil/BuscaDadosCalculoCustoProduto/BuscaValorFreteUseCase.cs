using SolfarmaGp.Repositorios.Contabil.BuscaDadosCalculoCustoProduto;

namespace SolfarmaGp.Controllers.UseCase.Contabil.BuscaDadosCalculoCustoProduto
{
    public class BuscaValorFreteUseCase
    {
        public async Task<string> ExecuteAsync(DateTime dataInicio, DateTime dataFim)
        {
            // Lógica para buscar dados de valor de frete
            BuscaValorFrete repo = new BuscaValorFrete();
            var resultado = await repo.ExecutarAsync(dataInicio, dataFim);
            string mensagem = resultado.Rows[0][0].ToString() ?? "Não obteve retorno";
            return mensagem;
        }   
    }
}
