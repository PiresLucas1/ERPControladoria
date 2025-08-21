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

        // Dados carregados do controller
        private IAjusteComboBoxUi _cfops;

        public NaturezaFiscal()
        {
            InitializeComponent();

            // estados iniciais de UI
            comboBoxNatureza.Enabled = false;
            if (txtIdColigada != null) txtIdColigada.Visible = false;
            if (txtColigada != null) txtColigada.Visible = false;
            if (txtIdNatureza != null) txtIdNatureza.Visible = false;
            if (txtNatureza != null) txtNatureza.Visible = false;

            // carrega dados no Load (para poder usar await)
            this.Load += NaturezaFiscal_Load;
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
        }

        // Seleção por ENTER digitando no combo da coligada (opcional)
        private void comboBoxColigada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            var texto = comboBoxColigada.Text == null ? "" : comboBoxColigada.Text.Trim();
            if (texto.Length == 0 || _cfops == null || _cfops.DicionarioColigada == null) return;

            string nome;
            if (_cfops.DicionarioColigada.TryGetValue(texto, out nome))
            {
                int idx = EncontrarItem(comboBoxColigada, new KeyValuePair<string, string>(texto, nome));
                if (idx >= 0) comboBoxColigada.SelectedIndex = idx;
            }
        }

        private void comboBoxColigada_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cast compatível com C# 7.3
            object selObj = comboBoxColigada.SelectedItem;
            if (!(selObj is KeyValuePair<string, string>)) return;
            var sel = (KeyValuePair<string, string>)selObj;

            if (txtIdColigada != null) { txtIdColigada.Text = sel.Key; txtIdColigada.Visible = true; }
            if (txtColigada != null) { txtColigada.Text = sel.Value; txtColigada.Visible = true; }

            CarregarNaturezasDaColigada(sel.Key);
        }

        private void CarregarNaturezasDaColigada(string codColigada)
        {
            comboBoxNatureza.Items.Clear();

            if (_cfops == null || _cfops.DatatableNatureza == null || _cfops.DatatableNatureza.Rows.Count == 0)
            {
                comboBoxNatureza.Enabled = false;
                return;
            }

            foreach (DataRow row in _cfops.DatatableNatureza.Rows)
            {
                var itemKey = Convert.ToString(row["CODCOLIGADA"]);
                if (!String.Equals(itemKey, codColigada, StringComparison.Ordinal)) continue;

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
