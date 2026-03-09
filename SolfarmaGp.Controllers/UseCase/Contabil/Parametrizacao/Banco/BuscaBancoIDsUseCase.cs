using SolfarmaGp.Repositorios.Contabil.Parametrizacao.Banco;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Banco
{
    public class BuscaBancoIDsUseCase
    {
        public async Task<DataTable> Execute()
        {
            BuscaBancoIDs repo = new BuscaBancoIDs();
            DataTable result = await repo.Execute();
            return result;

        }
    }
}
