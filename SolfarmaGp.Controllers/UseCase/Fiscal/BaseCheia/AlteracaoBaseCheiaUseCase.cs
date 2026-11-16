using SolfarmaGp.Repositorios.Fiscal.BaseCheia;
using SolfarmaGp.Services.Zanup.Bling;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.BaseCheia
{
    public class AlteracaoBaseCheiaUseCase
    {
        public async Task<bool> Executar(DateTime DataInicio, DateTime DataFim)
        {
            AlteracaoBaseCheia repositorio = new AlteracaoBaseCheia();

            var retorno = await repositorio.Execute(DataInicio, DataFim);

            return retorno;
        }
    }
}
