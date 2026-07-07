namespace SolfarmaGp.UI.MenusUI.Fiscal.ImportaXML.WebPostoXml
{
    partial class ImportaXmlPasta
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
            richTextBox1 = new RichTextBox();
            dtInicio = new DateTimePicker();
            dtFim = new DateTimePicker();
            tbLocalExport = new TextBox();
            cbModeloDocumento = new ComboBox();
            cbTipoExportacao = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnExecute = new Button();
            tbCnpj = new TextBox();
            lbCnpj = new Label();
            chkBoxTipoImportacao = new CheckBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = SystemColors.InfoText;
            richTextBox1.Location = new Point(185, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(340, 103);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Exportação de XML";
            // 
            // dtInicio
            // 
            dtInicio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(41, 177);
            dtInicio.MaximumSize = new Size(223, 250);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(223, 30);
            dtInicio.TabIndex = 3;
            // 
            // dtFim
            // 
            dtFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtFim.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(380, 177);
            dtFim.MaximumSize = new Size(223, 250);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(223, 30);
            dtFim.TabIndex = 4;
            // 
            // tbLocalExport
            // 
            tbLocalExport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbLocalExport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLocalExport.Location = new Point(37, 275);
            tbLocalExport.Name = "tbLocalExport";
            tbLocalExport.Size = new Size(560, 30);
            tbLocalExport.TabIndex = 5;
            // 
            // cbModeloDocumento
            // 
            cbModeloDocumento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbModeloDocumento.FormattingEnabled = true;
            cbModeloDocumento.Location = new Point(34, 362);
            cbModeloDocumento.Name = "cbModeloDocumento";
            cbModeloDocumento.Size = new Size(269, 33);
            cbModeloDocumento.TabIndex = 6;
            // 
            // cbTipoExportacao
            // 
            cbTipoExportacao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTipoExportacao.FormattingEnabled = true;
            cbTipoExportacao.Location = new Point(389, 362);
            cbTipoExportacao.Name = "cbTipoExportacao";
            cbTipoExportacao.Size = new Size(207, 33);
            cbTipoExportacao.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 138);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 8;
            label1.Text = "Data Início:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(369, 137);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 9;
            label2.Text = "Data Fim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 242);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 10;
            label3.Text = "Local de Exportação:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 322);
            label4.Name = "label4";
            label4.Size = new Size(261, 20);
            label4.TabIndex = 11;
            label4.Text = "Modelo do Documento (opcional):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(385, 322);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 12;
            label5.Text = "Exportar Tudo?";
            // 
            // btnExecute
            // 
            btnExecute.BackColor = SystemColors.Highlight;
            btnExecute.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExecute.ForeColor = SystemColors.ControlLightLight;
            btnExecute.Location = new Point(37, 589);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(553, 65);
            btnExecute.TabIndex = 13;
            btnExecute.Text = "Executar Exportação";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            // 
            // tbCnpj
            // 
            tbCnpj.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbCnpj.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCnpj.Location = new Point(37, 510);
            tbCnpj.Name = "tbCnpj";
            tbCnpj.Size = new Size(269, 30);
            tbCnpj.TabIndex = 14;
            tbCnpj.TextChanged += tbCnpj_TextChanged;
            // 
            // lbCnpj
            // 
            lbCnpj.AutoSize = true;
            lbCnpj.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCnpj.Location = new Point(37, 471);
            lbCnpj.Name = "lbCnpj";
            lbCnpj.Size = new Size(58, 20);
            lbCnpj.TabIndex = 15;
            lbCnpj.Text = "CNPJ:";
            // 
            // chkBoxTipoImportacao
            // 
            chkBoxTipoImportacao.AutoSize = true;
            chkBoxTipoImportacao.Location = new Point(37, 434);
            chkBoxTipoImportacao.Name = "chkBoxTipoImportacao";
            chkBoxTipoImportacao.Size = new Size(218, 24);
            chkBoxTipoImportacao.TabIndex = 16;
            chkBoxTipoImportacao.Text = "Importa por CNPJ Especifico";
            chkBoxTipoImportacao.UseVisualStyleBackColor = true;
            chkBoxTipoImportacao.CheckedChanged += chkBoxTipoImportacao_CheckedChanged;
            // 
            // ImportaXmlPasta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 696);
            Controls.Add(chkBoxTipoImportacao);
            Controls.Add(lbCnpj);
            Controls.Add(tbCnpj);
            Controls.Add(btnExecute);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbTipoExportacao);
            Controls.Add(cbModeloDocumento);
            Controls.Add(tbLocalExport);
            Controls.Add(dtFim);
            Controls.Add(dtInicio);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImportaXmlPasta";
            Text = "ExportaXml";
            ResumeLayout(false);
            PerformLayout();

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
        private TextBox tbCnpj;
        private Label lbCnpj;
        private CheckBox chkBoxTipoImportacao;
    }
}