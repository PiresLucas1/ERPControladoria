using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    public class ConsultarNotaPorChaveAcessoUseCAse
    {

        public async Task<DataTable> Execute(string chaveAcesso)
        {
            DataTable dtResult = new DataTable();
            dtResult = await new ConsultaNotaPorChaveAcesso().Executar(chaveAcesso);
            return dtResult;
        }
    
    }
}
