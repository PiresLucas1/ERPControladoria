using SolfarmaGp.Controllers.UseCase.Zanup;
using SolfarmaGp.Repositorios.Zanup.ExportaNotasFiscais;
using SolfarmaGp.UI.ComponentesTelaUI.Moderno;
using SolfarmaGp.UI.ComponentesTelaUI.ProcessoCarregamento.UIStatusDoProcessos;
using OfficeOpenXml;
using System.Data;
using System.Text;

namespace SolfarmaGp.UI.MenusUI.Zanup.ExportaNotasFiscais
{
    public partial class ExportaNotasFiscaisZanup : Form
    {
        public ExportaNotasFiscaisZanup()
        {
            InitializeComponent();
            dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFim.Value = DateTime.Today;
        }

        /// <summary>Lê período e filtros da tela. Devolve null (e avisa) se o período for inválido.</summary>
        private ParametrosExportaNotasZanup? LeParametros()
        {
            DateTime dataInicio = dtpInicio.Value.Date;
            DateTime dataFim = dtpFim.Value.Date;

            string? erroPeriodo = ExportaNotasFiscaisZanupUseCase.ValidaPeriodo(dataInicio, dataFim);
            if (erroPeriodo != null)
            {
                MessageBox.Show(this, erroPeriodo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new ParametrosExportaNotasZanup
            {
                DataInicio = dataInicio,
                DataFim = dataFim,
                CodTmv = txtCodTmv.Text.Trim(),
                // aceita um por linha, vírgula ou ponto e vírgula; fica no formato 192;193;194
                NumeroDocumentos = string.Join(";",
                    rtbNumeroDocumentos.Text
                        .Split(new[] { '\r', '\n', ',', ';' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            };
        }

        private async void btnSoClienteFornecedor_Click(object sender, EventArgs e) =>
            await ExecutaManual(EtapaManualZanup.ClienteFornecedor, "Cliente/Fornecedor");

        private async void btnSoProdutos_Click(object sender, EventArgs e) =>
            await ExecutaManual(EtapaManualZanup.Produtos, "Produtos");

        private async void btnSoNota_Click(object sender, EventArgs e) =>
            await ExecutaManual(EtapaManualZanup.DocumentoFiscal, "Documento fiscal");

        /// <summary>Roda uma única etapa de exportação, só com ela (as outras não são executadas).</summary>
        private async Task ExecutaManual(EtapaManualZanup etapa, string nome)
        {
            var parametros = LeParametros();
            if (parametros == null)
                return;

            string detalhe = $"Período: {parametros.DataInicio:dd/MM/yyyy} até {parametros.DataFim:dd/MM/yyyy}";
            if (etapa == EtapaManualZanup.DocumentoFiscal)
            {
                if (!string.IsNullOrWhiteSpace(parametros.NumeroDocumentos))
                    detalhe += $"\nDocumentos: {parametros.NumeroDocumentos}";
                if (!string.IsNullOrWhiteSpace(parametros.CodTmv))
                    detalhe += $"\nTipo de movimento: {parametros.CodTmv}";
            }

            DialogResult confirmacao = MessageBox.Show(this,
                $"Executar somente: {nome}\n\n{detalhe}\n\nNenhuma outra etapa será executada e nada é substituído.\n\nDeseja continuar?",
                "Confirmação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (confirmacao != DialogResult.OK)
                return;

            await Executa(
                $"Exportando {nome}...",
                1,
                aoIniciar => new ExportaNotasFiscaisZanupUseCase().ExecuteManual(parametros, etapa, aoIniciar));
        }

        private async void btnExportar_Click(object sender, EventArgs e)
        {
            var parametros = LeParametros();
            if (parametros == null)
                return;

            DialogResult confirmacao = MessageBox.Show(this,
                MontaMensagemConfirmacao(parametros),
                "Confirmação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (confirmacao != DialogResult.OK)
                return;

            await Executa(
                "Exportando notas Zanup...",
                6,
                aoIniciar => new ExportaNotasFiscaisZanupUseCase().Execute(parametros, aoIniciar));
        }

        private void DefineBotoesAtivos(bool ativos)
        {
            btnExportar.Enabled = ativos;
            btnSoClienteFornecedor.Enabled = ativos;
            btnSoProdutos.Enabled = ativos;
            btnSoNota.Enabled = ativos;
        }

        private static string MontaMensagemConfirmacao(ParametrosExportaNotasZanup p)
        {
            bool temDocumentos = !string.IsNullOrWhiteSpace(p.NumeroDocumentos);
            bool temTmv = !string.IsNullOrWhiteSpace(p.CodTmv);

            var msg = new StringBuilder();
            msg.AppendLine($"Período: {p.DataInicio:dd/MM/yyyy} até {p.DataFim:dd/MM/yyyy}");
            msg.AppendLine();
            msg.AppendLine("Serão executados, nesta ordem:");
            msg.AppendLine("1. Situação das NF-e emitidas na Sefaz");
            msg.AppendLine("2. Situação das NF-e recebidas na Sefaz");
            msg.AppendLine("3. Atualização de notas canceladas");
            msg.AppendLine("4. Exportação de Cliente/Fornecedor");
            msg.AppendLine("5. Exportação de Produtos");

            if (temDocumentos)
            {
                int qtd = p.NumeroDocumentos.Split(';', StringSplitOptions.RemoveEmptyEntries).Length;
                msg.AppendLine(qtd == 1
                    ? $"6. Documento fiscal nº {p.NumeroDocumentos}"
                    : $"6. {qtd} documentos fiscais: {p.NumeroDocumentos}");
            }
            else
            {
                msg.AppendLine("6. TODOS os documentos fiscais do período");
            }

            if (temTmv)
                msg.AppendLine($"    Somente o tipo de movimento {p.CodTmv}");

            msg.AppendLine();
            msg.AppendLine("Nenhuma etapa substitui registros existentes.");
            msg.AppendLine();
            msg.Append("Deseja continuar?");
            return msg.ToString();
        }

        private async Task Executa(
            string tituloProcesso,
            int totalEtapas,
            Func<Action<string>, Task<List<EtapaExportacaoZanup>>> executar)
        {
            DefineBotoesAtivos(false);
            rtbResultado.Clear();
            MostraPendencias(new List<PendenciaNotaZanup>());
            flpEtapas.Controls.Clear();

            List<EtapaExportacaoZanup>? etapas = null;
            Exception? falha = null;

            try
            {
                ProcessStatusManager.Start(tituloProcesso);
                int etapaAtual = 0;
                // Texto curto: o aviso de carregamento é estreito e corta mensagens longas.
                etapas = await executar(nomeEtapa =>
                    ProcessStatusManager.Update(totalEtapas > 1
                        ? $"Etapa {++etapaAtual} de {totalEtapas}: {nomeEtapa}"
                        : nomeEtapa));
            }
            catch (Exception ex)
            {
                falha = ex;
            }
            finally
            {
                // O aviso "Processando..." é TopMost: precisa fechar ANTES de qualquer MessageBox.
                ProcessStatusManager.Stop();
                DefineBotoesAtivos(true);
            }

            if (falha != null)
            {
                MessageBox.Show(this, falha.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (etapas != null)
                MostraResultado(etapas);
        }

        /// <summary>Uma linha por etapa, com ponto colorido: verde = OK, âmbar = aviso, vermelho = erro.</summary>
        private void MostraEtapas(List<EtapaExportacaoZanup> etapas)
        {
            flpEtapas.Controls.Clear();
            foreach (var etapa in etapas)
            {
                Color cor = !etapa.Sucesso ? Color.FromArgb(180, 35, 24)
                          : etapa.ComAviso ? Color.FromArgb(181, 110, 0)
                          : Color.FromArgb(39, 110, 30);

                string resumo = (etapa.Mensagem ?? "").Replace("\r", " ").Replace("\n", " ").Trim();
                if (resumo.Length > 90)
                    resumo = resumo.Substring(0, 87) + "...";

                flpEtapas.Controls.Add(new Label
                {
                    AutoSize = true,
                    ForeColor = cor,
                    Margin = new Padding(0, 0, 0, 4),
                    Text = $"●  {etapa.Nome}" + (resumo.Length > 0 ? $"  —  {resumo}" : "")
                });
            }
        }

        /// <summary>
        /// Uma aba por tipo de problema, com uma grade para o pessoal saber o que cadastrar/corrigir:
        /// produto, cliente/fornecedor, IDNAT, natureza (CFOP/regra de ICMS) e outros.
        /// Só aparecem as abas que têm registros.
        /// </summary>
        private void MostraPendencias(List<PendenciaNotaZanup> pendencias)
        {
            foreach (TabPage aba in tabResultado.TabPages.Cast<TabPage>().Where(t => t != tpLog).ToList())
            {
                tabResultado.TabPages.Remove(aba);
                aba.Dispose();
            }

            var grupos = new (string Categoria, string Titulo, string ColunaCodigo)[]
            {
                (PendenciaNotaZanup.Produto,            "Produtos",           "ID do produto"),
                (PendenciaNotaZanup.ClienteFornecedor,  "Cliente/Fornecedor", "CODCFO"),
                (PendenciaNotaZanup.Idnat,              "IDNAT",              "CFOP"),
                (PendenciaNotaZanup.Natureza,           "Naturezas",          "CFOP"),
                (PendenciaNotaZanup.Outros,             "Outros",             "Código"),
            };

            TabPage? primeira = null;
            foreach (var (categoria, titulo, colunaCodigo) in grupos)
            {
                var itens = pendencias.Where(p => p.Categoria == categoria).ToList();
                if (itens.Count == 0)
                    continue;

                var aba = new TabPage($"{titulo} ({itens.Count})") { UseVisualStyleBackColor = true };
                aba.Controls.Add(CriaGradePendencias(itens, colunaCodigo));
                tabResultado.TabPages.Add(aba);
                primeira ??= aba;
            }

            // Se há pendências, elas são o que o usuário precisa ver primeiro.
            tabResultado.SelectedTab = primeira ?? tpLog;

            bool temAbas = primeira != null;
            btnExcelAba.Enabled = temAbas;
            btnExcelTodas.Enabled = temAbas;
        }

        private static DataTable? TabelaDaAba(TabPage aba) =>
            aba.Controls.OfType<GradeModerna>().FirstOrDefault()?.DataSource as DataTable;

        /// <summary>Nome da aba sem a contagem "(n)" e sem caracteres que o Excel não aceita em nome de planilha.</summary>
        private static string NomePlanilha(TabPage aba)
        {
            string nome = aba.Text;
            int parenteses = nome.LastIndexOf(" (", StringComparison.Ordinal);
            if (parenteses > 0)
                nome = nome.Substring(0, parenteses);
            foreach (char c in new[] { '/', '\\', '?', '*', '[', ']', ':' })
                nome = nome.Replace(c, '-');
            return nome.Length > 31 ? nome.Substring(0, 31) : nome;
        }

        private void btnExcelAba_Click(object sender, EventArgs e)
        {
            TabPage aba = tabResultado.SelectedTab;
            if (aba == null || aba == tpLog || TabelaDaAba(aba) == null)
            {
                MessageBox.Show(this, "Selecione a aba de pendências (Produtos, Cliente/Fornecedor, IDNAT, Naturezas ou Outros) que deseja exportar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ExportaParaExcel(new List<TabPage> { aba }, $"Pendencias_{NomePlanilha(aba)}.xlsx");
        }

        private void btnExcelTodas_Click(object sender, EventArgs e)
        {
            var abas = tabResultado.TabPages.Cast<TabPage>().Where(t => t != tpLog && TabelaDaAba(t) != null).ToList();
            if (abas.Count == 0)
            {
                MessageBox.Show(this, "Não há pendências para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ExportaParaExcel(abas, "Pendencias_Notas_Zanup.xlsx");
        }

        /// <summary>Gera um .xlsx com uma planilha por aba informada.</summary>
        private void ExportaParaExcel(List<TabPage> abas, string nomeSugerido)
        {
            string caminho;
            using (var salvar = new SaveFileDialog
            {
                Filter = "Planilha Excel (*.xlsx)|*.xlsx",
                Title = "Salvar planilha",
                FileName = nomeSugerido
            })
            {
                if (salvar.ShowDialog(this) != DialogResult.OK)
                    return;
                caminho = salvar.FileName;
            }

            try
            {
                UseWaitCursor = true;
                ExcelPackage.License.SetNonCommercialPersonal("SolfarmaGP");

                using (var package = new ExcelPackage())
                {
                    foreach (TabPage aba in abas)
                    {
                        DataTable tabela = TabelaDaAba(aba)!;
                        ExcelWorksheet planilha = package.Workbook.Worksheets.Add(NomePlanilha(aba));
                        planilha.Cells["A1"].LoadFromDataTable(tabela, true);

                        using (var cabecalho = planilha.Cells[1, 1, 1, tabela.Columns.Count])
                            cabecalho.Style.Font.Bold = true;

                        planilha.View.FreezePanes(2, 1);
                        planilha.Cells[1, 1, Math.Max(1, tabela.Rows.Count + 1), tabela.Columns.Count].AutoFilter = true;
                        planilha.Cells.AutoFitColumns();

                        // Chave de acesso tem 44 dígitos: como texto, para o Excel não virar notação científica.
                        int colChave = tabela.Columns.IndexOf("Chave de acesso") + 1;
                        if (colChave > 0 && tabela.Rows.Count > 0)
                            planilha.Cells[2, colChave, tabela.Rows.Count + 1, colChave].Style.Numberformat.Format = "@";
                    }

                    package.SaveAs(new FileInfo(caminho));
                }
            }
            catch (IOException)
            {
                UseWaitCursor = false;
                MessageBox.Show(this, "Não foi possível gravar o arquivo. Se ele estiver aberto no Excel, feche-o e tente de novo.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                UseWaitCursor = false;
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                UseWaitCursor = false;
            }

            MessageBox.Show(this, "Planilha exportada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static GradeModerna CriaGradePendencias(List<PendenciaNotaZanup> itens, string colunaCodigo)
        {
            var tabela = new System.Data.DataTable();
            // Produto não encontrado: traz também os dados do item do XML (descrição, CFOP, quantidade, valor),
            // para o cadastro saber exatamente o que criar.
            bool ehProduto = itens.Count > 0 && itens[0].Categoria == PendenciaNotaZanup.Produto;

            tabela.Columns.Add(colunaCodigo);
            if (ehProduto)
            {
                tabela.Columns.Add("Descrição do produto");
                tabela.Columns.Add("CFOP do item");
                tabela.Columns.Add("Quantidade");
                tabela.Columns.Add("Valor total");
            }
            tabela.Columns.Add("Item");
            tabela.Columns.Add("Chave de acesso");
            tabela.Columns.Add("Série");
            tabela.Columns.Add("Emissão");
            tabela.Columns.Add("Emitente");
            tabela.Columns.Add("CNPJ emitente");
            tabela.Columns.Add("Destinatário");
            tabela.Columns.Add("CNPJ/CPF destinatário");
            tabela.Columns.Add("UF");
            tabela.Columns.Add("Natureza da operação");
            tabela.Columns.Add("Cancelada");
            tabela.Columns.Add("Mensagem");

            foreach (var p in itens.OrderBy(x => x.Codigo).ThenBy(x => x.Emissao))
            {
                var valores = new List<object> { p.Codigo };
                if (ehProduto)
                    valores.AddRange(new object[] { p.DescricaoProduto, p.CfopItem, p.Quantidade, p.ValorTotal });
                valores.AddRange(new object[]
                {
                    p.Item, p.ChaveAcesso, p.Serie, p.Emissao?.ToString("dd/MM/yyyy HH:mm") ?? "",
                    p.NomeEmitente, p.CnpjEmitente, p.NomeDestinatario, p.DocDestinatario, p.UfDestinatario,
                    p.NaturezaOperacao, p.Cancelado ? "Sim" : "Não", p.Mensagem
                });
                tabela.Rows.Add(valores.ToArray());
            }

            var grade = new GradeModerna
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText,
                DataSource = tabela
            };
            grade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            return grade;
        }

        private void MostraResultado(List<EtapaExportacaoZanup> etapas)
        {
            MostraEtapas(etapas);

            var texto = new StringBuilder();
            foreach (var etapa in etapas)
            {
                string situacao = !etapa.Sucesso ? "ERRO" : etapa.ComAviso ? "AVISO" : "OK";
                texto.AppendLine($"[{situacao}] {etapa.Nome}");
                if (!string.IsNullOrWhiteSpace(etapa.Mensagem))
                    texto.AppendLine(etapa.Mensagem);

                if (etapa.Pendencias.Count > 0)
                    texto.AppendLine($"{etapa.Pendencias.Count} nota(s) com erro: veja as abas ao lado do Log.");

                // Etapa com falha ou aviso: log completo (é ele que explica o erro).
                // Etapa OK: só o final, para não poluir.
                int maxLinhasLog = etapa.Sucesso && !etapa.ComAviso ? 30 : 500;
                if (etapa.Log.Count > 0)
                {
                    texto.AppendLine("Log:");
                    if (etapa.Log.Count > maxLinhasLog)
                        texto.AppendLine($"  ... {etapa.Log.Count - maxLinhasLog} linha(s) anteriores omitidas");
                    foreach (string linha in etapa.Log.Skip(Math.Max(0, etapa.Log.Count - maxLinhasLog)))
                        texto.AppendLine("  " + linha);
                }
                texto.AppendLine();
            }
            rtbResultado.Text = texto.ToString();
            MostraPendencias(etapas.SelectMany(x => x.Pendencias).ToList());

            var falha = etapas.FirstOrDefault(x => !x.Sucesso);
            var aviso = etapas.FirstOrDefault(x => x.ComAviso);

            if (falha != null)
            {
                MessageBox.Show(this,
                    $"Falha na etapa \"{falha.Nome}\". As etapas seguintes não foram executadas.\n\n{falha.Mensagem}\n\nO log completo está em Resultado.",
                    "Exportação Zanup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (aviso != null)
            {
                MessageBox.Show(this,
                    $"Exportação concluída, mas a etapa \"{aviso.Nome}\" teve registros com erro.\n\n{aviso.Mensagem}\n\nVeja as abas de pendências (produto, cliente/fornecedor, IDNAT, naturezas) e o log em Resultado.",
                    "Exportação Zanup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, "Exportação concluída.", "Exportação Zanup",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
