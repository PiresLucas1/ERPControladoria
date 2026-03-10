using SolfarmaGp.Repositorios.Contabil.Parametrizacao;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao
{
    public class AlteraLancamentoParametrizadoUseCase
    {
        public async Task<Boolean> Execute(DataTable dt, string user)
        {
            var result = await new AlteraLancamentoParametrizado().Execute(dt, user);            
            return result;
        }
    }
}
