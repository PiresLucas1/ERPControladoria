namespace ERP_FISCAL.view.UIComponentes
{
    partial class SelecaoCompletaItem
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
            this.cBCodProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescricaoNatureza = new System.Windows.Forms.TextBox();
            this.tbCodNatureza = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBCodProduto
            // 
            this.cBCodProduto.FormattingEnabled = true;
            this.cBCodProduto.Location = new System.Drawing.Point(31, 114);
            this.cBCodProduto.Name = "cBCodProduto";
            this.cBCodProduto.Size = new System.Drawing.Size(464, 28);
            this.cBCodProduto.TabIndex = 0;
            this.cBCodProduto.SelectedIndexChanged += new System.EventHandler(this.cBCodProduto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o código de Produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDescricaoNatureza);
            this.groupBox1.Controls.Add(this.tbCodNatureza);
            this.groupBox1.Location = new System.Drawing.Point(31, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Natureza de Rendimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            // 
            // tbDescricaoNatureza
            // 
            this.tbDescricaoNatureza.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbDescricaoNatureza.Location = new System.Drawing.Point(28, 172);
            this.tbDescricaoNatureza.Name = "tbDescricaoNatureza";
            this.tbDescricaoNatureza.Size = new System.Drawing.Size(374, 26);
            this.tbDescricaoNatureza.TabIndex = 1;
            // 
            // tbCodNatureza
            // 
            this.tbCodNatureza.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbCodNatureza.Location = new System.Drawing.Point(34, 89);
            this.tbCodNatureza.Name = "tbCodNatureza";
            this.tbCodNatureza.Size = new System.Drawing.Size(368, 26);
            this.tbCodNatureza.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(377, 452);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(118, 31);
            this.btnSelecionar.TabIndex = 3;
            this.btnSelecionar.Text = "button1";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(240, 452);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "button2";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selecione a descrição do Produto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(464, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // SelecaoCompletaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 518);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBCodProduto);
            this.Name = "SelecaoCompletaItem";
            this.Text = "SelecaoCompletaItem";
            this.Load += new System.EventHandler(this.SelecaoCompletaItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBCodProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescricaoNatureza;
        private System.Windows.Forms.TextBox tbCodNatureza;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}