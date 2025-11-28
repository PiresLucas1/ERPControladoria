namespace ERP_FISCAL.view
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
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkExibirRelacionados = new System.Windows.Forms.CheckBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lbFiltroSaldo = new System.Windows.Forms.Label();
            this.btnListaNotas = new System.Windows.Forms.Button();
            this.cbFiltroSaldo = new System.Windows.Forms.ComboBox();
            this.btnRelacionaItens = new System.Windows.Forms.Button();
            this.btGerarNotaFiscal = new System.Windows.Forms.Button();
            this.tabNavegacaoAba = new System.Windows.Forms.TabControl();
            this.tabConsultaItens = new System.Windows.Forms.TabPage();
            this.dvgConsultaNotas = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.tabItensSelecionado = new System.Windows.Forms.TabPage();
            this.dvgItensSelecionados = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.txtCountNotas = new System.Windows.Forms.TextBox();
            this.btnLimparTela = new System.Windows.Forms.Button();
            this.btnSelecionarTudo = new System.Windows.Forms.Button();
            this.gbFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavegacaoAba.SuspendLayout();
            this.tabConsultaItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsultaNotas)).BeginInit();
            this.tabItensSelecionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgItensSelecionados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltro.Controls.Add(this.groupBox1);
            this.gbFiltro.Controls.Add(this.btnRelacionaItens);
            this.gbFiltro.Location = new System.Drawing.Point(19, 15);
            this.gbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFiltro.Size = new System.Drawing.Size(1153, 164);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkExibirRelacionados);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.lbFiltroSaldo);
            this.groupBox1.Controls.Add(this.btnListaNotas);
            this.groupBox1.Controls.Add(this.cbFiltroSaldo);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(523, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Prioritário";
            // 
            // chkExibirRelacionados
            // 
            this.chkExibirRelacionados.AutoSize = true;
            this.chkExibirRelacionados.Location = new System.Drawing.Point(144, 110);
            this.chkExibirRelacionados.Name = "chkExibirRelacionados";
            this.chkExibirRelacionados.Size = new System.Drawing.Size(206, 24);
            this.chkExibirRelacionados.TabIndex = 3;
            this.chkExibirRelacionados.Text = "Exibir da NF relacionada";
            this.chkExibirRelacionados.UseVisualStyleBackColor = true;
            this.chkExibirRelacionados.CheckedChanged += new System.EventHandler(this.chkExibirRelacionados_CheckedChanged_1);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(10, 108);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(114, 26);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // lbFiltroSaldo
            // 
            this.lbFiltroSaldo.AutoSize = true;
            this.lbFiltroSaldo.Location = new System.Drawing.Point(7, 22);
            this.lbFiltroSaldo.Name = "lbFiltroSaldo";
            this.lbFiltroSaldo.Size = new System.Drawing.Size(44, 20);
            this.lbFiltroSaldo.TabIndex = 5;
            this.lbFiltroSaldo.Text = "Filtro";
            // 
            // btnListaNotas
            // 
            this.btnListaNotas.Location = new System.Drawing.Point(403, 98);
            this.btnListaNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaNotas.Name = "btnListaNotas";
            this.btnListaNotas.Size = new System.Drawing.Size(114, 36);
            this.btnListaNotas.TabIndex = 4;
            this.btnListaNotas.Text = "Listar notas";
            this.btnListaNotas.UseVisualStyleBackColor = true;
            this.btnListaNotas.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbFiltroSaldo
            // 
            this.cbFiltroSaldo.FormattingEnabled = true;
            this.cbFiltroSaldo.Location = new System.Drawing.Point(10, 46);
            this.cbFiltroSaldo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFiltroSaldo.Name = "cbFiltroSaldo";
            this.cbFiltroSaldo.Size = new System.Drawing.Size(114, 28);
            this.cbFiltroSaldo.TabIndex = 1;
            this.cbFiltroSaldo.SelectedIndexChanged += new System.EventHandler(this.cbFiltroSaldo_SelectedIndexChanged);
            // 
            // btnRelacionaItens
            // 
            this.btnRelacionaItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelacionaItens.Location = new System.Drawing.Point(977, 120);
            this.btnRelacionaItens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRelacionaItens.Name = "btnRelacionaItens";
            this.btnRelacionaItens.Size = new System.Drawing.Size(156, 36);
            this.btnRelacionaItens.TabIndex = 5;
            this.btnRelacionaItens.Text = "Relacionar itens";
            this.btnRelacionaItens.UseVisualStyleBackColor = true;
            this.btnRelacionaItens.Click += new System.EventHandler(this.btnRelacionaItens_Click);
            // 
            // btGerarNotaFiscal
            // 
            this.btGerarNotaFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarNotaFiscal.Location = new System.Drawing.Point(996, 795);
            this.btGerarNotaFiscal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btGerarNotaFiscal.Name = "btGerarNotaFiscal";
            this.btGerarNotaFiscal.Size = new System.Drawing.Size(170, 41);
            this.btGerarNotaFiscal.TabIndex = 6;
            this.btGerarNotaFiscal.Text = "Gerar nota fiscal";
            this.btGerarNotaFiscal.UseVisualStyleBackColor = true;
            this.btGerarNotaFiscal.Click += new System.EventHandler(this.btGerarNotaFiscal_Click);
            // 
            // tabNavegacaoAba
            // 
            this.tabNavegacaoAba.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabNavegacaoAba.Controls.Add(this.tabConsultaItens);
            this.tabNavegacaoAba.Controls.Add(this.tabItensSelecionado);
            this.tabNavegacaoAba.Location = new System.Drawing.Point(19, 186);
            this.tabNavegacaoAba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNavegacaoAba.Name = "tabNavegacaoAba";
            this.tabNavegacaoAba.SelectedIndex = 0;
            this.tabNavegacaoAba.Size = new System.Drawing.Size(1156, 584);
            this.tabNavegacaoAba.TabIndex = 4;
            this.tabNavegacaoAba.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabNavegacaoAba_Selected);
            // 
            // tabConsultaItens
            // 
            this.tabConsultaItens.Controls.Add(this.dvgConsultaNotas);
            this.tabConsultaItens.Location = new System.Drawing.Point(4, 29);
            this.tabConsultaItens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabConsultaItens.Name = "tabConsultaItens";
            this.tabConsultaItens.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabConsultaItens.Size = new System.Drawing.Size(1148, 551);
            this.tabConsultaItens.TabIndex = 0;
            this.tabConsultaItens.Text = "Consulta Itens";
            this.tabConsultaItens.UseVisualStyleBackColor = true;
            // 
            // dvgConsultaNotas
            // 
            this.dvgConsultaNotas.AllowUserToAddRows = false;
            this.dvgConsultaNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgConsultaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsultaNotas.Location = new System.Drawing.Point(6, 6);
            this.dvgConsultaNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgConsultaNotas.Name = "dvgConsultaNotas";
            this.dvgConsultaNotas.RowHeadersWidth = 62;
            this.dvgConsultaNotas.RowTemplate.Height = 28;
            this.dvgConsultaNotas.Size = new System.Drawing.Size(1137, 539);
            this.dvgConsultaNotas.TabIndex = 0;
            this.dvgConsultaNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgConsultaNotas_CellClick);
            this.dvgConsultaNotas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgConsultaNotas_CellFormatting);
            this.dvgConsultaNotas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dvgConsultaNotas_EditingControlShowing);
            // 
            // tabItensSelecionado
            // 
            this.tabItensSelecionado.Controls.Add(this.dvgItensSelecionados);
            this.tabItensSelecionado.Location = new System.Drawing.Point(4, 29);
            this.tabItensSelecionado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabItensSelecionado.Name = "tabItensSelecionado";
            this.tabItensSelecionado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabItensSelecionado.Size = new System.Drawing.Size(1148, 551);
            this.tabItensSelecionado.TabIndex = 1;
            this.tabItensSelecionado.Text = "Itens Selecionados";
            this.tabItensSelecionado.UseVisualStyleBackColor = true;
            // 
            // dvgItensSelecionados
            // 
            this.dvgItensSelecionados.AllowUserToAddRows = false;
            this.dvgItensSelecionados.AllowUserToResizeRows = false;
            this.dvgItensSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgItensSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgItensSelecionados.Location = new System.Drawing.Point(6, 6);
            this.dvgItensSelecionados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgItensSelecionados.Name = "dvgItensSelecionados";
            this.dvgItensSelecionados.RowHeadersVisible = false;
            this.dvgItensSelecionados.RowHeadersWidth = 62;
            this.dvgItensSelecionados.RowTemplate.Height = 28;
            this.dvgItensSelecionados.Size = new System.Drawing.Size(1136, 539);
            this.dvgItensSelecionados.TabIndex = 0;
            this.dvgItensSelecionados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgItensSelecionados_CellClick);
            this.dvgItensSelecionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgItensSelecionados_CellDoubleClick);
            // 
            // txtCountNotas
            // 
            this.txtCountNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCountNotas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCountNotas.Enabled = false;
            this.txtCountNotas.Location = new System.Drawing.Point(29, 802);
            this.txtCountNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountNotas.Name = "txtCountNotas";
            this.txtCountNotas.Size = new System.Drawing.Size(186, 26);
            this.txtCountNotas.TabIndex = 7;
            // 
            // btnLimparTela
            // 
            this.btnLimparTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparTela.Enabled = false;
            this.btnLimparTela.Location = new System.Drawing.Point(794, 795);
            this.btnLimparTela.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimparTela.Name = "btnLimparTela";
            this.btnLimparTela.Size = new System.Drawing.Size(170, 41);
            this.btnLimparTela.TabIndex = 8;
            this.btnLimparTela.Text = "Limpar Tela";
            this.btnLimparTela.UseVisualStyleBackColor = true;
            this.btnLimparTela.Click += new System.EventHandler(this.btnLimparTela_Click);
            // 
            // btnSelecionarTudo
            // 
            this.btnSelecionarTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarTudo.Enabled = false;
            this.btnSelecionarTudo.Location = new System.Drawing.Point(312, 795);
            this.btnSelecionarTudo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelecionarTudo.Name = "btnSelecionarTudo";
            this.btnSelecionarTudo.Size = new System.Drawing.Size(170, 41);
            this.btnSelecionarTudo.TabIndex = 9;
            this.btnSelecionarTudo.Text = "Selecionar tudo";
            this.btnSelecionarTudo.UseVisualStyleBackColor = true;
            this.btnSelecionarTudo.Click += new System.EventHandler(this.btnSelecionarTudo_Click);
            // 
            // ConsultaSaldoNotasFiscais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 866);
            this.Controls.Add(this.btnSelecionarTudo);
            this.Controls.Add(this.btnLimparTela);
            this.Controls.Add(this.txtCountNotas);
            this.Controls.Add(this.tabNavegacaoAba);
            this.Controls.Add(this.btGerarNotaFiscal);
            this.Controls.Add(this.gbFiltro);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConsultaSaldoNotasFiscais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Saldo Notas Fiscais";
            this.gbFiltro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavegacaoAba.ResumeLayout(false);
            this.tabConsultaItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsultaNotas)).EndInit();
            this.tabItensSelecionado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgItensSelecionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Button btnListaNotas;
        private System.Windows.Forms.Button btGerarNotaFiscal;
        private System.Windows.Forms.TabControl tabNavegacaoAba;
        private System.Windows.Forms.TabPage tabConsultaItens;
        private System.Windows.Forms.TabPage tabItensSelecionado;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgConsultaNotas;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgItensSelecionados;
        private System.Windows.Forms.Button btnRelacionaItens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFiltroSaldo;
        private System.Windows.Forms.Label lbFiltroSaldo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.CheckBox chkExibirRelacionados;
        private System.Windows.Forms.TextBox txtCountNotas;
        private System.Windows.Forms.Button btnLimparTela;
        private System.Windows.Forms.Button btnSelecionarTudo;
    }
}