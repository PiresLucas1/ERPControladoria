using SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs;
using SolfarmaGp.UI.Utils;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace SolfarmaGp.UI.MenusUI.Fiscal.ImportarNotasFiscaisXmlPataTotvs
{
    public partial class ImportarNotasFiscaisXmlParaTotvsDetalhes : Form
    {
        private int _IDQiveArquivoXML;
        private string _numDocumento;

        private DataTable _tabela;
        private BindingSource _bs = new BindingSource();
        private DataTable _tabelaContaFinanceria;
        private BindingSource _bsContaFinanceira = new BindingSource();

        private readonly ConsultaNotasExportaTotvsDetalhes _consultaDetalhes;
        public ImportarNotasFiscaisXmlParaTotvsDetalhes(int IDQiveArquivoXML, string numDocumento, ConsultaNotasExportaTotvsDetalhes consultaDetalhes)
        {
            _IDQiveArquivoXML = IDQiveArquivoXML;
            _numDocumento = numDocumento;
            _consultaDetalhes = consultaDetalhes;
            InitializeComponent();

            AjustarFonteTextBoxesGroupBox();
            Load += ImportarNotasFiscaisXmlParaTotvsDetalhes_Load;
        }
        private async void ImportarNotasFiscaisXmlParaTotvsDetalhes_Load(object sender, EventArgs e)
        {
            await CarregarDadosAsync();

        }
        private async Task CarregarDadosAsync()
        {
            try
            {
                var dtRetorno = await _consultaDetalhes.Executar(_IDQiveArquivoXML);

                DataTable dtNotaItens = dtRetorno.Item1;
                DataTable dtNotaContaFinanceira = dtRetorno.Item2;

                _tabela = dtNotaItens;
                _bs.DataSource = _tabela;

                _tabelaContaFinanceria = dtNotaContaFinanceira;
                _bsContaFinanceira.DataSource = _tabelaContaFinanceria;

                dvgContaFinanceira.DataSource = _bsContaFinanceira;
                AjustaTela();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocorreu um erro ao carregar os detalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AjustaTela()
        {
            AdicionarColunaEditavel();

            dvgDataNotaItens.Columns["IDQiveArquivoXML"].Visible = false;
            dvgDataNotaItens.Columns["ChaveAcesso"].Visible = false;
            dvgDataNotaItens.Columns["ERP_IDContasPagar"].Visible = false;
            dvgDataNotaItens.Columns["CNPJFornecedor"].Visible = false;
            dvgDataNotaItens.Columns["NomeFornecedor"].Visible = false;
            dvgDataNotaItens.Columns["UnidadeComercial"].Visible = false;



            tbIdQive.Text = _tabela.Rows[0]["IDQiveArquivoXML"].ToString();
            tbNumDoc.Text = _numDocumento;
            tbIdContasPagar.Text = _tabela.Rows[0]["ERP_IDContasPagar"].ToString();
            tbCodFornecedor.Text = _tabela.Rows[0]["CNPJFornecedor"].ToString();
            tbNomeFornecedor.Text = _tabela.Rows[0]["NomeFornecedor"].ToString();

            tbChaveAcesso.Text = _tabela.Rows[0]["ChaveAcesso"].ToString();

            
        }
        private void AjustarFonteTextBoxesGroupBox()
        {
            foreach (Control controle in gpHeader.Controls)
            {
                if (controle is TextBox textBox)
                {
                    textBox.Font = new Font(textBox.Font.FontFamily, 8, textBox.Font.Style);
                }
            }
        }
        private void AdicionarColunaEditavel()
        {
            if (!_tabela.Columns.Contains("Natureza"))
            {
                _tabela.Columns.Add("Natureza", typeof(string));
            }

            _bs.DataSource = _tabela;
            dvgDataNotaItens.DataSource = _bs;
            var indexColunaNatureza = dvgDataNotaItens.Columns["CFOP"].Index;

            dvgDataNotaItens.Columns["Natureza"].HeaderText = "Natureza Fiscal";
            dvgDataNotaItens.Columns["Natureza"].ReadOnly = false;
            dvgDataNotaItens.Columns["Natureza"].DisplayIndex = indexColunaNatureza + 1;
            
            ValidaColunasIBSCBS();
        }

        private void btnLancarNota_Click(object sender, EventArgs e)
        {

        }

        private async void btnAbrirXml_Click(object sender, EventArgs e)
        {
            ConsultarXmlNotaQiveUseCase useCase = new ConsultarXmlNotaQiveUseCase();
            string result = await useCase.Executar(_IDQiveArquivoXML);
            string stringFormattedToXMl = FormatarXml.Executar(result);

            VisualizarXML(stringFormattedToXMl);

        }
        private void VisualizarXML(string xml)
        {
            string caminhoTemp = Path.Combine(Path.GetTempPath(), "VisualizarXml.xml");
            File.WriteAllText(caminhoTemp,xml, Encoding.UTF8);

            Process.Start(new ProcessStartInfo
            {

                FileName = caminhoTemp,
                UseShellExecute = true
            });
        }
        private void ValidaColunasIBSCBS()
        {
            bool flagIBS = false;
            foreach (DataRowView row in _bs)
            {
                int rowIndex = _bs.IndexOf(row);

                if (Convert.ToDecimal(row["Valor IBS UF"]) == 9999 || Convert.ToDecimal(row["Valor IBS Mun."]) == 9999)
                {
                    dvgDataNotaItens.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    dvgDataNotaItens.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    flagIBS = true;

                    /*zera o campo ibs*/
                    row["Valor IBS UF"] = 0;
                    row["Valor IBS Mun."] = 0;
                }   
            }            
            if (flagIBS)
            {
                MessageBox.Show("As colunas IBS e CBS não foram localizadas no XML, valide o XML se for preciso .", "Colunas não localizadas no XML", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
