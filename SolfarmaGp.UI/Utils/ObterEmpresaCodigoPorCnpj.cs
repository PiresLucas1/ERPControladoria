using System.Text.RegularExpressions;

namespace SolfarmaGp.UI.Utils
{
    public class ObterEmpresaCodigoPorCnpj
    {
        public static string executar(string cnpj)
        {
            // Remove a máscara para garantir comparação correta, independente do formato recebido
            string cnpjLimpo = Regex.Replace(cnpj ?? string.Empty, @"[^\d]", "");

            switch (cnpjLimpo)
            {
                case "05371150000125":
                    return "6828"; // POSTO DO LAGO BEBEDOURO LTDA

                case "05371150000206":
                    return "6829"; // POSTO DO LAGO BEBEDOURO LTDA

                case "05371150000397":
                    return "6830"; // POSTO DO LAGO BEBEDOURO LTDA

                case "05371150000478":
                    return "6939"; // POSTO DO LAGO BEBEDOURO LTDA

                case "17340307000134":
                    return "48561"; // POSTO DO LAGO UNIDADE RUBIAO JUNIOR

                case "48196353000135":
                    return "48562"; // CONVENIENCIA BEBEDOURO LTDA

                case "05453630000135":      
                    return "48563"; // CONVENIENCIA DO LAGO BEBEDOURO LTDA

                default:
                    return "0"  ; // Não encontrado
            }
        }
    }
}
