namespace ERP_FISCAL.view.ZanupView
{
    partial class ConsultaNotaItem
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
            this.tbCnpjCpf = new System.Windows.Forms.TextBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnCriarNota = new System.Windows.Forms.Button();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dvgRetorno = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.tbIdProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRetorno)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCnpjCpf
            // 
            this.tbCnpjCpf.Location = new System.Drawing.Point(389, 64);
            this.tbCnpjCpf.Name = "tbCnpjCpf";
            this.tbCnpjCpf.Size = new System.Drawing.Size(244, 26);
            this.tbCnpjCpf.TabIndex = 2;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.tbIdProduto);
            this.gbFiltros.Controls.Add(this.dtFim);
            this.gbFiltros.Controls.Add(this.dtInicio);
            this.gbFiltros.Controls.Add(this.btnPesquisa);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.tbCnpjCpf);
            this.gbFiltros.Location = new System.Drawing.Point(17, 19);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1489, 216);
            this.gbFiltros.TabIndex = 3;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Incio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Fim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNPJ/CPF:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(1341, 144);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(110, 43);
            this.btnPesquisa.TabIndex = 6;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnCriarNota
            // 
            this.btnCriarNota.Location = new System.Drawing.Point(1379, 855);
            this.btnCriarNota.Name = "btnCriarNota";
            this.btnCriarNota.Size = new System.Drawing.Size(110, 43);
            this.btnCriarNota.TabIndex = 7;
            this.btnCriarNota.Text = "Criar nota";
            this.btnCriarNota.UseVisualStyleBackColor = true;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(55, 64);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(179, 26);
            this.dtInicio.TabIndex = 7;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(55, 141);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(179, 26);
            this.dtFim.TabIndex = 8;
            // 
            // dvgRetorno
            // 
            this.dvgRetorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRetorno.Location = new System.Drawing.Point(17, 253);
            this.dvgRetorno.Name = "dvgRetorno";
            this.dvgRetorno.RowHeadersWidth = 62;
            this.dvgRetorno.RowTemplate.Height = 28;
            this.dvgRetorno.Size = new System.Drawing.Size(1489, 578);
            this.dvgRetorno.TabIndex = 4;
            // 
            // tbIdProduto
            // 
            this.tbIdProduto.Location = new System.Drawing.Point(389, 144);
            this.tbIdProduto.Name = "tbIdProduto";
            this.tbIdProduto.Size = new System.Drawing.Size(244, 26);
            this.tbIdProduto.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID Produto";
            // 
            // ConsultaNotaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 937);
            this.Controls.Add(this.btnCriarNota);
            this.Controls.Add(this.dvgRetorno);
            this.Controls.Add(this.gbFiltros);
            this.Name = "ConsultaNotaItem";
            this.Text = "ConsultaNotaItem";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRetorno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbCnpjCpf;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgRetorno;
        private System.Windows.Forms.Button btnCriarNota;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdProduto;
    }
}