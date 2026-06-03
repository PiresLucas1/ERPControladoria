namespace SolfarmaGp.UI.MenusUI.Contabil.ParametrizacaoConferencia
{
    partial class AdicionaParametroResumido
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
            dvgResumo = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            btnAdicionarItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgResumo).BeginInit();
            SuspendLayout();
            // 
            // dvgResumo
            // 
            dvgResumo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgResumo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgResumo.ColumnHeadersHeight = 29;
            dvgResumo.Location = new Point(12, 21);
            dvgResumo.Name = "dvgResumo";
            dvgResumo.RowHeadersWidth = 51;
            dvgResumo.Size = new Size(896, 546);
            dvgResumo.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.Location = new Point(12, 606);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.Location = new Point(814, 606);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdicionarItem.Location = new Point(641, 606);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(141, 29);
            btnAdicionarItem.TabIndex = 3;
            btnAdicionarItem.Text = "Adicionar Item";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // AdicionaParametroResumido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 661);
            Controls.Add(btnAdicionarItem);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(dvgResumo);
            Name = "AdicionaParametroResumido";
            Text = "AdicionaParametroResumido";
            ((System.ComponentModel.ISupportInitialize)dvgResumo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComponentesTelaUI.DataGridView.MyDataGridView dvgResumo;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Button btnAdicionarItem;
    }
}