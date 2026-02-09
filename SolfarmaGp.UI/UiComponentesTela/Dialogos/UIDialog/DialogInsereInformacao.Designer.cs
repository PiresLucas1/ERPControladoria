namespace ERP_FISCAL.view.DialogUI
{
    partial class InsercaoBloco
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
            this.cProdutoText = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cProdutoCbox = new System.Windows.Forms.CheckBox();
            this.dataLancamentoCbox = new System.Windows.Forms.CheckBox();
            this.cfopCbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cfopText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataLancamentoText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cProdutoText
            // 
            this.cProdutoText.Location = new System.Drawing.Point(17, 222);
            this.cProdutoText.Name = "cProdutoText";
            this.cProdutoText.Size = new System.Drawing.Size(235, 26);
            this.cProdutoText.TabIndex = 0;
            // 
            // textTitulo
            // 
            this.textTitulo.AutoSize = true;
            this.textTitulo.Location = new System.Drawing.Point(15, 189);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(210, 30);
            this.textTitulo.TabIndex = 1;
            this.textTitulo.Text = "Cód. Serviço Totvs";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(348, 526);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 31);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(229, 526);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cProdutoCbox
            // 
            this.cProdutoCbox.AutoSize = true;
            this.cProdutoCbox.Location = new System.Drawing.Point(20, 40);
            this.cProdutoCbox.Name = "cProdutoCbox";
            this.cProdutoCbox.Size = new System.Drawing.Size(180, 24);
            this.cProdutoCbox.TabIndex = 4;
            this.cProdutoCbox.Text = "Cód. Serviço TOTVS";
            this.cProdutoCbox.UseVisualStyleBackColor = true;
            this.cProdutoCbox.CheckedChanged += new System.EventHandler(this.cProdutoCbox_CheckedChanged);
            // 
            // dataLancamentoCbox
            // 
            this.dataLancamentoCbox.AutoSize = true;
            this.dataLancamentoCbox.Location = new System.Drawing.Point(270, 40);
            this.dataLancamentoCbox.Name = "dataLancamentoCbox";
            this.dataLancamentoCbox.Size = new System.Drawing.Size(163, 24);
            this.dataLancamentoCbox.TabIndex = 5;
            this.dataLancamentoCbox.Text = "Data Lançamento";
            this.dataLancamentoCbox.UseVisualStyleBackColor = true;
            this.dataLancamentoCbox.CheckedChanged += new System.EventHandler(this.dataLancamentoCbox_CheckedChanged);
            // 
            // cfopCbox
            // 
            this.cfopCbox.AutoSize = true;
            this.cfopCbox.Location = new System.Drawing.Point(20, 88);
            this.cfopCbox.Name = "cfopCbox";
            this.cfopCbox.Size = new System.Drawing.Size(78, 24);
            this.cfopCbox.TabIndex = 6;
            this.cfopCbox.Text = "CFOP";
            this.cfopCbox.UseVisualStyleBackColor = true;
            this.cfopCbox.CheckedChanged += new System.EventHandler(this.cfopCbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "CFOP";
            // 
            // cfopText
            // 
            this.cfopText.Location = new System.Drawing.Point(19, 304);
            this.cfopText.Name = "cfopText";
            this.cfopText.Size = new System.Drawing.Size(203, 26);
            this.cfopText.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data Lançamento";
            // 
            // dataLancamentoText
            // 
            this.dataLancamentoText.Location = new System.Drawing.Point(286, 222);
            this.dataLancamentoText.Name = "dataLancamentoText";
            this.dataLancamentoText.Size = new System.Drawing.Size(166, 26);
            this.dataLancamentoText.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cProdutoCbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cfopText);
            this.groupBox1.Controls.Add(this.cfopCbox);
            this.groupBox1.Controls.Add(this.dataLancamentoText);
            this.groupBox1.Controls.Add(this.dataLancamentoCbox);
            this.groupBox1.Controls.Add(this.textTitulo);
            this.groupBox1.Controls.Add(this.cProdutoText);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 471);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 62);
            this.label3.TabIndex = 11;
            this.label3.Text = "IMPORTANTE: As informações inseridas aqui vai alterar todas as linhas selecionada" +
    "s da tabela de visualização";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InsercaoBloco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsercaoBloco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserção em Bloco";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox cProdutoText;
        private System.Windows.Forms.Label textTitulo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.CheckBox cProdutoCbox;
        public System.Windows.Forms.CheckBox dataLancamentoCbox;
        public System.Windows.Forms.CheckBox cfopCbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cfopText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataLancamentoText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}