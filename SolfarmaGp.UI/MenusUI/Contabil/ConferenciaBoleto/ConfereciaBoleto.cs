using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao;
using SolfarmaGp.Controllers.Utils.EnumerableToDateTable;
using SolfarmaGp.UI.ComponentesTelaUI.Tabelas.UIRetornoEmTabela;
using System.Collections;
using System.Data;
using System.Text;

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
            public DateTime DataDocumento { get; set; }
            public string ContaCompletaDebito { get; set; }
            public string ContaCompletaCredito { get; set; }
        }
        List<ConferenciaResultado> listaResultado { get; set; } = new List<ConferenciaResultado>();

        public ConfereciaBoleto()
        {
            InitializeComponent();
            ExcelPackage.License.SetNonCommercialPersonal("SolfarmaGP");
            cbBanco.Items.Add(10);
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
                MessageBox.Show("Necessário selecionar coligada"); return;
            }
            if (dtProcesso.Rows.Count == 0)
            {
                MessageBox.Show("Não foi possivel Localizar base importada"); return;
            }
            if(tbCodPessoa.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Necessário informar o codigo da pessoa"); return;
            }
            var numberFilial = Convert.ToInt32(tbFilial.Text);
            var numberColigada = Convert.ToInt32(cbBanco.Text);
            await ExecutaConferencia(dtProcesso, numberFilial, numberColigada);


        }
        public async Task ExecutaConferencia(DataTable dt, int filial, int codColigada)
        {
            ConsultaLancamentoContabilParametrizadoUseCase usecase = new ConsultaLancamentoContabilParametrizadoUseCase();
            DataTable dtParametros = await usecase.Execute(codColigada);

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
                                DataDocumento = Convert.ToDateTime(baseImportada.Field<string>("DATA")),
                                ContaCompletaDebito = baseParametros.Field<string>("ContaCompletaDebito"),
                                ContaCompletaCredito = baseParametros.Field<string>("ContaCompletaCredito"),
                            };
            listaResultado = resultado.ToList();
            dvgConferencia.DataSource = resultado.ToList();
            dvgConferencia.Columns["ContaCompletaDebito"].Visible = false;
            dvgConferencia.Columns["ContaCompletaCredito"].Visible = false;

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

        private void btnGeraLote_Click(object sender, EventArgs e)
        {
            var lista = (List<ConferenciaResultado>)dvgConferencia.DataSource;
            DataTable dt = new DataTable();
            dt = ConverteEnumerableParaDataTable(lista);
            string retorno = GeraLoteDrogaCentro(dt);
            SalvaArquivoTexto(retorno);




        }
        public void SalvaArquivoTexto(string resultado)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo de Importação (*.txt)|*.txt";
                saveFileDialog.Title = "Salvar arquivo de conciliação";
                saveFileDialog.FileName = $"Conciliação {tbCodPessoa.Text}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Encoding encoding = Encoding.GetEncoding(1252);              

                    File.WriteAllText(saveFileDialog.FileName, resultado, new UTF8Encoding(false));

                    MessageBox.Show("Arquivo gerado com sucesso!");
                }
            }
        }
        public string GeraLoteDrogaCentro(DataTable dt)
        {
            var sb = new StringBuilder();

            var grupos = dt.AsEnumerable()
                .GroupBy(x => x.Field<DateTime>("DataDocumento"))
                .OrderBy(x => x.Key);
            string codPessoa = tbCodPessoa.Text;
            string codPessoaFormatado = codPessoa.PadLeft(15, '0');

            foreach (var grupo in grupos)
            {
                var data = grupo.Key;

                sb.AppendLine($"M;{codPessoaFormatado};CONCILIACAO BANCARIA;{data:dd/MM/yyyy}");
                foreach (var row in grupo)
                {
                    string contaDebito = row["ContaCompletaDebito"].ToString().Trim();
                    string contaCredito = row["ContaCompletaCredito"].ToString().Trim();
                    string valor = row["Valor"].ToString().Trim();
                    string codHistorico = row["CodigoHistorico"].ToString().Trim();
                    string complemento = row["Complemento"].ToString().Trim();
                    string filial = row["Filial"].ToString().Trim();

                    //string linha = $"*P;;{contaDebito};{contaCredito};;{valor};{codHistorico};{complemento};{filial};;;000000000000000;0000;0000000000";
                    string linha = string.Join(";", new[]
                     {
                            "*P",
                            "",
                            contaDebito,
                            contaCredito,
                            "",
                            valor,
                            codHistorico,
                            complemento,
                            filial,
                            "",
                            "",
                            "000000000000000",
                            "0000",
                            "0000000000"
                        });
                    sb.AppendLine(linha);
                }
            }
            string resultado = sb.ToString();
            return resultado;
        }

        public DataTable CriaDataTableLoteImportacao(DataTable dt, string codPessoa)
        {
            DataTable dtPreview = new DataTable();

            dtPreview.Columns.Add("DataLote", typeof(DateTime));
            dtPreview.Columns.Add("Tipo", typeof(string));
            dtPreview.Columns.Add("Linha", typeof(string));

            string codPessoaFormatado = codPessoa.PadLeft(15, '0');

            var grupos = dt.AsEnumerable()
                .OrderBy(x => x.Field<DateTime>("DataDocumento"))
                .GroupBy(x => x.Field<DateTime>("DataDocumento"));

            foreach (var grupo in grupos)
            {
                DateTime data = grupo.Key;

                string header = $"M;{codPessoaFormatado};CONCILIACAO BANCARIA;{data:dd/MM/yyyy}";

                dtPreview.Rows.Add(data, "M", header);

                foreach (var row in grupo)
                {
                    string contaDebito = row["ContaCompletaDebito"].ToString().Trim();
                    string contaCredito = row["ContaCompletaCredito"].ToString().Trim();
                    string valor = row["Valor"].ToString().Trim();
                    string codHistorico = row["CodigoHistorico"].ToString().Trim();
                    string complemento = row["Complemento"].ToString().Trim();
                    string filial = row["Filial"].ToString().Trim();
                    //$"*P;;{contaDebito};{contaCredito};;{valor};{codHistorico};{complemento};{filial};;;000000000000000;0000;0000000000"
                    string linha = string.Join(";", new[]
                    {
                        "*P",
                        "",
                        contaDebito,
                        contaCredito,
                        "",
                        valor,
                        codHistorico,
                        complemento,
                        filial,
                        "",
                        "",
                        "000000000000000",
                        "0000",
                        "0000000000"
                    });

                    dtPreview.Rows.Add(data, "P", linha);
                }
            }

            return dtPreview;
        }

        private void btnVisualiza_Click(object sender, EventArgs e)
        {
            var lista = (List<ConferenciaResultado>)dvgConferencia.DataSource;
            DataTable dt = new DataTable();
            dt = ConverteEnumerableParaDataTable(lista);
            DataTable retorno = CriaDataTableLoteImportacao(dt, tbCodPessoa.Text);
            RetornoEmTabela viewRetorno = new RetornoEmTabela(retorno);
            viewRetorno.Show();
        }
        public DataTable ConverteEnumerableParaDataTable(List<ConferenciaResultado> lista)
        {
            DataTable dt = EnumerableToDataTable.ListToDataTable(lista);
            return dt;
        }
    }
}
