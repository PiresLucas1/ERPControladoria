using SolfarmaGp.Repositorios.Fiscal.ImportaNotasServicoTotvs.ConsultaNotasNfeServico.ConsultarNotasNfeServicoPorNumero;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ConsultaNotasServico
{
    public class ConsultaNotaServicoPorNumero
    {
        public async Task<DataTable> Executar(string noteId)
        {
            try
            {
                
                DataTable nota = await Task.Run(() =>
                {
                    ConsultarNotasNfeServicoPorNumero consultaNota = new ConsultarNotasNfeServicoPorNumero();
                    return consultaNota.Executar(noteId);
                });

                return nota;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel retornar nota", ex);

            }
        }
    }
}
