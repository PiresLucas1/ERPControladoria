using ERP_FISCAL.Repositories.Fiscal.AlteraDataDocumentoMovimentoTotvs;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ERP_FISCAL.Utils;

namespace ERP_FISCAL.Controller.Fiscal.AlteraDataDocumentoMovimentoTotvs
{
    public class AlteraDataDocumentoMovimentoTotvs
    {
        public class MovimentoNovaData
        {
            public int CODCOLIGADA { get; set; }
            public int IDMOV { get; set; }
            public DateTime NOVADATA { get; set; }
        }
        public async Task<DataTable> ConsultaMovimentoTovts(int codcoligada,DateTime dtInicio, DateTime dtFim)
        {
            var retorno = await new AlteraDataDocumentoMovimentoTotvsRepositories().ConsultaMovimentoTotvs(codcoligada ,dtInicio, dtFim);

            return retorno;
        }
        public async Task<DataTable> AlteraDataDocumentoTotvs(DataTable dtIdMovs)
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



            var retorno = await new AlteraDataDocumentoMovimentoTotvsRepositories().AlteraDataDocumentoTotvs(dtFormatadaParaBanco);
            return retorno;
        }
       
    }
}
