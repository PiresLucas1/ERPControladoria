using System.Data;

namespace SolfarmaGp.UI.MenusUI.Fiscal.ImportarNotasFiscaisXmlPataTotvs
{
    // Relatório dos produtos com os valores que serão enviados para a uspUsuNotaUsoConsumoInclusaoGP
    public partial class ConferenciaProdutosNota : Form
    {
        private const string ColDiferenca = "Diferença";

        // Tributos mostrados na conferência: nome e colunas da TVP (base, alíquota, valor)
        private static readonly (string Nome, string Base, string Aliquota, string Valor)[] Tributos =
        {
            ("ICMS",     "BASEICMS",   "ALIQUOTAICMS",   "VALORICMS"),
            ("ICMS ST",  "BASEICMSST", "ALIQUOTAICMSST", "VALORICMSST"),
            ("IPI",      "BASEIPI",    "ALIQUOTAIPI",    "VALORIPI"),
            ("PIS",      "BASEPIS",    "ALIQUOTAPIS",    "VALORPIS"),
            ("COFINS",   "BASECOFINS", "ALIQUOTACOFINS", "VALORCOFINS"),
            ("IBS UF",   "BASEIBSCBS", "ALIQUOTAIBSUF",  "VALORIBSUF"),
            ("IBS Mun.", "BASEIBSCBS", "ALIQUOTAIBSMUN", "VALORIBSMUN"),
            ("CBS",      "BASEIBSCBS", "ALIQUOTACBS",    "VALORCBS"),
        };

        public ConferenciaProdutosNota(DataTable itensTela, DataTable itensTvp)
        {
            InitializeComponent();
            CarregarRelatorio(itensTela, itensTvp);
        }

        private void CarregarRelatorio(DataTable itensTela, DataTable itensTvp)
        {
            var relatorio = new DataTable();
            relatorio.Columns.Add("Seq", typeof(int));
            relatorio.Columns.Add("Cód. Fornecedor", typeof(string));
            relatorio.Columns.Add("Descrição", typeof(string));
            relatorio.Columns.Add("IDPRD", typeof(int));
            relatorio.Columns.Add("Quantidade", typeof(decimal));
            relatorio.Columns.Add("Valor Total XML", typeof(decimal));
            relatorio.Columns.Add("Valor Unitário", typeof(decimal));
            relatorio.Columns.Add("Total Calculado", typeof(decimal));
            relatorio.Columns.Add(ColDiferenca, typeof(decimal));
            relatorio.Columns.Add("Natureza", typeof(string));
            relatorio.Columns.Add("Unidade", typeof(string));

            // Só mostra o tributo se ele for enviado em algum item, para a grade não ficar larga demais
            var tributosExibidos = Tributos
                .Where(t => itensTvp.AsEnumerable().Any(r => Decimal(r, t.Base) != 0 || Decimal(r, t.Valor) != 0))
                .ToList();

            foreach (var t in tributosExibidos)
            {
                relatorio.Columns.Add($"{t.Nome} Base", typeof(decimal));
                relatorio.Columns.Add($"{t.Nome} %", typeof(decimal));
                relatorio.Columns.Add($"{t.Nome} Valor", typeof(decimal));
            }

            decimal somaXml = 0, somaCalculada = 0;

            // As duas tabelas têm a mesma ordem: a TVP é montada linha a linha a partir dos itens da tela
            for (int i = 0; i < itensTvp.Rows.Count; i++)
            {
                DataRow tela = itensTela.Rows[i];
                DataRow tvp = itensTvp.Rows[i];

                decimal quantidade = (decimal)tvp["QUANTIDADE"];
                decimal valorUnitario = (decimal)tvp["VALORUNITARIO"];
                decimal valorXml = Convert.ToDecimal(tela["Valor"]);
                // A proc grava o total do item como QUANTIDADE * VALORUNITARIO
                decimal totalCalculado = Math.Round(quantidade * valorUnitario, 2);

                somaXml += valorXml;
                somaCalculada += totalCalculado;

                DataRow linha = relatorio.Rows.Add(
                    i + 1,
                    tela["CodProdFornecedor"]?.ToString(),
                    tela["Descricao"]?.ToString(),
                    tvp["IDPRD"],
                    quantidade,
                    valorXml,
                    valorUnitario,
                    totalCalculado,
                    totalCalculado - valorXml,
                    tvp["CODNAT"] == DBNull.Value ? "(nulo)" : tvp["CODNAT"],
                    tvp["CODUND"] == DBNull.Value ? "(nulo)" : tvp["CODUND"]);

                foreach (var t in tributosExibidos)
                {
                    linha[$"{t.Nome} Base"] = Decimal(tvp, t.Base);
                    linha[$"{t.Nome} %"] = Decimal(tvp, t.Aliquota);
                    linha[$"{t.Nome} Valor"] = Decimal(tvp, t.Valor);
                }
            }

            dgvProdutos.DataSource = relatorio;

            foreach (DataGridViewColumn col in dgvProdutos.Columns)
            {
                if (col.ValueType == typeof(decimal))
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.DefaultCellStyle.Format = col.Name == "Valor Unitário" ? "N4" : "N2";
                }
            }
            dgvProdutos.Columns["Quantidade"].DefaultCellStyle.Format = "N4";

            // Com os tributos a grade fica larga: descrição com largura fixa e as 3 primeiras colunas congeladas na rolagem
            DataGridViewColumn colDescricao = dgvProdutos.Columns["Descrição"];
            colDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDescricao.Width = 260;
            colDescricao.Frozen = true;

            // Valores de tributo em azul para separar visualmente das colunas do produto
            foreach (var t in tributosExibidos)
                dgvProdutos.Columns[$"{t.Nome} Valor"].DefaultCellStyle.ForeColor = Color.SteelBlue;

            decimal diferenca = somaCalculada - somaXml;
            string totaisTributos = string.Join("    ", tributosExibidos.Select(t =>
                $"{t.Nome}: {itensTvp.AsEnumerable().Sum(r => Decimal(r, t.Valor)):N2}"));

            lbTotais.Text = $"Itens: {relatorio.Rows.Count}    Total XML: {somaXml:N2}    Total enviado: {somaCalculada:N2}    Diferença: {diferenca:N2}"
                          + Environment.NewLine + "Tributos  →  " + totaisTributos;
            if (diferenca != 0)
                lbTotais.ForeColor = Color.Firebrick;
        }

        private static decimal Decimal(DataRow row, string coluna)
        {
            if (!row.Table.Columns.Contains(coluna) || row[coluna] == DBNull.Value)
                return 0m;
            return Convert.ToDecimal(row[coluna]);
        }

        // Destaca as linhas em que o total recalculado pela proc não bate com o XML
        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var valor = dgvProdutos.Rows[e.RowIndex].Cells[ColDiferenca].Value;
            if (valor is decimal diferenca && diferenca != 0)
                dgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSalmon;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
