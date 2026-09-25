using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    public class ConsultaCodCfoFornecedorPorCnpjUseCase
    {
        public async Task<string> Executar(string cnpjFornecedor)
        {
            if (string.IsNullOrWhiteSpace(cnpjFornecedor))
                return null;

            // A consulta compara o CNPJ sem pontuação, então envia apenas os dígitos
            string cnpjSomenteNumeros = new string(cnpjFornecedor.Where(char.IsDigit).ToArray()).PadLeft(14, '0');

            return await new ConsultaCodCfoFornecedorPorCnpj().Executar(cnpjSomenteNumeros);
        }
    }
}
