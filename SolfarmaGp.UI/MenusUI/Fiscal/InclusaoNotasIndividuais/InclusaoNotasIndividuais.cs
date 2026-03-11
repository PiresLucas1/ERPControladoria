using SolfarmaGp.Controllers.UseCase.Fiscal.InclusaoNotaIndividual;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.Fiscal.InclusaoNotasIndividuais
{
    public partial class InclusaoNotasIndividuais : Form
    {
        public DataTable dtNotasIncluidas = new DataTable();
        public InclusaoNotasIndividuais()
        {
            InitializeComponent();
        }

        private async  void btnAdiciona_Click(object sender, EventArgs e)
        {
            var textoSeparadoPorVirugula = rtbNumDocs.Text.
              Replace("\n", ",")
              .Replace("\r\n", ",");
            var dateInicio = dtpInicio.Value;
            var dateFim = dtpFim.Value;
            await IncluirNota(textoSeparadoPorVirugula, dateInicio, dateFim);
        }

        public async Task IncluirNota(string notas, DateTime dataInicio, DateTime dataFim)
        {
            InclusaoNotaIndividualUseCase usecase = new InclusaoNotaIndividualUseCase();
            var dtResult = await usecase.Execute(notas, dataInicio, dataFim);

            

        }
    }
}
