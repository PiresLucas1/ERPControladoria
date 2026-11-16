using SolfarmaGp.UI.ComponentesTelaUI.Moderno;

namespace SolfarmaGp.UI.MenusUI.DrogaCentro.Fiscal.ExportaNotasAlpha7
{
    partial class ExportaNotasFiscaisAlpha7
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
            cartaoSincronizacao = new CartaoPanel();
            nudDiasRetroativos = new NumericUpDown();
            lbDiasRetroativos = new Label();
            chkSincronizar = new CheckBox();
            btnSincronizar = new BotaoModerno();
            btnExportar = new BotaoModerno();
            cartaoResultado = new CartaoPanel();
            rtbResultado = new RichTextBox();
            flpEtapas = new FlowLayoutPanel();
            lbResultado = new Label();
            cartaoPeriodo.SuspendLayout();
            cartaoFiltros.SuspendLayout();
            cartaoSincronizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiasRetroativos).BeginInit();
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
            lbInfo.Text = "Exporta do Alpha7 para o Totvs, nesta ordem: Produtos, Cliente/Fornecedor e Notas Fiscais. Produtos e clientes/fornecedores vão desde o 1º dia do mês atual e nunca substituem registros.";
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
            lbTituloPeriodo.Size = new Size(151, 20);
            lbTituloPeriodo.TabIndex = 0;
            lbTituloPeriodo.Text = "1. Período das notas";
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
            lbTituloFiltros.Size = new Size(249, 20);
            lbTituloFiltros.TabIndex = 0;
            lbTituloFiltros.Text = "2. Filtros da nota fiscal (opcionais)";
            // 
            // cartaoSincronizacao
            // 
            cartaoSincronizacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartaoSincronizacao.BackColor = Color.White;
            cartaoSincronizacao.Controls.Add(nudDiasRetroativos);
            cartaoSincronizacao.Controls.Add(lbDiasRetroativos);
            cartaoSincronizacao.Controls.Add(chkSincronizar);
            cartaoSincronizacao.CorBorda = Color.FromArgb(222, 225, 230);
            cartaoSincronizacao.Location = new Point(20, 340);
            cartaoSincronizacao.Name = "cartaoSincronizacao";
            cartaoSincronizacao.Raio = 10;
            cartaoSincronizacao.Size = new Size(660, 62);
            cartaoSincronizacao.TabIndex = 3;
            // 
            // nudDiasRetroativos
            // 
            nudDiasRetroativos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudDiasRetroativos.Location = new Point(569, 16);
            nudDiasRetroativos.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudDiasRetroativos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDiasRetroativos.Name = "nudDiasRetroativos";
            nudDiasRetroativos.Size = new Size(75, 27);
            nudDiasRetroativos.TabIndex = 2;
            nudDiasRetroativos.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lbDiasRetroativos
            // 
            lbDiasRetroativos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbDiasRetroativos.AutoSize = true;
            lbDiasRetroativos.ForeColor = Color.FromArgb(96, 96, 96);
            lbDiasRetroativos.Location = new Point(440, 19);
            lbDiasRetroativos.Name = "lbDiasRetroativos";
            lbDiasRetroativos.Size = new Size(116, 20);
            lbDiasRetroativos.TabIndex = 1;
            lbDiasRetroativos.Text = "Dias retroativos:";
            // 
            // chkSincronizar
            // 
            chkSincronizar.AutoSize = true;
            chkSincronizar.Location = new Point(16, 18);
            chkSincronizar.Name = "chkSincronizar";
            chkSincronizar.Size = new Size(372, 24);
            chkSincronizar.TabIndex = 0;
            chkSincronizar.Text = "Somente sincronizar a base (desativa a exportação)";
            chkSincronizar.UseVisualStyleBackColor = true;
            chkSincronizar.CheckedChanged += chkSincronizar_CheckedChanged;
            // 
            // btnSincronizar
            // 
            btnSincronizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSincronizar.FlatStyle = FlatStyle.Flat;
            btnSincronizar.Location = new Point(336, 414);
            btnSincronizar.Name = "btnSincronizar";
            btnSincronizar.Principal = false;
            btnSincronizar.Raio = 8;
            btnSincronizar.Size = new Size(170, 38);
            btnSincronizar.TabIndex = 4;
            btnSincronizar.Text = "Somente sincronizar";
            btnSincronizar.UseVisualStyleBackColor = true;
            btnSincronizar.Click += btnSincronizar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Location = new Point(520, 414);
            btnExportar.Name = "btnExportar";
            btnExportar.Principal = true;
            btnExportar.Raio = 8;
            btnExportar.Size = new Size(160, 38);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // cartaoResultado
            // 
            cartaoResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartaoResultado.BackColor = Color.White;
            cartaoResultado.Controls.Add(rtbResultado);
            cartaoResultado.Controls.Add(flpEtapas);
            cartaoResultado.Controls.Add(lbResultado);
            cartaoResultado.CorBorda = Color.FromArgb(222, 225, 230);
            cartaoResultado.Location = new Point(20, 464);
            cartaoResultado.Name = "cartaoResultado";
            cartaoResultado.Raio = 10;
            cartaoResultado.Size = new Size(660, 266);
            cartaoResultado.TabIndex = 6;
            // 
            // rtbResultado
            // 
            rtbResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbResultado.BackColor = Color.FromArgb(245, 246, 248);
            rtbResultado.BorderStyle = BorderStyle.None;
            rtbResultado.Location = new Point(16, 124);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.Size = new Size(628, 126);
            rtbResultado.TabIndex = 2;
            rtbResultado.Text = "";
            // 
            // flpEtapas
            // 
            flpEtapas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpEtapas.AutoScroll = true;
            flpEtapas.FlowDirection = FlowDirection.TopDown;
            flpEtapas.Location = new Point(16, 38);
            flpEtapas.Name = "flpEtapas";
            flpEtapas.Size = new Size(628, 80);
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
            // ExportaNotasFiscaisAlpha7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(700, 750);
            Controls.Add(cartaoResultado);
            Controls.Add(btnExportar);
            Controls.Add(btnSincronizar);
            Controls.Add(cartaoSincronizacao);
            Controls.Add(cartaoFiltros);
            Controls.Add(cartaoPeriodo);
            Controls.Add(lbInfo);
            MaximizeBox = false;
            MinimumSize = new Size(718, 797);
            Name = "ExportaNotasFiscaisAlpha7";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exportação Notas Fiscais Alpha7";
            cartaoPeriodo.ResumeLayout(false);
            cartaoPeriodo.PerformLayout();
            cartaoFiltros.ResumeLayout(false);
            cartaoFiltros.PerformLayout();
            cartaoSincronizacao.ResumeLayout(false);
            cartaoSincronizacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiasRetroativos).EndInit();
            cartaoResultado.ResumeLayout(false);
            cartaoResultado.PerformLayout();
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
        private CartaoPanel cartaoSincronizacao;
        private CheckBox chkSincronizar;
        private Label lbDiasRetroativos;
        private NumericUpDown nudDiasRetroativos;
        private BotaoModerno btnSincronizar;
        private BotaoModerno btnExportar;
        private CartaoPanel cartaoResultado;
        private Label lbResultado;
        private FlowLayoutPanel flpEtapas;
        private RichTextBox rtbResultado;
    }
}
