using SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.TiposDeConsultas.ConsultaMovTotvsTrocaTipoMovimento;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.TipoDeConsultas.ConsultaMovimento
{
    public class ConsultaMovimentoUseCase
    {
        public async Task<DataTable> Executar(int codMovimento, int coligada)
        {
            ConsultaMovTotvsTrocaTipoMovimento alteraTipoMovimentoRepositories = new ConsultaMovTotvsTrocaTipoMovimento();
            DataTable dataRetorno = await alteraTipoMovimentoRepositories.Executar(codMovimento, coligada);

            return dataRetorno;
        }
    }
}
