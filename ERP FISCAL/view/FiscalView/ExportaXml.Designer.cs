namespace ERP_FISCAL.view.FiscalView
{
    partial class ExportaXml
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.tbLocalExport = new System.Windows.Forms.TextBox();
            this.cbModeloDocumento = new System.Windows.Forms.ComboBox();
            this.cbTipoExportacao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Sans Serif Collection", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Location = new System.Drawing.Point(208, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(328, 110);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Exportação de XML";
            // 
            // dtInicio
            // 
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(47, 208);
            this.dtInicio.MaximumSize = new System.Drawing.Size(250, 250);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(250, 35);
            this.dtInicio.TabIndex = 3;
            // 
            // dtFim
            // 
            this.dtFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(427, 208);
            this.dtFim.MaximumSize = new System.Drawing.Size(250, 250);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(250, 35);
            this.dtFim.TabIndex = 4;
            // 
            // tbLocalExport
            // 
            this.tbLocalExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLocalExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocalExport.Location = new System.Drawing.Point(48, 342);
            this.tbLocalExport.Name = "tbLocalExport";
            this.tbLocalExport.Size = new System.Drawing.Size(629, 35);
            this.tbLocalExport.TabIndex = 5;
            // 
            // cbModeloDocumento
            // 
            this.cbModeloDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModeloDocumento.FormattingEnabled = true;
            this.cbModeloDocumento.Location = new System.Drawing.Point(47, 455);
            this.cbModeloDocumento.Name = "cbModeloDocumento";
            this.cbModeloDocumento.Size = new System.Drawing.Size(302, 37);
            this.cbModeloDocumento.TabIndex = 6;
            // 
            // cbTipoExportacao
            // 
            this.cbTipoExportacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoExportacao.FormattingEnabled = true;
            this.cbTipoExportacao.Location = new System.Drawing.Point(438, 455);
            this.cbTipoExportacao.Name = "cbTipoExportacao";
            this.cbTipoExportacao.Size = new System.Drawing.Size(232, 37);
            this.cbTipoExportacao.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data Fim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Local de Exportação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modelo do Documento (opcional):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Exportar Tudo?";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExecute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExecute.Location = new System.Drawing.Point(48, 541);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(622, 65);
            this.btnExecute.TabIndex = 13;
            this.btnExecute.Text = "Executar Exportação";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // ExportaXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 641);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoExportacao);
            this.Controls.Add(this.cbModeloDocumento);
            this.Controls.Add(this.tbLocalExport);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExportaXml";
            this.Text = "ExportaXml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.TextBox tbLocalExport;
        private System.Windows.Forms.ComboBox cbModeloDocumento;
        private System.Windows.Forms.ComboBox cbTipoExportacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExecute;
    }
}