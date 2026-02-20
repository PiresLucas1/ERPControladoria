using SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.AlteraTipoMovimentoTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.AlteraTipoMovimentoUnico
{
    public class AltUnicoMovimentoUseCase
    {
        public async Task<string> Executar(int codMovimento, int coligada, string codTmovimento)
        {
            AlteraTipoMovimento alteraTipoMovimentoRepositories = new AlteraTipoMovimento();
            DataTable retorno = await alteraTipoMovimentoRepositories.Executar(codMovimento, coligada, codTmovimento);

            if(retorno.Rows.Count <= 0)
            {
                return "Sem resultado";
            }
            string? mensagem = retorno.Rows.Count > 0
                ? retorno.Rows[0]["Resultado"].ToString()
                : "Sem resultado";
            return mensagem;

        }
    }
}
