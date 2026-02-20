using SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.TiposDeConsultas.ConsultaMovTotvsTrocaTipoMovimento;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.TipoDeConsultas.ConsultaMovimento
{
    public class ConsultaListaMovimentoUseCase
    {
        public async Task<DataTable> Executar(string codMovimento, int coligada)
        {
            ConsultaListaMovTotvsTrocaMovimento alteraTipoMovimentoRepositories = new ConsultaListaMovTotvsTrocaMovimento();
            DataTable dataRetorno = await alteraTipoMovimentoRepositories.Executar(codMovimento, coligada);

            return dataRetorno;
        }
    }
}
