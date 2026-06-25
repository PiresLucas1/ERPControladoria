namespace SolfarmaGp.UI.MenusUI.Fiscal.NovaPasta
{
    partial class ExcutaAutomacaoRenomearArquivos
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
            txbPath = new TextBox();
            label1 = new Label();
            btnExecutar = new Button();
            btnCancelar = new Button();
            btnAbrirPasta = new Button();
            rtbInfo = new RichTextBox();
            pgBar = new ProgressBar();
            chkNotasQive = new CheckBox();
            SuspendLayout();
            // 
            // txbPath
            // 
            txbPath.BackColor = SystemColors.InactiveBorder;
            txbPath.Location = new Point(12, 67);
            txbPath.Name = "txbPath";
            txbPath.PlaceholderText = "C://www/jhondoe/arquivos";
            txbPath.Size = new Size(366, 27);
            txbPath.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 1;
            label1.Text = "Caminho da pasta dos arquivos";
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(500, 64);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(109, 30);
            btnExecutar.TabIndex = 2;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(354, 455);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 30);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAbrirPasta
            // 
            btnAbrirPasta.Location = new Point(500, 455);
            btnAbrirPasta.Name = "btnAbrirPasta";
            btnAbrirPasta.Size = new Size(109, 30);
            btnAbrirPasta.TabIndex = 4;
            btnAbrirPasta.Text = "Abrir Pasta";
            btnAbrirPasta.UseVisualStyleBackColor = true;
            btnAbrirPasta.Click += btnAbrirPasta_Click;
            // 
            // rtbInfo
            // 
            rtbInfo.BackColor = SystemColors.Info;
            rtbInfo.Location = new Point(12, 162);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.ReadOnly = true;
            rtbInfo.Size = new Size(597, 265);
            rtbInfo.TabIndex = 5;
            rtbInfo.Text = "";
            // 
            // pgBar
            // 
            pgBar.Location = new Point(11, 433);
            pgBar.Name = "pgBar";
            pgBar.Size = new Size(598, 10);
            pgBar.TabIndex = 6;
            // 
            // chkNotasQive
            // 
            chkNotasQive.AutoSize = true;
            chkNotasQive.Location = new Point(12, 114);
            chkNotasQive.Name = "chkNotasQive";
            chkNotasQive.Size = new Size(184, 24);
            chkNotasQive.TabIndex = 7;
            chkNotasQive.Text = "Renomear Notas Quive";
            chkNotasQive.UseVisualStyleBackColor = true;
            // 
            // ExcutaAutomacaoRenomearArquivos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 518);
            Controls.Add(chkNotasQive);
            Controls.Add(pgBar);
            Controls.Add(rtbInfo);
            Controls.Add(btnAbrirPasta);
            Controls.Add(btnCancelar);
            Controls.Add(btnExecutar);
            Controls.Add(label1);
            Controls.Add(txbPath);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ExcutaAutomacaoRenomearArquivos";
            Text = "Renomear PDF (NFe | NFS-e)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbPath;
        private Label label1;
        private Button btnExecutar;
        private Button btnCancelar;
        private Button btnAbrirPasta;
        private RichTextBox rtbInfo;
        private ProgressBar pgBar;
        private CheckBox chkNotasQive;
        private RadioButton radioButton1;
    }
}