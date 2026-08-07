using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    public class ConsultarNotaPorChaveAcesso
    {

        public async Task<DataTable> Execute(string chaveAcesso)
        {
            DataTable dtResult = new DataTable();
            dtResult = await new SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs.ConsultaNotaPorChaveAcesso().Executar(chaveAcesso);
            return dtResult;
        }
    
    }
}
