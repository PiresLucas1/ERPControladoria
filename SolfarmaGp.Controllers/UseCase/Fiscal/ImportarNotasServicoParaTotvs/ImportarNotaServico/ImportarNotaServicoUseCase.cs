using SolfarmaGp.Repositorios.Fiscal.ImportaNotasServicoTotvs.ImportarNotasServicoTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasServicoParaTotvs.ImportarNotaServico
{
    public class ImportarNotaServicoUseCase
    {
        public async Task Executar(DataTable dtNotas, List<DataRow> linhasSelecionadas)
        {
            ImportarNotasServicoTotvsRepo importaNota = new ImportarNotasServicoTotvsRepo();            
            await importaNota.Executar(dtNotas,linhasSelecionadas);

        }
    }

}
