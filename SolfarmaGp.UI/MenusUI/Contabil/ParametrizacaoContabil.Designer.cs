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
            textBox1 = new TextBox();
            cbTipoPesquisa = new ComboBox();
            groupBox1 = new GroupBox();
            btnFiltrar = new Button();
            lbValor = new Label();
            lbCbTipoFiltro = new Label();
            tbValorPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgParametrizacao).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dvgParametrizacao
            // 
            dvgParametrizacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgParametrizacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgParametrizacao.ColumnHeadersHeight = 29;
            dvgParametrizacao.Location = new Point(12, 211);
            dvgParametrizacao.Name = "dvgParametrizacao";
            dvgParametrizacao.RowHeadersWidth = 51;
            dvgParametrizacao.Size = new Size(1133, 617);
            dvgParametrizacao.TabIndex = 0;
            dvgParametrizacao.DefaultValuesNeeded += dvgParametrizacao_DefaultValuesNeeded;
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
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 857);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 27);
            textBox1.TabIndex = 3;
            // 
            // cbTipoPesquisa
            // 
            cbTipoPesquisa.FormattingEnabled = true;
            cbTipoPesquisa.Location = new Point(18, 66);
            cbTipoPesquisa.Name = "cbTipoPesquisa";
            cbTipoPesquisa.Size = new Size(131, 28);
            cbTipoPesquisa.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(lbValor);
            groupBox1.Controls.Add(lbCbTipoFiltro);
            groupBox1.Controls.Add(tbValorPesquisa);
            groupBox1.Controls.Add(cbTipoPesquisa);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1133, 193);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
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
            lbValor.Location = new Point(18, 112);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(126, 20);
            lbValor.TabIndex = 7;
            lbValor.Text = "Valor de pesquisa";
            // 
            // lbCbTipoFiltro
            // 
            lbCbTipoFiltro.AutoSize = true;
            lbCbTipoFiltro.Location = new Point(18, 34);
            lbCbTipoFiltro.Name = "lbCbTipoFiltro";
            lbCbTipoFiltro.Size = new Size(125, 20);
            lbCbTipoFiltro.TabIndex = 6;
            lbCbTipoFiltro.Text = "Tipo de pesquisa:";
            // 
            // tbValorPesquisa
            // 
            tbValorPesquisa.Location = new Point(18, 139);
            tbValorPesquisa.Name = "tbValorPesquisa";
            tbValorPesquisa.Size = new Size(173, 27);
            tbValorPesquisa.TabIndex = 5;
            // 
            // ParametrizacaoContabil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 910);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(btnAdicionaLinha);
            Controls.Add(btnAddItem);
            Controls.Add(dvgParametrizacao);
            Name = "ParametrizacaoContabil";
            Text = "ParametrizacaoContabil";
            Load += ParametrizacaoContabil_Load;
            ((System.ComponentModel.ISupportInitialize)dvgParametrizacao).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentesTelaUI.DataGridView.MyDataGridView dvgParametrizacao;
        private Label label1;
        private Button btnAddItem;
        private Button btnAdicionaLinha;
        private TextBox textBox1;
        private ComboBox cbTipoPesquisa;
        private GroupBox groupBox1;
        private Label lbValor;
        private Label lbCbTipoFiltro;
        private TextBox tbValorPesquisa;
        private Button btnFiltrar;
    }
}