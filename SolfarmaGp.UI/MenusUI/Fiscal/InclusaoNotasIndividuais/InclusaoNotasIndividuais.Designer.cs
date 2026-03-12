namespace SolfarmaGp.UI.MenusUI.Fiscal.InclusaoNotasIndividuais
{
    partial class InclusaoNotasIndividuais
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
            btnAdiciona = new Button();
            lbNumdoc = new Label();
            dvgNotasIncluidas = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            lbdtInicio = new Label();
            lbDataFim = new Label();
            dtpInicio = new DateTimePicker();
            dtpFim = new DateTimePicker();
            rtbNumDocs = new RichTextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dvgNotasIncluidas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdiciona
            // 
            btnAdiciona.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdiciona.Location = new Point(632, 149);
            btnAdiciona.Name = "btnAdiciona";
            btnAdiciona.Size = new Size(128, 30);
            btnAdiciona.TabIndex = 1;
            btnAdiciona.Text = "Adicionar";
            btnAdiciona.UseVisualStyleBackColor = true;
            btnAdiciona.Click += btnAdiciona_Click;
            // 
            // lbNumdoc
            // 
            lbNumdoc.AutoSize = true;
            lbNumdoc.Location = new Point(28, 16);
            lbNumdoc.Name = "lbNumdoc";
            lbNumdoc.Size = new Size(171, 20);
            lbNumdoc.TabIndex = 2;
            lbNumdoc.Text = "Numero de documento: ";
            // 
            // dvgNotasIncluidas
            // 
            dvgNotasIncluidas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgNotasIncluidas.ColumnHeadersHeight = 29;
            dvgNotasIncluidas.Location = new Point(12, 216);
            dvgNotasIncluidas.Name = "dvgNotasIncluidas";
            dvgNotasIncluidas.RowHeadersWidth = 51;
            dvgNotasIncluidas.Size = new Size(776, 362);
            dvgNotasIncluidas.TabIndex = 3;
            // 
            // lbdtInicio
            // 
            lbdtInicio.AutoSize = true;
            lbdtInicio.Location = new Point(29, 118);
            lbdtInicio.Name = "lbdtInicio";
            lbdtInicio.Size = new Size(84, 20);
            lbdtInicio.TabIndex = 6;
            lbdtInicio.Text = "Data Inicio:";
            // 
            // lbDataFim
            // 
            lbDataFim.AutoSize = true;
            lbDataFim.Location = new Point(216, 118);
            lbDataFim.Name = "lbDataFim";
            lbDataFim.Size = new Size(72, 20);
            lbDataFim.TabIndex = 7;
            lbDataFim.Text = "Data Fim:";
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(29, 152);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(160, 27);
            dtpInicio.TabIndex = 8;
            // 
            // dtpFim
            // 
            dtpFim.Format = DateTimePickerFormat.Short;
            dtpFim.Location = new Point(216, 152);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(160, 27);
            dtpFim.TabIndex = 9;
            // 
            // rtbNumDocs
            // 
            rtbNumDocs.Location = new Point(28, 39);
            rtbNumDocs.Name = "rtbNumDocs";
            rtbNumDocs.Size = new Size(572, 70);
            rtbNumDocs.TabIndex = 10;
            rtbNumDocs.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnAdiciona);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 207);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // InclusaoNotasIndividuais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 602);
            Controls.Add(rtbNumDocs);
            Controls.Add(dtpFim);
            Controls.Add(dtpInicio);
            Controls.Add(lbDataFim);
            Controls.Add(lbdtInicio);
            Controls.Add(dvgNotasIncluidas);
            Controls.Add(lbNumdoc);
            Controls.Add(groupBox1);
            Name = "InclusaoNotasIndividuais";
            Text = "InclusaoNotasIndividuais";
            ((System.ComponentModel.ISupportInitialize)dvgNotasIncluidas).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdiciona;
        private Label lbNumdoc;
        private ComponentesTelaUI.DataGridView.MyDataGridView dvgNotasIncluidas;
        private Label lbdtInicio;
        private Label lbDataFim;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private RichTextBox rtbNumDocs;
        private GroupBox groupBox1;
    }
}