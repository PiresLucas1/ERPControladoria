namespace SolfarmaGp.UI.MenusUI.Contabil.ConferenciaBoleto
{
    partial class ConfereciaBoleto
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
            btnImportarArquivo = new Button();
            gpHeader = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            lbNomaArquivo = new Label();
            txtFiltroTipo = new Label();
            comboBox1 = new ComboBox();
            txtFileName = new TextBox();
            dvgRelacaoBoletos = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            tbControlBase = new TabControl();
            tbBaseImportada = new TabPage();
            tbBaseConferencia = new TabPage();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            btnConferencia = new Button();
            lbBanco = new Label();
            gpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRelacaoBoletos).BeginInit();
            tbControlBase.SuspendLayout();
            tbBaseImportada.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnImportarArquivo
            // 
            btnImportarArquivo.Location = new Point(17, 84);
            btnImportarArquivo.Name = "btnImportarArquivo";
            btnImportarArquivo.Size = new Size(189, 29);
            btnImportarArquivo.TabIndex = 0;
            btnImportarArquivo.Text = "Importar Arquivo Excel";
            btnImportarArquivo.UseVisualStyleBackColor = true;
            btnImportarArquivo.Click += btnImportarArquivo_Click;
            // 
            // gpHeader
            // 
            gpHeader.Controls.Add(lbBanco);
            gpHeader.Controls.Add(btnConferencia);
            gpHeader.Controls.Add(comboBox2);
            gpHeader.Controls.Add(groupBox1);
            gpHeader.Controls.Add(lbNomaArquivo);
            gpHeader.Controls.Add(txtFileName);
            gpHeader.Controls.Add(btnImportarArquivo);
            gpHeader.Location = new Point(12, 5);
            gpHeader.Name = "gpHeader";
            gpHeader.Size = new Size(1323, 200);
            gpHeader.TabIndex = 1;
            gpHeader.TabStop = false;
            gpHeader.Text = "Geral";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 6;
            label1.Text = "Complemento:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 5;
            // 
            // lbNomaArquivo
            // 
            lbNomaArquivo.AutoSize = true;
            lbNomaArquivo.Location = new Point(17, 23);
            lbNomaArquivo.Name = "lbNomaArquivo";
            lbNomaArquivo.Size = new Size(109, 20);
            lbNomaArquivo.TabIndex = 4;
            lbNomaArquivo.Text = "Nome Arquivo:";
            // 
            // txtFiltroTipo
            // 
            txtFiltroTipo.AutoSize = true;
            txtFiltroTipo.Location = new Point(21, 105);
            txtFiltroTipo.Name = "txtFiltroTipo";
            txtFiltroTipo.Size = new Size(106, 20);
            txtFiltroTipo.TabIndex = 3;
            txtFiltroTipo.Text = "Tipo Natureza:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 28);
            comboBox1.TabIndex = 2;
            // 
            // txtFileName
            // 
            txtFileName.Enabled = false;
            txtFileName.Location = new Point(17, 51);
            txtFileName.Name = "txtFileName";
            txtFileName.PlaceholderText = "Nome do arquivo...";
            txtFileName.Size = new Size(269, 27);
            txtFileName.TabIndex = 1;
            // 
            // dvgRelacaoBoletos
            // 
            dvgRelacaoBoletos.AllowUserToAddRows = false;
            dvgRelacaoBoletos.AllowUserToDeleteRows = false;
            dvgRelacaoBoletos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgRelacaoBoletos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgRelacaoBoletos.ColumnHeadersHeight = 29;
            dvgRelacaoBoletos.Location = new Point(13, 8);
            dvgRelacaoBoletos.Name = "dvgRelacaoBoletos";
            dvgRelacaoBoletos.RowHeadersWidth = 51;
            dvgRelacaoBoletos.Size = new Size(1289, 512);
            dvgRelacaoBoletos.TabIndex = 2;
            // 
            // tbControlBase
            // 
            tbControlBase.Controls.Add(tbBaseImportada);
            tbControlBase.Controls.Add(tbBaseConferencia);
            tbControlBase.Location = new Point(12, 211);
            tbControlBase.Name = "tbControlBase";
            tbControlBase.SelectedIndex = 0;
            tbControlBase.Size = new Size(1323, 559);
            tbControlBase.TabIndex = 3;
            // 
            // tbBaseImportada
            // 
            tbBaseImportada.Controls.Add(dvgRelacaoBoletos);
            tbBaseImportada.Location = new Point(4, 29);
            tbBaseImportada.Name = "tbBaseImportada";
            tbBaseImportada.Padding = new Padding(3);
            tbBaseImportada.Size = new Size(1315, 526);
            tbBaseImportada.TabIndex = 0;
            tbBaseImportada.Text = "Base Importada";
            tbBaseImportada.UseVisualStyleBackColor = true;
            // 
            // tbBaseConferencia
            // 
            tbBaseConferencia.Location = new Point(4, 29);
            tbBaseConferencia.Name = "tbBaseConferencia";
            tbBaseConferencia.Padding = new Padding(3);
            tbBaseConferencia.Size = new Size(1315, 526);
            tbBaseConferencia.TabIndex = 1;
            tbBaseConferencia.Text = "Base Conferencia";
            tbBaseConferencia.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtFiltroTipo);
            groupBox1.Location = new Point(368, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 171);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(22, 156);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(174, 28);
            comboBox2.TabIndex = 8;
            // 
            // btnConferencia
            // 
            btnConferencia.Location = new Point(1179, 156);
            btnConferencia.Name = "btnConferencia";
            btnConferencia.Size = new Size(138, 29);
            btnConferencia.TabIndex = 9;
            btnConferencia.Text = "Conferir";
            btnConferencia.UseVisualStyleBackColor = true;
            // 
            // lbBanco
            // 
            lbBanco.AutoSize = true;
            lbBanco.Location = new Point(22, 133);
            lbBanco.Name = "lbBanco";
            lbBanco.Size = new Size(134, 20);
            lbBanco.TabIndex = 10;
            lbBanco.Text = "Selecione o Banco:";
            // 
            // ConfereciaBoleto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 838);
            Controls.Add(tbControlBase);
            Controls.Add(gpHeader);
            Name = "ConfereciaBoleto";
            Text = "ConfereciaBoleto";
            gpHeader.ResumeLayout(false);
            gpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRelacaoBoletos).EndInit();
            tbControlBase.ResumeLayout(false);
            tbBaseImportada.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImportarArquivo;
        private GroupBox gpHeader;
        private ComponentesTelaUI.DataGridView.MyDataGridView dvgRelacaoBoletos;
        private TextBox txtFileName;
        private Label txtFiltroTipo;
        private ComboBox comboBox1;
        private TabControl tbControlBase;
        private TabPage tbBaseImportada;
        private TabPage tbBaseConferencia;
        private Label lbNomaArquivo;
        private Label label1;
        private TextBox textBox1;
        private Button btnConferencia;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private Label lbBanco;
    }
}