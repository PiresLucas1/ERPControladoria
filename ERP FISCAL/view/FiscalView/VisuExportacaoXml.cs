using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view.FiscalView
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
            rtBoxResultado.Text = "Importando XMLs... Aguarde o processo ser concluído!";
        }
    }
}
