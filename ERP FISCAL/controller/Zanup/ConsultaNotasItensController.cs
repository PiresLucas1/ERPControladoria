using ERP_FISCAL.Repositories.ConsultaSaldoNotasZanup;
using ERP_FISCAL.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.Controller.ConsultaSaldoNotasFiscais
{
    public class ConsultaNotasZanupItemController
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

        public async Task<DataTable> ConsultaNotasZanupItem(DateTime dtInicio, DateTime dtFim, string cnpjCpf, int idProduto = 0)
        {
            

            ConsultaNotaItensZanupRepositories consultaNotaItensZanupRepositories = new ConsultaNotaItensZanupRepositories();
            DataTable retorno = await consultaNotaItensZanupRepositories.ConsultaNotaItens(dtInicio, dtFim, cnpjCpf, idProduto == 0 ? null : idProduto.ToString());
            
            return retorno;
            
        }
        public async Task CriaNotaZanup(List<NotaProdutoDTO> listaNotas)
        {
            ConsultaNotaItensZanupRepositories consultaNotaItensZanupRepositories = new ConsultaNotaItensZanupRepositories();
            foreach (NotaProdutoDTO item in listaNotas)
            {            
                string valorCnpjCpf = item.CnpjCpf = item.CnpjCpf.Replace(".", "").Replace("/", "").Replace("-", "");
                DataTable retorno = await BuscaInformacoesCnpjCpf(valorCnpjCpf);
                DestinatarioDTO destinatarioDTO = new DestinatarioDTO();



                foreach (DataRow row in retorno.Rows)
                {
                    destinatarioDTO.CpfCnpj = row["CPF/CNPJ"]?.ToString();
                    destinatarioDTO.Destinatario = row["Nome Destinatario"]?.ToString();
                    destinatarioDTO.InscricaoEstadualDestinatario = row["InscricaoEstaudalDestinatario"]?.ToString();
                    destinatarioDTO.NumeroEnderecoDestinatario = row["NumeroEnderecoDestinatario"]?.ToString();
                    destinatarioDTO.BairroEnderecoDestinatario =row["BairroEnderecoDestinatario"]?.ToString();
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


                HttpResponseMessage response = await consultaNotaItensZanupRepositories.CriaNotasItensZanup(item);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Erro ao criar nota para o produto {item.Produto} da nota {item.NumeroNota}. Status Code: {response.StatusCode}");
                    return;
                }
            }    

        }
        public async Task<DataTable> BuscaInformacoesCnpjCpf(string valor)
        {
            ConsultaNotaItensZanupRepositories consultaNotaItensZanupRepositories = new ConsultaNotaItensZanupRepositories();
            DataTable retorno = await consultaNotaItensZanupRepositories.BuscaInformacoesCnpjZanup(valor);

            return retorno;

        }

    }
}
