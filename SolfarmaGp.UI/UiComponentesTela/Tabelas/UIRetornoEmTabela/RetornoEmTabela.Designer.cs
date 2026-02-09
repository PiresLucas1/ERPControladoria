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
            this.txtBoxCount = new System.Windows.Forms.TextBox();
            this.dataGridRetorno = new ERP_CONTROLADORIA.view.SubTipos.MyDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRetorno)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(975, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxCount
            // 
            this.txtBoxCount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxCount.Enabled = false;
            this.txtBoxCount.Location = new System.Drawing.Point(12, 644);
            this.txtBoxCount.Name = "txtBoxCount";
            this.txtBoxCount.Size = new System.Drawing.Size(205, 26);
            this.txtBoxCount.TabIndex = 2;
            // 
            // dataGridRetorno
            // 
            this.dataGridRetorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRetorno.Location = new System.Drawing.Point(12, 33);
            this.dataGridRetorno.Name = "dataGridRetorno";
            this.dataGridRetorno.RowHeadersWidth = 62;
            this.dataGridRetorno.RowTemplate.Height = 28;
            this.dataGridRetorno.Size = new System.Drawing.Size(1068, 567);
            this.dataGridRetorno.TabIndex = 3;
            // 
            // RetornoEmTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1092, 692);
            this.Controls.Add(this.dataGridRetorno);
            this.Controls.Add(this.txtBoxCount);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "RetornoEmTabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetornoEmTabela";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRetorno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dataGridRetorno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxCount;
        private ERP_CONTROLADORIA.view.SubTipos.MyDataGridView dataGridRetorno;
    }
}