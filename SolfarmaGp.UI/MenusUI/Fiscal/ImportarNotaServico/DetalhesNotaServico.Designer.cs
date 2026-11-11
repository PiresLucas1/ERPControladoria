namespace SolfarmaGP.UI.MenusUI.Fiscal.ImportarNotaServicoView
{
    partial class DetalhesNotaServico
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
            tlpCampos = new TableLayoutPanel();
            pnlRodape = new Panel();
            btnFechar = new Button();
            pnlRodape.SuspendLayout();
            SuspendLayout();
            //
            // tlpCampos
            //
            tlpCampos.AutoScroll = true;
            tlpCampos.ColumnCount = 2;
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Location = new Point(0, 0);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.Padding = new Padding(10, 10, 20, 10);
            tlpCampos.RowCount = 0;
            tlpCampos.Size = new Size(700, 553);
            tlpCampos.TabIndex = 0;
            //
            // pnlRodape
            //
            pnlRodape.Controls.Add(btnFechar);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Location = new Point(0, 553);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(700, 47);
            pnlRodape.TabIndex = 1;
            //
            // btnFechar
            //
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.Location = new Point(583, 8);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(105, 31);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            //
            // DetalhesNotaServico
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnFechar;
            ClientSize = new Size(700, 600);
            Controls.Add(tlpCampos);
            Controls.Add(pnlRodape);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(500, 400);
            Name = "DetalhesNotaServico";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhes da Nota";
            pnlRodape.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCampos;
        private Panel pnlRodape;
        private Button btnFechar;
    }
}
