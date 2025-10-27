namespace ERP_FISCAL.view.UIComponentes.UIRetornoEmTabela
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridRetorno = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRetorno)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(924, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 644);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 26);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridRetorno
            // 
            this.dataGridRetorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRetorno.Location = new System.Drawing.Point(12, 33);
            this.dataGridRetorno.Name = "dataGridRetorno";
            this.dataGridRetorno.RowHeadersWidth = 62;
            this.dataGridRetorno.RowTemplate.Height = 28;
            this.dataGridRetorno.Size = new System.Drawing.Size(1023, 567);
            this.dataGridRetorno.TabIndex = 3;
            // 
            // RetornoEmTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1041, 692);
            this.Controls.Add(this.dataGridRetorno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "RetornoEmTabela";
            this.Text = "RetornoEmTabela";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRetorno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dataGridRetorno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dataGridRetorno;
    }
}