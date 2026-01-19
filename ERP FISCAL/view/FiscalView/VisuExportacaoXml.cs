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
    
    public partial class VisuExportacaoXml : Form
    {
        public static string valorRb { get; set; }
        public VisuExportacaoXml(string value = "")
        {
            InitializeComponent();
            header.Text = value;


        }

        private void rtBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }
        public void AlteraValorTexto(string valor)
        {
            rtBoxResultado.Text = valorRb;
        }
    }
}
