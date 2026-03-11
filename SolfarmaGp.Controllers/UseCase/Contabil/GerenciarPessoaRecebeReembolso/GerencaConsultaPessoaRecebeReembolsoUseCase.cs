using SolfarmaGp.Repositorios.Contabil.GerenciarPessoaRecebeReembolso;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.GerenciarPessoaRecebeReembolso
{
    public class GerencaConsultaPessoaRecebeReembolsoUseCase
    {
        public async Task<DataTable> Execute()
        {
            DataTable dtResult = new DataTable();

            dtResult = await new GerenciarConsultaPessoaRecebeReembolso().Execute();

            return dtResult;


        }
    }
}
