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
            dvgGerenciar = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            btnSalvar = new Button();
            tbContador = new TextBox();
            btnCancelar = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            lbNome = new Label();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgGerenciar).BeginInit();
            SuspendLayout();
            // 
            // dvgGerenciar
            // 
            dvgGerenciar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgGerenciar.ColumnHeadersHeight = 29;
            dvgGerenciar.Location = new Point(12, 141);
            dvgGerenciar.Name = "dvgGerenciar";
            dvgGerenciar.RowHeadersWidth = 51;
            dvgGerenciar.Size = new Size(818, 472);
            dvgGerenciar.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Location = new Point(670, 629);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(138, 39);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
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
            btnCancelar.Location = new Point(483, 629);
            btnCancelar.Name = "btnCancelar";
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
            btnFiltrar.Location = new Point(670, 94);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(138, 32);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // GerenciaClientesReembolso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Text = "GerenciaClientesReembolso";
            Load += GerenciaClientesReembolso_Load;
            ((System.ComponentModel.ISupportInitialize)dvgGerenciar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentesTelaUI.DataGridView.MyDataGridView dvgGerenciar;
        private Button btnSalvar;
        private TextBox tbContador;
        private Button btnCancelar;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label lbNome;
        private Button btnFiltrar;
    }
}