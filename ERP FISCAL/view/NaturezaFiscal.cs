using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ERP_FISCAL.controller;

namespace ERP_FISCAL.view
{
    public partial class NaturezaFiscal : Form
    {
        // Saídas para o form chamador
        public string CFOPSelecionado { get; private set; }
        public string DescricaoSelecionada { get; private set; }

        public int codColigada { get; set; }

        // Dados carregados do controller
        private IAjusteComboBoxUi _cfops;

        public NaturezaFiscal(int reqCodColigada)
        {
            InitializeComponent();

            // estados iniciais de UI
            comboBoxNatureza.Enabled = false;
            if (txtIdColigada != null) txtIdColigada.Visible = false;
            if (txtColigada != null) txtColigada.Visible = false;
            if (txtIdNatureza != null) txtIdNatureza.Visible = false;
            if (txtNatureza != null) txtNatureza.Visible = false;
            codColigada = reqCodColigada;



            // carrega dados no Load (para poder usar await)
            this.Load += NaturezaFiscal_Load;
        }

        public NaturezaFiscal()
        {
        }

        private async void NaturezaFiscal_Load(object sender, EventArgs e)
        {
            try
            {
                var carregaComboBoxCfop = new CarregaCFOPController();
                _cfops = await carregaComboBoxCfop.ListaTodosCFOPController();

                comboBoxColigada.Items.Clear();

                // Popular coligadas (Key = ID, Value = Nome)
                foreach (var kv in _cfops.DicionarioColigada)
                    comboBoxColigada.Items.Add(new KeyValuePair<string, string>(kv.Key, kv.Value));

                comboBoxColigada.DisplayMember = "Value";
                comboBoxColigada.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar coligadas/naturezas: " + ex.Message,"Natureza Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nomeColigada = carregaNameColigada();
            comboBoxColigada.SelectedValue = codColigada;
            comboBoxColigada.Text = nomeColigada;
            comboBoxColigada.Enabled = false;

            CarregarNaturezasDaColigada();
        }
        public string carregaNameColigada()
        {
            var nomeColigada = _cfops.DicionarioColigada.TryGetValue(codColigada.ToString(), out string valorEncontrado);

            if (!nomeColigada)
            {
                return "Não foi possivel localizar coligada";
            }
            string nomeColigadaConcatenado = codColigada.ToString() + " - " + valorEncontrado;

            return nomeColigadaConcatenado;

        }


        private void CarregarNaturezasDaColigada()
        {
            comboBoxNatureza.Items.Clear();

            if (_cfops == null || _cfops.DatatableNatureza == null || _cfops.DatatableNatureza.Rows.Count == 0)
            {
                comboBoxNatureza.Enabled = false;
                return;
            }

            foreach (DataRow row in _cfops.DatatableNatureza.Rows)
            {
                var itemKey = Convert.ToInt32(row["CODCOLIGADA"]);
                if (itemKey != codColigada) continue;

                string key = Convert.ToString(row["IDNATUREZA"]);
                string desc = Convert.ToString(row["DESCRICAO_NATUREZA"]);
                string value = key + " - " + desc;

                comboBoxNatureza.Items.Add(new KeyValuePair<string, string>(key, value));
            }

            comboBoxNatureza.DisplayMember = "Value";
            comboBoxNatureza.ValueMember = "Key";
            comboBoxNatureza.Enabled = comboBoxNatureza.Items.Count > 0;

            if (txtIdNatureza != null) txtIdNatureza.Visible = false;
            if (txtNatureza != null) txtNatureza.Visible = false;
        }

        private void comboBoxNatureza_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selObj = comboBoxNatureza.SelectedItem;
            if (!(selObj is KeyValuePair<string, string>)) return;
            var sel = (KeyValuePair<string, string>)selObj;

            if (txtIdNatureza != null) { txtIdNatureza.Text = sel.Key; txtIdNatureza.Visible = true; }
            if (txtNatureza != null) { txtNatureza.Text = sel.Value; txtNatureza.Visible = true; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (comboBoxNatureza.SelectedIndex == -1) return;

            object selObj = comboBoxNatureza.SelectedItem;
            if (!(selObj is KeyValuePair<string, string>)) return;
            var sel = (KeyValuePair<string, string>)selObj;

            CFOPSelecionado = sel.Key;    // exemplo: "5102"
            DescricaoSelecionada = sel.Value; // exemplo: "5102 - Venda de produção..."

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Helper para localizar item no ComboBox por Key+Value
        private static int EncontrarItem(ComboBox cb, KeyValuePair<string, string> alvo)
        {
            for (int i = 0; i < cb.Items.Count; i++)
            {
                object it = cb.Items[i];
                if (!(it is KeyValuePair<string, string>)) continue;
                var kv = (KeyValuePair<string, string>)it;
                if (kv.Key == alvo.Key && kv.Value == alvo.Value) return i;
            }
            return -1;
        }
    }
}
