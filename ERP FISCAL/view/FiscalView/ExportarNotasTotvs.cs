using ERP_FISCAL.controller;
using ERP_FISCAL.Controller;
using ERP_FISCAL.Utils;
using ERP_FISCAL.view.DialogUI;
using ERP_FISCAL.view.DialogUI.interfacesUI;
using ERP_FISCAL.view.interfaces;
using ERP_FISCAL.view.UIComponentes.UIConsultaItem;
using ERP_FISCAL.view.UIComponentes.UIStatusDoProcessos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ERP_FISCAL.Utils.DateParse;
using TextBox = System.Windows.Forms.TextBox;



namespace ERP_FISCAL
{
    public partial class ExportarNotasTotvs : Form
    {
        public string cfopSelecionado;
        public string valorDeCelula;
        public DataRow dataRowSelecionado;
        public DataGridViewRow cellAlteracao;
        public int colAlteracao;
        private DataTable dtOrignal;
        public ExportarNotasTotvs()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.ResizeForm);
            AplicarFonte.AplicarFonteForm(this, new System.Drawing.Font(this.Font.FontFamily, Properties.Settings.Default.FonteTamanho));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DtPickerInicio.Format = DateTimePickerFormat.Custom;
            DtPickerInicio.CustomFormat = "dd/MM/yyyy";
            DtPickerFim.Format = DateTimePickerFormat.Custom;
            DtPickerFim.CustomFormat = "dd/MM/yyyy";

            btnListaNotas.FlatStyle = FlatStyle.Flat;
            btnListaNotas.BackColor = Color.SteelBlue;
            btnListaNotas.ForeColor = Color.White;
            btnListaNotas.FlatAppearance.BorderSize = 0;
            btnListaNotas.AutoSize = true;

            btnSelecionarTodas.FlatStyle = FlatStyle.Flat;
            btnSelecionarTodas.BackColor = Color.SteelBlue;
            btnSelecionarTodas.ForeColor = Color.White;
            btnSelecionarTodas.FlatAppearance.BorderSize = 0;
            btnSelecionarTodas.AutoSize = true;

            btnDesmarcarTodos.FlatStyle = FlatStyle.Flat;
            btnDesmarcarTodos.BackColor = Color.SteelBlue;
            btnDesmarcarTodos.ForeColor = Color.White;
            btnDesmarcarTodos.FlatAppearance.BorderSize = 0;
            btnDesmarcarTodos.AutoSize = true;

            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.BackColor = Color.SteelBlue;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.AutoSize = true;

            btnExportarTotvs.FlatStyle = FlatStyle.Flat;
            btnExportarTotvs.BackColor = Color.SteelBlue;
            btnExportarTotvs.ForeColor = Color.White;
            btnExportarTotvs.FlatAppearance.BorderSize = 0;
            btnExportarTotvs.AutoSize = true;

            DtPickerInicio.Enabled = false;
            DtPickerFim.Enabled = false;
            txtBoxToFilter.Enabled = false;

