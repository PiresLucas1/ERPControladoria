using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ERP_FISCAL.view
{
    public partial class Portal : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Portal()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, TextShade.WHITE); ;


    

        }

        private void importarNFSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarNotaView eRPFiscal = new ImportarNotaView();
            eRPFiscal.Show();

        }



        private void Portal_Load(object sender, EventArgs e)
        {
            //tabControlHome.DrawMode = TabDrawMode.OwnerDrawFixed;
            //tabControlHome.SizeMode = TabSizeMode.Normal; // Normal deixa variar
            //tabControlHome.DrawItem += MaterialTabControl1_DrawItem;
            //AjustarLarguraDasAbas();


        }
        private void AjustarLarguraDasAbas()
        {
            using (Graphics g = tabControlHome.CreateGraphics())
            {
                int extra = 20; // margem adicional
                foreach (TabPage tp in tabControlHome.TabPages)
                {
                    int textWidth = (int)g.MeasureString(tp.Text, tabControlHome.Font).Width + extra;
                    tp.Tag = textWidth; // salvar valor para desenhar
                }
            }
        }

        private void MaterialTabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControlHome.TabPages[e.Index];
            Rectangle rect = e.Bounds;

            int largura = (int)(tabPage.Tag ?? rect.Width);
            rect.Width = largura;

            using (Brush brush = new SolidBrush(Color.Black))
            {
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString(tabPage.Text, tabControlHome.Font, brush, rect, sf);
            }
        }

        public void tabControlHome_Selected(object sender, TabControlEventArgs e)
        {
            AbreImpotarnota();
        }

        private void tabControlHome_Click(object sender, EventArgs e)
        {
            AbreImpotarnota();
        }

        public void AbreImpotarnota()
        {
            if (tabControlHome.SelectedTab == tabPageExportTotvs)
            {
                ImportarNotaView eRPFiscal = new ImportarNotaView();
                eRPFiscal.Show();
            }
        }

        private void tabPageExportTotvs_Click(object sender, EventArgs e)
        {
            AbreImpotarnota();
        }

        private void tabControlHome_MouseClick(object sender, MouseEventArgs e)
        {
            AbreImpotarnota();
        }
    }
}
