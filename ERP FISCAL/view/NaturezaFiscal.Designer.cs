namespace ERP_FISCAL.view
{
    partial class NaturezaFiscal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNatureza = new System.Windows.Forms.Label();
            this.txtIdNatureza = new System.Windows.Forms.Label();
            this.txtColigada = new System.Windows.Forms.Label();
            this.txtIdColigada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboBoxNatureza = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxColigada = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNatureza);
            this.groupBox1.Controls.Add(this.txtIdNatureza);
            this.groupBox1.Controls.Add(this.txtColigada);
            this.groupBox1.Controls.Add(this.txtIdColigada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(536, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // txtNatureza
            // 
            this.txtNatureza.AutoSize = true;
            this.txtNatureza.Location = new System.Drawing.Point(20, 189);
            this.txtNatureza.Name = "txtNatureza";
            this.txtNatureza.Size = new System.Drawing.Size(88, 16);
            this.txtNatureza.TabIndex = 7;
            this.txtNatureza.Text = "naturezadesc";
            this.txtNatureza.Visible = false;
            // 
            // txtIdNatureza
            // 
            this.txtIdNatureza.AutoSize = true;
            this.txtIdNatureza.Location = new System.Drawing.Point(20, 146);
            this.txtIdNatureza.Name = "txtIdNatureza";
            this.txtIdNatureza.Size = new System.Drawing.Size(74, 16);
            this.txtIdNatureza.TabIndex = 6;
            this.txtIdNatureza.Text = "ID natureza";
            this.txtIdNatureza.Visible = false;
            // 
            // txtColigada
            // 
            this.txtColigada.AutoSize = true;
            this.txtColigada.Location = new System.Drawing.Point(20, 93);
            this.txtColigada.Name = "txtColigada";
            this.txtColigada.Size = new System.Drawing.Size(97, 16);
            this.txtColigada.TabIndex = 5;
            this.txtColigada.Text = "nome coligada";
            this.txtColigada.Visible = false;
            // 
            // txtIdColigada
            // 
            this.txtIdColigada.AutoSize = true;
            this.txtIdColigada.Location = new System.Drawing.Point(20, 49);
            this.txtIdColigada.Name = "txtIdColigada";
            this.txtIdColigada.Size = new System.Drawing.Size(78, 16);
            this.txtIdColigada.TabIndex = 4;
            this.txtIdColigada.Text = "ID Coligada";
            this.txtIdColigada.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Natureza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Natureza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Coligada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Coligada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(318, 389);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboBoxNatureza
            // 
            this.comboBoxNatureza.Enabled = false;
            this.comboBoxNatureza.FormattingEnabled = true;
            this.comboBoxNatureza.Location = new System.Drawing.Point(29, 110);
            this.comboBoxNatureza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNatureza.Name = "comboBoxNatureza";
            this.comboBoxNatureza.Size = new System.Drawing.Size(536, 24);
            this.comboBoxNatureza.TabIndex = 7;
            this.comboBoxNatureza.SelectedIndexChanged += new System.EventHandler(this.comboBoxNatureza_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pesquise a natureza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Informe a coligada";
            // 
            // comboBoxColigada
            // 
            this.comboBoxColigada.FormattingEnabled = true;
            this.comboBoxColigada.Location = new System.Drawing.Point(29, 54);
            this.comboBoxColigada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxColigada.Name = "comboBoxColigada";
            this.comboBoxColigada.Size = new System.Drawing.Size(536, 24);
            this.comboBoxColigada.TabIndex = 9;

            // 
            // SelecionarCfop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 452);
            this.Controls.Add(this.comboBoxColigada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxNatureza);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelecionarCfop";
            this.Text = "Natureza Fiscal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboBoxNatureza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxColigada;
        private System.Windows.Forms.Label txtNatureza;
        private System.Windows.Forms.Label txtIdNatureza;
        private System.Windows.Forms.Label txtColigada;
        private System.Windows.Forms.Label txtIdColigada;
    }
}