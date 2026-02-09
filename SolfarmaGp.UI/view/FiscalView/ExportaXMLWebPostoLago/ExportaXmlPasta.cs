using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using ERP_FISCAL.Controller.ExportaXmlController;
using ERP_FISCAL.Repositories.ExportarXmlRepositories;
using ERP_FISCAL.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ERP_FISCAL.view.FiscalView
{
    public partial class ExportaXmlPasta : Form
    {
        Portal _formFocus = null;
        public ExportaXmlPasta(Portal _form)
        {
            InitializeComponent();
            carregaComboBox();
            string placeholderText = "Ex: \\\\192.168.30.48\\xml\\2025 - 11 - 21_a_26\\";
            tbLocalExport.Text = placeholderText;
            tbLocalExport.ForeColor = SystemColors.GrayText;
            _formFocus = _form;
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
            var modeloDocumento = "";
            if (cbModeloDocumento.SelectedItem != null)
            {
                modeloDocumento = cbModeloDocumento.Text.Substring(0, 2);

            }

            //var progress = new Progress<string>(s =>
            //{
            //    view.AlteraTipoMovimento(s);
            //});

            string cabecalhoDePesquisa = tbLocalExport.Text + dtInicio.Value.ToString() + dtFim.Text.ToString();

            _formFocus.AbrirFecharMonitoramentoExportacao(cabecalhoDePesquisa);

            this.Visible = false;
            DataTable retorno =  await exportaXmlController.ExportaXmlPostoLago(dtInicio.Value, dtFim.Value, tbLocalExport.Text, modeloDocumento ?? "", cbTipoExportacao.Text == "Sim" ? 1 : 0);
            _formFocus.AbrirFecharMonitoramentoExportacao();
            this.Close();

        }

    }
}
