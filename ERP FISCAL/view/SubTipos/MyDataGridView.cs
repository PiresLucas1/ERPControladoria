using System.Windows.Forms;


namespace ERP_CONTROLADORIA.view.SubTipos
{

public class MyDataGridView : DataGridView
{
    public MyDataGridView()
    {
        // Ativa double buffering
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        this.UpdateStyles();

        this.AllowUserToResizeColumns = true;
    }

    // Impede que o controle se redesenhe em excesso durante o scroll
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
    }
}
}
