using SolfarmaGp.UI.ComponentesTelaUI.Moderno;

namespace SolfarmaGp.UI.MenusUI.Zanup.ExportaNotasFiscais
{
    partial class ExportaNotasFiscaisZanup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lbInfo = new Label();
            cartaoPeriodo = new CartaoPanel();
            dtpFim = new DateTimePicker();
            lbDataFim = new Label();
            dtpInicio = new DateTimePicker();
            lbDtInicio = new Label();
            lbTituloPeriodo = new Label();
            cartaoFiltros = new CartaoPanel();
            rtbNumeroDocumentos = new RichTextBox();
            lbNumeroDocumentos = new Label();
            txtCodTmv = new TextBox();
            lbCodTmv = new Label();
            lbTituloFiltros = new Label();
            btnExportar = new BotaoModerno();
            btnSoClienteFornecedor = new BotaoModerno();
            btnSoProdutos = new BotaoModerno();
            btnSoNota = new BotaoModerno();
            cartaoResultado = new CartaoPanel();
            rtbResultado = new RichTextBox();
            tabResultado = new TabControl();
            btnExcelAba = new BotaoModerno();
            btnExcelTodas = new BotaoModerno();
            tpLog = new TabPage();
            flpEtapas = new FlowLayoutPanel();
            lbResultado = new Label();
            cartaoPeriodo.SuspendLayout();
            cartaoFiltros.SuspendLayout();
            cartaoResultado.SuspendLayout();
            SuspendLayout();
            // 
            // lbInfo
            // 
            lbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbInfo.ForeColor = Color.FromArgb(96, 96, 96);
            lbInfo.Location = new Point(22, 14);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(656, 44);
            lbInfo.TabIndex = 0;
            lbInfo.Text = "Primeiro atualiza a situação na Sefaz e as notas canceladas. Depois exporta Cliente/Fornecedor, Produtos e, por fim, o Documento Fiscal da Zanup para o Totvs (nunca substitui registros).";
            // 
            // cartaoPeriodo
            // 
            cartaoPeriodo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartaoPeriodo.BackColor = Color.White;
            cartaoPeriodo.Controls.Add(dtpFim);
            cartaoPeriodo.Controls.Add(lbDataFim);
            cartaoPeriodo.Controls.Add(dtpInicio);
            cartaoPeriodo.Controls.Add(lbDtInicio);
            cartaoPeriodo.Controls.Add(lbTituloPeriodo);
            cartaoPeriodo.CorBorda = Color.FromArgb(222, 225, 230);
            cartaoPeriodo.Location = new Point(20, 62);
            cartaoPeriodo.Name = "cartaoPeriodo";
            cartaoPeriodo.Raio = 10;
            cartaoPeriodo.Size = new Size(660, 102);
            cartaoPeriodo.TabIndex = 1;
            // 
            // dtpFim
            // 
            dtpFim.Format = DateTimePickerFormat.Short;
            dtpFim.Location = new Point(176, 62);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(140, 27);
            dtpFim.TabIndex = 4;
            // 
            // lbDataFim
            // 
            lbDataFim.AutoSize = true;
            lbDataFim.ForeColor = Color.FromArgb(96, 96, 96);
            lbDataFim.Location = new Point(176, 38);
            lbDataFim.Name = "lbDataFim";
            lbDataFim.Size = new Size(67, 20);
            lbDataFim.TabIndex = 3;
            lbDataFim.Text = "Data fim";
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(16, 62);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(140, 27);
            dtpInicio.TabIndex = 2;
            // 
            // lbDtInicio
            // 
            lbDtInicio.AutoSize = true;
            lbDtInicio.ForeColor = Color.FromArgb(96, 96, 96);
            lbDtInicio.Location = new Point(16, 38);
            lbDtInicio.Name = "lbDtInicio";
            lbDtInicio.Size = new Size(81, 20);
            lbDtInicio.TabIndex = 1;
            lbDtInicio.Text = "Data início";
            // 
            // lbTituloPeriodo
            // 
            lbTituloPeriodo.AutoSize = true;
            lbTituloPeriodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTituloPeriodo.Location = new Point(16, 10);
            lbTituloPeriodo.Name = "lbTituloPeriodo";
            lbTituloPeriodo.Size = new Size(200, 20);
            lbTituloPeriodo.TabIndex = 0;
            lbTituloPeriodo.Text = "1. Período (máximo 90 dias)";
            // 
            // cartaoFiltros
            // 
            cartaoFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartaoFiltros.BackColor = Color.White;
            cartaoFiltros.Controls.Add(rtbNumeroDocumentos);
            cartaoFiltros.Controls.Add(lbNumeroDocumentos);
            cartaoFiltros.Controls.Add(txtCodTmv);
            cartaoFiltros.Controls.Add(lbCodTmv);
            cartaoFiltros.Controls.Add(lbTituloFiltros);
            cartaoFiltros.CorBorda = Color.FromArgb(222, 225, 230);
            cartaoFiltros.Location = new Point(20, 176);
            cartaoFiltros.Name = "cartaoFiltros";
            cartaoFiltros.Raio = 10;
            cartaoFiltros.Size = new Size(660, 150);
            cartaoFiltros.TabIndex = 2;
            // 
            // rtbNumeroDocumentos
            // 
            rtbNumeroDocumentos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbNumeroDocumentos.Location = new Point(190, 62);
            rtbNumeroDocumentos.Name = "rtbNumeroDocumentos";
            rtbNumeroDocumentos.Size = new Size(454, 72);
            rtbNumeroDocumentos.TabIndex = 4;
            rtbNumeroDocumentos.Text = "";
            // 
            // lbNumeroDocumentos
            // 
            lbNumeroDocumentos.AutoSize = true;
            lbNumeroDocumentos.ForeColor = Color.FromArgb(96, 96, 96);
            lbNumeroDocumentos.Location = new Point(190, 38);
            lbNumeroDocumentos.Name = "lbNumeroDocumentos";
            lbNumeroDocumentos.Size = new Size(210, 20);
            lbNumeroDocumentos.TabIndex = 3;
            lbNumeroDocumentos.Text = "Nº documentos (um por linha)";
            // 
            // txtCodTmv
            // 
            txtCodTmv.Location = new Point(16, 62);
            txtCodTmv.Name = "txtCodTmv";
            txtCodTmv.Size = new Size(150, 27);
            txtCodTmv.TabIndex = 2;
            // 
            // lbCodTmv
            // 
            lbCodTmv.AutoSize = true;
            lbCodTmv.ForeColor = Color.FromArgb(96, 96, 96);
            lbCodTmv.Location = new Point(16, 38);
            lbCodTmv.Name = "lbCodTmv";
            lbCodTmv.Size = new Size(92, 20);
            lbCodTmv.TabIndex = 1;
            lbCodTmv.Text = "Código TMV";
            // 
            // lbTituloFiltros
            // 
            lbTituloFiltros.AutoSize = true;
            lbTituloFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTituloFiltros.Location = new Point(16, 10);
            lbTituloFiltros.Name = "lbTituloFiltros";
            lbTituloFiltros.Size = new Size(300, 20);
            lbTituloFiltros.TabIndex = 0;
            lbTituloFiltros.Text = "2. Filtros do documento fiscal (opcionais)";
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Location = new Point(520, 338);
            btnExportar.Name = "btnExportar";
            btnExportar.Principal = true;
            btnExportar.Raio = 8;
            btnExportar.Size = new Size(160, 38);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            //
            // btnSoClienteFornecedor
            //
            btnSoClienteFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSoClienteFornecedor.FlatStyle = FlatStyle.Flat;
            btnSoClienteFornecedor.Location = new Point(20, 338);
            btnSoClienteFornecedor.Name = "btnSoClienteFornecedor";
            btnSoClienteFornecedor.Principal = false;
            btnSoClienteFornecedor.Raio = 8;
            btnSoClienteFornecedor.Size = new Size(190, 38);
            btnSoClienteFornecedor.TabIndex = 4;
            btnSoClienteFornecedor.Text = "Cliente/Fornecedor";
            btnSoClienteFornecedor.UseVisualStyleBackColor = true;
            btnSoClienteFornecedor.Click += btnSoClienteFornecedor_Click;
            //
            // btnSoProdutos
            //
            btnSoProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSoProdutos.FlatStyle = FlatStyle.Flat;
            btnSoProdutos.Location = new Point(218, 338);
            btnSoProdutos.Name = "btnSoProdutos";
            btnSoProdutos.Principal = false;
            btnSoProdutos.Raio = 8;
            btnSoProdutos.Size = new Size(120, 38);
            btnSoProdutos.TabIndex = 5;
            btnSoProdutos.Text = "Produtos";
            btnSoProdutos.UseVisualStyleBackColor = true;
            btnSoProdutos.Click += btnSoProdutos_Click;
            //
            // btnSoNota
            //
            btnSoNota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSoNota.FlatStyle = FlatStyle.Flat;
            btnSoNota.Location = new Point(346, 338);
            btnSoNota.Name = "btnSoNota";
            btnSoNota.Principal = false;
            btnSoNota.Raio = 8;
            btnSoNota.Size = new Size(160, 38);
            btnSoNota.TabIndex = 6;
            btnSoNota.Text = "Nota fiscal";
            btnSoNota.UseVisualStyleBackColor = true;
            btnSoNota.Click += btnSoNota_Click;
            // 
            // cartaoResultado
            // 
            cartaoResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartaoResultado.BackColor = Color.White;
            cartaoResultado.Controls.Add(btnExcelTodas);
            cartaoResultado.Controls.Add(btnExcelAba);
            cartaoResultado.Controls.Add(tabResultado);
            cartaoResultado.Controls.Add(flpEtapas);
            cartaoResultado.Controls.Add(lbResultado);
            cartaoResultado.CorBorda = Color.FromArgb(222, 225, 230);
            cartaoResultado.Location = new Point(20, 388);
            cartaoResultado.Name = "cartaoResultado";
            cartaoResultado.Raio = 10;
            cartaoResultado.Size = new Size(660, 442);
            cartaoResultado.TabIndex = 4;
            // 
            // rtbResultado
            // 
            rtbResultado.BackColor = Color.FromArgb(245, 246, 248);
            rtbResultado.BorderStyle = BorderStyle.None;
            rtbResultado.Dock = DockStyle.Fill;
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.TabIndex = 0;
            rtbResultado.Text = "";
            //
            // tabResultado
            //
            tabResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabResultado.Controls.Add(tpLog);
            tabResultado.Location = new Point(16, 168);
            tabResultado.Name = "tabResultado";
            tabResultado.SelectedIndex = 0;
            tabResultado.Size = new Size(628, 258);
            tabResultado.TabIndex = 2;
            //
            // btnExcelAba
            //
            btnExcelAba.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcelAba.Enabled = false;
            btnExcelAba.FlatStyle = FlatStyle.Flat;
            btnExcelAba.Location = new Point(348, 4);
            btnExcelAba.Name = "btnExcelAba";
            btnExcelAba.Principal = false;
            btnExcelAba.Raio = 8;
            btnExcelAba.Size = new Size(140, 30);
            btnExcelAba.TabIndex = 3;
            btnExcelAba.Text = "Excel da aba";
            btnExcelAba.UseVisualStyleBackColor = true;
            btnExcelAba.Click += btnExcelAba_Click;
            //
            // btnExcelTodas
            //
            btnExcelTodas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcelTodas.Enabled = false;
            btnExcelTodas.FlatStyle = FlatStyle.Flat;
            btnExcelTodas.Location = new Point(496, 4);
            btnExcelTodas.Name = "btnExcelTodas";
            btnExcelTodas.Principal = false;
            btnExcelTodas.Raio = 8;
            btnExcelTodas.Size = new Size(148, 30);
            btnExcelTodas.TabIndex = 4;
            btnExcelTodas.Text = "Excel de todas";
            btnExcelTodas.UseVisualStyleBackColor = true;
            btnExcelTodas.Click += btnExcelTodas_Click;
            //
            // tpLog
            //
            tpLog.Controls.Add(rtbResultado);
            tpLog.Name = "tpLog";
            tpLog.Text = "Log";
            tpLog.UseVisualStyleBackColor = true;
            // 
            // flpEtapas
            // 
            flpEtapas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpEtapas.AutoScroll = true;
            flpEtapas.FlowDirection = FlowDirection.TopDown;
            flpEtapas.Location = new Point(16, 38);
            flpEtapas.Name = "flpEtapas";
            flpEtapas.Size = new Size(628, 122);
            flpEtapas.TabIndex = 1;
            flpEtapas.WrapContents = false;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbResultado.Location = new Point(16, 10);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(79, 20);
            lbResultado.TabIndex = 0;
            lbResultado.Text = "Resultado";
            // 
            // ExportaNotasFiscaisZanup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(700, 850);
            Controls.Add(cartaoResultado);
            Controls.Add(btnExportar);
            Controls.Add(btnSoNota);
            Controls.Add(btnSoProdutos);
            Controls.Add(btnSoClienteFornecedor);
            Controls.Add(cartaoFiltros);
            Controls.Add(cartaoPeriodo);
            Controls.Add(lbInfo);
            MinimumSize = new Size(718, 797);
            Name = "ExportaNotasFiscaisZanup";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exportação Notas Fiscais";
            cartaoPeriodo.ResumeLayout(false);
            cartaoPeriodo.PerformLayout();
            cartaoFiltros.ResumeLayout(false);
            cartaoFiltros.PerformLayout();
            cartaoResultado.ResumeLayout(false);
            cartaoResultado.PerformLayout();
            tabResultado.ResumeLayout(false);
            tpLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbInfo;
        private CartaoPanel cartaoPeriodo;
        private Label lbTituloPeriodo;
        private Label lbDtInicio;
        private DateTimePicker dtpInicio;
        private Label lbDataFim;
        private DateTimePicker dtpFim;
        private CartaoPanel cartaoFiltros;
        private Label lbTituloFiltros;
        private Label lbCodTmv;
        private TextBox txtCodTmv;
        private Label lbNumeroDocumentos;
        private RichTextBox rtbNumeroDocumentos;
        private BotaoModerno btnExportar;
        private BotaoModerno btnSoClienteFornecedor;
        private BotaoModerno btnSoProdutos;
        private BotaoModerno btnSoNota;
        private CartaoPanel cartaoResultado;
        private Label lbResultado;
        private FlowLayoutPanel flpEtapas;
        private RichTextBox rtbResultado;
        private TabControl tabResultado;
        private BotaoModerno btnExcelAba;
        private BotaoModerno btnExcelTodas;
        private TabPage tpLog;
    }
}
