namespace ERP_FISCAL.view.ZanupView
{
    partial class ConsultaNotaItem
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
            this.tbCnpjCpf = new System.Windows.Forms.TextBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cbLinhasSelecionadas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdProduto = new System.Windows.Forms.TextBox();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarNota = new System.Windows.Forms.Button();
            this.btnMarcarTodos = new System.Windows.Forms.Button();
            this.btnDesmarcarTodos = new System.Windows.Forms.Button();
            this.btnPreVisuNota = new System.Windows.Forms.Button();
            this.tbNumItens = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbActionsBottom = new System.Windows.Forms.GroupBox();
            this.dvgRetorno = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.gbFiltros.SuspendLayout();
            this.gbActionsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRetorno)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCnpjCpf
            // 
            this.tbCnpjCpf.Location = new System.Drawing.Point(389, 64);
            this.tbCnpjCpf.Name = "tbCnpjCpf";
            this.tbCnpjCpf.Size = new System.Drawing.Size(244, 26);
            this.tbCnpjCpf.TabIndex = 2;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cbLinhasSelecionadas);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.tbIdProduto);
            this.gbFiltros.Controls.Add(this.dtFim);
            this.gbFiltros.Controls.Add(this.dtInicio);
            this.gbFiltros.Controls.Add(this.btnPesquisa);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.tbCnpjCpf);
            this.gbFiltros.Location = new System.Drawing.Point(17, 19);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1489, 216);
            this.gbFiltros.TabIndex = 3;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // cbLinhasSelecionadas
            // 
            this.cbLinhasSelecionadas.AutoSize = true;
            this.cbLinhasSelecionadas.Location = new System.Drawing.Point(747, 64);
            this.cbLinhasSelecionadas.Name = "cbLinhasSelecionadas";
            this.cbLinhasSelecionadas.Size = new System.Drawing.Size(224, 24);
            this.cbLinhasSelecionadas.TabIndex = 11;
            this.cbLinhasSelecionadas.Text = "Exibir Linhas Selecionadas";
            this.cbLinhasSelecionadas.UseVisualStyleBackColor = true;
            this.cbLinhasSelecionadas.CheckedChanged += new System.EventHandler(this.cbLinhasSelecionadas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID Produto";
            // 
            // tbIdProduto
            // 
            this.tbIdProduto.Location = new System.Drawing.Point(389, 144);
            this.tbIdProduto.Name = "tbIdProduto";
            this.tbIdProduto.Size = new System.Drawing.Size(244, 26);
            this.tbIdProduto.TabIndex = 9;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(55, 141);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(179, 26);
            this.dtFim.TabIndex = 8;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(55, 64);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(179, 26);
            this.dtInicio.TabIndex = 7;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(1293, 144);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(164, 43);
            this.btnPesquisa.TabIndex = 6;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNPJ/CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Fim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Incio:";
            // 
            // btnCriarNota
            // 
            this.btnCriarNota.Location = new System.Drawing.Point(1300, 58);
            this.btnCriarNota.Name = "btnCriarNota";
            this.btnCriarNota.Size = new System.Drawing.Size(157, 43);
            this.btnCriarNota.TabIndex = 7;
            this.btnCriarNota.Text = "Criar nota";
            this.btnCriarNota.UseVisualStyleBackColor = true;
            this.btnCriarNota.Click += new System.EventHandler(this.btnCriarNota_Click_1);
            // 
            // btnMarcarTodos
            // 
            this.btnMarcarTodos.Location = new System.Drawing.Point(450, 849);
            this.btnMarcarTodos.Name = "btnMarcarTodos";
            this.btnMarcarTodos.Size = new System.Drawing.Size(156, 37);
            this.btnMarcarTodos.TabIndex = 8;
            this.btnMarcarTodos.Text = "Marcar todos";
            this.btnMarcarTodos.UseVisualStyleBackColor = true;
            this.btnMarcarTodos.Click += new System.EventHandler(this.btnMarcarTodos_Click);
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(450, 892);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(156, 37);
            this.btnDesmarcarTodos.TabIndex = 9;
            this.btnDesmarcarTodos.Text = "Desmarcar todos";
            this.btnDesmarcarTodos.UseVisualStyleBackColor = true;
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // btnPreVisuNota
            // 
            this.btnPreVisuNota.Enabled = false;
            this.btnPreVisuNota.Location = new System.Drawing.Point(620, 70);
            this.btnPreVisuNota.Name = "btnPreVisuNota";
            this.btnPreVisuNota.Size = new System.Drawing.Size(207, 37);
            this.btnPreVisuNota.TabIndex = 10;
            this.btnPreVisuNota.Text = "Pre visualização de nota";
            this.btnPreVisuNota.UseVisualStyleBackColor = true;
            // 
            // tbNumItens
            // 
            this.tbNumItens.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNumItens.Enabled = false;
            this.tbNumItens.Location = new System.Drawing.Point(16, 81);
            this.tbNumItens.Name = "tbNumItens";
            this.tbNumItens.Size = new System.Drawing.Size(184, 26);
            this.tbNumItens.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número de itens";
            // 
            // gbActionsBottom
            // 
            this.gbActionsBottom.Controls.Add(this.btnPreVisuNota);
            this.gbActionsBottom.Controls.Add(this.tbNumItens);
            this.gbActionsBottom.Controls.Add(this.label5);
            this.gbActionsBottom.Controls.Add(this.btnCriarNota);
            this.gbActionsBottom.Location = new System.Drawing.Point(17, 822);
            this.gbActionsBottom.Name = "gbActionsBottom";
            this.gbActionsBottom.Size = new System.Drawing.Size(1489, 124);
            this.gbActionsBottom.TabIndex = 13;
            this.gbActionsBottom.TabStop = false;
            // 
            // dvgRetorno
            // 
            this.dvgRetorno.AllowUserToAddRows = false;
            this.dvgRetorno.AllowUserToDeleteRows = false;
            this.dvgRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgRetorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRetorno.Location = new System.Drawing.Point(12, 241);
            this.dvgRetorno.Name = "dvgRetorno";
            this.dvgRetorno.RowHeadersWidth = 62;
            this.dvgRetorno.RowTemplate.Height = 28;
            this.dvgRetorno.Size = new System.Drawing.Size(1489, 575);
            this.dvgRetorno.TabIndex = 4;
            // 
            // ConsultaNotaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 958);
            this.Controls.Add(this.btnDesmarcarTodos);
            this.Controls.Add(this.btnMarcarTodos);
            this.Controls.Add(this.dvgRetorno);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.gbActionsBottom);
            this.Name = "ConsultaNotaItem";
            this.Text = "ConsultaNotaItem";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbActionsBottom.ResumeLayout(false);
            this.gbActionsBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRetorno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbCnpjCpf;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgRetorno;
        private System.Windows.Forms.Button btnCriarNota;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdProduto;
        private System.Windows.Forms.Button btnMarcarTodos;
        private System.Windows.Forms.Button btnDesmarcarTodos;
        private System.Windows.Forms.Button btnPreVisuNota;
        private System.Windows.Forms.TextBox tbNumItens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbActionsBottom;
        private System.Windows.Forms.CheckBox cbLinhasSelecionadas;
    }
}