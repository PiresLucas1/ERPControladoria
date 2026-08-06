using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultaProdutoTotvsResultado
    {
        public bool Encontrado { get; set; }
        public int? CodCfo { get; set; }
        public string CodNoFornecedor { get; set; }
    }

    public class ConsultaProdutoTotvsUseCase
    {
        public async Task<ConsultaProdutoTotvsResultado> Executar(string codNoForn,string cnpjFornecedor )
        {
            var consultaProdutoTotvs = new ConsultaProdutoTotvs();
            DataTable resultado = await consultaProdutoTotvs.Executar(codNoForn, FormatarCnpj(cnpjFornecedor));

            if (resultado.Rows.Count == 0)
            {
                return new ConsultaProdutoTotvsResultado { Encontrado = false };
            }

            DataRow linha = resultado.Rows[0];

            return new ConsultaProdutoTotvsResultado
            {
                Encontrado = true,
                CodCfo = linha["CODCFO"] != DBNull.Value ? Convert.ToInt32(linha["CODCFO"]) : null,
                CodNoFornecedor = linha["CODNOFORN"] != DBNull.Value ? linha["CODNOFORN"].ToString() : null
            };
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
