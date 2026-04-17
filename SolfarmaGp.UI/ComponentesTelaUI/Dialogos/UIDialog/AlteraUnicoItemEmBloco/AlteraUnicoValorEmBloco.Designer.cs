namespace SolfarmaGp.UI.ComponentesTelaUI.Dialogos.UIDialog.AlteraUnicoItemEmBloco
{
    partial class AlteraUnicoValorEmBloco
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
            lbValor = new Label();
            txtValor = new TextBox();
            button1 = new Button();
            button2 = new Button();
            cbValue = new ComboBox();
            SuspendLayout();
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(38, 45);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(97, 20);
            lbValor.TabIndex = 1;
            lbValor.Text = "Insira o valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(42, 78);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(247, 27);
            txtValor.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(210, 167);
            button1.Name = "button1";
            button1.Size = new Size(78, 32);
            button1.TabIndex = 3;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(116, 167);
            button2.Name = "button2";
            button2.Size = new Size(76, 32);
            button2.TabIndex = 4;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbValue
            // 
            cbValue.FormattingEnabled = true;
            cbValue.Location = new Point(42, 88);
            cbValue.Name = "cbValue";
            cbValue.Size = new Size(247, 28);
            cbValue.TabIndex = 5;
            // 
            // AlteraUnicoValorEmBloco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 211);
            Controls.Add(cbValue);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtValor);
            Controls.Add(lbValor);
            Name = "AlteraUnicoValorEmBloco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ComboBox cbValue;
    }
}