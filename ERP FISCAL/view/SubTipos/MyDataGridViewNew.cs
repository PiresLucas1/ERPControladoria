using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Windows.Forms;

namespace ERP_FISCAL.view.SubTipos
{

    public class MyDataGridView : DataGridView
    {
        public MyDataGridView()
        {
            // Ativa double buffering
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        // Impede que o controle se redesenhe em excesso durante o scroll
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }

}
