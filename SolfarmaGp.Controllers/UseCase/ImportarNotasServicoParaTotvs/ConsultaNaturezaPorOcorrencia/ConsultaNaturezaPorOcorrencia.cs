using SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultaNaturezaFiscalRepositorio;
using System.Data;
using System.Text.RegularExpressions;


namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ConsultaNaturezaPorOcorrencia
{
    public class ConsultaNaturezaPorOcorrencia
    {
        public async Task<DataTable> Executar(string valor, int codColigada)
        {
            bool valorEmNumero = VerificaValorParaPesquisa(valor);
            ConsultaNaturezaPorOcorrenciaRepo cfops = new ConsultaNaturezaPorOcorrenciaRepo();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.Executar(valor, codColigada, valorEmNumero);
            });

            return dataTable;
        }
        private static bool VerificaValorParaPesquisa(string valor)
        {
            Regex regex = new Regex(@"^[0-9\.]+$");
            return regex.IsMatch(valor);
        }
    }
}
