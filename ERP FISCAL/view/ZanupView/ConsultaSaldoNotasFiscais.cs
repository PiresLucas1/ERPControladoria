
using DocumentFormat.OpenXml.InkML;
using ERP_FISCAL.Controller.ConsultaSaldoNotasZanup;
using ERP_FISCAL.Services;
using ERP_FISCAL.Utils;
using ERP_FISCAL.view.UIComponentes.UIRetornoEmTabela;
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
            AplicarFonte.AplicarFonteForm(this, new System.Drawing.Font(this.Font.FontFamily, Properties.Settings.Default.FonteTamanho));
            cbFilial.Items.Add("Todas");
            cbFilial.Items.Add("1 - Farma");
            cbFilial.Items.Add("9 - Alimentar");
            cbFilial.Enabled = false;
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
           
           
          

            btnListaNotas.Enabled = false;
            btnListaNotas.Enabled = false;
            try
            {
                ProcessStatusManager.Start("Carregando dados...");
                ProcessStatusManager.Update("Processando...");
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
                txtCountNotas.Text = retorno.Rows.Count.ToString();

                if(retorno.Rows.Count > 0)
                {
                    cbFilial.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ProcessStatusManager.Error(ex); // Fecha e mostra o erro
            }
            finally
            {
                ProcessStatusManager.Stop(); // Garante o fechamento
            }
            
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
            dvgConsultaNotas.Columns["IDPessoaEmitente"].Visible = false;


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
            var linhasSelecionadas = dvgItensSelecionados.Rows
                .Cast<DataGridViewRow>()
                .Where(r => Convert.ToBoolean(r.Cells["Selecionar"].Value) == true)
                .Select(r => ((DataRowView)r.DataBoundItem).Row)
                .ToList();            
            try
            {
                ProcessStatusManager.Start("Carregando dados...");
                ProcessStatusManager.Update("Processando...");
                btGerarNotaFiscal.Enabled = false;

                CriaNotaBlingService dataRowToObject = new CriaNotaBlingService();

                await dataRowToObject.TranformaDataRowToObject(linhasSelecionadas, this);

            }
            catch(Exception ex)
            {
                ProcessStatusManager.Error(ex);
            }
            finally
            {
                ProcessStatusManager.Stop();
                var notas = ControleNotasCriadaBling.jsonNotasParaRegistro;
                DataTable notasCriadas = await new ConsultaSaldoNotasZanupController().RegistraNotasCriadasNoBlink(notas);
                if(notas.Count > 0)
                {
                    RetornoEmTabela retorno = new RetornoEmTabela(notasCriadas);
                    retorno.Visible = true;

                }
                new ControleNotasCriadaBling().LimparNotasCriadas();
                btGerarNotaFiscal.Enabled = !btGerarNotaFiscal.Enabled;
            }
            


        }

        private async void btGerarNotaFiscal_Click(object sender, EventArgs e)
        {
            if (dataItensSelecionados.Rows.Count <= 0)
            {
                return;
            }
            var result = MessageBox.Show(
                "Deseja realmente continuar?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                                
                await CriarNotaFiscal();
            }

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
        public void MarcaLinhaImportadaParaOBling(int valorDocumento, int IdProduto, decimal quantidadeParaDevolver)
        {
            foreach(DataGridViewRow row in dvgItensSelecionados.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                int doc = Convert.ToInt32(row.Cells["NumDocumento"].Value);
                //int prod = Convert.ToInt32(row.Cells["IDProduto"].Value);
                //decimal qtd = Convert.ToDecimal(row.Cells["Qtd para Devolver"].Value);

                if (doc == valorDocumento)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;   // fundo
                    row.DefaultCellStyle.ForeColor = Color.Black;        // texto (opcional)
                    
                }
            }
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
            AdicionarColunaSelecionar();
            dvgItensSelecionados.DataSource = dataItensSelecionados;


            MessageBox.Show("Itens importados com sucesso!");

            
        }


        private void tabNavegacaoAba_Selected(object sender, TabControlEventArgs e)
        {
            if(dvgItensSelecionados.Rows.Count <= 0)
            {
                txtCountNotas.Text = "0";
                return;
            }
            if (tabNavegacaoAba.SelectedTab == tabItensSelecionado)
            {
                if (dataItensSelecionados.Rows.Count > 0)
                {

                    dvgItensSelecionados.DataSource = dataItensSelecionados;
                    dvgItensSelecionados.Columns["Qtd para Devolver"].DisplayIndex = 0;
                    dvgItensSelecionados.Columns["Qtd para Devolver"].DefaultCellStyle.ForeColor = Color.Red;

                    AdicionaColunaEstoqueOrigem();
                    AdicionarColunaSelecionar();

                    dvgItensSelecionados.Columns["Estoque origem"].DisplayIndex = dvgItensSelecionados.Columns["Qtd para Devolver"].Index + 1;
                }

                dvgItensSelecionados.Columns["colSelecionado"].Visible= false;
                txtCountNotas.Text = dvgItensSelecionados.Rows.Count.ToString();

                btnSelecionarTudo.Enabled = true;
                btnLimparTela.Enabled = true;
                return;
                
            }
            else
            {
                txtCountNotas.Text =  dvgConsultaNotas.RowCount.ToString();
                btnSelecionarTudo.Enabled = false;
                btnLimparTela.Enabled = false;
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

        private void AdicionarColunaSelecionar()
        {
            if (!dvgItensSelecionados.Columns.Contains("Selecionar"))
            {

                DataGridViewCheckBoxColumn coluna = new DataGridViewCheckBoxColumn();
                coluna.Name = "Selecionar";
                coluna.HeaderText = "✓";
                coluna.DataPropertyName = "Selecionar"; 
                coluna.Width = 80;
                coluna.ReadOnly = false; 

                dvgItensSelecionados.Columns.Insert(0, coluna);

            }
        }

        private void btnRelacionaItens_Click(object sender, EventArgs e)
        {
            if (dvgConsultaNotas.RowCount <= 0)
            {
                MessageBox.Show("Nenhum item para importar!");
                return;
            }

            var dtOriginal = (DataTable)dvgConsultaNotas.DataSource;

            // adiciona a coluna Qtd para Devolver se não existir
            if (!dtOriginal.Columns.Contains("Qtd para Devolver"))
            {
                DataColumn colQuantidade = new DataColumn("Qtd para Devolver", typeof(int));
                colQuantidade.DefaultValue = 0;
                dtOriginal.Columns.Add(colQuantidade);
            }

            // linhas com quantidade preenchida
            var linhasSelecionadas = dtOriginal.AsEnumerable()
                .Where(r => r.Field<int>("Qtd para Devolver") != 0)
                .ToList();

            bool existeCelulaVazia = false;
            bool existeValorIncorreto = false;

            // validações
            foreach (DataRow row in linhasSelecionadas)
            {
                string qtd = row["Qtd para Devolver"]?.ToString();
                int index = dtOriginal.Rows.IndexOf(row);

                if (string.IsNullOrWhiteSpace(qtd) || Convert.ToInt32(qtd) == 0)
                {
                    dvgConsultaNotas.Rows[index].DefaultCellStyle.BackColor = Color.LightSalmon;
                    existeCelulaVazia = true;
                }

                if (Convert.ToInt32(qtd) > Convert.ToInt32(row["Saldo Restante"]))
                {
                    dvgConsultaNotas.Rows[index].DefaultCellStyle.BackColor = Color.LightSalmon;
                    existeValorIncorreto = true;
                }
            }

            if (existeValorIncorreto)
            {
                MessageBox.Show("Existe algumas linhas que o valor de devolução está incorreto");
                return;
            }

            if (existeCelulaVazia)
            {
                MessageBox.Show("Existe algumas linhas que o valor de devolução não foi informado");
                return;
            }

            if (linhasSelecionadas.Count == 0)
            {
                MessageBox.Show("Nenhum item selecionado");
                return;
            }

            // -----------------------------------------
            // 🔥 FILTRAR REPETIDOS ANTES DE IMPORTAR
            // -----------------------------------------

            var linhasSemDuplicados = new List<DataRow>();

            foreach (DataRow row in linhasSelecionadas)
            {
                string documento = row["NumDocumento"].ToString();
                string idProduto = row["IDProduto"].ToString();
                int quantidade = Convert.ToInt32(row["Quantidade Venda"]);

                // só adiciona se NÃO existir no grid destino
                if (!ItemJaExisteNoDestino(documento, idProduto, quantidade))
                {
                    linhasSemDuplicados.Add(row);
                }
            }

            if (linhasSemDuplicados.Count == 0)
            {
                MessageBox.Show("Todos os itens já foram relacionados anteriormente.");
                return;
            }

            // importa somente itens não duplicados
            ImportaItemParaDvgItensSelecionado(linhasSemDuplicados);
        }


        private bool ItemJaExisteNoDestino(string documento, string idProduto, int quantidade)
        {
            foreach (DataGridViewRow row in dvgItensSelecionados.Rows)
            {
                if (row.IsNewRow) continue;

                string doc = row.Cells["NumDocumento"].Value?.ToString();
                string prod = row.Cells["IDProduto"].Value?.ToString();
                int qtd = Convert.ToInt32(row.Cells["Quantidade Venda"].Value);

                if (doc == documento && prod == idProduto && qtd == quantidade)
                {
                    return true; // encontrou duplicata
                }
            }

            return false;
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

        private void btnSelecionarTudo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvgItensSelecionados.Rows)
            {
                row.Cells["Selecionar"].Value = true;
            }            
        }

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            dvgItensSelecionados.DataSource = null;
        }

        private void cbFilial_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dvgConsultaNotas.DataSource;
            switch (cbFilial.SelectedIndex)
            {

                case 0:                    
                    dt.DefaultView.RowFilter = "";
                    break;

                case 1:
                    dt.DefaultView.RowFilter = "IDPessoaEmitente = 1";
                    break;

                case 2:
                    dt.DefaultView.RowFilter = "IDPessoaEmitente = 9";
                    break;
            }
           
        }
    }
}


//if (tabela.Columns.Contains("NomeDaColuna"))
//{
//    tabela.Columns.Remove("NomeDaColuna");
//}