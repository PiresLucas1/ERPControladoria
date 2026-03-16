using SolfarmaGp.Controllers.UseCase.Fiscal.Gerenciar;

namespace SolfarmaGp.UI.MenusUI.Fiscal.Gerenciar
{
    public partial class AlteracaoDePeriodo : Form
    {
        public AlteracaoDePeriodo()
        {
            InitializeComponent();
            cbStatus.Items.Add("Ativo");
            cbStatus.Items.Add("Inativo");
            cbStatus.SelectedItem = "Ativo";
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime dtInicio = dtpInicio.Value.Date;
            DateTime dtFIm = dtpFim.Value.Date;

            if (dtInicio > dtFIm)
            {
                MessageBox.Show("Data inválida");
                return;
            }
            bool periodoEstaAtivo = cbStatus.SelectedItem == "Ativo" ? true : false;


            DialogResult resultado =
                MessageBox.Show(
                    "Deseja Confirmar a alteração de periodo fiscal",
                    "Confirmação",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information
                    );
            if (resultado == DialogResult.OK)
            {
                var usuario = new Portal().pegaValorUsuario();
                await AlteraPeriodoFiscal(dtInicio, dtFIm, periodoEstaAtivo, usuario);
            }

        }
        public async Task AlteraPeriodoFiscal(DateTime dtInicio, DateTime dtFim, bool periodoEstaAtivo, string usuario)
        {

            AlteracaoPeriodoFiscalUseCase useCase = new AlteracaoPeriodoFiscalUseCase();
            var alteracao = await useCase.Execute(dtInicio, dtFim, periodoEstaAtivo, usuario);

            if (alteracao)
            {
                MessageBox.Show("Alterado Com Sucesso", "Periodo Fiscal");
                return;
            }
            else
            {
                MessageBox.Show("Ocorreu um erro durante a alteração", "Periodo Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AlteracaoDePeriodo_Load(object sender, EventArgs e)
        {
            BuscaDataPeriodoUseCase useCase = new BuscaDataPeriodoUseCase();

            (DateTime dateInicio, DateTime dateFim, bool Status) = await useCase.Execute();
            dateTimePicker1.Value = dateInicio;
            dateTimePicker2.Value = dateFim;
            if (Status)
            {
                textBox1.Text = "Ativo";
            }

        }
    }
}
