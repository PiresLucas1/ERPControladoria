using SolfarmaGp.Repositorios.Fiscal.InclusaoNotaIndividuak;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.InclusaoNotaIndividual
{
    public class InclusaoNotaIndividualUseCase
    {
        public async Task<(DataTable,DataTable)> Execute(string notas, DateTime dtInicio, DateTime dtFim)
        {

            InclusaoNotaIndividualRepo repo = new InclusaoNotaIndividualRepo();
            var restultado = await repo.Execute(notas, dtInicio, dtFim);
            return restultado;
        }
    }
}
