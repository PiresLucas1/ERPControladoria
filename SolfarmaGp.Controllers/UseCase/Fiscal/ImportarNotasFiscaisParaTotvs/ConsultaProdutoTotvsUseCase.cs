using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class ConsultaProdutoTotvsUseCase
    {
        public async Task<DataTable> Executar(int codNoForn)
        {
            var consultaProdutoTotvs = new ConsultaProdutoTotvs();
            return await consultaProdutoTotvs.Executar(codNoForn);
        }
    }
}
