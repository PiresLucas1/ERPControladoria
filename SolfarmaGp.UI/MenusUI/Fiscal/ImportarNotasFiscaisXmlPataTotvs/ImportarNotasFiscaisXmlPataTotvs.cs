using SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.Fiscal.NovaPasta
{
    public partial class ImportarNotasFiscaisXmlPataTotvs : Form
    {
        public ImportarNotasFiscaisXmlPataTotvs()
        {
            InitializeComponent();
            cbTipoData.Items.AddRange(new string[] { "Data de Lançamento", "Data de Documento" });
            cbTipoData.SelectedText = "Data de Lançamento";
            cbTipoData.Enabled = false;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            var dataInicio = dtInicio.Value;
            var dataFim = dtFim.Value;

            if (dataInicio > dataFim)
            {
                MessageBox.Show("A data de início deve ser menor ou igual à data de fim.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //instacia controller + consulta itens
            await ConsultaNotas(dataInicio, dataFim);
            //recuperar valor
        }
        public async Task ConsultaNotas(DateTime dataInicio, DateTime dataFim)
        {
            ConsultaNotasUseCase useCase = new ConsultaNotasUseCase();
            DataTable result = await useCase.Execute(dataInicio, dataFim);
            PreencherGrid(result);
        }
        public void PreencherGrid(DataTable data)
        {
            if (data != null)
            {
                dvgNotas.DataSource = data;
                tbRegistros.Text = data.Rows.Count.ToString();
                return;
            }
            MessageBox.Show("Nenhum registro encontrado para o período selecionado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cbTipoData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cbTipoData.SelectedText != "Data de Lançamento" )
            //{
            //    MessageBox.Show("Essa funcionalidade ainda não foi implementada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }

        private void btnConsultarXml_Click(object sender, EventArgs e)
        {

        }
    }
}
