using ERP_FISCAL.Models;
using ERP_FISCAL.Utils;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static ERP_FISCAL.Utils.ControleNotasCriadaBling;

namespace ERP_FISCAL.service
{
    
    public class BlingService
    {
        public string urlBlingApiDev = "https://developer.bling.com.br/api/bling/nfse";
        public string urlBlingApiProd = "https://api.bling.com.br/Api/v3/nfe";
        public async Task<HttpResponseMessage> CriarNotaAsync(NotaFiscal data)
        {
            GetToken obterTokenAsync = new GetToken();
            string token = await obterTokenAsync.ObterTokenAsync();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            string json = JsonConvert.SerializeObject(data);
            //MessageBox.Show(json, "Dados enviados para criação da nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(urlBlingApiProd, content);
            int contadorDeTentativasDeConexao = 0;
            if((int)response.StatusCode == 429)
            {
                while (contadorDeTentativasDeConexao < 5)
                {                                        
                 await Task.Delay(7000);
                 response = await httpClient.PostAsync("https://api.bling.com.br/Api/v3/nfe", content);                   
                }
            }
        
            var retorno = await response.Content.ReadAsStringAsync();
            

            if (!response.IsSuccessStatusCode)
            {
                string errorBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Erro: {(int)response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception($"Erro na requisição: {(int)response.StatusCode} - {errorBody}");                                
            }

            var body = await response.Content.ReadAsStringAsync();


            Console.WriteLine(JsonConvert.DeserializeObject<RootObject>(body));
            RootObject bodyToObject = JsonConvert.DeserializeObject<RootObject>(body);
           

            Console.WriteLine(body);
            JsonParaDadoTabela nota = new JsonParaDadoTabela()
            {
                id = Convert.ToInt64(bodyToObject.data.id),
                numero = bodyToObject.data.numero,
                serie = bodyToObject.data.serie,
                contato = bodyToObject.data.contato.nome

            };

            new ControleNotasCriadaBling().AdicionarNotaCriada(nota);


            return response;
            
        }

        public async Task<NotaFiscal> ConsultarNotaAsync()
        {
            GetToken obterTokenAsync = new GetToken();

            string token = await obterTokenAsync.ObterTokenAsync();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var response = await httpClient.GetAsync($"https://api.bling.com.br/Api/v3/nfe?pagina=1&limite=1&tipo=1&serie=5");

            while((int)response.StatusCode == 429)
            {
              await Task.Delay(7000);
                response = await httpClient.GetAsync($"https://api.bling.com.br/Api/v3/nfe?pagina=1&limite=1&tipo=1&serie=5");
            }        
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Erro: {(int)response.StatusCode} - {response.ReasonPhrase}");
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();
            Console.Write("twste");
            var data = JsonConvert.DeserializeObject<Root>(json);
            var notaFiscal = data.Data.FirstOrDefault();
            await Task.Delay(7000);

            return notaFiscal;
        }
    }
}
