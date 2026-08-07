using SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisParaTotvs;
using SolfarmaGp.UI.ComponentesTelaUI.ProcessoCarregamento.UIStatusDoProcessos;
using SolfarmaGp.UI.ComponentesTelaUI.Tabelas.UIRetornoEmTabela;
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
            if(!_tabela.Columns.Contains("Selecionado"))
            {
                _tabela.Columns.Add("Selecionado", typeof(bool));
            }




            dvgDataNotaItens.ReadOnly = false;
            _bs.DataSource = _tabela;
            dvgDataNotaItens.DataSource = _bs;

            dvgDataNotaItens.Columns["Selecionado"].DisplayIndex = 1;
            dvgDataNotaItens.Columns["Selecionado"].HeaderText = "*";

            var indexColunaNatureza = dvgDataNotaItens.Columns["CFOP"].Index;

            dvgDataNotaItens.Columns["Natureza"].HeaderText = "Natureza Fiscal";
            //dvgDataNotaItens.Columns["Natureza"].ReadOnly = false;
            dvgDataNotaItens.Columns["Natureza"].DisplayIndex = indexColunaNatureza + 1;
            // e trava todas as outras colunas manualmente
            foreach (DataGridViewColumn col in dvgDataNotaItens.Columns)
            {
                col.ReadOnly = (col.Name != "Natureza" && col.Name != "Selecionado");
            }
            if (!_tabela.Columns.Contains("Selecionado"))
            {
                _tabela.Columns.Add("Selecionado", typeof(bool));
                _tabela.Columns["Selecionado"].DefaultValue = false;
            }

            var resultadoValidaColunasIBSCBS = ValidaColunasIBSCBS();

            
                //MessageBox.Show("As colunas IBS e CBS não foram localizadas no XML, valide o XML se for preciso .", "Colunas não localizadas no XML", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async  void btnLancarNota_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)_bs.DataSource;

            Console.Write(dt);
            NotaCapa objetoNota = new NotaCapa
            {
                IDQiveArquivoXml = tbIdQive.Text,
                ChaveAcesso = tbChaveAcesso.Text,
                CnpjFornecedor = tbCodFornecedor.Text,
                IDErpContasPagar = tbIdContasPagar.Text,
                NumDocumento = tbNumDoc.Text
            };
            var itens = new List<object>();
            foreach (DataRow row in dt.Rows)
            {
                var Novoitem = new
                {
                    IDProduto = row["IDProdFornecedor"],
                    DescricaoProduto = row["DescricaoProduto"],
                    NCM = row["NCM"],
                    CEST = row["CEST"],
                    CFOP = row["CFOP"],
                    UnidadeComercial = row["UnidadeComercial"],
                    Valor = row["Valor"],
                    CodEAN = row["CodEAN"],
                    Quantidade = row["Quantidade"],
                    ValorIBSMunicipio = row["ValorIBSMunicipio"],
                    Natureza = row["Natureza"]
                };
                itens.Add(Novoitem);
            };

            var resultado = await VerificaSeProdutoExisteTotvs();
            if(resultado.Count > 0)
            {               
                MessageBox.Show("Existe produto sem cadastro na Totvs", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


           
            

                

        }
        public static DataTable ListaParaDataTable<T>(List<T> lista)
        {
            DataTable tabela = new DataTable();
            var propriedades = typeof(T).GetProperties();

            foreach (var prop in propriedades)
            {
                tabela.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in lista)
            {
                var linha = tabela.NewRow();
                foreach (var prop in propriedades)
                {
                    linha[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                tabela.Rows.Add(linha);
            }

            return tabela;
        }

       
        public async void LancamentoNota(NotaCapa nota, List<object> itensNotas)
        {
            CriarNotaDevolucaoUseCase useCase = new CriarNotaDevolucaoUseCase();
            await useCase.Executar(
                intCodColigada: 2,
                intCodFilial: 1,
                vchCodCCFO: nota.ChaveAcesso,
                vchSerieDocumento: "1", 
                vchCodTipoMovimento: "1", 
                INvchNumeroDocumento: nota.NumDocumento, 
                INvchChaveAcesso: nota.ChaveAcesso, 
                INdatDataEmissao: DateTime.Now, 
                INdatDataLancamento: DateTime.Now, 
                tvpItens: ListaParaDataTable(itensNotas));
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
            File.WriteAllText(caminhoTemp, xml, Encoding.UTF8);

            Process.Start(new ProcessStartInfo
            {

                FileName = caminhoTemp,
                UseShellExecute = true
            });
        }
        private bool ValidaColunasIBSCBS()
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
            return flagIBS;
        }

        private async void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            var linhasSelecionadas = _tabela.AsEnumerable()
                .Where(row => row.Field<bool?>("Selecionado") == true)
                .ToList();
            if(linhasSelecionadas.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   
            var resultado = await VerificaSeProdutoExisteTotvs();

            if(resultado.Count == 0)
            {
                MessageBox.Show("Todos os produtos selecionados já existem no TOTVS.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CadastrarProdutoUseCase useCase = new CadastrarProdutoUseCase();
            DataTable resultadosCadastro= new DataTable();

            foreach (DataRow row in resultado)
            {
                var descricao = row["ProdutoDescricao"]?.ToString();
                var codProduto = row["IDProdFornecedor"]?.ToString();
                var ncm = row["NCM"]?.ToString();
                var cest = row["CEST"]?.ToString();
                var codUnidade = row["UnidadeComercial"]?.ToString();
                var preco = Convert.ToDecimal(row["ValorItem"]);
                var origem = "0"; // Defina a origem conforme necessário
                var cnpjFornecedor = tbCodFornecedor.Text;
                StatusProcess processo = new StatusProcess();
                try
                {
                    ProcessStatusManager.Start("Carregando dados...");
                    ProcessStatusManager.Update("Processando...");

                    resultadosCadastro = await useCase.Executar(codProduto, descricao, ncm, cest, codUnidade, preco, origem, cnpjFornecedor);
                }
                catch (Exception ex)
                {
                    ProcessStatusManager.Stop();
                    MessageBox.Show($"Erro ao cadastrar produto '{descricao}': {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ProcessStatusManager.Stop();
                }
            }

            RetornoEmTabela retorno = new RetornoEmTabela(resultadosCadastro);
            retorno.ShowDialog();



        }
        private async Task<List<DataRow>> VerificaSeProdutoExisteTotvs()
        {
            var linhasSelecionadas = _tabela.AsEnumerable()
                .Where(row => row.Field<bool?>("Selecionado") == true)
                .ToList();
            var cnpjFornecedor = tbCodFornecedor.Text;

            if (linhasSelecionadas.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            var usecase = new ConsultaProdutoTotvsUseCase(); //controller
            var produtosEncontrados = new List<string>(); //lista de produto econtrados, produtos que não vai precisar de cadastro
            var produtosNaoEncontrados = new List<DataRow>(); // lista de produtos que não foram encontrados, produtos que vai precisar de cadastro
            var mensagensNaoEncontrados = new List<string>(); // lista de mensagens de produtos não encontrados, para exibir na tela
            var erros = new List<string>(); // lista de mensagens de erros, para exibir na tela

            foreach (DataRow row in linhasSelecionadas)
            {
                var codNoForn = row["IDProdFornecedor"]?.ToString();
                var descricaoProduto = row["ProdutoDescricao"]?.ToString();

                try
                {
                    var resultado = await usecase.Executar(codNoForn, cnpjFornecedor);

                    if (resultado.Encontrado)
                    {
                        produtosEncontrados.Add($"Fornecedor: {resultado.CodCfo} - Cod. Produto: {resultado.CodNoFornecedor}");
                    }
                    else
                    {
                        produtosNaoEncontrados.Add(row);
                        mensagensNaoEncontrados.Add($"Produto '{descricaoProduto}' (cod {codNoForn}) não encontrado no TOTVS.");
                    }
                }
                catch (Exception ex)
                {
                    erros.Add($"Erro ao consultar produto '{descricaoProduto}' (cod {codNoForn}): {ex.Message}");
                }
            }

            if (erros.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros), "Erros ao cadastrar produto(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (mensagensNaoEncontrados.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, mensagensNaoEncontrados), "Produtos não encontrados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (produtosEncontrados.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, produtosEncontrados), "Produtos encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return produtosNaoEncontrados;
        }
    }
}
