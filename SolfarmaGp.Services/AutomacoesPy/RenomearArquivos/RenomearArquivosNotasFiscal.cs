using System.Diagnostics;

namespace SolfarmaGp.Services.AutomacoesPy.RenomearArquivos
{
    public class RenomearArquivosNotasFiscal
    {
        public async Task ExecuteAsync(string path, Action<string> onOutput)
        {
            string exePath = Path.Combine(@"C:\gs300gp\py_automation_rename_file\dist", "main.exe");

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = $"\"{path}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                StandardOutputEncoding = System.Text.Encoding.UTF8
            };

            using (Process process = Process.Start(psi))
            {
                // lê stderr em paralelo para não causar deadlock
                Task erroTask = Task.Run(async () =>
                {
                    string erro;
                    while ((erro = await process.StandardError.ReadLineAsync()) != null)
                    {
                        onOutput("[ERRO] " + erro);
                    }
                });

                // lê stdout linha a linha em tempo real
                string linha;
                while ((linha = await process.StandardOutput.ReadLineAsync()) != null)
                {
                    onOutput(linha);
                }

                await Task.WhenAll(erroTask, process.WaitForExitAsync());
            }
        }

    }
}
