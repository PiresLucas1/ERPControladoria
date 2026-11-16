using SolfarmaGp.UI.ComponentesTelaUI.Moderno;

namespace SolfarmaGp.UI.MenusUI.Fiscal.EntradasComFiltro
{
    partial class BuscaEntradasComFiltro
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
            DataGridViewCellStyle estiloCabecalho = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloCelula = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloAlternada = new DataGridViewCellStyle();
            cartaoFiltros = new CartaoPanel();
            lbTituloFiltros = new Label();
            lbColigada = new Label();
            txtBxColigada = new TextBox();
            lbFilial = new Label();
            txtBxFilial = new TextBox();
            lbDtInicio = new Label();
            dtDataInicio = new DateTimePicker();
            lbDtFim = new Label();
            dtDataFim = new DateTimePicker();
            chBxEntrada = new CheckBox();
            chBxSaida = new CheckBox();
            lbStatus = new Label();
            btExportar = new BotaoModerno();
            btPesquisar = new BotaoModerno();
            pbCarregando = new ProgressBar();
            cartaoGrade = new CartaoPanel();
            dtEntradasComFiltro = new DataGridView();
            cartaoFiltros.SuspendLayout();
            cartaoGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtEntradasComFiltro).BeginInit();
            SuspendLayout();
            //
            // cartaoFiltros
            //
            cartaoFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartaoFiltros.Controls.Add(chBxSaida);
            cartaoFiltros.Controls.Add(chBxEntrada);
            cartaoFiltros.Controls.Add(dtDataFim);
            cartaoFiltros.Controls.Add(lbDtFim);
            cartaoFiltros.Controls.Add(dtDataInicio);
            cartaoFiltros.Controls.Add(lbDtInicio);
            cartaoFiltros.Controls.Add(txtBxFilial);
            cartaoFiltros.Controls.Add(lbFilial);
            cartaoFiltros.Controls.Add(txtBxColigada);
            cartaoFiltros.Controls.Add(lbColigada);
            cartaoFiltros.Controls.Add(lbTituloFiltros);
            cartaoFiltros.Location = new Point(20, 16);
            cartaoFiltros.Name = "cartaoFiltros";
            cartaoFiltros.Size = new Size(780, 112);
            cartaoFiltros.TabIndex = 0;
            //
            // lbTituloFiltros
            //
            lbTituloFiltros.AutoSize = true;
            lbTituloFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTituloFiltros.Location = new Point(16, 10);
            lbTituloFiltros.Name = "lbTituloFiltros";
            lbTituloFiltros.Size = new Size(52, 20);
            lbTituloFiltros.TabIndex = 0;
            lbTituloFiltros.Text = "Filtros";
            //
            // lbColigada
            //
            lbColigada.AutoSize = true;
            lbColigada.ForeColor = Color.FromArgb(96, 96, 96);
            lbColigada.Location = new Point(16, 38);
            lbColigada.Name = "lbColigada";
            lbColigada.Size = new Size(69, 20);
            lbColigada.TabIndex = 1;
            lbColigada.Text = "Coligada";
            //
            // txtBxColigada
            //
            txtBxColigada.Location = new Point(16, 62);
            txtBxColigada.Name = "txtBxColigada";
            txtBxColigada.Size = new Size(120, 27);
            txtBxColigada.TabIndex = 2;
            //
            // lbFilial
            //
            lbFilial.AutoSize = true;
            lbFilial.ForeColor = Color.FromArgb(96, 96, 96);
            lbFilial.Location = new Point(156, 38);
            lbFilial.Name = "lbFilial";
            lbFilial.Size = new Size(40, 20);
            lbFilial.TabIndex = 3;
            lbFilial.Text = "Filial";
            //
            // txtBxFilial
            //
            txtBxFilial.Location = new Point(156, 62);
            txtBxFilial.Name = "txtBxFilial";
            txtBxFilial.Size = new Size(120, 27);
            txtBxFilial.TabIndex = 4;
            //
            // lbDtInicio
            //
            lbDtInicio.AutoSize = true;
            lbDtInicio.ForeColor = Color.FromArgb(96, 96, 96);
            lbDtInicio.Location = new Point(310, 38);
            lbDtInicio.Name = "lbDtInicio";
            lbDtInicio.Size = new Size(84, 20);
            lbDtInicio.TabIndex = 5;
            lbDtInicio.Text = "Data inicial";
            //
            // dtDataInicio
            //
            dtDataInicio.Format = DateTimePickerFormat.Short;
            dtDataInicio.Location = new Point(310, 62);
            dtDataInicio.Name = "dtDataInicio";
            dtDataInicio.Size = new Size(140, 27);
            dtDataInicio.TabIndex = 6;
            //
            // lbDtFim
            //
            lbDtFim.AutoSize = true;
            lbDtFim.ForeColor = Color.FromArgb(96, 96, 96);
            lbDtFim.Location = new Point(470, 38);
            lbDtFim.Name = "lbDtFim";
            lbDtFim.Size = new Size(72, 20);
            lbDtFim.TabIndex = 7;
            lbDtFim.Text = "Data final";
            //
            // dtDataFim
            //
            dtDataFim.Format = DateTimePickerFormat.Short;
            dtDataFim.Location = new Point(470, 62);
            dtDataFim.Name = "dtDataFim";
            dtDataFim.Size = new Size(140, 27);
            dtDataFim.TabIndex = 8;
            //
            // chBxEntrada
            //
            chBxEntrada.AutoSize = true;
            chBxEntrada.Location = new Point(650, 40);
            chBxEntrada.Name = "chBxEntrada";
            chBxEntrada.Size = new Size(82, 24);
            chBxEntrada.TabIndex = 9;
            chBxEntrada.Text = "Entrada";
            chBxEntrada.UseVisualStyleBackColor = true;
            //
            // chBxSaida
            //
            chBxSaida.AutoSize = true;
            chBxSaida.Location = new Point(650, 68);
            chBxSaida.Name = "chBxSaida";
            chBxSaida.Size = new Size(68, 24);
            chBxSaida.TabIndex = 10;
            chBxSaida.Text = "Saída";
            chBxSaida.UseVisualStyleBackColor = true;
            //
            // lbStatus
            //
            lbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbStatus.ForeColor = Color.FromArgb(96, 96, 96);
            lbStatus.Location = new Point(22, 148);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(420, 20);
            lbStatus.TabIndex = 1;
            lbStatus.TextAlign = ContentAlignment.MiddleLeft;
            //
            // btExportar
            //
            btExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btExportar.Location = new Point(454, 140);
            btExportar.Name = "btExportar";
            btExportar.Size = new Size(160, 38);
            btExportar.TabIndex = 2;
            btExportar.Text = "Exportar";
            btExportar.UseVisualStyleBackColor = true;
            btExportar.Click += btExportar_Click;
            //
            // btPesquisar
            //
            btPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btPesquisar.Location = new Point(640, 140);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Principal = true;
            btPesquisar.Size = new Size(160, 38);
            btPesquisar.TabIndex = 3;
            btPesquisar.Text = "Pesquisar";
            btPesquisar.UseVisualStyleBackColor = true;
            btPesquisar.Click += btPesquisar_Click;
            //
            // pbCarregando
            //
            pbCarregando.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbCarregando.MarqueeAnimationSpeed = 25;
            pbCarregando.Location = new Point(20, 188);
            pbCarregando.Name = "pbCarregando";
            pbCarregando.Size = new Size(780, 8);
            pbCarregando.Style = ProgressBarStyle.Marquee;
            pbCarregando.TabIndex = 4;
            pbCarregando.Visible = false;
            //
            // cartaoGrade
            //
            cartaoGrade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartaoGrade.Controls.Add(dtEntradasComFiltro);
            cartaoGrade.Location = new Point(20, 206);
            cartaoGrade.Name = "cartaoGrade";
            cartaoGrade.Size = new Size(780, 334);
            cartaoGrade.TabIndex = 5;
            //
            // dtEntradasComFiltro
            //
            dtEntradasComFiltro.AllowUserToAddRows = false;
            dtEntradasComFiltro.AllowUserToDeleteRows = false;
            dtEntradasComFiltro.AllowUserToResizeRows = false;
            estiloAlternada.BackColor = Color.FromArgb(250, 251, 252);
            dtEntradasComFiltro.AlternatingRowsDefaultCellStyle = estiloAlternada;
            dtEntradasComFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtEntradasComFiltro.BackgroundColor = Color.White;
            dtEntradasComFiltro.BorderStyle = BorderStyle.None;
            dtEntradasComFiltro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtEntradasComFiltro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            estiloCabecalho.Alignment = DataGridViewContentAlignment.MiddleLeft;
            estiloCabecalho.BackColor = Color.FromArgb(245, 246, 248);
            estiloCabecalho.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            estiloCabecalho.ForeColor = Color.FromArgb(60, 60, 60);
            estiloCabecalho.SelectionBackColor = Color.FromArgb(245, 246, 248);
            estiloCabecalho.SelectionForeColor = Color.FromArgb(60, 60, 60);
            estiloCabecalho.WrapMode = DataGridViewTriState.False;
            dtEntradasComFiltro.ColumnHeadersDefaultCellStyle = estiloCabecalho;
            dtEntradasComFiltro.ColumnHeadersHeight = 36;
            dtEntradasComFiltro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            estiloCelula.BackColor = Color.White;
            estiloCelula.ForeColor = Color.FromArgb(40, 40, 40);
            estiloCelula.SelectionBackColor = Color.FromArgb(253, 232, 220);
            estiloCelula.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dtEntradasComFiltro.DefaultCellStyle = estiloCelula;
            dtEntradasComFiltro.EnableHeadersVisualStyles = false;
            dtEntradasComFiltro.GridColor = Color.FromArgb(235, 237, 240);
            dtEntradasComFiltro.Location = new Point(1, 1);
            dtEntradasComFiltro.Name = "dtEntradasComFiltro";
            dtEntradasComFiltro.ReadOnly = true;
            dtEntradasComFiltro.RowHeadersVisible = false;
            dtEntradasComFiltro.RowHeadersWidth = 51;
            dtEntradasComFiltro.Size = new Size(778, 332);
            dtEntradasComFiltro.TabIndex = 0;
            //
            // BuscaEntradasComFiltro
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(820, 560);
            Controls.Add(cartaoGrade);
            Controls.Add(pbCarregando);
            Controls.Add(btPesquisar);
            Controls.Add(btExportar);
            Controls.Add(lbStatus);
            Controls.Add(cartaoFiltros);
            MinimumSize = new Size(838, 607);
            Name = "BuscaEntradasComFiltro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entradas Com Filtro";
            cartaoFiltros.ResumeLayout(false);
            cartaoFiltros.PerformLayout();
            cartaoGrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtEntradasComFiltro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CartaoPanel cartaoFiltros;
        private Label lbTituloFiltros;
        private Label lbColigada;
        private TextBox txtBxColigada;
        private Label lbFilial;
        private TextBox txtBxFilial;
        private Label lbDtInicio;
        private DateTimePicker dtDataInicio;
        private Label lbDtFim;
        private DateTimePicker dtDataFim;
        private CheckBox chBxEntrada;
        private CheckBox chBxSaida;
        private Label lbStatus;
        private BotaoModerno btExportar;
        private BotaoModerno btPesquisar;
        private ProgressBar pbCarregando;
        private CartaoPanel cartaoGrade;
        private DataGridView dtEntradasComFiltro;
    }
}
