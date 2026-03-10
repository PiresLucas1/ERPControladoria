namespace SolfarmaGp.UI.MenusUI.Contabil
{
    partial class AdicionarItemParametro
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
            cbTipoItem = new ComboBox();
            tbItem = new TextBox();
            btnAdicionar = new Button();
            tbPlanoContas = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cbTipoItem
            // 
            cbTipoItem.FormattingEnabled = true;
            cbTipoItem.Location = new Point(44, 57);
            cbTipoItem.Name = "cbTipoItem";
            cbTipoItem.Size = new Size(150, 28);
            cbTipoItem.TabIndex = 0;
            cbTipoItem.SelectedIndexChanged += cbTipoItem_SelectedIndexChanged;
            // 
            // tbItem
            // 
            tbItem.Location = new Point(44, 121);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(311, 27);
            tbItem.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(236, 243);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(119, 30);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adiconar Item";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // tbPlanoContas
            // 
            tbPlanoContas.Location = new Point(44, 181);
            tbPlanoContas.Name = "tbPlanoContas";
            tbPlanoContas.Size = new Size(311, 27);
            tbPlanoContas.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(98, 243);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 30);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AdicionarItemParametro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 304);
            Controls.Add(btnCancelar);
            Controls.Add(tbPlanoContas);
            Controls.Add(btnAdicionar);
            Controls.Add(tbItem);
            Controls.Add(cbTipoItem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AdicionarItemParametro";
            Text = "AdicionarItemParametro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipoItem;
        private TextBox tbItem;
        private Button btnAdicionar;
        private TextBox tbPlanoContas;
        private Button btnCancelar;
    }
}