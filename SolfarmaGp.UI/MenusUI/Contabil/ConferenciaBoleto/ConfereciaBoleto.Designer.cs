namespace SolfarmaGp.UI.MenusUI.Contabil.ConferenciaBoleto
{
    partial class ConfereciaBoleto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImportarArquivo = new Button();
            gpHeader = new GroupBox();
            lbCodPessoa = new Label();
            tbCodPessoa = new TextBox();
            lbFilial = new Label();
            tbFilial = new TextBox();
            lbBanco = new Label();
            btnConferencia = new Button();
            cbColigada = new ComboBox();
            groupBox1 = new GroupBox();
            btnFiltrar = new Button();
            tbValorPesquisa = new TextBox();
            label1 = new Label();
            cbFiltro = new ComboBox();
            txtFiltroTipo = new Label();
            lbNomaArquivo = new Label();
            txtFileName = new TextBox();
            dvgRelacaoBoletos = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            tbControlBase = new TabControl();
            tbBaseImportada = new TabPage();
            tbBaseConferencia = new TabPage();
            dvgConferencia = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            btnGeraLote = new Button();
            btnVisualiza = new Button();
            cbBanco = new ComboBox();
            laBanco = new Label();
            gpHeader.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRelacaoBoletos).BeginInit();
            tbControlBase.SuspendLayout();
            tbBaseImportada.SuspendLayout();
            tbBaseConferencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgConferencia).BeginInit();
            SuspendLayout();
            // 
            // btnImportarArquivo
            // 
            btnImportarArquivo.Location = new Point(17, 84);
            btnImportarArquivo.Name = "btnImportarArquivo";
            btnImportarArquivo.Size = new Size(189, 29);
            btnImportarArquivo.TabIndex = 0;
            btnImportarArquivo.Text = "Importar Arquivo Excel";
            btnImportarArquivo.UseVisualStyleBackColor = true;
            btnImportarArquivo.Click += btnImportarArquivo_Click;
            // 
            // gpHeader
            // 
            gpHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpHeader.Controls.Add(laBanco);
            gpHeader.Controls.Add(cbBanco);
            gpHeader.Controls.Add(lbCodPessoa);
            gpHeader.Controls.Add(tbCodPessoa);
            gpHeader.Controls.Add(lbFilial);
            gpHeader.Controls.Add(tbFilial);
            gpHeader.Controls.Add(lbBanco);
            gpHeader.Controls.Add(btnConferencia);
            gpHeader.Controls.Add(cbColigada);
            gpHeader.Controls.Add(groupBox1);
            gpHeader.Controls.Add(lbNomaArquivo);
            gpHeader.Controls.Add(txtFileName);
            gpHeader.Controls.Add(btnImportarArquivo);
            gpHeader.Location = new Point(12, 5);
            gpHeader.Name = "gpHeader";
            gpHeader.Size = new Size(1323, 200);
            gpHeader.TabIndex = 1;
            gpHeader.TabStop = false;
            gpHeader.Text = "Geral";
            // 
            // lbCodPessoa
            // 
            lbCodPessoa.AutoSize = true;
            lbCodPessoa.Location = new Point(457, 27);
            lbCodPessoa.Name = "lbCodPessoa";
            lbCodPessoa.Size = new Size(87, 20);
            lbCodPessoa.TabIndex = 14;
            lbCodPessoa.Text = "Cod. Pessoa";
            // 
            // tbCodPessoa
            // 
            tbCodPessoa.Location = new Point(457, 51);
            tbCodPessoa.Name = "tbCodPessoa";
            tbCodPessoa.Size = new Size(111, 27);
            tbCodPessoa.TabIndex = 13;
            // 
            // lbFilial
            // 
            lbFilial.AutoSize = true;
            lbFilial.Location = new Point(457, 129);
            lbFilial.Name = "lbFilial";
            lbFilial.Size = new Size(43, 20);
            lbFilial.TabIndex = 12;
            lbFilial.Text = "Filial:";
            // 
            // tbFilial
            // 
            tbFilial.Location = new Point(457, 152);
            tbFilial.Name = "tbFilial";
            tbFilial.Size = new Size(111, 27);
            tbFilial.TabIndex = 11;
            // 
            // lbBanco
            // 
            lbBanco.AutoSize = true;
            lbBanco.Location = new Point(22, 133);
            lbBanco.Name = "lbBanco";
            lbBanco.Size = new Size(152, 20);
            lbBanco.TabIndex = 10;
            lbBanco.Text = "Selecione a Coligada:";
            // 
            // btnConferencia
            // 
            btnConferencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConferencia.Location = new Point(1179, 156);
            btnConferencia.Name = "btnConferencia";
            btnConferencia.Size = new Size(138, 29);
            btnConferencia.TabIndex = 9;
            btnConferencia.Text = "Conferir";
            btnConferencia.UseVisualStyleBackColor = true;
            btnConferencia.Click += btnConferencia_Click;
            // 
            // cbColigada
            // 
            cbColigada.FormattingEnabled = true;
            cbColigada.Location = new Point(22, 156);
            cbColigada.Name = "cbColigada";
            cbColigada.Size = new Size(174, 28);
            cbColigada.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(tbValorPesquisa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbFiltro);
            groupBox1.Controls.Add(txtFiltroTipo);
            groupBox1.Location = new Point(647, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 171);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(245, 129);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(100, 29);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // tbValorPesquisa
            // 
            tbValorPesquisa.Location = new Point(28, 129);
            tbValorPesquisa.Name = "tbValorPesquisa";
            tbValorPesquisa.Size = new Size(189, 27);
            tbValorPesquisa.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 101);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 6;
            label1.Text = "Valor Pesquisa:";
            // 
            // cbFiltro
            // 
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Location = new Point(28, 60);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(163, 28);
            cbFiltro.TabIndex = 2;
            // 
            // txtFiltroTipo
            // 
            txtFiltroTipo.AutoSize = true;
            txtFiltroTipo.Location = new Point(28, 31);
            txtFiltroTipo.Name = "txtFiltroTipo";
            txtFiltroTipo.Size = new Size(141, 20);
            txtFiltroTipo.TabIndex = 3;
            txtFiltroTipo.Text = "Selecione o Campo:";
            // 
            // lbNomaArquivo
            // 
            lbNomaArquivo.AutoSize = true;
            lbNomaArquivo.Location = new Point(17, 23);
            lbNomaArquivo.Name = "lbNomaArquivo";
            lbNomaArquivo.Size = new Size(109, 20);
            lbNomaArquivo.TabIndex = 4;
            lbNomaArquivo.Text = "Nome Arquivo:";
            // 
            // txtFileName
            // 
            txtFileName.Enabled = false;
            txtFileName.Location = new Point(17, 51);
            txtFileName.Name = "txtFileName";
            txtFileName.PlaceholderText = "Nome do arquivo...";
            txtFileName.Size = new Size(269, 27);
            txtFileName.TabIndex = 1;
            // 
            // dvgRelacaoBoletos
            // 
            dvgRelacaoBoletos.AllowUserToAddRows = false;
            dvgRelacaoBoletos.AllowUserToDeleteRows = false;
            dvgRelacaoBoletos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgRelacaoBoletos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgRelacaoBoletos.ColumnHeadersHeight = 29;
            dvgRelacaoBoletos.Location = new Point(13, 8);
            dvgRelacaoBoletos.Name = "dvgRelacaoBoletos";
            dvgRelacaoBoletos.RowHeadersWidth = 51;
            dvgRelacaoBoletos.Size = new Size(1289, 512);
            dvgRelacaoBoletos.TabIndex = 2;
            // 
            // tbControlBase
            // 
            tbControlBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbControlBase.Controls.Add(tbBaseImportada);
            tbControlBase.Controls.Add(tbBaseConferencia);
            tbControlBase.Location = new Point(12, 211);
            tbControlBase.Name = "tbControlBase";
            tbControlBase.SelectedIndex = 0;
            tbControlBase.Size = new Size(1323, 559);
            tbControlBase.TabIndex = 3;
            // 
            // tbBaseImportada
            // 
            tbBaseImportada.Controls.Add(dvgRelacaoBoletos);
            tbBaseImportada.Location = new Point(4, 29);
            tbBaseImportada.Name = "tbBaseImportada";
            tbBaseImportada.Padding = new Padding(3);
            tbBaseImportada.Size = new Size(1315, 526);
            tbBaseImportada.TabIndex = 0;
            tbBaseImportada.Text = "Base Importada";
            tbBaseImportada.UseVisualStyleBackColor = true;
            // 
            // tbBaseConferencia
            // 
            tbBaseConferencia.Controls.Add(dvgConferencia);
            tbBaseConferencia.Location = new Point(4, 29);
            tbBaseConferencia.Name = "tbBaseConferencia";
            tbBaseConferencia.Padding = new Padding(3);
            tbBaseConferencia.Size = new Size(1315, 526);
            tbBaseConferencia.TabIndex = 1;
            tbBaseConferencia.Text = "Base Conferencia";
            tbBaseConferencia.UseVisualStyleBackColor = true;
            // 
            // dvgConferencia
            // 
            dvgConferencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgConferencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConferencia.ColumnHeadersHeight = 29;
            dvgConferencia.Location = new Point(3, 6);
            dvgConferencia.Name = "dvgConferencia";
            dvgConferencia.RowHeadersWidth = 51;
            dvgConferencia.Size = new Size(1306, 517);
            dvgConferencia.TabIndex = 0;
            // 
            // btnGeraLote
            // 
            btnGeraLote.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGeraLote.Location = new Point(1165, 788);
            btnGeraLote.Name = "btnGeraLote";
            btnGeraLote.Size = new Size(153, 38);
            btnGeraLote.TabIndex = 10;
            btnGeraLote.Text = "Gerar lotes";
            btnGeraLote.UseVisualStyleBackColor = true;
            btnGeraLote.Click += btnGeraLote_Click;
            // 
            // btnVisualiza
            // 
            btnVisualiza.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualiza.Location = new Point(988, 788);
            btnVisualiza.Name = "btnVisualiza";
            btnVisualiza.Size = new Size(153, 38);
            btnVisualiza.TabIndex = 11;
            btnVisualiza.Text = "Visualizar";
            btnVisualiza.UseVisualStyleBackColor = true;
            btnVisualiza.Click += btnVisualiza_Click;
            // 
            // cbBanco
            // 
            cbBanco.FormattingEnabled = true;
            cbBanco.Location = new Point(223, 156);
            cbBanco.Name = "cbBanco";
            cbBanco.Size = new Size(174, 28);
            cbBanco.TabIndex = 15;
            // 
            // laBanco
            // 
            laBanco.AutoSize = true;
            laBanco.Location = new Point(223, 129);
            laBanco.Name = "laBanco";
            laBanco.Size = new Size(134, 20);
            laBanco.TabIndex = 16;
            laBanco.Text = "Selecione o Banco:";
            // 
            // ConfereciaBoleto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 838);
            Controls.Add(btnVisualiza);
            Controls.Add(btnGeraLote);
            Controls.Add(tbControlBase);
            Controls.Add(gpHeader);
            Name = "ConfereciaBoleto";
            Text = "ConfereciaBoleto";
            Load += ConfereciaBoleto_Load;
            gpHeader.ResumeLayout(false);
            gpHeader.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRelacaoBoletos).EndInit();
            tbControlBase.ResumeLayout(false);
            tbBaseImportada.ResumeLayout(false);
            tbBaseConferencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgConferencia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImportarArquivo;
        private GroupBox gpHeader;
        private ComponentesTelaUI.DataGridView.MyDataGridView dvgRelacaoBoletos;
        private TextBox txtFileName;
        private Label txtFiltroTipo;
        private ComboBox cbFiltro;
        private TabControl tbControlBase;
        private TabPage tbBaseImportada;
        private TabPage tbBaseConferencia;
        private Label lbNomaArquivo;
        private Label label1;
        private TextBox tbValorPesquisa;
        private Button btnConferencia;
        private ComboBox cbColigada;
        private GroupBox groupBox1;
        private Label lbBanco;
        private ComponentesTelaUI.DataGridView.MyDataGridView dvgConferencia;
        private Label lbFilial;
        private TextBox tbFilial;
        private Button btnFiltrar;
        private Label lbCodPessoa;
        private TextBox tbCodPessoa;
        private Button btnGeraLote;
        private Button btnVisualiza;
        private Label laBanco;
        private ComboBox cbBanco;
    }
}