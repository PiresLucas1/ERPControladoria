namespace SolfarmaGp.UI.MenusUI.Contabil
{
    partial class ParametrizacaoContabil
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
            dvgParametrizacao = new SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView();
            btnAddItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgParametrizacao).BeginInit();
            SuspendLayout();
            // 
            // dvgParametrizacao
            // 
            dvgParametrizacao.ColumnHeadersHeight = 29;
            dvgParametrizacao.Location = new Point(12, 78);
            dvgParametrizacao.Name = "dvgParametrizacao";
            dvgParametrizacao.RowHeadersWidth = 51;
            dvgParametrizacao.Size = new Size(1133, 575);
            dvgParametrizacao.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(12, 669);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(131, 39);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Adicionar Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // ParametrizacaoContabil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 732);
            Controls.Add(btnAddItem);
            Controls.Add(dvgParametrizacao);
            Name = "ParametrizacaoContabil";
            Text = "ParametrizacaoContabil";
            ((System.ComponentModel.ISupportInitialize)dvgParametrizacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComponentesTelaUI.DataGridView.MyDataGridView dvgParametrizacao;
        private Label label1;
        private Button btnAddItem;
    }
}