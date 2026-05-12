using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolfarmaGp.UI.Utils
{
    public class NormalizaTextoComparacao
    {
        public static string Normalizar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            texto = RemoveAcentos.Remover(texto);

            texto = texto
                .Replace('\u00A0', ' ') // espaço invisível comum do Excel
                .Replace("\r", " ")
                .Replace("\n", " ")
                .Trim()
                .ToUpperInvariant();

            while (texto.Contains("  "))
                texto = texto.Replace("  ", " ");

            return texto;
        }
    }
}
