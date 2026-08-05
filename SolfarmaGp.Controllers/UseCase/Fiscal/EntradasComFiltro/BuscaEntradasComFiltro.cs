using SolfarmaGp.Repositorios.Fiscal.EntradasComFiltro;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.BuscaEntradasComFiltroUseCase
{
    public class BuscaEntradasComFiltroUseCase
    {
        public async Task<DataTable> Execute(DateTime dataInicio, DateTime dataFim, int Coligada, int Filial,string EntradaSaida)
        {

            BuscaEntradasComFiltro repo = new BuscaEntradasComFiltro();
            var dt = await repo.ExecutarAsync(dataInicio, dataFim, Coligada, Filial, EntradaSaida);
            Console.Write(dt);
            return dt;
        }
    }
}
