namespace SolfarmaGp.Controllers.Utils.Parse.FormatarUnidadeMedida
{
    /// <summary>
    /// Converte a unidade comercial do XML (uCom) para o código de unidade cadastrado na TOTVS (tabela TUND).
    /// Cada fornecedor escreve a unidade de um jeito; o de-para evita o erro de chave estrangeira FKTPRDUND_TUND.
    /// </summary>
    public static class FormatarUnidadeMedida
    {
        // De-para: unidade como vem no XML -> CODUND da TOTVS. Para incluir uma nova, adicione uma linha aqui.
        private static readonly Dictionary<string, string> DePara = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "CXA", "CX" },
        };

        public static string Executar(string unidade)
        {
            if (string.IsNullOrWhiteSpace(unidade))
                return unidade;

            string unidadeLimpa = unidade.Trim().ToUpperInvariant();

            return DePara.TryGetValue(unidadeLimpa, out string unidadeTotvs)
                ? unidadeTotvs
                : unidadeLimpa;
        }
    }
}
