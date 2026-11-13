using SolfarmaGp.Controllers.UseCase.Fiscal.BuscaEntradasComFiltroUseCase;
using System.Data;
using System.Text;

namespace SolfarmaGp.UI.MenusUI.Fiscal.EntradasComFiltro
{
    public partial class BuscaEntradasComFiltro : Form
    {
        private DataTable dtResultado;

        // Trava contra clique duplo: enquanto há uma consulta/exportação rodando, nenhuma outra começa.
        private bool _ocupado;

        public BuscaEntradasComFiltro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Liga/desliga o modo "ocupado": mostra a barra de carregamento, bloqueia botões e filtros
        /// e troca o cursor. É chamado ANTES do await, então um segundo clique não passa.
        /// </summary>
        private void DefineOcupado(bool ocupado, string status)
        {
            _ocupado = ocupado;
            pbCarregando.Visible = ocupado;
            btPesquisar.Enabled = !ocupado;
            btExportar.Enabled = !ocupado;
            cartaoFiltros.Enabled = !ocupado;
            UseWaitCursor = ocupado;
            lbStatus.Text = status;
        }

        private async void btPesquisar_Click(object sender, EventArgs e)
        {
            if (_ocupado)
                return;

            DateTime dataInicio = dtDataInicio.Value.Date;
            DateTime dataFim = dtDataFim.Value.Date;

            if (dataInicio > dataFim)
            {
                MessageBox.Show(this, "A data inicial não pode ser maior que a data final.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBxColigada.Text.Trim(), out int coligada))
            {
                MessageBox.Show(this, "Informe a coligada (somente números).", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxColigada.Focus();
                return;
            }

            int filial = 0;
            if (!string.IsNullOrWhiteSpace(txtBxFilial.Text) && !int.TryParse(txtBxFilial.Text.Trim(), out filial))
            {
                MessageBox.Show(this, "Filial inválida. Informe somente números ou deixe vazio.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxFilial.Focus();
                return;
            }

            string tipoMovimento;
            if (chBxEntrada.Checked && !chBxSaida.Checked)
                tipoMovimento = "E";
            else if (!chBxEntrada.Checked && chBxSaida.Checked)
                tipoMovimento = "S";
            else if (chBxEntrada.Checked && chBxSaida.Checked)
                tipoMovimento = "E,S"; // Entrada + Saída
            else
            {
                MessageBox.Show(this, "Selecione Entrada ou Saída.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DefineOcupado(true, "Consultando notas, aguarde...");
            string mensagemFinal = "";
            Exception? falha = null;

            try
            {
                var useCase = new BuscaEntradasComFiltroUseCase();
                dtResultado = await useCase.Execute(dataInicio, dataFim, coligada, filial, tipoMovimento);
                dtEntradasComFiltro.DataSource = dtResultado;
                mensagemFinal = $"{dtResultado.Rows.Count} linha(s) retornada(s).";
            }
            catch (Exception ex)
            {
                falha = ex;
            }
            finally
            {
                DefineOcupado(false, falha == null ? mensagemFinal : "Falha na consulta.");
            }

            if (falha != null)
                MessageBox.Show(this, falha.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(this, $"Linhas retornadas: {dtResultado.Rows.Count}");
        }

        private async void btExportar_Click(object sender, EventArgs e)
        {
            if (_ocupado)
                return;

            if (dtResultado == null || dtResultado.Rows.Count == 0)
            {
                MessageBox.Show(this, "Não existem dados para exportar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string caminho;
            using (SaveFileDialog salvar = new SaveFileDialog
            {
                Filter = "Arquivo TXT (*.txt)|*.txt",
                Title = "Salvar arquivo TXT",
                FileName = "Entradas.txt"
            })
            {
                if (salvar.ShowDialog(this) != DialogResult.OK)
                    return;
                caminho = salvar.FileName;
            }

            DefineOcupado(true, "Exportando arquivo, aguarde...");
            DataTable tabela = dtResultado;
            Exception? falha = null;

            try
            {
                // Gravação em segundo plano para não congelar a tela com muitas linhas.
                await Task.Run(() => GravaArquivo(tabela, caminho));
            }
            catch (Exception ex)
            {
                falha = ex;
            }
            finally
            {
                DefineOcupado(false, falha == null ? "Arquivo exportado." : "Falha ao exportar.");
            }

            if (falha != null)
                MessageBox.Show(this, falha.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(this, "Arquivo exportado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void GravaArquivo(DataTable tabela, string caminho)
        {
            using (StreamWriter writer = new StreamWriter(caminho, false, Encoding.UTF8))
            {
                // CABEÇALHO
                writer.WriteLine(string.Join("|",
                    tabela.Columns.Cast<DataColumn>().Select(coluna => coluna.ColumnName)));

                // DADOS
                foreach (DataRow row in tabela.Rows)
                {
                    writer.WriteLine(string.Join("|",
                        row.ItemArray.Select(valor =>
                            valor is DateTime data
                                ? data.ToString("dd/MM/yyyy")
                                : valor?.ToString() ?? "")));
                }
            }
        }
    }
}
