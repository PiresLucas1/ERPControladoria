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
        ImportarNotaView FormFocus { get; set; }
        string NumDoc { get; set; }
        string CodVerificacao { get; set; }
        string CnpjPrestador { get; set; }
        string RazaoSocial { get; set; }

    }
    public class NaturezaFiscalType : INaturezaFiscalType
    {
        public int ReqCodColigada { get; set; }
        public int ReqIndexCelula { get; set; }
        public string NumDoc { get; set; }
        public string CnpjPrestador { get; set; } 
        public string CodVerificacao { get; set; }
        public ImportarNotaView FormFocus { get; set; }
        public string RazaoSocial { get; set; }
    }

    public interface IDtoFormNotaParaNatureza
    {

        string CodColigada { get; set; }
        string CnpjPrestador { get; set; }
        string CodVerificacao { get; set; }
        string NumDoc { get; set; }
        int QuantidadeNotas { get; set; }
        string RazaoSocial { get; set; }


    }

    public class DtoFormNotaParaNatureza : IDtoFormNotaParaNatureza
    {
        public string CodColigada { get ; set ; }
        public string CnpjPrestador { get; set; }
        public string CodVerificacao { get; set ; }
        public string NumDoc { get; set; }
        public int QuantidadeNotas { get; set; }
        public string RazaoSocial { get; set; }
    }

}
