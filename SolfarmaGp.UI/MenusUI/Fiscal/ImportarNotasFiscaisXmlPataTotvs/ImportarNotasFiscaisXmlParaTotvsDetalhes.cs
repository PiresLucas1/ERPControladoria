using SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.Fiscal.ImportarNotasFiscaisXmlPataTotvs
{
    public partial class ImportarNotasFiscaisXmlParaTotvsDetalhes : Form
    {
        private int _IDQiveArquivoXML;
        private string _numDocumento;
        private DataTable _tabela;
        private BindingSource _bs = new BindingSource();
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
                DataTable dtRetorno = await _consultaDetalhes.Executar(_IDQiveArquivoXML);
                _tabela = dtRetorno;
                _bs.DataSource = _tabela;                
                AjustaTela();
            }
            catch (Exception ex) { 
            
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
            dvgDataNotaItens.Columns["UnidadeComercial"].Visible =false;
            


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

            dvgDataNotaItens.Columns["Natureza"].HeaderText = "Observação";
            dvgDataNotaItens.Columns["Natureza"].ReadOnly = false;
        }

    }
}
