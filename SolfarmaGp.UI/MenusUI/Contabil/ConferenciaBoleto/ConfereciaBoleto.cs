using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.Contabil.ConferenciaBoleto
{
    public partial class ConfereciaBoleto : Form
    {
        public class ConferenciaResultado
        {
            public string ContaDebito { get; set; }
            public string ContaCredito { get; set; }
            public string Valor { get; set; }
            public string CodigoHistorico { get; set; }
            public string Complemento { get; set; }
            public int Filial { get; set; }
            public string DataDocumento { get; set; }
        }
        List<ConferenciaResultado> listaResultado { get; set; } = new List<ConferenciaResultado>();

        public ConfereciaBoleto()
        {
            InitializeComponent();
            ExcelPackage.License.SetNonCommercialPersonal("SolfarmaGP");
            cbBanco.Items.Add("Sicoob");
            cbFiltro.Items.AddRange(new string[] { "ContaDebito", "ContaCredito", "Complemento" });
        }

        private void btnImportarArquivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Selecione o arquivo Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        FileInfo fileInfo = new FileInfo(filePath);

                        txtFileName.Text = fileInfo.Name;

                        using (ExcelPackage package = new ExcelPackage(fileInfo))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                            if (worksheet.Dimension == null)
                            {
                                MessageBox.Show("A planilha está vazia.");
                                return;
                            }

                            DataTable dt = new DataTable();

                            bool hasHeader = true;

                            // Criar colunas
                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                string columnName = hasHeader
                                    ? worksheet.Cells[1, col].Text
                                    : $"Column {col}";

                                dt.Columns.Add(string.IsNullOrWhiteSpace(columnName)
                                    ? $"Column {col}"
                                    : columnName);
                            }

                            int startRow = hasHeader ? 2 : 1;

                            // Preencher linhas
                            for (int row = startRow; row <= worksheet.Dimension.End.Row; row++)
                            {
                                DataRow newRow = dt.NewRow();

                                for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                                {
                                    newRow[col - 1] = worksheet.Cells[row, col].Text;
                                }

                                dt.Rows.Add(newRow);
                            }

                            dvgRelacaoBoletos.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao importar o arquivo:\n" + ex.Message);
                    }
                }
            }

        }

        private async void btnConferencia_Click(object sender, EventArgs e)
        {
            DataTable dtProcesso = (DataTable)dvgRelacaoBoletos.DataSource;
            if (tbFilial.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Necessário informar Filial"); return;
            }
            if (cbBanco.SelectedItem == null)
            {
                MessageBox.Show("Necessário selecionar banco"); return;
            }
            if (dtProcesso.Rows.Count == 0)
            {
                MessageBox.Show("Não foi possivel Localizar base importada"); return;
            }
            var numberFilial = Convert.ToInt32(tbFilial.Text);
            await ExecutaConferencia(dtProcesso, numberFilial);


        }
        public async Task ExecutaConferencia(DataTable dt, int filial)
        {
            ConsultaLancamentoContabilParametrizadoUseCase usecase = new ConsultaLancamentoContabilParametrizadoUseCase();
            DataTable dtParametros = await usecase.Execute();

            var resultado = from baseImportada in dt.AsEnumerable()
                            from baseParametros in dtParametros.AsEnumerable()
                            let palavras = baseParametros.Field<string>("Descricão Extrato")
                                           .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            where
                                baseImportada.Field<string>("TIPO").ToLower() == "c"
                                && baseParametros.Field<int>("Filial") == filial
                                && palavras.All(p =>
                                            baseImportada.Field<string>("HISTÓRICO")
                                            .Contains(p, StringComparison.OrdinalIgnoreCase))
                            select new ConferenciaResultado
                            {
                                ContaDebito = baseParametros.Field<string>("Cod. Conta Debito") ?? "",
                                ContaCredito = baseParametros.Field<string>("Cod. Conta Credito") ?? "",
                                Valor = baseImportada.Field<string>("VALOR") ?? "",
                                CodigoHistorico = baseParametros.Field<string>("Cod. Historico") ?? "",
                                Complemento = baseParametros.Field<string>("Complemento") ?? "",
                                Filial = baseParametros.Field<int?>("Filial") ?? 0,
                                DataDocumento = baseImportada.Field<string>("DATA"),
                            };
            listaResultado = resultado.ToList();
            dvgConferencia.DataSource = resultado.ToList();

            MessageBox.Show("Conferencia Finalizada");


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtroSelecionado = cbFiltro.Text;
            string valorPesquisa = tbValorPesquisa.Text;

            if (string.IsNullOrWhiteSpace(valorPesquisa))
            {
                dvgConferencia.DataSource = listaResultado;
                return;
            }

            valorPesquisa = valorPesquisa.ToLower();

            var filtrado = listaResultado.Where(x =>
            {
                var propriedade = x.GetType().GetProperty(filtroSelecionado);

                if (propriedade == null)
                    return false;

                var valor = propriedade.GetValue(x)?.ToString()?.ToLower();

                return valor != null && valor.Contains(valorPesquisa);
            }).ToList();

            dvgConferencia.DataSource = filtrado;
        }
    }
}
