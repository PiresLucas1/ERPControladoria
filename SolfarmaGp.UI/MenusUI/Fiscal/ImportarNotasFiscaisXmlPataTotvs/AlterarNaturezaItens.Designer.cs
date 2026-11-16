namespace SolfarmaGp.UI.MenusUI.Fiscal.ImportarNotasFiscaisXmlPataTotvs
{
    partial class AlterarNaturezaItens
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
            lbInfo = new Label();
            lbNatureza = new Label();
            txtNatureza = new TextBox();
            btnPesquisar = new Button();
            txtDescricao = new TextBox();
            btnAplicar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            //
            // lbInfo
            //
            lbInfo.Location = new Point(12, 9);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(536, 40);
            lbInfo.TabIndex = 0;
            //
            // lbNatureza
            //
            lbNatureza.AutoSize = true;
            lbNatureza.Location = new Point(12, 58);
            lbNatureza.Name = "lbNatureza";
            lbNatureza.Size = new Size(152, 20);
            lbNatureza.TabIndex = 1;
            lbNatureza.Text = "Natureza Fiscal (CFOP)";
            //
            // txtNatureza
            //
            txtNatureza.Location = new Point(12, 81);
            txtNatureza.Name = "txtNatureza";
            txtNatureza.Size = new Size(160, 27);
            txtNatureza.TabIndex = 2;
            txtNatureza.TextChanged += txtNatureza_TextChanged;
            txtNatureza.KeyDown += txtNatureza_KeyDown;
            //
            // btnPesquisar
            //
            btnPesquisar.Location = new Point(178, 80);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(40, 29);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "...";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            //
            // txtDescricao
            //
            txtDescricao.Location = new Point(224, 81);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(324, 27);
            txtDescricao.TabIndex = 4;
            txtDescricao.TabStop = false;
            //
            // btnAplicar
            //
            btnAplicar.Location = new Point(332, 130);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(105, 31);
            btnAplicar.TabIndex = 5;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(443, 130);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 31);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // AlterarNaturezaItens
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(560, 173);
            Controls.Add(lbInfo);
            Controls.Add(lbNatureza);
            Controls.Add(txtNatureza);
            Controls.Add(btnPesquisar);
            Controls.Add(txtDescricao);
            Controls.Add(btnAplicar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AlterarNaturezaItens";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alterar Natureza dos Itens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbInfo;
        private Label lbNatureza;
        private TextBox txtNatureza;
        private Button btnPesquisar;
        private TextBox txtDescricao;
        private Button btnAplicar;
        private Button btnCancelar;
    }
}
