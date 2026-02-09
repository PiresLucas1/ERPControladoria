using System.Data;


namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ConsultaNaturezaPorOcorrencia
{
    public class ConsultaNaturezaPorOcorrencia
    {
        public async Task<DataTable> CarregaComOcorrencia(string valor, int codColigada)
        {
            bool valorEmNumero = CfopController.VerificaValorParaPesquisa(valor);
            Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultaNaturezaFiscal.ConsultaPorOcorrencia.ConsultaNaturezaPorOcorrencia cfops = new Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultaNaturezaFiscal.ConsultaPorOcorrencia.ConsultaNaturezaPorOcorrencia();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.Consultar(valor, codColigada, valorEmNumero);
            });

            return dataTable;
        }
    }
}
