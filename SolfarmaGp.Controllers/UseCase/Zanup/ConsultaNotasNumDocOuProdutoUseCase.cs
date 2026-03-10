using ERP_FISCAL.Repositories.ConsultaSaldoNotasZanup;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Zanup
{
    public class ConsultaNotasNumDocOuProdutoUseCase
    {
        public async Task<DataTable> ConsultaSaldoNotas(int IDProduto = 0, int NumDoc = 0)
        {
            ConsultaSaldoNotasNumDocOuProd consultaSaldoNotas = new ConsultaSaldoNotasNumDocOuProd();
            DataTable retorno = await consultaSaldoNotas.Execute(IDProduto, NumDoc);
            return retorno;
        }
    }
}
