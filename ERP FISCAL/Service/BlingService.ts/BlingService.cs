using ERP_FISCAL.Service.BlingService.ts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.service
{
    public class BlingService
    {
        public async Task<string> CriarNotaAsync(IDtoBlingNotaFiscal data)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", "c2b04a69023cd88cf12d6f188581f9f64414cebb");


            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("https://api.bling.com.br/Api/v3/nfe", content);
            var retorno = await response.Content.ReadAsStringAsync();

            return $"Status: {(int)response.StatusCode} - {response.StatusCode}\r\n{retorno}";
        }
    }
}
