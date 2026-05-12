using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolfarmaGp.UI.Utils
{
    public static class RemoveAcentos
    {
        public static string Remover(string texto)
        {
            var normalizado = texto.Normalize(System.Text.NormalizationForm.FormD);

            var chars = normalizado
                .Where(c => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c)
                    != System.Globalization.UnicodeCategory.NonSpacingMark)
                .ToArray();

            return new string(chars).Normalize(System.Text.NormalizationForm.FormC);
        }
    }
}
