namespace ERP_FISCAL.view.FiscalView
{
    partial class VisuExportacaoXml
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
            this.rtBoxResultado = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtBoxResultado
            // 
            this.rtBoxResultado.BackColor = System.Drawing.SystemColors.Info;
            this.rtBoxResultado.Location = new System.Drawing.Point(14, 63);
            this.rtBoxResultado.Name = "rtBoxResultado";
            this.rtBoxResultado.Size = new System.Drawing.Size(643, 125);
            this.rtBoxResultado.TabIndex = 0;
            this.rtBoxResultado.Text = "";
            this.rtBoxResultado.TextChanged += new System.EventHandler(this.rtBoxResultado_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 197);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(643, 48);
            this.progressBar1.TabIndex = 1;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(59, 20);
            this.header.TabIndex = 2;
            this.header.Text = "header";
            // 
            // VisuExportacaoXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(669, 257);
            this.Controls.Add(this.header);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rtBoxResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisuExportacaoXml";
            this.Text = "VisuExportacaoXml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBoxResultado;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label header;
    }
}