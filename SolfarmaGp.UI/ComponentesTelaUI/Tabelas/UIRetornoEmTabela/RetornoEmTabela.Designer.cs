namespace SolfarmaGp.UI.ComponentesTelaUI.Tabelas.UIRetornoEmTabela
{
    partial class RetornoEmTabela
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
            button1 = new Button();
            txtBoxCount = new TextBox();
            dataGridRetorno = new System.Windows.Forms.DataGridView();
            btnCopiaTabela = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridRetorno).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(867, 626);
            button1.Name = "button1";
            button1.Size = new Size(93, 44);
            button1.TabIndex = 1;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBoxCount
            // 
            txtBoxCount.BackColor = SystemColors.ScrollBar;
            txtBoxCount.Enabled = false;
            txtBoxCount.Location = new Point(11, 644);
            txtBoxCount.Name = "txtBoxCount";
            txtBoxCount.Size = new Size(183, 27);
            txtBoxCount.TabIndex = 2;
            // 
            // dataGridRetorno
            // 
            dataGridRetorno.AllowUserToAddRows = false;
            dataGridRetorno.AllowUserToDeleteRows = false;
            dataGridRetorno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRetorno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRetorno.Location = new Point(11, 33);
            dataGridRetorno.Name = "dataGridRetorno";
            dataGridRetorno.RowHeadersWidth = 62;
            dataGridRetorno.RowTemplate.Height = 28;
            dataGridRetorno.Size = new Size(949, 567);
            dataGridRetorno.TabIndex = 3;
            // 
            // btnCopiaTabela
            // 
            btnCopiaTabela.Location = new Point(684, 626);
            btnCopiaTabela.Name = "btnCopiaTabela";
            btnCopiaTabela.Size = new Size(140, 44);
            btnCopiaTabela.TabIndex = 4;
            btnCopiaTabela.Text = "Copia tabela";
            btnCopiaTabela.UseVisualStyleBackColor = true;
            btnCopiaTabela.Click += btnCopiaTabela_Click;
            // 
            // RetornoEmTabela
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(971, 692);
            Controls.Add(btnCopiaTabela);
            Controls.Add(dataGridRetorno);
            Controls.Add(txtBoxCount);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "RetornoEmTabela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RetornoEmTabela";
            ((System.ComponentModel.ISupportInitialize)dataGridRetorno).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        //private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dataGridRetorno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxCount;
        private System.Windows.Forms.DataGridView dataGridRetorno;
        private Button btnCopiaTabela;
    }
}