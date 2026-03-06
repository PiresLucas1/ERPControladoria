using Microsoft.IdentityModel.Tokens;
using SolfarmaGp.Repositorios.Contabil.Parametrizacao.Conta;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Conta
{
    public class ConsultaContaUseCase
    {

        public async Task<IEnumerable<dtoObjetoComboBoxInteface>> Execute()
        {
            ConsultaTodosContasContabeis repository = new ConsultaTodosContasContabeis();
            DataTable dt = await repository.Execute();

            var retorno = dt.AsEnumerable()
                .Select(row => new dtoObjetoComboBoxInteface
                {
                    valor = row.Field<int>("IDContaContabil"),
                    label = row.Field<string>("CodigoConta").ToString()
                });
            return retorno;
        }
    }
}
