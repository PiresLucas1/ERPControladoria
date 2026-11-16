using SolfarmaGp.Repositorios.Fiscal.BaseCheia;

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
