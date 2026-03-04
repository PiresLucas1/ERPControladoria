using SolfarmaGp.UI.Utils;

namespace SolfarmaGp.UI.MenusUI.Contabil
{
    public partial class ParametrizacaoContabil : Form
    {
        public ParametrizacaoContabil()
        {
            InitializeComponent();

        }
        public void AjustarDataGrid()
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!ValidaFormularioAberto.FormAberto(typeof(AdicionarItemParametro)))
            {
                AdicionarItemParametro adicionarItemParametro = new AdicionarItemParametro();
                adicionarItemParametro.Visible = true;
            }
        }
    }
}
