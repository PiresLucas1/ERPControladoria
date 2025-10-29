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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxIDProduto = new System.Windows.Forms.TextBox();
            this.lbIDProduto = new System.Windows.Forms.Label();
            this.dtConsultaNotas = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.btGerarNotaFiscal = new System.Windows.Forms.Button();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultaNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltro.Controls.Add(this.btGerarNotaFiscal);
            this.gbFiltro.Controls.Add(this.button1);
            this.gbFiltro.Controls.Add(this.txtBoxIDProduto);
            this.gbFiltro.Controls.Add(this.lbIDProduto);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(776, 102);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listar notas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtBoxIDProduto
            // 
            this.txtBoxIDProduto.Location = new System.Drawing.Point(6, 50);
            this.txtBoxIDProduto.Name = "txtBoxIDProduto";
            this.txtBoxIDProduto.Size = new System.Drawing.Size(100, 22);
            this.txtBoxIDProduto.TabIndex = 1;
            // 
            // lbIDProduto
            // 
            this.lbIDProduto.AutoSize = true;
            this.lbIDProduto.Location = new System.Drawing.Point(6, 31);
            this.lbIDProduto.Name = "lbIDProduto";
            this.lbIDProduto.Size = new System.Drawing.Size(70, 16);
            this.lbIDProduto.TabIndex = 0;
            this.lbIDProduto.Text = "ID Produto";
            // 
            // dtConsultaNotas
            // 
            this.dtConsultaNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtConsultaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConsultaNotas.Location = new System.Drawing.Point(12, 145);
            this.dtConsultaNotas.Name = "dtConsultaNotas";
            this.dtConsultaNotas.RowHeadersWidth = 51;
            this.dtConsultaNotas.RowTemplate.Height = 24;
            this.dtConsultaNotas.Size = new System.Drawing.Size(776, 307);
            this.dtConsultaNotas.TabIndex = 1;
            // 
            // btGerarNotaFiscal
            // 
            this.btGerarNotaFiscal.Location = new System.Drawing.Point(377, 37);
            this.btGerarNotaFiscal.Name = "btGerarNotaFiscal";
            this.btGerarNotaFiscal.Size = new System.Drawing.Size(92, 48);
            this.btGerarNotaFiscal.TabIndex = 3;
            this.btGerarNotaFiscal.Text = "Gerar nota fiscal";
            this.btGerarNotaFiscal.UseVisualStyleBackColor = true;
            // 
            // ConsultaSaldoNotasFiscais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 479);
            this.Controls.Add(this.dtConsultaNotas);
            this.Controls.Add(this.gbFiltro);
            this.Name = "ConsultaSaldoNotasFiscais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Saldo Notas Fiscais";
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultaNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label lbIDProduto;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dtConsultaNotas;
        private System.Windows.Forms.TextBox txtBoxIDProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btGerarNotaFiscal;
    }
}