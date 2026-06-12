using SolfarmaGp.Repositorios.Contabil.BuscaDadosCalculoCustoProduto;

namespace SolfarmaGp.Controllers.UseCase.Contabil.BuscaDadosCalculoCustoProduto
{
    public class BuscaReembolsoSaidaUseCase
    {
        public async Task<string> ExecuteAsync(DateTime dataInicio, DateTime dataFim)
        {
            // Lógica para buscar dados de reembolso de saída
            BuscaReembolsoSaida repo = new BuscaReembolsoSaida();
            var resultado = await repo.ExecutarAsync(dataInicio, dataFim);
            string mensagem = resultado.Rows[0][0].ToString() ?? "Não obteve retorno";
            return mensagem;
        }   
    }
}
