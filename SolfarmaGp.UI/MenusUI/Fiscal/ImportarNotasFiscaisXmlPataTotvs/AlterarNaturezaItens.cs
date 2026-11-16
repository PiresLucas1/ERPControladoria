using SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs;
using SolfarmaGp.UI.MenusUI.MenuCompartilhados.ConsultaItens;
using SolfarmaGp.UI.Utils;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.Fiscal.ImportarNotasFiscaisXmlPataTotvs
{
    // Pesquisa uma Natureza Fiscal (CFOP da TOTVS) para aplicar nos itens selecionados da nota
    public partial class AlterarNaturezaItens : Form
    {
        private const string ColunaCodigo = "COD. NATUREZA";
        private const string ColunaDescricao = "DESCRIÇÃO NATUREZA";

        private readonly int _codColigada;

        public string CodigoNatureza { get; private set; }

        public AlterarNaturezaItens(int codColigada, int quantidadeItens)
        {
            InitializeComponent();
            MascaraNatureza.Aplicar(txtNatureza);
            _codColigada = codColigada;
            lbInfo.Text = $"Coligada {codColigada} - {quantidadeItens} item(ns) selecionado(s). Digite o código ou o nome e pressione Enter. Vazio + ... lista todas.";
        }

        private async void btnPesquisar_Click(object sender, EventArgs e) => await Pesquisar();

        private async void txtNatureza_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            await Pesquisar();
        }

        // Se o usuário alterar o texto depois de escolher, a seleção anterior deixa de valer
        private void txtNatureza_TextChanged(object sender, EventArgs e)
        {
            if (txtNatureza.Text == CodigoNatureza) return;
            CodigoNatureza = null;
            txtDescricao.Text = string.Empty;
        }

        // Campo vazio: lista todas | 0 ocorrências: avisa | 1 código: seleciona direto | mais de um: abre a consulta
        private async Task Pesquisar()
        {
            string valor = txtNatureza.Text.Trim();

            DataTable retorno;
            try
            {
                retorno = await new ConsultaNaturezaEntradaTotvsUseCase().Executar(_codColigada, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar a natureza: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (retorno == null || retorno.Rows.Count == 0)
            {
                MessageBox.Show("Natureza não localizada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // O mesmo código pode vir repetido (ex.: natureza com mais de uma conta contábil)
            int codigosDistintos = retorno.AsEnumerable()
                .Select(r => r[ColunaCodigo]?.ToString().Trim())
                .Distinct()
                .Count();

            if (codigosDistintos == 1)
            {
                Selecionar(retorno.Rows[0]);
                return;
            }

            using ConsultaItem consulta = new ConsultaItem(retorno, "Consulta CFOP", Selecionar);
            consulta.ShowDialog(this);
        }

        private void Selecionar(DataRow row)
        {
            CodigoNatureza = row[ColunaCodigo].ToString().Trim();
            txtNatureza.Text = CodigoNatureza;
            txtDescricao.Text = row[ColunaDescricao].ToString().Trim();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (CodigoNatureza == null)
            {
                MessageBox.Show("Pesquise e confirme a natureza antes de aplicar (Enter).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
