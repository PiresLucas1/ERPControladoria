using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    public class ConsultaNaturezaEntradaTotvsUseCase
    {
        // Vazio: lista todas | com letras: pesquisa pela descrição | só números e pontos: pesquisa pelo código
        public async Task<DataTable> Executar(int codColigada, string valor = null)
        {
            string texto = valor?.Trim();
            bool pesquisaPorDescricao = !string.IsNullOrEmpty(texto) && texto.Any(char.IsLetter);

            return await new ConsultaNaturezaEntradaTotvs().Executar(
                codColigada,
                pesquisaPorDescricao ? null : texto,
                pesquisaPorDescricao ? texto : null);
        }
    }
}
