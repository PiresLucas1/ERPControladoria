namespace SolfarmaGp.UI.MenusUI.Contabil
{
    partial class ParametrizacaoContabil
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
            dvgParametrizacao = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            btnAddItem = new Button();
            btnAdicionaLinha = new Button();
            tbCount = new TextBox();
            cbTipoPesquisa = new ComboBox();
            gpGeral = new GroupBox();
            lbCodColigada = new Label();
            cbColigada = new ComboBox();
            btnFiltrar = new Button();
            lbValor = new Label();
            lbCbTipoFiltro = new Label();
            tbValorPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgParametrizacao).BeginInit();
            gpGeral.SuspendLayout();
            SuspendLayout();
            // 
            // dvgParametrizacao
            // 
            dvgParametrizacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgParametrizacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgParametrizacao.ColumnHeadersHeight = 29;
            dvgParametrizacao.Location = new Point(12, 211);
            dvgParametrizacao.Name = "dvgParametrizacao";
            dvgParametrizacao.RowHeadersVisible = false;
            dvgParametrizacao.RowHeadersWidth = 51;
            dvgParametrizacao.Size = new Size(1133, 617);
            dvgParametrizacao.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddItem.Location = new Point(345, 851);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(131, 39);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Adicionar Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnAdicionaLinha
            // 
            btnAdicionaLinha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdicionaLinha.Location = new Point(172, 851);
            btnAdicionaLinha.Name = "btnAdicionaLinha";
            btnAdicionaLinha.Size = new Size(131, 39);
            btnAdicionaLinha.TabIndex = 2;
            btnAdicionaLinha.Text = "Incluir Linha";
            btnAdicionaLinha.UseVisualStyleBackColor = true;
            btnAdicionaLinha.Click += btnAdicionaLinha_Click;
            // 
            // tbCount
            // 
            tbCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbCount.BackColor = SystemColors.ScrollBar;
            tbCount.Enabled = false;
            tbCount.Location = new Point(12, 857);
            tbCount.Name = "tbCount";
            tbCount.Size = new Size(122, 27);
            tbCount.TabIndex = 3;
            // 
            // cbTipoPesquisa
            // 
            cbTipoPesquisa.FormattingEnabled = true;
            cbTipoPesquisa.Location = new Point(6, 138);
            cbTipoPesquisa.Name = "cbTipoPesquisa";
            cbTipoPesquisa.Size = new Size(131, 28);
            cbTipoPesquisa.TabIndex = 4;
            // 
            // gpGeral
            // 
            gpGeral.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpGeral.Controls.Add(lbCodColigada);
            gpGeral.Controls.Add(cbColigada);
            gpGeral.Controls.Add(btnFiltrar);
            gpGeral.Controls.Add(lbValor);
            gpGeral.Controls.Add(lbCbTipoFiltro);
            gpGeral.Controls.Add(tbValorPesquisa);
            gpGeral.Controls.Add(cbTipoPesquisa);
            gpGeral.Location = new Point(12, 12);
            gpGeral.Name = "gpGeral";
            gpGeral.Size = new Size(1133, 193);
            gpGeral.TabIndex = 5;
            gpGeral.TabStop = false;
            gpGeral.Text = "Geral";
            // 
            // lbCodColigada
            // 
            lbCodColigada.AutoSize = true;
            lbCodColigada.Location = new Point(6, 32);
            lbCodColigada.Name = "lbCodColigada";
            lbCodColigada.Size = new Size(72, 20);
            lbCodColigada.TabIndex = 10;
            lbCodColigada.Text = "Coligada:";
            // 
            // cbColigada
            // 
            cbColigada.FormattingEnabled = true;
            cbColigada.Location = new Point(6, 65);
            cbColigada.Name = "cbColigada";
            cbColigada.Size = new Size(131, 28);
            cbColigada.TabIndex = 9;
            cbColigada.SelectedValueChanged += cbColigada_SelectedValueChanged;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrar.Location = new Point(978, 127);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(131, 39);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(160, 111);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(126, 20);
            lbValor.TabIndex = 7;
            lbValor.Text = "Valor de pesquisa";
            // 
            // lbCbTipoFiltro
            // 
            lbCbTipoFiltro.AutoSize = true;
            lbCbTipoFiltro.Location = new Point(6, 106);
            lbCbTipoFiltro.Name = "lbCbTipoFiltro";
            lbCbTipoFiltro.Size = new Size(125, 20);
            lbCbTipoFiltro.TabIndex = 6;
            lbCbTipoFiltro.Text = "Tipo de pesquisa:";
            // 
            // tbValorPesquisa
            // 
            tbValorPesquisa.Location = new Point(160, 138);
            tbValorPesquisa.Name = "tbValorPesquisa";
            tbValorPesquisa.Size = new Size(173, 27);
            tbValorPesquisa.TabIndex = 5;
            // 
            // ParametrizacaoContabil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 910);
            Controls.Add(gpGeral);
            Controls.Add(tbCount);
            Controls.Add(btnAdicionaLinha);
            Controls.Add(btnAddItem);
            Controls.Add(dvgParametrizacao);
            Name = "ParametrizacaoContabil";
            Text = "ParametrizacaoContabil";
            Load += ParametrizacaoContabil_Load;
            ((System.ComponentModel.ISupportInitialize)dvgParametrizacao).EndInit();
            gpGeral.ResumeLayout(false);
            gpGeral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentesTelaUI.DataGridView.MyDataGridView dvgParametrizacao;
        private Label label1;
        private Button btnAddItem;
        private Button btnAdicionaLinha;
        private TextBox tbCount;
        private ComboBox cbTipoPesquisa;
        private GroupBox gpGeral;
        private Label lbValor;
        private Label lbCbTipoFiltro;
        private TextBox tbValorPesquisa;
        private Button btnFiltrar;
        private Label lbCodColigada;
        private ComboBox cbColigada;
    }
}