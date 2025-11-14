namespace ERP_FISCAL.view
{
    partial class CadUsu
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
            this.txtNomeUsu = new System.Windows.Forms.TextBox();
            this.gpFiltro = new System.Windows.Forms.GroupBox();
            this.gpAdicao = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdicionarPerfil = new System.Windows.Forms.Button();
            this.btnAdicionarMenu = new System.Windows.Forms.Button();
            this.cbFiltros = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dvgUsuarios = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.gpFiltro.SuspendLayout();
            this.gpAdicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeUsu
            // 
            this.txtNomeUsu.Location = new System.Drawing.Point(65, 58);
            this.txtNomeUsu.Name = "txtNomeUsu";
            this.txtNomeUsu.Size = new System.Drawing.Size(146, 26);
            this.txtNomeUsu.TabIndex = 1;
            // 
            // gpFiltro
            // 
            this.gpFiltro.Controls.Add(this.gpAdicao);
            this.gpFiltro.Controls.Add(this.cbFiltros);
            this.gpFiltro.Controls.Add(this.btnFiltrar);
            this.gpFiltro.Controls.Add(this.label4);
            this.gpFiltro.Controls.Add(this.txtMenu);
            this.gpFiltro.Controls.Add(this.label3);
            this.gpFiltro.Controls.Add(this.txtPerfil);
            this.gpFiltro.Controls.Add(this.label2);
            this.gpFiltro.Controls.Add(this.label1);
            this.gpFiltro.Controls.Add(this.txtNomeUsu);
            this.gpFiltro.Location = new System.Drawing.Point(12, 12);
            this.gpFiltro.Name = "gpFiltro";
            this.gpFiltro.Size = new System.Drawing.Size(1142, 183);
            this.gpFiltro.TabIndex = 2;
            this.gpFiltro.TabStop = false;
            this.gpFiltro.Text = "Filtro";
            // 
            // gpAdicao
            // 
            this.gpAdicao.Controls.Add(this.button2);
            this.gpAdicao.Controls.Add(this.btnAdicionarPerfil);
            this.gpAdicao.Controls.Add(this.btnAdicionarMenu);
            this.gpAdicao.Location = new System.Drawing.Point(788, 25);
            this.gpAdicao.Name = "gpAdicao";
            this.gpAdicao.Size = new System.Drawing.Size(344, 148);
            this.gpAdicao.TabIndex = 12;
            this.gpAdicao.TabStop = false;
            this.gpAdicao.Text = "Adicionar Itens";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = " Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionarPerfil
            // 
            this.btnAdicionarPerfil.Location = new System.Drawing.Point(24, 81);
            this.btnAdicionarPerfil.Name = "btnAdicionarPerfil";
            this.btnAdicionarPerfil.Size = new System.Drawing.Size(142, 35);
            this.btnAdicionarPerfil.TabIndex = 13;
            this.btnAdicionarPerfil.Text = "Menu";
            this.btnAdicionarPerfil.UseVisualStyleBackColor = true;
            this.btnAdicionarPerfil.Click += new System.EventHandler(this.btnAdicionarMenu_Click);
            // 
            // btnAdicionarMenu
            // 
            this.btnAdicionarMenu.Location = new System.Drawing.Point(172, 35);
            this.btnAdicionarMenu.Name = "btnAdicionarMenu";
            this.btnAdicionarMenu.Size = new System.Drawing.Size(142, 35);
            this.btnAdicionarMenu.TabIndex = 12;
            this.btnAdicionarMenu.Text = "Perfil";
            this.btnAdicionarMenu.UseVisualStyleBackColor = true;
            this.btnAdicionarMenu.Click += new System.EventHandler(this.btnAdicionarPerfil_Click);
            // 
            // cbFiltros
            // 
            this.cbFiltros.FormattingEnabled = true;
            this.cbFiltros.Location = new System.Drawing.Point(261, 133);
            this.cbFiltros.Name = "cbFiltros";
            this.cbFiltros.Size = new System.Drawing.Size(146, 28);
            this.cbFiltros.TabIndex = 8;
            this.cbFiltros.SelectedIndexChanged += new System.EventHandler(this.cbFiltros_SelectedIndexChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(440, 124);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(118, 35);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opção de pesquisa";
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(65, 133);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(146, 26);
            this.txtMenu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menu";
            // 
            // txtPerfil
            // 
            this.txtPerfil.Location = new System.Drawing.Point(261, 58);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(146, 26);
            this.txtPerfil.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Usuario";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(1026, 724);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(118, 35);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 724);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Location = new System.Drawing.Point(12, 211);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.RowHeadersWidth = 62;
            this.dvgUsuarios.RowTemplate.Height = 28;
            this.dvgUsuarios.Size = new System.Drawing.Size(1143, 475);
            this.dvgUsuarios.TabIndex = 11;
            // 
            // CadUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 780);
            this.Controls.Add(this.dvgUsuarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gpFiltro);
            this.Name = "CadUsu";
            this.Text = "CadUsu";
            this.gpFiltro.ResumeLayout(false);
            this.gpFiltro.PerformLayout();
            this.gpAdicao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeUsu;
        private System.Windows.Forms.GroupBox gpFiltro;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbFiltros;
        private System.Windows.Forms.Label label4;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgUsuarios;
        private System.Windows.Forms.Button btnAdicionarPerfil;
        private System.Windows.Forms.Button btnAdicionarMenu;
        private System.Windows.Forms.GroupBox gpAdicao;
        private System.Windows.Forms.Button button2;
    }
}