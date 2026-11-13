using SolfarmaGp.Controllers.UseCase.DrogaCentro.Fiscal.ExportaNotasAlpha7;
using SolfarmaGp.Repositorios.DrogaCentro.Fiscal.ExportaNotasAlpha7;
using SolfarmaGp.UI.ComponentesTelaUI.ProcessoCarregamento.UIStatusDoProcessos;
using System.Text;

namespace SolfarmaGp.UI.MenusUI.DrogaCentro.Fiscal.ExportaNotasAlpha7
{
    public partial class ExportaNotasFiscaisAlpha7 : Form
    {
        public ExportaNotasFiscaisAlpha7()
        {
            InitializeComponent();
            AtualizaEstadoBotoes();
        }

        private void chkSincronizar_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaEstadoBotoes();
        }

        /// <summary>
        /// Modos exclusivos: caixa desmarcada = só Exportar; caixa marcada = só Somente sincronizar
        /// (e só então os dias retroativos fazem sentido).
        /// </summary>
        private void AtualizaEstadoBotoes()
        {
            bool modoSincronizar = chkSincronizar.Checked;
            btnExportar.Enabled = !modoSincronizar;
            btnSincronizar.Enabled = modoSincronizar;
            nudDiasRetroativos.Enabled = modoSincronizar;
        }

        private async void btnExportar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtpInicio.Value.Date;
            DateTime dataFim = dtpFim.Value.Date;

            if (dataInicio > dataFim)
            {
                MessageBox.Show("Data inválida");
                return;
            }

            // A procedure de nota fiscal recusa períodos de 60 dias ou mais.
            if ((dataFim - dataInicio).TotalDays >= 60)
            {
                MessageBox.Show("O período das notas fiscais não pode ser maior do que 60 dias.");
                return;
            }

