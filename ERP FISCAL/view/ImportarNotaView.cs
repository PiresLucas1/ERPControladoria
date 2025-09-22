using ERP_FISCAL.controller;
using ERP_FISCAL.Controller;
using ERP_FISCAL.view;
using ERP_FISCAL.view.DialogUI;
using ERP_FISCAL.view.DialogUI.interfacesUI;
using ERP_FISCAL.view.interfaces;
using ERP_FISCAL.view.SubTipos;
using ERP_FISCAL.view.UIComponentes;
using ERP_FISCAL.view.UIComponentes.UIConsultaItem;
using ERP_FISCAL.view.UIComponentes.UIStatusDoProcessos;
using Microsoft.VisualBasic;
using SeuProjeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ERP_FISCAL.view.UIComponentes.UIStatusDoProcessos.StatusProcess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;



namespace ERP_FISCAL
{
    public partial class ImportarNotaView : Form
    {
        public string cfopSelecionado;
        public string valorDeCelula;
        public DataRow dataRowSelecionado;
        public int cellAlteracao;
        public int colAlteracao;
        public ImportarNotaView()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.ResizeForm);

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

            string[] itens = { "Periodo", "Chave de acesso" };
            coBoxTipeFilter.Items.AddRange(itens);
            coBoxTipeFilter.SelectedIndex = 0;
        }

        private async void btnListaNotas_Click(object sender, EventArgs e)
        {
            StatusProcess splashScreen = new StatusProcess();



            if (coBoxTipeFilter.SelectedIndex == 0) // datepicker
            {
                DateTime dataInicio = DtPickerInicio.Value.Date;
                DateTime dataFim = DtPickerFim.Value.Date;

                if (dataInicio == null) return;
                if (dataFim == null) return;
                try
                {
                    this.Enabled = false;

                    // Mostra a tela de carregamento
                    splashScreen.Show(this); // 'this' como owner para ficar modal
                    splashScreen.SetMessage("Carregando notas...");
                    splashScreen.UpdateProgress(30);

                    // Executa a consulta principal
                    splashScreen.SetMessage("Carregando notas fiscais...");

                    ExportServiceNotes exportServiceNotes = new ExportServiceNotes();
                    DataTable notas = await exportServiceNotes.ListServiceNotesAsync(dataInicio, dataFim);

                    dtImportacao.RowHeadersWidth = 20;
                    dtImportacao.EnableHeadersVisualStyles = false;
                    dtImportacao.RowHeadersDefaultCellStyle.BackColor = Color.White;
                    dtImportacao.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                    dtImportacao.DataSource = notas;
                    dtImportacao.AllowUserToAddRows = false;
                    dtImportacao.ReadOnly = false;
                    dtImportacao.AutoGenerateColumns = true;

                    splashScreen.SetMessage("Montando grade...");
                    splashScreen.UpdateProgress(70);
                    if (!dtImportacao.Columns.Contains("CFOP"))
                    {
                        int index = dtImportacao.Columns["Cód. Serviço TOTVS"].Index;

                        DataGridViewTextBoxColumn cfopColuna = new DataGridViewTextBoxColumn();

                        cfopColuna.Name = "CFOP";
                        cfopColuna.HeaderText = "CFOP";
                        cfopColuna.ReadOnly = false;
                        cfopColuna.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        cfopColuna.Width = 70;
                        dtImportacao.Columns.Add(cfopColuna);

                    }


                    if (!dtImportacao.Columns.Contains("Data Lançamento"))
                    {
                        int index = dtImportacao.Columns["CFOP"].Index;

                        var colData = new DataGridViewMaskedTextBoxColumn();
                        colData.Name = "Data Lançamento";
                        colData.HeaderText = "Data Lançamento";
                        colData.Mask = "00/00/0000";
                        colData.Width = 80;

                        dtImportacao.Columns.Add(colData);

                        colData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }


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
           

                    dtImportacao.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                    dtImportacao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    dtImportacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    dtImportacao.ColumnHeadersHeight = 30;

                    dtImportacao.DefaultCellStyle.SelectionBackColor = dtImportacao.DefaultCellStyle.BackColor;
                    dtImportacao.DefaultCellStyle.SelectionForeColor = dtImportacao.DefaultCellStyle.ForeColor;

                    if (!notas.Columns.Contains("Selecionar"))
                    {
                        DataColumn colCheck = new DataColumn("Selecionar", typeof(bool));
                        colCheck.DefaultValue = false;
                        notas.Columns.Add(colCheck);
                    }

                    dtImportacao.Columns["Selecionar"].DisplayIndex = 0;
                    dtImportacao.Columns["Selecionar"].HeaderText = "✓";
                    dtImportacao.Columns["Selecionar"].Width = 30;
                    dtImportacao.Columns["Selecionar"].Width = 30;

                    //ajusta colunas
                    int indexCodProduto = dtImportacao.Columns["Cód. Serviço TOTVS"].Index;
                    dtImportacao.Columns["CFOP"].DisplayIndex = indexCodProduto++;
                    dtImportacao.Columns["Retorno"].DisplayIndex = dtImportacao.Columns.Count - 1;


                    splashScreen.SetMessage("Finalizando...");
                    splashScreen.UpdateProgress(100);

                }
                catch (Exception ex)
                {
                    splashScreen.Close();
                    this.Enabled = true;
                    MessageBox.Show("Erro ao carregar notas: " + ex.Message);
                    
                }
                finally
                {
                    splashScreen.Close();
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
                ExportServiceNotes service = new ExportServiceNotes();

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

        private void btnExportarTotvs_Click(object sender, EventArgs e)
        {
            DataTable NotesChecks = new DataTable();
            foreach (DataGridViewColumn col in dtImportacao.Columns)
            {
                NotesChecks.Columns.Add(col.Name, col.ValueType ?? typeof(string));
            }

            foreach (DataGridViewRow row in dtImportacao.Rows)
            {
                if (row.IsNewRow)
                    continue;

                // Verifica se a linha está marcada
                bool selecionado = Convert.ToBoolean(row.Cells["Selecionar"].Value);
                if (!selecionado)
                    continue;

                DataRow newRow = NotesChecks.NewRow();
                foreach (DataGridViewColumn col in dtImportacao.Columns)
                {
                    newRow[col.Name] = row.Cells[col.Name].Value ?? DBNull.Value;
                }

                NotesChecks.Rows.Add(newRow);


            }
            ExportServiceNotes exportServiceNotes = new ExportServiceNotes();
            exportServiceNotes.ExportToTotvs(NotesChecks);

        }

        /* Ajusta tela conforme altera o tamanho dela */
        private void ResizeForm(object sender, EventArgs e)
        {
            int top = 300;
            int bottomSpacing = 10;
            int sideMargin = 10;
            int gbListarHeight = 100; // Altura aproximada do GBListar

            int widthWindow = this.ClientSize.Width;
            int heightWindow = this.ClientSize.Height;

            // Primeiro posicionar GBListar
            GBListar.Top = top - gbListarHeight - 10; // 10px de margem
            GBListar.Left = widthWindow - 350;

            // Depois ajustar DataGrid para começar depois do GBListar
            int dataGridTop = GBListar.Bottom + 10;

            dtImportacao.Top = dataGridTop;
            dtImportacao.Left = sideMargin;
            dtImportacao.Width = Math.Max(0, widthWindow - 2 * sideMargin);
            dtImportacao.Height = Math.Max(0, heightWindow - dataGridTop - bottomSpacing);

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
                CarregaCFOPController cfopController = new CarregaCFOPController();
                

                AbrirConsultaItem(e.RowIndex, Convert.ToInt32(codColigada), cfopController, "cfop");
            }

            if(colName == "Cód. Serviço TOTVS")
            {
                ProdutoServicoController produtoServicoController = new ProdutoServicoController();
                AbrirConsultaItem(e.RowIndex, Convert.ToInt32(codColigada), produtoServicoController, "cProduto");
            }
        }
        public void AbrirConsultaItem(int row, int codColigada, UIController data, string name)
        {
            ConsultaItem consultaItem = new ConsultaItem(row, codColigada, data, name, this);
            consultaItem.Show();
        }

        public void AtualizaCFOP(int index, string CFOPSelecionado)
        {
            dtImportacao.Rows[index].Cells["CFOP"].Value = CFOPSelecionado;

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
            if(dtImportacao == null)
            {
                MessageBox.Show("Não há informação na tabela");
                return;
            }
            var listaNatureza = await CarregaListaNatureza();
            List<int> linhasParaInserir = new List<int>();
            foreach (DataGridViewRow row in dtImportacao.Rows)
            {
                bool selecionado = Convert.ToBoolean(row.Cells["Selecionar"].Value);                
                    if (selecionado)
                    {
                        linhasParaInserir.Add(row.Index);
                    }                
            }
            if(linhasParaInserir.Count < 1)
            {
                MessageBox.Show("Nenhuma informação foi selecionada");
                return;
            }

            DialogoInsereInformacao dialogo = new DialogoInsereInformacao();
            dialogo.titulo = "CFOP";
            dialogo.dataTable = listaNatureza;

            using (var dialog = new DialogInsereInformacao(dialogo))
             {
              if (dialog.ShowDialog() == DialogResult.OK)
               {
                    foreach(int linha in linhasParaInserir)
                    {
                        AtualizaCFOP(linha,dialog.ValorDigitado);
                    }
               }
             }            
        }


        public async Task<DataTable> CarregaListaNatureza()
        {
            var carregaComboBoxCfop = new CarregaCFOPController();
            var lista = await carregaComboBoxCfop.CarregaTodos();

            return lista;
        }

        public void SelecionaValorProduto(string valor, int index)
        {
            var ProdutoFormatado = valor.Split('-');
            dtImportacao.Rows[index].Cells["Cód. Serviço TOTVS"].Value = ProdutoFormatado[0].Trim();
            ;
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
                textBox.KeyDown -= TextBox_KeyDown;
                textBox.KeyDown += TextBox_KeyDown;

                cellAlteracao = dtImportacao.CurrentCell.RowIndex;
                colAlteracaocolAlteracao = dtImportacao.CurrentCell.ColumnIndex;
            }
        }

        private async void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

            var textBox = sender as TextBox;
            string valorDigitado = textBox?.Text;
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede mudar de célula

               
                if (!string.IsNullOrEmpty(valorDigitado))
                {
                    ProdutoServicoController produtoController = new ProdutoServicoController();
                    var retorno = await produtoController.PegaValorUnicoPeloCodigo(valorDigitado);

                    Console.WriteLine(retorno);
                   
                    // opcional: atualizar a célula atual com o retorno
                    dtImportacao.CurrentCell.Value = retorno;
                }
            }
        }
        public async void ConsultaItemNaCelula(string valor)
        {
            string nomeColuna = dtImportacao.Columns[colAlteracao].Name;
            DataTable retorno = null;
            if (nomeColuna == "Cód. Serviço TOTVS")
            {

                ProdutoServicoController produtoController = new ProdutoServicoController();
                retorno = await produtoController.CarregaComOcorrencia(valor);
                Console.WriteLine(retorno);
            }
            if(nomeColuna == "CFOP")
            {
                CarregaCFOPController cFOPController = new CarregaCFOPController();
                retorno = await cFOPController.CarregaComOcorrencia(valor);

            }
            int linhaAtual = dtImportacao.CurrentCell.RowIndex -1;
            var codColigadaLinha = dtImportacao.Rows[linhaAtual].Cells["CODCOLIGADA"].Value?.ToString();

            if (retorno == null) return;

            foreach (DataRow item in retorno.Rows)
            {
                var codColigadaRetorno = item["CODCOLIGADA"].ToString();

                // Comparando se são iguais
                if (codColigadaRetorno == codColigadaLinha)
                {                 
                    string primeiroValorEncontrado = item["CODIGOPRD"].ToString();

                    // Atualizar célula atual com o valor desejado
                    dtImportacao.Rows[cellAlteracao].Cells["Cód. Serviço TOTVS"].Value = primeiroValorEncontrado;
                    break;
                }
            }
        }
        public void AlteraValorDataRow(DataRow rowValor, string name, int rowLinha)
        {
            dataRowSelecionado = rowValor;

            if(name == "cfop")
            {
                //Console.WriteLine(dataRowSelecionado[1]);              
                InsereValorNoDataGridView(rowLinha, dataRowSelecionado[1].ToString(), "CFOP");

            }
            if(name == "cProduto")
            {
                //Console.WriteLine(dataRowSelecionado[0]);
                InsereValorNoDataGridView(rowLinha, dataRowSelecionado[0].ToString(), "Cód. Serviço TOTVS");

            }
        }
        public void InsereValorNoDataGridView(int row, string valor, string coluna)
        {
            dtImportacao.Rows[row].Cells[coluna].Value = valor;
        }


    }
}
