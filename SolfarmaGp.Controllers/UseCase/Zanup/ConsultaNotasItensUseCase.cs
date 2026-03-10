using ERP_FISCAL.Repositories.ConsultaSaldoNotasZanup;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Zanup
{
    public class ConsultaNotasItensUseCase
    {
        public class DestinatarioDTO
        {
            public string CpfCnpj { get; set; }
            public string Destinatario { get; set; }
            public string InscricaoEstadualDestinatario { get; set; }
            public string NumeroEnderecoDestinatario { get; set; }
            public string BairroEnderecoDestinatario { get; set; }
            public string CepEnderecoDestinatario { get; set; }
            public string NomeMunicipioEnderecoDestinatario { get; set; }
            public string UfEnderecoDestinatario { get; set; }
        }

        public async Task<DataTable> Execute(DateTime dtInicio, DateTime dtFim, string cnpjCpf, int idProduto = 0)
        {


            ConsultaNotaItens consultaNotaItensZanupRepositories = new ConsultaNotaItens();
            DataTable retorno = await consultaNotaItensZanupRepositories.Executar(dtInicio, dtFim, cnpjCpf, idProduto == 0 ? null : idProduto.ToString());

            return retorno;

        }
      
      
    }
}
