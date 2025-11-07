
using DocumentFormat.OpenXml.InkML;
using ERP_FISCAL.Controller.ConsultaSaldoNotasZanup;
using ERP_FISCAL.Utils;
using ERP_FISCAL.view.UIComponentes.UIStatusDoProcessos;
using System;
using System.Collections.Generic;

using System.Data;
using System.IO;
using System.Linq;

using System.Threading.Tasks;

using System.Windows.Forms;
using Color = System.Drawing.Color;


namespace ERP_FISCAL.view
{

    public partial class ConsultaSaldoNotasFiscais : Form
    {
        public DataGridViewRow cellAlteracao;
        public int colAlteracao;
        public DataTable dataItensSelecionados = new DataTable();
        public DataTable dataItensPesquisado = new DataTable();
        public DataTable dataOrigem = new DataTable();
        public ConsultaSaldoNotasFiscais()
        {
            InitializeComponent();
            cbFiltroSaldo.Items.Add("IDProduto");
            cbFiltroSaldo.Items.Add("Num.doc");
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            int ValorFiltro;

            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MessageBox.Show("Preencha o campo!",
                                "Campo obrigatório",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if ((!int.TryParse(txtFiltro.Text, out ValorFiltro)))
            {
                MessageBox.Show("Digite apenas números!",
                                "Entrada inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            StatusProcess splashScreen = new StatusProcess();
            splashScreen.Show(this); // 'this' como owner para ficar modal
            splashScreen.SetMessage("Carregando...");
            splashScreen.UpdateProgress(70);
            btnListaNotas.Enabled = false;
            btnListaNotas.Enabled = false;
            try
            {
                ConsultaSaldoNotasZanupController consultaSaldoNotasZanup = new ConsultaSaldoNotasZanupController();

                DataTable retorno = new DataTable();

                if (cbFiltroSaldo.SelectedIndex == 0)
                {
                    retorno = await consultaSaldoNotasZanup.ConsultaSaldoNotas(ValorFiltro, 0);

                }
                else
                {
                    retorno = await consultaSaldoNotasZanup.ConsultaSaldoNotas(0, ValorFiltro);
                }


                if (dataItensSelecionados.Columns.Count <= 0)

                    if (retorno.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum produto encontrado!");
                    }
                dataItensPesquisado = retorno;
                CarregaDataTable(retorno);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado ao consultar notas: " + ex.Message,
                                "Erro no sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            splashScreen.Close();
            btnListaNotas.Enabled = true;

        }
        public void CarregaDataTable(DataTable data)
        {
            if (!data.Columns.Contains("Qtd para Devolver"))
            {
                DataColumn colQuantidade = new DataColumn("Qtd para Devolver", typeof(int));
                colQuantidade.DefaultValue = 0;
                data.Columns.Add(colQuantidade);

            }
            if (!data.Columns.Contains("colSelecionado"))
            {
                DataColumn colSelecionado = new DataColumn("colSelecionado", typeof(bool));
                colSelecionado.DefaultValue = 0;
                data.Columns.Add(colSelecionado);
            }
            dvgConsultaNotas.DataSource = data;

            VerificaSeExisteItemNoDatatableDeItensSelecionado(data);

            dvgConsultaNotas.Columns["Qtd para Devolver"].DisplayIndex = 0;
            dvgConsultaNotas.Columns["Qtd para Devolver"].Width = 30;
            dvgConsultaNotas.Columns["Qtd para Devolver"].Width = 30;
            dvgConsultaNotas.Columns["Qtd para Devolver"].DefaultCellStyle.ForeColor = Color.Red;
            
            dvgConsultaNotas.Columns["colSelecionado"].Visible = false;


            dvgConsultaNotas.RowHeadersVisible = false;
            dataOrigem = dvgConsultaNotas.DataSource as DataTable;

            OrdenarPorSelecionado(dvgConsultaNotas);

        }

        public void VerificaSeExisteItemNoDatatableDeItensSelecionado(DataTable data)
        {
            ResetarCoresGridConsultaNotas();
            List<string> chaveDeAcessoSelecionadas = new List<string>();
            if (dataItensSelecionados.Rows.Count <= 0)
                return;
            foreach (DataRow row in dataItensSelecionados.Rows)
            {
                var chaveAcesso = row["ChaveAcesso"].ToString();
                chaveDeAcessoSelecionadas.Add(chaveAcesso);

            }
            foreach (DataRow row in data.Rows)
            {
                var chaveAcesso = row["ChaveAcesso"].ToString();
                if (chaveDeAcessoSelecionadas.Contains(chaveAcesso))
                {

                    PintarLinhaPorDataRow(dvgConsultaNotas, row, Color.LightSalmon);
                    row["colSelecionado"] = true;
                }
            }
            dvgConsultaNotas.Refresh();

        }
        public void ResetarCoresGridConsultaNotas()
        {
            foreach (DataGridViewRow row in dvgConsultaNotas.Rows)
            {
                // reset visual
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;

                // reset lógico (no DataTable)
                if (row.DataBoundItem is DataRowView drv
                    && drv.Row.Table.Columns.Contains("colSelecionado"))
                {
                    drv.Row["colSelecionado"] = false;
                }
            }

            dvgConsultaNotas.Refresh();
        }

        public void OrdenarPorSelecionado(DataGridView dvg)
        {
            if (dvg.DataSource is DataTable dt)
            {
                if (!dt.Columns.Contains("colSelecionado"))
                    return; // nada para ordenar

                dt.DefaultView.Sort = "colSelecionado DESC";
            }
        }


        private void dvgConsultaNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return; // Ignora cliques no header
            // Remove a seleção de todas as linhas
            dvgConsultaNotas.ClearSelection();
            // Destaca a linha clicada
            dvgConsultaNotas.Rows[e.RowIndex].Selected = true;


            // Opcional: Define cores personalizadas para a linha selecionada
            dvgConsultaNotas.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dvgConsultaNotas.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;



        }

        public async Task CriarNotaFiscal()
        {
            var dtOriginal = (System.Data.DataTable)dvgItensSelecionados.DataSource;

            var linhasSelecionadas = dtOriginal.AsEnumerable()
                .ToList();



            StatusProcess splashScreen = new StatusProcess();

            splashScreen.Show(this); // 'this' como owner para ficar modal
            splashScreen.SetMessage("Gerando nota fical no bling...");

            CriaNotaBlingService dataRowToObject = new CriaNotaBlingService();
            await dataRowToObject.TranformaDataRowToObject(linhasSelecionadas, this);
            btGerarNotaFiscal.Enabled = false;

            splashScreen.Close();
            btGerarNotaFiscal.Enabled = true;
        }

        private async void btGerarNotaFiscal_Click(object sender, EventArgs e)
        {
            if (dataItensSelecionados.Rows.Count <= 0)
            {
                return;
            }
            await CriarNotaFiscal();
        }
        public void LimpaDataGridViewItensSelecionados()
        {
            dataItensSelecionados.Clear();
            dvgItensSelecionados.DataSource = dataItensSelecionados;
        }

        public void GeraTextoDeCriacaoDeNotas(string valor)
        {
            txtCountNotas.Text = valor;
        }

        public void PintarLinhaPorDataRow(DataGridView dvg, DataRow rowParaPintar, Color cor)
        {
            foreach (DataGridViewRow gridRow in dvg.Rows)
            {
                if (gridRow.DataBoundItem is DataRowView drv &&
                    drv.Row == rowParaPintar)
                {
                    gridRow.DefaultCellStyle.BackColor = cor;
                    break;
                }
            }
        }



        public void ImportaItemParaDvgItensSelecionado(List<DataRow> linhasSelecionadas)
        {
            var dtOriginal = (DataTable)dvgConsultaNotas.DataSource;
            
            if(dataItensSelecionados.Rows.Count <= 0)
                dataItensSelecionados = dtOriginal.Clone();
            

            if (!dataItensSelecionados.Columns.Contains("Estoque origem"))
            {
                dataItensSelecionados.Columns.Add("Estoque origem", typeof(string));
            }

            foreach (var linha in linhasSelecionadas)
            {
                dataItensSelecionados.ImportRow(linha);

                PintarLinhaPorDataRow(dvgConsultaNotas, linha, Color.LightSalmon);
            }

            AdicionaColunaEstoqueOrigem();
            dvgItensSelecionados.DataSource = dataItensSelecionados;


            MessageBox.Show("Itens importados com sucesso!");

            
        }


        private void tabNavegacaoAba_Selected(object sender, TabControlEventArgs e)
        {
            if (tabNavegacaoAba.SelectedTab == tabItensSelecionado)
            {
                if (dataItensSelecionados.Rows.Count > 0)
                {

                    dvgItensSelecionados.DataSource = dataItensSelecionados;
                    dvgItensSelecionados.Columns["Qtd para Devolver"].DisplayIndex = 0;
                    dvgItensSelecionados.Columns["Qtd para Devolver"].DefaultCellStyle.ForeColor = Color.Red;

                    AdicionaColunaEstoqueOrigem();

                    dvgItensSelecionados.Columns["Estoque origem"].DisplayIndex = dvgItensSelecionados.Columns["Qtd para Devolver"].Index + 1;
                }

                txtCountNotas.Text = "";
                return;


            }
            else
            {
                txtCountNotas.Text =  dvgConsultaNotas.RowCount.ToString();
            }
        }

        /*Adiciona coluna estoque de origem na tabela que alimenta o dvg de itens selecionados*/
        public void AdicionaColunaEstoqueOrigem()
        {
            // Evita adicionar a coluna mais de uma vez
            if (!dvgItensSelecionados.Columns.Contains("Estoque Origem"))
            {
                DataGridViewComboBoxColumn colCombo = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Estoque origem",
                    Name = "Estoque Origem",
                    DataPropertyName = "Estoque Origem", // Nome da coluna no DataTable (deve existir se for binding)
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                    FlatStyle = FlatStyle.Flat,
                    Width = 200
                };

                // Adiciona as opções do combo
                colCombo.Items.AddRange(
                    "Amazon - FBA Onsite (Full)",
                    "Geral",
                    "Mercado Livre - FULL",
                    "Mercado Livre - Local",
                    "Raia Drogasil",
                    "Shopee",
                    "Shopee 205632595 (Fulfillment)",
                    "Shopee 205655037 (Fulfillment)",
                    "Shopee 205655101 (Fulfillment)",
                    "Shopee Garnier (Fulfillment)",
                    "Shopee L'Oréal (Fulfillment)",
                    "Shopee Maybelline (Fulfillment)",
                    "Shopee Zanup (Fulfillm)",
                    "Solfarma",
                    "TikTok Shop"
                );

                dvgItensSelecionados.Columns.Add(colCombo);
            }
        }

        private void btnRelacionaItens_Click(object sender, EventArgs e)
        {
            if (dvgConsultaNotas.RowCount > 0)
            {

                var dtOriginal = (System.Data.DataTable)dvgConsultaNotas.DataSource;
                if (!dtOriginal.Columns.Contains("Qtd para Devolver"))
                {
                    DataColumn colQuantidade = new DataColumn("Qtd para Devolver", typeof(int));
                    colQuantidade.DefaultValue = 0;
                    dtOriginal.Columns.Add(colQuantidade);

                }


                var linhasSelecionadas = dtOriginal.AsEnumerable()
                    .Where(r => r.Field<int>("Qtd para Devolver") != 0)
                    .ToList();

                bool existeCelulaVaiza = false;
                bool existeValorIncorreto = false;
                foreach (DataRow row in linhasSelecionadas)
                {
                    string qtd = row["Qtd para Devolver"]?.ToString();
                    if (string.IsNullOrWhiteSpace(qtd) || Convert.ToInt32(qtd) == 0)
                    {
                        int index = dtOriginal.Rows.IndexOf(row);
                        dvgConsultaNotas.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
                        existeCelulaVaiza = true;
                    }
                    if (Convert.ToUInt32(qtd) > Convert.ToInt32(row["Saldo Restante"].ToString()))
                    {
                        int index = dtOriginal.Rows.IndexOf(row);
                        dvgConsultaNotas.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
                        existeValorIncorreto = true;
                    }
                }
                if (existeValorIncorreto)
                {
                    MessageBox.Show("Existe algumas linhas que o valor de devolução esta incorreto");
                    return;
                }
                if (existeCelulaVaiza)
                {
                    MessageBox.Show("Existe algumas linhas que o valor de devolução não foi informado");
                    return;
                }

                if (linhasSelecionadas.Count > 0)
                    ImportaItemParaDvgItensSelecionado(linhasSelecionadas);
                else
                    MessageBox.Show("Nenhum item selecionado");



            }
            else
                MessageBox.Show("Nenhum item para importar!");
        }

        private void dvgConsultaNotas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {

                textBox.PreviewKeyDown -= TextBox_PreviewKeyDown;
                textBox.PreviewKeyDown += TextBox_PreviewKeyDown;


                cellAlteracao = dvgConsultaNotas.CurrentRow;
                colAlteracao = dvgConsultaNotas.CurrentCell.ColumnIndex;
            }
        }
        private void TextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var cellParaTextBox = sender as TextBox;

                var valorSaldoRestante = cellAlteracao.Cells["Saldo Restante"].Value.ToString();
                int saldoRestante = Convert.ToInt32(valorSaldoRestante);
                int valorDevolvido = Convert.ToInt32(cellParaTextBox.Text);
                if (valorDevolvido > saldoRestante)
                {
                    MessageBox.Show("Valor de Devolução não pode ser maior que o valor de Saldo Restante");
                    cellAlteracao.Cells["Qtd para Devolver"].Value = "";
                    return;
                }



            }
        }

