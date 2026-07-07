using SolfarmaGp.Controllers.UseCase.Fiscal.ImportaXml.WebPostoXml;
using SolfarmaGp.UI.ComponentesTelaUI.Tabelas.UIRetornoEmTabela;
using SolfarmaGp.UI.MenusUI;
using SolfarmaGp.UI.Utils;
using System.Data;
using System.Text.RegularExpressions;

namespace SolfarmaGp.UI.MenusUI.Fiscal.ImportaXML.WebPostoXml
{
    public partial class ImportaXmlPasta : Form
    {
        Portal _formFocus = null;
        public ImportaXmlPasta(Portal _form)
        {
            InitializeComponent();
            carregaComboBox();
            string placeholderText = "Ex: \\\\192.168.30.48\\xml\\2025 - 11 - 21_a_26\\";
            tbLocalExport.PlaceholderText = placeholderText;
            tbLocalExport.ForeColor = SystemColors.GrayText;
            chkBoxTipoImportacao.Checked = false;
            tbCnpj.Enabled = false;
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
            ImportaXmlPostoUseCase exportaXmlController = new ImportaXmlPostoUseCase();
            var modeloDocumento = "";
            var tipoExportacao = "";
            if (cbModeloDocumento.SelectedItem != null)
            {
                modeloDocumento = cbModeloDocumento.Text.Substring(0, 2);

            }
            if (chkBoxTipoImportacao.Checked && string.IsNullOrEmpty(tbCnpj.Text))
            {
                MessageBox.Show("Informe o CNPJ para importação por CNPJ");
                return;
            }


            tipoExportacao = chkBoxTipoImportacao.Checked ? tbCnpj.Text : "";
            string idEmpresa = ConverteCnpjParaIdEmpresa(tipoExportacao);
            string dataInicio = dtInicio.Value.Date.ToString();
            string dataFim = dtFim.Value.Date.ToString();
            string cabecalhoDePesquisa = tbLocalExport.Text;
            char existeBarraFinal = cabecalhoDePesquisa[cabecalhoDePesquisa.Length - 1];
            if (existeBarraFinal != '\\')
            {
                cabecalhoDePesquisa = cabecalhoDePesquisa + '\\';
            }

            var Visualizacao = _formFocus.AbrirFecharMonitoramentoExportacao(cabecalhoDePesquisa);
            var progress = new Progress<string>(s =>
            {
                Visualizacao.AlteraValorTexto(s);
            });

            this.Visible = false;
            DataTable retorno = await exportaXmlController.Execute(
                dtInicio.Value.Date,
                dtFim.Value.Date,
                cabecalhoDePesquisa,
                modeloDocumento ?? "",
                cbTipoExportacao.Text == "Sim" ? 1 : 0,
                idEmpresa,
                progress);

            RetornoEmTabela tabelaRetorno = new RetornoEmTabela(retorno);
            tabelaRetorno.Show();
            _formFocus.AbrirFecharMonitoramentoExportacao();
            this.Close();

        }
        private string ConverteCnpjParaIdEmpresa(string valor)
        {
            var cnpj = RemoverMascaraCnpj.RemoverMascara(valor);
            cnpj = ObterEmpresaCodigoPorCnpj.executar(cnpj);
            return cnpj;

        }


        private void chkBoxTipoImportacao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxTipoImportacao.Checked) tbCnpj.Enabled = true;
            else tbCnpj.Enabled = false;
        }

        private void tbCnpj_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            // Remove tudo que não for número
            string numeros = Regex.Replace(txt.Text, @"[^\d]", "");

            // Limita a 14 dígitos (tamanho do CNPJ)
            if (numeros.Length > 14)
                numeros = numeros.Substring(0, 14);

            // Aplica a máscara progressivamente
            string formatado = numeros;

            if (numeros.Length > 2)
                formatado = numeros.Substring(0, 2) + "." + numeros.Substring(2);

            if (numeros.Length > 5)
                formatado = formatado.Substring(0, 6) + "." + formatado.Substring(6);

            if (numeros.Length > 8)
                formatado = formatado.Substring(0, 10) + "/" + formatado.Substring(10);

            if (numeros.Length > 12)
                formatado = formatado.Substring(0, 15) + "-" + formatado.Substring(15);

            // Evita loop infinito de disparo do evento
            txt.TextChanged -= tbCnpj_TextChanged;
            txt.Text = formatado;
            txt.SelectionStart = txt.Text.Length; // mantém o cursor no final
            txt.TextChanged += tbCnpj_TextChanged;
        }
    }
}