            string[] itens = { "Periodo" };
            coBoxTipeFilter.Items.AddRange(itens);
            coBoxTipeFilter.SelectedIndex = 0;
        }
        private async void btnListaNotas_Click(object sender, EventArgs e)
        {
            
            if (dtImportacao.Rows.Count > 0 &&  dtImportacao.Columns[0].Frozen == true){
                dtImportacao.Columns[0].Frozen = false;

            }



            if (coBoxTipeFilter.SelectedIndex == 0) // datepicker
            {
                DateTime dataInicio = DtPickerInicio.Value.Date;
                DateTime dataFim = DtPickerFim.Value.Date;

                if (dataInicio == null) return;
                if (dataFim == null) return;
                if (txtBoxColigada.Text == "")
                    txtBoxColigada.Text = "0";

                try
                {
                    this.Enabled = false;

                    // Mostra a tela de carregamento
                    ProcessStatusManager.Start("Carregando dados...");
                    ProcessStatusManager.Update("Processando...");
                                        

                    NotasController exportServiceNotes = new NotasController();

                    DataTable notas = await exportServiceNotes.ListServiceNotesAsync(dataInicio, dataFim, Convert.ToInt32(txtBoxColigada.Text), cbLancadasNoERP.Checked);
                    

                    DataTable notasFormatada = exportServiceNotes.ReorganizarDataTable(notas);
                    dtOrignal = notasFormatada;



                    dtImportacao.RowHeadersWidth = 20;
                    dtImportacao.EnableHeadersVisualStyles = false;
                    dtImportacao.RowHeadersDefaultCellStyle.BackColor = Color.White;
                    dtImportacao.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                    dtImportacao.DataSource = notasFormatada;
                    dtImportacao.AllowUserToAddRows = false;
                    dtImportacao.ReadOnly = false;
                    dtImportacao.AutoGenerateColumns = true;
                    
                    

                    if (!dtImportacao.Columns.Contains("IDMov"))
                    {
                        dtImportacao.Columns.Add("IDMov", "IDMov");
                        dtImportacao.Columns["IDMov"].ReadOnly = true;
                    }

                    if (!dtImportacao.Columns.Contains("Retorno"))
                    {
                        dtImportacao.Columns.Add("Retorno", "Retorno");
                        dtImportacao.Columns["Retorno"].ReadOnly = true;
                    }


                    dtImportacao.AllowUserToResizeColumns = true;
                    dtImportacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dtImportacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                    dtImportacao.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                    dtImportacao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


                    dtImportacao.DefaultCellStyle.SelectionBackColor = dtImportacao.DefaultCellStyle.BackColor;
                    dtImportacao.DefaultCellStyle.SelectionForeColor = dtImportacao.DefaultCellStyle.ForeColor;

                    if (!notasFormatada.Columns.Contains("Selecionar"))
                    {
                        var colCheck = new DataColumn("Selecionar", typeof(bool))
                        {
                            DefaultValue = false
                        };
                        notasFormatada.Columns.Add(colCheck);
                    }

                    dtImportacao.Columns["Selecionar"].DisplayIndex = 0;
                    dtImportacao.Columns["Selecionar"].HeaderText = "✓";
                    dtImportacao.Columns["Selecionar"].Width = 30;
                    dtImportacao.Columns["Selecionar"].Width = 30;

                    //colunas invisiveis  ----------------------------------------
                    dtImportacao.Columns["ErpSitucaoContasPagar"].Visible = false;
                    dtImportacao.Columns["IdErpTitulo"].Visible = false;
                    dtImportacao.Columns["ErpSitucaoTitulo"].Visible = false;

                    //ajuste de colunas ------------------------------------------

                    foreach (DataGridViewColumn col in dtImportacao.Columns)
                    {
                        col.ReadOnly = true;
                       //col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                    dtImportacao.Columns["Data Lançamento"].ReadOnly = false;
                    dtImportacao.Columns["Cód. Serviço TOTVS"].ReadOnly = false;
                    dtImportacao.Columns["CFOP"].ReadOnly = false;
                    dtImportacao.Columns["Selecionar"].ReadOnly = false;

                    dtImportacao.Columns["Cód. Serviço TOTVS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtImportacao.Columns["CFOP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtImportacao.Columns["Descrição"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtImportacao.Columns["CFOP Descrição"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    dtImportacao.Columns["Razão Social Prestador"].Frozen = true;

                    // finalização de ajuste ----------------------------------------

                    
                  

                }
                catch (Exception ex)
                {
                    ProcessStatusManager.Error(ex); // Fecha e mostra o erro
                    this.Enabled = true;                    

                }
                finally
                {
                    ProcessStatusManager.Stop(); // Garante o fechamento
                    this.Enabled = true;
                    this.BringToFront();
                    this.Activate();
                }
            }
            else
            {
                string filterValue;

                filterValue = coBoxTipeFilter.SelectedItem.ToString();
                if (filterValue == null)
                {
                    return;
                }
                NotasController service = new NotasController();

                DataTable dt;
                dt = await service.FindUniqueNoteAsync(filterValue);


                foreach (DataGridViewRow row in dtImportacao.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }


            }

        }
        private void btnSelecionarTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtImportacao.Rows)
            {
                row.Cells["Selecionar"].Value = true;
            }
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtImportacao.Rows)
            {
                row.Cells["Selecionar"].Value = false;
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            DtPickerInicio.Value = DateTime.Today;
            DtPickerFim.Value = DateTime.Today;


            // Limpa a grid
            dtImportacao.DataSource = null;

            // Remove a coluna CFOP se existir
            if (dtImportacao.Columns.Contains("CFOP"))
                dtImportacao.Columns.Remove("CFOP");


            // Remove a coluna CFOP se existir
            if (dtImportacao.Columns.Contains("Data Lançamento"))
                dtImportacao.Columns.Remove("Data Lançamento");

            if (dtImportacao.Columns.Contains("..."))
                dtImportacao.Columns.Remove("...");

            // Desmarca todos os checkboxes (se ainda houver dados na grid)
            foreach (DataGridViewRow row in dtImportacao.Rows)
            {
                if (row.Cells["Selecionado"] is DataGridViewCheckBoxCell chk)
                    chk.Value = false;
            }
        }

        private async void btnExportarTotvs_Click(object sender, EventArgs e)
        {
            NotasController exportServiceNotes = new NotasController();
            var dtOriginal = (DataTable)dtImportacao.DataSource;
            if(dtOriginal == null)
            {
                MessageBox.Show("Não há dados para exportar");
                return;
            }
            var linhasSelecionadas = dtOriginal.AsEnumerable()
                .Where(r => r.Field<bool>("Selecionar"))
                .ToList();

            await exportServiceNotes.ExportToTotvs(dtOriginal, linhasSelecionadas);

            VerificaLinha();
        }

        private void VerificaLinha()
        {
            foreach (DataGridViewRow row in dtImportacao.Rows)
            {

                var valorRetorno = row.Cells["Retorno"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(valorRetorno))
                {
                    if (valorRetorno.Contains("Sucesso"))
                    {
                        row.DefaultCellStyle.BackColor = Color.LimeGreen; // Cor da linha
                        row.DefaultCellStyle.ForeColor = Color.Black;      // Cor do texto
                    }
                    row.DefaultCellStyle.BackColor = Color.LightSalmon; // Cor da linha
                    row.DefaultCellStyle.ForeColor = Color.Black;      // Cor do texto
                }
            }


        }

        /* Ajusta tela conforme altera o tamanho dela */
        private void ResizeForm(object sender, EventArgs e)
        {
            int bottomSpacing = 10;   // distância da janela até os botões
            int sideMargin = 10;      // margem lateral
            int buttonHeight = 30;    // altura dos botões
            int buttonSpacing = 5;    // espaçamento entre botões
            int gridButtonSpacing = 30; // distância entre DataGridView e botões

            int widthWindow = this.ClientSize.Width;
            int heightWindow = this.ClientSize.Height;

            // GroupBox (fixo no topo)
            groupBox1.Left = sideMargin;
            groupBox1.Top = sideMargin;
            groupBox1.Width = widthWindow - 2 * sideMargin;



            // Botões na parte de baixo
            int btnY = heightWindow - buttonHeight - bottomSpacing;

            btnSelecionarTodas.Top = btnY;
            btnDesmarcarTodos.Top = btnY;
            btnInserirEmBloco.Top = btnY;
            btnLimpar.Top = btnY;
            btnExportarTotvs.Top = btnY;

            // Posicionamento dos botões em sequência
            btnSelecionarTodas.Left = sideMargin;
            btnDesmarcarTodos.Left = btnSelecionarTodas.Right + buttonSpacing;
            btnInserirEmBloco.Left = btnDesmarcarTodos.Right + buttonSpacing;
            btnLimpar.Left = btnInserirEmBloco.Right + buttonSpacing;

            // Exportar no canto direito
            btnExportarTotvs.Left = widthWindow - btnExportarTotvs.Width - sideMargin;

            // DataGridView — mantém 30px entre o grid e os botões
            dtImportacao.Left = sideMargin;
            dtImportacao.Top = groupBox1.Bottom + sideMargin;
            dtImportacao.Width = widthWindow - 2 * sideMargin;
            dtImportacao.Height = btnSelecionarTodas.Top - dtImportacao.Top - gridButtonSpacing;

            int pesquisarRightMargin = 20; // Margem direita dentro do GroupBox
            btnListaNotas.Left = groupBox1.Width - btnListaNotas.Width - pesquisarRightMargin;
        }
        private void coBoxTipeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(coBoxTipeFilter.SelectedIndex);

            if (coBoxTipeFilter.SelectedIndex == 0) //filtro intervalo de data
            {
                DtPickerInicio.Enabled = true;
                DtPickerFim.Enabled = true;
                txtBoxToFilter.Enabled = false;
            }
            if (coBoxTipeFilter.SelectedIndex == 1) //filtro chave de acesso
            {
                txtBoxToFilter.Enabled = true;
                DtPickerInicio.Enabled = false;
                DtPickerFim.Enabled = false;
            }
        }

        private void dtImportacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignora header

            var colName = dtImportacao.Columns[e.ColumnIndex].Name;
            var codColigada = dtImportacao.Rows[e.RowIndex].Cells["CodColigada"].Value;
            var cnpjPrestador = dtImportacao.Rows[e.RowIndex].Cells["CNPJ Prestador"].Value;
            var codVerificacao = dtImportacao.Rows[e.RowIndex].Cells["Código Verificação"].Value;
            var numDoc = dtImportacao.Rows[e.RowIndex].Cells["Documento"].Value;
            var razaoSocial = dtImportacao.Rows[e.RowIndex].Cells["Razão Social Prestador"].Value;

            if (colName == "CFOP")
            {
                CfopController cfopController = new CfopController();


                AbrirConsultaItem(dtImportacao.Rows[e.RowIndex], Convert.ToInt32(codColigada), cfopController, "Consulta CFOP");
            }

            if (colName == "Cód. Serviço TOTVS")
            {
                ProdutoServicoController produtoServicoController = new ProdutoServicoController();
                AbrirConsultaItem(dtImportacao.Rows[e.RowIndex], Convert.ToInt32(codColigada), produtoServicoController, "Consulta Produto");
            }
        }
        public void AbrirConsultaItem(DataGridViewRow row, int codColigada, UIController data, string name)
        {
            ConsultaItem consultaItem = new ConsultaItem(row, codColigada, data, name, this);
            consultaItem.Show();
        }

        public void AtualizaCFOP(int index, string cfopSelecionado)
        {
            CfopController cFOPController = new CfopController();
            ValidaValorDeCelulaCfop(cfopSelecionado, cFOPController, index, "CFOP", "CFOP Descrição");


        }
        public void AtualizaProduto(int index, string cProduto)
        {
            ProdutoServicoController produtoServico = new ProdutoServicoController();
            ValidaValorDeCelulaCProduto(cProduto, produtoServico, index, "Cód. Serviço TOTVS", "Descrição");

        }
        public void AtualizaDataLancamento(int index, string dataLancamento)
        {
            dtImportacao.Rows[index].Cells["Data Lançamento"].Value = dataLancamento;
        }
        public DtoFormNotaParaNatureza PegaInformacaoParaNatureza(int index)
        {

            if (index > dtImportacao.RowCount - 1)
            {
                MessageBox.Show("Não há mais notas para percorrer");
                return null;
            }
            var codColigada = dtImportacao.Rows[index].Cells["CodColigada"].Value.ToString();
            var cnpjPrestador = dtImportacao.Rows[index].Cells["CNPJ Prestador"].Value.ToString();
            var codVerificacao = dtImportacao.Rows[index].Cells["Código Verificação"].Value.ToString();
            var numDoc = dtImportacao.Rows[index].Cells["Documento"].Value.ToString();
            var razaoSocial = dtImportacao.Rows[index].Cells["Razão Social Prestador"].Value.ToString();
            var quantidade = dtImportacao.RowCount - 1;
            var informacaoParaNatureza = new DtoFormNotaParaNatureza
            {
                CodColigada = codColigada,
                CnpjPrestador = cnpjPrestador,
                CodVerificacao = codVerificacao,
                NumDoc = numDoc,
                QuantidadeNotas = quantidade,
                RazaoSocial = razaoSocial
            };
            return informacaoParaNatureza;
        }
        private async void btnInserirEmBloco_Click(object sender, EventArgs e)
        {
            if (dtImportacao == null)
            {
                MessageBox.Show("Não há informação na tabela");
                return;
            }
            var listaNatureza = await CarregaListaNatureza(0);
            List<int> linhasParaInserir = new List<int>();
            foreach (DataGridViewRow row in dtImportacao.Rows)
            {
                bool selecionado = Convert.ToBoolean(row.Cells["Selecionar"].Value);
                if (selecionado)
                {
                    linhasParaInserir.Add(row.Index);
                }
            }
            if (linhasParaInserir.Count < 1)
            {
                MessageBox.Show("Nenhuma informação foi selecionada");
                return;
            }

            var dialogo = new DialogoInsereInformacao
            {
                titulo = "Cód. Serviço Totvs",
                dataTable = listaNatureza
            };
            
            using (var dialog = new InsercaoBloco(dialogo))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (int linha in linhasParaInserir)
                    {
                        if (dialog.cfopCbox.Checked)
                        {
                            AtualizaCFOP(linha, dialog.valorCfop);
                        }

                        if (dialog.cProdutoCbox.Checked)
                        {
                            AtualizaProduto(linha, dialog.valorProduto);
                        }

                        if (dialog.dataLancamentoCbox.Checked)
                        {
                            AtualizaDataLancamento(linha, dialog.valorData);
                        }
                    }
                }
            }
            MessageBox.Show("Existe algumas informações que não existe em determinadas coligadas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        public async Task<DataTable> CarregaListaNatureza(int codColigada)
        {
            var carregaComboBoxCfop = new CfopController();
            var lista = await carregaComboBoxCfop.CarregaTodos(codColigada);

            return lista;
        }

        public void SelecionaValorProduto(string valor, int index)
        {
            var ProdutoFormatado = valor.Split('-');
            dtImportacao.Rows[index].Cells["Cód. Serviço TOTVS"].Value = ProdutoFormatado[0].Trim();

        }

        private void TextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                var cellParaTextBox = sender as TextBox;

                ConsultaItemNaCelula(cellParaTextBox.Text);

            }
        }
        private void dtImportacao_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {

                textBox.PreviewKeyDown -= TextBox_PreviewKeyDown;
                textBox.PreviewKeyDown += TextBox_PreviewKeyDown;


                cellAlteracao = dtImportacao.CurrentRow;
                colAlteracao = dtImportacao.CurrentCell.ColumnIndex;
            }
        }

        private async void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //não esta sendo utilizado - remover depois
            var textBox = sender as TextBox;
            string valorDigitado = textBox?.Text;
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true; // impede mudar de célula


                if (!string.IsNullOrEmpty(valorDigitado))
                {
                    ProdutoServicoController produtoController = new ProdutoServicoController();
                    var retorno = await produtoController.PegaValorUnicoPeloCodigo(valorDigitado);


                    // opcional: atualizar a célula atual com o retorno
                    dtImportacao.CurrentCell.Value = retorno;
                }
            }
        }
        public async void ConsultaItemNaCelula(string valor)
        {
            string nomeColuna = dtImportacao.Columns[colAlteracao].Name;
            if (nomeColuna == "Data Lançamento")
            {
                string valorDataFormatado = FormatarDataDigitada(valor);

                // 🟢 Força o encerramento da edição
                dtImportacao.EndEdit();

                // 🟢 Agora a célula realmente pode ser alterada
                dtImportacao.Rows[cellAlteracao.Index].Cells[nomeColuna].Value = valorDataFormatado;

                // 🟢 Atualiza visualmente
                dtImportacao.RefreshEdit();
                dtImportacao.Refresh();

                return;
            }
            // define variaveis para localizar colunas no datagridview
            var itemColunaValor = "";
            var itemColunaDescricao = "";

            DataTable retorno = new DataTable();
            DataGridViewRow linhaAtual = dtImportacao.CurrentRow;
            var codColigadaLinha = dtImportacao.Rows[linhaAtual.Index].Cells["CODCOLIGADA"].Value?.ToString();

            retorno = retorno.DefaultView.ToTable(true);

            if (nomeColuna == "Cód. Serviço TOTVS")
            {

                ProdutoServicoController produtoController = new ProdutoServicoController();
                retorno = await produtoController.CarregaComOcorrencia(valor, Convert.ToInt32(codColigadaLinha));
                itemColunaValor = "CODIGOPRD";
                itemColunaDescricao = "DESCRICAO";
            }
            if (nomeColuna == "CFOP")
            {
                CfopController cFOPController = new CfopController();
                retorno = await cFOPController.CarregaComOcorrencia(valor, Convert.ToInt32(codColigadaLinha));
                itemColunaValor = "COD. NATUREZA";
                itemColunaDescricao = "DESCRIÇÃO NATUREZA";

            }

            if (retorno == null) return;

            DataTable dataRetorno = retorno;
            string valorEncontrado = "";
            string valorDescricaoEncontrado = "";



            if (dataRetorno.Rows.Count > 1)
            {
                if (nomeColuna == "CFOP")
                {
                    CfopController cFOPController = new CfopController();
                    ConsultaItem consultaItem = new ConsultaItem(linhaAtual, Convert.ToInt32(codColigadaLinha), cFOPController, "Consulta CFOP", this);
                    await consultaItem.PesquisaValorPorString(valor);
                    //AbrirConsultaItem(e.RowIndex, Convert.ToInt32(codColigada), cfopController, "cfop");
                    consultaItem.Show();
                    return;
                }
                if (nomeColuna == "Cód. Serviço TOTVS")
                {
                    ProdutoServicoController cProdutoCotroller = new ProdutoServicoController();
                    ConsultaItem consultaItem = new ConsultaItem(linhaAtual, Convert.ToInt32(codColigadaLinha), cProdutoCotroller, "Consulta Produto", this);
                    await consultaItem.PesquisaValorPorString(valor);
                    //AbrirConsultaItem(e.RowIndex, Convert.ToInt32(codColigada), cfopController, "cfop");
                    consultaItem.Show();
                    return;
                }
            }

            if (dataRetorno.Rows.Count < 1)
            {
                MessageBox.Show("Não foi possivel localizar");
                return;
            }

            if (nomeColuna == "CFOP")
            {

                valorEncontrado = dataRetorno.Rows[0]["COD. NATUREZA"].ToString();
                valorDescricaoEncontrado = dataRetorno.Rows[0]["DESCRIÇÃO NATUREZA"].ToString();
            }
            if (nomeColuna == "Cód. Serviço TOTVS")
            {
                valorEncontrado = dataRetorno.Rows[0]["CODIGOPRD"].ToString();
                valorDescricaoEncontrado = dataRetorno.Rows[0]["DESCRICAO"].ToString();
            }
            if (dataRetorno.Rows.Count == 1)
            {
                if (nomeColuna == "Cód. Serviço TOTVS")
                {
                    dtImportacao.Rows[cellAlteracao.Index].Cells[nomeColuna].Value = valorEncontrado;
                    dtImportacao.Rows[cellAlteracao.Index].Cells["Descrição"].Value = valorDescricaoEncontrado;
                }
                if (nomeColuna == "CFOP")
                {
                    string ufPrestador = dtImportacao.Rows[cellAlteracao.Index].Cells["UF Prestador"].Value.ToString();
                    string ufTomador = dtImportacao.Rows[cellAlteracao.Index].Cells["UF Tomador"].Value.ToString();
                    string filial = dtImportacao.Rows[cellAlteracao.Index].Cells["CodFilial"].Value.ToString();

                    string codColigada = dtImportacao.Rows[cellAlteracao.Index].Cells["CodColigada"].Value.ToString();

                    if(ufTomador != "")
                    {
                        if (Convert.ToInt32(codColigada) == 2)
                        {
                            ValidaNaturezaFilial validaNatureza = new ValidaNaturezaFilial();
                            bool validacao = validaNatureza.ValidaCodigoNaturezaFilial(valorEncontrado, Convert.ToInt32(filial), ufTomador, ufPrestador);

                            if (!validacao)
                            {
                                dtImportacao.Rows[cellAlteracao.Index].Cells[nomeColuna].Value = "";
                                return;
                            }
                        }
                    }
                    //validaNatureza.ValidaCodigoNaturezaFilial()
                    dtImportacao.Rows[cellAlteracao.Index].Cells[nomeColuna].Value = valorEncontrado;
                    dtImportacao.Rows[cellAlteracao.Index].Cells["CFOP Descrição"].Value = valorDescricaoEncontrado;
                }
                return;
            }

            return;

        }
        public void AlteraValorDataRow(DataRow rowValor, string name, DataGridViewRow rowLinha)
        {
            dataRowSelecionado = rowValor;

            if (name == "Consulta CFOP")
            {
                var valor = dataRowSelecionado["COD. NATUREZA"].ToString().Trim();
                var valorDescricao = dataRowSelecionado["DESCRIÇÃO NATUREZA"].ToString().Trim();

                string ufPrestador = dtImportacao.Rows[rowLinha.Index].Cells["UF Prestador"].Value.ToString();
                string ufTomador = dtImportacao.Rows[rowLinha.Index].Cells["UF Tomador"].Value.ToString();
                string filial = dtImportacao.Rows[rowLinha.Index].Cells["CodFilial"].Value.ToString();
                if(ufTomador != "")
                {                
                    ValidaNaturezaFilial validaNatureza = new ValidaNaturezaFilial();

                    string codColigada = dtImportacao.Rows[cellAlteracao.Index].Cells["CodColigada"].Value.ToString();
                    if (Convert.ToInt32(codColigada) == 2)
                    {

                        bool validacao = validaNatureza.ValidaCodigoNaturezaFilial(valor, Convert.ToInt32(filial), ufTomador, ufPrestador);

                        if (!validacao)
                        {
                            return;
                        }
                    }
                }

                InsereValorNoDataGridView(rowLinha.Index, valor, "CFOP");
                InsereValorNoDataGridView(rowLinha.Index, valorDescricao, "CFOP Descrição");


            }
            if (name == "Consulta Produto")
            {
                var valor = dataRowSelecionado["CODIGOPRD"].ToString().Trim();
                var valorDescricao = dataRowSelecionado["DESCRICAO"].ToString().Trim();

                InsereValorNoDataGridView(rowLinha.Index, dataRowSelecionado[0].ToString(), "Cód. Serviço TOTVS");
                InsereValorNoDataGridView(rowLinha.Index, valorDescricao, "Descrição");

            }
        }
        public void InsereValorNoDataGridView(int row, string valor, string coluna)
        {
            dtImportacao.Rows[row].Cells[coluna].Value = valor;
        }

        public async void ValidaValorDeCelulaCfop(string valor, UIController controller, int index, string valorCelula1, string valorCelula2)
        {

            var retorno = await controller.PegaValorUnicoPeloCodigo(valor);
            var codColigadaLinha = dtImportacao.Rows[index].Cells["CODCOLIGADA"].Value?.ToString();
            DataRow valorRow = null;


            foreach (DataRow row in retorno.Rows)
            {
                var codColigadaRetorno = row["CODCOLIGADA"].ToString();

                if (codColigadaRetorno == codColigadaLinha)
                {
                    valorRow = row;
                }

            }
            if (valorRow == null)
            {
                return;
            }
            dtImportacao.Rows[index].Cells[valorCelula1].Value = valorRow["IDNATUREZA"].ToString();
            dtImportacao.Rows[index].Cells[valorCelula2].Value = valorRow["DESCRIÇÃO NATUREZA"].ToString();

        }
        public async void ValidaValorDeCelulaCProduto(string valor, UIController controller, int index, string valorCelula1, string valorCelula2)
        {

            var retorno = await controller.PegaValorUnicoPeloCodigo(valor);
            var codColigadaLinha = dtImportacao.Rows[index].Cells["CODCOLIGADA"].Value?.ToString();
            DataRow valorRow = null;


            foreach (DataRow row in retorno.Rows)
            {
                var codColigadaRetorno = row["CODCOLIGADA"].ToString();

                if (codColigadaRetorno == codColigadaLinha)
                {
                    valorRow = row;
                }

            }
            if (valorRow == null)
            {
                //mensagemErro += "Valor: " + valor + " Não encontrado para coligada: " + codColigadaLinha;
                return;
            }
            dtImportacao.Rows[index].Cells[valorCelula1].Value = valorRow["CODIGOPRD"].ToString();
            dtImportacao.Rows[index].Cells[valorCelula2].Value = valorRow["DESCRICAO"].ToString();

        }
        public void CarregaDadosDoDataTable(DataTable data)
        {
            dtImportacao.DataSource = data;
            if (!dtOrignal.Columns.Contains("Selecionar"))
            {
                var colCheck = new DataColumn("Selecionar", typeof(bool))
                {
                    DefaultValue = false
                };

                dtOrignal.Columns.Add(colCheck);
            }

            dtImportacao.Columns["Selecionar"].DisplayIndex = 0;
            dtImportacao.Columns["Selecionar"].HeaderText = "✓";
            dtImportacao.Columns["Selecionar"].Width = 30;
            dtImportacao.Columns["Selecionar"].Width = 30;
        }
        private void dtImportacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora cliques no header

            // Remove a seleção de todas as linhas
            dtImportacao.ClearSelection();

            // Destaca a linha clicada
            dtImportacao.Rows[e.RowIndex].Selected = true;

            // Opcional: Define cores personalizadas para a linha selecionada
            dtImportacao.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dtImportacao.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtImportacao.Rows.Count != 0)
            {
                DataTable dataTableOriginal = (DataTable)dtImportacao.DataSource;
                DataTable dataTableRetorno = dataTableOriginal.Clone();
                string valorFiltro = "";

                if (txtCnpjFor.Text != "")
                {

                    valorFiltro = txtCnpjFor.Text;
                    foreach (DataRow row in dataTableOriginal.Rows)
                    {
                        if (row["CNPJ Prestador"].ToString().Contains(valorFiltro))
                        {
                            dataTableRetorno.ImportRow(row);
                        }
                    }
                    dtImportacao.DataSource = dataTableRetorno;
                    return;
                }


              
                valorFiltro = txtBoxNumDoc.Text;
                if (valorFiltro == "")
                {
                    dtImportacao.DataSource = dtOrignal;
                    return;
                }
                foreach (DataRow row in dataTableOriginal.Rows)
                {
                    if (row["Documento"].ToString() == valorFiltro)
                    {
                        dataTableRetorno.ImportRow(row);
                    }
                }
                dtImportacao.DataSource = dataTableRetorno;
                return;
            }
            MessageBox.Show("Não existe nenhum dado na tabela");
        }
        private void FiltraLinhaComErro()
        {
            var dt = dtImportacao.DataSource as DataTable;
            if (dt == null) return;

            if (checkBoxMostraComErro.Checked)
            {
                dt.DefaultView.RowFilter = "[Retorno] IS NOT NULL AND [Retorno] <> ''";
                VerificaLinha();
            }
            else
            {
                dt.DefaultView.RowFilter = string.Empty; // limpa o filtro
                VerificaLinha();
            }

        }

        private void checkBoxMostraComErro_CheckedChanged(object sender, EventArgs e)
        {
            FiltraLinhaComErro();
        }

        private void btnAutoPreencherCfop_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow linha in dtImportacao.Rows)
            {
                string filial = linha.Cells["CodFilial"].Value.ToString(); 
                string codColigada = linha.Cells["CodColigada"].Value.ToString(); 
                string ufTomador = linha.Cells["UF Tomador"].Value.ToString();
                string ufPrestador = linha.Cells["UF Prestador"].Value.ToString();



                if (Convert.ToInt32(filial) != 1 && Convert.ToInt32(codColigada) == 2)
                {
                  
                  if (ufPrestador == ufTomador) 
                  {
                      linha.Cells["CFOP"].Value = "1.933.008";
                      linha.Cells["CFOP Descrição"].Value = "AQUISIÇÃO DE SERVIÇOS - FILIAL";
                  }
                  else
                  {
                      linha.Cells["CFOP"].Value = "2.933.006";
                      linha.Cells["CFOP Descrição"].Value = "AQUISIÇÃO DE SERVIÇOS - FILIAL";
                  }
                }

            }
            MessageBox.Show("CFOPs preenchidos automaticamente conforme regras definidas.");
        }


    }
}
