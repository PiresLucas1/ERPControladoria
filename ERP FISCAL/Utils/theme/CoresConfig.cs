using Newtonsoft.Json;
using System.IO;
using System.Drawing;
namespace ERP_FISCAL.Utils.theme
{


    public static class CoresConfig
    {
        //public static CoresConfig Cores { get; private set; }

        public static void CarregarCores(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
                throw new FileNotFoundException($"Arquivo de configuração não encontrado: {caminhoArquivo}");

            string json = File.ReadAllText(caminhoArquivo);
            //Cores = JsonConvert.DeserializeObject<T>(json);
        }

        public static Color HexToColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }
    }
}
