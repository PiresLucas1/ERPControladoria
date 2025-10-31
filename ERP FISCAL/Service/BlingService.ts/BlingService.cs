using ERP_FISCAL.Models;

using ERP_FISCAL.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.service
{
    public class BlingService
    {
        public async Task<string> CriarNotaAsync(NotaFiscal data)
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

            var response = await httpClient.PostAsync("https://api.bling.com.br/Api/v3/nfe", content);
            var retorno = await response.Content.ReadAsStringAsync();

            return $"Status: {(int)response.StatusCode} - {response.StatusCode}\r\n{retorno}";
        }

        public async Task<NotaFiscal> ConsultarNotaAsync()
        {
            GetToken obterTokenAsync = new GetToken();

            string token = await obterTokenAsync.ObterTokenAsync();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var response = await httpClient.GetAsync($"https://api.bling.com.br/Api/v3/nfe?pagina=1&limite=1&tipo=1");

            while((int)response.StatusCode == 429)
            {
              await Task.Delay(7000);
                response = await httpClient.GetAsync($"https://api.bling.com.br/Api/v3/nfe?pagina=1&limite=1&tipo=1");
            }        
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Erro: {(int)response.StatusCode} - {response.ReasonPhrase}");
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();
            var notaFiscal = JsonConvert.DeserializeObject<NotaFiscal>(json);
            await Task.Delay(7000);

            return notaFiscal;
        }
    }
}
