using OfficeOpenXml;

namespace SolfarmaGp.UI.Utils
{
    /// <summary>
    /// Exporta para Excel o que está em um DataGridView (colunas visíveis, na ordem em que aparecem)
    /// e abre o arquivo no programa associado a .xlsx.
    /// </summary>
    public static class ExportarGridParaExcel
    {
        public static void Executar(DataGridView grid, string nomeArquivo, string nomePlanilha = "Notas")
        {
            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar", "Exportar para Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var colunas = grid.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .OrderBy(c => c.DisplayIndex)
                .ToList();

            Form tela = grid.FindForm();

            try
            {
                if (tela != null) tela.Cursor = Cursors.WaitCursor;
                ExcelPackage.License.SetNonCommercialPersonal("SolfarmaGP");

                using var package = new ExcelPackage();
                var planilha = package.Workbook.Worksheets.Add(nomePlanilha);

                for (int c = 0; c < colunas.Count; c++)
                    planilha.Cells[1, c + 1].Value = TituloColuna(colunas[c]);

                int linhaExcel = 2;
                foreach (DataGridViewRow linha in grid.Rows)
                {
                    if (linha.IsNewRow) continue;

                    for (int c = 0; c < colunas.Count; c++)
                    {
                        object? valor = linha.Cells[colunas[c].Index].Value;

                        if (valor == null || valor is DBNull)
                            continue;

                        if (valor is bool marcado)
                            valor = marcado ? "Sim" : "Não";

                        planilha.Cells[linhaExcel, c + 1].Value = valor;
                    }
                    linhaExcel++;
                }

                // formatos por tipo de dado (o valor continua sendo número/data, não texto, para o Excel poder somar e filtrar)
                if (linhaExcel > 2)
                {
                    for (int c = 0; c < colunas.Count; c++)
                    {
                        var tipo = colunas[c].ValueType;
                        var coluna = planilha.Cells[2, c + 1, linhaExcel - 1, c + 1];

                        if (tipo == typeof(DateTime) || tipo == typeof(DateTime?))
                            coluna.Style.Numberformat.Format = "dd/MM/yyyy";
                        else if (tipo == typeof(decimal) || tipo == typeof(double) || tipo == typeof(float))
                            coluna.Style.Numberformat.Format = "#,##0.00";
                    }
                }

                var cabecalho = planilha.Cells[1, 1, 1, colunas.Count];
                cabecalho.Style.Font.Bold = true;
                cabecalho.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                cabecalho.Style.Fill.BackgroundColor.SetColor(Color.LightGray);

                planilha.View.FreezePanes(2, 1);
                planilha.Cells[1, 1, linhaExcel - 1, colunas.Count].AutoFilter = true;
                planilha.Cells[planilha.Dimension.Address].AutoFitColumns(8, 60);

                string caminho = Path.Combine(Path.GetTempPath(), $"{nomeArquivo}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");
                package.SaveAs(new FileInfo(caminho));

                // abre no programa associado a .xlsx (Excel); o usuário salva onde quiser a partir dele
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(caminho) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível exportar para o Excel: {ex.Message}", "Exportar para Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (tela != null) tela.Cursor = Cursors.Default;
            }
        }

        // Colunas de marcar usam títulos como "✓" ou "*"; no Excel fica mais claro o nome da coluna
        private static string TituloColuna(DataGridViewColumn coluna)
        {
            string titulo = coluna.HeaderText?.Trim();
            bool tituloSemTexto = string.IsNullOrEmpty(titulo) || !titulo.Any(char.IsLetterOrDigit);
            return tituloSemTexto ? coluna.Name : titulo;
        }
    }
}
