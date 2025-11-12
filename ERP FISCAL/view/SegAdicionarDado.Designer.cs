namespace ERP_FISCAL.view
{
    partial class SegAdicionarDado
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dvgItens = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescApp = new System.Windows.Forms.TextBox();
            this.lblNomeAplicacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgItens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(430, 26);
            this.txtNome.TabIndex = 1;
            // 
            // dvgItens
            // 
            this.dvgItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgItens.Location = new System.Drawing.Point(23, 258);
            this.dvgItens.Name = "dvgItens";
            this.dvgItens.RowHeadersWidth = 62;
            this.dvgItens.RowTemplate.Height = 28;
            this.dvgItens.Size = new System.Drawing.Size(618, 431);
            this.dvgItens.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(49, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(143, 30);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome Menu";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(537, 200);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(104, 41);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Adicionar";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDescApp
            // 
            this.txtDescApp.Location = new System.Drawing.Point(53, 155);
            this.txtDescApp.Name = "txtDescApp";
            this.txtDescApp.Size = new System.Drawing.Size(430, 26);
            this.txtDescApp.TabIndex = 7;
            // 
            // lblNomeAplicacao
            // 
            this.lblNomeAplicacao.AutoSize = true;
            this.lblNomeAplicacao.Location = new System.Drawing.Point(49, 119);
            this.lblNomeAplicacao.Name = "lblNomeAplicacao";
            this.lblNomeAplicacao.Size = new System.Drawing.Size(230, 30);
            this.lblNomeAplicacao.TabIndex = 8;
            this.lblNomeAplicacao.Text = "Descrição Aplicação";
            // 
            // SegAdicionarDado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 777);
            this.Controls.Add(this.txtDescApp);
            this.Controls.Add(this.lblNomeAplicacao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dvgItens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SegAdicionarDado";
            this.Text = "SegAdicionarDado";
            ((System.ComponentModel.ISupportInitialize)(this.dvgItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dvgItens;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescApp;
        private System.Windows.Forms.Label lblNomeAplicacao;
    }
}