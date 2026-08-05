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
            btPesquisar = new Button();
            lbDtInicio = new Label();
            lbDtFim = new Label();
            dtDataFim = new DateTimePicker();
            dtDataInicio = new DateTimePicker();
            dtEntradasComFiltro = new DataGridView();
            lbColigada = new Label();
            txtBxColigada = new TextBox();
            lbFilial = new Label();
            txtBxFilial = new TextBox();
            gbFiltrosDt = new GroupBox();
            gbFiltros = new GroupBox();
            btExportar = new Button();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            chBxEntrada = new CheckBox();
            chBxSaida = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtEntradasComFiltro).BeginInit();
            gbFiltrosDt.SuspendLayout();
            gbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // btPesquisar
            // 
            btPesquisar.Location = new Point(341, 26);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Size = new Size(94, 29);
            btPesquisar.TabIndex = 0;
            btPesquisar.Text = "Pesquisar";
            btPesquisar.UseVisualStyleBackColor = true;
            btPesquisar.Click += btPesquisar_Click;
            // 
            // lbDtInicio
            // 
            lbDtInicio.AutoSize = true;
            lbDtInicio.Location = new Point(6, 23);
            lbDtInicio.Name = "lbDtInicio";
            lbDtInicio.Size = new Size(48, 20);
            lbDtInicio.TabIndex = 1;
            lbDtInicio.Text = "Inícial";
            // 
            // lbDtFim
            // 
            lbDtFim.AutoSize = true;
            lbDtFim.Location = new Point(3, 88);
            lbDtFim.Name = "lbDtFim";
            lbDtFim.Size = new Size(40, 20);
            lbDtFim.TabIndex = 2;
            lbDtFim.Text = "Final";
            // 
            // dtDataFim
            // 
            dtDataFim.Format = DateTimePickerFormat.Short;
            dtDataFim.Location = new Point(6, 111);
            dtDataFim.Name = "dtDataFim";
            dtDataFim.Size = new Size(134, 27);
            dtDataFim.TabIndex = 3;
            // 
            // dtDataInicio
            // 
            dtDataInicio.Format = DateTimePickerFormat.Short;
            dtDataInicio.Location = new Point(6, 46);
            dtDataInicio.Name = "dtDataInicio";
            dtDataInicio.Size = new Size(134, 27);
            dtDataInicio.TabIndex = 4;
            // 
            // dtEntradasComFiltro
            // 
            dtEntradasComFiltro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEntradasComFiltro.Location = new Point(12, 202);
            dtEntradasComFiltro.Name = "dtEntradasComFiltro";
            dtEntradasComFiltro.RowHeadersWidth = 51;
            dtEntradasComFiltro.Size = new Size(776, 236);
            dtEntradasComFiltro.TabIndex = 5;
            // 
            // lbColigada
            // 
            lbColigada.AutoSize = true;
            lbColigada.Location = new Point(6, 23);
            lbColigada.Name = "lbColigada";
            lbColigada.Size = new Size(69, 20);
            lbColigada.TabIndex = 6;
            lbColigada.Text = "Coligada";
            // 
            // txtBxColigada
            // 
            txtBxColigada.Location = new Point(6, 46);
            txtBxColigada.Name = "txtBxColigada";
            txtBxColigada.Size = new Size(125, 27);
            txtBxColigada.TabIndex = 7;
            // 
            // lbFilial
            // 
            lbFilial.AutoSize = true;
            lbFilial.Location = new Point(6, 88);
            lbFilial.Name = "lbFilial";
            lbFilial.Size = new Size(40, 20);
            lbFilial.TabIndex = 8;
            lbFilial.Text = "Filial";
            // 
            // txtBxFilial
            // 
            txtBxFilial.Location = new Point(6, 113);
            txtBxFilial.Name = "txtBxFilial";
            txtBxFilial.Size = new Size(125, 27);
            txtBxFilial.TabIndex = 9;
            // 
            // gbFiltrosDt
            // 
            gbFiltrosDt.Controls.Add(dtDataInicio);
            gbFiltrosDt.Controls.Add(lbDtInicio);
            gbFiltrosDt.Controls.Add(lbDtFim);
            gbFiltrosDt.Controls.Add(dtDataFim);
            gbFiltrosDt.Location = new Point(171, 12);
            gbFiltrosDt.Name = "gbFiltrosDt";
            gbFiltrosDt.Size = new Size(150, 157);
            gbFiltrosDt.TabIndex = 10;
            gbFiltrosDt.TabStop = false;
            gbFiltrosDt.Text = "Data Pesquisa";
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(lbColigada);
            gbFiltros.Controls.Add(txtBxColigada);
            gbFiltros.Controls.Add(txtBxFilial);
            gbFiltros.Controls.Add(lbFilial);
            gbFiltros.Location = new Point(12, 12);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(144, 157);
            gbFiltros.TabIndex = 11;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // btExportar
            // 
            btExportar.Location = new Point(473, 26);
            btExportar.Name = "btExportar";
            btExportar.Size = new Size(94, 29);
            btExportar.TabIndex = 12;
            btExportar.Text = "Exportar";
            btExportar.UseVisualStyleBackColor = true;
            btExportar.Click += btExportar_Click;
            // 
            // chBxEntrada
            // 
            chBxEntrada.AutoSize = true;
            chBxEntrada.Location = new Point(341, 76);
            chBxEntrada.Name = "chBxEntrada";
            chBxEntrada.Size = new Size(82, 24);
            chBxEntrada.TabIndex = 13;
            chBxEntrada.Text = "Entrada";
            chBxEntrada.UseVisualStyleBackColor = true;
            // 
            // chBxSaida
            // 
            chBxSaida.AutoSize = true;
            chBxSaida.Location = new Point(341, 106);
            chBxSaida.Name = "chBxSaida";
            chBxSaida.Size = new Size(68, 24);
            chBxSaida.TabIndex = 14;
            chBxSaida.Text = "Saída";
            chBxSaida.UseVisualStyleBackColor = true;
            // 
            // BuscaEntradasComFiltro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chBxSaida);
            Controls.Add(chBxEntrada);
            Controls.Add(btExportar);
            Controls.Add(gbFiltros);
            Controls.Add(gbFiltrosDt);
            Controls.Add(dtEntradasComFiltro);
            Controls.Add(btPesquisar);
            Name = "BuscaEntradasComFiltro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entradas Com Filtro";
            ((System.ComponentModel.ISupportInitialize)dtEntradasComFiltro).EndInit();
            gbFiltrosDt.ResumeLayout(false);
            gbFiltrosDt.PerformLayout();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btPesquisar;
        private Label lbDtInicio;
        private Label lbDtFim;
        private DateTimePicker dtDataFim;
        private DateTimePicker dtDataInicio;
        private DataGridView dtEntradasComFiltro;
        private Label lbColigada;
        private TextBox txtBxColigada;
        private Label lbFilial;
        private TextBox txtBxFilial;
        private GroupBox gbFiltrosDt;
        private GroupBox gbFiltros;
        private Button btExportar;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private CheckBox chBxEntrada;
        private CheckBox chBxSaida;
    }
}