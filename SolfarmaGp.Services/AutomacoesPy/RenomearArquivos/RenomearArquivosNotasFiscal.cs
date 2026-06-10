using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace SolfarmaGp.Services.AutomacoesPy.RenomearArquivos
{
    public class RenomearArquivosNotasFiscal
    {
        public void Execute(string pathFile, Action<string> onOutput) 
        {
            string pythonExe = "";
            string script = "";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = pythonExe,
                Arguments = $"\"{script}\" \"{pathFile}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,   // captura o print() do Python
                RedirectStandardError = true,   // captura erros
                CreateNoWindow = true    // não abre janela do terminal
            };

            using (Process process = Process.Start(psi))
            {
                string linha;
                while ((linha = process.StandardOutput.ReadLine()) != null)
                {
                    onOutput(linha);
                }
                process.WaitForExit();
            }
        }

    }
}
