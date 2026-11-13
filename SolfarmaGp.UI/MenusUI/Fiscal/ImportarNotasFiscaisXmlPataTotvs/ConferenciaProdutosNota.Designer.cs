namespace SolfarmaGp.UI.MenusUI.Fiscal.ImportarNotasFiscaisXmlPataTotvs
{
    partial class ConferenciaProdutosNota
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvProdutos = new DataGridView();
            pnlRodape = new Panel();
            lbTotais = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            pnlRodape.SuspendLayout();
            SuspendLayout();
            //
            // dgvProdutos
            //
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProdutos.BackgroundColor = SystemColors.Window;
            dgvProdutos.Dock = DockStyle.Fill;
            dgvProdutos.Location = new Point(0, 0);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(1100, 393);
            dgvProdutos.TabIndex = 0;
            dgvProdutos.CellFormatting += dgvProdutos_CellFormatting;
            //
            // pnlRodape
            //
            pnlRodape.Controls.Add(lbTotais);
            pnlRodape.Controls.Add(btnConfirmar);
            pnlRodape.Controls.Add(btnCancelar);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Location = new Point(0, 393);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(1100, 57);
            pnlRodape.TabIndex = 1;
            //
            // lbTotais
            //
            lbTotais.Anchor = AnchorStyles.Left;
            lbTotais.AutoSize = true;
            lbTotais.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTotais.Location = new Point(12, 18);
            lbTotais.Name = "lbTotais";
            lbTotais.Size = new Size(0, 20);
            lbTotais.TabIndex = 0;
            //
            // btnConfirmar
            //
            btnConfirmar.Anchor = AnchorStyles.Right;
            btnConfirmar.Location = new Point(872, 13);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(105, 31);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Lançar Nota";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Anchor = AnchorStyles.Right;
            btnCancelar.Location = new Point(983, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 31);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // ConferenciaProdutosNota
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(1100, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(pnlRodape);
            MinimizeBox = false;
            MinimumSize = new Size(700, 300);
            Name = "ConferenciaProdutosNota";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Conferência dos produtos enviados";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            pnlRodape.ResumeLayout(false);
            pnlRodape.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProdutos;
        private Panel pnlRodape;
        private Label lbTotais;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}
