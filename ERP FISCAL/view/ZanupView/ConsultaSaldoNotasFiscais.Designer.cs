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
            this.btnRelacionaItens = new System.Windows.Forms.Button();
            this.btnListaNotas = new System.Windows.Forms.Button();
            this.btGerarNotaFiscal = new System.Windows.Forms.Button();
            this.tabNavegacaoAba = new System.Windows.Forms.TabControl();
            this.tabConsultaItens = new System.Windows.Forms.TabPage();
            this.dvgConsultaNotas = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.tabItensSelecionado = new System.Windows.Forms.TabPage();
            this.dvgItensSelecionados = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.cbFiltroSaldo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbFiltroSaldo = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.gbFiltro.SuspendLayout();
            this.tabNavegacaoAba.SuspendLayout();
            this.tabConsultaItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsultaNotas)).BeginInit();
            this.tabItensSelecionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgItensSelecionados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltro.Controls.Add(this.groupBox1);
            this.gbFiltro.Controls.Add(this.btnRelacionaItens);
            this.gbFiltro.Controls.Add(this.btnListaNotas);
            this.gbFiltro.Location = new System.Drawing.Point(17, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(1025, 131);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            // 
            // btnRelacionaItens
            // 
            this.btnRelacionaItens.Location = new System.Drawing.Point(244, 90);
            this.btnRelacionaItens.Name = "btnRelacionaItens";
            this.btnRelacionaItens.Size = new System.Drawing.Size(139, 29);
            this.btnRelacionaItens.TabIndex = 3;
            this.btnRelacionaItens.Text = "Relacionar itens";
            this.btnRelacionaItens.UseVisualStyleBackColor = true;
            this.btnRelacionaItens.Click += new System.EventHandler(this.btnRelacionaItens_Click);
            // 
            // btnListaNotas
            // 
            this.btnListaNotas.Location = new System.Drawing.Point(244, 29);
            this.btnListaNotas.Name = "btnListaNotas";
            this.btnListaNotas.Size = new System.Drawing.Size(101, 29);
            this.btnListaNotas.TabIndex = 2;
            this.btnListaNotas.Text = "Listar notas";
            this.btnListaNotas.UseVisualStyleBackColor = true;
            this.btnListaNotas.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btGerarNotaFiscal
            // 
            this.btGerarNotaFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarNotaFiscal.Location = new System.Drawing.Point(885, 636);
            this.btGerarNotaFiscal.Name = "btGerarNotaFiscal";
            this.btGerarNotaFiscal.Size = new System.Drawing.Size(151, 33);
            this.btGerarNotaFiscal.TabIndex = 3;
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
            this.tabNavegacaoAba.Location = new System.Drawing.Point(17, 149);
            this.tabNavegacaoAba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNavegacaoAba.Name = "tabNavegacaoAba";
            this.tabNavegacaoAba.SelectedIndex = 0;
            this.tabNavegacaoAba.Size = new System.Drawing.Size(1028, 467);
            this.tabNavegacaoAba.TabIndex = 4;
            this.tabNavegacaoAba.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabNavegacaoAba_Selected);
            // 
            // tabConsultaItens
            // 
            this.tabConsultaItens.Controls.Add(this.dvgConsultaNotas);
            this.tabConsultaItens.Location = new System.Drawing.Point(4, 25);
            this.tabConsultaItens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabConsultaItens.Name = "tabConsultaItens";
            this.tabConsultaItens.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabConsultaItens.Size = new System.Drawing.Size(1020, 438);
            this.tabConsultaItens.TabIndex = 0;
            this.tabConsultaItens.Text = "Consulta Itens";
            this.tabConsultaItens.UseVisualStyleBackColor = true;
            // 
            // dvgConsultaNotas
            // 
            this.dvgConsultaNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgConsultaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsultaNotas.Location = new System.Drawing.Point(5, 5);
            this.dvgConsultaNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgConsultaNotas.Name = "dvgConsultaNotas";
            this.dvgConsultaNotas.RowHeadersWidth = 62;
            this.dvgConsultaNotas.RowTemplate.Height = 28;
            this.dvgConsultaNotas.Size = new System.Drawing.Size(1011, 431);
            this.dvgConsultaNotas.TabIndex = 0;
            this.dvgConsultaNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgConsultaNotas_CellClick);
            this.dvgConsultaNotas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dvgConsultaNotas_EditingControlShowing);
            // 
            // tabItensSelecionado
            // 
            this.tabItensSelecionado.Controls.Add(this.dvgItensSelecionados);
            this.tabItensSelecionado.Location = new System.Drawing.Point(4, 25);
            this.tabItensSelecionado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabItensSelecionado.Name = "tabItensSelecionado";
            this.tabItensSelecionado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabItensSelecionado.Size = new System.Drawing.Size(1020, 438);
            this.tabItensSelecionado.TabIndex = 1;
            this.tabItensSelecionado.Text = "Itens Selecionados";
            this.tabItensSelecionado.UseVisualStyleBackColor = true;
            // 
            // dvgItensSelecionados
            // 
            this.dvgItensSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgItensSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgItensSelecionados.Location = new System.Drawing.Point(5, 5);
            this.dvgItensSelecionados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgItensSelecionados.Name = "dvgItensSelecionados";
            this.dvgItensSelecionados.RowHeadersWidth = 62;
            this.dvgItensSelecionados.RowTemplate.Height = 28;
            this.dvgItensSelecionados.Size = new System.Drawing.Size(1010, 431);
            this.dvgItensSelecionados.TabIndex = 0;
            this.dvgItensSelecionados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgItensSelecionados_CellClick);
            this.dvgItensSelecionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgItensSelecionados_CellDoubleClick);
            // 
            // cbFiltroSaldo
            // 
            this.cbFiltroSaldo.FormattingEnabled = true;
            this.cbFiltroSaldo.Location = new System.Drawing.Point(9, 37);
            this.cbFiltroSaldo.Name = "cbFiltroSaldo";
            this.cbFiltroSaldo.Size = new System.Drawing.Size(102, 24);
            this.cbFiltroSaldo.TabIndex = 4;
            this.cbFiltroSaldo.SelectedIndexChanged += new System.EventHandler(this.cbFiltroSaldo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.lbFiltroSaldo);
            this.groupBox1.Controls.Add(this.cbFiltroSaldo);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Prioritário";
            // 
            // lbFiltroSaldo
            // 
            this.lbFiltroSaldo.AutoSize = true;
            this.lbFiltroSaldo.Location = new System.Drawing.Point(6, 18);
            this.lbFiltroSaldo.Name = "lbFiltroSaldo";
            this.lbFiltroSaldo.Size = new System.Drawing.Size(36, 16);
            this.lbFiltroSaldo.TabIndex = 5;
            this.lbFiltroSaldo.Text = "Filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(9, 86);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(102, 22);
            this.txtFiltro.TabIndex = 6;
            // 
            // ConsultaSaldoNotasFiscais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 693);
            this.Controls.Add(this.tabNavegacaoAba);
            this.Controls.Add(this.btGerarNotaFiscal);
            this.Controls.Add(this.gbFiltro);
            this.Name = "ConsultaSaldoNotasFiscais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Saldo Notas Fiscais";
            this.gbFiltro.ResumeLayout(false);
            this.tabNavegacaoAba.ResumeLayout(false);
            this.tabConsultaItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsultaNotas)).EndInit();
            this.tabItensSelecionado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgItensSelecionados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}