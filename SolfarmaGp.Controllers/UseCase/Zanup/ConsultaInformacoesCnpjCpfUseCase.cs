using SolfarmaGp.Repositorios.Zanup;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Zanup
{
    public class ConsultaInformacoesCnpjCpfUseCase
    {
        public async Task<DataTable> Execute(string valor)
        {
            ConsultaCnpjOutrasInformacoes consultaNotaItensZanupRepositories = new ConsultaCnpjOutrasInformacoes();
            DataTable retorno = await consultaNotaItensZanupRepositories.Execute(valor);

            return retorno;

        }
    }
}
