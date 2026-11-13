using SolfarmaGp.UI.ComponentesTelaUI.Moderno;

namespace SolfarmaGp.UI.MenusUI.Contabil.GerenciaClientesReembolso
{
    partial class GerenciaClientesReembolso
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
            dvgGerenciar = new GradeModerna();
            btnSalvar = new BotaoModerno();
            tbContador = new TextBox();
            btnCancelar = new BotaoModerno();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            lbNome = new Label();
            btnFiltrar = new BotaoModerno();
            ((System.ComponentModel.ISupportInitialize)dvgGerenciar).BeginInit();
            SuspendLayout();
            // 
            // dvgGerenciar
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 251, 252);
            dvgGerenciar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dvgGerenciar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgGerenciar.BackgroundColor = Color.White;
            dvgGerenciar.BorderStyle = BorderStyle.None;
            dvgGerenciar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgGerenciar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(245, 246, 248);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(245, 246, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvgGerenciar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvgGerenciar.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(253, 232, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dvgGerenciar.DefaultCellStyle = dataGridViewCellStyle3;
            dvgGerenciar.EnableHeadersVisualStyles = false;
            dvgGerenciar.GridColor = Color.FromArgb(235, 237, 240);
            dvgGerenciar.Location = new Point(12, 141);
            dvgGerenciar.Name = "dvgGerenciar";
            dvgGerenciar.RowHeadersWidth = 51;
            dvgGerenciar.Size = new Size(818, 472);
            dvgGerenciar.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(670, 629);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Principal = true;
            btnSalvar.Raio = 8;
            btnSalvar.Size = new Size(138, 39);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tbContador
            // 
            tbContador.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbContador.BackColor = SystemColors.ScrollBar;
            tbContador.Location = new Point(12, 641);
            tbContador.Name = "tbContador";
            tbContador.Size = new Size(111, 27);
            tbContador.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(483, 629);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Principal = false;
            btnCancelar.Raio = 8;
            btnCancelar.Size = new Size(128, 39);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 5;
            label1.Text = "IDPessoa:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 44);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(349, 27);
            textBox3.TabIndex = 6;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(169, 13);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(53, 20);
            lbNome.TabIndex = 7;
            lbNome.Text = "Nome:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Location = new Point(670, 94);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Principal = false;
            btnFiltrar.Raio = 8;
            btnFiltrar.Size = new Size(138, 32);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // GerenciaClientesReembolso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(842, 693);
            Controls.Add(btnFiltrar);
            Controls.Add(lbNome);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(btnCancelar);
            Controls.Add(tbContador);
            Controls.Add(btnSalvar);
            Controls.Add(dvgGerenciar);
            Name = "GerenciaClientesReembolso";
            ShowIcon = false;
            Text = "Gerencia Clientes Reembolso";
            Load += GerenciaClientesReembolso_Load;
            ((System.ComponentModel.ISupportInitialize)dvgGerenciar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradeModerna dvgGerenciar;
        private BotaoModerno btnSalvar;
        private TextBox tbContador;
        private BotaoModerno btnCancelar;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label lbNome;
        private BotaoModerno btnFiltrar;
    }
}