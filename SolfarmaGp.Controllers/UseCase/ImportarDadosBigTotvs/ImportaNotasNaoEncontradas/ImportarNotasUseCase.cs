using SolfarmaGp.Repositorios.Fiscal.ImportarNotasServicoParaTotvs.ImportaNotasServicoParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarDadosBigTotvs.ImportaNotasNaoEncontradas
{
    public class ImportarNotasUseCase
    {
        public async Task<(string MensagemRetorno, DataTable DtRetorno)> Executar(string[] notas, DateTime dataInicio, DateTime dataFim, int substituir, int conferida, int filial)
        {
            string stringNotas = string.Join(",", notas);
            ImportaNotasParaTotvsRepo exportaDadosBigRepositories = new ImportaNotasParaTotvsRepo();
            var resultado = await exportaDadosBigRepositories.Executar(stringNotas, dataInicio, dataFim, substituir, conferida, filial);
            return (resultado.mensagem,resultado.DtRetorno);
        }
    }
}
