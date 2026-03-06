using Microsoft.IdentityModel.Tokens;
using SolfarmaGp.Repositorios.Contabil.Parametrizacao.Complemento;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Complemento
{
    public class ConsultaComplementoUseCase
    {

        public async Task<IEnumerable<dtoObjetoComboBoxInteface>> Execute()
        {
            ConsultaTodosComplemento repository = new ConsultaTodosComplemento();
            DataTable dt = await repository.Execute();

            var retorno = dt.AsEnumerable()
                .Select(row => new dtoObjetoComboBoxInteface
                {
                    valor = row.Field<int>("IDComplemento"),
                    label = row.Field<string>("Descricao").ToString()
                });
 
            return retorno;
        }
    }
}
