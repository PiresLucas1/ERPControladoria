using SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasServicoParaTotvs.NaturezaNota;
using SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasServicoParaTotvs.ProdutoServico;
using SolfarmaGp.UI.MenusUI.MenuCompartilhados.ConsultaItens;
using System.Data;

namespace SolfarmaGP.UI.MenusUI.Fiscal.ImportarNotaServicoView
{
    // Formulário para informar o Cód. Serviço TOTVS e o CFOP que serão aplicados em todas as linhas selecionadas
    public partial class PreencherServicoCfopLote : Form
    {
        private const string ColunaCodServico = "CODIGOPRD";
        private const string ColunaDescServico = "DESCRICAO";
        private const string ColunaCodCfop = "COD. NATUREZA";
        private const string ColunaDescCfop = "DESCRIÇÃO NATUREZA";

        private readonly int _codColigada;

        public string CodigoServico { get; private set; }
        public string DescricaoServico { get; private set; }
        public string CodigoCfop { get; private set; }
        public string DescricaoCfop { get; private set; }

        public PreencherServicoCfopLote(int codColigada, int quantidadeLinhas)
        {
            InitializeComponent();
            _codColigada = codColigada;
            lbInfo.Text = $"Coligada {codColigada} - {quantidadeLinhas} linha(s) selecionada(s). Digite o código ou o nome e pressione Enter.";
        }

        private async void btnPesquisarServico_Click(object sender, EventArgs e) => await PesquisarServico();
        private async void btnPesquisarCfop_Click(object sender, EventArgs e) => await PesquisarCfop();

        private async void txtServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            await PesquisarServico();
        }

        private async void txtCfop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            await PesquisarCfop();
        }

        // Se o usuário alterar o texto depois de escolher, a seleção anterior deixa de valer
        private void txtServico_TextChanged(object sender, EventArgs e)
        {
            if (txtServico.Text == CodigoServico) return;
            CodigoServico = null;
            DescricaoServico = null;
            txtDescServico.Text = string.Empty;
        }

        private void txtCfop_TextChanged(object sender, EventArgs e)
        {
            if (txtCfop.Text == CodigoCfop) return;
            CodigoCfop = null;
            DescricaoCfop = null;
            txtDescCfop.Text = string.Empty;
        }

        private async Task PesquisarServico()
        {
            string valor = txtServico.Text.Trim();
            if (string.IsNullOrEmpty(valor)) return;

            DataTable retorno = await new ListaProdutoFiltroUseCase().Executar(valor, _codColigada);
            ResolverRetorno(retorno, ColunaCodServico, "Consulta Produto", "Serviço", SelecionarServico);
        }

        private async Task PesquisarCfop()
        {
            string valor = txtCfop.Text.Trim();
            if (string.IsNullOrEmpty(valor)) return;

            DataTable retorno = await new ListaNaturezaFiltroUseCase().Executar(valor, _codColigada);
            ResolverRetorno(retorno, ColunaCodCfop, "Consulta CFOP", "CFOP", SelecionarCfop);
        }

        // 0 ocorrências: avisa | 1 código: seleciona direto | mais de um código: abre a consulta com as ocorrências
        private void ResolverRetorno(DataTable retorno, string colunaCodigo, string tituloConsulta, string nomeCampo, Action<DataRow> selecionar)
        {
            if (retorno == null || retorno.Rows.Count == 0)
            {
                MessageBox.Show($"{nomeCampo} não localizado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // O mesmo código pode vir repetido (ex.: CFOP com mais de uma conta contábil)
            int codigosDistintos = retorno.AsEnumerable()
                .Select(r => r[colunaCodigo]?.ToString().Trim())
                .Distinct()
                .Count();

            if (codigosDistintos == 1)
            {
                selecionar(retorno.Rows[0]);
                return;
            }

            using ConsultaItem consulta = new ConsultaItem(retorno, tituloConsulta, selecionar);
            consulta.ShowDialog(this);
        }

        private void SelecionarServico(DataRow row)
        {
            CodigoServico = row[ColunaCodServico].ToString().Trim();
            DescricaoServico = row[ColunaDescServico].ToString().Trim();
            txtServico.Text = CodigoServico;
            txtDescServico.Text = DescricaoServico;
        }

        private void SelecionarCfop(DataRow row)
        {
            CodigoCfop = row[ColunaCodCfop].ToString().Trim();
            DescricaoCfop = row[ColunaDescCfop].ToString().Trim();
            txtCfop.Text = CodigoCfop;
            txtDescCfop.Text = DescricaoCfop;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtServico.Text) && CodigoServico == null)
            {
                MessageBox.Show("Pesquise e confirme o Cód. Serviço antes de aplicar (Enter).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtCfop.Text) && CodigoCfop == null)
            {
                MessageBox.Show("Pesquise e confirme o CFOP antes de aplicar (Enter).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CodigoServico == null && CodigoCfop == null)
            {
                MessageBox.Show("Informe ao menos o Cód. Serviço ou o CFOP.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
