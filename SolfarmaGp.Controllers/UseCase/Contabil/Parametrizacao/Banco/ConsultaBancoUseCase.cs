using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dto;
using SolfarmaGp.Repositorios.Contabil.Parametrizacao.Banco;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Banco
{
    public class ConsultaBancoUseCase
    {
        public async Task<IEnumerable<dtoObjetoComboBoxInteface>> Execute()
        {
            ConsultaTodosBanco repository = new ConsultaTodosBanco();
            DataTable dt = await repository.Execute();

            var retorno = dt.AsEnumerable()
                .Select(row => new dtoObjetoComboBoxInteface
                {
                    valor = row.Field<int>("IDBanco"),
                    label = !string.IsNullOrWhiteSpace(row.Field<string>("NomeBanco"))
                        ? row.Field<string>("NomeBanco").Trim()
                        : row.Field<int>("IDBanco").ToString()
                });

            return retorno;
        }
    }
}
