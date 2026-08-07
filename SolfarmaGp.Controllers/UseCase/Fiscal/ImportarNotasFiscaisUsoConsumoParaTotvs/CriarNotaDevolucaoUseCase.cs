using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class CriarNotaDevolucaoUseCase
    {
        public async Task<int> Executar(
            int intCodColigada,
            int intCodFilial,
            string vchCodCCFO,
            string vchSerieDocumento,
            string vchCodTipoMovimento,
            string INvchNumeroDocumento,
            string INvchChaveAcesso,
            DateTime INdatDataEmissao,
            DateTime INdatDataLancamento,
            DataTable tvpItens,
            string vchCODMUNSERVICO = null,
            string vchCODETDMUNSERV = null,
            int? inIDNatMov = null,
            string vchCODTDO = "NF-e")
        {
            var consultaProdutoTotvs = new CriarNotaDevolucao();
            return await consultaProdutoTotvs.Executar(
                intCodColigada,
                intCodFilial,
                vchCodCCFO,
                vchSerieDocumento,
                vchCodTipoMovimento,
                INvchNumeroDocumento,
                INvchChaveAcesso,
                INdatDataEmissao,
                INdatDataLancamento,
                tvpItens,
                vchCODMUNSERVICO,
                vchCODETDMUNSERV,
                inIDNatMov,
                vchCODTDO
            );
        }
    }
}