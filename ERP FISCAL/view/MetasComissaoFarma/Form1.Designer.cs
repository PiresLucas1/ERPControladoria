namespace ERP_FISCAL.view.MetasComissaoFarma
{
    partial class Form1
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
            this.tabMetasGerais = new System.Windows.Forms.TabControl();
            this.tbMetasGerais = new System.Windows.Forms.TabPage();
            this.tabMetasPorEmpresa = new System.Windows.Forms.TabPage();
            this.tabConfiguracoes = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDtBase = new System.Windows.Forms.Label();
            this.dtpDataBase = new System.Windows.Forms.DateTimePicker();
            this.lbMetaTotal = new System.Windows.Forms.Label();
            this.txtbMetaTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbHPC = new System.Windows.Forms.Label();
            this.lbGenerico = new System.Windows.Forms.Label();
            this.lbNestle = new System.Windows.Forms.Label();
            this.lbLoreal = new System.Windows.Forms.Label();
            this.lbEtico = new System.Windows.Forms.Label();
            this.txtbHPC = new System.Windows.Forms.TextBox();
            this.txtbGenerico = new System.Windows.Forms.TextBox();
            this.txtbNestle = new System.Windows.Forms.TextBox();
            this.txtbLoreal = new System.Windows.Forms.TextBox();
            this.txtbEtico = new System.Windows.Forms.TextBox();
            this.pnlMetasGerais = new System.Windows.Forms.Panel();
            this.tabMetasGerais.SuspendLayout();
            this.tbMetasGerais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlMetasGerais.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMetasGerais
            // 
            this.tabMetasGerais.Controls.Add(this.tbMetasGerais);
            this.tabMetasGerais.Controls.Add(this.tabMetasPorEmpresa);
            this.tabMetasGerais.Controls.Add(this.tabConfiguracoes);
            this.tabMetasGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMetasGerais.Location = new System.Drawing.Point(0, 0);
            this.tabMetasGerais.Name = "tabMetasGerais";
            this.tabMetasGerais.SelectedIndex = 0;
            this.tabMetasGerais.Size = new System.Drawing.Size(1107, 641);
            this.tabMetasGerais.TabIndex = 5;
            // 
            // tbMetasGerais
            // 
            this.tbMetasGerais.Controls.Add(this.pnlMetasGerais);
            this.tbMetasGerais.Location = new System.Drawing.Point(4, 25);
            this.tbMetasGerais.Name = "tbMetasGerais";
            this.tbMetasGerais.Padding = new System.Windows.Forms.Padding(3);
            this.tbMetasGerais.Size = new System.Drawing.Size(1099, 612);
            this.tbMetasGerais.TabIndex = 0;
            this.tbMetasGerais.Text = "Metas Gerais";
            this.tbMetasGerais.UseVisualStyleBackColor = true;
            // 
            // tabMetasPorEmpresa
            // 
            this.tabMetasPorEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tabMetasPorEmpresa.Name = "tabMetasPorEmpresa";
            this.tabMetasPorEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetasPorEmpresa.Size = new System.Drawing.Size(1098, 611);
            this.tabMetasPorEmpresa.TabIndex = 1;
            this.tabMetasPorEmpresa.Text = "Metas por Empresa";
            this.tabMetasPorEmpresa.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracoes
            // 
            this.tabConfiguracoes.Location = new System.Drawing.Point(4, 25);
            this.tabConfiguracoes.Name = "tabConfiguracoes";
            this.tabConfiguracoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguracoes.Size = new System.Drawing.Size(1099, 612);
            this.tabConfiguracoes.TabIndex = 2;
            this.tabConfiguracoes.Text = "Configurações";
            this.tabConfiguracoes.UseVisualStyleBackColor = true;
            this.tabConfiguracoes.Click += new System.EventHandler(this.tabConfiguracoes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbMetaTotal);
            this.groupBox1.Controls.Add(this.lbMetaTotal);
            this.groupBox1.Controls.Add(this.dtpDataBase);
            this.groupBox1.Controls.Add(this.lbDtBase);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração Geral";
            // 
            // lbDtBase
            // 
            this.lbDtBase.AutoSize = true;
            this.lbDtBase.Location = new System.Drawing.Point(19, 31);
            this.lbDtBase.Name = "lbDtBase";
            this.lbDtBase.Size = new System.Drawing.Size(74, 16);
            this.lbDtBase.TabIndex = 0;
            this.lbDtBase.Text = "Data Base:";
            this.lbDtBase.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpDataBase
            // 
            this.dtpDataBase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataBase.Location = new System.Drawing.Point(99, 31);
            this.dtpDataBase.Name = "dtpDataBase";
            this.dtpDataBase.Size = new System.Drawing.Size(121, 22);
            this.dtpDataBase.TabIndex = 1;
            this.dtpDataBase.ValueChanged += new System.EventHandler(this.dtpDataBase_ValueChanged);
            // 
            // lbMetaTotal
            // 
            this.lbMetaTotal.AutoSize = true;
            this.lbMetaTotal.Location = new System.Drawing.Point(19, 75);
            this.lbMetaTotal.Name = "lbMetaTotal";
            this.lbMetaTotal.Size = new System.Drawing.Size(74, 16);
            this.lbMetaTotal.TabIndex = 2;
            this.lbMetaTotal.Text = "Meta Total:";
            // 
            // txtbMetaTotal
            // 
            this.txtbMetaTotal.Location = new System.Drawing.Point(99, 72);
            this.txtbMetaTotal.Name = "txtbMetaTotal";
            this.txtbMetaTotal.Size = new System.Drawing.Size(121, 22);
            this.txtbMetaTotal.TabIndex = 3;
            this.txtbMetaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbEtico);
            this.groupBox2.Controls.Add(this.txtbLoreal);
            this.groupBox2.Controls.Add(this.txtbNestle);
            this.groupBox2.Controls.Add(this.txtbGenerico);
            this.groupBox2.Controls.Add(this.txtbHPC);
            this.groupBox2.Controls.Add(this.lbEtico);
            this.groupBox2.Controls.Add(this.lbLoreal);
            this.groupBox2.Controls.Add(this.lbNestle);
            this.groupBox2.Controls.Add(this.lbGenerico);
            this.groupBox2.Controls.Add(this.lbHPC);
            this.groupBox2.Location = new System.Drawing.Point(25, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meta por Categoria";
            // 
            // lbHPC
            // 
            this.lbHPC.AutoSize = true;
            this.lbHPC.Location = new System.Drawing.Point(12, 37);
            this.lbHPC.Name = "lbHPC";
            this.lbHPC.Size = new System.Drawing.Size(38, 16);
            this.lbHPC.TabIndex = 0;
            this.lbHPC.Text = "HPC:";
            // 
            // lbGenerico
            // 
            this.lbGenerico.AutoSize = true;
            this.lbGenerico.Location = new System.Drawing.Point(12, 73);
            this.lbGenerico.Name = "lbGenerico";
            this.lbGenerico.Size = new System.Drawing.Size(65, 16);
            this.lbGenerico.TabIndex = 0;
            this.lbGenerico.Text = "Genérico:";
            // 
            // lbNestle
            // 
            this.lbNestle.AutoSize = true;
            this.lbNestle.Location = new System.Drawing.Point(12, 112);
            this.lbNestle.Name = "lbNestle";
            this.lbNestle.Size = new System.Drawing.Size(49, 16);
            this.lbNestle.TabIndex = 0;
            this.lbNestle.Text = "Nestle:";
            // 
            // lbLoreal
            // 
            this.lbLoreal.AutoSize = true;
            this.lbLoreal.Location = new System.Drawing.Point(12, 144);
            this.lbLoreal.Name = "lbLoreal";
            this.lbLoreal.Size = new System.Drawing.Size(48, 16);
            this.lbLoreal.TabIndex = 0;
            this.lbLoreal.Text = "Loreal:";
            // 
            // lbEtico
            // 
            this.lbEtico.AutoSize = true;
            this.lbEtico.Location = new System.Drawing.Point(12, 181);
            this.lbEtico.Name = "lbEtico";
            this.lbEtico.Size = new System.Drawing.Size(40, 16);
            this.lbEtico.TabIndex = 0;
            this.lbEtico.Text = "Ético:";
            // 
            // txtbHPC
            // 
            this.txtbHPC.Location = new System.Drawing.Point(116, 37);
            this.txtbHPC.Name = "txtbHPC";
            this.txtbHPC.Size = new System.Drawing.Size(121, 22);
            this.txtbHPC.TabIndex = 4;
            // 
            // txtbGenerico
            // 
            this.txtbGenerico.Location = new System.Drawing.Point(116, 73);
            this.txtbGenerico.Name = "txtbGenerico";
            this.txtbGenerico.Size = new System.Drawing.Size(121, 22);
            this.txtbGenerico.TabIndex = 4;
            // 
            // txtbNestle
            // 
            this.txtbNestle.Location = new System.Drawing.Point(116, 109);
            this.txtbNestle.Name = "txtbNestle";
            this.txtbNestle.Size = new System.Drawing.Size(121, 22);
            this.txtbNestle.TabIndex = 4;
            // 
            // txtbLoreal
            // 
            this.txtbLoreal.Location = new System.Drawing.Point(116, 141);
            this.txtbLoreal.Name = "txtbLoreal";
            this.txtbLoreal.Size = new System.Drawing.Size(121, 22);
            this.txtbLoreal.TabIndex = 4;
            this.txtbLoreal.TextChanged += new System.EventHandler(this.txtbLoreal_TextChanged);
            // 
            // txtbEtico
            // 
            this.txtbEtico.Location = new System.Drawing.Point(116, 175);
            this.txtbEtico.Name = "txtbEtico";
            this.txtbEtico.Size = new System.Drawing.Size(121, 22);
            this.txtbEtico.TabIndex = 4;
            // 
            // pnlMetasGerais
            // 
            this.pnlMetasGerais.Controls.Add(this.groupBox1);
            this.pnlMetasGerais.Controls.Add(this.groupBox2);
            this.pnlMetasGerais.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMetasGerais.Location = new System.Drawing.Point(3, 3);
            this.pnlMetasGerais.Name = "pnlMetasGerais";
            this.pnlMetasGerais.Size = new System.Drawing.Size(1408, 606);
            this.pnlMetasGerais.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 641);
            this.Controls.Add(this.tabMetasGerais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeção de vendas farma";
            this.tabMetasGerais.ResumeLayout(false);
            this.tbMetasGerais.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlMetasGerais.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMetasGerais;
        private System.Windows.Forms.TabPage tbMetasGerais;
        private System.Windows.Forms.TabPage tabMetasPorEmpresa;
        private System.Windows.Forms.TabPage tabConfiguracoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDtBase;
        private System.Windows.Forms.DateTimePicker dtpDataBase;
        private System.Windows.Forms.TextBox txtbMetaTotal;
        private System.Windows.Forms.Label lbMetaTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbEtico;
        private System.Windows.Forms.TextBox txtbLoreal;
        private System.Windows.Forms.TextBox txtbNestle;
        private System.Windows.Forms.TextBox txtbGenerico;
        private System.Windows.Forms.TextBox txtbHPC;
        private System.Windows.Forms.Label lbEtico;
        private System.Windows.Forms.Label lbLoreal;
        private System.Windows.Forms.Label lbNestle;
        private System.Windows.Forms.Label lbGenerico;
        private System.Windows.Forms.Label lbHPC;
        private System.Windows.Forms.Panel pnlMetasGerais;
    }
}