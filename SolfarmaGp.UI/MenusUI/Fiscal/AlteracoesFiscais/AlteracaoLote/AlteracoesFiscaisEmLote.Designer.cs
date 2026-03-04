namespace SolfarmaGp.UI.MenusUI.Fiscal.AlteracoesFiscais.AlteracaoLote
{
    partial class AlteracoesFiscaisEmLote
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtFiltroInput = new RichTextBox();
            lblFiltro = new Label();
            gpFiltro = new GroupBox();
            label3 = new Label();
            cbColigada = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dtFim = new DateTimePicker();
            dtInicio = new DateTimePicker();
            btnConsultar = new Button();
            gbTipoAlteracao = new GroupBox();
            rbAlteraDataDocumento = new RadioButton();
            rbAlteraCodTmtv = new RadioButton();
            btnAlteraCodMovimento = new Button();
            groupBox1 = new GroupBox();
            btnAlteraDataDocumento = new Button();
            btnAlterarSelecionados = new Button();
            button1 = new Button();
            btnSelecionarTudo = new Button();
            txtCountRows = new TextBox();
            dvgIDMovs = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            gpFiltro.SuspendLayout();
            gbTipoAlteracao.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgIDMovs).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtFiltroInput
            // 
            txtFiltroInput.Location = new Point(657, 44);
            txtFiltroInput.Margin = new Padding(3, 2, 3, 2);
            txtFiltroInput.Name = "txtFiltroInput";
            txtFiltroInput.Size = new Size(586, 94);
            txtFiltroInput.TabIndex = 2;
            txtFiltroInput.Text = "";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(661, 18);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(312, 20);
            lblFiltro.TabIndex = 3;
            lblFiltro.Text = "Insira os IDMOV  separado por \",\" para buscar";
            // 
            // gpFiltro
            // 
            gpFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpFiltro.Controls.Add(label3);
            gpFiltro.Controls.Add(cbColigada);
            gpFiltro.Controls.Add(label2);
            gpFiltro.Controls.Add(label1);
            gpFiltro.Controls.Add(dtFim);
            gpFiltro.Controls.Add(dtInicio);
            gpFiltro.Controls.Add(btnConsultar);
            gpFiltro.Controls.Add(txtFiltroInput);
            gpFiltro.Controls.Add(lblFiltro);
            gpFiltro.Controls.Add(gbTipoAlteracao);
            gpFiltro.Location = new Point(11, 14);
            gpFiltro.Margin = new Padding(3, 2, 3, 2);
            gpFiltro.Name = "gpFiltro";
            gpFiltro.Padding = new Padding(3, 2, 3, 2);
            gpFiltro.Size = new Size(1395, 166);
            gpFiltro.TabIndex = 4;
            gpFiltro.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 31);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 15;
            label3.Text = "Cod. Coligada";
            // 
            // cbColigada
            // 
            cbColigada.FormattingEnabled = true;
            cbColigada.Location = new Point(287, 68);
            cbColigada.Margin = new Padding(3, 4, 3, 4);
            cbColigada.Name = "cbColigada";
            cbColigada.Size = new Size(121, 28);
            cbColigada.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 94);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 13;
            label2.Text = "Data Fim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 21);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 12;
            label1.Text = "Data Inicio";
            // 
            // dtFim
            // 
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(445, 121);
            dtFim.Margin = new Padding(3, 4, 3, 4);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(134, 27);
            dtFim.TabIndex = 11;
            // 
            // dtInicio
            // 
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(445, 50);
            dtInicio.Margin = new Padding(3, 4, 3, 4);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(134, 27);
            dtInicio.TabIndex = 10;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.Location = new Point(1272, 105);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(108, 34);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // gbTipoAlteracao
            // 
            gbTipoAlteracao.Controls.Add(rbAlteraDataDocumento);
            gbTipoAlteracao.Controls.Add(rbAlteraCodTmtv);
            gbTipoAlteracao.Location = new Point(7, 20);
            gbTipoAlteracao.Margin = new Padding(3, 4, 3, 4);
            gbTipoAlteracao.Name = "gbTipoAlteracao";
            gbTipoAlteracao.Padding = new Padding(3, 4, 3, 4);
            gbTipoAlteracao.Size = new Size(251, 141);
            gbTipoAlteracao.TabIndex = 9;
            gbTipoAlteracao.TabStop = false;
            gbTipoAlteracao.Text = "Alterações";
            // 
            // rbAlteraDataDocumento
            // 
            rbAlteraDataDocumento.AutoSize = true;
            rbAlteraDataDocumento.Location = new Point(8, 81);
            rbAlteraDataDocumento.Margin = new Padding(3, 4, 3, 4);
            rbAlteraDataDocumento.Name = "rbAlteraDataDocumento";
            rbAlteraDataDocumento.Size = new Size(165, 24);
            rbAlteraDataDocumento.TabIndex = 8;
            rbAlteraDataDocumento.TabStop = true;
            rbAlteraDataDocumento.Text = "Data de Documento";
            rbAlteraDataDocumento.TextAlign = ContentAlignment.MiddleCenter;
            rbAlteraDataDocumento.UseVisualStyleBackColor = true;
            rbAlteraDataDocumento.CheckedChanged += rbAlteraDataDocumento_CheckedChanged;
            // 
            // rbAlteraCodTmtv
            // 
            rbAlteraCodTmtv.AutoSize = true;
            rbAlteraCodTmtv.Location = new Point(8, 36);
            rbAlteraCodTmtv.Margin = new Padding(3, 4, 3, 4);
            rbAlteraCodTmtv.Name = "rbAlteraCodTmtv";
            rbAlteraCodTmtv.Size = new Size(102, 24);
            rbAlteraCodTmtv.TabIndex = 7;
            rbAlteraCodTmtv.TabStop = true;
            rbAlteraCodTmtv.Text = "Cod. TMTV";
            rbAlteraCodTmtv.TextAlign = ContentAlignment.MiddleCenter;
            rbAlteraCodTmtv.UseVisualStyleBackColor = true;
            rbAlteraCodTmtv.CheckedChanged += rbAlteraCodTmtv_CheckedChanged;
            // 
            // btnAlteraCodMovimento
            // 
            btnAlteraCodMovimento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlteraCodMovimento.Location = new Point(1151, 84);
            btnAlteraCodMovimento.Margin = new Padding(3, 2, 3, 2);
            btnAlteraCodMovimento.Name = "btnAlteraCodMovimento";
            btnAlteraCodMovimento.Size = new Size(203, 38);
            btnAlteraCodMovimento.TabIndex = 7;
            btnAlteraCodMovimento.Text = "Alterar Cód Movimento";
            btnAlteraCodMovimento.UseVisualStyleBackColor = true;
            btnAlteraCodMovimento.Click += btnAlteraCodMovimento_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnAlteraDataDocumento);
            groupBox1.Controls.Add(btnAlterarSelecionados);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnAlteraCodMovimento);
            groupBox1.Controls.Add(btnSelecionarTudo);
            groupBox1.Controls.Add(txtCountRows);
            groupBox1.Location = new Point(12, 856);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1394, 142);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnAlteraDataDocumento
            // 
            btnAlteraDataDocumento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlteraDataDocumento.Location = new Point(1151, 24);
            btnAlteraDataDocumento.Margin = new Padding(3, 2, 3, 2);
            btnAlteraDataDocumento.Name = "btnAlteraDataDocumento";
            btnAlteraDataDocumento.Size = new Size(203, 46);
            btnAlteraDataDocumento.TabIndex = 11;
            btnAlteraDataDocumento.Text = "Alterar Data Documento";
            btnAlteraDataDocumento.UseVisualStyleBackColor = true;
            btnAlteraDataDocumento.Click += btnAlteraDataDocumento_Click;
            // 
            // btnAlterarSelecionados
            // 
            btnAlterarSelecionados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAlterarSelecionados.Location = new Point(180, 88);
            btnAlterarSelecionados.Margin = new Padding(3, 2, 3, 2);
            btnAlterarSelecionados.Name = "btnAlterarSelecionados";
            btnAlterarSelecionados.Size = new Size(134, 34);
            btnAlterarSelecionados.TabIndex = 8;
            btnAlterarSelecionados.Text = "Alt. Selecionados";
            btnAlterarSelecionados.UseVisualStyleBackColor = true;
            btnAlterarSelecionados.Click += btnAlterarSelecionados_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(180, 45);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(134, 34);
            button1.TabIndex = 10;
            button1.Text = "Limpar seleção";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSelecionarTudo
            // 
            btnSelecionarTudo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSelecionarTudo.Location = new Point(18, 45);
            btnSelecionarTudo.Margin = new Padding(3, 2, 3, 2);
            btnSelecionarTudo.Name = "btnSelecionarTudo";
            btnSelecionarTudo.Size = new Size(134, 34);
            btnSelecionarTudo.TabIndex = 9;
            btnSelecionarTudo.Text = "Selecionar  tudo";
            btnSelecionarTudo.UseVisualStyleBackColor = true;
            btnSelecionarTudo.Click += btnSelecionarTudo_Click;
            // 
            // txtCountRows
            // 
            txtCountRows.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtCountRows.BackColor = SystemColors.ScrollBar;
            txtCountRows.Location = new Point(18, 96);
            txtCountRows.Margin = new Padding(3, 2, 3, 2);
            txtCountRows.Name = "txtCountRows";
            txtCountRows.Size = new Size(135, 27);
            txtCountRows.TabIndex = 10;
            // 
            // dvgIDMovs
            // 
            dvgIDMovs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgIDMovs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgIDMovs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgIDMovs.Location = new Point(11, 185);
            dvgIDMovs.Margin = new Padding(3, 2, 3, 2);
            dvgIDMovs.Name = "dvgIDMovs";
            dvgIDMovs.RowHeadersWidth = 62;
            dvgIDMovs.RowTemplate.Height = 28;
            dvgIDMovs.Size = new Size(1395, 666);
            dvgIDMovs.TabIndex = 5;
            // 
            // AlteracoesFiscaisEmLote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 1012);
            Controls.Add(dvgIDMovs);
            Controls.Add(gpFiltro);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AlteracoesFiscaisEmLote";
            Text = "AlterarTipoMovimentoLista";
            gpFiltro.ResumeLayout(false);
            gpFiltro.PerformLayout();
            gbTipoAlteracao.ResumeLayout(false);
            gbTipoAlteracao.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgIDMovs).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox txtFiltroInput;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.GroupBox gpFiltro;
        private SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView dvgIDMovs;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlteraCodMovimento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlterarSelecionados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelecionarTudo;
        private System.Windows.Forms.TextBox txtCountRows;
        private System.Windows.Forms.GroupBox gbTipoAlteracao;
        private System.Windows.Forms.RadioButton rbAlteraDataDocumento;
        private System.Windows.Forms.RadioButton rbAlteraCodTmtv;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbColigada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlteraDataDocumento;
    }
}