namespace SolfarmaGp.UI.MenusUI.Fiscal.ImportarNotasFiscaisXmlPataTotvs
{
    partial class ImportarNotasFiscaisXmlParaTotvsDetalhes
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
            dvgDataNotaItens = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            btnLancarNota = new Button();
            btnCancelar = new Button();
            textBox1 = new TextBox();
            lbTotalItens = new Label();
            gpFooter = new GroupBox();
            btnAbrirXml = new Button();
            btnPreencherCFOP = new Button();
            gpHeader = new GroupBox();
            tbNomeFornecedor = new TextBox();
            tbCodFornecedor = new TextBox();
            tbIdContasPagar = new TextBox();
            tbNumDoc = new TextBox();
            tbIdQive = new TextBox();
            lbChaveAcesso = new Label();
            lbNomeFornecedor = new Label();
            lbIDFornecedor = new Label();
            lbIDContasPagar = new Label();
            lbNumDoc = new Label();
            lbIDQiveArquivoXml = new Label();
            tbChaveAcesso = new TextBox();
            dvgContaFinanceira = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            gpContas = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dvgDataNotaItens).BeginInit();
            gpFooter.SuspendLayout();
            gpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgContaFinanceira).BeginInit();
            gpContas.SuspendLayout();
            SuspendLayout();
            // 
            // dvgDataNotaItens
            // 
            dvgDataNotaItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgDataNotaItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgDataNotaItens.ColumnHeadersHeight = 29;
            dvgDataNotaItens.Location = new Point(12, 166);
            dvgDataNotaItens.Name = "dvgDataNotaItens";
            dvgDataNotaItens.RowHeadersWidth = 51;
            dvgDataNotaItens.Size = new Size(1093, 384);
            dvgDataNotaItens.TabIndex = 0;
            // 
            // btnLancarNota
            // 
            btnLancarNota.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLancarNota.Location = new Point(955, 26);
            btnLancarNota.Name = "btnLancarNota";
            btnLancarNota.Size = new Size(132, 36);
            btnLancarNota.TabIndex = 1;
            btnLancarNota.Text = "Lançar Nota";
            btnLancarNota.UseVisualStyleBackColor = true;
            btnLancarNota.Click += btnLancarNota_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(485, 26);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 36);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(15, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(93, 27);
            textBox1.TabIndex = 4;
            // 
            // lbTotalItens
            // 
            lbTotalItens.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbTotalItens.AutoSize = true;
            lbTotalItens.Location = new Point(15, 2);
            lbTotalItens.Name = "lbTotalItens";
            lbTotalItens.Size = new Size(98, 20);
            lbTotalItens.TabIndex = 5;
            lbTotalItens.Text = "Total de itens";
            // 
            // gpFooter
            // 
            gpFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpFooter.Controls.Add(btnAbrirXml);
            gpFooter.Controls.Add(btnPreencherCFOP);
            gpFooter.Controls.Add(btnCancelar);
            gpFooter.Controls.Add(btnLancarNota);
            gpFooter.Controls.Add(lbTotalItens);
            gpFooter.Controls.Add(textBox1);
            gpFooter.Location = new Point(12, 756);
            gpFooter.Name = "gpFooter";
            gpFooter.Size = new Size(1093, 71);
            gpFooter.TabIndex = 6;
            gpFooter.TabStop = false;
            // 
            // btnAbrirXml
            // 
            btnAbrirXml.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbrirXml.Location = new Point(678, 26);
            btnAbrirXml.Name = "btnAbrirXml";
            btnAbrirXml.Size = new Size(127, 36);
            btnAbrirXml.TabIndex = 6;
            btnAbrirXml.Text = "Abrir XML";
            btnAbrirXml.UseVisualStyleBackColor = true;
            btnAbrirXml.Click += btnAbrirXml_Click;
            // 
            // btnPreencherCFOP
            // 
            btnPreencherCFOP.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPreencherCFOP.Location = new Point(811, 26);
            btnPreencherCFOP.Name = "btnPreencherCFOP";
            btnPreencherCFOP.Size = new Size(127, 36);
            btnPreencherCFOP.TabIndex = 2;
            btnPreencherCFOP.Text = "Preencher CFOP";
            btnPreencherCFOP.UseVisualStyleBackColor = true;
            // 
            // gpHeader
            // 
            gpHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpHeader.Controls.Add(tbNomeFornecedor);
            gpHeader.Controls.Add(tbCodFornecedor);
            gpHeader.Controls.Add(tbIdContasPagar);
            gpHeader.Controls.Add(tbNumDoc);
            gpHeader.Controls.Add(tbIdQive);
            gpHeader.Controls.Add(lbChaveAcesso);
            gpHeader.Controls.Add(lbNomeFornecedor);
            gpHeader.Controls.Add(lbIDFornecedor);
            gpHeader.Controls.Add(lbIDContasPagar);
            gpHeader.Controls.Add(lbNumDoc);
            gpHeader.Controls.Add(lbIDQiveArquivoXml);
            gpHeader.Controls.Add(tbChaveAcesso);
            gpHeader.Font = new Font("Segoe UI", 9F);
            gpHeader.Location = new Point(12, -1);
            gpHeader.Name = "gpHeader";
            gpHeader.Size = new Size(1093, 161);
            gpHeader.TabIndex = 7;
            gpHeader.TabStop = false;
            gpHeader.Text = "Identificação";
            // 
            // tbNomeFornecedor
            // 
            tbNomeFornecedor.BackColor = SystemColors.ScrollBar;
            tbNomeFornecedor.Location = new Point(623, 116);
            tbNomeFornecedor.Name = "tbNomeFornecedor";
            tbNomeFornecedor.Size = new Size(303, 27);
            tbNomeFornecedor.TabIndex = 20;
            // 
            // tbCodFornecedor
            // 
            tbCodFornecedor.BackColor = SystemColors.ScrollBar;
            tbCodFornecedor.Location = new Point(623, 55);
            tbCodFornecedor.Name = "tbCodFornecedor";
            tbCodFornecedor.Size = new Size(91, 27);
            tbCodFornecedor.TabIndex = 19;
            // 
            // tbIdContasPagar
            // 
            tbIdContasPagar.BackColor = SystemColors.ScrollBar;
            tbIdContasPagar.Location = new Point(368, 55);
            tbIdContasPagar.Name = "tbIdContasPagar";
            tbIdContasPagar.Size = new Size(131, 27);
            tbIdContasPagar.TabIndex = 18;
            // 
            // tbNumDoc
            // 
            tbNumDoc.BackColor = SystemColors.ScrollBar;
            tbNumDoc.Location = new Point(180, 55);
            tbNumDoc.Name = "tbNumDoc";
            tbNumDoc.Size = new Size(131, 27);
            tbNumDoc.TabIndex = 17;
            // 
            // tbIdQive
            // 
            tbIdQive.BackColor = SystemColors.ScrollBar;
            tbIdQive.Location = new Point(15, 55);
            tbIdQive.Name = "tbIdQive";
            tbIdQive.Size = new Size(131, 27);
            tbIdQive.TabIndex = 16;
            // 
            // lbChaveAcesso
            // 
            lbChaveAcesso.AutoSize = true;
            lbChaveAcesso.Location = new Point(15, 91);
            lbChaveAcesso.Name = "lbChaveAcesso";
            lbChaveAcesso.Size = new Size(102, 20);
            lbChaveAcesso.TabIndex = 15;
            lbChaveAcesso.Text = "Chave Acesso:";
            // 
            // lbNomeFornecedor
            // 
            lbNomeFornecedor.AutoSize = true;
            lbNomeFornecedor.Location = new Point(623, 91);
            lbNomeFornecedor.Name = "lbNomeFornecedor";
            lbNomeFornecedor.Size = new Size(53, 20);
            lbNomeFornecedor.TabIndex = 14;
            lbNomeFornecedor.Text = "Nome:";
            // 
            // lbIDFornecedor
            // 
            lbIDFornecedor.AutoSize = true;
            lbIDFornecedor.Location = new Point(623, 32);
            lbIDFornecedor.Name = "lbIDFornecedor";
            lbIDFornecedor.Size = new Size(121, 20);
            lbIDFornecedor.TabIndex = 13;
            lbIDFornecedor.Text = "Cod. Fornecedor:";
            // 
            // lbIDContasPagar
            // 
            lbIDContasPagar.AutoSize = true;
            lbIDContasPagar.Location = new Point(368, 32);
            lbIDContasPagar.Name = "lbIDContasPagar";
            lbIDContasPagar.Size = new Size(117, 20);
            lbIDContasPagar.TabIndex = 12;
            lbIDContasPagar.Text = "ID Contas Pagar:";
            // 
            // lbNumDoc
            // 
            lbNumDoc.AutoSize = true;
            lbNumDoc.Location = new Point(180, 32);
            lbNumDoc.Name = "lbNumDoc";
            lbNumDoc.Size = new Size(78, 20);
            lbNumDoc.TabIndex = 11;
            lbNumDoc.Text = "Num. Doc:";
            // 
            // lbIDQiveArquivoXml
            // 
            lbIDQiveArquivoXml.AutoSize = true;
            lbIDQiveArquivoXml.Location = new Point(15, 32);
            lbIDQiveArquivoXml.Name = "lbIDQiveArquivoXml";
            lbIDQiveArquivoXml.Size = new Size(61, 20);
            lbIDQiveArquivoXml.TabIndex = 10;
            lbIDQiveArquivoXml.Text = "ID Qive:";
            // 
            // tbChaveAcesso
            // 
            tbChaveAcesso.BackColor = SystemColors.ScrollBar;
            tbChaveAcesso.Location = new Point(15, 116);
            tbChaveAcesso.Name = "tbChaveAcesso";
            tbChaveAcesso.Size = new Size(543, 27);
            tbChaveAcesso.TabIndex = 6;
            // 
            // dvgContaFinanceira
            // 
            dvgContaFinanceira.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgContaFinanceira.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgContaFinanceira.ColumnHeadersHeight = 29;
            dvgContaFinanceira.Location = new Point(5, 26);
            dvgContaFinanceira.Name = "dvgContaFinanceira";
            dvgContaFinanceira.RowHeadersWidth = 51;
            dvgContaFinanceira.Size = new Size(1081, 167);
            dvgContaFinanceira.TabIndex = 8;
            // 
            // gpContas
            // 
            gpContas.Controls.Add(dvgContaFinanceira);
            gpContas.Location = new Point(12, 556);
            gpContas.Name = "gpContas";
            gpContas.Size = new Size(1093, 199);
            gpContas.TabIndex = 9;
            gpContas.TabStop = false;
            gpContas.Text = "Conta(s) Financeira";
            // 
            // ImportarNotasFiscaisXmlParaTotvsDetalhes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 830);
            Controls.Add(gpHeader);
            Controls.Add(dvgDataNotaItens);
            Controls.Add(gpFooter);
            Controls.Add(gpContas);
            Name = "ImportarNotasFiscaisXmlParaTotvsDetalhes";
            Text = "Exportar Notas Totvs Detalhado";
            Load += ImportarNotasFiscaisXmlParaTotvsDetalhes_Load;
            ((System.ComponentModel.ISupportInitialize)dvgDataNotaItens).EndInit();
            gpFooter.ResumeLayout(false);
            gpFooter.PerformLayout();
            gpHeader.ResumeLayout(false);
            gpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgContaFinanceira).EndInit();
            gpContas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComponentesTelaUI.DataGridView.MyDataGridView dvgDataNotaItens;
        private Button button2;
        private Button btnLancarNota;
        private Button btnCancelar;
        private TextBox textBox1;
        private Label lbTotalItens;
        private GroupBox gpFooter;
        private GroupBox gpHeader;
        private TextBox tbNomeFornecedor;
        private TextBox tbCodFornecedor;
        private TextBox tbIdContasPagar;
        private TextBox tbChaveAcesso;
        private TextBox tbIdQive;
        private Label lbChaveAcesso;
        private Label lbNomeFornecedor;
        private Label lbIDFornecedor;
        private Label lbIDContasPagar;
        private Label lbNumDoc;
        private Label lbIDQiveArquivoXml;
        private Button btnPreencherCFOP;
        private TextBox tbNumDoc;
        private ComponentesTelaUI.DataGridView.MyDataGridView dvgContaFinanceira;
        private GroupBox gpContas;
        private Button btnAbrirXml;
    }
}