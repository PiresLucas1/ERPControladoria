using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.view.interfaces
{
    public interface INaturezaFiscalType
    {

        int ReqCodColigada { get; set; }
        int ReqIndexCelula { get; set; }
        ImportarNota FormFocus { get; set; }
        string NumDoc { get; set; }
        string CodVerificacao { get; set; }
        string CnpjPrestador { get; set; }

    }
    public class NaturezaFiscalType : INaturezaFiscalType
    {
        public int ReqCodColigada { get; set; }
        public int ReqIndexCelula { get; set; }
        public string NumDoc { get; set; }
        public string CnpjPrestador { get; set; } 
        public string CodVerificacao { get; set; }
        public ImportarNota FormFocus { get; set; }
    }

    public interface IDtoFormNotaParaNatureza
    {
        //codColigada,
        //        cnpjPrestador,
        //        codVerificacao,
        //        numDoc
        string CodColigada { get; set; }
        string CnpjPrestador { get; set; }
        string CodVerificacao { get; set; }
        string NumDoc { get; set; }

    }

    public class DtoFormNotaParaNatureza : IDtoFormNotaParaNatureza
    {
        public string CodColigada { get ; set ; }
        public string CnpjPrestador { get; set; }
        public string CodVerificacao { get; set ; }
        public string NumDoc { get; set; }
    }

}
