using SolfarmaGp.UI.ComponentesTelaUI.Moderno;

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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dvgParametrizacao = new GradeModerna();
            btnAddItem = new BotaoModerno();
            tbCount = new TextBox();
            gpGeral = new CartaoGroupBox();
            cbBanco = new ComboBox();
            btnLimpaFiltro = new Button();
            tbReduzidoCredito = new TextBox();
            tbReduzidoDebito = new TextBox();
            lbCredito = new Label();
            blContaDebito = new Label();
            lbBanco = new Label();
            tbFilial = new TextBox();
            lbCodColigada = new Label();
            cbColigada = new ComboBox();
            btnFiltrar = new BotaoModerno();
            lbFilial = new Label();
            btnSalvaParametros = new BotaoModerno();
            btnExcluir = new BotaoModerno();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dvgParametrizacao).BeginInit();
            gpGeral.SuspendLayout();
            SuspendLayout();
            // 
            // dvgParametrizacao
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(250, 251, 252);
            dvgParametrizacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dvgParametrizacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgParametrizacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgParametrizacao.BackgroundColor = Color.White;
            dvgParametrizacao.BorderStyle = BorderStyle.None;
            dvgParametrizacao.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgParametrizacao.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(245, 246, 248);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(245, 246, 248);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dvgParametrizacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dvgParametrizacao.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(253, 232, 220);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dvgParametrizacao.DefaultCellStyle = dataGridViewCellStyle6;
            dvgParametrizacao.EnableHeadersVisualStyles = false;
            dvgParametrizacao.GridColor = Color.FromArgb(235, 237, 240);
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
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Location = new Point(329, 851);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Principal = false;
            btnAddItem.Raio = 8;
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
            gpGeral.BackColor = Color.White;
            gpGeral.Controls.Add(cbBanco);
            gpGeral.Controls.Add(btnLimpaFiltro);
            gpGeral.Controls.Add(tbReduzidoCredito);
            gpGeral.Controls.Add(tbReduzidoDebito);
            gpGeral.Controls.Add(lbCredito);
            gpGeral.Controls.Add(blContaDebito);
            gpGeral.Controls.Add(lbBanco);
            gpGeral.Controls.Add(tbFilial);
            gpGeral.Controls.Add(lbCodColigada);
            gpGeral.Controls.Add(cbColigada);
            gpGeral.Controls.Add(btnFiltrar);
            gpGeral.Controls.Add(lbFilial);
            gpGeral.CorBorda = Color.FromArgb(222, 225, 230);
            gpGeral.Location = new Point(12, 12);
            gpGeral.Name = "gpGeral";
            gpGeral.Raio = 10;
            gpGeral.Size = new Size(1133, 193);
            gpGeral.TabIndex = 5;
            gpGeral.TabStop = false;
            gpGeral.Text = "Geral";
            // 
            // cbBanco
            // 
            cbBanco.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBanco.FormattingEnabled = true;
            cbBanco.Location = new Point(270, 64);
            cbBanco.Name = "cbBanco";
            cbBanco.Size = new Size(151, 28);
            cbBanco.TabIndex = 19;
            // 
            // btnLimpaFiltro
            // 
            btnLimpaFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpaFiltro.BackgroundImage = Properties.Resources.trash_solid;
            btnLimpaFiltro.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpaFiltro.Location = new Point(934, 124);
            btnLimpaFiltro.Name = "btnLimpaFiltro";
            btnLimpaFiltro.Size = new Size(38, 39);
            btnLimpaFiltro.TabIndex = 18;
            btnLimpaFiltro.UseVisualStyleBackColor = true;
            btnLimpaFiltro.Click += btnLimpaFiltro_Click;
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
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Location = new Point(978, 124);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Principal = false;
            btnFiltrar.Raio = 8;
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
            btnSalvaParametros.FlatStyle = FlatStyle.Flat;
            btnSalvaParametros.Location = new Point(956, 851);
            btnSalvaParametros.Name = "btnSalvaParametros";
            btnSalvaParametros.Principal = true;
            btnSalvaParametros.Raio = 8;
            btnSalvaParametros.Size = new Size(165, 39);
            btnSalvaParametros.TabIndex = 6;
            btnSalvaParametros.Text = "Salvar Parametrização";
            btnSalvaParametros.UseVisualStyleBackColor = true;
            btnSalvaParametros.Click += btnSalvaParametros_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Location = new Point(179, 851);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Principal = false;
            btnExcluir.Raio = 8;
            btnExcluir.Size = new Size(131, 39);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir item";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolTip1
            // 
            toolTip1.Tag = "Limpar Filtro";
            // 
            // ParametrizacaoContabil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1160, 910);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvaParametros);
            Controls.Add(gpGeral);
            Controls.Add(tbCount);
            Controls.Add(btnAddItem);
            Controls.Add(dvgParametrizacao);
            Name = "ParametrizacaoContabil";
            ShowIcon = false;
            Text = "Parametrizacao Contabil";
            Load += ParametrizacaoContabil_Load;
            ((System.ComponentModel.ISupportInitialize)dvgParametrizacao).EndInit();
            gpGeral.ResumeLayout(false);
            gpGeral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradeModerna dvgParametrizacao;
        private Label label1;
        private BotaoModerno btnAddItem;
        private TextBox tbCount;
        private ComboBox cbTipoPesquisa;
        private CartaoGroupBox gpGeral;
        private Label lbValor;
        private Label lbFilial;
        private TextBox tbValorPesquisa;
        private BotaoModerno btnFiltrar;
        private Label lbCodColigada;
        private ComboBox cbColigada;
        private BotaoModerno btnSalvaParametros;
        private TextBox tbFilial;
        private TextBox tbReduzidoCredito;
        private TextBox tbReduzidoDebito;
        private Label lbCredito;
        private Label blContaDebito;
        private Label lbBanco;
        private BotaoModerno btnExcluir;
        private Button btnLimpaFiltro;
        private ToolTip toolTip1;
        private ComboBox cbBanco;
    }
}