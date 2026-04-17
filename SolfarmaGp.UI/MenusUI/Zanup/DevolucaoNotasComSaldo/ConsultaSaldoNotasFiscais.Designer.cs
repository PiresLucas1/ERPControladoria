namespace SolfarmaGP.UI.MenusUI.Zanup.DevolucaoNota
{
    partial class ConsultaSaldoNotasFiscais
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
            gbFiltro = new GroupBox();
            groupBox1 = new GroupBox();
            cbFilial = new ComboBox();
            chkExibirRelacionados = new CheckBox();
            txtFiltro = new TextBox();
            lbFiltroSaldo = new Label();
            btnListaNotas = new Button();
            cbFiltroSaldo = new ComboBox();
            btnRelacionaItens = new Button();
            btGerarNotaFiscal = new Button();
            tabNavegacaoAba = new TabControl();
            tabConsultaItens = new TabPage();
            dvgConsultaNotas = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            tabItensSelecionado = new TabPage();
            dvgItensSelecionados = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            txtCountNotas = new TextBox();
            btnLimparTela = new Button();
            btnSelecionarTudo = new Button();
            btnAlteraEstoque = new Button();
            gbFiltro.SuspendLayout();
            groupBox1.SuspendLayout();
            tabNavegacaoAba.SuspendLayout();
            tabConsultaItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgConsultaNotas).BeginInit();
            tabItensSelecionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgItensSelecionados).BeginInit();
            SuspendLayout();
            // 
            // gbFiltro
            // 
            gbFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFiltro.Controls.Add(groupBox1);
            gbFiltro.Controls.Add(btnRelacionaItens);
            gbFiltro.Location = new Point(17, 15);
            gbFiltro.Margin = new Padding(3, 4, 3, 4);
            gbFiltro.Name = "gbFiltro";
            gbFiltro.Padding = new Padding(3, 4, 3, 4);
            gbFiltro.Size = new Size(1025, 164);
            gbFiltro.TabIndex = 0;
            gbFiltro.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbFilial);
            groupBox1.Controls.Add(chkExibirRelacionados);
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Controls.Add(lbFiltroSaldo);
            groupBox1.Controls.Add(btnListaNotas);
            groupBox1.Controls.Add(cbFiltroSaldo);
            groupBox1.Location = new Point(9, 14);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(566, 142);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro Prioritário";
            // 
            // cbFilial
            // 
            cbFilial.FormattingEnabled = true;
            cbFilial.Location = new Point(194, 46);
            cbFilial.Name = "cbFilial";
            cbFilial.Size = new Size(176, 28);
            cbFilial.TabIndex = 6;
            cbFilial.SelectedIndexChanged += cbFilial_SelectedIndexChanged;
            // 
            // chkExibirRelacionados
            // 
            chkExibirRelacionados.AutoSize = true;
            chkExibirRelacionados.Location = new Point(194, 108);
            chkExibirRelacionados.Name = "chkExibirRelacionados";
            chkExibirRelacionados.Size = new Size(193, 24);
            chkExibirRelacionados.TabIndex = 3;
            chkExibirRelacionados.Text = "Exibir da NF relacionada";
            chkExibirRelacionados.UseVisualStyleBackColor = true;
            chkExibirRelacionados.CheckedChanged += chkExibirRelacionados_CheckedChanged_1;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(9, 108);
            txtFiltro.Margin = new Padding(3, 4, 3, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(139, 27);
            txtFiltro.TabIndex = 2;
            txtFiltro.KeyPress += txtFiltro_KeyPress;
            // 
            // lbFiltroSaldo
            // 
            lbFiltroSaldo.AutoSize = true;
            lbFiltroSaldo.Location = new Point(6, 22);
            lbFiltroSaldo.Name = "lbFiltroSaldo";
            lbFiltroSaldo.Size = new Size(43, 20);
            lbFiltroSaldo.TabIndex = 5;
            lbFiltroSaldo.Text = "Filtro";
            // 
            // btnListaNotas
            // 
            btnListaNotas.Location = new Point(448, 98);
            btnListaNotas.Margin = new Padding(3, 4, 3, 4);
            btnListaNotas.Name = "btnListaNotas";
            btnListaNotas.Size = new Size(101, 36);
            btnListaNotas.TabIndex = 4;
            btnListaNotas.Text = "Listar notas";
            btnListaNotas.UseVisualStyleBackColor = true;
            btnListaNotas.Click += Button1_Click;
            // 
            // cbFiltroSaldo
            // 
            cbFiltroSaldo.FormattingEnabled = true;
            cbFiltroSaldo.Location = new Point(9, 46);
            cbFiltroSaldo.Margin = new Padding(3, 4, 3, 4);
            cbFiltroSaldo.Name = "cbFiltroSaldo";
            cbFiltroSaldo.Size = new Size(139, 28);
            cbFiltroSaldo.TabIndex = 1;
            cbFiltroSaldo.SelectedIndexChanged += cbFiltroSaldo_SelectedIndexChanged;
            // 
            // btnRelacionaItens
            // 
            btnRelacionaItens.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRelacionaItens.Location = new Point(868, 120);
            btnRelacionaItens.Margin = new Padding(3, 4, 3, 4);
            btnRelacionaItens.Name = "btnRelacionaItens";
            btnRelacionaItens.Size = new Size(139, 36);
            btnRelacionaItens.TabIndex = 5;
            btnRelacionaItens.Text = "Relacionar itens";
            btnRelacionaItens.UseVisualStyleBackColor = true;
            btnRelacionaItens.Click += btnRelacionaItens_Click;
            // 
            // btGerarNotaFiscal
            // 
            btGerarNotaFiscal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btGerarNotaFiscal.Location = new Point(885, 795);
            btGerarNotaFiscal.Margin = new Padding(3, 4, 3, 4);
            btGerarNotaFiscal.Name = "btGerarNotaFiscal";
            btGerarNotaFiscal.Size = new Size(151, 41);
            btGerarNotaFiscal.TabIndex = 6;
            btGerarNotaFiscal.Text = "Gerar nota fiscal";
            btGerarNotaFiscal.UseVisualStyleBackColor = true;
            btGerarNotaFiscal.Click += btGerarNotaFiscal_Click;
            // 
            // tabNavegacaoAba
            // 
            tabNavegacaoAba.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabNavegacaoAba.Controls.Add(tabConsultaItens);
            tabNavegacaoAba.Controls.Add(tabItensSelecionado);
            tabNavegacaoAba.Location = new Point(17, 186);
            tabNavegacaoAba.Margin = new Padding(3, 2, 3, 2);
            tabNavegacaoAba.Name = "tabNavegacaoAba";
            tabNavegacaoAba.SelectedIndex = 0;
            tabNavegacaoAba.Size = new Size(1028, 584);
            tabNavegacaoAba.TabIndex = 4;
            tabNavegacaoAba.Selected += tabNavegacaoAba_Selected;
            // 
            // tabConsultaItens
            // 
            tabConsultaItens.Controls.Add(dvgConsultaNotas);
            tabConsultaItens.Location = new Point(4, 29);
            tabConsultaItens.Margin = new Padding(3, 2, 3, 2);
            tabConsultaItens.Name = "tabConsultaItens";
            tabConsultaItens.Padding = new Padding(3, 2, 3, 2);
            tabConsultaItens.Size = new Size(1020, 551);
            tabConsultaItens.TabIndex = 0;
            tabConsultaItens.Text = "Consulta Itens";
            tabConsultaItens.UseVisualStyleBackColor = true;
            // 
            // dvgConsultaNotas
            // 
            dvgConsultaNotas.AllowUserToAddRows = false;
            dvgConsultaNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgConsultaNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgConsultaNotas.Location = new Point(5, 6);
            dvgConsultaNotas.Margin = new Padding(3, 2, 3, 2);
            dvgConsultaNotas.Name = "dvgConsultaNotas";
            dvgConsultaNotas.RowHeadersWidth = 62;
            dvgConsultaNotas.RowTemplate.Height = 28;
            dvgConsultaNotas.Size = new Size(1011, 539);
            dvgConsultaNotas.TabIndex = 0;
            dvgConsultaNotas.CellClick += dvgConsultaNotas_CellClick;
            dvgConsultaNotas.CellFormatting += dvgConsultaNotas_CellFormatting;
            dvgConsultaNotas.EditingControlShowing += dvgConsultaNotas_EditingControlShowing;
            // 
            // tabItensSelecionado
            // 
            tabItensSelecionado.Controls.Add(dvgItensSelecionados);
            tabItensSelecionado.Location = new Point(4, 29);
            tabItensSelecionado.Margin = new Padding(3, 2, 3, 2);
            tabItensSelecionado.Name = "tabItensSelecionado";
            tabItensSelecionado.Padding = new Padding(3, 2, 3, 2);
            tabItensSelecionado.Size = new Size(1020, 551);
            tabItensSelecionado.TabIndex = 1;
            tabItensSelecionado.Text = "Itens Selecionados";
            tabItensSelecionado.UseVisualStyleBackColor = true;
            // 
            // dvgItensSelecionados
            // 
            dvgItensSelecionados.AllowUserToAddRows = false;
            dvgItensSelecionados.AllowUserToResizeRows = false;
            dvgItensSelecionados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgItensSelecionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgItensSelecionados.Location = new Point(5, 6);
            dvgItensSelecionados.Margin = new Padding(3, 2, 3, 2);
            dvgItensSelecionados.Name = "dvgItensSelecionados";
            dvgItensSelecionados.RowHeadersVisible = false;
            dvgItensSelecionados.RowHeadersWidth = 62;
            dvgItensSelecionados.RowTemplate.Height = 28;
            dvgItensSelecionados.Size = new Size(1010, 539);
            dvgItensSelecionados.TabIndex = 0;
            dvgItensSelecionados.CellClick += dvgItensSelecionados_CellClick;
            dvgItensSelecionados.CellDoubleClick += dvgItensSelecionados_CellDoubleClick;
            // 
            // txtCountNotas
            // 
            txtCountNotas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtCountNotas.BackColor = SystemColors.ScrollBar;
            txtCountNotas.Enabled = false;
            txtCountNotas.Location = new Point(26, 802);
            txtCountNotas.Margin = new Padding(3, 4, 3, 4);
            txtCountNotas.Name = "txtCountNotas";
            txtCountNotas.Size = new Size(166, 27);
            txtCountNotas.TabIndex = 7;
            // 
            // btnLimparTela
            // 
            btnLimparTela.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimparTela.Enabled = false;
            btnLimparTela.Location = new Point(706, 795);
            btnLimparTela.Margin = new Padding(3, 4, 3, 4);
            btnLimparTela.Name = "btnLimparTela";
            btnLimparTela.Size = new Size(151, 41);
            btnLimparTela.TabIndex = 8;
            btnLimparTela.Text = "Limpar Tela";
            btnLimparTela.UseVisualStyleBackColor = true;
            btnLimparTela.Click += btnLimparTela_Click;
            // 
            // btnSelecionarTudo
            // 
            btnSelecionarTudo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSelecionarTudo.Enabled = false;
            btnSelecionarTudo.Location = new Point(220, 798);
            btnSelecionarTudo.Margin = new Padding(3, 4, 3, 4);
            btnSelecionarTudo.Name = "btnSelecionarTudo";
            btnSelecionarTudo.Size = new Size(136, 34);
            btnSelecionarTudo.TabIndex = 9;
            btnSelecionarTudo.Text = "Selecionar tudo";
            btnSelecionarTudo.UseVisualStyleBackColor = true;
            btnSelecionarTudo.Click += btnSelecionarTudo_Click;
            // 
            // btnAlteraEstoque
            // 
            btnAlteraEstoque.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlteraEstoque.Location = new Point(376, 798);
            btnAlteraEstoque.Margin = new Padding(3, 4, 3, 4);
            btnAlteraEstoque.Name = "btnAlteraEstoque";
            btnAlteraEstoque.Size = new Size(163, 33);
            btnAlteraEstoque.TabIndex = 10;
            btnAlteraEstoque.Text = "Alt Estoque Em Bloco";
            btnAlteraEstoque.UseVisualStyleBackColor = true;
            btnAlteraEstoque.Click += btnAlteraEstoque_Click;
            // 
            // ConsultaSaldoNotasFiscais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 866);
            Controls.Add(btnAlteraEstoque);
            Controls.Add(btnSelecionarTudo);
            Controls.Add(btnLimparTela);
            Controls.Add(txtCountNotas);
            Controls.Add(tabNavegacaoAba);
            Controls.Add(btGerarNotaFiscal);
            Controls.Add(gbFiltro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultaSaldoNotasFiscais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Saldo Notas Fiscais";
            gbFiltro.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabNavegacaoAba.ResumeLayout(false);
            tabConsultaItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgConsultaNotas).EndInit();
            tabItensSelecionado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgItensSelecionados).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Button btnListaNotas;
        private System.Windows.Forms.Button btGerarNotaFiscal;
        private System.Windows.Forms.TabControl tabNavegacaoAba;
        private System.Windows.Forms.TabPage tabConsultaItens;
        private System.Windows.Forms.TabPage tabItensSelecionado;
        private SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView dvgConsultaNotas;
        private SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView dvgItensSelecionados;
        private System.Windows.Forms.Button btnRelacionaItens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFiltroSaldo;
        private System.Windows.Forms.Label lbFiltroSaldo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.CheckBox chkExibirRelacionados;
        private System.Windows.Forms.TextBox txtCountNotas;
        private System.Windows.Forms.Button btnLimparTela;
        private System.Windows.Forms.Button btnSelecionarTudo;
        private System.Windows.Forms.ComboBox cbFilial;
        private Button btnAlteraEstoque;
    }
}