namespace SolfarmaGp.UI.UiComponentesTela.ProcessoCarregamento.UIStatusDoProcessos
{
    public partial class StatusProcess : Form
    {
        private bool status = false;
        private CancellationTokenSource cancellation;

        public StatusProcess()
        {
            InitializeComponent();
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = 0;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

            cancellation = new CancellationTokenSource();

            
            
            
        }
        private void StatusProcess_Shown(object sender, EventArgs e)
        {
            StartLoadingAnimation(); // ✅ Agora a janela já existe
        }

        private async void StartLoadingAnimation()
        {
            await Task.Run(async () =>
            {
                int carregamento = 0;

                while (!cancellation.Token.IsCancellationRequested)
                {
                    // Se a janela já foi fechada, sai do loop imediatamente
                    if (this.IsDisposed || !this.IsHandleCreated)
                        return;

                    try
                    {
                        this.Invoke(new Action(() =>
                        {
                            if (!this.IsDisposed && this.progressBar1 != null)
                                progressBar1.Value = carregamento;
                        }));
                    }
                    catch
                    {
                        // Se der erro ao invocar (form já fechou), apenas sair
                        return;
                    }

                    carregamento += 10;
                    if (carregamento > 100) carregamento = 0;

                    await Task.Delay(200);
                }
            });
        }

        private void StatusProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancellation != null && !cancellation.IsCancellationRequested)
                cancellation.Cancel();
        }

        public void SetMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(SetMessage), message);
            }
            else
            {
                label1.Text = message;
            }
        }

        public void CloseComponent()
        {
            if (cancellation != null && !cancellation.IsCancellationRequested)
                cancellation.Cancel();

            if (!this.IsDisposed && this.IsHandleCreated)
            {
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Close();
                    }));
                }
                catch
                {
                    // Se já estiver fechado, ignora
                }
            }
        }
    }
}
