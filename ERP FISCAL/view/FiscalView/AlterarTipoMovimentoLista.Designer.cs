namespace ERP_FISCAL.view.FiscalView
{
    partial class AlterarTipoMovimentoLista
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtFiltroInput = new System.Windows.Forms.RichTextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.gpFiltro = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlteraCodMovimento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlterarSelecionados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelecionarTudo = new System.Windows.Forms.Button();
            this.txtCountRows = new System.Windows.Forms.TextBox();
            this.dvgIDMovs = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.gpFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIDMovs)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtFiltroInput
            // 
            this.txtFiltroInput.Location = new System.Drawing.Point(23, 45);
            this.txtFiltroInput.Name = "txtFiltroInput";
            this.txtFiltroInput.Size = new System.Drawing.Size(659, 94);
            this.txtFiltroInput.TabIndex = 2;
            this.txtFiltroInput.Text = "";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(27, 19);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(336, 20);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Insira os IDMOV  separado por \",\" para buscar";
            // 
            // gpFiltro
            // 
            this.gpFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpFiltro.Controls.Add(this.btnConsultar);
            this.gpFiltro.Controls.Add(this.txtFiltroInput);
            this.gpFiltro.Controls.Add(this.lblFiltro);
            this.gpFiltro.Location = new System.Drawing.Point(12, 12);
            this.gpFiltro.Name = "gpFiltro";
            this.gpFiltro.Size = new System.Drawing.Size(1521, 156);
            this.gpFiltro.TabIndex = 4;
            this.gpFiltro.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(1384, 105);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(121, 34);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlteraCodMovimento
            // 
            this.btnAlteraCodMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlteraCodMovimento.Location = new System.Drawing.Point(1312, 53);
            this.btnAlteraCodMovimento.Name = "btnAlteraCodMovimento";
            this.btnAlteraCodMovimento.Size = new System.Drawing.Size(193, 34);
            this.btnAlteraCodMovimento.TabIndex = 7;
            this.btnAlteraCodMovimento.Text = "Alterar Cód Movimento";
            this.btnAlteraCodMovimento.UseVisualStyleBackColor = true;
            this.btnAlteraCodMovimento.Click += new System.EventHandler(this.btnAlteraCodMovimento_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAlterarSelecionados);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAlteraCodMovimento);
            this.groupBox1.Controls.Add(this.btnSelecionarTudo);
            this.groupBox1.Controls.Add(this.txtCountRows);
            this.groupBox1.Location = new System.Drawing.Point(12, 805);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1521, 108);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnAlterarSelecionados
            // 
            this.btnAlterarSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlterarSelecionados.Location = new System.Drawing.Point(205, 68);
            this.btnAlterarSelecionados.Name = "btnAlterarSelecionados";
            this.btnAlterarSelecionados.Size = new System.Drawing.Size(151, 34);
            this.btnAlterarSelecionados.TabIndex = 8;
            this.btnAlterarSelecionados.Text = "Alt. Selecionados";
            this.btnAlterarSelecionados.UseVisualStyleBackColor = true;
            this.btnAlterarSelecionados.Click += new System.EventHandler(this.btnAlterarSelecionados_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(205, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpar seleção";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelecionarTudo
            // 
            this.btnSelecionarTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelecionarTudo.Location = new System.Drawing.Point(23, 25);
            this.btnSelecionarTudo.Name = "btnSelecionarTudo";
            this.btnSelecionarTudo.Size = new System.Drawing.Size(151, 34);
            this.btnSelecionarTudo.TabIndex = 9;
            this.btnSelecionarTudo.Text = "Selecionar  tudo";
            this.btnSelecionarTudo.UseVisualStyleBackColor = true;
            this.btnSelecionarTudo.Click += new System.EventHandler(this.btnSelecionarTudo_Click);
            // 
            // txtCountRows
            // 
            this.txtCountRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCountRows.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCountRows.Location = new System.Drawing.Point(23, 76);
            this.txtCountRows.Name = "txtCountRows";
            this.txtCountRows.Size = new System.Drawing.Size(151, 26);
            this.txtCountRows.TabIndex = 10;
            // 
            // dvgIDMovs
            // 
            this.dvgIDMovs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgIDMovs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgIDMovs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgIDMovs.Location = new System.Drawing.Point(12, 185);
            this.dvgIDMovs.Name = "dvgIDMovs";
            this.dvgIDMovs.RowHeadersWidth = 62;
            this.dvgIDMovs.RowTemplate.Height = 28;
            this.dvgIDMovs.Size = new System.Drawing.Size(1521, 601);
            this.dvgIDMovs.TabIndex = 5;
            // 
            // AlterarTipoMovimentoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 925);
            this.Controls.Add(this.dvgIDMovs);
            this.Controls.Add(this.gpFiltro);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlterarTipoMovimentoLista";
            this.Text = "AlterarTipoMovimentoLista";
            this.gpFiltro.ResumeLayout(false);
            this.gpFiltro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIDMovs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox txtFiltroInput;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.GroupBox gpFiltro;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgIDMovs;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlteraCodMovimento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlterarSelecionados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelecionarTudo;
        private System.Windows.Forms.TextBox txtCountRows;
    }
}