namespace ERP_FISCAL
{
    partial class ExportarNotasTotvs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportarNotasTotvs));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnListaNotas = new System.Windows.Forms.Button();
            this.btnExportarTotvs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAutoFuncoes = new System.Windows.Forms.GroupBox();
            this.btnPreenche = new System.Windows.Forms.Button();
            this.btnAutoPreencherCfop = new System.Windows.Forms.Button();
            this.checkBoxMostraComErro = new System.Windows.Forms.CheckBox();
            this.cbLancadasNoERP = new System.Windows.Forms.CheckBox();
            this.lbDataInicio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDtFim = new System.Windows.Forms.Label();
            this.DtPickerInicio = new System.Windows.Forms.DateTimePicker();
            this.txtCnpjFor = new System.Windows.Forms.TextBox();
            this.DtPickerFim = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxToFilter = new System.Windows.Forms.TextBox();
            this.txtBoxColigada = new System.Windows.Forms.TextBox();
            this.txtBoxNumDoc = new System.Windows.Forms.TextBox();
            this.lbCodColigada = new System.Windows.Forms.Label();
            this.coBoxTipeFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserirEmBloco = new System.Windows.Forms.Button();
            this.btnDesmarcarTodos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSelecionarTodas = new System.Windows.Forms.Button();
            this.dtImportacao = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.groupBox1.SuspendLayout();
            this.gbAutoFuncoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtImportacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListaNotas
            // 
            this.btnListaNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListaNotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListaNotas.Location = new System.Drawing.Point(1116, 122);
            this.btnListaNotas.Name = "btnListaNotas";
            this.btnListaNotas.Size = new System.Drawing.Size(127, 32);
            this.btnListaNotas.TabIndex = 6;
            this.btnListaNotas.Text = "Pesquisar";
            this.btnListaNotas.UseVisualStyleBackColor = true;
            this.btnListaNotas.Click += new System.EventHandler(this.btnListaNotas_Click);
            // 
            // btnExportarTotvs
            // 
            this.btnExportarTotvs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarTotvs.Location = new System.Drawing.Point(1124, 762);
            this.btnExportarTotvs.Name = "btnExportarTotvs";
            this.btnExportarTotvs.Size = new System.Drawing.Size(135, 33);
            this.btnExportarTotvs.TabIndex = 6;
            this.btnExportarTotvs.Text = "Exportar TOTVS";
            this.btnExportarTotvs.UseVisualStyleBackColor = true;
            this.btnExportarTotvs.Click += new System.EventHandler(this.btnExportarTotvs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gbAutoFuncoes);
            this.groupBox1.Controls.Add(this.checkBoxMostraComErro);
            this.groupBox1.Controls.Add(this.cbLancadasNoERP);
            this.groupBox1.Controls.Add(this.lbDataInicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbDtFim);
            this.groupBox1.Controls.Add(this.DtPickerInicio);
            this.groupBox1.Controls.Add(this.txtCnpjFor);
            this.groupBox1.Controls.Add(this.DtPickerFim);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnListaNotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxToFilter);
            this.groupBox1.Controls.Add(this.txtBoxColigada);
            this.groupBox1.Controls.Add(this.txtBoxNumDoc);
            this.groupBox1.Controls.Add(this.lbCodColigada);
            this.groupBox1.Controls.Add(this.coBoxTipeFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1259, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Prioritário";
            // 
            // gbAutoFuncoes
            // 
            this.gbAutoFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbAutoFuncoes.Controls.Add(this.btnPreenche);
            this.gbAutoFuncoes.Controls.Add(this.btnAutoPreencherCfop);
            this.gbAutoFuncoes.Location = new System.Drawing.Point(886, 62);
            this.gbAutoFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.gbAutoFuncoes.Name = "gbAutoFuncoes";
            this.gbAutoFuncoes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAutoFuncoes.Size = new System.Drawing.Size(215, 106);
            this.gbAutoFuncoes.TabIndex = 13;
            this.gbAutoFuncoes.TabStop = false;
            this.gbAutoFuncoes.Text = "Auto preenchimento";
            // 
            // btnPreenche
            // 
            this.btnPreenche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreenche.Location = new System.Drawing.Point(23, 60);
            this.btnPreenche.Name = "btnPreenche";
            this.btnPreenche.Size = new System.Drawing.Size(163, 32);
            this.btnPreenche.TabIndex = 13;
            this.btnPreenche.Text = "Preencher campos";
            this.btnPreenche.UseVisualStyleBackColor = true;
            this.btnPreenche.Click += new System.EventHandler(this.btnPreenche_Click);
            // 
            // btnAutoPreencherCfop
            // 
            this.btnAutoPreencherCfop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAutoPreencherCfop.Enabled = false;
            this.btnAutoPreencherCfop.Location = new System.Drawing.Point(23, 25);
            this.btnAutoPreencherCfop.Name = "btnAutoPreencherCfop";
            this.btnAutoPreencherCfop.Size = new System.Drawing.Size(163, 32);
            this.btnAutoPreencherCfop.TabIndex = 12;
            this.btnAutoPreencherCfop.Text = "Preencher CFOP";
            this.btnAutoPreencherCfop.UseVisualStyleBackColor = true;
            this.btnAutoPreencherCfop.Visible = false;
            this.btnAutoPreencherCfop.Click += new System.EventHandler(this.btnAutoPreencherCfop_Click);
            // 
            // checkBoxMostraComErro
            // 
            this.checkBoxMostraComErro.AutoSize = true;
            this.checkBoxMostraComErro.Location = new System.Drawing.Point(886, 27);
            this.checkBoxMostraComErro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMostraComErro.Name = "checkBoxMostraComErro";
            this.checkBoxMostraComErro.Size = new System.Drawing.Size(131, 20);
            this.checkBoxMostraComErro.TabIndex = 9;
            this.checkBoxMostraComErro.Text = "Celulas com Erro";
            this.checkBoxMostraComErro.UseVisualStyleBackColor = true;
            this.checkBoxMostraComErro.CheckedChanged += new System.EventHandler(this.checkBoxMostraComErro_CheckedChanged);
            // 
            // cbLancadasNoERP
            // 
            this.cbLancadasNoERP.AutoSize = true;
            this.cbLancadasNoERP.Location = new System.Drawing.Point(433, 100);
            this.cbLancadasNoERP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLancadasNoERP.Name = "cbLancadasNoERP";
            this.cbLancadasNoERP.Size = new System.Drawing.Size(138, 20);
            this.cbLancadasNoERP.TabIndex = 6;
            this.cbLancadasNoERP.Text = "Lançadas no ERP";
            this.cbLancadasNoERP.UseVisualStyleBackColor = true;
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(228, 30);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(41, 16);
            this.lbDataInicio.TabIndex = 2;
            this.lbDataInicio.Text = "Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CNPJ Fornecedor";
            // 
            // lbDtFim
            // 
            this.lbDtFim.AutoSize = true;
            this.lbDtFim.Location = new System.Drawing.Point(228, 103);
            this.lbDtFim.Name = "lbDtFim";
            this.lbDtFim.Size = new System.Drawing.Size(36, 16);
            this.lbDtFim.TabIndex = 3;
            this.lbDtFim.Text = "Final";
            // 
            // DtPickerInicio
            // 
            this.DtPickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerInicio.Location = new System.Drawing.Point(231, 47);
            this.DtPickerInicio.Name = "DtPickerInicio";
            this.DtPickerInicio.Size = new System.Drawing.Size(145, 22);
            this.DtPickerInicio.TabIndex = 0;
            // 
            // txtCnpjFor
            // 
            this.txtCnpjFor.Location = new System.Drawing.Point(652, 91);
            this.txtCnpjFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCnpjFor.Name = "txtCnpjFor";
            this.txtCnpjFor.Size = new System.Drawing.Size(208, 22);
            this.txtCnpjFor.TabIndex = 10;
            // 
            // DtPickerFim
            // 
            this.DtPickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerFim.Location = new System.Drawing.Point(231, 122);
            this.DtPickerFim.Name = "DtPickerFim";
            this.DtPickerFim.Size = new System.Drawing.Size(145, 22);
            this.DtPickerFim.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFiltrar.Location = new System.Drawing.Point(652, 130);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(103, 27);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero Documento";
            // 
            // txtBoxToFilter
            // 
            this.txtBoxToFilter.Location = new System.Drawing.Point(19, 122);
            this.txtBoxToFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxToFilter.Name = "txtBoxToFilter";
            this.txtBoxToFilter.Size = new System.Drawing.Size(152, 22);
            this.txtBoxToFilter.TabIndex = 4;
            // 
            // txtBoxColigada
            // 
            this.txtBoxColigada.Location = new System.Drawing.Point(433, 50);
            this.txtBoxColigada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxColigada.Name = "txtBoxColigada";
            this.txtBoxColigada.Size = new System.Drawing.Size(130, 22);
            this.txtBoxColigada.TabIndex = 0;
            // 
            // txtBoxNumDoc
            // 
            this.txtBoxNumDoc.Location = new System.Drawing.Point(652, 42);
            this.txtBoxNumDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNumDoc.Name = "txtBoxNumDoc";
            this.txtBoxNumDoc.Size = new System.Drawing.Size(147, 22);
            this.txtBoxNumDoc.TabIndex = 7;
            // 
            // lbCodColigada
            // 
            this.lbCodColigada.AutoSize = true;
            this.lbCodColigada.Location = new System.Drawing.Point(429, 30);
            this.lbCodColigada.Name = "lbCodColigada";
            this.lbCodColigada.Size = new System.Drawing.Size(109, 16);
            this.lbCodColigada.TabIndex = 1;
            this.lbCodColigada.Text = "Código Coligada";
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
            // btnInserirEmBloco
            // 
            this.btnInserirEmBloco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInserirEmBloco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirEmBloco.Enabled = false;
            this.btnInserirEmBloco.Location = new System.Drawing.Point(674, 994);
            this.btnInserirEmBloco.Name = "btnInserirEmBloco";
            this.btnInserirEmBloco.Size = new System.Drawing.Size(151, 32);
            this.btnInserirEmBloco.TabIndex = 7;
            this.btnInserirEmBloco.Text = "Inserir em bloco";
            this.btnInserirEmBloco.UseVisualStyleBackColor = true;
            this.btnInserirEmBloco.Visible = false;
            this.btnInserirEmBloco.Click += new System.EventHandler(this.btnInserirEmBloco_Click);
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(16, 762);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(136, 33);
            this.btnDesmarcarTodos.TabIndex = 6;
            this.btnDesmarcarTodos.Text = "Desmarcar todos";
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(293, 762);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 33);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btnSelecionarTodas
            // 
            this.btnSelecionarTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelecionarTodas.Location = new System.Drawing.Point(163, 762);
            this.btnSelecionarTodas.Name = "btnSelecionarTodas";
            this.btnSelecionarTodas.Size = new System.Drawing.Size(125, 33);
            this.btnSelecionarTodas.TabIndex = 6;
            this.btnSelecionarTodas.Text = "Selecionar todos";
            this.btnSelecionarTodas.UseVisualStyleBackColor = true;
            this.btnSelecionarTodas.Click += new System.EventHandler(this.btnSelecionarTodos_Click);
            // 
            // dtImportacao
            // 
            this.dtImportacao.AllowUserToAddRows = false;
            this.dtImportacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtImportacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtImportacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtImportacao.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtImportacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtImportacao.ColumnHeadersHeight = 34;
            this.dtImportacao.Location = new System.Drawing.Point(12, 189);
            this.dtImportacao.Name = "dtImportacao";
            this.dtImportacao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtImportacao.RowTemplate.Height = 24;
            this.dtImportacao.Size = new System.Drawing.Size(1262, 558);
            this.dtImportacao.TabIndex = 5;
            this.dtImportacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtImportacao_CellClick);
            this.dtImportacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtImportacao_CellContentClick);
            this.dtImportacao.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtImportacao_EditingControlShowing);
            this.dtImportacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // ExportarNotasTotvs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 805);
            this.Controls.Add(this.btnDesmarcarTodos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelecionarTodas);
            this.Controls.Add(this.btnInserirEmBloco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportarTotvs);
            this.Controls.Add(this.dtImportacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportarNotasTotvs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importação NFS-E";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAutoFuncoes.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNumDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCnpjFor;
        private System.Windows.Forms.CheckBox checkBoxMostraComErro;
        private System.Windows.Forms.Button btnAutoPreencherCfop;
        private System.Windows.Forms.GroupBox gbAutoFuncoes;
        private System.Windows.Forms.Button btnPreenche;
    }
}

