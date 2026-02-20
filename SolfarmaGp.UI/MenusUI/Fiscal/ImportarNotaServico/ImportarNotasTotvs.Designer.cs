namespace SolfarmaGP.UI.MenusUI.Fiscal.ImportarNotaServicoView
{
    partial class ImportarNotasTotvs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportarNotasTotvs));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnListaNotas = new Button();
            btnExportarTotvs = new Button();
            groupBox1 = new GroupBox();
            gbAutoFuncoes = new GroupBox();
            btnPreenche = new Button();
            btnAutoPreencherCfop = new Button();
            checkBoxMostraComErro = new CheckBox();
            cbLancadasNoERP = new CheckBox();
            lbDataInicio = new Label();
            label4 = new Label();
            lbDtFim = new Label();
            DtPickerInicio = new DateTimePicker();
            txtCnpjFor = new TextBox();
            DtPickerFim = new DateTimePicker();
            btnFiltrar = new Button();
            label2 = new Label();
            label3 = new Label();
            txtBoxToFilter = new TextBox();
            txtBoxColigada = new TextBox();
            txtBoxNumDoc = new TextBox();
            lbCodColigada = new Label();
            coBoxTipeFilter = new ComboBox();
            label1 = new Label();
            btnDesmarcarTodos = new Button();
            btnLimpar = new Button();
            btnSelecionarTodas = new Button();
            dtImportacao = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            groupBox1.SuspendLayout();
            gbAutoFuncoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtImportacao).BeginInit();
            SuspendLayout();
            // 
            // btnListaNotas
            // 
            btnListaNotas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnListaNotas.BackgroundImageLayout = ImageLayout.None;
            btnListaNotas.Location = new Point(1116, 152);
            btnListaNotas.Margin = new Padding(3, 4, 3, 4);
            btnListaNotas.Name = "btnListaNotas";
            btnListaNotas.Size = new Size(127, 40);
            btnListaNotas.TabIndex = 6;
            btnListaNotas.Text = "Pesquisar";
            btnListaNotas.UseVisualStyleBackColor = true;
            btnListaNotas.Click += btnListaNotas_Click;
            // 
            // btnExportarTotvs
            // 
            btnExportarTotvs.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportarTotvs.Location = new Point(1124, 952);
            btnExportarTotvs.Margin = new Padding(3, 4, 3, 4);
            btnExportarTotvs.Name = "btnExportarTotvs";
            btnExportarTotvs.Size = new Size(135, 41);
            btnExportarTotvs.TabIndex = 6;
            btnExportarTotvs.Text = "Exportar TOTVS";
            btnExportarTotvs.UseVisualStyleBackColor = true;
            btnExportarTotvs.Click += btnExportarTotvs_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(gbAutoFuncoes);
            groupBox1.Controls.Add(checkBoxMostraComErro);
            groupBox1.Controls.Add(cbLancadasNoERP);
            groupBox1.Controls.Add(lbDataInicio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbDtFim);
            groupBox1.Controls.Add(DtPickerInicio);
            groupBox1.Controls.Add(txtCnpjFor);
            groupBox1.Controls.Add(DtPickerFim);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnListaNotas);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBoxToFilter);
            groupBox1.Controls.Add(txtBoxColigada);
            groupBox1.Controls.Add(txtBoxNumDoc);
            groupBox1.Controls.Add(lbCodColigada);
            groupBox1.Controls.Add(coBoxTipeFilter);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 12);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1259, 216);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro Prioritário";
            // 
            // gbAutoFuncoes
            // 
            gbAutoFuncoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gbAutoFuncoes.Controls.Add(btnPreenche);
            gbAutoFuncoes.Controls.Add(btnAutoPreencherCfop);
            gbAutoFuncoes.Location = new Point(886, 78);
            gbAutoFuncoes.Margin = new Padding(3, 2, 50, 2);
            gbAutoFuncoes.Name = "gbAutoFuncoes";
            gbAutoFuncoes.Padding = new Padding(3, 2, 3, 2);
            gbAutoFuncoes.Size = new Size(215, 132);
            gbAutoFuncoes.TabIndex = 13;
            gbAutoFuncoes.TabStop = false;
            gbAutoFuncoes.Text = "Auto preenchimento";
            // 
            // btnPreenche
            // 
            btnPreenche.BackgroundImageLayout = ImageLayout.None;
            btnPreenche.Location = new Point(23, 75);
            btnPreenche.Margin = new Padding(3, 4, 3, 4);
            btnPreenche.Name = "btnPreenche";
            btnPreenche.Size = new Size(163, 40);
            btnPreenche.TabIndex = 13;
            btnPreenche.Text = "Preencher campos";
            btnPreenche.UseVisualStyleBackColor = true;
            btnPreenche.Click += btnPreenche_Click;
            // 
            // btnAutoPreencherCfop
            // 
            btnAutoPreencherCfop.BackgroundImageLayout = ImageLayout.None;
            btnAutoPreencherCfop.Enabled = false;
            btnAutoPreencherCfop.Location = new Point(23, 31);
            btnAutoPreencherCfop.Margin = new Padding(3, 4, 3, 4);
            btnAutoPreencherCfop.Name = "btnAutoPreencherCfop";
            btnAutoPreencherCfop.Size = new Size(163, 40);
            btnAutoPreencherCfop.TabIndex = 12;
            btnAutoPreencherCfop.Text = "Preencher CFOP";
            btnAutoPreencherCfop.UseVisualStyleBackColor = true;
            btnAutoPreencherCfop.Visible = false;
            btnAutoPreencherCfop.Click += btnAutoPreencherCfop_Click;
            // 
            // checkBoxMostraComErro
            // 
            checkBoxMostraComErro.AutoSize = true;
            checkBoxMostraComErro.Location = new Point(886, 34);
            checkBoxMostraComErro.Margin = new Padding(3, 2, 3, 2);
            checkBoxMostraComErro.Name = "checkBoxMostraComErro";
            checkBoxMostraComErro.Size = new Size(142, 24);
            checkBoxMostraComErro.TabIndex = 9;
            checkBoxMostraComErro.Text = "Celulas com Erro";
            checkBoxMostraComErro.UseVisualStyleBackColor = true;
            checkBoxMostraComErro.CheckedChanged += checkBoxMostraComErro_CheckedChanged;
            // 
            // cbLancadasNoERP
            // 
            cbLancadasNoERP.AutoSize = true;
            cbLancadasNoERP.Location = new Point(433, 125);
            cbLancadasNoERP.Margin = new Padding(3, 2, 3, 2);
            cbLancadasNoERP.Name = "cbLancadasNoERP";
            cbLancadasNoERP.Size = new Size(142, 24);
            cbLancadasNoERP.TabIndex = 6;
            cbLancadasNoERP.Text = "Lançadas no ERP";
            cbLancadasNoERP.UseVisualStyleBackColor = true;
            // 
            // lbDataInicio
            // 
            lbDataInicio.AutoSize = true;
            lbDataInicio.Location = new Point(228, 38);
            lbDataInicio.Name = "lbDataInicio";
            lbDataInicio.Size = new Size(48, 20);
            lbDataInicio.TabIndex = 2;
            lbDataInicio.Text = "Inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(649, 91);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 11;
            label4.Text = "CNPJ Fornecedor";
            // 
            // lbDtFim
            // 
            lbDtFim.AutoSize = true;
            lbDtFim.Location = new Point(228, 129);
            lbDtFim.Name = "lbDtFim";
            lbDtFim.Size = new Size(40, 20);
            lbDtFim.TabIndex = 3;
            lbDtFim.Text = "Final";
            // 
            // DtPickerInicio
            // 
            DtPickerInicio.Format = DateTimePickerFormat.Short;
            DtPickerInicio.Location = new Point(231, 59);
            DtPickerInicio.Margin = new Padding(3, 4, 3, 4);
            DtPickerInicio.Name = "DtPickerInicio";
            DtPickerInicio.Size = new Size(145, 27);
            DtPickerInicio.TabIndex = 0;
            // 
            // txtCnpjFor
            // 
            txtCnpjFor.Location = new Point(652, 114);
            txtCnpjFor.Margin = new Padding(3, 2, 3, 2);
            txtCnpjFor.Name = "txtCnpjFor";
            txtCnpjFor.Size = new Size(208, 27);
            txtCnpjFor.TabIndex = 10;
            // 
            // DtPickerFim
            // 
            DtPickerFim.Format = DateTimePickerFormat.Short;
            DtPickerFim.Location = new Point(231, 152);
            DtPickerFim.Margin = new Padding(3, 4, 3, 4);
            DtPickerFim.Name = "DtPickerFim";
            DtPickerFim.Size = new Size(145, 27);
            DtPickerFim.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackgroundImageLayout = ImageLayout.None;
            btnFiltrar.Location = new Point(652, 162);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(103, 34);
            btnFiltrar.TabIndex = 9;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 130);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 5;
            label2.Text = "Filtro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(649, 29);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 9;
            label3.Text = "Numero Documento";
            // 
            // txtBoxToFilter
            // 
            txtBoxToFilter.Location = new Point(19, 152);
            txtBoxToFilter.Margin = new Padding(3, 2, 3, 2);
            txtBoxToFilter.Name = "txtBoxToFilter";
            txtBoxToFilter.Size = new Size(152, 27);
            txtBoxToFilter.TabIndex = 4;
            // 
            // txtBoxColigada
            // 
            txtBoxColigada.Location = new Point(433, 62);
            txtBoxColigada.Margin = new Padding(3, 2, 3, 2);
            txtBoxColigada.Name = "txtBoxColigada";
            txtBoxColigada.Size = new Size(130, 27);
            txtBoxColigada.TabIndex = 0;
            // 
            // txtBoxNumDoc
            // 
            txtBoxNumDoc.Location = new Point(652, 52);
            txtBoxNumDoc.Margin = new Padding(3, 2, 3, 2);
            txtBoxNumDoc.Name = "txtBoxNumDoc";
            txtBoxNumDoc.Size = new Size(147, 27);
            txtBoxNumDoc.TabIndex = 7;
            // 
            // lbCodColigada
            // 
            lbCodColigada.AutoSize = true;
            lbCodColigada.Location = new Point(429, 38);
            lbCodColigada.Name = "lbCodColigada";
            lbCodColigada.Size = new Size(122, 20);
            lbCodColigada.TabIndex = 1;
            lbCodColigada.Text = "Código Coligada";
            // 
            // coBoxTipeFilter
            // 
            coBoxTipeFilter.FormattingEnabled = true;
            coBoxTipeFilter.Location = new Point(19, 61);
            coBoxTipeFilter.Margin = new Padding(3, 2, 3, 2);
            coBoxTipeFilter.Name = "coBoxTipeFilter";
            coBoxTipeFilter.Size = new Size(152, 28);
            coBoxTipeFilter.TabIndex = 3;
            coBoxTipeFilter.SelectedIndexChanged += coBoxTipeFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "Filtro";
            // 
            // btnDesmarcarTodos
            // 
            btnDesmarcarTodos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDesmarcarTodos.Location = new Point(16, 952);
            btnDesmarcarTodos.Margin = new Padding(3, 4, 3, 4);
            btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            btnDesmarcarTodos.Size = new Size(136, 41);
            btnDesmarcarTodos.TabIndex = 6;
            btnDesmarcarTodos.Text = "Desmarcar todos";
            btnDesmarcarTodos.Click += btnDesmarcarTodos_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpar.Location = new Point(379, 952);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 41);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btLimpar_Click;
            // 
            // btnSelecionarTodas
            // 
            btnSelecionarTodas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSelecionarTodas.Location = new Point(163, 952);
            btnSelecionarTodas.Margin = new Padding(3, 4, 3, 4);
            btnSelecionarTodas.Name = "btnSelecionarTodas";
            btnSelecionarTodas.Size = new Size(145, 41);
            btnSelecionarTodas.TabIndex = 6;
            btnSelecionarTodas.Text = "Selecionar todos";
            btnSelecionarTodas.UseVisualStyleBackColor = true;
            btnSelecionarTodas.Click += btnSelecionarTodos_Click;
            // 
            // dtImportacao
            // 
            dtImportacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtImportacao.Location = new Point(16, 219);
            dtImportacao.Name = "dtImportacao";
            dtImportacao.RowHeadersWidth = 51;
            dtImportacao.Size = new Size(1259, 710);
            dtImportacao.TabIndex = 7;
            dtImportacao.CellClick += dtImportacao_CellClick;
            dtImportacao.CellDoubleClick += dtImportacao_CellContentClick;
            dtImportacao.EditingControlShowing += dtImportacao_EditingControlShowing;
            dtImportacao.KeyDown += TextBox_KeyDown;
            // 
            // ImportarNotasTotvs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 1006);
            Controls.Add(dtImportacao);
            Controls.Add(btnDesmarcarTodos);
            Controls.Add(btnLimpar);
            Controls.Add(btnSelecionarTodas);
            Controls.Add(groupBox1);
            Controls.Add(btnExportarTotvs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImportarNotasTotvs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Importação NFS-E";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbAutoFuncoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtImportacao).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
             
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
        private System.Windows.Forms.Button btnDesmarcarTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSelecionarTodas;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNumDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCnpjFor;
        private System.Windows.Forms.CheckBox checkBoxMostraComErro;
        private System.Windows.Forms.Button btnAutoPreencherCfop;
        private System.Windows.Forms.GroupBox gbAutoFuncoes;
        private System.Windows.Forms.Button btnPreenche;
        private SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView dtImportacao;
    }
}

