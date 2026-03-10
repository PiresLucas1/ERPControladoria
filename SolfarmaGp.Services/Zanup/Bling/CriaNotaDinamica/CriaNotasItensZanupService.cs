namespace SolfarmaGp.Services.Zanup.Bling.CriaNotaDinamica
{
    public class CriaNotasItensZanupService
    {
        public async Task<HttpResponseMessage> Execute(NotaProdutoDTO novaNota, string token)
        {
            CriaNotaServiceBling criarNotaBling = new CriaNotaServiceBling();
            HttpResponseMessage response = await criarNotaBling.Execute(novaNota, token);

            return response;


        }
    }
}
