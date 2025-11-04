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
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSelecionado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumeroNota = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbConferida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilial = new System.Windows.Forms.TextBox();
            this.dtNotasImportadas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.chkNaoConferida = new System.Windows.Forms.CheckBox();
            this.chkSubstituir = new System.Windows.Forms.CheckBox();
            this.gbFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNotasImportadas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtPickerInicio
            // 
            this.dtPickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerInicio.Location = new System.Drawing.Point(58, 41);
            this.dtPickerInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPickerInicio.Name = "dtPickerInicio";
            this.dtPickerInicio.Size = new System.Drawing.Size(154, 22);
            this.dtPickerInicio.TabIndex = 0;
            // 
            // dtPickerFinal
            // 
            this.dtPickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFinal.Location = new System.Drawing.Point(58, 91);
            this.dtPickerFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPickerFinal.Name = "dtPickerFinal";
            this.dtPickerFinal.Size = new System.Drawing.Size(154, 22);
            this.dtPickerFinal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Fim";
            // 
            // gbFiltro
            // 
            this.gbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltro.Controls.Add(this.groupBox1);
            this.gbFiltro.Controls.Add(this.btnPesquisar);
            this.gbFiltro.Controls.Add(this.label7);
            this.gbFiltro.Controls.Add(this.cbConferida);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.txtFilial);
            this.gbFiltro.Controls.Add(this.dtPickerInicio);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.dtPickerFinal);
            this.gbFiltro.Location = new System.Drawing.Point(11, 10);
            this.gbFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFiltro.Size = new System.Drawing.Size(1067, 181);
            this.gbFiltro.TabIndex = 4;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Parâmetros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSelecionado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNumeroNota);
            this.groupBox1.Location = new System.Drawing.Point(464, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(258, 150);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // chkSelecionado
            // 
            this.chkSelecionado.AutoSize = true;
            this.chkSelecionado.Location = new System.Drawing.Point(9, 95);
            this.chkSelecionado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSelecionado.Name = "chkSelecionado";
            this.chkSelecionado.Size = new System.Drawing.Size(142, 20);
            this.chkSelecionado.TabIndex = 20;
            this.chkSelecionado.Text = "Exibir Selecionado";
            this.chkSelecionado.UseVisualStyleBackColor = true;
            this.chkSelecionado.CheckedChanged += new System.EventHandler(this.chkSelecionado_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "N° Nota";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(153, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumeroNota
            // 
            this.txtNumeroNota.Location = new System.Drawing.Point(9, 55);
            this.txtNumeroNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroNota.Name = "txtNumeroNota";
            this.txtNumeroNota.Size = new System.Drawing.Size(178, 22);
            this.txtNumeroNota.TabIndex = 17;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(904, 143);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(125, 30);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Conferida";
            // 
            // cbConferida
            // 
            this.cbConferida.FormattingEnabled = true;
            this.cbConferida.Location = new System.Drawing.Point(277, 42);
            this.cbConferida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbConferida.Name = "cbConferida";
            this.cbConferida.Size = new System.Drawing.Size(137, 24);
            this.cbConferida.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código Filial";
            // 
            // txtFilial
            // 
            this.txtFilial.Location = new System.Drawing.Point(58, 148);
            this.txtFilial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilial.Name = "txtFilial";
            this.txtFilial.Size = new System.Drawing.Size(150, 22);
            this.txtFilial.TabIndex = 5;
            // 
            // dtNotasImportadas
            // 
            this.dtNotasImportadas.AllowUserToAddRows = false;
            this.dtNotasImportadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNotasImportadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNotasImportadas.Location = new System.Drawing.Point(1, 195);
            this.dtNotasImportadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNotasImportadas.Name = "dtNotasImportadas";
            this.dtNotasImportadas.RowHeadersWidth = 62;
            this.dtNotasImportadas.RowTemplate.Height = 28;
            this.dtNotasImportadas.Size = new System.Drawing.Size(1067, 455);
            this.dtNotasImportadas.TabIndex = 5;
            this.dtNotasImportadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtNotasImportadas_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtCount);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btn);
            this.groupBox2.Controls.Add(this.chkNaoConferida);
            this.groupBox2.Controls.Add(this.chkSubstituir);
            this.groupBox2.Location = new System.Drawing.Point(11, 655);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1067, 73);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // txtCount
            // 
            this.txtCount.Enabled = false;
            this.txtCount.Location = new System.Drawing.Point(5, 38);
            this.txtCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(91, 22);
            this.txtCount.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(263, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "Selecionar tudo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.Location = new System.Drawing.Point(873, 27);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(156, 30);
            this.btn.TabIndex = 17;
            this.btn.Text = "Importar para Totvs";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // chkNaoConferida
            // 
            this.chkNaoConferida.AutoSize = true;
            this.chkNaoConferida.Location = new System.Drawing.Point(121, 40);
            this.chkNaoConferida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkNaoConferida.Name = "chkNaoConferida";
            this.chkNaoConferida.Size = new System.Drawing.Size(114, 20);
            this.chkNaoConferida.TabIndex = 16;
            this.chkNaoConferida.Text = "Não conferida";
            this.chkNaoConferida.UseVisualStyleBackColor = true;
            // 
            // chkSubstituir
            // 
            this.chkSubstituir.AutoSize = true;
            this.chkSubstituir.Location = new System.Drawing.Point(121, 20);
            this.chkSubstituir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSubstituir.Name = "chkSubstituir";
            this.chkSubstituir.Size = new System.Drawing.Size(83, 20);
            this.chkSubstituir.TabIndex = 15;
            this.chkSubstituir.Text = "Substituir";
            this.chkSubstituir.UseVisualStyleBackColor = true;
            // 
            // ExportaDadosBig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 735);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtNotasImportadas);
            this.Controls.Add(this.gbFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExportaDadosBig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exporta Dados Big";
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbFiltro;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumeroNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.CheckBox chkSelecionado;
    }
}