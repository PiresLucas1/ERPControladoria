using Microsoft.IdentityModel.Tokens;
using SolfarmaGp.Repositorios.Contabil.Parametrizacao.CodigoHistorico;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.CodigoHistorico
{
    
    public class ConsultaCodigoHistorioUseCase
    {

        public async Task<IEnumerable<dtoObjetoComboBoxInteface>>  Execute()
        {
            ConsultaTodosCodigoHistorico repository = new ConsultaTodosCodigoHistorico();
            DataTable dt = await repository.Execute();

            var retorno = dt.AsEnumerable()
                .Select(row => new dtoObjetoComboBoxInteface
                {
                    label = row["IDHistorico"].ToString(),
                    valor = row["CodigoHistorico"].ToString()
                });
            return retorno;
        } 
    }
}
