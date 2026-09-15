using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Banco;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dados;
using SolfarmaGp.Controllers.UseCase.Contabil.Tiktok;
using SolfarmaGp.Controllers.Utils.EnumerableToDateTable;
using SolfarmaGp.UI.ComponentesTelaUI;
using SolfarmaGp.UI.ComponentesTelaUI.Tabelas.UIRetornoEmTabela;
using SolfarmaGp.UI.MenusUI.Contabil.ParametrizacaoConferencia;
using SolfarmaGp.UI.Utils;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Text;
using static SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.ConsultaLancamentoContabilParametrizadoUseCase;
using static SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dados.ConsultaLancamentoContabilParametrizadoDadosUseCase;
using static SolfarmaGp.Controllers.UseCase.Contabil.Tiktok.BuscaParametrizacaoContabilTiktokUseCase;


namespace SolfarmaGp.UI.MenusUI.Contabil.ConferenciaBoleto
{
    public partial class ConfereciaBoleto : Form
    {
        public class ConferenciaResultado
        {
            public string ContaDebito { get; set; }
            public string ContaCredito { get; set; }
            public string Valor { get; set; }
            public string CodigoHistorico { get; set; }
            public string Complemento { get; set; }
            public int Filial { get; set; }
            public DateTime DataDocumento { get; set; }
            public string ContaCompletaDebito { get; set; }
            public string ContaCompletaCredito { get; set; }
        }

        // IDComplemento não serve mais como chave: cada marca/loja (IDBanco) tem seus próprios IDs de
        // complemento na tblContabilConferenciaRecebimentosComplemento. A categoria é identificada pelo
        // sufixo padronizado do texto do complemento (ex.: "(FRETE)", "(COMISSAO)"), que se repete igual
        // em todas as marcas.
        private static readonly Dictionary<string, string> CategoriaPorMetricaTiktok = new()
        {
            { "VendasLiquidas", "VendasLiquidas" },
            { "CustoFrete", "CustoFrete" },
            { "TaxaSFP", "TaxaSFP" },
            { "TaxaItem", "TaxaItem" },
            { "ICMSDifal", "ICMSDifal" },
            { "ComissaoAfiliados", "ComissaoAfiliados" },
            { "ReembolsoLogistica", "ReembolsoLogistica" },
            { "ReembolsoTiktok", "ReembolsoTiktok" },
            { "TarifaComissao", "ComissaoAfiliados" },
        };

        private static string ClassificaCategoriaTiktok(string complemento)
        {
            string texto = (complemento ?? "").ToUpperInvariant();

            if (texto.Contains("(FRETE)")) return "CustoFrete";
            if (texto.Contains("(TAXA DE SERVIÇO SFP)")) return "TaxaSFP";
            if (texto.Contains("(TAXAS)")) return "TaxaItem";
            if (texto.Contains("(ICMS DIFAL)")) return "ICMSDifal";
            if (texto.Contains("(COMISSAO)")) return "ComissaoAfiliados";
            if (texto.Contains("(REEMBOLSO LOGISTICA)")) return "ReembolsoLogistica";
            if (texto.Contains("(REEMBOLSO TIK TOK)")) return "ReembolsoTiktok";
            return "VendasLiquidas"; // sem sufixo entre parênteses = linha "base" da marca
        }

        private List<ConferenciaResultado> listaResultado = new();
        private BindingList<ConferenciaResultado> listaExibida = new();
        private BindingSource bsConferencia = new();

        public ConfereciaBoleto()
        {
            InitializeComponent();
            ExcelPackage.License.SetNonCommercialPersonal("SolfarmaGP");
            cbColigada.Items.Add(10);
            cbColigada.Items.Add(3);
            gbFiltros.Enabled = false;
            dtpDocumento.Enabled = false;
            checkDataFiltro.Checked = false;
            chkBoxComum.Checked = true;

            bsConferencia.DataSource = listaExibida;
            dvgConferencia.DataSource = bsConferencia;

            AtualizaControlesPorTipoProcesso();
        }

        private void chkBoxComum_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaControlesPorTipoProcesso();
            chkBoxTikTok.Checked = !chkBoxComum.Checked;
        }

