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
            this.DtPickerInicio = new System.Windows.Forms.DateTimePicker();
            this.lbApresentacao = new System.Windows.Forms.Label();
            this.lbDataInicio = new System.Windows.Forms.Label();
            this.lbDtFim = new System.Windows.Forms.Label();
            this.DtPickerFim = new System.Windows.Forms.DateTimePicker();
            this.GbDTNotas = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtImportacao = new System.Windows.Forms.DataGridView();
            this.btnListaNotas = new System.Windows.Forms.Button();
            this.GBListar = new System.Windows.Forms.GroupBox();
            this.btnInserirEmBloco = new System.Windows.Forms.Button();
            this.btnDesmarcarTodos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSelecionarTodas = new System.Windows.Forms.Button();
            this.btnExportarTotvs = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gbNotas = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxToFilter = new System.Windows.Forms.TextBox();
            this.coBoxTipeFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupLoading = new System.Windows.Forms.GroupBox();
            this.GbDTNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtImportacao)).BeginInit();
            this.GBListar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtPickerInicio
            // 
            this.DtPickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerInicio.Location = new System.Drawing.Point(11, 59);
            this.DtPickerInicio.Name = "DtPickerInicio";
            this.DtPickerInicio.Size = new System.Drawing.Size(145, 22);
            this.DtPickerInicio.TabIndex = 0;
            // 
            // lbApresentacao
            // 
            this.lbApresentacao.AutoSize = true;
            this.lbApresentacao.Location = new System.Drawing.Point(12, 22);
            this.lbApresentacao.Name = "lbApresentacao";
            this.lbApresentacao.Size = new System.Drawing.Size(200, 16);
            this.lbApresentacao.TabIndex = 1;
            this.lbApresentacao.Text = "Selecione o filtro para pesquisar";
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(8, 29);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(41, 16);
            this.lbDataInicio.TabIndex = 2;
            this.lbDataInicio.Text = "Inicial";
            // 
            // lbDtFim
            // 
            this.lbDtFim.AutoSize = true;
            this.lbDtFim.Location = new System.Drawing.Point(8, 96);
            this.lbDtFim.Name = "lbDtFim";
            this.lbDtFim.Size = new System.Drawing.Size(36, 16);
            this.lbDtFim.TabIndex = 3;
            this.lbDtFim.Text = "Final";
            // 
            // DtPickerFim
            // 
            this.DtPickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerFim.Location = new System.Drawing.Point(11, 119);
            this.DtPickerFim.Name = "DtPickerFim";
            this.DtPickerFim.Size = new System.Drawing.Size(145, 22);
            this.DtPickerFim.TabIndex = 0;
            // 
            // GbDTNotas
            // 
            this.GbDTNotas.Controls.Add(this.lbDataInicio);
            this.GbDTNotas.Controls.Add(this.lbDtFim);
            this.GbDTNotas.Controls.Add(this.DtPickerInicio);
            this.GbDTNotas.Controls.Add(this.DtPickerFim);
            this.GbDTNotas.Location = new System.Drawing.Point(288, 14);
            this.GbDTNotas.Name = "GbDTNotas";
            this.GbDTNotas.Size = new System.Drawing.Size(168, 158);
            this.GbDTNotas.TabIndex = 4;
            this.GbDTNotas.TabStop = false;
            this.GbDTNotas.Text = "Datas Notas";
            // 
            // dtImportacao
            // 
            this.dtImportacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtImportacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtImportacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtImportacao.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtImportacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtImportacao.ColumnHeadersHeight = 34;
            this.dtImportacao.Location = new System.Drawing.Point(12, 243);
            this.dtImportacao.Name = "dtImportacao";
            this.dtImportacao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtImportacao.RowTemplate.Height = 24;
            this.dtImportacao.Size = new System.Drawing.Size(1151, 454);
            this.dtImportacao.TabIndex = 5;
            this.dtImportacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtImportacao_CellContentClick_1);
            this.dtImportacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtImportacao_CellContentClick);
            // 
            // btnListaNotas
            // 
            this.btnListaNotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListaNotas.Location = new System.Drawing.Point(16, 205);
            this.btnListaNotas.Name = "btnListaNotas";
            this.btnListaNotas.Size = new System.Drawing.Size(127, 32);
            this.btnListaNotas.TabIndex = 6;
            this.btnListaNotas.Text = "Pesquisar";
            this.btnListaNotas.UseVisualStyleBackColor = true;
            this.btnListaNotas.Click += new System.EventHandler(this.btnListaNotas_Click);
            // 
            // GBListar
            // 
            this.GBListar.Controls.Add(this.btnInserirEmBloco);
            this.GBListar.Controls.Add(this.btnDesmarcarTodos);
            this.GBListar.Controls.Add(this.btnLimpar);
            this.GBListar.Controls.Add(this.btnSelecionarTodas);
            this.GBListar.Location = new System.Drawing.Point(761, 103);
            this.GBListar.Name = "GBListar";
            this.GBListar.Size = new System.Drawing.Size(402, 130);
            this.GBListar.TabIndex = 7;
            this.GBListar.TabStop = false;
            this.GBListar.Text = "Ações no Data Grid";
            // 
            // btnInserirEmBloco
            // 
            this.btnInserirEmBloco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirEmBloco.Location = new System.Drawing.Point(199, 23);
            this.btnInserirEmBloco.Name = "btnInserirEmBloco";
            this.btnInserirEmBloco.Size = new System.Drawing.Size(131, 28);
            this.btnInserirEmBloco.TabIndex = 7;
            this.btnInserirEmBloco.Text = "Inserir em bloco";
            this.btnInserirEmBloco.UseVisualStyleBackColor = true;
            this.btnInserirEmBloco.Click += new System.EventHandler(this.btnInserirEmBloco_Click);
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(29, 58);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(130, 29);
            this.btnDesmarcarTodos.TabIndex = 6;
            this.btnDesmarcarTodos.Text = "Desmarcar todos";
            this.btnDesmarcarTodos.UseVisualStyleBackColor = true;
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(29, 98);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 26);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btnSelecionarTodas
            // 
            this.btnSelecionarTodas.Location = new System.Drawing.Point(28, 24);
            this.btnSelecionarTodas.Name = "btnSelecionarTodas";
            this.btnSelecionarTodas.Size = new System.Drawing.Size(131, 28);
            this.btnSelecionarTodas.TabIndex = 6;
            this.btnSelecionarTodas.Text = "Selecionar todos";
            this.btnSelecionarTodas.UseVisualStyleBackColor = true;
            this.btnSelecionarTodas.Click += new System.EventHandler(this.btnSelecionarTodos_Click);
            // 
            // btnExportarTotvs
            // 
            this.btnExportarTotvs.Location = new System.Drawing.Point(288, 178);
            this.btnExportarTotvs.Name = "btnExportarTotvs";
            this.btnExportarTotvs.Size = new System.Drawing.Size(130, 28);
            this.btnExportarTotvs.TabIndex = 6;
            this.btnExportarTotvs.Text = "Exportar TOTVS";
            this.btnExportarTotvs.UseVisualStyleBackColor = true;
            this.btnExportarTotvs.Click += new System.EventHandler(this.btnExportarTotvs_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // gbNotas
            // 
            this.gbNotas.Location = new System.Drawing.Point(547, 22);
            this.gbNotas.Name = "gbNotas";
            this.gbNotas.Size = new System.Drawing.Size(251, 48);
            this.gbNotas.TabIndex = 10;
            this.gbNotas.TabStop = false;
            this.gbNotas.Text = "Notas";
            this.gbNotas.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxToFilter);
            this.groupBox1.Controls.Add(this.coBoxTipeFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Prioritário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro";
            // 
            // txtBoxToFilter
            // 
            this.txtBoxToFilter.Location = new System.Drawing.Point(19, 97);
            this.txtBoxToFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxToFilter.Name = "txtBoxToFilter";
            this.txtBoxToFilter.Size = new System.Drawing.Size(152, 22);
            this.txtBoxToFilter.TabIndex = 4;
            // 
            // coBoxTipeFilter
            // 
            this.coBoxTipeFilter.FormattingEnabled = true;
            this.coBoxTipeFilter.Location = new System.Drawing.Point(19, 49);
            this.coBoxTipeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coBoxTipeFilter.Name = "coBoxTipeFilter";
            this.coBoxTipeFilter.Size = new System.Drawing.Size(152, 24);
            this.coBoxTipeFilter.TabIndex = 3;
            this.coBoxTipeFilter.SelectedIndexChanged += new System.EventHandler(this.coBoxTipeFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro";
            // 
            // groupLoading
            // 
            this.groupLoading.Controls.Add(this.progressBar1);
            this.groupLoading.Location = new System.Drawing.Point(6, 706);
            this.groupLoading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupLoading.Name = "groupLoading";
            this.groupLoading.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupLoading.Size = new System.Drawing.Size(333, 49);
            this.groupLoading.TabIndex = 7;
            this.groupLoading.TabStop = false;
            this.groupLoading.Text = "Pronto";
            this.groupLoading.Visible = false;
            // 
            // ImportarNotaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 764);
            this.Controls.Add(this.groupLoading);
            this.Controls.Add(this.btnExportarTotvs);
            this.Controls.Add(this.btnListaNotas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbNotas);
            this.Controls.Add(this.GBListar);
            this.Controls.Add(this.dtImportacao);
            this.Controls.Add(this.GbDTNotas);
            this.Controls.Add(this.lbApresentacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportarNotaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importação NFS-E";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbDTNotas.ResumeLayout(false);
            this.GbDTNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtImportacao)).EndInit();
            this.GBListar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupLoading.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtPickerInicio;
        private System.Windows.Forms.Label lbApresentacao;
        private System.Windows.Forms.Label lbDataInicio;
        private System.Windows.Forms.Label lbDtFim;
        private System.Windows.Forms.DateTimePicker DtPickerFim;
        private System.Windows.Forms.GroupBox GbDTNotas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dtImportacao;
        private System.Windows.Forms.Button btnListaNotas;
        private System.Windows.Forms.GroupBox GBListar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSelecionarTodas;
        private System.Windows.Forms.Button btnDesmarcarTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExportarTotvs;
        private System.Windows.Forms.GroupBox gbNotas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxToFilter;
        private System.Windows.Forms.ComboBox coBoxTipeFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupLoading;
        private System.Windows.Forms.Button btnInserirEmBloco;
    }
}

