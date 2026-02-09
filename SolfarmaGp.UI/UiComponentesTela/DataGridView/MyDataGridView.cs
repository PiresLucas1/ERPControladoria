using System.ComponentModel;
using System.Windows.Forms.Design;

namespace SolfarmaGp.UI.UiComponentesTela.DataGridView
{
    [Designer(typeof(ControlDesigner))]
    [ToolboxItem(true)]
    public class MyDataGridView : System.Windows.Forms.DataGridView
    {
        public MyDataGridView()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
        
    }
}
