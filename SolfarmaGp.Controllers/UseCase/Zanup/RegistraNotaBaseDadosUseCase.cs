using SolfarmaGp.Communication.Zanup.Bling;

using SolfarmaGp.Repositorios.Zanup;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Zanup
{
    public class RegistraNotaBaseDadosUseCase
    {
        public static DataTable dtRetornoNotasCriadas;
        public async Task<DataTable> Execute(List<ControleNotasCriadas.JsonParaDadoTabela> notas)
        {

            if(notas == null)
            {
                
                throw new Exception("Não foi possivel Localizar Notas");
            }

            RegistraNotasCriadaBling consultaSaldoNotas = new RegistraNotasCriadaBling();

            if (dtRetornoNotasCriadas == null)
            {
                var primeiroRetorno = await consultaSaldoNotas.Execute(notas.First());
                dtRetornoNotasCriadas = primeiroRetorno.Clone();
                dtRetornoNotasCriadas.ImportRow(primeiroRetorno.Rows[0]);
            }
            foreach (var nota in notas.Skip(1))
            {
                var retorno = await consultaSaldoNotas.Execute(nota);
                dtRetornoNotasCriadas.ImportRow(retorno.Rows[0]);
            }
            return dtRetornoNotasCriadas;
        }
    }
}
