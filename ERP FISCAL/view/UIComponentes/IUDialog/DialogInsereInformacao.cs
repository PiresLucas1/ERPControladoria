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
    public partial class DialogInsereInformacao : Form
    {
        public string ValorDigitado { get; private set; }
        public DataTable data { get; set; }
        public DialogInsereInformacao(IDialogoInsereInformacao dialogo )
        {

            InitializeComponent();
            data = dialogo.dataTable;
            ConfigurarAutocompletar();
            textTitulo.Text = dialogo.titulo;

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            ValorDigitado = textBoxEntrada.Text;
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
            this.textBoxEntrada.AutoCompleteCustomSource = colecaoSugestoes;
            this.textBoxEntrada.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBoxEntrada.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

    }
}
