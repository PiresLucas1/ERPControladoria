using SolfarmaGp.Repositorios.Contabil.Parametrizacao;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao
{
    public class AdicionaParametroResumidoUseCase
    {
        public async Task<bool> Execute(DataTable dt, string user)
        {
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dt.Rows[i];

                bool possuiCampoEmBranco =                    
                    row.IsNull("CodContaDebito") ||
                    row.IsNull("CodContaCredito") ||
                    row.IsNull("CodHistorico") ||
                    row.IsNull("Complemento") ||
                    string.IsNullOrWhiteSpace(row["DescricaoExtrato"]?.ToString());
                if (possuiCampoEmBranco)
                {
                    dt.Rows.RemoveAt(i);
                }
            }
            var result = await new AdicionaParametrosResumido().Execute(dt, user);
            return result;
        }
    }
}
