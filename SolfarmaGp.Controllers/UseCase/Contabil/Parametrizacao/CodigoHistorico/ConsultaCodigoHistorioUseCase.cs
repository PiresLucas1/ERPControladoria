using Microsoft.IdentityModel.Tokens;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dto;
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
                    valor = row.Field<int>("IDHistorico"),
                    label = row.Field<string>("CodigoHistorico")
                })
                .ToList();
            return retorno;
        } 
    }
}
