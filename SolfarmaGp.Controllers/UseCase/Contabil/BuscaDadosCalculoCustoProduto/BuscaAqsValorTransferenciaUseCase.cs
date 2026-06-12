using SolfarmaGp.Repositorios.Contabil.BuscaDadosCalculoCustoProduto;
using System.Threading.Tasks;

namespace SolfarmaGp.Controllers.UseCase.Contabil.BuscaDadosCalculoCustoProduto
{
    public class BuscaAqsValorTransferenciaUsecase
    {
        public async Task<string> ExecuteAsync(DateTime dataInicio, DateTime dataFim)
        {
            BuscaAqsValorTransferencia repo = new BuscaAqsValorTransferencia();
            var resultado = await repo.ExecutarAsync(dataInicio, dataFim);
            string mensagem = resultado.Rows[0][0].ToString() ?? "Não obteve retorno";
            return mensagem;
        }
    }
}