        private void dvgItensSelecionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabNavegacaoAba.SelectedTab == tabItensSelecionado)
            {
                if (dataItensSelecionados.Rows.Count <= 0)
                {
                    return;
                }
                DialogResult retorno = MessageBox.Show("Deseja excluir este item da relação", "Aviso",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (retorno == DialogResult.OK)
                {
                    dataItensSelecionados.Rows.RemoveAt(e.RowIndex);
                    dvgItensSelecionados.DataSource = dataItensSelecionados;
                }

            }
        }
        private void dvgItensSelecionados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgItensSelecionados.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSalmon;
            dvgItensSelecionados.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;

        }

        private void cbFiltroSaldo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltroSaldo.SelectedIndex == 0)
            {

            }
        }


        private void chkExibirRelacionados_CheckedChanged_1(object sender, EventArgs e)
        {
            if (dvgConsultaNotas.DataSource == null)
                return;

            DataTable dt = (dvgConsultaNotas.DataSource as DataTable);

            if (chkExibirRelacionados.Checked)
            {
                // Clona a estrutura
                DataTable dtFiltrado = dt.Clone();

                // Copia apenas as linhas pintadas
                foreach (DataGridViewRow row in dvgConsultaNotas.Rows)
                {
                    if (row.DefaultCellStyle.BackColor == Color.LightSalmon)
                    {
                        dtFiltrado.ImportRow(((DataRowView)row.DataBoundItem).Row);
                    }
                }

                dvgConsultaNotas.DataSource = dtFiltrado;
                
            }
            else
            {
                // Restaura o DataTable original
                dvgConsultaNotas.DataSource = dataOrigem;
            }
        }

        private void dvgConsultaNotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var row = dvgConsultaNotas.Rows[e.RowIndex];
            var drv = row.DataBoundItem as DataRowView;

            if (drv != null && drv.DataView.Table.Columns.Contains("colSelecionado"))
            {
                bool selecionado = Convert.ToBoolean(drv.Row["colSelecionado"]);
                row.DefaultCellStyle.BackColor = selecionado ? Color.LightSalmon : Color.White;
            }
        }


        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Button1_Click(null, null);
                e.Handled = true;
            }
        }
    }
}
