namespace SolfarmaGp.Controllers.Utils.Parse.FormatarDataDigitada
{
    public class FormatarData
    {
        public string Executar(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return string.Empty;

            valor = valor.Trim();

            // Caso já esteja no formato dd/MM/yyyy e seja válido
            if (DateTime.TryParse(valor, out DateTime dataFormatada))
                return dataFormatada.ToString("dd/MM/yyyy");

            // Remove tudo que não for número
            string somenteNumeros = new string(valor.Where(char.IsDigit).ToArray());

            if (somenteNumeros.Length == 8)
            {
                // ddMMyyyy → exemplo: 01092025
                string dia = somenteNumeros.Substring(0, 2);
                string mes = somenteNumeros.Substring(2, 2);
                string ano = somenteNumeros.Substring(4, 4);
                valor = $"{dia}/{mes}/{ano}";
            }
            else if (somenteNumeros.Length == 7)
            {
                // dMMyyyy → exemplo: 1092025 → 01/09/2025
                string dia = "0" + somenteNumeros.Substring(0, 1);
                string mes = somenteNumeros.Substring(1, 2);
                string ano = somenteNumeros.Substring(3, 4);
                valor = $"{dia}/{mes}/{ano}";
            }
            else if (somenteNumeros.Length == 6)
            {
                // ddMMyy → tenta corrigir ano
                string dia = somenteNumeros.Substring(0, 2);
                string mes = somenteNumeros.Substring(2, 2);
                string ano = "20" + somenteNumeros.Substring(4, 2);
                valor = $"{dia}/{mes}/{ano}";
            }

            // Tenta converter novamente
            if (DateTime.TryParse(valor, out DateTime data))
                return data.ToString("dd/MM/yyyy");

            return string.Empty; // Retorna vazio se não for possível formatar
        }
    }
}
