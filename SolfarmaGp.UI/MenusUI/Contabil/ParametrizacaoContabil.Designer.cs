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
            tbCount = new TextBox();
            gpGeral = new GroupBox();
            tbReduzidoCredito = new TextBox();
            tbReduzidoDebito = new TextBox();
            lbCredito = new Label();
            blContaDebito = new Label();
            lbBanco = new Label();
            tbBanco = new TextBox();
            tbFilial = new TextBox();
            lbCodColigada = new Label();
            cbColigada = new ComboBox();
            btnFiltrar = new Button();
            lbFilial = new Label();
            btnSalvaParametros = new Button();
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
            dvgParametrizacao.CellDoubleClick += dvgParametrizacao_CellDoubleClick;
            dvgParametrizacao.CellEndEdit += dvgParametrizacao_CellEndEdit;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddItem.Location = new Point(188, 851);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(131, 39);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Adicionar Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
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
            // gpGeral
            // 
            gpGeral.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpGeral.Controls.Add(tbReduzidoCredito);
            gpGeral.Controls.Add(tbReduzidoDebito);
            gpGeral.Controls.Add(lbCredito);
            gpGeral.Controls.Add(blContaDebito);
            gpGeral.Controls.Add(lbBanco);
            gpGeral.Controls.Add(tbBanco);
            gpGeral.Controls.Add(tbFilial);
            gpGeral.Controls.Add(lbCodColigada);
            gpGeral.Controls.Add(cbColigada);
            gpGeral.Controls.Add(btnFiltrar);
            gpGeral.Controls.Add(lbFilial);
            gpGeral.Location = new Point(12, 12);
            gpGeral.Name = "gpGeral";
            gpGeral.Size = new Size(1133, 193);
            gpGeral.TabIndex = 5;
            gpGeral.TabStop = false;
            gpGeral.Text = "Geral";
            // 
            // tbReduzidoCredito
            // 
            tbReduzidoCredito.Location = new Point(505, 148);
            tbReduzidoCredito.Name = "tbReduzidoCredito";
            tbReduzidoCredito.Size = new Size(139, 27);
            tbReduzidoCredito.TabIndex = 17;
            // 
            // tbReduzidoDebito
            // 
            tbReduzidoDebito.Location = new Point(270, 148);
            tbReduzidoDebito.Name = "tbReduzidoDebito";
            tbReduzidoDebito.Size = new Size(139, 27);
            tbReduzidoDebito.TabIndex = 16;
            // 
            // lbCredito
            // 
            lbCredito.AutoSize = true;
            lbCredito.Location = new Point(505, 115);
            lbCredito.Name = "lbCredito";
            lbCredito.Size = new Size(128, 20);
            lbCredito.TabIndex = 15;
            lbCredito.Text = "Reduzido Crédito:";
            // 
            // blContaDebito
            // 
            blContaDebito.AutoSize = true;
            blContaDebito.Location = new Point(270, 115);
            blContaDebito.Name = "blContaDebito";
            blContaDebito.Size = new Size(125, 20);
            blContaDebito.TabIndex = 14;
            blContaDebito.Text = "Reduzido Débito:";
            // 
            // lbBanco
            // 
            lbBanco.AutoSize = true;
            lbBanco.Location = new Point(270, 31);
            lbBanco.Name = "lbBanco";
            lbBanco.Size = new Size(53, 20);
            lbBanco.TabIndex = 13;
            lbBanco.Text = "Banco:";
            // 
            // tbBanco
            // 
            tbBanco.Location = new Point(270, 64);
            tbBanco.Name = "tbBanco";
            tbBanco.Size = new Size(139, 27);
            tbBanco.TabIndex = 12;
            // 
            // tbFilial
            // 
            tbFilial.Location = new Point(29, 148);
            tbFilial.Name = "tbFilial";
            tbFilial.Size = new Size(139, 27);
            tbFilial.TabIndex = 11;
            // 
            // lbCodColigada
            // 
            lbCodColigada.AutoSize = true;
            lbCodColigada.Location = new Point(29, 31);
            lbCodColigada.Name = "lbCodColigada";
            lbCodColigada.Size = new Size(72, 20);
            lbCodColigada.TabIndex = 10;
            lbCodColigada.Text = "Coligada:";
            // 
            // cbColigada
            // 
            cbColigada.FormattingEnabled = true;
            cbColigada.Location = new Point(29, 64);
            cbColigada.Name = "cbColigada";
            cbColigada.Size = new Size(131, 28);
            cbColigada.TabIndex = 9;
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
            // lbFilial
            // 
            lbFilial.AutoSize = true;
            lbFilial.Location = new Point(29, 115);
            lbFilial.Name = "lbFilial";
            lbFilial.Size = new Size(43, 20);
            lbFilial.TabIndex = 6;
            lbFilial.Text = "Filial:";
            // 
            // btnSalvaParametros
            // 
            btnSalvaParametros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvaParametros.Location = new Point(956, 851);
            btnSalvaParametros.Name = "btnSalvaParametros";
            btnSalvaParametros.Size = new Size(165, 39);
            btnSalvaParametros.TabIndex = 6;
            btnSalvaParametros.Text = "Salvar Parametrização";
            btnSalvaParametros.UseVisualStyleBackColor = true;
            btnSalvaParametros.Click += btnSalvaParametros_Click;
            // 
            // ParametrizacaoContabil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 910);
            Controls.Add(btnSalvaParametros);
            Controls.Add(gpGeral);
            Controls.Add(tbCount);
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
        private TextBox tbCount;
        private ComboBox cbTipoPesquisa;
        private GroupBox gpGeral;
        private Label lbValor;
        private Label lbFilial;
        private TextBox tbValorPesquisa;
        private Button btnFiltrar;
        private Label lbCodColigada;
        private ComboBox cbColigada;
        private Button btnSalvaParametros;
        private TextBox tbBanco;
        private TextBox tbFilial;
        private TextBox tbReduzidoCredito;
        private TextBox tbReduzidoDebito;
        private Label lbCredito;
        private Label blContaDebito;
        private Label lbBanco;
    }
}