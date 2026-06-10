using SolfarmaGp.Services.AutomacoesPy.RenomearArquivos;

namespace SolfarmaGp.UI.MenusUI.Fiscal.NovaPasta
{
    public partial class ExcutaAutomacaoRenomearArquivos : Form
    {
        private RenomearArquivosNotasFiscal _service = new RenomearArquivosNotasFiscal();
        public ExcutaAutomacaoRenomearArquivos()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var path = txbPath.Text;
            ExecutaAutomacao(path);
        
        }
        private void ExecutaAutomacao(string path)
        {
            rtbInfo.Clear();
            btnExecutar.Enabled = false;
            _service.Execute(path, linha =>
            {
                rtbInfo.AppendText(linha + "\n");
                rtbInfo.ScrollToCaret();                
            });

            btnExecutar.Enabled = true;
        }
    }
}
