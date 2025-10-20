namespace ERP_FISCAL.view
{
    partial class AlterarContaDebitoFrete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarContaDebitoFrete));
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoMovimento = new System.Windows.Forms.ComboBox();
            this.cbSelecionaItensComDivergencia = new System.Windows.Forms.CheckBox();
            this.lbMostrarTodos = new System.Windows.Forms.Label();
            this.cbItensParaMostrar = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.gbDeAcoes = new System.Windows.Forms.GroupBox();
            this.Alterar = new System.Windows.Forms.Button();
            this.btnAlterarEmBloco = new System.Windows.Forms.Button();
            this.dtContabilizacaoFrete = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.gbFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDeAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtContabilizacaoFrete)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltro.Controls.Add(this.groupBox1);
            this.gbFiltro.Controls.Add(this.btnPesquisar);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.dateTimePickerFim);
            this.gbFiltro.Controls.Add(this.dateTimePickerInicio);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(1358, 270);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTipoMovimento);
            this.groupBox1.Controls.Add(this.cbSelecionaItensComDivergencia);
            this.groupBox1.Controls.Add(this.lbMostrarTodos);
            this.groupBox1.Controls.Add(this.cbItensParaMostrar);
            this.groupBox1.Location = new System.Drawing.Point(444, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificar na tabela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escolher tipo de movimento";
            // 
            // cbTipoMovimento
            // 
            this.cbTipoMovimento.FormattingEnabled = true;
            this.cbTipoMovimento.Location = new System.Drawing.Point(29, 149);
            this.cbTipoMovimento.Name = "cbTipoMovimento";
            this.cbTipoMovimento.Size = new System.Drawing.Size(188, 28);
            this.cbTipoMovimento.TabIndex = 5;
            this.cbTipoMovimento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbSelecionaItensComDivergencia
            // 
            this.cbSelecionaItensComDivergencia.AutoSize = true;
            this.cbSelecionaItensComDivergencia.Location = new System.Drawing.Point(29, 191);
            this.cbSelecionaItensComDivergencia.Name = "cbSelecionaItensComDivergencia";
            this.cbSelecionaItensComDivergencia.Size = new System.Drawing.Size(214, 24);
            this.cbSelecionaItensComDivergencia.TabIndex = 4;
            this.cbSelecionaItensComDivergencia.Text = "Selecionar itens com erro";
            this.cbSelecionaItensComDivergencia.UseVisualStyleBackColor = true;
            this.cbSelecionaItensComDivergencia.CheckedChanged += new System.EventHandler(this.cbSelecionaItensComDivergencia_CheckedChanged);
            // 
            // lbMostrarTodos
            // 
            this.lbMostrarTodos.AutoSize = true;
            this.lbMostrarTodos.Location = new System.Drawing.Point(25, 34);
            this.lbMostrarTodos.Name = "lbMostrarTodos";
            this.lbMostrarTodos.Size = new System.Drawing.Size(286, 20);
            this.lbMostrarTodos.TabIndex = 3;
            this.lbMostrarTodos.Text = "Somente itens que precisa de correção";
            // 
            // cbItensParaMostrar
            // 
            this.cbItensParaMostrar.FormattingEnabled = true;
            this.cbItensParaMostrar.Location = new System.Drawing.Point(29, 70);
            this.cbItensParaMostrar.Name = "cbItensParaMostrar";
            this.cbItensParaMostrar.Size = new System.Drawing.Size(188, 28);
            this.cbItensParaMostrar.TabIndex = 2;
            this.cbItensParaMostrar.SelectedIndexChanged += new System.EventHandler(this.cbItensParaMostrar_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(227, 196);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(139, 39);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Lançamento Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Lançamento Inicio";
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFim.Location = new System.Drawing.Point(30, 171);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(132, 26);
            this.dateTimePickerFim.TabIndex = 1;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(30, 90);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(132, 26);
            this.dateTimePickerInicio.TabIndex = 0;
            // 
            // gbDeAcoes
            // 
            this.gbDeAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDeAcoes.Controls.Add(this.Alterar);
            this.gbDeAcoes.Controls.Add(this.btnAlterarEmBloco);
            this.gbDeAcoes.Location = new System.Drawing.Point(12, 909);
            this.gbDeAcoes.Name = "gbDeAcoes";
            this.gbDeAcoes.Size = new System.Drawing.Size(1358, 82);
            this.gbDeAcoes.TabIndex = 2;
            this.gbDeAcoes.TabStop = false;
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(23, 25);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(139, 39);
            this.Alterar.TabIndex = 8;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            // 
            // btnAlterarEmBloco
            // 
            this.btnAlterarEmBloco.Location = new System.Drawing.Point(185, 25);
            this.btnAlterarEmBloco.Name = "btnAlterarEmBloco";
            this.btnAlterarEmBloco.Size = new System.Drawing.Size(139, 39);
            this.btnAlterarEmBloco.TabIndex = 7;
            this.btnAlterarEmBloco.Text = "Alterar em Bloco";
            this.btnAlterarEmBloco.UseVisualStyleBackColor = true;
            this.btnAlterarEmBloco.Click += new System.EventHandler(this.btnAlterarEmBloco_Click);
            // 
            // dtContabilizacaoFrete
            // 
            this.dtContabilizacaoFrete.AllowUserToAddRows = false;
            this.dtContabilizacaoFrete.AllowUserToDeleteRows = false;
            this.dtContabilizacaoFrete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtContabilizacaoFrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtContabilizacaoFrete.Location = new System.Drawing.Point(12, 293);
            this.dtContabilizacaoFrete.Name = "dtContabilizacaoFrete";
            this.dtContabilizacaoFrete.RowHeadersWidth = 62;
            this.dtContabilizacaoFrete.RowTemplate.Height = 28;
            this.dtContabilizacaoFrete.Size = new System.Drawing.Size(1358, 615);
            this.dtContabilizacaoFrete.TabIndex = 1;
            this.dtContabilizacaoFrete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtContabilizacaoFrete_CellClick);
            this.dtContabilizacaoFrete.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtContabilizacaoFrete_RowPrePaint);
            // 
            // AlterarContaDebitoFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 1003);
            this.Controls.Add(this.gbDeAcoes);
            this.Controls.Add(this.dtContabilizacaoFrete);
            this.Controls.Add(this.gbFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarContaDebitoFrete";
            this.Text = "AlterarContaDebitoFrete";
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDeAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtContabilizacaoFrete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dtContabilizacaoFrete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMostrarTodos;
        private System.Windows.Forms.ComboBox cbItensParaMostrar;
        private System.Windows.Forms.GroupBox gbDeAcoes;
        private System.Windows.Forms.Button btnAlterarEmBloco;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.CheckBox cbSelecionaItensComDivergencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoMovimento;
    }
}