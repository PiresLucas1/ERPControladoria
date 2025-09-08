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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERP_FISCAL.view.UIComponentes
{
    public partial class ProdutoServico : Form
    {
        public DataTable tabelaDados;
        public List<string> listaCodigoProduto;
        public int indexRow;
        private bool navegandoComSeta = false;
        private int coligada;
        private ImportarNotaView _formPai;


        public ProdutoServico(int indexRow, int codColigada, ImportarNotaView formFocus)
        {
            InitializeComponent();
            this.indexRow = indexRow;
            this.Load += SelecaoCompletaItem_Load;
            listaCodigoProduto = new List<string>();
            this.coligada = codColigada;
            this._formPai = formFocus;


        }
        public async Task CarregaInformacoesProdutoServicoForms()
        {
            try
            {
                var produtoServico = new ProdutoServicoController();
                DataTable tabela = await produtoServico.CarregaTodos();
                //Console.WriteLine(tabela.Columns["CODCOLIGADA"].DataType);

                var tabelaFiltradaPorColigada = tabela.AsEnumerable()
                    .Where(row => row.Field<short>("CODCOLIGADA") == coligada)
                    .CopyToDataTable();

                this.tabelaDados = tabelaFiltradaPorColigada;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar coligadas/naturezas: " + ex.Message, "Natureza Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void  SelecaoCompletaItem_Load(object sender, EventArgs e)
        {
            await CarregaInformacoesProdutoServicoForms();
            CarregaComboBoxCodigoProduto();
        }




        public void CarregaComboBoxCodigoProduto()
        {
            cbCodigoProduto.DropDownStyle = ComboBoxStyle.DropDown; // permite digitar
            cbCodigoProduto.AutoCompleteMode = AutoCompleteMode.None; // desliga autocomplete padrão

            foreach (DataRow row in tabelaDados.Rows) {

                string valor = row["CODIGOPRD"].ToString() + " - " + row["DESCRICAO"].ToString();
                cbCodigoProduto.Items.Add(valor);
                listaCodigoProduto.Add(valor);
            }
            cbCodigoProduto.TextChanged += cbCodigoProduto_TextChanged;
        }

        private void AjustarDropDown()
        {
            int qtdItens = cbCodigoProduto.Items.Count;

            if (qtdItens == 0)
            {
                cbCodigoProduto.DroppedDown = false;
                return;
            }

            // Ajusta dinamicamente: máximo 15 itens na lista
            cbCodigoProduto.MaxDropDownItems = Math.Min(qtdItens, 15);
        }

        private void cbCodigoProduto_TextChanged(object sender, EventArgs e)
        {
            if (navegandoComSeta)
            {
                string item = cbCodigoProduto.Text;
                string[] codigoDescricao = item.Split(new string[] { " - " }, StringSplitOptions.None);
                RecuperaValoresDoItemSelecionada(codigoDescricao[0]);
            }
            else
            {
                string valorDigitado = cbCodigoProduto.Text;

                var filtrados = string.IsNullOrEmpty(valorDigitado)
                    ? listaCodigoProduto
                    : listaCodigoProduto
                        .Where(x => x.IndexOf(valorDigitado, StringComparison.OrdinalIgnoreCase) >= 0)
                        .Distinct()
                        .ToList();

                cbCodigoProduto.TextChanged -= cbCodigoProduto_TextChanged;

                cbCodigoProduto.Items.Clear();
                if (filtrados.Count > 0)
                {
                    cbCodigoProduto.Items.AddRange(filtrados.ToArray());
                    cbCodigoProduto.DroppedDown = true;

                    cbCodigoProduto.Text = valorDigitado;
                    cbCodigoProduto.SelectionStart = valorDigitado.Length;
                    cbCodigoProduto.SelectionLength = 0;
                }
                else if (filtrados.Count == 0)
                {                 
                    cbCodigoProduto.Items.AddRange(listaCodigoProduto.ToArray());
                }

                cbCodigoProduto.TextChanged += cbCodigoProduto_TextChanged;

            }
            cbCodigoProduto.SelectionStart = cbCodigoProduto.Text.Length;
            cbCodigoProduto.SelectionLength = 0;

        }

        private void RecuperaValoresDoItemSelecionada(string valor)
        {           
            
            var dataRowCodigoProduto = tabelaDados.Select($"CODIGOPRD = '{valor}'");
            if(dataRowCodigoProduto != null)
            {

                if (dataRowCodigoProduto.Length > 0)
                {
                    DataRow rowEncontrada = dataRowCodigoProduto[0];
                    tbCodNatureza.Text = rowEncontrada[2].ToString();
                    tbDescricaoNatureza.Text = rowEncontrada[3].ToString();
                }
            }
        }
        private void cbCodigoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (navegandoComSeta) return;
            if (cbCodigoProduto.SelectedItem != null)
            {
                string item = cbCodigoProduto.SelectedItem.ToString();
                string[] codigoDescricao = item.Split(new string[] { " - " }, StringSplitOptions.None);
                RecuperaValoresDoItemSelecionada(codigoDescricao[0]);
            }

            // Reseta a flag após a seleção
            navegandoComSeta = false;
        }
        private void cbCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            // Detecta quando o usuário está usando as setas para navegar
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                navegandoComSeta = true;
            }
            else
            {
                navegandoComSeta = false;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            var produtoSelecionado = cbCodigoProduto.SelectedItem.ToString();
            _formPai.SelecionaValorProduto(produtoSelecionado, indexRow);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
