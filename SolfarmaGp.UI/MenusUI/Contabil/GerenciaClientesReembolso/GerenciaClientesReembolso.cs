using SolfarmaGp.Controllers.UseCase.Contabil.GerenciarPessoaRecebeReembolso;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.Contabil.GerenciaClientesReembolso
{
    public partial class GerenciaClientesReembolso : Form
    {
        public GerenciaClientesReembolso()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void GerenciaClientesReembolso_Load(object sender, EventArgs e)
        {

            DataTable dt = await new GerencaConsultaPessoaRecebeReembolsoUseCase().Execute();
            dvgGerenciar.DataSource = dt;
            tbContador.Text = dt.Rows.Count.ToString();
        }
    }
}
