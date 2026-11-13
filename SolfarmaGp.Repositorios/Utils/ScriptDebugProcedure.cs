using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace SolfarmaGp.Repositorios.Utils
{
    /// <summary>
    /// Gera um script T-SQL pronto para rodar no SSMS com todos os parâmetros de um SqlCommand
    /// (inclusive TVP e OUTPUT), para conferir os valores enviados para a procedure.
    /// </summary>
    public static class ScriptDebugProcedure
    {
        public static string Gerar(SqlCommand cmd)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"-- Gerado em {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            sb.AppendLine("-- Para testar sem gravar: descomente o BEGIN TRAN e o ROLLBACK");
            sb.AppendLine("-- BEGIN TRAN;");
            sb.AppendLine();

            var argumentos = new List<string>();

            foreach (SqlParameter param in cmd.Parameters)
            {
                string nome = param.ParameterName.StartsWith("@") ? param.ParameterName : "@" + param.ParameterName;

                if (param.SqlDbType == SqlDbType.Structured)
                {
                    sb.AppendLine($"DECLARE {nome} {param.TypeName};");
                    if (param.Value is DataTable tabela)
                        AppendInsertsTvp(sb, nome, tabela);
                    sb.AppendLine();
                    argumentos.Add($"{nome} = {nome}");
                }
                else if (param.Direction == ParameterDirection.Output || param.Direction == ParameterDirection.InputOutput)
                {
                    sb.AppendLine($"DECLARE {nome} {TipoSql(param)};");
                    argumentos.Add($"{nome} = {nome} OUTPUT");
                }
                else
                {
                    argumentos.Add($"{nome} = {Formatar(param.Value)}");
                }
            }

            sb.AppendLine();
            sb.AppendLine($"EXEC {cmd.CommandText}");
            sb.AppendLine("    " + string.Join("," + Environment.NewLine + "    ", argumentos) + ";");

            var saidas = cmd.Parameters.Cast<SqlParameter>()
                .Where(p => p.Direction == ParameterDirection.Output || p.Direction == ParameterDirection.InputOutput)
                .Select(p => p.ParameterName)
                .ToList();
            if (saidas.Count > 0)
                sb.AppendLine($"SELECT {string.Join(", ", saidas)};");

            sb.AppendLine();
            sb.AppendLine("-- ROLLBACK;");
            return sb.ToString();
        }

        /// <summary>
        /// Gera o script, escreve na janela Output do Visual Studio e salva em %TEMP%\{nomeArquivo}.
        /// Retorna o script para poder ser inspecionado no debugger.
        /// </summary>
        public static string GerarESalvar(SqlCommand cmd, string nomeArquivo)
        {
            string script = Gerar(cmd);

            Debug.WriteLine("========== SCRIPT DEBUG: " + cmd.CommandText + " ==========");
            Debug.WriteLine(script);

            try
            {
                string caminho = Path.Combine(Path.GetTempPath(), nomeArquivo);
                File.WriteAllText(caminho, script, Encoding.UTF8);
                Debug.WriteLine("Script salvo em: " + caminho);
            }
            catch (Exception ex)
            {
                // O log de debug nunca pode impedir o lançamento
                Debug.WriteLine("Não foi possível salvar o script de debug: " + ex.Message);
            }

            return script;
        }

        /// <summary>
        /// Gera uma tabela em texto (colunas alinhadas) com todas as linhas do DataTable.
        /// </summary>
        public static string GerarTabela(DataTable tabela)
        {
            var colunas = tabela.Columns.Cast<DataColumn>().ToList();
            var linhas = tabela.Rows.Cast<DataRow>()
                .Select(row => colunas.Select(c => FormatarCelula(row[c])).ToList())
                .ToList();

            // Largura de cada coluna = maior entre o nome e os valores
            var larguras = colunas
                .Select((c, i) => Math.Max(c.ColumnName.Length, linhas.Count == 0 ? 0 : linhas.Max(l => l[i].Length)))
                .ToList();

            string Linha(IEnumerable<string> valores) =>
                "| " + string.Join(" | ", valores.Select((v, i) => v.PadRight(larguras[i]))) + " |";
            string separador = "+" + string.Join("+", larguras.Select(l => new string('-', l + 2))) + "+";

            var sb = new StringBuilder();
            sb.AppendLine($"-- Gerado em {DateTime.Now:dd/MM/yyyy HH:mm:ss} - {tabela.Rows.Count} linha(s)");
            sb.AppendLine(separador);
            sb.AppendLine(Linha(colunas.Select(c => c.ColumnName)));
            sb.AppendLine(separador);
            foreach (var linha in linhas)
                sb.AppendLine(Linha(linha));
            sb.AppendLine(separador);

            // Totais das colunas numéricas, para conferir com o XML
            var totais = colunas
                .Where(c => c.DataType == typeof(decimal) || c.DataType == typeof(double))
                .Select(c => $"{c.ColumnName} = {tabela.AsEnumerable().Sum(r => r[c] == DBNull.Value ? 0m : Convert.ToDecimal(r[c])).ToString(CultureInfo.InvariantCulture)}");
            sb.AppendLine("Totais: " + string.Join("; ", totais));

            return sb.ToString();
        }

        /// <summary>
        /// Gera a tabela, escreve na janela Output do Visual Studio e salva em %TEMP%\{nomeArquivo}.
        /// </summary>
        public static string GerarESalvarTabela(DataTable tabela, string nomeArquivo)
        {
            string texto = GerarTabela(tabela);

            Debug.WriteLine("========== ITENS DEBUG: " + nomeArquivo + " ==========");
            Debug.WriteLine(texto);

            try
            {
                string caminho = Path.Combine(Path.GetTempPath(), nomeArquivo);
                File.WriteAllText(caminho, texto, Encoding.UTF8);
                Debug.WriteLine("Itens salvos em: " + caminho);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Não foi possível salvar os itens de debug: " + ex.Message);
            }

            return texto;
        }

        private static string FormatarCelula(object valor)
        {
            return valor switch
            {
                null or DBNull => "NULL",
                DateTime data => data.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                IFormattable numero => numero.ToString(null, CultureInfo.InvariantCulture),
                _ => valor.ToString()
            };
        }

        private static void AppendInsertsTvp(StringBuilder sb, string nome, DataTable tabela)
        {
            if (tabela.Rows.Count == 0)
            {
                sb.AppendLine($"-- {nome} sem linhas");
                return;
            }

            string colunas = string.Join(", ", tabela.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
            foreach (DataRow row in tabela.Rows)
            {
                string valores = string.Join(", ", tabela.Columns.Cast<DataColumn>().Select(c => Formatar(row[c])));
                sb.AppendLine($"INSERT INTO {nome} ({colunas}) VALUES ({valores});");
            }
        }

        private static string Formatar(object valor)
        {
            switch (valor)
            {
                case null:
                case DBNull:
                    return "NULL";
                case string texto:
                    return "'" + texto.Replace("'", "''") + "'";
                case DateTime data:
                    return "'" + data.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) + "'";
                case bool b:
                    return b ? "1" : "0";
                case IFormattable numero:
                    return numero.ToString(null, CultureInfo.InvariantCulture);
                default:
                    return "'" + valor.ToString().Replace("'", "''") + "'";
            }
        }

        private static string TipoSql(SqlParameter param)
        {
            return param.SqlDbType switch
            {
                SqlDbType.VarChar or SqlDbType.NVarChar or SqlDbType.Char or SqlDbType.NChar
                    => $"{param.SqlDbType.ToString().ToUpperInvariant()}({(param.Size > 0 ? param.Size.ToString() : "MAX")})",
                SqlDbType.Decimal => $"DECIMAL({param.Precision},{param.Scale})",
                _ => param.SqlDbType.ToString().ToUpperInvariant()
            };
        }
    }
}
