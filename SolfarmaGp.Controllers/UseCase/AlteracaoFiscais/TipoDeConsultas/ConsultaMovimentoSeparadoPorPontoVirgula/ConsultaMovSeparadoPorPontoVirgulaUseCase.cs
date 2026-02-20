using SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.TiposDeConsultas.ConsultaListaIDMovTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.TipoDeConsultas.ConsultaMovimentoSeparadoPorPontoVirgula
{
    public class ConsultaMovSeparadoPorPontoVirgulaUseCase
    {
        public async Task<DataTable> Executar(string codMovimento)
        {
            ConsultaListaIDMovTotvs alteraTipoMovimento = new ConsultaListaIDMovTotvs();
            DataTable retorno = await alteraTipoMovimento.Executar(codMovimento);

            return retorno;
        }
    }
}
