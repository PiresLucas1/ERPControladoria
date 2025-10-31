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
            this.txtBoxIDProduto = new System.Windows.Forms.TextBox();
            this.lbIDProduto = new System.Windows.Forms.Label();
            this.btGerarNotaFiscal = new System.Windows.Forms.Button();
            this.tabNavegacaoAba = new System.Windows.Forms.TabControl();
            this.tabConsultaItens = new System.Windows.Forms.TabPage();
            this.dvgConsultaNotas = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.tabItensSelecionado = new System.Windows.Forms.TabPage();
            this.dvgItensSelecionados = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.gbFiltro.SuspendLayout();
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
            this.gbFiltro.Controls.Add(this.btnRelacionaItens);
            this.gbFiltro.Controls.Add(this.btnListaNotas);
            this.gbFiltro.Controls.Add(this.txtBoxIDProduto);
            this.gbFiltro.Controls.Add(this.lbIDProduto);
            this.gbFiltro.Location = new System.Drawing.Point(19, 15);
            this.gbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFiltro.Size = new System.Drawing.Size(1153, 164);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            // 
            // btnRelacionaItens
            // 
            this.btnRelacionaItens.Location = new System.Drawing.Point(22, 120);
            this.btnRelacionaItens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRelacionaItens.Name = "btnRelacionaItens";
            this.btnRelacionaItens.Size = new System.Drawing.Size(156, 36);
            this.btnRelacionaItens.TabIndex = 3;
            this.btnRelacionaItens.Text = "Relacionar itens";
            this.btnRelacionaItens.UseVisualStyleBackColor = true;
            this.btnRelacionaItens.Click += new System.EventHandler(this.btnRelacionaItens_Click);
            // 
            // btnListaNotas
            // 
            this.btnListaNotas.Location = new System.Drawing.Point(203, 39);
            this.btnListaNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaNotas.Name = "btnListaNotas";
            this.btnListaNotas.Size = new System.Drawing.Size(114, 36);
            this.btnListaNotas.TabIndex = 2;
            this.btnListaNotas.Text = "Listar notas";
            this.btnListaNotas.UseVisualStyleBackColor = true;
            this.btnListaNotas.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtBoxIDProduto
            // 
            this.txtBoxIDProduto.Location = new System.Drawing.Point(22, 49);
            this.txtBoxIDProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxIDProduto.Name = "txtBoxIDProduto";
            this.txtBoxIDProduto.Size = new System.Drawing.Size(112, 26);
            this.txtBoxIDProduto.TabIndex = 1;
            // 
            // lbIDProduto
            // 
            this.lbIDProduto.AutoSize = true;
            this.lbIDProduto.Location = new System.Drawing.Point(22, 25);
            this.lbIDProduto.Name = "lbIDProduto";
            this.lbIDProduto.Size = new System.Drawing.Size(86, 20);
            this.lbIDProduto.TabIndex = 0;
            this.lbIDProduto.Text = "ID Produto";
            // 
            // btGerarNotaFiscal
            // 
            this.btGerarNotaFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarNotaFiscal.Location = new System.Drawing.Point(996, 795);
            this.btGerarNotaFiscal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btGerarNotaFiscal.Name = "btGerarNotaFiscal";
            this.btGerarNotaFiscal.Size = new System.Drawing.Size(170, 41);
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
            this.tabNavegacaoAba.Location = new System.Drawing.Point(19, 186);
            this.tabNavegacaoAba.Name = "tabNavegacaoAba";
            this.tabNavegacaoAba.SelectedIndex = 0;
            this.tabNavegacaoAba.Size = new System.Drawing.Size(1157, 584);
            this.tabNavegacaoAba.TabIndex = 4;
            this.tabNavegacaoAba.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabNavegacaoAba_Selected);
            // 
            // tabConsultaItens
            // 
            this.tabConsultaItens.Controls.Add(this.dvgConsultaNotas);
            this.tabConsultaItens.Location = new System.Drawing.Point(4, 29);
            this.tabConsultaItens.Name = "tabConsultaItens";
            this.tabConsultaItens.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaItens.Size = new System.Drawing.Size(1149, 551);
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
            this.dvgConsultaNotas.Location = new System.Drawing.Point(6, 6);
            this.dvgConsultaNotas.Name = "dvgConsultaNotas";
            this.dvgConsultaNotas.RowHeadersWidth = 62;
            this.dvgConsultaNotas.RowTemplate.Height = 28;
            this.dvgConsultaNotas.Size = new System.Drawing.Size(1137, 539);
            this.dvgConsultaNotas.TabIndex = 0;
            this.dvgConsultaNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgConsultaNotas_CellClick);
            // 
            // tabItensSelecionado
            // 
            this.tabItensSelecionado.Controls.Add(this.dvgItensSelecionados);
            this.tabItensSelecionado.Location = new System.Drawing.Point(4, 29);
            this.tabItensSelecionado.Name = "tabItensSelecionado";
            this.tabItensSelecionado.Padding = new System.Windows.Forms.Padding(3);
            this.tabItensSelecionado.Size = new System.Drawing.Size(1149, 551);
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
            this.dvgItensSelecionados.Location = new System.Drawing.Point(6, 6);
            this.dvgItensSelecionados.Name = "dvgItensSelecionados";
            this.dvgItensSelecionados.RowHeadersWidth = 62;
            this.dvgItensSelecionados.RowTemplate.Height = 28;
            this.dvgItensSelecionados.Size = new System.Drawing.Size(1136, 539);
            this.dvgItensSelecionados.TabIndex = 0;
            this.dvgItensSelecionados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgItensSelecionados_CellClick);
            this.dvgItensSelecionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgItensSelecionados_CellDoubleClick);
            // 
            // ConsultaSaldoNotasFiscais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 866);
            this.Controls.Add(this.tabNavegacaoAba);
            this.Controls.Add(this.btGerarNotaFiscal);
            this.Controls.Add(this.gbFiltro);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConsultaSaldoNotasFiscais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Saldo Notas Fiscais";
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.tabNavegacaoAba.ResumeLayout(false);
            this.tabConsultaItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsultaNotas)).EndInit();
            this.tabItensSelecionado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgItensSelecionados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label lbIDProduto;
        private System.Windows.Forms.TextBox txtBoxIDProduto;
        private System.Windows.Forms.Button btnListaNotas;
        private System.Windows.Forms.Button btGerarNotaFiscal;
        private System.Windows.Forms.TabControl tabNavegacaoAba;
        private System.Windows.Forms.TabPage tabConsultaItens;
        private System.Windows.Forms.TabPage tabItensSelecionado;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgConsultaNotas;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgItensSelecionados;
        private System.Windows.Forms.Button btnRelacionaItens;
    }
}