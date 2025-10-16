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
            this.menuBarTop = new System.Windows.Forms.MenuStrip();
            this.importarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarNotasParaOBigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarContaFreteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarBottom = new System.Windows.Forms.MenuStrip();
            this.Opções = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtVersao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarTop.SuspendLayout();
            this.menuBarBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBarTop
            // 
            this.menuBarTop.BackColor = System.Drawing.Color.DarkOrange;
            this.menuBarTop.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBarTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBarTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarNotasToolStripMenuItem,
            this.contabilToolStripMenuItem});
            this.menuBarTop.Location = new System.Drawing.Point(0, 0);
            this.menuBarTop.Name = "menuBarTop";
            this.menuBarTop.Size = new System.Drawing.Size(1937, 33);
            this.menuBarTop.TabIndex = 0;
            this.menuBarTop.Text = "menuStrip1";
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
            // contabilToolStripMenuItem
            // 
            this.contabilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarContaFreteToolStripMenuItem});
            this.contabilToolStripMenuItem.Enabled = false;
            this.contabilToolStripMenuItem.Name = "contabilToolStripMenuItem";
            this.contabilToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.contabilToolStripMenuItem.Text = "Contabil";
            this.contabilToolStripMenuItem.Visible = false;
            // 
            // alterarContaFreteToolStripMenuItem
            // 
            this.alterarContaFreteToolStripMenuItem.Name = "alterarContaFreteToolStripMenuItem";
            this.alterarContaFreteToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.alterarContaFreteToolStripMenuItem.Text = "Alterar conta frete";
            this.alterarContaFreteToolStripMenuItem.Click += new System.EventHandler(this.alterarContaFreteToolStripMenuItem_Click);
            // 
            // menuBarBottom
            // 
            this.menuBarBottom.BackColor = System.Drawing.Color.DarkOrange;
            this.menuBarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuBarBottom.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBarBottom.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBarBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtVersao,
            this.Opções,
            this.toolStripMenuItem4});
            this.menuBarBottom.Location = new System.Drawing.Point(0, 849);
            this.menuBarBottom.Name = "menuBarBottom";
            this.menuBarBottom.Size = new System.Drawing.Size(1937, 33);
            this.menuBarBottom.TabIndex = 1;
            this.menuBarBottom.Text = "menuStrip2";
            // 
            // Opções
            // 
            this.Opções.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarCorToolStripMenuItem});
            this.Opções.Name = "Opções";
            this.Opções.Size = new System.Drawing.Size(89, 29);
            this.Opções.Text = "Opções";
            // 
            // alterarCorToolStripMenuItem
            // 
            this.alterarCorToolStripMenuItem.Name = "alterarCorToolStripMenuItem";
            this.alterarCorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.alterarCorToolStripMenuItem.Text = "Alterar Cor";
            this.alterarCorToolStripMenuItem.Click += new System.EventHandler(this.alterarCorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5});
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(94, 29);
            this.toolStripMenuItem4.Text = "Contabil";
            this.toolStripMenuItem4.Visible = false;
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(256, 34);
            this.toolStripMenuItem5.Text = "Alterar conta frete";
            // 
            // txtVersao
            // 
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(81, 29);
            this.txtVersao.Text = "Versão";
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1937, 882);
            this.Controls.Add(this.menuBarBottom);
            this.Controls.Add(this.menuBarTop);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBarTop;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controladoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuBarTop.ResumeLayout(false);
            this.menuBarTop.PerformLayout();
            this.menuBarBottom.ResumeLayout(false);
            this.menuBarBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBarTop;
        private System.Windows.Forms.ToolStripMenuItem importarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarNotasParaOBigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarContaFreteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuBarBottom;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem Opções;
        private System.Windows.Forms.ToolStripMenuItem alterarCorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtVersao;
    }
}