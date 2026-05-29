using System.Xml;

namespace SolfarmaGp.UI.Utils
{
    public class FormatarXml
    {
        public static string Executar(string xml)
        {
            try
            {
                var doc = new XmlDocument();
                doc.LoadXml(xml);
                var stringBuilder = new System.Text.StringBuilder();
                var settings = new System.Xml.XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "  ",
                    NewLineChars = Environment.NewLine,
                    NewLineHandling =NewLineHandling.Replace
                };
                using (var writer = XmlWriter.Create(stringBuilder, settings))
                {
                    doc.Save(writer);
                }
                return stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                // Trate a exceção conforme necessário, por exemplo, logando o erro ou retornando uma mensagem de erro.
                return $"Erro ao formatar XML: {ex.Message}";
            }
        }
    }
}
