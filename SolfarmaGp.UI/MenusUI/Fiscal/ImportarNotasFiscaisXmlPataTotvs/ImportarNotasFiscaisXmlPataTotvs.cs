using SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs;
using SolfarmaGp.UI.ComponentesTelaUI.ProcessoCarregamento.UIStatusDoProcessos;
using SolfarmaGp.UI.MenusUI.Fiscal.ImportarNotasFiscaisXmlPataTotvs;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.Fiscal.NovaPasta
{
    public partial class ImportarNotasFiscaisXmlPataTotvs : Form
    {
        private DataTable _tabela;
        private BindingSource _bs = new BindingSource();
        private DataRowView _linhaSelecionada = null;
        public ImportarNotasFiscaisXmlPataTotvs()
        {
            InitializeComponent();
            dvgNotas.ReadOnly = true;
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
            try
            {
                ProcessStatusManager.Start("Carregando dados...");
                ProcessStatusManager.Update("Processando...");
                await ConsultaNotas(dataInicio, dataFim);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao consultar as notas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                ProcessStatusManager.Stop();
            }
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

            if (data == null || data.Rows.Count == 0)
            {
                _tabela = null;
                _bs.DataSource = null;
                dvgNotas.DataSource = _bs;
                tbRegistros.Text = "0";

                MessageBox.Show(
                    "Nenhum registro encontrado para o período selecionado.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            _tabela = data;
            _bs.DataSource = _tabela;
            dvgNotas.DataSource = _bs;
            AdicionarColunaSelecao();                        
            dvgNotas.Sorted += (s, e) => AtualizarCoresDaGrid();

            dvgNotas.Columns["DataDocumento"].DefaultCellStyle.Format = "dd/MM/yyyy";

            tbRegistros.Text = _tabela.Rows.Count.ToString();
        }

        private void AdicionarColunaSelecao()
        {
            if (dvgNotas.Columns.Contains("Selecionado"))
                return;

            DataGridViewCheckBoxColumn colunaSelecao = new DataGridViewCheckBoxColumn();

            colunaSelecao.Name = "Selecionado";
            colunaSelecao.HeaderText = "";
            colunaSelecao.Width = 40;
            colunaSelecao.ReadOnly = false;

            dvgNotas.Columns.Insert(0, colunaSelecao);
        }
        private void cbTipoData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cbTipoData.SelectedText != "Data de Lançamento" )
            //{
            //    MessageBox.Show("Essa funcionalidade ainda não foi implementada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }

        private async void btnConsultarXml_Click(object sender, EventArgs e)
        {
            var IDqiveArquivoXMLString = dvgNotas.CurrentRow.Cells["IDQiveArquivoXML"].Value.ToString();
            var IDQiveArquivoXMLString = dvgNotas.CurrentRow.Cells["IDQiveArquivoXML"].Value.ToString();

            var numDocumentoString = dvgNotas.CurrentRow.Cells["NumDocumento"].Value.ToString();
            int IDQiveArquivoXML = int.Parse(IDQiveArquivoXMLString);

            ConsultarXmlNotaQiveUseCase useCase = new ConsultarXmlNotaQiveUseCase();
            string result = await useCase.Executar(IDQiveArquivoXML);
        }

        private void btnSelecionaTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvgNotas.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Selecionado"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {
                    checkBoxCell.Value = true;
                }
            }
        }

        private void gpAcoes_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimparSelecao_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvgNotas.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Selecionado"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {
                    checkBoxCell.Value = false;
                }
            }
        }

        private void dvgNotas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var IDQiveArquivoXMLString = dvgNotas.Rows[e.RowIndex].Cells["IDQiveArquivoXML"].Value.ToString();
            var numDocumentoString = dvgNotas.Rows[e.RowIndex].Cells["NumDocumento"].Value.ToString();
            int IDQiveArquivoXML = int.Parse(IDQiveArquivoXMLString);

            ConsultaDetalhesNota(IDQiveArquivoXML, numDocumentoString);
        }

        private void btnVisualizarNota_Click(object sender, EventArgs e)
        {
            var IDQiveArquivoXMLString = dvgNotas.CurrentRow.Cells["IDQiveArquivoXML"].Value.ToString();
            var numDocumentoString = dvgNotas.CurrentRow.Cells["NumDocumento"].Value.ToString();
            int IDQiveArquivoXML = int.Parse(IDQiveArquivoXMLString);

            ConsultaDetalhesNota(IDQiveArquivoXML, numDocumentoString);
        }

        private void dvgNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _linhaSelecionada = dvgNotas.Rows[e.RowIndex].DataBoundItem as DataRowView;
            AtualizarCoresDaGrid();
        }
        private void AtualizarCoresDaGrid()
        {
            foreach (DataGridViewRow row in dvgNotas.Rows)
            {
                if (row.DataBoundItem == _linhaSelecionada)
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void ConsultaDetalhesNota(int IDQiveArquivoXML, string numDocumentoString)
        {
            using (var form = new ImportarNotasFiscaisXmlParaTotvsDetalhes(
                                  IDQiveArquivoXML,
                                  numDocumentoString,
                                  new ConsultaNotasExportaTotvsDetalhes())
                  )
            {
                DialogResult result = form.ShowDialog(this);
            }
        }
    }
}