        private void chkBoxTikTok_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaControlesPorTipoProcesso();
            chkBoxComum.Checked = !chkBoxTikTok.Checked;
        }

        private void AtualizaControlesPorTipoProcesso()
        {
            bool comum = chkBoxComum.Checked;
            bool tiktok = chkBoxTikTok.Checked;

            btnBuscarBase.Enabled = !comum;
            btnTotaisOutros.Enabled = !comum && tiktok;

            btnImportarArquivo.Enabled = !tiktok;
            tbValor.Enabled = !tiktok;
            tbValorReferente.Enabled = !tiktok;
            tbCreditoTotal.Enabled = !tiktok;
            tbDebitoTotal.Enabled = !tiktok;                       

        }

        private void CarregarGrid(IEnumerable<ConferenciaResultado> dados)
        {
            listaExibida = new BindingList<ConferenciaResultado>(dados.ToList());
            bsConferencia.DataSource = listaExibida;

            if (dvgConferencia.Columns["ContaCompletaDebito"] != null)
                dvgConferencia.Columns["ContaCompletaDebito"].Visible = false;

            if (dvgConferencia.Columns["ContaCompletaCredito"] != null)
                dvgConferencia.Columns["ContaCompletaCredito"].Visible = false;

            if (dvgConferencia.Columns["DataDocumento"] != null)
                dvgConferencia.Columns["DataDocumento"].DefaultCellStyle.Format = "dd/MM/yyyy";

            AtualizarTotal(listaExibida);
        }
        private void AtualizarTotal(IEnumerable<ConferenciaResultado> lista)
        {
            decimal valorTotal = lista.Sum(x => Convert.ToDecimal(x.Valor));

            tbValorReferente.Text = valorTotal.ToString();
        }

        private void btnImportarArquivo_Click(object sender, EventArgs e)
        {


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Selecione o arquivo Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        FileInfo fileInfo = new FileInfo(filePath);

                        txtFileName.Text = fileInfo.Name;

                        using (ExcelPackage package = new ExcelPackage(fileInfo))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                            if (worksheet.Dimension == null)
                            {
                                MessageBox.Show("A planilha está vazia.");
                                return;
                            }

                            DataTable dt = new DataTable();

                            bool hasHeader = true;

                            // Criar colunas
                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                string columnName = hasHeader
                                    ? worksheet.Cells[1, col].Text
                                    : $"Column {col}";

                                dt.Columns.Add(string.IsNullOrWhiteSpace(columnName)
                                    ? $"Column {col}"
                                    : columnName);
                            }

                            int startRow = hasHeader ? 2 : 1;

                            // Preencher linhas
                            for (int row = startRow; row <= worksheet.Dimension.End.Row; row++)
                            {
                                DataRow newRow = dt.NewRow();

                                for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                                {
                                    newRow[col - 1] = worksheet.Cells[row, col].Text;
                                }

                                dt.Rows.Add(newRow);
                            }

                            dvgRelacaoBoletos.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao importar o arquivo:\n" + ex.Message);
                    }
                    finally
                    {
                        if (dvgRelacaoBoletos.DataSource is DataTable dt && dt.Rows.Count > 0)
                        {
                            DataTable dtBaseImportada = (DataTable)dvgRelacaoBoletos.DataSource;
                            tbCreditoTotal.Text = dtBaseImportada.AsEnumerable()
                                .Where(row =>
                                    row.Field<string>("Movimentacao")?.Trim().Equals("C", StringComparison.OrdinalIgnoreCase) == true ||
                                    row.Field<string>("Movimentacao")?.Trim().Equals("Crédito", StringComparison.OrdinalIgnoreCase) == true ||
                                    row.Field<string>("Movimentacao")?.Trim().Equals("Credito", StringComparison.OrdinalIgnoreCase) == true
                                )
                                .Sum(row => Convert.ToDecimal(row.Field<string>("Valor")))
                                .ToString();
                            tbDebitoTotal.Text = dtBaseImportada.AsEnumerable()
                                .Where(row =>
                                    row.Field<string>("Movimentacao")?.Trim().Equals("D", StringComparison.OrdinalIgnoreCase) == true ||
                                    row.Field<string>("Movimentacao")?.Trim().Equals("Débito", StringComparison.OrdinalIgnoreCase) == true ||
                                    row.Field<string>("Movimentacao")?.Trim().Equals("Debito", StringComparison.OrdinalIgnoreCase) == true
                                )
                                .Sum(row => Convert.ToDecimal(row.Field<string>("Valor")))
                                .ToString();
                        }


                    }
                }
            }

        }

        private async void btnBuscarBase_Click(object sender, EventArgs e)
        {
            if (chkBoxTikTok.Checked)
            {
                await BuscarBaseTiktok();
            }
            else if (chkBoxComum.Checked)
            {
                btnImportarArquivo_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Selecione o tipo de processo: Comum ou TikTok.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTotaisOutros_Click(object sender, EventArgs e)
        {
            if (dvgRelacaoBoletos.DataSource is not DataTable dt || dt.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados na base para somar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ResultadosEmTela.ItemResultado> itens = new();

            foreach (DataColumn coluna in dt.Columns)
            {
                if(coluna.ColumnName == "IDLancamento")
                    continue;
                if (!EhTipoNumerico(coluna.DataType))
                    continue;

                decimal soma = dt.AsEnumerable()
                    .Where(row => row[coluna] != DBNull.Value)
                    .Sum(row => Convert.ToDecimal(row[coluna]));

                itens.Add(new ResultadosEmTela.ItemResultado { Label = coluna.ColumnName, Valor = soma.ToString("N2") });
            }

            if (itens.Count == 0)
            {
                MessageBox.Show("Nenhuma coluna numérica encontrada para somar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (ResultadosEmTela form = new ResultadosEmTela(itens))
            {
                form.ShowDialog();
            }
        }

        private static bool EhTipoNumerico(Type tipo)
        {
            return tipo == typeof(int) || tipo == typeof(long) || tipo == typeof(short) ||
                   tipo == typeof(decimal) || tipo == typeof(double) || tipo == typeof(float) ||
                   tipo == typeof(byte);
        }

        private async Task BuscarBaseTiktok()
        {
            try
            {
                BuscaExtratoTiktokLancamentoUseCase usecase = new BuscaExtratoTiktokLancamentoUseCase();
                DataTable dt = await usecase.Execute();

                txtFileName.Text = "Extrato TikTok";
                dvgRelacaoBoletos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar a base do TikTok:\n" + ex.Message);
            }
        }

        private async void btnConferencia_Click(object sender, EventArgs e)
        {

            DataTable dtProcesso = (DataTable)dvgRelacaoBoletos.DataSource;

            if (chkBoxTikTok.Checked)
            {
                if (dtProcesso == null || dtProcesso.Rows.Count < 1)
                {
                    MessageBox.Show("Não foi possivel Localizar base importada"); return;
                }
                if (tbCodPessoa.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Necessário informar o codigo da pessoa"); return;
                }
                if (tbFilial.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Necessário informar Filial"); return;
                }
                if (cbColigada.SelectedItem == null)
                {
                    MessageBox.Show("Necessário selecionar coligada"); return;
                }

                var numberFilialTiktok = Convert.ToInt32(tbFilial.Text);
                var numberColigadaTiktok = Convert.ToInt32(cbColigada.Text);
                var numberBancoTiktok = Convert.ToInt32(cbBanco.SelectedValue);

                if (!ConfirmaGeracaoConferencia(cbBanco.Text))
                    return;

                await ExecutaConferenciaTiktok(dtProcesso, numberFilialTiktok, numberColigadaTiktok, numberBancoTiktok);
                return;
            }

            if (tbFilial.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Necessário informar Filial"); return;
            }
            if (cbColigada.SelectedItem == null)
            {
                MessageBox.Show("Necessário selecionar coligada"); return;
            }
            if (dtProcesso.Rows.Count < 1 || dtProcesso == null)
            {
                MessageBox.Show("Não foi possivel Localizar base importada"); return;
            }
            if (tbCodPessoa.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Necessário informar o codigo da pessoa"); return;
            }
            var numberFilial = Convert.ToInt32(tbFilial.Text);
            var numberColigada = Convert.ToInt32(cbColigada.Text);
            var numberBanco = Convert.ToInt32(cbBanco.SelectedValue);

            if (!ConfirmaGeracaoConferencia(cbBanco.Text))
                return;

            var result = await VerificaSeExisteValorEmParametros(numberFilial, numberColigada, numberBanco, dtProcesso);
            if (result != 1) { return; }
            await ExecutaConferencia(dtProcesso, numberFilial, numberColigada, numberBanco);
        }
        public async Task<int> VerificaSeExisteValorEmParametros(int numberFilial, int numberColigada, int numberBanco, DataTable dtProcesso)
        {
            ConsultaLancamentoContabilParametrizadoDadosUseCase usecase = new ConsultaLancamentoContabilParametrizadoDadosUseCase();
            DataTable dtParametros = await usecase.Execute(new ObjetoPesquisaParametrosContabilDados { CodColigada = numberColigada, banco = numberBanco, filial = numberFilial, reduzidoCredito = 0, reduzidoDebito = 0 });

            List<string> listaComplementos = dtParametros
                .AsEnumerable()
                .Select(row => row.Field<string>("DescricaoExtrato")?.Trim())
                .Where(x => !string.IsNullOrEmpty(x))
                .Distinct()
                .ToList();



            List<string> listaParametrosNaoEncontrado = dtProcesso
                .AsEnumerable()
                .Where(row =>
                {
                    string movimentacao = row.Field<string>("Movimentacao")?.Trim();


                    return string.Equals(movimentacao, "C", StringComparison.OrdinalIgnoreCase)
                        || string.Equals(movimentacao, "Crédito", StringComparison.OrdinalIgnoreCase)
                        || string.Equals(movimentacao, "Credito", StringComparison.OrdinalIgnoreCase);
                })
                .Select(row => row.Field<string>("Complemento")?.Trim())
                .Where(x => !string.IsNullOrEmpty(x))
                .Distinct()
                .Except(listaComplementos)
                .ToList();


            if (listaParametrosNaoEncontrado.Count > 0)
            {
                DataTable dtParametrosNaoEncontrados = new DataTable();

                dtParametrosNaoEncontrados.Columns.Add("CodContaDebito", typeof(int));
                dtParametrosNaoEncontrados.Columns.Add("CodContaCredito", typeof(int));
                dtParametrosNaoEncontrados.Columns.Add("CodHistorico", typeof(int));
                dtParametrosNaoEncontrados.Columns.Add("Complemento", typeof(int));
                dtParametrosNaoEncontrados.Columns.Add("DescricaoExtrato", typeof(string));
                dtParametrosNaoEncontrados.Columns.Add("Filial", typeof(int));
                dtParametrosNaoEncontrados.Columns.Add("CodColigada", typeof(int));
                dtParametrosNaoEncontrados.Columns.Add("CodBanco", typeof(int));

                foreach (string descricaoExtrato in listaParametrosNaoEncontrado)
                {
                    DataRow row = dtParametrosNaoEncontrados.NewRow();

                    row["CodContaDebito"] = DBNull.Value;
                    row["CodContaCredito"] = DBNull.Value;
                    row["CodHistorico"] = DBNull.Value;
                    row["Complemento"] = DBNull.Value;

                    row["DescricaoExtrato"] = descricaoExtrato;
                    row["Filial"] = numberFilial;
                    row["CodColigada"] = numberColigada;
                    row["CodBanco"] = numberBanco;
                    dtParametrosNaoEncontrados.Rows.Add(row);
                }
                //dtParametrosNaoEncontrados.Rows.Add(0, 0, 0, descricaoExtrato, descricaoExtrato, numberFilial, numberColigada, numberBanco);

                string mensagem = "Os seguintes complementos não foram encontrados nos parâmetros:\n" + string.Join("\n", listaParametrosNaoEncontrado);
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult result = MessageBox.Show("Deseja inserir os complementos não encontrados nos parâmetros?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Lógica para inserir os complementos não encontrados nos parâmetros
                    using (var form = new AdicionaParametroResumido(dtParametrosNaoEncontrados))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            // Continua aqui depois que o usuário confirmar
                        }
                        else
                        {
                            // O usuário cancelou a operação, então você pode optar por não fazer nada ou fechar a aplicação, dependendo do seu fluxo
                        }
                    }
                    //MessageBox.Show("Complementos inseridos nos parâmetros com sucesso!");
                }

            }
            return 1;

        }

        private bool ConfirmaGeracaoConferencia(string banco)
        {
            string mensagem = "Confirma a geração da conferência com os dados abaixo?\n\n" +
                $"Código de Lote: {tbCodPessoa.Text}\n" +
                $"Coligada: {cbColigada.Text}\n" +
                $"Banco: {banco}\n" +
                $"Filial: {tbFilial.Text}";

            DialogResult resposta = MessageBox.Show(mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resposta == DialogResult.Yes;
        }

        public async Task ExecutaConferencia(DataTable dt, int filial, int codColigada, int banco)
        {
            ConsultaLancamentoContabilParametrizadoUseCase usecase = new ConsultaLancamentoContabilParametrizadoUseCase();
            ObjetoPesquisaParametrosContabil objPesquisa = new ObjetoPesquisaParametrosContabil
            {
                CodColigada = codColigada,
                filial = filial,
                banco = banco,
                reduzidoCredito = 0,
                reduzidoDebito = 0
            };
            DataTable dtParametros = await usecase.Execute(objPesquisa);

            int coligada = int.Parse(cbColigada.Text);

            var resultado = from baseImportada in dt.AsEnumerable()
                            from baseParametros in dtParametros.AsEnumerable()

                            let complemento = NormalizaTextoComparacao.Normalizar(baseImportada.Field<string>("Complemento") ?? "")
                            let descricao = NormalizaTextoComparacao.Normalizar(baseParametros.Field<string>("DescricaoExtrato") ?? "")

                            //let palavras = descricao.Split(' ', StringSplitOptions.RemoveEmptyEntries)

                            //let palavras = baseParametros.Field<string>("DescricaoExtrato")
                            //               .Split(' ', StringSplitOptions.RemoveEmptyEntries)

                            where
                                baseParametros.Field<int>("CodColigada") == coligada
                                && (
                                    baseImportada.Field<string>("Movimentacao")?.Trim().Equals("C", StringComparison.OrdinalIgnoreCase) == true ||
                                    baseImportada.Field<string>("Movimentacao")?.Trim().Equals("Crédito", StringComparison.OrdinalIgnoreCase) == true ||
                                    baseImportada.Field<string>("Movimentacao")?.Trim().Equals("Credito", StringComparison.OrdinalIgnoreCase) == true
                                   )
                                && baseParametros.Field<int>("Filial") == filial
                                && baseParametros.Field<int>("CodBanco") == banco
                                && complemento.Equals(descricao, StringComparison.OrdinalIgnoreCase)
                            //&& palavras.All(p =>
                            //        complemento.Contains(p, StringComparison.OrdinalIgnoreCase))
                            select new ConferenciaResultado
                            {
                                ContaDebito = baseParametros.Field<int>("CodContaDebito").ToString() ?? "",
                                ContaCredito = baseParametros.Field<int>("CodContaCredito").ToString() ?? "",
                                Valor = Convert.ToDecimal(baseImportada.Field<string>("Valor")).ToString() ?? "",
                                CodigoHistorico = baseParametros.Field<string>("CodHistorico").ToString() ?? "",
                                Complemento = baseParametros.Field<string>("Complemento") ?? "",
                                Filial = baseParametros.Field<int?>("Filial") ?? 0,
                                DataDocumento = Convert.ToDateTime(baseImportada.Field<string>("Data")),
                                ContaCompletaDebito = baseParametros.Field<string>("ContaCompletaDebito"),
                                ContaCompletaCredito = baseParametros.Field<string>("ContaCompletaCredito"),
                            };
            listaResultado = resultado.ToList();

            //dvgConferencia.Columns["ContaCompletaDebito"].Visible = false;
            //dvgConferencia.Columns["ContaCompletaCredito"].Visible = false;
            //dvgConferencia.Columns["DataDocumento"].DefaultCellStyle.Format = "dd/MM/yyyy";

            //decimal valorTotal = listaResultado.Sum(row => Convert.ToDecimal(row.Valor, new CultureInfo("en-US")));
            //tbValor.Text = valorTotal.ToString("N2", new CultureInfo("en-US"));
            //tbValorReferente.Text = valorTotal.ToString("N2", new CultureInfo("en-US"));            
            CarregarGrid(listaResultado);

            tbValor.Text = listaResultado
                .Sum(x => Convert.ToDecimal(x.Valor))
                .ToString();

            MessageBox.Show("Conferencia Finalizada");
            gbFiltros.Enabled = true;

        }


        public async Task ExecutaConferenciaTiktok(DataTable dtExtrato, int filial, int codColigada, int idBanco)
        {
            BuscaParametrizacaoContabilTiktokUseCase usecase = new BuscaParametrizacaoContabilTiktokUseCase();
            DataTable dtParametros = await usecase.Execute(new ObjetoPesquisaParametrosTiktok { CodColigada = codColigada, Filial = filial, IDBanco = idBanco });

            Dictionary<(string Categoria, string Sinal), DataRow> lookup = dtParametros.AsEnumerable()
                .GroupBy(row => (Categoria: ClassificaCategoriaTiktok(row.Field<string>("Complemento")), Sinal: row.Field<string>("Sinal")?.Trim()))
                .ToDictionary(g => g.Key, g => g.First());

            List<string> naoEncontrados = new();
            List<ConferenciaResultado> resultado = new();

            foreach (DataRow linha in dtExtrato.AsEnumerable())
            {
                DateTime data = linha.Field<DateTime>("DataDemonstrativo");

                foreach (KeyValuePair<string, string> mapeamento in CategoriaPorMetricaTiktok)
                {
                    if (!dtExtrato.Columns.Contains(mapeamento.Key))
                        continue;

                    decimal? valorNullable = linha.Field<decimal?>(mapeamento.Key);
                    if (valorNullable is null || valorNullable == 0)
                        continue;

                    decimal valor = valorNullable.Value;
                    string sinal = valor >= 0 ? "POSITIVO" : "NEGATIVO";

                    if (!lookup.TryGetValue((mapeamento.Value, sinal), out DataRow parametro))
                    {
                        naoEncontrados.Add($"{mapeamento.Key} ({sinal})");
                        continue;
                    }

                    resultado.Add(new ConferenciaResultado
                    {
                        ContaDebito = parametro.Field<string>("CodContaDebito")?.Trim() ?? "",
                        ContaCredito = parametro.Field<string>("CodContaCredito")?.Trim() ?? "",
                        Valor = Math.Abs(valor).ToString(),
                        CodigoHistorico = parametro.Field<string>("CodHistorico")?.Trim() ?? "",
                        Complemento = parametro.Field<string>("Complemento") ?? "",
                        Filial = parametro.Field<int?>("Filial") ?? filial,
                        DataDocumento = data,
                        ContaCompletaDebito = parametro.Field<string>("ContaCompletaDebito"),
                        ContaCompletaCredito = parametro.Field<string>("ContaCompletaCredito"),
                    });
                }
            }

            if (naoEncontrados.Count > 0)
            {
                string mensagem = "As seguintes métricas não possuem parametrização cadastrada para Filial/Coligada informados:\n" + string.Join("\n", naoEncontrados.Distinct());
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            listaResultado = resultado;
            CarregarGrid(listaResultado);

            tbValor.Text = listaResultado
                .Sum(x => Convert.ToDecimal(x.Valor))
                .ToString();

            MessageBox.Show("Conferencia TikTok Finalizada");
            gbFiltros.Enabled = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string valorContaDebito = NormalizarFiltro.Normalizar(tbContaDebito.Text);
            string valorContaCredito = NormalizarFiltro.Normalizar(tbContaCredito.Text);
            string valorComplemento = NormalizarFiltro.Normalizar(tbComplemento.Text);
            string valorHistorico = NormalizarFiltro.Normalizar(tbHistorico.Text);
            string valorDocumento = NormalizarFiltro.Normalizar(tbValorDocumento.Text);
            DateTime valorData = dtpDocumento.Value.Date;

            //List<ConferenciaResultado> listaResultado = (List<ConferenciaResultado>)dvgConferencia.DataSource;

            if (string.IsNullOrWhiteSpace(valorContaDebito) &&
               string.IsNullOrWhiteSpace(valorContaCredito) &&
               string.IsNullOrWhiteSpace(valorComplemento) &&
               string.IsNullOrWhiteSpace(valorHistorico) &&
               string.IsNullOrWhiteSpace(valorDocumento) &&
               checkDataFiltro.Checked == false
               )
            {
                MessageBox.Show("Informe ao menos um filtro para realizar a busca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var filtrado = listaResultado
                .AsEnumerable()
                .Where(x =>
                    (string.IsNullOrWhiteSpace(valorContaDebito) || NormalizarFiltro.Normalizar(x.ContaDebito).Contains(valorContaDebito)) &&
                    (string.IsNullOrWhiteSpace(valorContaCredito) || NormalizarFiltro.Normalizar(x.ContaCredito).Contains(valorContaCredito)) &&
                    (string.IsNullOrWhiteSpace(valorComplemento) || NormalizarFiltro.Normalizar(x.Complemento).Contains(valorComplemento)) &&
                    (string.IsNullOrWhiteSpace(valorHistorico) || NormalizarFiltro.Normalizar(x.CodigoHistorico).Contains(valorHistorico)) &&
                    (string.IsNullOrWhiteSpace(valorDocumento) || NormalizarFiltro.Normalizar(x.Valor).Contains(valorDocumento)) &&
                    (!checkDataFiltro.Checked || x.DataDocumento.Date == valorData.Date)
                )
                .ToList();
            CarregarGrid(filtrado);
            //dvgConferencia.DataSource = filtrado;
            tbValorReferente.Text = filtrado.Sum(x => Convert.ToDecimal(x.Valor)).ToString();
        }


        private void btnGeraLote_Click(object sender, EventArgs e)
        {
            //var lista = (List<ConferenciaResultado>)dvgConferencia.DataSource;
            var lista = ((BindingList<ConferenciaResultado>)bsConferencia.DataSource)
                .ToList();
            //var lista = (List<ConferenciaResultado>)bsConferencia.DataSource;
            DataTable dt = new DataTable();
            dt = ConverteEnumerableParaDataTable(lista);
            string retorno = GeraLoteDrogaCentro(dt);
            SalvaArquivoTexto(retorno);

        }
        public void SalvaArquivoTexto(string resultado)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo de Importação (*.txt)|*.txt";
                saveFileDialog.Title = "Salvar arquivo de conciliação";
                saveFileDialog.FileName = $"Conciliação Coligada {cbColigada.Text} - Filial {tbFilial.Text}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Encoding encoding = Encoding.GetEncoding(1252); //ANSI

                    File.WriteAllText(saveFileDialog.FileName, resultado, encoding);

                    MessageBox.Show("Arquivo gerado com sucesso!");
                }
            }
        }
        public string GeraLoteDrogaCentro(DataTable dt)
        {
            var sb = new StringBuilder();

            var grupos = dt.AsEnumerable()
                .GroupBy(x => x.Field<DateTime>("DataDocumento"))
                .OrderBy(x => x.Key);
            string codPessoa = tbCodPessoa.Text;
            string codPessoaFormatado = codPessoa.PadLeft(15, '0');

            foreach (var grupo in grupos)
            {
                var data = grupo.Key;

                sb.AppendLine($"M;{codPessoaFormatado};CONCILIACAO BANCARIA;{data:dd/MM/yyyy}");
                foreach (var row in grupo)
                {
                    string contaDebito = row["ContaCompletaDebito"].ToString().Trim();
                    string contaCredito = row["ContaCompletaCredito"].ToString().Trim();
                    string valor = row["Valor"].ToString().Trim();
                    string codHistorico = row["CodigoHistorico"].ToString().Trim();
                    string complemento = row["Complemento"].ToString().Trim();
                    string filial = row["Filial"].ToString().Trim();

                    //string linha = $"*P;;{contaDebito};{contaCredito};;{valor};{codHistorico};{complemento};{filial};;;000000000000000;0000;0000000000";
                    string linha = string.Join(";", new[]
                     {
                            "*P",
                            "",
                            contaDebito,
                            contaCredito,
                            "",
                            valor,
                            codHistorico,
                            complemento,
                            filial,
                            "",
                            "",
                            "000000000000000",
                            "0000",
                            "0000000000"
                        });
                    sb.AppendLine(linha);
                }
            }
            string resultado = sb.ToString();
            return resultado;
        }

        public DataTable CriaDataTableLoteImportacao(DataTable dt, string codPessoa)
        {
            DataTable dtPreview = new DataTable();

            dtPreview.Columns.Add("DataLote", typeof(DateTime));
            dtPreview.Columns.Add("Tipo", typeof(string));
            dtPreview.Columns.Add("Linha", typeof(string));

            string codPessoaFormatado = codPessoa.PadLeft(15, '0');

            var grupos = dt.AsEnumerable()
                .OrderBy(x => x.Field<DateTime>("DataDocumento"))
                .GroupBy(x => x.Field<DateTime>("DataDocumento"));

            foreach (var grupo in grupos)
            {
                DateTime data = grupo.Key;

                string header = $"M;{codPessoaFormatado};CONCILIACAO BANCARIA;{data:dd/MM/yyyy}";

                dtPreview.Rows.Add(data, "M", header);

                foreach (var row in grupo)
                {
                    string contaDebito = row["ContaCompletaDebito"].ToString().Trim();
                    string contaCredito = row["ContaCompletaCredito"].ToString().Trim();
                    string valor = row["Valor"].ToString().Trim();
                    string codHistorico = row["CodigoHistorico"].ToString().Trim();
                    string complemento = row["Complemento"].ToString().Trim();
                    string filial = row["Filial"].ToString().Trim();
                    //$"*P;;{contaDebito};{contaCredito};;{valor};{codHistorico};{complemento};{filial};;;000000000000000;0000;0000000000"
                    string linha = string.Join(";", new[]
                    {
                        "*P",
                        "",
                        contaDebito,
                        contaCredito,
                        "",
                        valor,
                        codHistorico,
                        complemento,
                        filial,
                        "",
                        "",
                        "000000000000000",
                        "0000",
                        "0000000000"
                    });

                    dtPreview.Rows.Add(data, "P", linha);
                }
            }

            return dtPreview;
        }

        private void btnVisualiza_Click(object sender, EventArgs e)
        {
            //var lista = (List<ConferenciaResultado>)dvgConferencia.DataSource;
            //var lista = (List<ConferenciaResultado>)bsConferencia.DataSource;
            var lista = ((BindingList<ConferenciaResultado>)bsConferencia.DataSource)
                .ToList();
            DataTable dt = new DataTable();
            dt = ConverteEnumerableParaDataTable(lista);
            DataTable retorno = CriaDataTableLoteImportacao(dt, tbCodPessoa.Text);
            RetornoEmTabela viewRetorno = new RetornoEmTabela(retorno);
            viewRetorno.Show();
        }
        public DataTable ConverteEnumerableParaDataTable(List<ConferenciaResultado> lista)
        {
            DataTable dt = EnumerableToDataTable.ListToDataTable(lista);
            return dt;
        }

        private async void ConfereciaBoleto_Load(object sender, EventArgs e)
        {
            BuscaBancoIDsUseCase useCase = new BuscaBancoIDsUseCase();
            DataTable bancoIds = await useCase.Execute();

            var bancoIdsLegendasList = bancoIds.AsEnumerable()
                .Select(row => new
                {
                    idBanco = row.Field<int>("IDBanco"),
                    nome = RetornaValorNomeBanco(Convert.ToInt32(row.Field<int>("IDBanco")))

                }).ToDataTable();

            var linhaVazia = bancoIdsLegendasList.NewRow();
            linhaVazia["idBanco"] = 0;
            linhaVazia["nome"] = "";
            bancoIdsLegendasList.Rows.InsertAt(linhaVazia, 0);

            cbBanco.DataSource = bancoIdsLegendasList;
            cbBanco.DisplayMember = "nome";
            cbBanco.ValueMember = "idBanco";
        }
        private string RetornaValorNomeBanco(int id)
        {
            switch (id)
            {
                case 104:
                    return "104 - Cx Econ. Federal";
                case 111:
                    return "111 - Banco";
                case 151:
                    return "151 - Ban. Nossa Caixa S.A";
                case 197:
                    return "197 - Stone";
                case 290:
                    return "290 - PagBank";
                case 341:
                    return "341 - Itau";
                case 756:
                    return "756 - Sicoob";
                case 1:
                    return "001 - Banco do Brasil";
                case 184:
                    return "184 - Itau BBA";
                case 37244238:
                    return "TikTok - Cimed";
                case 37244239:
                    return "TikTok - Zanup";
                case 37244240:
                    return "TikTok-Loreal";
                case 37244241:
                    return "TikTok-Johnson";
                case 37244242:
                    return "TikTok-Garnier";
                case 37244243:
                    return "TikTok-Baruel Baby";
                case 37244244:
                    return "TikTok-Bom Ar";
                case 37244245:
                    return "TikTok-Eucerin";
                case 37244246:
                    return "TikTok-OX";
                case 37244247:
                    return "TikTok-Tenys Pe";
                case 37244248:
                    return "TikTok-YSL";
                default:
                    return "";
            }


        }

        private void checkDataFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDataFiltro.Checked)
            {
                dtpDocumento.Enabled = true;
            }
            else
            {
                dtpDocumento.Enabled = false;
                dtpDocumento.Value = DateTime.Now;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (bsConferencia.Current is not ConferenciaResultado item)
                return;

            listaResultado.Remove(item);
            listaExibida.Remove(item);

            AtualizarTotal(listaExibida);

            tbValor.Text = listaResultado
                .Sum(x => Convert.ToDecimal(x.Valor, new CultureInfo("en-US")))
                .ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbContaDebito.Clear();
            tbContaCredito.Clear();
            tbComplemento.Clear();
            tbHistorico.Clear();
            tbValorDocumento.Clear();

            checkDataFiltro.Checked = false;
            dtpDocumento.Enabled = false;
            dtpDocumento.Value = DateTime.Now;

            listaExibida = new BindingList<ConferenciaResultado>(listaResultado.ToList());
            bsConferencia.DataSource = listaExibida;

            AtualizarTotal(listaExibida);
        }
    }
}
