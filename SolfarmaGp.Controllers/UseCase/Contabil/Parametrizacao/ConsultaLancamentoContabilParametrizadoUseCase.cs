using SolfarmaGp.Repositorios.Contabil.Parametrizacao;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao
{
    public class ConsultaLancamentoContabilParametrizadoUseCase
    {
        public async Task<DataTable> Execute(int codColigada = 0)
        {
            ConsultaLancamentoContabilParametrizado repositorio = new ConsultaLancamentoContabilParametrizado();
            DataTable resultado = await repositorio.Execute();

            return resultado;
        }
    }
}
