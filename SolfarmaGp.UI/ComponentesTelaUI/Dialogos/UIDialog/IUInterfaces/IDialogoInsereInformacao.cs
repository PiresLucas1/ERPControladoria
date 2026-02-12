using System.Data;

namespace SolfarmaGp.UI.UiComponentesTela.Dialogos.UIDialog.IUInterfaces
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
