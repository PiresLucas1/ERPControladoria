using SolfarmaGp.Repositorios.Contabil.Tiktok;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Tiktok
{
    public class BuscaExtratoTiktokLancamentoUseCase
    {
        public async Task<DataTable> Execute()
        {
            BuscaExtratoTiktokLancamento repo = new BuscaExtratoTiktokLancamento();
            DataTable result = await repo.Execute();
            return result;
        }
    }
}
