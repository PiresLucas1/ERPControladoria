using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

public class CustomTabSelector : MaterialTabSelector
{
    private MaterialTabControl materialTabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (BaseTabControl == null) return;

        for (int i = 0; i < BaseTabControl.TabPages.Count; i++)
        {
            var tabRect = BaseTabControl.GetTabRect(i);

            // 🔹 aqui você força uma largura mínima
            tabRect.Width = 200;

            TextRenderer.DrawText(
                e.Graphics,
                BaseTabControl.TabPages[i].Text,
                BaseTabControl.Font,
                tabRect,
                Color.Black,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }

    private void InitializeComponent()
    {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(200, 100);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

    }
}
