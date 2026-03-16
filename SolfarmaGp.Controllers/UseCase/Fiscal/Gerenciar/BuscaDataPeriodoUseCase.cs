using SolfarmaGp.Repositorios.Fiscal.Gerenciar;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.Gerenciar
{
    public class BuscaDataPeriodoUseCase
    {
        public async Task<(DateTime dtInicio, DateTime dtFim, bool)> Execute()
        {
            BuscaDataPeriodo repo = new BuscaDataPeriodo();
            DataTable dtRetorno = await repo.Execute();

            DateTime dtInicio = Convert.ToDateTime(dtRetorno.Rows[0]["DataApuracaoInicio"]);
            DateTime dtFim = Convert.ToDateTime(dtRetorno.Rows[0]["DataApuracaoFim"]);
            bool status = Convert.ToBoolean(dtRetorno.Rows[0]["StatusApuracao"]);

            return (dtInicio, dtFim, status);
        }
    }
}
