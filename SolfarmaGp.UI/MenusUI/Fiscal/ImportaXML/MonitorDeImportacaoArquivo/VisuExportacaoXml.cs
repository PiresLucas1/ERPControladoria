
namespace SolfarmaGP.view.FiscalView
{
    
    public partial class VisuExportacaoXml : UserControl
    {
        public static string valorRb { get; set; }
        public VisuExportacaoXml(string value = "")
        {
            InitializeComponent();
            header.Text = value;
            AlteraValorTexto();


        }
        public void AlteraValorTexto(string valor ="")
        {
            rtBoxResultado.AppendText(valor + Environment.NewLine);
        }

    }
}
