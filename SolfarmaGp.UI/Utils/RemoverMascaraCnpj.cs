using System.Text.RegularExpressions;

/// <summary>
/// Remove todos os caracteres não numéricos de uma string.
/// Útil para recuperar o valor "limpo" de campos mascarados (CNPJ, CPF, telefone, CEP, etc).
/// </summary>
/// <param name="textoComMascara">Texto formatado com máscara (ex: "12.345.678/0001-95")</param>
/// <returns>Somente os dígitos (ex: "12345678000195")</returns>
namespace SolfarmaGp.UI.Utils
{
    public class RemoverMascaraCnpj
    {
        public static string RemoverMascara(string textoComMascara)
        {
            if (string.IsNullOrEmpty(textoComMascara))
                return string.Empty;

            return Regex.Replace(textoComMascara, @"[^\d]", "");
        }
    }
}
