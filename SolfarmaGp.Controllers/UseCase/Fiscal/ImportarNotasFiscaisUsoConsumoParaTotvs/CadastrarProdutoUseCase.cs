using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class CadastrarProdutoUseCase
    {
        public async Task<DataTable> Executar(string codProduto, string descricao, string ncm, string cest, string codUnidade, decimal preco, string origem, string cnpjFornecedor, string codFornecedor)
        {
            CadastrarProdutoTotvs repo = new CadastrarProdutoTotvs();
            return await repo.Executar(codProduto, descricao, ncm, cest, codUnidade, preco, origem, cnpjFornecedor, codFornecedor);
        }
        public static string FormatarCnpj(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj))
                return cnpj;

            // Remove tudo que não for dígito (pontos, barras, espaços, letras etc.)
            string apenasNumeros = new string(cnpj.Where(char.IsDigit).ToArray());

            // Garante 14 dígitos, preenchendo com zeros à esquerda se necessário
            apenasNumeros = apenasNumeros.PadLeft(14, '0');

            if (apenasNumeros.Length != 14)
                return cnpj; // não é um CNPJ válido em quantidade de dígitos, retorna original

            return Convert.ToUInt64(apenasNumeros).ToString(@"00\.000\.000\/0000-00");
        }
    }
}
