namespace ERP_FISCAL.view.FiscalView
{
    partial class AlterarTipoMovimentoLista
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtFiltroInput = new System.Windows.Forms.RichTextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.gpFiltro = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbTipoAlteracao = new System.Windows.Forms.GroupBox();
            this.rbAlteraDataDocumento = new System.Windows.Forms.RadioButton();
            this.rbAlteraCodTmtv = new System.Windows.Forms.RadioButton();
            this.btnAlteraCodMovimento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlterarSelecionados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelecionarTudo = new System.Windows.Forms.Button();
            this.txtCountRows = new System.Windows.Forms.TextBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbColigada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dvgIDMovs = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.btnAlteraDataDocumento = new System.Windows.Forms.Button();
            this.gpFiltro.SuspendLayout();
            this.gbTipoAlteracao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIDMovs)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtFiltroInput
            // 
            this.txtFiltroInput.Location = new System.Drawing.Point(657, 35);
            this.txtFiltroInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroInput.Name = "txtFiltroInput";
            this.txtFiltroInput.Size = new System.Drawing.Size(586, 76);
            this.txtFiltroInput.TabIndex = 2;
            this.txtFiltroInput.Text = "";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(661, 14);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(282, 16);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Insira os IDMOV  separado por \",\" para buscar";
            // 
            // gpFiltro
            // 
            this.gpFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpFiltro.Controls.Add(this.label3);
            this.gpFiltro.Controls.Add(this.cbColigada);
            this.gpFiltro.Controls.Add(this.label2);
            this.gpFiltro.Controls.Add(this.label1);
            this.gpFiltro.Controls.Add(this.dtFim);
            this.gpFiltro.Controls.Add(this.dtInicio);
            this.gpFiltro.Controls.Add(this.btnConsultar);
            this.gpFiltro.Controls.Add(this.txtFiltroInput);
            this.gpFiltro.Controls.Add(this.lblFiltro);
            this.gpFiltro.Controls.Add(this.gbTipoAlteracao);
            this.gpFiltro.Location = new System.Drawing.Point(11, 11);
            this.gpFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpFiltro.Name = "gpFiltro";
            this.gpFiltro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpFiltro.Size = new System.Drawing.Size(1395, 133);
            this.gpFiltro.TabIndex = 4;
            this.gpFiltro.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(1272, 84);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(108, 27);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbTipoAlteracao
            // 
            this.gbTipoAlteracao.Controls.Add(this.rbAlteraDataDocumento);
            this.gbTipoAlteracao.Controls.Add(this.rbAlteraCodTmtv);
            this.gbTipoAlteracao.Location = new System.Drawing.Point(7, 16);
            this.gbTipoAlteracao.Name = "gbTipoAlteracao";
            this.gbTipoAlteracao.Size = new System.Drawing.Size(251, 113);
            this.gbTipoAlteracao.TabIndex = 9;
            this.gbTipoAlteracao.TabStop = false;
            this.gbTipoAlteracao.Text = "Alterações";
            // 
            // rbAlteraDataDocumento
            // 
            this.rbAlteraDataDocumento.AutoSize = true;
            this.rbAlteraDataDocumento.Location = new System.Drawing.Point(8, 65);
            this.rbAlteraDataDocumento.Name = "rbAlteraDataDocumento";
            this.rbAlteraDataDocumento.Size = new System.Drawing.Size(148, 20);
            this.rbAlteraDataDocumento.TabIndex = 8;
            this.rbAlteraDataDocumento.TabStop = true;
            this.rbAlteraDataDocumento.Text = "Data de Documento";
            this.rbAlteraDataDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAlteraDataDocumento.UseVisualStyleBackColor = true;
            this.rbAlteraDataDocumento.CheckedChanged += new System.EventHandler(this.rbAlteraDataDocumento_CheckedChanged);
            // 
            // rbAlteraCodTmtv
            // 
            this.rbAlteraCodTmtv.AutoSize = true;
            this.rbAlteraCodTmtv.Location = new System.Drawing.Point(8, 29);
            this.rbAlteraCodTmtv.Name = "rbAlteraCodTmtv";
            this.rbAlteraCodTmtv.Size = new System.Drawing.Size(97, 20);
            this.rbAlteraCodTmtv.TabIndex = 7;
            this.rbAlteraCodTmtv.TabStop = true;
            this.rbAlteraCodTmtv.Text = "Cod. TMTV";
            this.rbAlteraCodTmtv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAlteraCodTmtv.UseVisualStyleBackColor = true;
            this.rbAlteraCodTmtv.CheckedChanged += new System.EventHandler(this.rbAlteraCodTmtv_CheckedChanged);
            // 
            // btnAlteraCodMovimento
            // 
            this.btnAlteraCodMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlteraCodMovimento.Location = new System.Drawing.Point(1192, 70);
            this.btnAlteraCodMovimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlteraCodMovimento.Name = "btnAlteraCodMovimento";
            this.btnAlteraCodMovimento.Size = new System.Drawing.Size(162, 37);
            this.btnAlteraCodMovimento.TabIndex = 7;
            this.btnAlteraCodMovimento.Text = "Alterar Cód Movimento";
            this.btnAlteraCodMovimento.UseVisualStyleBackColor = true;
            this.btnAlteraCodMovimento.Click += new System.EventHandler(this.btnAlteraCodMovimento_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAlteraDataDocumento);
            this.groupBox1.Controls.Add(this.btnAlterarSelecionados);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAlteraCodMovimento);
            this.groupBox1.Controls.Add(this.btnSelecionarTudo);
            this.groupBox1.Controls.Add(this.txtCountRows);
            this.groupBox1.Location = new System.Drawing.Point(12, 685);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1394, 114);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnAlterarSelecionados
            // 
            this.btnAlterarSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlterarSelecionados.Location = new System.Drawing.Point(180, 70);
            this.btnAlterarSelecionados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterarSelecionados.Name = "btnAlterarSelecionados";
            this.btnAlterarSelecionados.Size = new System.Drawing.Size(134, 27);
            this.btnAlterarSelecionados.TabIndex = 8;
            this.btnAlterarSelecionados.Text = "Alt. Selecionados";
            this.btnAlterarSelecionados.UseVisualStyleBackColor = true;
            this.btnAlterarSelecionados.Click += new System.EventHandler(this.btnAlterarSelecionados_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(180, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpar seleção";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelecionarTudo
            // 
            this.btnSelecionarTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelecionarTudo.Location = new System.Drawing.Point(18, 36);
            this.btnSelecionarTudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionarTudo.Name = "btnSelecionarTudo";
            this.btnSelecionarTudo.Size = new System.Drawing.Size(134, 27);
            this.btnSelecionarTudo.TabIndex = 9;
            this.btnSelecionarTudo.Text = "Selecionar  tudo";
            this.btnSelecionarTudo.UseVisualStyleBackColor = true;
            this.btnSelecionarTudo.Click += new System.EventHandler(this.btnSelecionarTudo_Click);
            // 
            // txtCountRows
            // 
            this.txtCountRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCountRows.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCountRows.Location = new System.Drawing.Point(18, 77);
            this.txtCountRows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCountRows.Name = "txtCountRows";
            this.txtCountRows.Size = new System.Drawing.Size(135, 22);
            this.txtCountRows.TabIndex = 10;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(445, 40);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(134, 22);
            this.dtInicio.TabIndex = 10;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(445, 97);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(134, 22);
            this.dtFim.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data Fim";
            // 
            // cbColigada
            // 
            this.cbColigada.FormattingEnabled = true;
            this.cbColigada.Location = new System.Drawing.Point(287, 54);
            this.cbColigada.Name = "cbColigada";
            this.cbColigada.Size = new System.Drawing.Size(121, 24);
            this.cbColigada.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cod. Coligada";
            // 
            // dvgIDMovs
            // 
            this.dvgIDMovs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgIDMovs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgIDMovs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgIDMovs.Location = new System.Drawing.Point(11, 148);
            this.dvgIDMovs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgIDMovs.Name = "dvgIDMovs";
            this.dvgIDMovs.RowHeadersWidth = 62;
            this.dvgIDMovs.RowTemplate.Height = 28;
            this.dvgIDMovs.Size = new System.Drawing.Size(1395, 533);
            this.dvgIDMovs.TabIndex = 5;
            // 
            // btnAlteraDataDocumento
            // 
            this.btnAlteraDataDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlteraDataDocumento.Location = new System.Drawing.Point(1192, 19);
            this.btnAlteraDataDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlteraDataDocumento.Name = "btnAlteraDataDocumento";
            this.btnAlteraDataDocumento.Size = new System.Drawing.Size(162, 37);
            this.btnAlteraDataDocumento.TabIndex = 11;
            this.btnAlteraDataDocumento.Text = "Alterar Data Documento";
            this.btnAlteraDataDocumento.UseVisualStyleBackColor = true;
            this.btnAlteraDataDocumento.Click += new System.EventHandler(this.btnAlteraDataDocumento_Click);
            // 
            // AlterarTipoMovimentoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 810);
            this.Controls.Add(this.dvgIDMovs);
            this.Controls.Add(this.gpFiltro);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AlterarTipoMovimentoLista";
            this.Text = "AlterarTipoMovimentoLista";
            this.gpFiltro.ResumeLayout(false);
            this.gpFiltro.PerformLayout();
            this.gbTipoAlteracao.ResumeLayout(false);
            this.gbTipoAlteracao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIDMovs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox txtFiltroInput;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.GroupBox gpFiltro;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgIDMovs;
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