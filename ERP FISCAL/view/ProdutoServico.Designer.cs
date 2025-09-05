namespace ERP_FISCAL.view.UIComponentes
{
    partial class ProdutoServico
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescricaoNatureza = new System.Windows.Forms.TextBox();
            this.tbCodNatureza = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbCodigoProduto = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
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
            this.groupBox1.Location = new System.Drawing.Point(32, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tbDescricaoNatureza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescricaoNatureza.Name = "tbDescricaoNatureza";
            this.tbDescricaoNatureza.Size = new System.Drawing.Size(374, 26);
            this.tbDescricaoNatureza.TabIndex = 1;
            // 
            // tbCodNatureza
            // 
            this.tbCodNatureza.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbCodNatureza.Location = new System.Drawing.Point(34, 89);
            this.tbCodNatureza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodNatureza.Name = "tbCodNatureza";
            this.tbCodNatureza.Size = new System.Drawing.Size(368, 26);
            this.tbCodNatureza.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(376, 441);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(119, 42);
            this.btnSelecionar.TabIndex = 3;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(248, 441);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 42);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbCodigoProduto
            // 
            this.cbCodigoProduto.FormattingEnabled = true;
            this.cbCodigoProduto.Location = new System.Drawing.Point(32, 90);
            this.cbCodigoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCodigoProduto.Name = "cbCodigoProduto";
            this.cbCodigoProduto.Size = new System.Drawing.Size(464, 28);
            this.cbCodigoProduto.TabIndex = 6;
            this.cbCodigoProduto.SelectedIndexChanged += new System.EventHandler(this.cbCodigoProduto_SelectedIndexChanged);
            this.cbCodigoProduto.TextChanged += new System.EventHandler(this.cbCodigoProduto_TextChanged);
            this.cbCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCodigoProduto_KeyDown);
            // 
            // ProdutoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 518);
            this.Controls.Add(this.cbCodigoProduto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProdutoServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto ";
            this.Load += new System.EventHandler(this.SelecaoCompletaItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescricaoNatureza;
        private System.Windows.Forms.TextBox tbCodNatureza;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbCodigoProduto;
    }
}