namespace SolfarmaGP.UI.MenusUI.Fiscal.ImportarNotaServicoView
{
    partial class PreencherServicoCfopLote
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
            lbServico = new Label();
            txtServico = new TextBox();
            btnPesquisarServico = new Button();
            txtDescServico = new TextBox();
            lbCfop = new Label();
            txtCfop = new TextBox();
            btnPesquisarCfop = new Button();
            txtDescCfop = new TextBox();
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
            // lbServico
            //
            lbServico.AutoSize = true;
            lbServico.Location = new Point(12, 58);
            lbServico.Name = "lbServico";
            lbServico.Size = new Size(131, 20);
            lbServico.TabIndex = 1;
            lbServico.Text = "Cód. Serviço TOTVS";
            //
            // txtServico
            //
            txtServico.Location = new Point(12, 81);
            txtServico.Name = "txtServico";
            txtServico.Size = new Size(160, 27);
            txtServico.TabIndex = 2;
            txtServico.TextChanged += txtServico_TextChanged;
            txtServico.KeyDown += txtServico_KeyDown;
            //
            // btnPesquisarServico
            //
            btnPesquisarServico.Location = new Point(178, 80);
            btnPesquisarServico.Name = "btnPesquisarServico";
            btnPesquisarServico.Size = new Size(40, 29);
            btnPesquisarServico.TabIndex = 3;
            btnPesquisarServico.Text = "...";
            btnPesquisarServico.UseVisualStyleBackColor = true;
            btnPesquisarServico.Click += btnPesquisarServico_Click;
            //
            // txtDescServico
            //
            txtDescServico.Location = new Point(224, 81);
            txtDescServico.Name = "txtDescServico";
            txtDescServico.ReadOnly = true;
            txtDescServico.Size = new Size(324, 27);
            txtDescServico.TabIndex = 4;
            txtDescServico.TabStop = false;
            //
            // lbCfop
            //
            lbCfop.AutoSize = true;
            lbCfop.Location = new Point(12, 121);
            lbCfop.Name = "lbCfop";
            lbCfop.Size = new Size(41, 20);
            lbCfop.TabIndex = 5;
            lbCfop.Text = "CFOP";
            //
            // txtCfop
            //
            txtCfop.Location = new Point(12, 144);
            txtCfop.Name = "txtCfop";
            txtCfop.Size = new Size(160, 27);
            txtCfop.TabIndex = 6;
            txtCfop.TextChanged += txtCfop_TextChanged;
            txtCfop.KeyDown += txtCfop_KeyDown;
            //
            // btnPesquisarCfop
            //
            btnPesquisarCfop.Location = new Point(178, 143);
            btnPesquisarCfop.Name = "btnPesquisarCfop";
            btnPesquisarCfop.Size = new Size(40, 29);
            btnPesquisarCfop.TabIndex = 7;
            btnPesquisarCfop.Text = "...";
            btnPesquisarCfop.UseVisualStyleBackColor = true;
            btnPesquisarCfop.Click += btnPesquisarCfop_Click;
            //
            // txtDescCfop
            //
            txtDescCfop.Location = new Point(224, 144);
            txtDescCfop.Name = "txtDescCfop";
            txtDescCfop.ReadOnly = true;
            txtDescCfop.Size = new Size(324, 27);
            txtDescCfop.TabIndex = 8;
            txtDescCfop.TabStop = false;
            //
            // btnAplicar
            //
            btnAplicar.Location = new Point(332, 194);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(105, 31);
            btnAplicar.TabIndex = 9;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(443, 194);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 31);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // PreencherServicoCfopLote
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(560, 237);
            Controls.Add(lbInfo);
            Controls.Add(lbServico);
            Controls.Add(txtServico);
            Controls.Add(btnPesquisarServico);
            Controls.Add(txtDescServico);
            Controls.Add(lbCfop);
            Controls.Add(txtCfop);
            Controls.Add(btnPesquisarCfop);
            Controls.Add(txtDescCfop);
            Controls.Add(btnAplicar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PreencherServicoCfopLote";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Preencher Serviço / CFOP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbInfo;
        private Label lbServico;
        private TextBox txtServico;
        private Button btnPesquisarServico;
        private TextBox txtDescServico;
        private Label lbCfop;
        private TextBox txtCfop;
        private Button btnPesquisarCfop;
        private TextBox txtDescCfop;
        private Button btnAplicar;
        private Button btnCancelar;
    }
}
