namespace ERP_FISCAL
{
    partial class ERPFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ERPFiscal));
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
            this.btnSelecionarTodas = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExportarTotvs = new System.Windows.Forms.Button();
            this.gbNotas = new System.Windows.Forms.GroupBox();
            this.GbDTNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtImportacao)).BeginInit();
            this.GBListar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtPickerInicio
            // 
            this.DtPickerInicio.Location = new System.Drawing.Point(11, 59);
            this.DtPickerInicio.Name = "DtPickerInicio";
            this.DtPickerInicio.Size = new System.Drawing.Size(131, 22);
            this.DtPickerInicio.TabIndex = 0;
            // 
            // lbApresentacao
            // 
            this.lbApresentacao.AutoSize = true;
            this.lbApresentacao.Location = new System.Drawing.Point(12, 22);
            this.lbApresentacao.Name = "lbApresentacao";
            this.lbApresentacao.Size = new System.Drawing.Size(211, 16);
            this.lbApresentacao.TabIndex = 1;
            this.lbApresentacao.Text = "Selecione a data para importação";
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
            this.DtPickerFim.Location = new System.Drawing.Point(11, 119);
            this.DtPickerFim.Name = "DtPickerFim";
            this.DtPickerFim.Size = new System.Drawing.Size(131, 22);
            this.DtPickerFim.TabIndex = 0;
            // 
            // GbDTNotas
            // 
            this.GbDTNotas.Controls.Add(this.lbDataInicio);
            this.GbDTNotas.Controls.Add(this.lbDtFim);
            this.GbDTNotas.Controls.Add(this.DtPickerInicio);
            this.GbDTNotas.Controls.Add(this.DtPickerFim);
            this.GbDTNotas.Location = new System.Drawing.Point(15, 52);
            this.GbDTNotas.Name = "GbDTNotas";
            this.GbDTNotas.Size = new System.Drawing.Size(177, 166);
            this.GbDTNotas.TabIndex = 4;
            this.GbDTNotas.TabStop = false;
            this.GbDTNotas.Text = "Datas Notas";
            // 
            // dtImportacao
            // 
            this.dtImportacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtImportacao.Location = new System.Drawing.Point(15, 240);
            this.dtImportacao.Name = "dtImportacao";
            this.dtImportacao.RowHeadersWidth = 51;
            this.dtImportacao.RowTemplate.Height = 24;
            this.dtImportacao.Size = new System.Drawing.Size(1147, 510);
            this.dtImportacao.TabIndex = 5;
            // 
            // btnListaNotas
            // 
            this.btnListaNotas.Location = new System.Drawing.Point(18, 72);
            this.btnListaNotas.Name = "btnListaNotas";
            this.btnListaNotas.Size = new System.Drawing.Size(104, 40);
            this.btnListaNotas.TabIndex = 6;
            this.btnListaNotas.Text = "Listar Notas";
            this.btnListaNotas.UseVisualStyleBackColor = true;
            this.btnListaNotas.Click += new System.EventHandler(this.btnListaNotas_Click);
            // 
            // GBListar
            // 
            this.GBListar.Controls.Add(this.btnListaNotas);
            this.GBListar.Controls.Add(this.btnSelecionarTodas);
            this.GBListar.Controls.Add(this.btnExportarTotvs);
            this.GBListar.Controls.Add(this.btnLimpar);
            this.GBListar.Controls.Add(this.btnDesmarcarTodos);
            this.GBListar.Location = new System.Drawing.Point(492, 52);
            this.GBListar.Name = "GBListar";
            this.GBListar.Size = new System.Drawing.Size(670, 166);
            this.GBListar.TabIndex = 7;
            this.GBListar.TabStop = false;
            this.GBListar.Text = "Ações";
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(281, 72);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(119, 40);
            this.btnDesmarcarTodos.TabIndex = 6;
            this.btnDesmarcarTodos.Text = "Desmarcar todos";
            this.btnDesmarcarTodos.UseVisualStyleBackColor = true;
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // btnSelecionarTodas
            // 
            this.btnSelecionarTodas.Location = new System.Drawing.Point(137, 72);
            this.btnSelecionarTodas.Name = "btnSelecionarTodas";
            this.btnSelecionarTodas.Size = new System.Drawing.Size(118, 40);
            this.btnSelecionarTodas.TabIndex = 6;
            this.btnSelecionarTodas.Text = "Selecionar todos";
            this.btnSelecionarTodas.UseVisualStyleBackColor = true;
            this.btnSelecionarTodas.Click += new System.EventHandler(this.btnSelecionarTodos_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1022, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 16);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Pronto";
            this.lblStatus.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(971, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(158, 33);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(423, 72);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 40);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btnExportarTotvs
            // 
            this.btnExportarTotvs.Location = new System.Drawing.Point(520, 72);
            this.btnExportarTotvs.Name = "btnExportarTotvs";
            this.btnExportarTotvs.Size = new System.Drawing.Size(117, 40);
            this.btnExportarTotvs.TabIndex = 6;
            this.btnExportarTotvs.Text = "Exportar TOTVS";
            this.btnExportarTotvs.UseVisualStyleBackColor = true;
            this.btnExportarTotvs.Click += new System.EventHandler(this.btnExportarTotvs_Click);
            // 
            // gbNotas
            // 
            this.gbNotas.Location = new System.Drawing.Point(216, 52);
            this.gbNotas.Name = "gbNotas";
            this.gbNotas.Size = new System.Drawing.Size(251, 166);
            this.gbNotas.TabIndex = 10;
            this.gbNotas.TabStop = false;
            this.gbNotas.Text = "Notas";
            // 
            // ERPFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 764);
            this.Controls.Add(this.gbNotas);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.GBListar);
            this.Controls.Add(this.dtImportacao);
            this.Controls.Add(this.GbDTNotas);
            this.Controls.Add(this.lbApresentacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ERPFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importação NFS-E";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbDTNotas.ResumeLayout(false);
            this.GbDTNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtImportacao)).EndInit();
            this.GBListar.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSelecionarTodas;
        private System.Windows.Forms.Button btnDesmarcarTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExportarTotvs;
        private System.Windows.Forms.GroupBox gbNotas;
    }
}

