namespace ERP_FISCAL.view
{
    partial class AlteraTipoMovimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteraTipoMovimento));
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lbConsultaMovimento = new System.Windows.Forms.Label();
            this.tbCodMovimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodTmv = new System.Windows.Forms.TextBox();
            this.tbColigada = new System.Windows.Forms.TextBox();
            this.dtAlteracoes = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gbBottom = new System.Windows.Forms.GroupBox();
            this.gbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlteracoes)).BeginInit();
            this.gbBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHeader
            // 
            this.gbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHeader.Controls.Add(this.btnConsulta);
            this.gbHeader.Controls.Add(this.lbConsultaMovimento);
            this.gbHeader.Controls.Add(this.tbCodMovimento);
            this.gbHeader.Controls.Add(this.label2);
            this.gbHeader.Controls.Add(this.label1);
            this.gbHeader.Controls.Add(this.tbCodTmv);
            this.gbHeader.Controls.Add(this.tbColigada);
            this.gbHeader.Location = new System.Drawing.Point(12, 3);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(1103, 219);
            this.gbHeader.TabIndex = 0;
            this.gbHeader.TabStop = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(261, 125);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(141, 39);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lbConsultaMovimento
            // 
            this.lbConsultaMovimento.AutoSize = true;
            this.lbConsultaMovimento.Location = new System.Drawing.Point(17, 31);
            this.lbConsultaMovimento.Name = "lbConsultaMovimento";
            this.lbConsultaMovimento.Size = new System.Drawing.Size(162, 20);
            this.lbConsultaMovimento.TabIndex = 7;
            this.lbConsultaMovimento.Text = "Código de Movimento";
            // 
            // tbCodMovimento
            // 
            this.tbCodMovimento.Location = new System.Drawing.Point(21, 55);
            this.tbCodMovimento.Name = "tbCodMovimento";
            this.tbCodMovimento.Size = new System.Drawing.Size(174, 26);
            this.tbCodMovimento.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código TMV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coligada";
            // 
            // tbCodTmv
            // 
            this.tbCodTmv.Location = new System.Drawing.Point(486, 55);
            this.tbCodTmv.Name = "tbCodTmv";
            this.tbCodTmv.Size = new System.Drawing.Size(174, 26);
            this.tbCodTmv.TabIndex = 2;
            // 
            // tbColigada
            // 
            this.tbColigada.Location = new System.Drawing.Point(21, 138);
            this.tbColigada.Name = "tbColigada";
            this.tbColigada.Size = new System.Drawing.Size(174, 26);
            this.tbColigada.TabIndex = 1;
            // 
            // dtAlteracoes
            // 
            this.dtAlteracoes.AllowUserToAddRows = false;
            this.dtAlteracoes.AllowUserToDeleteRows = false;
            this.dtAlteracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAlteracoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlteracoes.Location = new System.Drawing.Point(12, 247);
            this.dtAlteracoes.Name = "dtAlteracoes";
            this.dtAlteracoes.RowHeadersWidth = 62;
            this.dtAlteracoes.RowTemplate.Height = 28;
            this.dtAlteracoes.Size = new System.Drawing.Size(1103, 486);
            this.dtAlteracoes.TabIndex = 1;
            this.dtAlteracoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAlteracoes_CellClick);
            this.dtAlteracoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAlteracoes_CellContentClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(949, 25);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(136, 43);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gbBottom
            // 
            this.gbBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBottom.Controls.Add(this.btnAlterar);
            this.gbBottom.Location = new System.Drawing.Point(12, 739);
            this.gbBottom.Name = "gbBottom";
            this.gbBottom.Size = new System.Drawing.Size(1103, 79);
            this.gbBottom.TabIndex = 10;
            this.gbBottom.TabStop = false;
            // 
            // AlteraTipoMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 830);
            this.Controls.Add(this.gbBottom);
            this.Controls.Add(this.dtAlteracoes);
            this.Controls.Add(this.gbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlteraTipoMovimento";
            this.Text = "AlteraTipoMovimento";
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlteracoes)).EndInit();
            this.gbBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.DataGridView dtAlteracoes;
        private System.Windows.Forms.Label lbConsultaMovimento;
        private System.Windows.Forms.TextBox tbCodMovimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodTmv;
        private System.Windows.Forms.TextBox tbColigada;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gbBottom;
    }
}