using SolfarmaGp.Repositorios.Contabil.Tiktok;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Tiktok
{
    public class LimpaExtratoTiktokLancamentoUseCase
    {
        public async Task<int> Execute()
        {
            LimpaExtratoTiktokLancamento repo = new LimpaExtratoTiktokLancamento();
            int linhasAfetadas = await repo.Execute();
            return linhasAfetadas;
        }
    }
}
