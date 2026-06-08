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
            lbFim = new Label();
            lbInicio = new Label();
            dtFim = new DateTimePicker();
            dtInicio = new DateTimePicker();
            dvgNotas = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            tbRegistros = new TextBox();
            gpAcoes = new GroupBox();
            btnVisualizarNota = new Button();
            btnLimparSelecao = new Button();
            btnSelecionaTodos = new Button();
            label1 = new Label();
            tbRegistrosAtencao = new TextBox();
            btnConsultarXml = new Button();
            lbRegistro = new Label();
            button2 = new Button();
            Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNotas).BeginInit();
            gpAcoes.SuspendLayout();
            SuspendLayout();
            // 
            // Filtros
            // 
            Filtros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Filtros.Controls.Add(btnConsultar);
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
            dvgNotas.AllowUserToAddRows = false;
            dvgNotas.AllowUserToDeleteRows = false;
            dvgNotas.AllowUserToResizeColumns = false;
            dvgNotas.AllowUserToResizeRows = false;
            dvgNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgNotas.ColumnHeadersHeight = 29;
            dvgNotas.Location = new Point(12, 197);
            dvgNotas.Name = "dvgNotas";
            dvgNotas.RowHeadersVisible = false;
            dvgNotas.RowHeadersWidth = 51;
            dvgNotas.Size = new Size(1171, 435);
            dvgNotas.TabIndex = 1;
            dvgNotas.CellClick += dvgNotas_CellClick;
            dvgNotas.CellDoubleClick += dvgNotas_CellContentDoubleClick;
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
            gpAcoes.Controls.Add(btnVisualizarNota);
            gpAcoes.Controls.Add(btnLimparSelecao);
            gpAcoes.Controls.Add(btnSelecionaTodos);
            gpAcoes.Controls.Add(label1);
            gpAcoes.Controls.Add(tbRegistrosAtencao);
            gpAcoes.Controls.Add(button2);
            gpAcoes.Controls.Add(btnConsultarXml);
            gpAcoes.Controls.Add(lbRegistro);
            gpAcoes.Controls.Add(tbRegistros);
            gpAcoes.Location = new Point(12, 637);
            gpAcoes.Name = "gpAcoes";
            gpAcoes.Size = new Size(1171, 119);
            gpAcoes.TabIndex = 3;
            gpAcoes.TabStop = false;
            gpAcoes.Enter += gpAcoes_Enter;
            // 
            // btnVisualizarNota
            // 
            btnVisualizarNota.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualizarNota.Location = new Point(807, 69);
            btnVisualizarNota.Name = "btnVisualizarNota";
            btnVisualizarNota.Size = new Size(151, 30);
            btnVisualizarNota.TabIndex = 14;
            btnVisualizarNota.Text = "Visualizar Nota";
            btnVisualizarNota.UseVisualStyleBackColor = true;
            btnVisualizarNota.Click += btnVisualizarNota_Click;
            // 
            // btnLimparSelecao
            // 
            btnLimparSelecao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimparSelecao.Location = new Point(202, 74);
            btnLimparSelecao.Name = "btnLimparSelecao";
            btnLimparSelecao.Size = new Size(147, 30);
            btnLimparSelecao.TabIndex = 13;
            btnLimparSelecao.Text = "Desmarcar tudo";
            btnLimparSelecao.UseVisualStyleBackColor = true;
            btnLimparSelecao.Click += btnLimparSelecao_Click;
            // 
            // btnSelecionaTodos
            // 
            btnSelecionaTodos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSelecionaTodos.Location = new Point(202, 29);
            btnSelecionaTodos.Name = "btnSelecionaTodos";
            btnSelecionaTodos.Size = new Size(147, 30);
            btnSelecionaTodos.TabIndex = 12;
            btnSelecionaTodos.Text = "Selecionar Tudo";
            btnSelecionaTodos.UseVisualStyleBackColor = true;
            btnSelecionaTodos.Click += btnSelecionaTodos_Click;
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
            // btnConsultarXml
            // 
            btnConsultarXml.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConsultarXml.Location = new Point(1001, 24);
            btnConsultarXml.Name = "btnConsultarXml";
            btnConsultarXml.Size = new Size(147, 30);
            btnConsultarXml.TabIndex = 7;
            btnConsultarXml.Text = "Consultar XML";
            btnConsultarXml.UseVisualStyleBackColor = true;
            btnConsultarXml.Click += btnConsultarXml_Click;
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
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Enabled = false;
            button2.Location = new Point(1001, 69);
            button2.Name = "button2";
            button2.Size = new Size(147, 30);
            button2.TabIndex = 8;
            button2.Text = "Importar Totvs";
            button2.UseVisualStyleBackColor = true;
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
            Text = "Importar Notas Fiscais XML Para TOTVS";
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
        private Label lbFim;
        private Label lbInicio;
        private DateTimePicker dtFim;
        private DateTimePicker dtInicio;
        private ComponentesTelaUI.DataGridView.MyDataGridView dvgNotas;
        private TextBox tbRegistros;
        private GroupBox gpAcoes;
        private Button btnConsultarXml;
        private Label lbRegistro;
        private Label label1;
        private TextBox tbRegistrosAtencao;
        private Button btnSelecionaTodos;
        private Button btnLimparSelecao;
        private Button btnVisualizarNota;
        private Button button2;
    }
}