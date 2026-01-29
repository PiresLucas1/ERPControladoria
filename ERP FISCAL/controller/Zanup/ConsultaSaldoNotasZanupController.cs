using ERP_FISCAL.Repositories.ConsultaSaldoNotasZanup;
using System.Data;
using System.Threading.Tasks;
using ERP_FISCAL.Utils;
using System.Collections.Generic;
using System.Linq;

namespace ERP_FISCAL.Controller.ConsultaSaldoNotasZanup
{
    public class ConsultaSaldoNotasZanupController
    {
        public static DataTable dtRetornoNotasCriadas;
        public async Task <DataTable> ConsultaSaldoNotas(int IDProduto = 0,int NumDoc = 0) 
        {
            ConsultaSaldoNotasZanupRepositories consultaSaldoNotas = new ConsultaSaldoNotasZanupRepositories();
            DataTable retorno = await consultaSaldoNotas.ConsultaSaldoNotas(IDProduto, NumDoc);
            return retorno;
        }
        public async Task<DataTable> RegistraNotasCriadasNoBlink(List<ControleNotasCriadaBling.JsonParaDadoTabela> notas)
        {

            ConsultaSaldoNotasZanupRepositories consultaSaldoNotas = new ConsultaSaldoNotasZanupRepositories();

            if(dtRetornoNotasCriadas == null)
            {
                var primeiroRetorno = await consultaSaldoNotas.RegistraNotasCriadasNoBlink(notas.First());
                dtRetornoNotasCriadas = primeiroRetorno.Clone();
                dtRetornoNotasCriadas.ImportRow(primeiroRetorno.Rows[0]);
            }            
            foreach (var nota in notas.Skip(1))
            {
                var retorno = await consultaSaldoNotas.RegistraNotasCriadasNoBlink(nota);
                dtRetornoNotasCriadas.ImportRow(retorno.Rows[0]);
            }            
            return dtRetornoNotasCriadas;
        }
    }
}
