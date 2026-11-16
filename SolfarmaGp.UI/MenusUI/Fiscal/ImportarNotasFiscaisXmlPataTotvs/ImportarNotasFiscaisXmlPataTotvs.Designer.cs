using SolfarmaGp.UI.ComponentesTelaUI.Moderno;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Filtros = new CartaoGroupBox();
            groupBox1 = new CartaoGroupBox();
            dtFim = new DateTimePicker();
            dtInicio = new DateTimePicker();
            lbFim = new Label();
            lbInicio = new Label();
            btnConsultar = new BotaoModerno();
            dvgNotas = new GradeModerna();
            tbRegistros = new TextBox();
            gpAcoes = new CartaoGroupBox();
            btnVisualizarNota = new BotaoModerno();
            btnLimparSelecao = new BotaoModerno();
            btnSelecionaTodos = new BotaoModerno();
            label1 = new Label();
            tbRegistrosAtencao = new TextBox();
            button2 = new BotaoModerno();
            btnConsultarXml = new BotaoModerno();
            lbRegistro = new Label();
            Filtros.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNotas).BeginInit();
            gpAcoes.SuspendLayout();
            SuspendLayout();
            // 
            // Filtros
            // 
            Filtros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Filtros.BackColor = Color.White;
            Filtros.Controls.Add(groupBox1);
            Filtros.Controls.Add(btnConsultar);
            Filtros.CorBorda = Color.FromArgb(222, 225, 230);
            Filtros.Location = new Point(12, 3);
            Filtros.Name = "Filtros";
            Filtros.Raio = 10;
            Filtros.Size = new Size(1171, 187);
            Filtros.TabIndex = 0;
            Filtros.TabStop = false;
            Filtros.Text = "Filtros";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dtFim);
            groupBox1.Controls.Add(dtInicio);
            groupBox1.Controls.Add(lbFim);
            groupBox1.Controls.Add(lbInicio);
            groupBox1.CorBorda = Color.FromArgb(222, 225, 230);
            groupBox1.Location = new Point(6, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Raio = 10;
            groupBox1.Size = new Size(504, 159);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // dtFim
            // 
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(186, 58);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(123, 27);
            dtFim.TabIndex = 1;
            // 
            // dtInicio
            // 
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(24, 58);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(123, 27);
            dtInicio.TabIndex = 0;
            // 
            // lbFim
            // 
            lbFim.AutoSize = true;
            lbFim.Location = new Point(186, 35);
            lbFim.Name = "lbFim";
            lbFim.Size = new Size(33, 20);
            lbFim.TabIndex = 3;
            lbFim.Text = "Fim";
            // 
            // lbInicio
            // 
            lbInicio.AutoSize = true;
            lbInicio.Location = new Point(24, 35);
            lbInicio.Name = "lbInicio";
            lbInicio.Size = new Size(45, 20);
            lbInicio.TabIndex = 2;
            lbInicio.Text = "Inicio";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Location = new Point(1042, 129);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Principal = true;
            btnConsultar.Raio = 8;
            btnConsultar.Size = new Size(106, 30);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dvgNotas
            // 
            dvgNotas.AllowUserToAddRows = false;
            dvgNotas.AllowUserToDeleteRows = false;
            dvgNotas.AllowUserToResizeColumns = false;
            dvgNotas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 251, 252);
            dvgNotas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dvgNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgNotas.BackgroundColor = Color.White;
            dvgNotas.BorderStyle = BorderStyle.None;
            dvgNotas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgNotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(245, 246, 248);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(245, 246, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvgNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvgNotas.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(253, 232, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dvgNotas.DefaultCellStyle = dataGridViewCellStyle3;
            dvgNotas.EnableHeadersVisualStyles = false;
            dvgNotas.GridColor = Color.FromArgb(235, 237, 240);
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
            gpAcoes.BackColor = Color.White;
            gpAcoes.Controls.Add(btnVisualizarNota);
            gpAcoes.Controls.Add(btnLimparSelecao);
            gpAcoes.Controls.Add(btnSelecionaTodos);
            gpAcoes.Controls.Add(label1);
            gpAcoes.Controls.Add(tbRegistrosAtencao);
            gpAcoes.Controls.Add(button2);
            gpAcoes.Controls.Add(btnConsultarXml);
            gpAcoes.Controls.Add(lbRegistro);
            gpAcoes.Controls.Add(tbRegistros);
            gpAcoes.CorBorda = Color.FromArgb(222, 225, 230);
            gpAcoes.Location = new Point(12, 637);
            gpAcoes.Name = "gpAcoes";
            gpAcoes.Raio = 10;
            gpAcoes.Size = new Size(1171, 119);
            gpAcoes.TabIndex = 3;
            gpAcoes.TabStop = false;
            gpAcoes.Enter += gpAcoes_Enter;
            // 
            // btnVisualizarNota
            // 
            btnVisualizarNota.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualizarNota.FlatStyle = FlatStyle.Flat;
            btnVisualizarNota.Location = new Point(807, 69);
            btnVisualizarNota.Name = "btnVisualizarNota";
            btnVisualizarNota.Principal = false;
            btnVisualizarNota.Raio = 8;
            btnVisualizarNota.Size = new Size(151, 30);
            btnVisualizarNota.TabIndex = 14;
            btnVisualizarNota.Text = "Visualizar Nota";
            btnVisualizarNota.UseVisualStyleBackColor = true;
            btnVisualizarNota.Click += btnVisualizarNota_Click;
            // 
            // btnLimparSelecao
            // 
            btnLimparSelecao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimparSelecao.FlatStyle = FlatStyle.Flat;
            btnLimparSelecao.Location = new Point(202, 74);
            btnLimparSelecao.Name = "btnLimparSelecao";
            btnLimparSelecao.Principal = false;
            btnLimparSelecao.Raio = 8;
            btnLimparSelecao.Size = new Size(147, 30);
            btnLimparSelecao.TabIndex = 13;
            btnLimparSelecao.Text = "Desmarcar tudo";
            btnLimparSelecao.UseVisualStyleBackColor = true;
            btnLimparSelecao.Click += btnLimparSelecao_Click;
            // 
            // btnSelecionaTodos
            // 
            btnSelecionaTodos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSelecionaTodos.FlatStyle = FlatStyle.Flat;
            btnSelecionaTodos.Location = new Point(202, 29);
            btnSelecionaTodos.Name = "btnSelecionaTodos";
            btnSelecionaTodos.Principal = false;
            btnSelecionaTodos.Raio = 8;
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
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1001, 69);
            button2.Name = "button2";
            button2.Principal = false;
            button2.Raio = 8;
            button2.Size = new Size(147, 30);
            button2.TabIndex = 8;
            button2.Text = "Importar Totvs";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnConsultarXml
            // 
            btnConsultarXml.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConsultarXml.FlatStyle = FlatStyle.Flat;
            btnConsultarXml.Location = new Point(1001, 24);
            btnConsultarXml.Name = "btnConsultarXml";
            btnConsultarXml.Principal = false;
            btnConsultarXml.Raio = 8;
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
            // ImportarNotasFiscaisXmlPataTotvs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1195, 761);
            Controls.Add(gpAcoes);
            Controls.Add(dvgNotas);
            Controls.Add(Filtros);
            Name = "ImportarNotasFiscaisXmlPataTotvs";
            Text = "Importar XML Uso e Consumo";
            Filtros.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNotas).EndInit();
            gpAcoes.ResumeLayout(false);
            gpAcoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CartaoGroupBox Filtros;
        private BotaoModerno btnConsultar;
        private Label lbFim;
        private Label lbInicio;
        private DateTimePicker dtFim;
        private DateTimePicker dtInicio;
        private GradeModerna dvgNotas;
        private TextBox tbRegistros;
        private CartaoGroupBox gpAcoes;
        private BotaoModerno btnConsultarXml;
        private Label lbRegistro;
        private Label label1;
        private TextBox tbRegistrosAtencao;
        private BotaoModerno btnSelecionaTodos;
        private BotaoModerno btnLimparSelecao;
        private BotaoModerno btnVisualizarNota;
        private BotaoModerno button2;
        private CartaoGroupBox groupBox1;
    }
}