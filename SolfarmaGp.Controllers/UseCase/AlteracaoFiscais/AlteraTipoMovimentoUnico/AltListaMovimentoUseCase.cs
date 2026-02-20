using SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.AlteraTipoMovimentoTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.AlteraTipoMovimentoUnico
{
    public class AltListaMovimentoUseCase
    {
        public async Task<DataTable> Executar(DataTable data)
        {
            ALteraTipoMovimentoEmLista alteraTipoMovimento = new ALteraTipoMovimentoEmLista();
            DataTable retorno = await alteraTipoMovimento.Executar(data);

            return retorno;
        }
    }
}
