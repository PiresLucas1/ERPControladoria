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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
            this.materialDrawer2 = new MaterialSkin.Controls.MaterialDrawer();
            this.tabControlHome = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageExportTotvs = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDrawer2
            // 
            this.materialDrawer2.AutoHide = false;
            this.materialDrawer2.AutoShow = false;
            this.materialDrawer2.BackgroundWithAccent = false;
            this.materialDrawer2.BaseTabControl = null;
            this.materialDrawer2.Depth = 0;
            this.materialDrawer2.HighlightWithAccent = true;
            this.materialDrawer2.IndicatorWidth = 0;
            this.materialDrawer2.IsOpen = true;
            this.materialDrawer2.Location = new System.Drawing.Point(0, 32606);
            this.materialDrawer2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer2.Name = "materialDrawer2";
            this.materialDrawer2.ShowIconsWhenHidden = false;
            this.materialDrawer2.Size = new System.Drawing.Size(71, 46);
            this.materialDrawer2.TabIndex = 2;
            this.materialDrawer2.Text = "materialDrawer2";
            this.materialDrawer2.UseColors = false;
            // 
            // tabControlHome
            // 
            this.tabControlHome.Controls.Add(this.tabPageExportTotvs);
            this.tabControlHome.Controls.Add(this.tabPage2);
            this.tabControlHome.Depth = 0;
            this.tabControlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHome.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlHome.ImageList = this.imageList1;
            this.tabControlHome.Location = new System.Drawing.Point(0, 0);
            this.tabControlHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlHome.Multiline = true;
            this.tabControlHome.Name = "tabControlHome";
            this.tabControlHome.SelectedIndex = 0;
            this.tabControlHome.Size = new System.Drawing.Size(1020, 677);
            this.tabControlHome.TabIndex = 3;
            this.tabControlHome.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlHome_Selected);
            this.tabControlHome.Click += new System.EventHandler(this.tabControlHome_Click);
            this.tabControlHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControlHome_MouseClick);
            // 
            // tabPageExportTotvs
            // 
            this.tabPageExportTotvs.BackColor = System.Drawing.Color.Transparent;
            this.tabPageExportTotvs.ImageIndex = 0;
            this.tabPageExportTotvs.Location = new System.Drawing.Point(4, 29);
            this.tabPageExportTotvs.Name = "tabPageExportTotvs";
            this.tabPageExportTotvs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExportTotvs.Size = new System.Drawing.Size(1012, 644);
            this.tabPageExportTotvs.TabIndex = 0;
            this.tabPageExportTotvs.Text = "Exporta nota para TOTVS";
            this.tabPageExportTotvs.Click += new System.EventHandler(this.tabPageExportTotvs_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "settings_32dp_E3E3E3_FILL0_wght200_GRAD0_opsz40.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "person_play_32dp_E3E3E3_FILL0_wght200_GRAD0_opsz40.png");
            this.imageList1.Images.SetKeyName(1, "settings_32dp_E3E3E3_FILL0_wght200_GRAD0_opsz40.png");
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ERP_FISCAL.Properties.Resources.solfarma_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1020, 677);
            this.Controls.Add(this.tabControlHome);
            this.Controls.Add(this.materialDrawer2);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControlHome;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Portal";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controladoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Portal_Load);
            this.tabControlHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialDrawer materialDrawer2;
        private MaterialSkin.Controls.MaterialTabControl tabControlHome;
        private System.Windows.Forms.TabPage tabPageExportTotvs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
    }
}