namespace SolfarmaGp.UI.Utils
{
    /// <summary>
    /// Máscara da Natureza Fiscal (CFOP da TOTVS) no formato x.xxx.xxx, aplicada enquanto o usuário digita.
    /// Se o texto tiver letras, é uma pesquisa por nome e fica sem máscara.
    /// </summary>
    public static class MascaraNatureza
    {
        private const int MaxDigitos = 7;

        public static string Formatar(string texto)
        {
            if (string.IsNullOrEmpty(texto) || texto.Any(char.IsLetter))
                return texto;

            string digitos = new string(texto.Where(char.IsDigit).Take(MaxDigitos).ToArray());

            if (digitos.Length <= 1)
                return digitos;
            if (digitos.Length <= 4)
                return digitos[0] + "." + digitos.Substring(1);

            return digitos[0] + "." + digitos.Substring(1, 3) + "." + digitos.Substring(4);
        }

        public static void Aplicar(TextBox textBox)
        {
            textBox.TextChanged -= TextBox_TextChanged;
            textBox.TextChanged += TextBox_TextChanged;
        }

        public static void Remover(TextBox textBox)
        {
            textBox.TextChanged -= TextBox_TextChanged;
        }

        private static void TextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            string formatado = Formatar(textBox.Text);
            if (formatado == textBox.Text)
                return;

            textBox.Text = formatado;
            textBox.SelectionStart = formatado.Length;
        }
    }
}
