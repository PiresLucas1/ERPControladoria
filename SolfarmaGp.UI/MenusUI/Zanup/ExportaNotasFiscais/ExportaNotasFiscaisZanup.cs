using SolfarmaGp.Controllers.UseCase.Zanup;
using SolfarmaGp.Repositorios.Zanup.ExportaNotasFiscais;
using SolfarmaGp.UI.ComponentesTelaUI.ProcessoCarregamento.UIStatusDoProcessos;
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

        private async void btnExportar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtpInicio.Value.Date;
            DateTime dataFim = dtpFim.Value.Date;

            string? erroPeriodo = ExportaNotasFiscaisZanupUseCase.ValidaPeriodo(dataInicio, dataFim);
            if (erroPeriodo != null)
            {
                MessageBox.Show(this, erroPeriodo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parametros = new ParametrosExportaNotasZanup
            {
                DataInicio = dataInicio,
                DataFim = dataFim,
                CodTmv = txtCodTmv.Text.Trim(),
                // um documento por linha -> separados por vírgula, como nas outras telas
                NumeroDocumentos = string.Join(",",
                    rtbNumeroDocumentos.Text
                        .Split(new[] { '\r', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            };

            DialogResult confirmacao = MessageBox.Show(this,
                MontaMensagemConfirmacao(parametros),
                "Confirmação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (confirmacao != DialogResult.OK)
                return;

            await Executa(parametros);
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
            msg.AppendLine("3. Vínculo de pedido de venda com o XML");
            msg.AppendLine("4. Atualização de notas canceladas");
            msg.AppendLine("5. Exportação de Cliente/Fornecedor");
            msg.AppendLine("6. Exportação de Produtos");

            if (temDocumentos)
            {
                int qtd = p.NumeroDocumentos.Split(',', StringSplitOptions.RemoveEmptyEntries).Length;
                msg.AppendLine(qtd == 1
                    ? $"7. Documento fiscal nº {p.NumeroDocumentos}"
                    : $"7. {qtd} documentos fiscais: {p.NumeroDocumentos}");
            }
            else
            {
                msg.AppendLine("7. TODOS os documentos fiscais do período");
            }

            if (temTmv)
                msg.AppendLine($"    Somente o tipo de movimento {p.CodTmv}");

            msg.AppendLine();
            msg.AppendLine("Nenhuma etapa substitui registros existentes.");
            msg.AppendLine();
            msg.Append("Deseja continuar?");
            return msg.ToString();
        }

        private async Task Executa(ParametrosExportaNotasZanup parametros)
        {
            btnExportar.Enabled = false;
            rtbResultado.Clear();
            flpEtapas.Controls.Clear();

            List<EtapaExportacaoZanup>? etapas = null;
            Exception? falha = null;

            try
            {
                ProcessStatusManager.Start("Exportando notas fiscais da Zanup...");
                etapas = await new ExportaNotasFiscaisZanupUseCase().Execute(
                    parametros,
                    nomeEtapa => ProcessStatusManager.Update($"Executando {nomeEtapa}..."));
            }
            catch (Exception ex)
            {
                falha = ex;
            }
            finally
            {
                // O aviso "Processando..." é TopMost: precisa fechar ANTES de qualquer MessageBox.
                ProcessStatusManager.Stop();
                btnExportar.Enabled = true;
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

                if (etapa.Detalhes.Count > 0)
                {
                    texto.AppendLine("Notas com erro:");
                    foreach (string d in etapa.Detalhes.Take(50))
                        texto.AppendLine("  " + d);
                    if (etapa.Detalhes.Count > 50)
                        texto.AppendLine($"  ... e mais {etapa.Detalhes.Count - 50}");
                }

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
                    $"Exportação concluída, mas a etapa \"{aviso.Nome}\" teve registros com erro.\n\n{aviso.Mensagem}\n\nVeja os detalhes e o log em Resultado.",
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
