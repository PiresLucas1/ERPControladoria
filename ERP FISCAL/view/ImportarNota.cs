using ERP_FISCAL.controller;
using ERP_FISCAL.view;
using ERP_FISCAL.view.interfaces;
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
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ERP_FISCAL
{
    public partial class ImportarNota : Form
    {
        public string cfopSelecionado;
        public ImportarNota()
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


            if (coBoxTipeFilter.SelectedIndex == 0) // datepicker
            {
                DateTime dataInicio = DtPickerInicio.Value.Date;
                DateTime dataFim = DtPickerFim.Value.Date;

                if (dataInicio == null) return;
                if (dataFim == null) return;
                try
                {



                    groupLoading.Visible = true;
                    groupLoading.Text = "Carregando notas...";
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    progressBar1.Visible = true;

                    //// Executa em outra thread sem travar a UI
                    //DataTable notas = await Task.Run(() =>
                    //{
                    //    Carregar_Colunas util = new Carregar_Colunas();
                    //    return util.ObterNotas(dataInicio, dataFim);
                    //});

                    ExportServiceNotes exportServiceNotes = new ExportServiceNotes();
                    DataTable notas = await exportServiceNotes.ListServiceNotesAsync(dataInicio, dataFim);

                    dtImportacao.RowHeadersWidth = 20;
                    dtImportacao.EnableHeadersVisualStyles = false;
                    dtImportacao.RowHeadersDefaultCellStyle.BackColor = Color.White;
                    dtImportacao.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                    dtImportacao.DataSource = notas;
                    dtImportacao.AllowUserToAddRows = false;
                    dtImportacao.ReadOnly = false;

                    if (!dtImportacao.Columns.Contains("CFOP"))
                    {
                        int index = dtImportacao.Columns["Cód. Serviço TOTVS"].Index;

                        var cfopColuna = new DataGridViewTextBoxColumn();
                        cfopColuna.Name = "CFOP";
                        cfopColuna.HeaderText = "CFOP";
                        cfopColuna.ReadOnly = false;
                        cfopColuna.Width = 60;

                        dtImportacao.Columns.Insert(index + 1, cfopColuna);
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

                    if (!dtImportacao.Columns.Contains("Cod. Produto"))
                    {
                        dtImportacao.Columns.Add("CodProduto", "Cod. Produto");
                        dtImportacao.Columns["CodProduto"].ReadOnly = false;
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
                    groupLoading.Text = $"Notas carregadas: {notas.Rows.Count}";

                    dtImportacao.Columns["Selecionar"].DisplayIndex = 0;
                    dtImportacao.Columns["Selecionar"].HeaderText = "✓";
                    dtImportacao.Columns["Selecionar"].Width = 30;
                    dtImportacao.Columns["Selecionar"].Width = 30;




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar notas: " + ex.Message);
                    groupLoading.Text = "Erro ao carregar.";
                }
                finally
                {
                    progressBar1.Visible = false;
                    groupLoading.Visible = false;
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

            // Limpa status
            groupLoading.Text = "";
            groupLoading.Text = "";

            // Limpa a grid
            dtImportacao.DataSource = null;

            // Remove a coluna CFOP se existir
            if (dtImportacao.Columns.Contains("CFOP"))
                dtImportacao.Columns.Remove("CFOP");
            if (dtImportacao.Columns.Contains("CodProduto"))
                dtImportacao.Columns.Remove("CodProduto");

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
                foreach(DataGridViewColumn col in dtImportacao.Columns)
                {
                    newRow[col.Name] = row.Cells[col.Name].Value ?? DBNull.Value;
                }

                NotesChecks.Rows.Add(newRow);

                
            }
            ExportServiceNotes exportServiceNotes = new ExportServiceNotes();
            exportServiceNotes.ExportToTotvs(NotesChecks);
            
        }

        private void dtImportacao_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Apenas evita que a exceção estoure para o usuário
            e.Cancel = true;
        }

        private void ResizeForm(object sender, EventArgs e)
        {
            // configurações desejadas
            int top = 300;
            int bottomSpacing = 100;
            int sideMargin = 10; // margem esquerda/direita (ajuste se quiser)

            int widthWindow = this.ClientSize.Width;
            int heightWindow = this.ClientSize.Height;

           
            // aplica posição e tamanho
            dtImportacao.Top = top;
            dtImportacao.Left = sideMargin;
            dtImportacao.Width = Math.Max(0, widthWindow - 2 * sideMargin); // garante não ficar negativo
            dtImportacao.Height = Math.Max(0, heightWindow - top - bottomSpacing); // garante não ficar negativo

            //Console.WriteLine($"largura:{widthWindow} / altura:{heightWindow} -> dt.Width:{dtImportacao.Width} dt.Height:{dtImportacao.Height}");
            ResizeComponentForm(sender, e);
        }

        private void ResizeComponentForm(object sender, EventArgs e)
        {

            int widthWindow = this.ClientSize.Width;

            GBListar.Top = 230;
            GBListar.Left = widthWindow - 350;

            groupLoading.Top = this.ClientSize.Height - 65;

        }

        private void coBoxTipeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(coBoxTipeFilter.SelectedIndex);
            
            if(coBoxTipeFilter.SelectedIndex == 0) //filtro intervalo de data
            {
                DtPickerInicio.Enabled = true;
                DtPickerFim.Enabled = true;
                txtBoxToFilter.Enabled = false;
            }
            if(coBoxTipeFilter.SelectedIndex == 1) //filtro chave de acesso
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
                AbrirSelecaoCFOP(e.RowIndex, Convert.ToInt32(codColigada), cnpjPrestador.ToString(), codVerificacao.ToString(), numDoc.ToString(), razaoSocial.ToString());
            }
        }

        public void AbrirSelecaoCFOP(int rowIndex, int codColigada, string cnpjPrestador, string codVerificacao, string numDoc, string razaoSocial)
        {
            
            NaturezaFiscalType notaInstancia = new NaturezaFiscalType
            {
                ReqCodColigada = codColigada,
                ReqIndexCelula = rowIndex,
                CnpjPrestador = cnpjPrestador,
                CodVerificacao = codVerificacao,
                NumDoc = numDoc,
                FormFocus = this,
                RazaoSocial = razaoSocial
            };
            var frm = new NaturezaFiscal(notaInstancia);
            frm.Show();

        }
        public void AtualizaCFOP(int index, string CFOPSelecionado)
        {
            dtImportacao.Rows[index].Cells["CFOP"].Value = CFOPSelecionado;
           
        }
        public DtoFormNotaParaNatureza PegaInformacaoParaNatureza(int index)
        {

            if(index > dtImportacao.RowCount - 1)
            {
                MessageBox.Show("Não há mais notas para percorrer");
                return null; 
            }
            var codColigada = dtImportacao.Rows[index].Cells["CodColigada"].Value.ToString();
            var cnpjPrestador = dtImportacao.Rows[index].Cells["CNPJ Prestador"].Value.ToString();
            var codVerificacao = dtImportacao.Rows[index].Cells["Código Verificação"].Value.ToString();
            var numDoc = dtImportacao.Rows[index].Cells["Documento"].Value.ToString();
            var razaoSocial = dtImportacao.Rows[index].Cells["Razão Social Prestador"].Value.ToString();
            var quantidade = dtImportacao.RowCount -1;
            var informacaoParaNatureza = new DtoFormNotaParaNatureza
            {
                CodColigada = codColigada,
                CnpjPrestador =cnpjPrestador,
                CodVerificacao = codVerificacao,
                NumDoc = numDoc,
                QuantidadeNotas = quantidade,
                RazaoSocial = razaoSocial
            };
            return informacaoParaNatureza;
        }

    }




}
