using ClosedXML.Excel;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ERP_FISCAL.Service.UploadFile
{
    public class UploadFileService
    {
       
        public string SelecionarArquivo()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecione a planilha Excel";
                openFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return null;
        }

        public DataTable LerPlanilha(string caminho)
        {
            var dt = new DataTable();

            using (var workbook = new XLWorkbook(caminho))
            {
                var planilha = workbook.Worksheet(1); // primeira aba
                bool primeiraLinha = true;

                foreach (var linha in planilha.RowsUsed())
                {
                    if (primeiraLinha)
                    {
                        // Cria as colunas com base nos cabeçalhos
                        foreach (var celula in linha.Cells())
                            dt.Columns.Add(celula.Value.ToString());
                        primeiraLinha = false;
                    }
                    else
                    {
                        // Adiciona as linhas de dados
                        dt.Rows.Add();
                        int i = 0;
                        foreach (var celula in linha.Cells())
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = celula.Value.ToString();
                            i++;
                        }
                    }
                }
            }

            return dt;
        }

        public DataTable FormatarPlanilhaSicoob(string caminho)
        {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Data", typeof(DateTime));
            tabela.Columns.Add("Documento", typeof(string));
            tabela.Columns.Add("Histórico", typeof(string));
            tabela.Columns.Add("Valor", typeof(decimal));
            tabela.Columns.Add("Tipo", typeof(string));

            using (var workbook = new XLWorkbook(caminho))
            {
                var ws = workbook.Worksheet(1); // primeira aba
                var ultimaLinha = ws.LastRowUsed().RowNumber();

                for (int i = 3; i <= ultimaLinha; i++)
                {
                    if (string.IsNullOrWhiteSpace(ws.Cell(i, 1).GetValue<string>()))
                        continue;

                    string data = ws.Cell(i, 1).GetString().Trim();
                    string documento = ws.Cell(i, 2).GetString().Trim();
                    string historico = ws.Cell(i, 3).GetString().Trim();
                    string valorTexto = ws.Cell(i, 4).GetFormattedString().Trim();

                    // ======= Ajuste do histórico =======
                    string complemento = ws.Cell(i + 1, 3).GetString().Trim();
                    if (historico.Contains("CRÉD.TED-STR"))
                        historico = historico + " " + complemento;
                    else if (historico.Contains("CR COMPRAS"))
                        historico = complemento;

                    // ======= Ajuste do valor e tipo =======
                    if (string.IsNullOrWhiteSpace(valorTexto)) continue;

                    string tipo = valorTexto.Substring(valorTexto.Length - 1, 1); // último caractere
                    string valorSemTipo = valorTexto.Substring(0, valorTexto.Length - 1);

                    // Converte valor no formato decimal (trocando vírgula por ponto)
                    if (!decimal.TryParse(valorSemTipo.Replace(".", "").Replace(",", "."),
                                           System.Globalization.NumberStyles.Any,
                                           System.Globalization.CultureInfo.InvariantCulture, out decimal valor))
                    {
                        continue;
                    }

                    tabela.Rows.Add(data, documento, historico, valor, tipo);
                }
            }

            return tabela;
        }

        public void FormatarGridVisual(DataGridView dataRetorno)
        {
            var dgv = dataRetorno;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["Valor"].DefaultCellStyle.Format = "C2";
            dgv.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // ======= Cores conforme o tipo (C/D) =======
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["Tipo"].Value == null) continue;

                string tipo = row.Cells["Tipo"].Value.ToString().Trim().ToUpper();
                if (tipo == "C")
                {
                    row.Cells["Valor"].Style.BackColor = Color.FromArgb(216, 228, 188);
                    row.Cells["Valor"].Style.ForeColor = Color.FromArgb(0, 112, 192);
                }
                else if (tipo == "D")
                {
                    row.Cells["Valor"].Style.BackColor = Color.FromArgb(235, 241, 222);
                    row.Cells["Valor"].Style.ForeColor = Color.Red;
                }
            }
        }
    }

 }

