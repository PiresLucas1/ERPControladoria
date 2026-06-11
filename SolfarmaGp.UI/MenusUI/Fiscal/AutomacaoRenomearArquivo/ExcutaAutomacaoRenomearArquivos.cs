using SolfarmaGp.Services.AutomacoesPy.RenomearArquivos;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SolfarmaGp.UI.MenusUI.Fiscal.NovaPasta
{
    public partial class ExcutaAutomacaoRenomearArquivos : Form
    {
        private RenomearArquivosNotasFiscal _service = new RenomearArquivosNotasFiscal();
        public ExcutaAutomacaoRenomearArquivos()
        {
            InitializeComponent();
        }

        private async void btnExecutar_Click(object sender, EventArgs e)
        {
            var path = txbPath.Text;
            await ExecutaAutomacao(path);

        }
        private async Task ExecutaAutomacao(string path)
        {
            rtbInfo.Clear();
            btnExecutar.Enabled = false;
            pgBar.Style = ProgressBarStyle.Marquee; // fica animando em loop
            pgBar.Visible = true;
            await _service.ExecuteAsync(path, linha =>
            {
                if (rtbInfo.InvokeRequired)
                {
                    rtbInfo.Invoke(() =>
                    {
                        rtbInfo.AppendText(linha + "\n");
                        rtbInfo.ScrollToCaret();
                    });
                }
                else
                {
                    rtbInfo.AppendText(linha + "\n");
                    rtbInfo.ScrollToCaret();
                }
            });
            pgBar.Visible = false;
            btnExecutar.Enabled = true;

            MessageBox.Show("Processamento concluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAbrirPasta_Click(object sender, EventArgs e)
        {

            string caminho = @"\\SRVTOTVS-056VM\renomear_notas";

            try
            {
                if (Directory.Exists(caminho))
                {
                    Process.Start("explorer.exe", caminho);
                }
                else
                {
                    MessageBox.Show("Pasta não encontrada ou sem acesso à rede!",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir pasta: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
