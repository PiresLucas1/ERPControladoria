namespace SolfarmaGp.UI.MenusUI.Fiscal.NovaPasta
{
    partial class ImportarNotasFiscaisXmlPataTotvs
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
            Filtros = new GroupBox();
            btnConsultar = new Button();
            lbTipoData = new Label();
            cbTipoData = new ComboBox();
            lbFim = new Label();
            lbInicio = new Label();
            dtFim = new DateTimePicker();
            dtInicio = new DateTimePicker();
            dvgNotas = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            tbRegistros = new TextBox();
            gpAcoes = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            btnCadastrarEans = new Button();
            label1 = new Label();
            tbRegistrosAtencao = new TextBox();
            button2 = new Button();
            button1 = new Button();
            lbRegistro = new Label();
            Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNotas).BeginInit();
            gpAcoes.SuspendLayout();
            SuspendLayout();
            // 
            // Filtros
            // 
            Filtros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Filtros.Controls.Add(btnConsultar);
            Filtros.Controls.Add(lbTipoData);
            Filtros.Controls.Add(cbTipoData);
            Filtros.Controls.Add(lbFim);
            Filtros.Controls.Add(lbInicio);
            Filtros.Controls.Add(dtFim);
            Filtros.Controls.Add(dtInicio);
            Filtros.Location = new Point(12, 3);
            Filtros.Name = "Filtros";
            Filtros.Size = new Size(1171, 187);
            Filtros.TabIndex = 0;
            Filtros.TabStop = false;
            Filtros.Text = "Filtros";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.Location = new Point(1042, 129);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(106, 30);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lbTipoData
            // 
            lbTipoData.AutoSize = true;
            lbTipoData.Location = new Point(21, 88);
            lbTipoData.Name = "lbTipoData";
            lbTipoData.Size = new Size(75, 20);
            lbTipoData.TabIndex = 5;
            lbTipoData.Text = "Tipo Data";
            // 
            // cbTipoData
            // 
            cbTipoData.FormattingEnabled = true;
            cbTipoData.Location = new Point(21, 111);
            cbTipoData.Name = "cbTipoData";
            cbTipoData.Size = new Size(124, 28);
            cbTipoData.TabIndex = 4;
            cbTipoData.SelectedIndexChanged += cbTipoData_SelectedIndexChanged;
            // 
            // lbFim
            // 
            lbFim.AutoSize = true;
            lbFim.Location = new Point(183, 29);
            lbFim.Name = "lbFim";
            lbFim.Size = new Size(33, 20);
            lbFim.TabIndex = 3;
            lbFim.Text = "Fim";
            // 
            // lbInicio
            // 
            lbInicio.AutoSize = true;
            lbInicio.Location = new Point(21, 29);
            lbInicio.Name = "lbInicio";
            lbInicio.Size = new Size(45, 20);
            lbInicio.TabIndex = 2;
            lbInicio.Text = "Inicio";
            // 
            // dtFim
            // 
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(183, 52);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(123, 27);
            dtFim.TabIndex = 1;
            // 
            // dtInicio
            // 
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(21, 52);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(123, 27);
            dtInicio.TabIndex = 0;
            // 
            // dvgNotas
            // 
            dvgNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgNotas.ColumnHeadersHeight = 29;
            dvgNotas.Location = new Point(12, 196);
            dvgNotas.Name = "dvgNotas";
            dvgNotas.RowHeadersWidth = 51;
            dvgNotas.Size = new Size(1171, 435);
            dvgNotas.TabIndex = 1;
            // 
            // tbRegistros
            // 
            tbRegistros.BackColor = SystemColors.MenuBar;
            tbRegistros.Location = new Point(80, 22);
            tbRegistros.Name = "tbRegistros";
            tbRegistros.Size = new Size(72, 27);
            tbRegistros.TabIndex = 2;
            // 
            // gpAcoes
            // 
            gpAcoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpAcoes.Controls.Add(button4);
            gpAcoes.Controls.Add(button3);
            gpAcoes.Controls.Add(btnCadastrarEans);
            gpAcoes.Controls.Add(label1);
            gpAcoes.Controls.Add(tbRegistrosAtencao);
            gpAcoes.Controls.Add(button2);
            gpAcoes.Controls.Add(button1);
            gpAcoes.Controls.Add(lbRegistro);
            gpAcoes.Controls.Add(tbRegistros);
            gpAcoes.Location = new Point(12, 637);
            gpAcoes.Name = "gpAcoes";
            gpAcoes.Size = new Size(1171, 119);
            gpAcoes.TabIndex = 3;
            gpAcoes.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Location = new Point(643, 69);
            button4.Name = "button4";
            button4.Size = new Size(147, 30);
            button4.TabIndex = 13;
            button4.Text = "Desmarcar tudo";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(643, 24);
            button3.Name = "button3";
            button3.Size = new Size(147, 30);
            button3.TabIndex = 12;
            button3.Text = "Selecionar Tudo";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarEans
            // 
            btnCadastrarEans.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrarEans.Location = new Point(825, 69);
            btnCadastrarEans.Name = "btnCadastrarEans";
            btnCadastrarEans.Size = new Size(147, 30);
            btnCadastrarEans.TabIndex = 11;
            btnCadastrarEans.Text = "Cadastrar Itens";
            btnCadastrarEans.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 79);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 10;
            label1.Text = "Atenção:";
            // 
            // tbRegistrosAtencao
            // 
            tbRegistrosAtencao.BackColor = SystemColors.MenuBar;
            tbRegistrosAtencao.Location = new Point(80, 76);
            tbRegistrosAtencao.Name = "tbRegistrosAtencao";
            tbRegistrosAtencao.Size = new Size(72, 27);
            tbRegistrosAtencao.TabIndex = 9;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(1001, 69);
            button2.Name = "button2";
            button2.Size = new Size(147, 30);
            button2.TabIndex = 8;
            button2.Text = "Importar Totvs";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(825, 24);
            button1.Name = "button1";
            button1.Size = new Size(147, 30);
            button1.TabIndex = 7;
            button1.Text = "Consultar XMLs";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbRegistro
            // 
            lbRegistro.AutoSize = true;
            lbRegistro.Location = new Point(6, 29);
            lbRegistro.Name = "lbRegistro";
            lbRegistro.Size = new Size(68, 20);
            lbRegistro.TabIndex = 4;
            lbRegistro.Text = "Registos:";
            // 
            // ImportarNotasFiscaisXmlPataTotvs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 761);
            Controls.Add(gpAcoes);
            Controls.Add(dvgNotas);
            Controls.Add(Filtros);
            Name = "ImportarNotasFiscaisXmlPataTotvs";
            Text = "ImportarNotasFiscaisXmlPataTotvs";
            Filtros.ResumeLayout(false);
            Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNotas).EndInit();
            gpAcoes.ResumeLayout(false);
            gpAcoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Filtros;
        private Button btnConsultar;
        private Label lbTipoData;
        private ComboBox cbTipoData;
        private Label lbFim;
        private Label lbInicio;
        private DateTimePicker dtFim;
        private DateTimePicker dtInicio;
        private ComponentesTelaUI.DataGridView.MyDataGridView dvgNotas;
        private TextBox tbRegistros;
        private GroupBox gpAcoes;
        private Button button2;
        private Button button1;
        private Label lbRegistro;
        private Button btnCadastrarEans;
        private Label label1;
        private TextBox tbRegistrosAtencao;
        private Button button3;
        private Button button4;
    }
}