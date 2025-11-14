namespace ERP_FISCAL.view.UIComponentes
{
    partial class AdicionaUsuario
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
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.nomeUsuario = new System.Windows.Forms.Label();
            this.cbListaPerfil = new System.Windows.Forms.ComboBox();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(53, 79);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(306, 26);
            this.txtNomeUsuario.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(248, 253);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(111, 42);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.AutoSize = true;
            this.nomeUsuario.Location = new System.Drawing.Point(49, 31);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(110, 20);
            this.nomeUsuario.TabIndex = 3;
            this.nomeUsuario.Text = "Nome Usuario";
            // 
            // cbListaPerfil
            // 
            this.cbListaPerfil.FormattingEnabled = true;
            this.cbListaPerfil.Location = new System.Drawing.Point(53, 151);
            this.cbListaPerfil.Name = "cbListaPerfil";
            this.cbListaPerfil.Size = new System.Drawing.Size(306, 28);
            this.cbListaPerfil.TabIndex = 4;
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Location = new System.Drawing.Point(49, 117);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(66, 30);
            this.lbPerfil.TabIndex = 5;
            this.lbPerfil.Text = "Perfil";
            // 
            // AdicionaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 316);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.cbListaPerfil);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNomeUsuario);
            this.Name = "AdicionaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label nomeUsuario;
        private System.Windows.Forms.ComboBox cbListaPerfil;
        private System.Windows.Forms.Label lbPerfil;
    }
}