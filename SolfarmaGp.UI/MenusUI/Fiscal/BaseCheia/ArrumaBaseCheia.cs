using SolfarmaGp.Controllers.UseCase.Fiscal.BaseCheia;

namespace SolfarmaGp.UI.MenusUI.Fiscal.BaseCheia
{
    public partial class ArrumaBaseCheia : Form
    {
        public ArrumaBaseCheia()
        {
            InitializeComponent();

            // Alinhar ao centro
            rtbInformacao.SelectionAlignment = HorizontalAlignment.Center;
        }

        private async void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtInicio = dtpDataInicio.Value.Date;
                DateTime dtFim = dtpDataFim.Value.Date;

                if (dtInicio > dtFim)
                {
                    MessageBox.Show("A data inicial não pode ser maior que a data final.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado =
                    MessageBox.Show(
                        "Deseja confirmar o recálculo?",
                        "Confirmação",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question
                        );

                if (resultado == DialogResult.OK)
                {
                    var retono = await AlteraBase(dtInicio, dtFim);

                    if (retono == true)
                    {
                        MessageBox.Show("Base recálculada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<bool> AlteraBase(DateTime dtInicio, DateTime dtFim)
        {
            AlteracaoBaseCheiaUseCase useCase = new AlteracaoBaseCheiaUseCase();

            var retorno = await useCase.Executar(dtInicio, dtFim);

            return retorno;
        }
    }
}
