using System.Drawing;
using System.Windows.Forms;

namespace ERP_FISCAL.Utils
{
    public static class AplicarFonte
    {
        public static void AplicarFonteForm(Control controle, Font fonte)
        {
            controle.Font = fonte;

            foreach (Control c in controle.Controls)
            {
                AplicarFonteForm(c, fonte);
            }
        }

    }
}
