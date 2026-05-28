namespace SolfarmaGp.UI.MenusUI.Contabil.BuscaDadosCalculoCustoProduto
{
    partial class BuscaDadosCalculoCustoProduto
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
            dtFim = new DateTimePicker();
            dtInicio = new DateTimePicker();
            gpHeader = new GroupBox();
            button1 = new Button();
            lbDataInicio = new Label();
            lbDataFim = new Label();
            richTextBox1 = new RichTextBox();
            prbar = new ProgressBar();
            btnClose = new Button();
            gbFooter = new GroupBox();
            chkBoxIcmsRetidoSubstituido = new CheckBox();
            chkAqsValorTransferencia = new CheckBox();
            chkBoxValorFrete = new CheckBox();
            chkBoxReembolsoSaida = new CheckBox();
            chkBoxIcmsSt = new CheckBox();
            chkBoxReembolsoEntrada = new CheckBox();
            gpHeader.SuspendLayout();
            gbFooter.SuspendLayout();
            SuspendLayout();
            // 
            // dtFim
            // 
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(27, 128);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(158, 27);
            dtFim.TabIndex = 1;
            // 
            // dtInicio
            // 
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(27, 61);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(158, 27);
            dtInicio.TabIndex = 0;
            // 
            // gpHeader
            // 
            gpHeader.Controls.Add(button1);
            gpHeader.Controls.Add(lbDataInicio);
            gpHeader.Controls.Add(lbDataFim);
            gpHeader.Controls.Add(dtInicio);
            gpHeader.Controls.Add(dtFim);
            gpHeader.Location = new Point(12, 12);
            gpHeader.Name = "gpHeader";
            gpHeader.Size = new Size(648, 172);
            gpHeader.TabIndex = 2;
            gpHeader.TabStop = false;
            gpHeader.Text = "Parâmetros para pesquisa";
            // 
            // button1
            // 
            button1.Location = new Point(537, 115);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 2;
            button1.Text = "Executar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbDataInicio
            // 
            lbDataInicio.AutoSize = true;
            lbDataInicio.Location = new Point(27, 35);
            lbDataInicio.Name = "lbDataInicio";
            lbDataInicio.Size = new Size(84, 20);
            lbDataInicio.TabIndex = 3;
            lbDataInicio.Text = "Data Inicio:";
            // 
            // lbDataFim
            // 
            lbDataFim.AutoSize = true;
            lbDataFim.Location = new Point(27, 104);
            lbDataFim.Name = "lbDataFim";
            lbDataFim.Size = new Size(72, 20);
            lbDataFim.TabIndex = 2;
            lbDataFim.Text = "Data Fim:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.Location = new Point(12, 208);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(648, 258);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // prbar
            // 
            prbar.ForeColor = SystemColors.HotTrack;
            prbar.Location = new Point(12, 192);
            prbar.Name = "prbar";
            prbar.Size = new Size(648, 10);
            prbar.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(17, 593);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // gbFooter
            // 
            gbFooter.Controls.Add(chkBoxIcmsRetidoSubstituido);
            gbFooter.Controls.Add(chkAqsValorTransferencia);
            gbFooter.Controls.Add(chkBoxValorFrete);
            gbFooter.Controls.Add(chkBoxReembolsoSaida);
            gbFooter.Controls.Add(chkBoxIcmsSt);
            gbFooter.Controls.Add(chkBoxReembolsoEntrada);
            gbFooter.Location = new Point(12, 472);
            gbFooter.Name = "gbFooter";
            gbFooter.Size = new Size(645, 103);
            gbFooter.TabIndex = 7;
            gbFooter.TabStop = false;
            gbFooter.Text = "Tipos de Execuções";
            // 
            // chkBoxIcmsRetidoSubstituido
            // 
            chkBoxIcmsRetidoSubstituido.AutoSize = true;
            chkBoxIcmsRetidoSubstituido.Location = new Point(423, 61);
            chkBoxIcmsRetidoSubstituido.Name = "chkBoxIcmsRetidoSubstituido";
            chkBoxIcmsRetidoSubstituido.Size = new Size(198, 24);
            chkBoxIcmsRetidoSubstituido.TabIndex = 12;
            chkBoxIcmsRetidoSubstituido.Text = "ICMS Retido/ Substituido";
            chkBoxIcmsRetidoSubstituido.UseVisualStyleBackColor = true;
            // 
            // chkAqsValorTransferencia
            // 
            chkAqsValorTransferencia.AutoSize = true;
            chkAqsValorTransferencia.Location = new Point(423, 31);
            chkAqsValorTransferencia.Name = "chkAqsValorTransferencia";
            chkAqsValorTransferencia.Size = new Size(188, 24);
            chkAqsValorTransferencia.TabIndex = 11;
            chkAqsValorTransferencia.Text = "Aqs. Valor Transferência";
            chkAqsValorTransferencia.UseVisualStyleBackColor = true;
            // 
            // chkBoxValorFrete
            // 
            chkBoxValorFrete.AutoSize = true;
            chkBoxValorFrete.Location = new Point(234, 33);
            chkBoxValorFrete.Name = "chkBoxValorFrete";
            chkBoxValorFrete.Size = new Size(102, 24);
            chkBoxValorFrete.TabIndex = 10;
            chkBoxValorFrete.Text = "Valor Frete";
            chkBoxValorFrete.UseVisualStyleBackColor = true;
            // 
            // chkBoxReembolsoSaida
            // 
            chkBoxReembolsoSaida.AutoSize = true;
            chkBoxReembolsoSaida.Location = new Point(232, 61);
            chkBoxReembolsoSaida.Name = "chkBoxReembolsoSaida";
            chkBoxReembolsoSaida.Size = new Size(153, 24);
            chkBoxReembolsoSaida.TabIndex = 9;
            chkBoxReembolsoSaida.Text = "Reembolso/ Saída";
            chkBoxReembolsoSaida.UseVisualStyleBackColor = true;
            // 
            // chkBoxIcmsSt
            // 
            chkBoxIcmsSt.AutoSize = true;
            chkBoxIcmsSt.Location = new Point(18, 61);
            chkBoxIcmsSt.Name = "chkBoxIcmsSt";
            chkBoxIcmsSt.Size = new Size(89, 24);
            chkBoxIcmsSt.TabIndex = 8;
            chkBoxIcmsSt.Text = "ICMS ST ";
            chkBoxIcmsSt.UseVisualStyleBackColor = true;
            // 
            // chkBoxReembolsoEntrada
            // 
            chkBoxReembolsoEntrada.AutoSize = true;
            chkBoxReembolsoEntrada.Location = new Point(18, 32);
            chkBoxReembolsoEntrada.Name = "chkBoxReembolsoEntrada";
            chkBoxReembolsoEntrada.Size = new Size(167, 24);
            chkBoxReembolsoEntrada.TabIndex = 7;
            chkBoxReembolsoEntrada.Text = "Reembolso/ Entrada";
            chkBoxReembolsoEntrada.UseVisualStyleBackColor = true;
            // 
            // BuscaDadosCalculoCustoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 650);
            Controls.Add(gbFooter);
            Controls.Add(prbar);
            Controls.Add(richTextBox1);
            Controls.Add(gpHeader);
            Controls.Add(btnClose);
            Name = "BuscaDadosCalculoCustoProduto";
            Text = "Contabilização do Custo dos Produtos";
            gpHeader.ResumeLayout(false);
            gpHeader.PerformLayout();
            gbFooter.ResumeLayout(false);
            gbFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtFim;
        private DateTimePicker dtInicio;
        private GroupBox gpHeader;
        private Label lbDataInicio;
        private Label lbDataFim;
        private RichTextBox richTextBox1;
        private ProgressBar prbar;
        private Button button1;
        private Button btnClose;
        private GroupBox gbFooter;
        private CheckBox chkBoxIcmsRetidoSubstituido;
        private CheckBox chkAqsValorTransferencia;
        private CheckBox chkBoxValorFrete;
        private CheckBox chkBoxReembolsoSaida;
        private CheckBox chkBoxIcmsSt;
        private CheckBox chkBoxReembolsoEntrada;
    }
}