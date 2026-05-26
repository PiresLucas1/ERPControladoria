using SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.TiposDeConsultas.ConsultaListaIDMovTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.AlteracaoFiscais.TipoDeConsultas.ConsultaMovimentoSeparadoPorPontoVirgula
{
    public class ConsultaMovSeparadoPorPontoVirgulaUseCase
    {
        public async Task<DataTable> Executar(string codMovimento, int codColigada)
        {
            ConsultaListaIDMovTotvs alteraTipoMovimento = new ConsultaListaIDMovTotvs();
            DataTable retorno = await alteraTipoMovimento.Executar(codMovimento, codColigada);

            return retorno;
        }
    }
}
