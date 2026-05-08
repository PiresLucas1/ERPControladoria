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
            laBanco = new Label();
            cbBanco = new ComboBox();
            lbCodPessoa = new Label();
            tbCodPessoa = new TextBox();
            lbFilial = new Label();
            tbFilial = new TextBox();
            lbBanco = new Label();
            cbColigada = new ComboBox();
            gbFiltros = new GroupBox();
            checkDataFiltro = new CheckBox();
            label6 = new Label();
            dtpDocumento = new DateTimePicker();
            tbValorDocumento = new TextBox();
            label5 = new Label();
            tbHistorico = new TextBox();
            label4 = new Label();
            label1 = new Label();
            tbComplemento = new TextBox();
            tbContaCredito = new TextBox();
            lbCredito = new Label();
            btnFiltrar = new Button();
            tbContaDebito = new TextBox();
            lbContaDebito = new Label();
            lbNomaArquivo = new Label();
            txtFileName = new TextBox();
            btnConferencia = new Button();
            dvgRelacaoBoletos = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            tbControlBase = new TabControl();
            tbBaseImportada = new TabPage();
            tbBaseConferencia = new TabPage();
            dvgConferencia = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            btnGeraLote = new Button();
            btnVisualiza = new Button();
            tbValor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbValorReferente = new TextBox();
            groupBox1 = new GroupBox();
            btnExcluir = new Button();
            button1 = new Button();
            gpHeader.SuspendLayout();
            gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRelacaoBoletos).BeginInit();
            tbControlBase.SuspendLayout();
            tbBaseImportada.SuspendLayout();
            tbBaseConferencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgConferencia).BeginInit();
            groupBox1.SuspendLayout();
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
            gpHeader.Controls.Add(cbColigada);
            gpHeader.Controls.Add(gbFiltros);
            gpHeader.Controls.Add(lbNomaArquivo);
            gpHeader.Controls.Add(txtFileName);
            gpHeader.Controls.Add(btnImportarArquivo);
            gpHeader.Location = new Point(12, 5);
            gpHeader.Name = "gpHeader";
            gpHeader.Size = new Size(1409, 200);
            gpHeader.TabIndex = 1;
            gpHeader.TabStop = false;
            gpHeader.Text = "Geral";
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
            // cbBanco
            // 
            cbBanco.FormattingEnabled = true;
            cbBanco.Location = new Point(223, 156);
            cbBanco.Name = "cbBanco";
            cbBanco.Size = new Size(174, 28);
            cbBanco.TabIndex = 15;
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
            // cbColigada
            // 
            cbColigada.FormattingEnabled = true;
            cbColigada.Location = new Point(22, 156);
            cbColigada.Name = "cbColigada";
            cbColigada.Size = new Size(174, 28);
            cbColigada.TabIndex = 8;
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(button1);
            gbFiltros.Controls.Add(checkDataFiltro);
            gbFiltros.Controls.Add(label6);
            gbFiltros.Controls.Add(dtpDocumento);
            gbFiltros.Controls.Add(tbValorDocumento);
            gbFiltros.Controls.Add(label5);
            gbFiltros.Controls.Add(tbHistorico);
            gbFiltros.Controls.Add(label4);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Controls.Add(tbComplemento);
            gbFiltros.Controls.Add(tbContaCredito);
            gbFiltros.Controls.Add(lbCredito);
            gbFiltros.Controls.Add(btnFiltrar);
            gbFiltros.Controls.Add(tbContaDebito);
            gbFiltros.Controls.Add(lbContaDebito);
            gbFiltros.Location = new Point(614, 17);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(741, 171);
            gbFiltros.TabIndex = 7;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros:";
            // 
            // checkDataFiltro
            // 
            checkDataFiltro.AutoSize = true;
            checkDataFiltro.Location = new Point(545, 81);
            checkDataFiltro.Name = "checkDataFiltro";
            checkDataFiltro.Size = new Size(145, 24);
            checkDataFiltro.TabIndex = 21;
            checkDataFiltro.Text = "Data Documento";
            checkDataFiltro.UseVisualStyleBackColor = true;
            checkDataFiltro.CheckedChanged += checkDataFiltro_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(539, 23);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 20;
            label6.Text = "Data:";
            // 
            // dtpDocumento
            // 
            dtpDocumento.Format = DateTimePickerFormat.Short;
            dtpDocumento.Location = new Point(545, 49);
            dtpDocumento.Name = "dtpDocumento";
            dtpDocumento.Size = new Size(150, 27);
            dtpDocumento.TabIndex = 19;
            // 
            // tbValorDocumento
            // 
            tbValorDocumento.Location = new Point(279, 113);
            tbValorDocumento.Name = "tbValorDocumento";
            tbValorDocumento.Size = new Size(129, 27);
            tbValorDocumento.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 85);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 17;
            label5.Text = "Valor";
            // 
            // tbHistorico
            // 
            tbHistorico.Location = new Point(370, 51);
            tbHistorico.Name = "tbHistorico";
            tbHistorico.Size = new Size(129, 27);
            tbHistorico.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 25);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 15;
            label4.Text = "Histórico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 83);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 14;
            label1.Text = "Complemento:";
            // 
            // tbComplemento
            // 
            tbComplemento.Location = new Point(28, 110);
            tbComplemento.Name = "tbComplemento";
            tbComplemento.Size = new Size(217, 27);
            tbComplemento.TabIndex = 13;
            // 
            // tbContaCredito
            // 
            tbContaCredito.Location = new Point(196, 51);
            tbContaCredito.Name = "tbContaCredito";
            tbContaCredito.Size = new Size(129, 27);
            tbContaCredito.TabIndex = 12;
            // 
            // lbCredito
            // 
            lbCredito.AutoSize = true;
            lbCredito.Location = new Point(196, 25);
            lbCredito.Name = "lbCredito";
            lbCredito.Size = new Size(104, 20);
            lbCredito.TabIndex = 11;
            lbCredito.Text = "Conta Credito:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(596, 116);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(114, 34);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // tbContaDebito
            // 
            tbContaDebito.Location = new Point(28, 51);
            tbContaDebito.Name = "tbContaDebito";
            tbContaDebito.Size = new Size(120, 27);
            tbContaDebito.TabIndex = 5;
            // 
            // lbContaDebito
            // 
            lbContaDebito.AutoSize = true;
            lbContaDebito.Location = new Point(28, 25);
            lbContaDebito.Name = "lbContaDebito";
            lbContaDebito.Size = new Size(101, 20);
            lbContaDebito.TabIndex = 6;
            lbContaDebito.Text = "Conta Débito:";
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
            // btnConferencia
            // 
            btnConferencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConferencia.Location = new Point(1065, 63);
            btnConferencia.Name = "btnConferencia";
            btnConferencia.Size = new Size(140, 35);
            btnConferencia.TabIndex = 9;
            btnConferencia.Text = "Conferir";
            btnConferencia.UseVisualStyleBackColor = true;
            btnConferencia.Click += btnConferencia_Click;
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
            dvgRelacaoBoletos.Size = new Size(1375, 632);
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
            tbControlBase.Size = new Size(1409, 679);
            tbControlBase.TabIndex = 3;
            // 
            // tbBaseImportada
            // 
            tbBaseImportada.Controls.Add(dvgRelacaoBoletos);
            tbBaseImportada.Location = new Point(4, 29);
            tbBaseImportada.Name = "tbBaseImportada";
            tbBaseImportada.Padding = new Padding(3);
            tbBaseImportada.Size = new Size(1401, 646);
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
            tbBaseConferencia.Size = new Size(1401, 646);
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
            dvgConferencia.Size = new Size(1392, 634);
            dvgConferencia.TabIndex = 0;
            // 
            // btnGeraLote
            // 
            btnGeraLote.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGeraLote.Location = new Point(1227, 63);
            btnGeraLote.Name = "btnGeraLote";
            btnGeraLote.Size = new Size(153, 35);
            btnGeraLote.TabIndex = 10;
            btnGeraLote.Text = "Gerar lotes";
            btnGeraLote.UseVisualStyleBackColor = true;
            btnGeraLote.Click += btnGeraLote_Click;
            // 
            // btnVisualiza
            // 
            btnVisualiza.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualiza.Location = new Point(1227, 20);
            btnVisualiza.Name = "btnVisualiza";
            btnVisualiza.Size = new Size(153, 35);
            btnVisualiza.TabIndex = 11;
            btnVisualiza.Text = "Visualizar";
            btnVisualiza.UseVisualStyleBackColor = true;
            btnVisualiza.Click += btnVisualiza_Click;
            // 
            // tbValor
            // 
            tbValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbValor.Location = new Point(148, 65);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(108, 27);
            tbValor.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(31, 34);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 18;
            label2.Text = "Total referente:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(36, 74);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 19;
            label3.Text = "Total:";
            // 
            // tbValorReferente
            // 
            tbValorReferente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbValorReferente.Location = new Point(148, 34);
            tbValorReferente.Name = "tbValorReferente";
            tbValorReferente.Size = new Size(108, 27);
            tbValorReferente.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnGeraLote);
            groupBox1.Controls.Add(btnVisualiza);
            groupBox1.Controls.Add(tbValorReferente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbValor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnConferencia);
            groupBox1.Location = new Point(16, 872);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1401, 108);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.Location = new Point(889, 63);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(140, 35);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(469, 116);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 22;
            button1.Text = "Limpar filtro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ConfereciaBoleto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 982);
            Controls.Add(tbControlBase);
            Controls.Add(gpHeader);
            Controls.Add(groupBox1);
            Name = "ConfereciaBoleto";
            Text = "ConfereciaBoleto";
            Load += ConfereciaBoleto_Load;
            gpHeader.ResumeLayout(false);
            gpHeader.PerformLayout();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRelacaoBoletos).EndInit();
            tbControlBase.ResumeLayout(false);
            tbBaseImportada.ResumeLayout(false);
            tbBaseConferencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgConferencia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImportarArquivo;
        private GroupBox gpHeader;
        private ComponentesTelaUI.DataGridView.MyDataGridView dvgRelacaoBoletos;
        private TextBox txtFileName;
        private TabControl tbControlBase;
        private TabPage tbBaseImportada;
        private TabPage tbBaseConferencia;
        private Label lbNomaArquivo;
        private TextBox tbContaDebito;
        private Button btnConferencia;
        private ComboBox cbColigada;
        private GroupBox gbFiltros;
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
        private TextBox tbValor;
        private Label label2;
        private Label label3;
        private TextBox tbValorReferente;
        private Label label1;
        private TextBox tbComplemento;
        private TextBox tbContaCredito;
        private Label lbCredito;
        private Label lbContaDebito;
        private GroupBox groupBox1;
        private TextBox tbHistorico;
        private Label label4;
        private TextBox tbValorDocumento;
        private Label label5;
        private DateTimePicker dtpDocumento;
        private Label label6;
        private CheckBox checkDataFiltro;
        private Button btnExcluir;
        private Button button1;
    }
}