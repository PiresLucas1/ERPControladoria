namespace ERP_FISCAL
{
    partial class ImportarNotaView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportarNotaView));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnListaNotas = new System.Windows.Forms.Button();
            this.btnExportarTotvs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLancadasNoERP = new System.Windows.Forms.CheckBox();
            this.lbDataInicio = new System.Windows.Forms.Label();
            this.lbDtFim = new System.Windows.Forms.Label();
            this.DtPickerInicio = new System.Windows.Forms.DateTimePicker();
            this.DtPickerFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxToFilter = new System.Windows.Forms.TextBox();
            this.txtBoxColigada = new System.Windows.Forms.TextBox();
            this.lbCodColigada = new System.Windows.Forms.Label();
            this.coBoxTipeFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtImportacao = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.btnInserirEmBloco = new System.Windows.Forms.Button();
            this.btnDesmarcarTodos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSelecionarTodas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtImportacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListaNotas
            // 
            this.btnListaNotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListaNotas.Location = new System.Drawing.Point(733, 179);
            this.btnListaNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaNotas.Name = "btnListaNotas";
            this.btnListaNotas.Size = new System.Drawing.Size(143, 40);
            this.btnListaNotas.TabIndex = 6;
            this.btnListaNotas.Text = "Pesquisar";
            this.btnListaNotas.UseVisualStyleBackColor = true;
            this.btnListaNotas.Click += new System.EventHandler(this.btnListaNotas_Click);
            // 
            // btnExportarTotvs
            // 
            this.btnExportarTotvs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarTotvs.Location = new System.Drawing.Point(1273, 961);
            this.btnExportarTotvs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportarTotvs.Name = "btnExportarTotvs";
            this.btnExportarTotvs.Size = new System.Drawing.Size(161, 41);
            this.btnExportarTotvs.TabIndex = 6;
            this.btnExportarTotvs.Text = "Exportar TOTVS";
            this.btnExportarTotvs.UseVisualStyleBackColor = true;
            this.btnExportarTotvs.Click += new System.EventHandler(this.btnExportarTotvs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLancadasNoERP);
            this.groupBox1.Controls.Add(this.lbDataInicio);
            this.groupBox1.Controls.Add(this.lbDtFim);
            this.groupBox1.Controls.Add(this.DtPickerInicio);
            this.groupBox1.Controls.Add(this.DtPickerFim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxToFilter);
            this.groupBox1.Controls.Add(this.txtBoxColigada);
            this.groupBox1.Controls.Add(this.lbCodColigada);
            this.groupBox1.Controls.Add(this.coBoxTipeFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(690, 206);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Prioritário";
            // 
            // cbLancadasNoERP
            // 
            this.cbLancadasNoERP.AutoSize = true;
            this.cbLancadasNoERP.Location = new System.Drawing.Point(485, 130);
            this.cbLancadasNoERP.Name = "cbLancadasNoERP";
            this.cbLancadasNoERP.Size = new System.Drawing.Size(164, 24);
            this.cbLancadasNoERP.TabIndex = 6;
            this.cbLancadasNoERP.Text = "Lançadas no ERP";
            this.cbLancadasNoERP.UseVisualStyleBackColor = true;
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(257, 38);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(49, 20);
            this.lbDataInicio.TabIndex = 2;
            this.lbDataInicio.Text = "Inicial";
            // 
            // lbDtFim
            // 
            this.lbDtFim.AutoSize = true;
            this.lbDtFim.Location = new System.Drawing.Point(257, 129);
            this.lbDtFim.Name = "lbDtFim";
            this.lbDtFim.Size = new System.Drawing.Size(43, 20);
            this.lbDtFim.TabIndex = 3;
            this.lbDtFim.Text = "Final";
            // 
            // DtPickerInicio
            // 
            this.DtPickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerInicio.Location = new System.Drawing.Point(260, 59);
            this.DtPickerInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtPickerInicio.Name = "DtPickerInicio";
            this.DtPickerInicio.Size = new System.Drawing.Size(163, 26);
            this.DtPickerInicio.TabIndex = 0;
            // 
            // DtPickerFim
            // 
            this.DtPickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerFim.Location = new System.Drawing.Point(260, 153);
            this.DtPickerFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtPickerFim.Name = "DtPickerFim";
            this.DtPickerFim.Size = new System.Drawing.Size(163, 26);
            this.DtPickerFim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro";
            // 
            // txtBoxToFilter
            // 
            this.txtBoxToFilter.Location = new System.Drawing.Point(21, 153);
            this.txtBoxToFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxToFilter.Name = "txtBoxToFilter";
            this.txtBoxToFilter.Size = new System.Drawing.Size(170, 26);
            this.txtBoxToFilter.TabIndex = 4;
            // 
            // txtBoxColigada
            // 
            this.txtBoxColigada.Location = new System.Drawing.Point(487, 67);
            this.txtBoxColigada.Name = "txtBoxColigada";
            this.txtBoxColigada.Size = new System.Drawing.Size(146, 26);
            this.txtBoxColigada.TabIndex = 0;
            // 
            // lbCodColigada
            // 
            this.lbCodColigada.AutoSize = true;
            this.lbCodColigada.Location = new System.Drawing.Point(483, 38);
            this.lbCodColigada.Name = "lbCodColigada";
            this.lbCodColigada.Size = new System.Drawing.Size(125, 20);
            this.lbCodColigada.TabIndex = 1;
            this.lbCodColigada.Text = "Código Coligada";
            // 
            // coBoxTipeFilter
            // 
            this.coBoxTipeFilter.FormattingEnabled = true;
            this.coBoxTipeFilter.Location = new System.Drawing.Point(21, 61);
            this.coBoxTipeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coBoxTipeFilter.Name = "coBoxTipeFilter";
            this.coBoxTipeFilter.Size = new System.Drawing.Size(170, 28);
            this.coBoxTipeFilter.TabIndex = 3;
            this.coBoxTipeFilter.SelectedIndexChanged += new System.EventHandler(this.coBoxTipeFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro";
            // 
            // dtImportacao
            // 
            this.dtImportacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtImportacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtImportacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtImportacao.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtImportacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtImportacao.ColumnHeadersHeight = 34;
            this.dtImportacao.Location = new System.Drawing.Point(14, 237);
            this.dtImportacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtImportacao.Name = "dtImportacao";
            this.dtImportacao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtImportacao.RowTemplate.Height = 24;
            this.dtImportacao.Size = new System.Drawing.Size(1420, 697);
            this.dtImportacao.TabIndex = 5;
            this.dtImportacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtImportacao_CellContentClick);
            this.dtImportacao.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtImportacao_EditingControlShowing);
            this.dtImportacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // btnInserirEmBloco
            // 
            this.btnInserirEmBloco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInserirEmBloco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirEmBloco.Enabled = false;
            this.btnInserirEmBloco.Location = new System.Drawing.Point(505, 959);
            this.btnInserirEmBloco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInserirEmBloco.Name = "btnInserirEmBloco";
            this.btnInserirEmBloco.Size = new System.Drawing.Size(170, 40);
            this.btnInserirEmBloco.TabIndex = 7;
            this.btnInserirEmBloco.Text = "Inserir em bloco";
            this.btnInserirEmBloco.UseVisualStyleBackColor = true;
            this.btnInserirEmBloco.Visible = false;
            this.btnInserirEmBloco.Click += new System.EventHandler(this.btnInserirEmBloco_Click);
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(18, 961);
            this.btnDesmarcarTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(153, 41);
            this.btnDesmarcarTodos.TabIndex = 6;
            this.btnDesmarcarTodos.Text = "Desmarcar todos";
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(354, 960);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(126, 41);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btnSelecionarTodas
            // 
            this.btnSelecionarTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelecionarTodas.Location = new System.Drawing.Point(177, 961);
            this.btnSelecionarTodas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelecionarTodas.Name = "btnSelecionarTodas";
            this.btnSelecionarTodas.Size = new System.Drawing.Size(161, 41);
            this.btnSelecionarTodas.TabIndex = 6;
            this.btnSelecionarTodas.Text = "Selecionar todos";
            this.btnSelecionarTodas.UseVisualStyleBackColor = true;
            this.btnSelecionarTodas.Click += new System.EventHandler(this.btnSelecionarTodos_Click);
            // 
            // ImportarNotaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 1030);
            this.Controls.Add(this.btnDesmarcarTodos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelecionarTodas);
            this.Controls.Add(this.btnInserirEmBloco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportarTotvs);
            this.Controls.Add(this.btnListaNotas);
            this.Controls.Add(this.dtImportacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImportarNotaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importação NFS-E";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtImportacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        //private System.Windows.Forms.DataGridView dtImportacao;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dtImportacao;        
        private System.Windows.Forms.Button btnListaNotas;
        private System.Windows.Forms.Button btnExportarTotvs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxToFilter;
        private System.Windows.Forms.ComboBox coBoxTipeFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCodColigada;
        private System.Windows.Forms.TextBox txtBoxColigada;
        private System.Windows.Forms.Label lbDataInicio;
        private System.Windows.Forms.Label lbDtFim;
        private System.Windows.Forms.DateTimePicker DtPickerInicio;
        private System.Windows.Forms.DateTimePicker DtPickerFim;
        private System.Windows.Forms.CheckBox cbLancadasNoERP;
        private System.Windows.Forms.Button btnInserirEmBloco;
        private System.Windows.Forms.Button btnDesmarcarTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSelecionarTodas;
    }
}

