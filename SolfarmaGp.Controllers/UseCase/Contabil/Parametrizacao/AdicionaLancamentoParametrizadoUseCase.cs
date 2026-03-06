using SolfarmaGp.Repositorios.Contabil;
using static SolfarmaGp.Repositorios.Contabil.AdicionarLancamentoParametrizado;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao
{
    public class AdicionaLancamentoParametrizadoUseCase
    {       
        public async Task Execute(DtoLancamentoNovo novoLancamento)
        {
            AdicionarLancamentoParametrizado repository = new AdicionarLancamentoParametrizado();
            LancamentoParametrizado lancamento = new LancamentoParametrizado
            {
                IDContaContabilDebito = novoLancamento.IDContaContabilDebito,
                IDContaContabilCredito = novoLancamento.IDContaContabilCredito,
                IDHistorico = novoLancamento.IDHistorico,
                IDComplemento = novoLancamento.IDComplemento,
                DescricaoExtrato = novoLancamento.DescricaoExtrato,
                Filial = novoLancamento.Filial,
                CodColigada = novoLancamento.CodColigada

            };
            await repository.Execute(lancamento);
        }
    }
}