            // Filial (todas), Substituir (nunca) e Não conferida (padrão) seguem fixos: NULL / 0 / NULL.
            var parametros = new ParametrosNotaFiscalAlpha7
            {
                DataInicio = dataInicio,
                DataFim = dataFim,
                Filial = null,
                Substituir = false,
                NaoConferida = null,
                CodTmv = txtCodTmv.Text.Trim(),
                // um documento por linha -> separados por vírgula, como nas outras telas
                NumeroDocumentos = string.Join(",",
                    rtbNumeroDocumentos.Text
                        .Split(new[] { '\r', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            };

            // Exportar só fica ativo com a caixa desmarcada: sincronização é um modo à parte.
            const bool sincronizar = false;
            int dias = (int)nudDiasRetroativos.Value;

            DialogResult confirmacao = MessageBox.Show(this,
                MontaMensagemConfirmacao(parametros, sincronizar, dias),
                "Confirmação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (confirmacao != DialogResult.OK)
                return;

            await ExecutaComStatus(
                "Exportando Alpha7...",
                "Exportação concluída.",
                aoIniciarEtapa => new ExportaNotasAlpha7UseCase().Execute(parametros, sincronizar, dias, aoIniciarEtapa));
        }

        private async void btnSincronizar_Click(object sender, EventArgs e)
        {
            int dias = (int)nudDiasRetroativos.Value;

            DialogResult confirmacao = MessageBox.Show(this,
                $"Somente sincronizar:\n\nSincronizar base Alpha7 (últimos {dias} dias)\n\nNenhuma exportação será feita.\n\nDeseja continuar?",
                "Confirmação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (confirmacao != DialogResult.OK)
                return;

            await ExecutaComStatus(
                "Sincronizando base Alpha7...",
                "Sincronização concluída.",
                aoIniciarEtapa => new ExportaNotasAlpha7UseCase().ExecuteSomenteSincronizacao(dias, aoIniciarEtapa));
        }

        /// <summary>Mensagem de confirmação que muda conforme a sincronização e os filtros da nota fiscal.</summary>
        private static string MontaMensagemConfirmacao(ParametrosNotaFiscalAlpha7 p, bool sincronizar, int diasRetroativos)
        {
            var primeiroDiaDoMes = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            bool temDocumentos = !string.IsNullOrWhiteSpace(p.NumeroDocumentos);
            bool temTmv = !string.IsNullOrWhiteSpace(p.CodTmv);

            var msg = new StringBuilder();
            msg.AppendLine("Serão exportados do Alpha7 para o Totvs, nesta ordem:");
            msg.AppendLine();
            if (sincronizar)
                msg.AppendLine($"0. Sincronizar base Alpha7 (últimos {diasRetroativos} dias)");
            msg.AppendLine($"1. Produtos cadastrados desde {primeiroDiaDoMes:dd/MM/yyyy}");
            msg.AppendLine($"2. Clientes/Fornecedores cadastrados desde {primeiroDiaDoMes:dd/MM/yyyy}");

            if (temDocumentos)
            {
                int qtd = p.NumeroDocumentos.Split(',', StringSplitOptions.RemoveEmptyEntries).Length;
                msg.AppendLine(qtd == 1
                    ? $"3. Nota fiscal nº {p.NumeroDocumentos}"
                    : $"3. {qtd} notas fiscais: {p.NumeroDocumentos}");
                msg.AppendLine($"    (emitidas de {p.DataInicio:dd/MM/yyyy} até {p.DataFim:dd/MM/yyyy})");
            }
            else
            {
                msg.AppendLine($"3. TODAS as notas fiscais de {p.DataInicio:dd/MM/yyyy} até {p.DataFim:dd/MM/yyyy}");
            }

            if (temTmv)
                msg.AppendLine($"    Somente o tipo de movimento {p.CodTmv}");

            msg.AppendLine();
            msg.AppendLine("Nenhuma etapa substitui registros existentes.");
            if (temDocumentos)
                msg.AppendLine("Atenção: produtos e clientes/fornecedores não usam o filtro de nota; rodam para o mês inteiro.");
            msg.AppendLine();
            msg.Append("Deseja continuar?");
            return msg.ToString();
        }

        private async Task ExecutaComStatus(
            string mensagemProcessando,
            string mensagemSucesso,
            Func<Action<string>, Task<List<EtapaExportacaoAlpha7>>> executar)
        {
            btnExportar.Enabled = false;
            btnSincronizar.Enabled = false;
            rtbResultado.Clear();
            flpEtapas.Controls.Clear();

            List<EtapaExportacaoAlpha7>? etapas = null;
            Exception? falha = null;

            try
            {
                ProcessStatusManager.Start(mensagemProcessando);
                etapas = await executar(nomeEtapa => ProcessStatusManager.Update($"Executando {nomeEtapa}..."));
            }
            catch (Exception ex)
            {
                falha = ex;
            }
            finally
            {
                // O aviso "Processando..." é TopMost: precisa fechar ANTES de qualquer MessageBox,
                // senão a mensagem abre por trás dele.
                ProcessStatusManager.Stop();
                AtualizaEstadoBotoes();
            }

            if (falha != null)
            {
                MessageBox.Show(this, falha.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (etapas != null)
                MostraResultado(etapas, mensagemSucesso);
        }

        /// <summary>Uma linha por etapa, com ponto colorido: verde = OK, âmbar = aviso, vermelho = erro.</summary>
        private void MostraEtapas(List<EtapaExportacaoAlpha7> etapas)
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

        private void MostraResultado(List<EtapaExportacaoAlpha7> etapas, string mensagemSucesso)
        {
            MostraEtapas(etapas);

            var texto = new StringBuilder();
            foreach (var etapa in etapas)
            {
                string situacao = !etapa.Sucesso ? "ERRO" : etapa.ComAviso ? "AVISO" : "OK";
                texto.AppendLine($"[{situacao}] {etapa.Nome}");
                if (!string.IsNullOrWhiteSpace(etapa.Mensagem))
                    texto.AppendLine(etapa.Mensagem);

                // Log de progresso da procedure (uma linha por registro): mostra só o final.
                const int maxLinhasLog = 30;
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

            bool falhou = etapas.Any(x => !x.Sucesso);
            if (falhou)
            {
                var etapaComErro = etapas.First(x => !x.Sucesso);
                MessageBox.Show(this,
                    $"Falha na etapa \"{etapaComErro.Nome}\". As etapas seguintes não foram executadas (se houver).\n\n{etapaComErro.Mensagem}",
                    "Exportação Alpha7",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (etapas.Any(x => x.ComAviso))
            {
                var etapaComAviso = etapas.First(x => x.ComAviso);
                MessageBox.Show(this,
                    $"{mensagemSucesso}\n\nMas a etapa \"{etapaComAviso.Nome}\" teve avisos. Veja os detalhes em Resultado.\n\n{etapaComAviso.Mensagem}",
                    "Exportação Alpha7",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this,
                    mensagemSucesso,
                    "Exportação Alpha7",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
