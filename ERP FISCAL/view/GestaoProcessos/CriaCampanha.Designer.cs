namespace ERP_FISCAL.view.GestaoProcessos
{
    partial class CriaCampanha
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
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNomeCampanha = new System.Windows.Forms.TextBox();
            this.dtInicioApuracao = new System.Windows.Forms.DateTimePicker();
            this.dtFimApuracao = new System.Windows.Forms.DateTimePicker();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.tbApuracao = new System.Windows.Forms.TextBox();
            this.lbDataApuracao = new System.Windows.Forms.Label();
            this.tbCalculo = new System.Windows.Forms.TextBox();
            this.gbDataApurcao = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMecanica = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chckRegraValidacao = new System.Windows.Forms.CheckBox();
            this.tbMeta = new System.Windows.Forms.TextBox();
            this.tbGatilhoPositivacao = new System.Windows.Forms.TextBox();
            this.cbValores = new System.Windows.Forms.ComboBox();
            this.lbTipoValor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbGatilhoVenda = new System.Windows.Forms.Label();
            this.tbGatilhoVenda = new System.Windows.Forms.TextBox();
            this.tbObservação = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chckGatilhoVenda = new System.Windows.Forms.CheckBox();
            this.chckbGatilhoPositivacao = new System.Windows.Forms.CheckBox();
            this.gbOutros = new System.Windows.Forms.GroupBox();
            this.btnCriarCampanha = new System.Windows.Forms.Button();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnAtualizaVisualizacao = new System.Windows.Forms.Button();
            this.dvgCampanhas = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.gbMain.SuspendLayout();
            this.gbDataApurcao.SuspendLayout();
            this.gbMecanica.SuspendLayout();
            this.gbOutros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCampanhas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(36, 35);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(116, 16);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome Campanha:";
            // 
            // tbNomeCampanha
            // 
            this.tbNomeCampanha.Location = new System.Drawing.Point(39, 63);
            this.tbNomeCampanha.Name = "tbNomeCampanha";
            this.tbNomeCampanha.Size = new System.Drawing.Size(344, 22);
            this.tbNomeCampanha.TabIndex = 1;
            // 
            // dtInicioApuracao
            // 
            this.dtInicioApuracao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicioApuracao.Location = new System.Drawing.Point(21, 48);
            this.dtInicioApuracao.Name = "dtInicioApuracao";
            this.dtInicioApuracao.Size = new System.Drawing.Size(195, 22);
            this.dtInicioApuracao.TabIndex = 2;
            // 
            // dtFimApuracao
            // 
            this.dtFimApuracao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFimApuracao.Location = new System.Drawing.Point(21, 107);
            this.dtFimApuracao.Name = "dtFimApuracao";
            this.dtFimApuracao.Size = new System.Drawing.Size(195, 22);
            this.dtFimApuracao.TabIndex = 3;
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Controls.Add(this.btnCriarCampanha);
            this.gbMain.Controls.Add(this.tbNomeCampanha);
            this.gbMain.Controls.Add(this.lbNome);
            this.gbMain.Controls.Add(this.gbDataApurcao);
            this.gbMain.Controls.Add(this.gbMecanica);
            this.gbMain.Controls.Add(this.gbOutros);
            this.gbMain.Location = new System.Drawing.Point(13, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1484, 543);
            this.gbMain.TabIndex = 4;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Parametros:";
            // 
            // tbApuracao
            // 
            this.tbApuracao.Location = new System.Drawing.Point(36, 66);
            this.tbApuracao.Name = "tbApuracao";
            this.tbApuracao.Size = new System.Drawing.Size(486, 22);
            this.tbApuracao.TabIndex = 5;
            // 
            // lbDataApuracao
            // 
            this.lbDataApuracao.AutoSize = true;
            this.lbDataApuracao.Location = new System.Drawing.Point(18, 24);
            this.lbDataApuracao.Name = "lbDataApuracao";
            this.lbDataApuracao.Size = new System.Drawing.Size(41, 16);
            this.lbDataApuracao.TabIndex = 4;
            this.lbDataApuracao.Text = "Inicio:";
            // 
            // tbCalculo
            // 
            this.tbCalculo.Location = new System.Drawing.Point(36, 140);
            this.tbCalculo.Name = "tbCalculo";
            this.tbCalculo.Size = new System.Drawing.Size(486, 22);
            this.tbCalculo.TabIndex = 6;
            // 
            // gbDataApurcao
            // 
            this.gbDataApurcao.Controls.Add(this.label1);
            this.gbDataApurcao.Controls.Add(this.dtInicioApuracao);
            this.gbDataApurcao.Controls.Add(this.dtFimApuracao);
            this.gbDataApurcao.Controls.Add(this.lbDataApuracao);
            this.gbDataApurcao.Location = new System.Drawing.Point(39, 102);
            this.gbDataApurcao.Name = "gbDataApurcao";
            this.gbDataApurcao.Size = new System.Drawing.Size(344, 145);
            this.gbDataApurcao.TabIndex = 7;
            this.gbDataApurcao.TabStop = false;
            this.gbDataApurcao.Text = "Data Apuração";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fim:";
            // 
            // gbMecanica
            // 
            this.gbMecanica.Controls.Add(this.lbTipoValor);
            this.gbMecanica.Controls.Add(this.cbValores);
            this.gbMecanica.Controls.Add(this.chckRegraValidacao);
            this.gbMecanica.Controls.Add(this.label3);
            this.gbMecanica.Controls.Add(this.label2);
            this.gbMecanica.Controls.Add(this.tbCalculo);
            this.gbMecanica.Controls.Add(this.tbApuracao);
            this.gbMecanica.Location = new System.Drawing.Point(486, 21);
            this.gbMecanica.Name = "gbMecanica";
            this.gbMecanica.Size = new System.Drawing.Size(812, 236);
            this.gbMecanica.TabIndex = 8;
            this.gbMecanica.TabStop = false;
            this.gbMecanica.Text = "Mecanica da Campanha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo Apuração:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo Calculo:";
            // 
            // chckRegraValidacao
            // 
            this.chckRegraValidacao.AutoSize = true;
            this.chckRegraValidacao.Location = new System.Drawing.Point(36, 187);
            this.chckRegraValidacao.Name = "chckRegraValidacao";
            this.chckRegraValidacao.Size = new System.Drawing.Size(200, 20);
            this.chckRegraValidacao.TabIndex = 9;
            this.chckRegraValidacao.Text = "Existe Regra de Validação ?";
            this.chckRegraValidacao.UseVisualStyleBackColor = true;
            // 
            // tbMeta
            // 
            this.tbMeta.Location = new System.Drawing.Point(262, 125);
            this.tbMeta.Name = "tbMeta";
            this.tbMeta.Size = new System.Drawing.Size(175, 22);
            this.tbMeta.TabIndex = 11;
            this.tbMeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMeta_KeyPress);
            // 
            // tbGatilhoPositivacao
            // 
            this.tbGatilhoPositivacao.Location = new System.Drawing.Point(27, 204);
            this.tbGatilhoPositivacao.Name = "tbGatilhoPositivacao";
            this.tbGatilhoPositivacao.Size = new System.Drawing.Size(175, 22);
            this.tbGatilhoPositivacao.TabIndex = 12;
            this.tbGatilhoPositivacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGatilhoPositivacao_KeyPress);
            // 
            // cbValores
            // 
            this.cbValores.FormattingEnabled = true;
            this.cbValores.Location = new System.Drawing.Point(610, 64);
            this.cbValores.Name = "cbValores";
            this.cbValores.Size = new System.Drawing.Size(153, 24);
            this.cbValores.TabIndex = 11;
            // 
            // lbTipoValor
            // 
            this.lbTipoValor.AutoSize = true;
            this.lbTipoValor.Location = new System.Drawing.Point(607, 27);
            this.lbTipoValor.Name = "lbTipoValor";
            this.lbTipoValor.Size = new System.Drawing.Size(73, 16);
            this.lbTipoValor.TabIndex = 12;
            this.lbTipoValor.Text = "Tipo Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor Meta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gatilho Positivação:";
            // 
            // lbGatilhoVenda
            // 
            this.lbGatilhoVenda.AutoSize = true;
            this.lbGatilhoVenda.Location = new System.Drawing.Point(25, 92);
            this.lbGatilhoVenda.Name = "lbGatilhoVenda";
            this.lbGatilhoVenda.Size = new System.Drawing.Size(95, 16);
            this.lbGatilhoVenda.TabIndex = 16;
            this.lbGatilhoVenda.Text = "Gatilho Venda:";
            // 
            // tbGatilhoVenda
            // 
            this.tbGatilhoVenda.Location = new System.Drawing.Point(27, 123);
            this.tbGatilhoVenda.Name = "tbGatilhoVenda";
            this.tbGatilhoVenda.Size = new System.Drawing.Size(175, 22);
            this.tbGatilhoVenda.TabIndex = 15;
            this.tbGatilhoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGatilhoVenda_KeyPress);
            // 
            // tbObservação
            // 
            this.tbObservação.Location = new System.Drawing.Point(262, 195);
            this.tbObservação.Name = "tbObservação";
            this.tbObservação.Size = new System.Drawing.Size(485, 22);
            this.tbObservação.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Observação:";
            // 
            // chckGatilhoVenda
            // 
            this.chckGatilhoVenda.AutoSize = true;
            this.chckGatilhoVenda.Location = new System.Drawing.Point(28, 32);
            this.chckGatilhoVenda.Name = "chckGatilhoVenda";
            this.chckGatilhoVenda.Size = new System.Drawing.Size(133, 20);
            this.chckGatilhoVenda.TabIndex = 19;
            this.chckGatilhoVenda.Text = "Gatilho de Venda";
            this.chckGatilhoVenda.UseVisualStyleBackColor = true;
            this.chckGatilhoVenda.CheckedChanged += new System.EventHandler(this.chckGatilhoVenda_CheckedChanged);
            // 
            // chckbGatilhoPositivacao
            // 
            this.chckbGatilhoPositivacao.AutoSize = true;
            this.chckbGatilhoPositivacao.Location = new System.Drawing.Point(262, 32);
            this.chckbGatilhoPositivacao.Name = "chckbGatilhoPositivacao";
            this.chckbGatilhoPositivacao.Size = new System.Drawing.Size(145, 20);
            this.chckbGatilhoPositivacao.TabIndex = 20;
            this.chckbGatilhoPositivacao.Text = "Gatilho Positivação";
            this.chckbGatilhoPositivacao.UseVisualStyleBackColor = true;
            this.chckbGatilhoPositivacao.CheckedChanged += new System.EventHandler(this.chckbGatilhoPositivacao_CheckedChanged);
            // 
            // gbOutros
            // 
            this.gbOutros.Controls.Add(this.label5);
            this.gbOutros.Controls.Add(this.tbGatilhoVenda);
            this.gbOutros.Controls.Add(this.tbGatilhoPositivacao);
            this.gbOutros.Controls.Add(this.label4);
            this.gbOutros.Controls.Add(this.tbMeta);
            this.gbOutros.Controls.Add(this.label6);
            this.gbOutros.Controls.Add(this.chckbGatilhoPositivacao);
            this.gbOutros.Controls.Add(this.lbGatilhoVenda);
            this.gbOutros.Controls.Add(this.tbObservação);
            this.gbOutros.Controls.Add(this.chckGatilhoVenda);
            this.gbOutros.Location = new System.Drawing.Point(39, 263);
            this.gbOutros.Name = "gbOutros";
            this.gbOutros.Size = new System.Drawing.Size(794, 268);
            this.gbOutros.TabIndex = 21;
            this.gbOutros.TabStop = false;
            this.gbOutros.Text = "Valores:";
            // 
            // btnCriarCampanha
            // 
            this.btnCriarCampanha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarCampanha.Location = new System.Drawing.Point(1309, 494);
            this.btnCriarCampanha.Name = "btnCriarCampanha";
            this.btnCriarCampanha.Size = new System.Drawing.Size(159, 37);
            this.btnCriarCampanha.TabIndex = 22;
            this.btnCriarCampanha.Text = "Criar Campanha";
            this.btnCriarCampanha.UseVisualStyleBackColor = true;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalhes.Location = new System.Drawing.Point(14, 794);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(115, 37);
            this.btnDetalhes.TabIndex = 23;
            this.btnDetalhes.Text = "Visualizar";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            // 
            // btnAtualizaVisualizacao
            // 
            this.btnAtualizaVisualizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtualizaVisualizacao.Location = new System.Drawing.Point(156, 794);
            this.btnAtualizaVisualizacao.Name = "btnAtualizaVisualizacao";
            this.btnAtualizaVisualizacao.Size = new System.Drawing.Size(159, 37);
            this.btnAtualizaVisualizacao.TabIndex = 24;
            this.btnAtualizaVisualizacao.Text = "Atualizar Visualização";
            this.btnAtualizaVisualizacao.UseVisualStyleBackColor = true;
            // 
            // dvgCampanhas
            // 
            this.dvgCampanhas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCampanhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCampanhas.Location = new System.Drawing.Point(14, 586);
            this.dvgCampanhas.Name = "dvgCampanhas";
            this.dvgCampanhas.RowHeadersWidth = 51;
            this.dvgCampanhas.RowTemplate.Height = 24;
            this.dvgCampanhas.Size = new System.Drawing.Size(1483, 172);
            this.dvgCampanhas.TabIndex = 5;
            // 
            // CriaCampanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 843);
            this.Controls.Add(this.btnAtualizaVisualizacao);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.dvgCampanhas);
            this.Controls.Add(this.gbMain);
            this.Name = "CriaCampanha";
            this.Text = "CriaCampanha";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbDataApurcao.ResumeLayout(false);
            this.gbDataApurcao.PerformLayout();
            this.gbMecanica.ResumeLayout(false);
            this.gbMecanica.PerformLayout();
            this.gbOutros.ResumeLayout(false);
            this.gbOutros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCampanhas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNomeCampanha;
        private System.Windows.Forms.DateTimePicker dtInicioApuracao;
        private System.Windows.Forms.DateTimePicker dtFimApuracao;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lbDataApuracao;
        private System.Windows.Forms.TextBox tbApuracao;
        private System.Windows.Forms.TextBox tbCalculo;
        private System.Windows.Forms.GroupBox gbDataApurcao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMecanica;
        private System.Windows.Forms.CheckBox chckRegraValidacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbObservação;
        private System.Windows.Forms.Label lbGatilhoVenda;
        private System.Windows.Forms.TextBox tbGatilhoVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGatilhoPositivacao;
        private System.Windows.Forms.TextBox tbMeta;
        private System.Windows.Forms.Label lbTipoValor;
        private System.Windows.Forms.ComboBox cbValores;
        private System.Windows.Forms.GroupBox gbOutros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chckbGatilhoPositivacao;
        private System.Windows.Forms.CheckBox chckGatilhoVenda;
        private System.Windows.Forms.Button btnCriarCampanha;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgCampanhas;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnAtualizaVisualizacao;
    }
}