using SolfarmaGp.Repositorios.Fiscal.ImportaNotasServicoTotvs.ConsultaNotasNfeServico.ConsultarNotasNfeServicoPorPeriodo;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ConsultaNotasServico
{
    public class ConsultaNotasServico
    {
        public async Task<DataTable> Executar(DateTime valueDate1, DateTime valueDate2, int codColigada, bool bitExisteErp)
        {

            int existeErp;
            if (bitExisteErp == false)
            {
                existeErp = 0;
            }
            else
            {
                existeErp = 1;
            }
            DataTable notas = await Task.Run(() =>
            {
                ConsultarNotasNfeServicoPorPeriodo consultarNotasServico = new ConsultarNotasNfeServicoPorPeriodo();
                return consultarNotasServico.Executar(valueDate1, valueDate2, codColigada, existeErp);
            });



            return notas;

        }
    }
}
