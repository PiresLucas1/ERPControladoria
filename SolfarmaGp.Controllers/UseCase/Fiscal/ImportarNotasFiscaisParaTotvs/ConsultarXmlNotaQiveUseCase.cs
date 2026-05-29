using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultarXmlNotaQiveUseCase
    {
        public async Task<string> Executar(int IDQiveArquivoXML)
        {
            try
            {
                var consulta = new ConsultarXmlNotaQive();
                var resultado = await consulta.Executar(IDQiveArquivoXML);

                string xmlConteudo = resultado.Rows[0][0].ToString();
                return xmlConteudo;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
        }
    }
}
