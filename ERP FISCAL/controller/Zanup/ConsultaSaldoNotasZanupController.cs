using ERP_FISCAL.Repositories.ConsultaSaldoNotasZanup;
using System.Data;
using System.Threading.Tasks;
using ERP_FISCAL.Utils;
using System.Collections.Generic;

namespace ERP_FISCAL.Controller.ConsultaSaldoNotasZanup
{
    public class ConsultaSaldoNotasZanupController
    {
        public DataTable dtRetornoNotasCriadas;
        public async Task <DataTable> ConsultaSaldoNotas(int IDProduto = 0,int NumDoc = 0) 
        {
            ConsultaSaldoNotasZanupRepositories consultaSaldoNotas = new ConsultaSaldoNotasZanupRepositories();
            DataTable retorno = await consultaSaldoNotas.ConsultaSaldoNotas(IDProduto, NumDoc);
            return retorno;
        }
        public async Task<DataTable> RegistraNotasCriadasNoBlink(List<ControleNotasCriadaBling.JsonParaDadoTabela> notas)
        {
            ConsultaSaldoNotasZanupRepositories consultaSaldoNotas = new ConsultaSaldoNotasZanupRepositories();  
            foreach(var nota in notas)
            {
                DataTable retorno = await consultaSaldoNotas.RegistraNotasCriadasNoBlink(nota);
                DataTable cloneRetorno = retorno.Clone();
                dtRetornoNotasCriadas = cloneRetorno.Copy();

                DataRow primeiraLinha = retorno.Rows[0];


                dtRetornoNotasCriadas.Rows.Add(primeiraLinha.ItemArray);
            }

            //DataTable retorno = await consultaSaldoNotas.RegistraNotasCriadasNoBlink(notas);
            return dtRetornoNotasCriadas;
        }
    }
}
