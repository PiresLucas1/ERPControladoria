using SolfarmaGp.Controllers.Utils.EnumerableToDateTable;
using SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.AlteraDataDocumentoMovimentoTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.AlteraDataDocumento
{
    public class AltDataDocumentoUseCase
    {
        public class MovimentoNovaData
        {
            public int CODCOLIGADA { get; set; }
            public int IDMOV { get; set; }
            public DateTime NOVADATA { get; set; }
        }
        public async Task<DataTable> Executar(DataTable dtIdMovs)
        {


            var dtFormatadaParaBanco = dtIdMovs
                .AsEnumerable()
                .Select(r => new MovimentoNovaData
                {
                    IDMOV = r.Field<int>("IDMovimento"),
                    NOVADATA = r.Field<DateTime>("Data Pagamento"),
                    CODCOLIGADA = 2
                })
                .ToList()
                .ToDataTable();



            var retorno = await new AlteraDataDocumentoMovimentoTotvsRepositories().Executar(dtFormatadaParaBanco);
            return retorno;
        }
    }
}
