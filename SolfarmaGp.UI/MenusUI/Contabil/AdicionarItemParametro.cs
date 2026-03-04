using Microsoft.IdentityModel.Tokens;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao;

namespace SolfarmaGp.UI.MenusUI.Contabil
{
    public partial class AdicionarItemParametro : Form
    {
        public AdicionarItemParametro()
        {
            InitializeComponent();
            cbTipoItem.Items.Add("Conta");
            cbTipoItem.Items.Add("Historico");
            cbTipoItem.Items.Add("Complemento");

            cbTipoItem.SelectedItem = "Conta";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string valor = tbItem.Text;
            string valorPlanoContas = tbPlanoContas.Text;

            if (valor.IsNullOrEmpty())
            {
                MessageBox.Show("O campo de item não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(valorPlanoContas.IsNullOrEmpty() && cbTipoItem.SelectedItem == "Conta")
            {
                MessageBox.Show("O campo de plano de contas não pode estar vazio para o tipo 'Conta'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbTipoItem.SelectedItem == "Conta")
            {
                AdicionaContaUseCase useCase = new AdicionaContaUseCase();
                useCase.Execute(valor, valorPlanoContas);
            }
            if (cbTipoItem.SelectedItem == "Historico")
            {
                AdicionaCodigoHistoricoUseCase useCase = new AdicionaCodigoHistoricoUseCase();
                useCase.Execute(valor);
            }
            if (cbTipoItem.SelectedItem == "Complemento")
            {
                AdicionaComplementoUseCase useCase = new AdicionaComplementoUseCase();
                useCase.Execute(valor);
            }
        }

        private void cbTipoItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoItem.SelectedItem == "Conta")
            {
                tbItem.PlaceholderText = "Digite o código da conta (Reduzido)";
                tbPlanoContas.Enabled = true;
                tbPlanoContas.PlaceholderText = "Digite o código do plano de contas";
            }
            if (cbTipoItem.SelectedItem == "Historico")
            {
                tbItem.PlaceholderText = "Digite o código do histórico";
                tbPlanoContas.Enabled = false;
                tbPlanoContas.PlaceholderText = "Plano de contas não necessário para histórico";
            }
            if (cbTipoItem.SelectedItem == "Complemento")
            {
                tbItem.PlaceholderText = "Digite o código do complemento";
                tbPlanoContas.Enabled = false;
                tbPlanoContas.PlaceholderText = "Plano de contas não necessário para complemento";
            }
        }
    }
}
