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
using ERP_FISCAL.Controller;
using ERP_FISCAL.view.Interfaces;

namespace ERP_FISCAL.view.UIComponentes
{
    public partial class SelecaoCompletaItem : Form
    {
        public DataTable tabelaDados;
        public int indexRow;
        
        public SelecaoCompletaItem(int indexRow)
        {
            InitializeComponent();
            this.indexRow = indexRow;
            this.Load += SelecaoCompletaItem_Load;
           

        }
        public async Task CarregaInformacoesProdutoServicoForms()
        {
            try
            {
                var produtoServico = new ProdutoServicoController();
                tabelaDados = await produtoServico.CarregaProdutoServicoController();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar coligadas/naturezas: " + ex.Message, "Natureza Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void  SelecaoCompletaItem_Load(object sender, EventArgs e)
        {
            await CarregaInformacoesProdutoServicoForms();
            //CarregaComboBoxProdutoServico();
            ConfigurarAutocompletar();
        }
        public void CarregaComboBoxProdutoServico()
        {
            cBCodProduto.Items.Clear();

            if (tabelaDados == null || tabelaDados.Rows.Count == 0)
            {
                cBCodProduto.Enabled = false;
                return;
            }

            foreach (DataRow row in tabelaDados.Rows)
            {

                string key = Convert.ToString(row["CODIGOPRD"]);
                string desc = Convert.ToString(row["DESCRICAO"]);
                string value = key + " - " + desc;

                cBCodProduto.Items.Add(new KeyValuePair<string, string>(key, value));
            }

            cBCodProduto.DisplayMember = "Value";
            cBCodProduto.ValueMember = "Key";
            cBCodProduto.Enabled = cBCodProduto.Items.Count > 0;

        }

        private void cBCodProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selObj = cBCodProduto.SelectedItem;
            if (!(selObj is KeyValuePair<string, string>)) return;
            var sel = (KeyValuePair<string, string>)selObj;

            var produtoServico = tabelaDados.Select($"CODIGOPRD = '{sel.Key}'");

            DataRow linhaProduto = produtoServico[0];
            tbCodNatureza.Text = linhaProduto[2].ToString();
            tbDescricaoNatureza.Text = linhaProduto[3].ToString();

        }
        public void ConfigurarAutocompletar()
        {
            if (tabelaDados == null)
                return;

            cBCodProduto.DropDownStyle = ComboBoxStyle.DropDown;
            cBCodProduto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cBCodProduto.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection colecaoSugestoes = new AutoCompleteStringCollection();

            foreach (DataRow row in tabelaDados.Rows)
            {
                colecaoSugestoes.Add(row["DESCRICAO"].ToString());
            }

            cBCodProduto.AutoCompleteCustomSource = colecaoSugestoes;
        }


    }
}
