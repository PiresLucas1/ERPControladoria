using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.view.DialogUI.interfacesUI
{
    public interface IDialogoInsereInformacao
    {
        string titulo {  get; set; }
        DataTable dataTable { get; set; }

    }

    public class DialogoInsereInformacao : IDialogoInsereInformacao
    { 

        public string titulo { get;  set; }
        public DataTable dataTable { get; set; }
    }
}
