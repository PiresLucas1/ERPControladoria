namespace ERP_FISCAL.view
{
    partial class Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarNotasParaOBigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarContaFreteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarNotasToolStripMenuItem,
            this.contabilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1937, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importarNotasToolStripMenuItem
            // 
            this.importarNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.importarNotasParaOBigToolStripMenuItem});
            this.importarNotasToolStripMenuItem.Name = "importarNotasToolStripMenuItem";
            this.importarNotasToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.importarNotasToolStripMenuItem.Text = "Importar Notas";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.importarToolStripMenuItem.Text = "Importar XML Serviço";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // importarNotasParaOBigToolStripMenuItem
            // 
            this.importarNotasParaOBigToolStripMenuItem.Name = "importarNotasParaOBigToolStripMenuItem";
            this.importarNotasParaOBigToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.importarNotasParaOBigToolStripMenuItem.Text = "Importar Notas para o Big";
            this.importarNotasParaOBigToolStripMenuItem.Click += new System.EventHandler(this.importarNotasParaOBigToolStripMenuItem_Click);
            // 
            // alterarContaFreteToolStripMenuItem
            // 
            this.alterarContaFreteToolStripMenuItem.Name = "alterarContaFreteToolStripMenuItem";
            this.alterarContaFreteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.alterarContaFreteToolStripMenuItem.Text = "Alterar conta frete";
            this.alterarContaFreteToolStripMenuItem.Click += new System.EventHandler(this.alterarContaFreteToolStripMenuItem_Click);
            // 
            // contabilToolStripMenuItem
            // 
            this.contabilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarContaFreteToolStripMenuItem});
            this.contabilToolStripMenuItem.Name = "contabilToolStripMenuItem";
            this.contabilToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.contabilToolStripMenuItem.Text = "Contabil";
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ERP_FISCAL.Properties.Resources.SOLFARMA_3D_PNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1937, 882);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controladoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarNotasParaOBigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarContaFreteToolStripMenuItem;
    }
}