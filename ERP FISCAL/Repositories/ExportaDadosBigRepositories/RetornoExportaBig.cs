using System.Data;

namespace ERP_FISCAL.Repositories.ExportaDadosBigRepositories
{
    internal interface IRetornoExportaBig
    {
        string MensagemRetorno { get; set; }
        DataTable DtRetorno { get; set; }
    }
    internal class RetornoExportaBigRepository : IRetornoExportaBig
    {
        public string MensagemRetorno { get; set; }
        public DataTable DtRetorno { get; set; }

        public RetornoExportaBigRepository()
        {
            MensagemRetorno = string.Empty;
            DtRetorno = new DataTable();
        }
    }
}
