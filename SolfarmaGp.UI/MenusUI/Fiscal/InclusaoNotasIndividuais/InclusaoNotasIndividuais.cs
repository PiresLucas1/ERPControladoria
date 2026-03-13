using SolfarmaGp.Controllers.UseCase.Fiscal.InclusaoNotaIndividual;
using SolfarmaGp.UI.ComponentesTelaUI.ProcessoCarregamento.UIStatusDoProcessos;
using SolfarmaGp.UI.ComponentesTelaUI.Tabelas.UIRetornoEmTabela;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.Fiscal.InclusaoNotasIndividuais
{
    public partial class InclusaoNotasIndividuais : Form
    {
        public DataTable dtNotasIncluidas = new DataTable();
        public InclusaoNotasIndividuais()
        {
            InitializeComponent();
            dtNotasIncluidas.Columns.Add("Numero Documento Totvs", typeof(string));
            dtNotasIncluidas.Columns.Add("IDMOV", typeof(string));
            dtNotasIncluidas.Columns.Add("Numero Documento", typeof(string));
            dtNotasIncluidas.Columns.Add("Data Importacao", typeof(DateTime));

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
            try
            {
                ProcessStatusManager.Start();
                var (dtResultado, mensagemRetorno, isWork) = await usecase.Execute(notas, dataInicio, dataFim);
                if (isWork)
                {
                    MessageBox.Show(
                        mensagemRetorno,
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                     );
                    
                    InsereValorNoDataTable(dtResultado);
                }
                else
                {
                    MessageBox.Show(
                        mensagemRetorno,
                        "Erro na importação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    RetornoEmTabela notasNaoImportadas = new RetornoEmTabela(dtResultado);
                    return;
                }
                
            }
            catch (Exception ex)
            {
                ProcessStatusManager.Error(ex);
                return;
            }
            finally
            {
                ProcessStatusManager.Stop();
            }
        }
        public void InsereValorNoDataTable(DataTable resultado)
        {
            if(resultado.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Nenhuma linha para retorno",
                    "Retorno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }
            foreach(DataRow row in resultado.Rows)
            {
                DataRow novaLinha = dtNotasIncluidas.NewRow();
                novaLinha["IDMOV"] = row["IDMOV"];
                novaLinha["Numero Documento Totvs"] = row["NumeroDocumentoTotvs"];
                novaLinha["Numero Documento"] = row["NumeroDocumento"];
                novaLinha["Data Importacao"] = row["DataImportacao"];

                dtNotasIncluidas.Rows.Add(novaLinha);
            }
            AtualizaDataGridView();
        }

        public void AtualizaDataGridView()
        {
            dvgNotasIncluidas.DataSource = dtNotasIncluidas;
        }
    }
}
