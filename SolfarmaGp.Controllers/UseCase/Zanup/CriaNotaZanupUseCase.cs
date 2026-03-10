using SolfarmaGp.Repositorios.Zanup;
using SolfarmaGp.Services.Zanup;
using SolfarmaGp.Services.Zanup.Bling;
using SolfarmaGp.Services.Zanup.Bling.CriaNotaDinamica;
using System.Data;
using static SolfarmaGp.Controllers.UseCase.Zanup.ConsultaNotasItensUseCase;

namespace SolfarmaGp.Controllers.UseCase.Zanup
{
    internal class CriaNotaZanupUseCase
    {
        public async Task Execute(List<NotaProdutoDTO> listaNotas)
        {
            ConsultaInformacoesCnpjCpfUseCase consultaDestinatario = new ConsultaInformacoesCnpjCpfUseCase();
            foreach (NotaProdutoDTO item in listaNotas)
            {
                string valorCnpjCpf = item.CnpjCpf = item.CnpjCpf.Replace(".", "").Replace("/", "").Replace("-", "");
                DataTable retorno = await consultaDestinatario.Execute(valorCnpjCpf);
                DestinatarioDTO destinatarioDTO = new DestinatarioDTO();



                foreach (DataRow row in retorno.Rows)
                {
                    destinatarioDTO.CpfCnpj = row["CPF/CNPJ"]?.ToString();
                    destinatarioDTO.Destinatario = row["Nome Destinatario"]?.ToString();
                    destinatarioDTO.InscricaoEstadualDestinatario = row["InscricaoEstaudalDestinatario"]?.ToString();
                    destinatarioDTO.NumeroEnderecoDestinatario = row["NumeroEnderecoDestinatario"]?.ToString();
                    destinatarioDTO.BairroEnderecoDestinatario = row["BairroEnderecoDestinatario"]?.ToString();
                    destinatarioDTO.CepEnderecoDestinatario = row["CEPEnderecoDestinatario"]?.ToString();
                    destinatarioDTO.NomeMunicipioEnderecoDestinatario = row["NomeMunicipioEnderecoDestinatario"]?.ToString();
                    destinatarioDTO.UfEnderecoDestinatario = row["UFEnderecoDestinatario"]?.ToString();
                }

                item.CpfCnpj = destinatarioDTO.CpfCnpj;
                item.Destinatario = destinatarioDTO.Destinatario;
                item.InscricaoEstadualDestinatario = destinatarioDTO.InscricaoEstadualDestinatario;
                item.NumeroEnderecoDestinatario = destinatarioDTO.NumeroEnderecoDestinatario;
                item.BairroEnderecoDestinatario = destinatarioDTO.BairroEnderecoDestinatario;
                item.CepEnderecoDestinatario = destinatarioDTO.CepEnderecoDestinatario;
                item.NomeMunicipioEnderecoDestinatario = destinatarioDTO.NomeMunicipioEnderecoDestinatario;
                item.UfEnderecoDestinatario = destinatarioDTO.UfEnderecoDestinatario;

                PegaTokenApiBling pegaToken = new PegaTokenApiBling();
                var token = await pegaToken.Execute();
                if(token == null)
                {
                    throw new Exception($"Não foi possivel Gerar Token");
                }

                HttpResponseMessage response = await new CriaNotaServiceBling().Execute(item, token);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Erro ao criar nota para o produto {item.Produto} da nota {item.NumeroNota}. Status Code: {response.StatusCode}");
                }
            }

        }
    }
}
