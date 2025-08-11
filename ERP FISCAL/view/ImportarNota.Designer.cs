namespace ERP_FISCAL
{
    partial class ImportarNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportarNota));
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
            this.DtPickerInicio.Location = new System.Drawing.Point(12, 74);
            this.DtPickerInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtPickerInicio.Name = "DtPickerInicio";
            this.DtPickerInicio.Size = new System.Drawing.Size(163, 26);
            this.DtPickerInicio.TabIndex = 0;
            // 
            // lbApresentacao
            // 
            this.lbApresentacao.AutoSize = true;
            this.lbApresentacao.Location = new System.Drawing.Point(14, 28);
            this.lbApresentacao.Name = "lbApresentacao";
            this.lbApresentacao.Size = new System.Drawing.Size(235, 20);
            this.lbApresentacao.TabIndex = 1;
            this.lbApresentacao.Text = "Selecione o filtro para pesquisar";
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(9, 36);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(49, 20);
            this.lbDataInicio.TabIndex = 2;
            this.lbDataInicio.Text = "Inicial";
            // 
            // lbDtFim
            // 
            this.lbDtFim.AutoSize = true;
            this.lbDtFim.Location = new System.Drawing.Point(9, 120);
            this.lbDtFim.Name = "lbDtFim";
            this.lbDtFim.Size = new System.Drawing.Size(43, 20);
            this.lbDtFim.TabIndex = 3;
            this.lbDtFim.Text = "Final";
            // 
            // DtPickerFim
            // 
            this.DtPickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerFim.Location = new System.Drawing.Point(12, 149);
            this.DtPickerFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtPickerFim.Name = "DtPickerFim";
            this.DtPickerFim.Size = new System.Drawing.Size(163, 26);
            this.DtPickerFim.TabIndex = 0;
            // 
            // GbDTNotas
            // 
            this.GbDTNotas.Controls.Add(this.lbDataInicio);
            this.GbDTNotas.Controls.Add(this.lbDtFim);
            this.GbDTNotas.Controls.Add(this.DtPickerInicio);
            this.GbDTNotas.Controls.Add(this.DtPickerFim);
            this.GbDTNotas.Location = new System.Drawing.Point(324, 17);
            this.GbDTNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbDTNotas.Name = "GbDTNotas";
            this.GbDTNotas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbDTNotas.Size = new System.Drawing.Size(189, 198);
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
            this.dtImportacao.Location = new System.Drawing.Point(13, 304);
            this.dtImportacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtImportacao.Name = "dtImportacao";
            this.dtImportacao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtImportacao.RowTemplate.Height = 24;
            this.dtImportacao.Size = new System.Drawing.Size(1295, 568);
            this.dtImportacao.TabIndex = 5;
            // 
            // btnListaNotas
            // 
            this.btnListaNotas.Location = new System.Drawing.Point(18, 256);
            this.btnListaNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaNotas.Name = "btnListaNotas";
            this.btnListaNotas.Size = new System.Drawing.Size(143, 40);
            this.btnListaNotas.TabIndex = 6;
            this.btnListaNotas.Text = "Pesquisar";
            this.btnListaNotas.UseVisualStyleBackColor = true;
            this.btnListaNotas.Click += new System.EventHandler(this.btnListaNotas_Click);
            // 
            // GBListar
            // 
            this.GBListar.Controls.Add(this.btnDesmarcarTodos);
            this.GBListar.Controls.Add(this.btnLimpar);
            this.GBListar.Controls.Add(this.btnSelecionarTodas);
            this.GBListar.Location = new System.Drawing.Point(799, 212);
            this.GBListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBListar.Name = "GBListar";
            this.GBListar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBListar.Size = new System.Drawing.Size(509, 80);
            this.GBListar.TabIndex = 7;
            this.GBListar.TabStop = false;
            this.GBListar.Text = "Ações no Data Grid";
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(185, 28);
            this.btnDesmarcarTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(146, 38);
            this.btnDesmarcarTodos.TabIndex = 6;
            this.btnDesmarcarTodos.Text = "Desmarcar todos";
            this.btnDesmarcarTodos.UseVisualStyleBackColor = true;
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(337, 30);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(146, 32);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btnSelecionarTodas
            // 
            this.btnSelecionarTodas.Location = new System.Drawing.Point(32, 27);
            this.btnSelecionarTodas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelecionarTodas.Name = "btnSelecionarTodas";
            this.btnSelecionarTodas.Size = new System.Drawing.Size(143, 38);
            this.btnSelecionarTodas.TabIndex = 6;
            this.btnSelecionarTodas.Text = "Selecionar todos";
            this.btnSelecionarTodas.UseVisualStyleBackColor = true;
            this.btnSelecionarTodas.Click += new System.EventHandler(this.btnSelecionarTodos_Click);
            // 
            // btnExportarTotvs
            // 
            this.btnExportarTotvs.Location = new System.Drawing.Point(324, 223);
            this.btnExportarTotvs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportarTotvs.Name = "btnExportarTotvs";
            this.btnExportarTotvs.Size = new System.Drawing.Size(146, 35);
            this.btnExportarTotvs.TabIndex = 6;
            this.btnExportarTotvs.Text = "Exportar TOTVS";
            this.btnExportarTotvs.UseVisualStyleBackColor = true;
            this.btnExportarTotvs.Click += new System.EventHandler(this.btnExportarTotvs_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 29);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(334, 15);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // gbNotas
            // 
            this.gbNotas.Location = new System.Drawing.Point(615, 28);
            this.gbNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNotas.Name = "gbNotas";
            this.gbNotas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNotas.Size = new System.Drawing.Size(282, 60);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(213, 172);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Prioritário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro";
            // 
            // txtBoxToFilter
            // 
            this.txtBoxToFilter.Location = new System.Drawing.Point(21, 121);
            this.txtBoxToFilter.Name = "txtBoxToFilter";
            this.txtBoxToFilter.Size = new System.Drawing.Size(170, 26);
            this.txtBoxToFilter.TabIndex = 4;
            // 
            // coBoxTipeFilter
            // 
            this.coBoxTipeFilter.FormattingEnabled = true;
            this.coBoxTipeFilter.Location = new System.Drawing.Point(21, 61);
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
            // groupLoading
            // 
            this.groupLoading.Controls.Add(this.progressBar1);
            this.groupLoading.Location = new System.Drawing.Point(7, 882);
            this.groupLoading.Name = "groupLoading";
            this.groupLoading.Size = new System.Drawing.Size(375, 61);
            this.groupLoading.TabIndex = 7;
            this.groupLoading.TabStop = false;
            this.groupLoading.Text = "Pronto";
            this.groupLoading.Visible = false;
            // 
            // ImportarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 955);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImportarNota";
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
    }
}

