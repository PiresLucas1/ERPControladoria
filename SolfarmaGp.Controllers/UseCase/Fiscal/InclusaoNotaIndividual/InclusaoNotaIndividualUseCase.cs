using SolfarmaGp.Repositorios.Fiscal.InclusaoNotaIndividuak;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.InclusaoNotaIndividual
{
    public class InclusaoNotaIndividualUseCase
    {
        public async Task<(DataTable,string, bool)> Execute(string notas, DateTime dtInicio, DateTime dtFim)
        {

            InclusaoNotaIndividualRepo repo = new InclusaoNotaIndividualRepo();
            var (dtResult, mensagemRetorno) = await repo.Execute(notas, dtInicio, dtFim);
            Console.Write(dtResult);

            if(mensagemRetorno.Contains("EXPORTAÇÃO DOS DADOS FINALIZADO COM SUCESSO!"))
            {
                return (dtResult, mensagemRetorno, true);
            }
            else
            {
                return (dtResult, mensagemRetorno, false);
            }
        }
    }
}
