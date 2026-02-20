namespace SolfarmaGp.UI.MenusUI.Fiscal.AlteracoesFiscais.AlteracaoUnica
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
            gbHeader = new GroupBox();
            btnAlterarEmBloco = new Button();
            chkAlteraEmBloco = new CheckBox();
            btnConsulta = new Button();
            lbConsultaMovimento = new Label();
            tbCodMovimento = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbCodTmv = new TextBox();
            tbColigada = new TextBox();
            dtAlteracoes = new DataGridView();
            btnAlterar = new Button();
            gbBottom = new GroupBox();
            txtCount = new TextBox();
            gbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtAlteracoes).BeginInit();
            gbBottom.SuspendLayout();
            SuspendLayout();
            // 
            // gbHeader
            // 
            gbHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbHeader.Controls.Add(btnAlterarEmBloco);
            gbHeader.Controls.Add(chkAlteraEmBloco);
            gbHeader.Controls.Add(btnConsulta);
            gbHeader.Controls.Add(lbConsultaMovimento);
            gbHeader.Controls.Add(tbCodMovimento);
            gbHeader.Controls.Add(label2);
            gbHeader.Controls.Add(label1);
            gbHeader.Controls.Add(tbCodTmv);
            gbHeader.Controls.Add(tbColigada);
            gbHeader.Location = new Point(11, 3);
            gbHeader.Name = "gbHeader";
            gbHeader.Size = new Size(980, 219);
            gbHeader.TabIndex = 0;
            gbHeader.TabStop = false;
            // 
            // btnAlterarEmBloco
            // 
            btnAlterarEmBloco.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlterarEmBloco.Location = new Point(792, 161);
            btnAlterarEmBloco.Name = "btnAlterarEmBloco";
            btnAlterarEmBloco.Size = new Size(173, 43);
            btnAlterarEmBloco.TabIndex = 10;
            btnAlterarEmBloco.Text = "Alterar em bloco";
            btnAlterarEmBloco.UseVisualStyleBackColor = true;
            btnAlterarEmBloco.Visible = false;
            btnAlterarEmBloco.Click += btnAlterarEmBloco_Click;
            // 
            // chkAlteraEmBloco
            // 
            chkAlteraEmBloco.AutoSize = true;
            chkAlteraEmBloco.Location = new Point(232, 55);
            chkAlteraEmBloco.Name = "chkAlteraEmBloco";
            chkAlteraEmBloco.Size = new Size(143, 24);
            chkAlteraEmBloco.TabIndex = 9;
            chkAlteraEmBloco.Text = "Alterar em Bloco";
            chkAlteraEmBloco.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(232, 125);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(125, 39);
            btnConsulta.TabIndex = 8;
            btnConsulta.Text = "Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // lbConsultaMovimento
            // 
            lbConsultaMovimento.AutoSize = true;
            lbConsultaMovimento.Location = new Point(15, 31);
            lbConsultaMovimento.Name = "lbConsultaMovimento";
            lbConsultaMovimento.Size = new Size(159, 20);
            lbConsultaMovimento.TabIndex = 7;
            lbConsultaMovimento.Text = "Código de Movimento";
            // 
            // tbCodMovimento
            // 
            tbCodMovimento.Location = new Point(19, 55);
            tbCodMovimento.Name = "tbCodMovimento";
            tbCodMovimento.Size = new Size(155, 27);
            tbCodMovimento.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 22);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "Código TMV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 106);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "Coligada";
            // 
            // tbCodTmv
            // 
            tbCodTmv.Location = new Point(432, 55);
            tbCodTmv.Name = "tbCodTmv";
            tbCodTmv.Size = new Size(155, 27);
            tbCodTmv.TabIndex = 2;
            // 
            // tbColigada
            // 
            tbColigada.Location = new Point(19, 138);
            tbColigada.Name = "tbColigada";
            tbColigada.Size = new Size(155, 27);
            tbColigada.TabIndex = 1;
            // 
            // dtAlteracoes
            // 
            dtAlteracoes.AllowUserToAddRows = false;
            dtAlteracoes.AllowUserToDeleteRows = false;
            dtAlteracoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtAlteracoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtAlteracoes.Location = new Point(11, 247);
            dtAlteracoes.Name = "dtAlteracoes";
            dtAlteracoes.RowHeadersWidth = 62;
            dtAlteracoes.RowTemplate.Height = 28;
            dtAlteracoes.Size = new Size(980, 486);
            dtAlteracoes.TabIndex = 1;
            dtAlteracoes.CellClick += dtAlteracoes_CellClick;
            dtAlteracoes.CellContentClick += dtAlteracoes_CellContentClick;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlterar.Location = new Point(844, 25);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(121, 43);
            btnAlterar.TabIndex = 9;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // gbBottom
            // 
            gbBottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbBottom.Controls.Add(txtCount);
            gbBottom.Controls.Add(btnAlterar);
            gbBottom.Location = new Point(11, 739);
            gbBottom.Name = "gbBottom";
            gbBottom.Size = new Size(980, 79);
            gbBottom.TabIndex = 10;
            gbBottom.TabStop = false;
            // 
            // txtCount
            // 
            txtCount.BackColor = SystemColors.ScrollBar;
            txtCount.Enabled = false;
            txtCount.Location = new Point(8, 33);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(80, 27);
            txtCount.TabIndex = 10;
            // 
            // AlteraTipoMovimento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 830);
            Controls.Add(gbBottom);
            Controls.Add(dtAlteracoes);
            Controls.Add(gbHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AlteraTipoMovimento";
            Text = "AlteraTipoMovimento";
            gbHeader.ResumeLayout(false);
            gbHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtAlteracoes).EndInit();
            gbBottom.ResumeLayout(false);
            gbBottom.PerformLayout();
            ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox chkAlteraEmBloco;
        private System.Windows.Forms.Button btnAlterarEmBloco;
        private System.Windows.Forms.TextBox txtCount;
    }
}