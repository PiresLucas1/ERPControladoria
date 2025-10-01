using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_FISCAL.controller;
using ERP_FISCAL.view.DialogUI.interfacesUI;

namespace ERP_FISCAL.view.DialogUI
{
    public partial class InsercaoBloco : Form
    {
        public string valorProduto  { get; private set; }
        public string valorData { get; private set; }
        public string valorCfop { get; private set; }
        public DataTable data { get; set; }
        public InsercaoBloco(IDialogoInsereInformacao dialogo )
        {

            InitializeComponent();
            data = dialogo.dataTable;
            ConfigurarAutocompletar();
            textTitulo.Text = dialogo.titulo;

            dataLancamentoText.Enabled = false;
            cProdutoText.Enabled = false;
            cfopText.Enabled = false;


        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            valorProduto = cProdutoText.Text;
            valorCfop = cfopText.Text;
            valorData = dataLancamentoText.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
 
        public void ConfigurarAutocompletar()
        {
            // Crie a coleção de sugestões
            AutoCompleteStringCollection colecaoSugestoes = new AutoCompleteStringCollection();
            if (data == null)
            {
                return;
            }
            foreach(DataRow row in data.Rows)
            {
                colecaoSugestoes.Add(row["IDNATUREZA"].ToString());
            }

            // Associe a coleção e configure as propriedades do TextBox
            this.cProdutoText.AutoCompleteCustomSource = colecaoSugestoes;
            this.cProdutoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.cProdutoText.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void cProdutoCbox_CheckedChanged(object sender, EventArgs e)
        {
            verificaCheckBox();

        }

        private void dataLancamentoCbox_CheckedChanged(object sender, EventArgs e)
        {
            verificaCheckBox();
        }

        private void cfopCbox_CheckedChanged(object sender, EventArgs e)
        {
            verificaCheckBox();
        }
        public void verificaCheckBox()
        {
            if (dataLancamentoCbox.Checked == true)
                dataLancamentoText.Enabled = true;
            else
                dataLancamentoText.Enabled = false;

            if (cProdutoCbox.Checked == true)
                cProdutoText.Enabled = true;
            else
                cProdutoText.Enabled = false;

            if(cfopCbox.Checked == true)
                cfopText.Enabled = true;
            else
                cfopText.Enabled = false;
        }
    }
}
