using SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.AlteraTipoMovimentoTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.AlteracaoFiscais.AlteraTipoMovimentoUnico
{
    public class AltListaMovimentoUseCase
    {
        public async Task<DataTable> Executar(DataTable data, int codColigada)
        {
            ALteraTipoMovimentoEmLista alteraTipoMovimento = new ALteraTipoMovimentoEmLista();
            DataTable retorno = await alteraTipoMovimento.Executar(data, codColigada);

            return retorno;
        }
    }
}
