using ERP_FISCAL.Controller.ExportaXmlController;
using ERP_FISCAL.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ERP_FISCAL.view.FiscalView
{
    public partial class ExportaXml : Form
    {
        public ExportaXml()
        {
            InitializeComponent();
            carregaComboBox();
            string placeholderText = "Ex: \\\\192.168.30.48\\xml\\2025 - 11 - 21_a_26\\";
            tbLocalExport.Text = placeholderText;
            tbLocalExport.ForeColor = SystemColors.GrayText;
            //AplicarFonte.AplicarFonteForm(this, new System.Drawing.Font(this.Font.FontFamily, Properties.Settings.Default.FonteTamanho));
        }
        public void carregaComboBox()
        {
            cbTipoExportacao.Items.Clear();
            cbTipoExportacao.Items.Add("Sim");
            cbTipoExportacao.Items.Add("Não");

            cbModeloDocumento.Items.Clear();
            cbModeloDocumento.Items.Add("55 - NF-e");
            cbModeloDocumento.Items.Add("55 - NFCe");
            cbModeloDocumento.Items.Add("69 - Sat");



        }

        private async void btnExecute_Click(object sender, EventArgs e)
        {
            ExportaXmlController exportaXmlController = new ExportaXmlController();            
            var modeloDocumento = cbModeloDocumento.Text.Substring(0, 2);
            DataTable retorno =  await exportaXmlController.ExportaXmlPostoLago(dtInicio.Value, dtFim.Value, tbLocalExport.Text, modeloDocumento, cbTipoExportacao.Text == "Sim" ? 1 : 0);
            MessageBox.Show("Exportação concluída. Registros exportados: " + retorno.Rows.Count.ToString());
        }
    }
}
