namespace ERP_FISCAL.view
{
    partial class ExportaDadosBig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportaDadosBig));
            this.dtPickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbConferida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilial = new System.Windows.Forms.TextBox();
            this.dtNotasImportadas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn = new System.Windows.Forms.Button();
            this.chkNaoConferida = new System.Windows.Forms.CheckBox();
            this.chkSubstituir = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNotasImportadas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtPickerInicio
            // 
            this.dtPickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerInicio.Location = new System.Drawing.Point(65, 51);
            this.dtPickerInicio.Name = "dtPickerInicio";
            this.dtPickerInicio.Size = new System.Drawing.Size(173, 26);
            this.dtPickerInicio.TabIndex = 0;
            // 
            // dtPickerFinal
            // 
            this.dtPickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFinal.Location = new System.Drawing.Point(65, 114);
            this.dtPickerFinal.Name = "dtPickerFinal";
            this.dtPickerFinal.Size = new System.Drawing.Size(173, 26);
            this.dtPickerFinal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Fim";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbConferida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFilial);
            this.groupBox1.Controls.Add(this.dtPickerInicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtPickerFinal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(1017, 179);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(141, 38);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Conferida";
            // 
            // cbConferida
            // 
            this.cbConferida.FormattingEnabled = true;
            this.cbConferida.Location = new System.Drawing.Point(312, 53);
            this.cbConferida.Name = "cbConferida";
            this.cbConferida.Size = new System.Drawing.Size(154, 28);
            this.cbConferida.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código Filial";
            // 
            // txtFilial
            // 
            this.txtFilial.Location = new System.Drawing.Point(65, 185);
            this.txtFilial.Name = "txtFilial";
            this.txtFilial.Size = new System.Drawing.Size(168, 26);
            this.txtFilial.TabIndex = 5;
            // 
            // dtNotasImportadas
            // 
            this.dtNotasImportadas.AllowUserToAddRows = false;
            this.dtNotasImportadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNotasImportadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNotasImportadas.Location = new System.Drawing.Point(12, 244);
            this.dtNotasImportadas.Name = "dtNotasImportadas";
            this.dtNotasImportadas.RowHeadersWidth = 62;
            this.dtNotasImportadas.RowTemplate.Height = 28;
            this.dtNotasImportadas.Size = new System.Drawing.Size(1200, 569);
            this.dtNotasImportadas.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn);
            this.groupBox2.Controls.Add(this.chkNaoConferida);
            this.groupBox2.Controls.Add(this.chkSubstituir);
            this.groupBox2.Location = new System.Drawing.Point(12, 819);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1200, 91);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(982, 34);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(176, 38);
            this.btn.TabIndex = 17;
            this.btn.Text = "Importar para Totvs";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // chkNaoConferida
            // 
            this.chkNaoConferida.AutoSize = true;
            this.chkNaoConferida.Location = new System.Drawing.Point(18, 55);
            this.chkNaoConferida.Name = "chkNaoConferida";
            this.chkNaoConferida.Size = new System.Drawing.Size(134, 24);
            this.chkNaoConferida.TabIndex = 16;
            this.chkNaoConferida.Text = "Não conferida";
            this.chkNaoConferida.UseVisualStyleBackColor = true;
            // 
            // chkSubstituir
            // 
            this.chkSubstituir.AutoSize = true;
            this.chkSubstituir.Location = new System.Drawing.Point(18, 23);
            this.chkSubstituir.Name = "chkSubstituir";
            this.chkSubstituir.Size = new System.Drawing.Size(102, 24);
            this.chkSubstituir.TabIndex = 15;
            this.chkSubstituir.Text = "Substituir";
            this.chkSubstituir.UseVisualStyleBackColor = true;
            // 
            // ExportaDadosBig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 919);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtNotasImportadas);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportaDadosBig";
            this.Text = "Exporta Dados Big";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNotasImportadas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerInicio;
        private System.Windows.Forms.DateTimePicker dtPickerFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilial;
        private System.Windows.Forms.DataGridView dtNotasImportadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbConferida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox chkNaoConferida;
        private System.Windows.Forms.CheckBox chkSubstituir;
        private System.Windows.Forms.Button btn;
    }
}