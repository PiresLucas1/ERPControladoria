using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_FISCAL.controller;

namespace ERP_FISCAL.view
{
    public partial class SelecionarCfop : Form
    {
        private IAjusteComboBoxUi cfops;


        public SelecionarCfop()
        {
            InitializeComponent();
            CarregarComboBox();
        }

        public async void CarregarComboBox()
        {
            CarregaCFOPController carregaComboBoxCfop = new CarregaCFOPController();
            cfops = await carregaComboBoxCfop.ListaTodosCFOPController();


           foreach(var item in cfops.DicionarioColigada)
            {
               
                comboBoxColigada.Items.Add(new KeyValuePair<string, string>(item.Key, item.Value));
            }

            comboBoxColigada.DisplayMember = "Value";
            comboBoxColigada.ValueMember = "Key";

        }  


        private void comboBoxColigada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string valorComboBox = comboBoxColigada.Text.ToString();
                Console.WriteLine(comboBoxColigada.Text.ToString());
                if (valorComboBox != ""){
                    if (cfops.DicionarioColigada.ContainsKey(valorComboBox))
                    {
                        var valor  = cfops.DicionarioColigada[valorComboBox];
                        int index = comboBoxColigada.FindString(valor);
                        if (index >= 0)
                        {
                            comboBoxColigada.SelectedIndex= index;
                        }
                        comboBoxNatureza.Enabled = true;
                        carregarComboBox();

                        string chavecb = PegaValorChave(comboBoxColigada);
                        string valorcb = PegaValorValor(comboBoxColigada);

                        txtIdColigada.Text = chavecb;
                        txtColigada.Text = valorcb;
                        txtIdColigada.Visible = true;
                        txtColigada.Visible = true;
                    }
                   
                    
                }
            }
            
        }

        private void comboBoxColigada_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.Write(comboBoxColigada.GetItemText(comboBoxColigada.SelectedIndex));
            comboBoxNatureza.Enabled = true;


            string chave = PegaValorChave(comboBoxColigada);
            string valor = PegaValorValor(comboBoxColigada);

            txtIdColigada.Text = chave;
            txtColigada.Text = valor;
            txtIdColigada.Visible = true;
            txtColigada.Visible = true;
            carregarComboBox();
        }

        public void carregarComboBox()
        {
            comboBoxNatureza.Items.Clear();
            if (comboBoxColigada.SelectedItem != null)
            {
                var selected = (KeyValuePair<string, string>)comboBoxColigada.SelectedItem;
                string chave = selected.Key;
                string valor = selected.Value;


                foreach(DataRow item in cfops.DatatableNatureza.Rows)
                {
                    Console.WriteLine(item);
                    var itemKey = item["CODCOLIGADA"].ToString();
                    if (itemKey == chave)
                    {
                        //Console.WriteLine(item["DESCRICAO_NATUREZA"]);
                        string key = item["IDNATUREZA"].ToString();
                        string value = key + " - " + item["DESCRICAO_NATUREZA"];
                        comboBoxNatureza.Items.Add(new KeyValuePair<string, string>(key, value));
                    }
                    comboBoxNatureza.DisplayMember = "value";
                    comboBoxNatureza.ValueMember = "key";
                }
            }

        }

        public string PegaValorChave(ComboBox cbItem) 
        {
            var selected = (KeyValuePair<string, string>)cbItem.SelectedItem;
            string chave = selected.Key;         
            return chave;
        }
        public string PegaValorValor(ComboBox cbItem)
        {
            var selected = (KeyValuePair<string, string>)cbItem.SelectedItem;
            string valor = selected.Value;
            return valor;
        }

        private void comboBoxNatureza_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chavecb = PegaValorChave(comboBoxNatureza);
            string valorcb = PegaValorValor(comboBoxNatureza);

            txtIdNatureza.Text = chavecb;
            txtNatureza.Text = valorcb;
            txtIdNatureza.Visible = true;
            txtNatureza.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxNatureza.SelectedIndex == -1)
            {
                return;
            }
            else
            {

            ImportarNota importarNota = new ImportarNota();
            importarNota.cfopSelecionado = PegaValorChave(comboBoxNatureza);
                //importarNota.AtualizaValor()
            }

        }
    }
}
