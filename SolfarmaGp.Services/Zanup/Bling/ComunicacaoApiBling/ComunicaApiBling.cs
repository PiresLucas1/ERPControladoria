using Newtonsoft.Json;
using SolfarmaGp.Communication.Zanup.Bling;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using static SolfarmaGp.Communication.Zanup.Bling.ControleNotasCriadas;
using static SolfarmaGp.Services.Zanup.Bling.DtoNotaFiscalBling;

namespace SolfarmaGp.Services.Zanup.Bling.ComunicacaoApiBling
{
    public class ComunicaApiBling
    {
        public string urlBlingApiDev = "https://developer.bling.com.br/api/bling/nfse";
        public string urlBlingApiProd = "https://api.bling.com.br/Api/v3/nfe";
        public async Task<HttpResponseMessage> Execute(NotaFiscal data, string token)
        {


            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            string json = JsonConvert.SerializeObject(data);
            //MessageBox.Show(json, "Dados enviados para criação da nota", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(urlBlingApiProd, content);
            int contadorDeTentativasDeConexao = 0;
            if ((int)response.StatusCode == 429)
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

            new ControleNotasCriadas().AdicionarNotaCriada(nota);


            return response;

        }
    }
}

