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
            this.btGerarNotaFiscal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxIDProduto = new System.Windows.Forms.TextBox();
            this.lbIDProduto = new System.Windows.Forms.Label();
            this.dtConsultaNotas = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.btnCriaNotaFiscal = new System.Windows.Forms.Button();
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
            this.gbFiltro.Location = new System.Drawing.Point(14, 15);
            this.gbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFiltro.Size = new System.Drawing.Size(1152, 128);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            // 
            // btGerarNotaFiscal
            // 
            this.btGerarNotaFiscal.Location = new System.Drawing.Point(424, 46);
            this.btGerarNotaFiscal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btGerarNotaFiscal.Name = "btGerarNotaFiscal";
            this.btGerarNotaFiscal.Size = new System.Drawing.Size(104, 60);
            this.btGerarNotaFiscal.TabIndex = 3;
            this.btGerarNotaFiscal.Text = "Gerar nota fiscal";
            this.btGerarNotaFiscal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listar notas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtBoxIDProduto
            // 
            this.txtBoxIDProduto.Location = new System.Drawing.Point(7, 62);
            this.txtBoxIDProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxIDProduto.Name = "txtBoxIDProduto";
            this.txtBoxIDProduto.Size = new System.Drawing.Size(112, 26);
            this.txtBoxIDProduto.TabIndex = 1;
            // 
            // lbIDProduto
            // 
            this.lbIDProduto.AutoSize = true;
            this.lbIDProduto.Location = new System.Drawing.Point(7, 39);
            this.lbIDProduto.Name = "lbIDProduto";
            this.lbIDProduto.Size = new System.Drawing.Size(86, 20);
            this.lbIDProduto.TabIndex = 0;
            this.lbIDProduto.Text = "ID Produto";
            // 
            // dtConsultaNotas
            // 
            this.dtConsultaNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtConsultaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConsultaNotas.Location = new System.Drawing.Point(19, 162);
            this.dtConsultaNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtConsultaNotas.Name = "dtConsultaNotas";
            this.dtConsultaNotas.RowHeadersWidth = 51;
            this.dtConsultaNotas.RowTemplate.Height = 24;
            this.dtConsultaNotas.Size = new System.Drawing.Size(1152, 540);
            this.dtConsultaNotas.TabIndex = 1;
            this.dtConsultaNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtConsultaNotas_CellClick);
            this.dtConsultaNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtConsultaNotas_CellContentClick);
            // 
            // btnCriaNotaFiscal
            // 
            this.btnCriaNotaFiscal.Location = new System.Drawing.Point(997, 721);
            this.btnCriaNotaFiscal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCriaNotaFiscal.Name = "btnCriaNotaFiscal";
            this.btnCriaNotaFiscal.Size = new System.Drawing.Size(169, 39);
            this.btnCriaNotaFiscal.TabIndex = 3;
            this.btnCriaNotaFiscal.Text = "Criar Nota Fiscal";
            this.btnCriaNotaFiscal.UseVisualStyleBackColor = true;
            this.btnCriaNotaFiscal.Click += new System.EventHandler(this.btnCriaNotaFiscal_Click);
            // 
            // ConsultaSaldoNotasFiscais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 773);
            this.Controls.Add(this.btnCriaNotaFiscal);
            this.Controls.Add(this.dtConsultaNotas);
            this.Controls.Add(this.gbFiltro);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btnCriaNotaFiscal;
    }
}