using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.CodigoHistorico;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Complemento;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Conta;
using SolfarmaGp.UI.Utils;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.Contabil
{
    public partial class ParametrizacaoContabil : Form
    {

        public List<dtoObjetoComboBoxInteface> cbHistorico { get; set; }
        public List<dtoObjetoComboBoxInteface> cbCodComplemento { get; set; }
        public List<dtoObjetoComboBoxInteface> cbContaCotabil { get; set; }

        public ParametrizacaoContabil()
        {
            InitializeComponent();
            cbTipoPesquisa.Items.AddRange(new object[] {
                "Conta Débito",
                "Conta Crédito",
                "Histórico",
                "Descrição Complemento",
                "Descrição Extrato",
                "Filial"
            });            
        }
        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!ValidaFormularioAberto.FormAberto(typeof(AdicionarItemParametro)))
            {
                AdicionarItemParametro adicionarItemParametro = new AdicionarItemParametro();
                adicionarItemParametro.StartPosition = FormStartPosition.CenterParent;
                DialogResult resultado = adicionarItemParametro.ShowDialog(this);

                if(resultado == DialogResult.Cancel)
                {
                    return;
                }if(resultado == DialogResult.OK)
                {
                    await CarregaTela();
                }
            }
        }

        private async void ParametrizacaoContabil_Load(object sender, EventArgs e)
        {
            await CarregaTela();

        }
        public async Task<DataTable> AtualizarDataGrid()
        {
            ConsultaLancamentoContabilParametrizadoUseCase usecase = new ConsultaLancamentoContabilParametrizadoUseCase();
            DataTable dt = await usecase.Execute();
            return dt;
        }

        private void dvgParametrizacao_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            var cbCodigoReduzidoDebito = new DataGridViewComboBoxCell();
            if (cbContaCotabil.Count > 0)
            {
                cbCodigoReduzidoDebito.DataSource = cbContaCotabil;
                cbCodigoReduzidoDebito.DisplayMember = "valor";
                cbCodigoReduzidoDebito.ValueMember = "label";
            }
            var cbCodigoReduzidoCredito = new DataGridViewComboBoxCell();
            if(cbContaCotabil.Count > 0)
            {
                cbCodigoReduzidoCredito.DataSource = cbContaCotabil;
                cbCodigoReduzidoCredito.DisplayMember = "valor";
                cbCodigoReduzidoCredito.ValueMember = "label";

            }

            var cbCodigoHistorico = new DataGridViewComboBoxCell();
            if(cbContaCotabil.Count   > 0)
            {

                cbCodigoHistorico.DataSource = cbHistorico;
                cbCodigoHistorico.DisplayMember = "valor";
                cbCodigoHistorico.ValueMember = "label";
            }

            var cbComplemento = new DataGridViewComboBoxCell();
            if (cbCodComplemento.Count > 0)
            {
                cbComplemento.DataSource = cbCodComplemento;
                cbComplemento.DisplayMember = "valor";
                cbComplemento.ValueMember = "label";
            }

            var tbDescricaoExtrato = new DataGridViewTextBoxCell();

            var cbFilial = new DataGridViewTextBoxCell();

            e.Row.Cells["Cod. Conta Debito"] = cbCodigoReduzidoDebito;
            e.Row.Cells["Cod. Conta Credito"] = cbCodigoReduzidoCredito;
            e.Row.Cells["Cod. Historico"] = cbCodigoHistorico;
            e.Row.Cells["Complemento"] = cbComplemento;
            e.Row.Cells["Descricão Extrato"] = tbDescricaoExtrato;
            e.Row.Cells["Filial"] = cbFilial;

            e.Row.ReadOnly = false;
            return;
        }
        public async Task CarregaCodigoReduzido()
        {
            ConsultaContaUseCase usecase = new ConsultaContaUseCase();
            var result = await usecase.Execute();
            cbContaCotabil = result
                .Select(x => new dtoObjetoComboBoxInteface
                {
                    label= x.label,
                    valor = x.valor
                })
                .ToList();
            
        }
        public async Task CarregaCodigoHistorico()
        {
            ConsultaCodigoHistorioUseCase usecase = new ConsultaCodigoHistorioUseCase();
            var result = await usecase.Execute();
            cbHistorico =  result
                .Select(x => new dtoObjetoComboBoxInteface
                {
                    label = x.label,
                    valor = x.valor
                })
                .ToList();
        }

        public async Task CarregaComplemento()
        {
            ConsultaComplementoUseCase usecase = new ConsultaComplementoUseCase();
            var result = await usecase.Execute();
            cbCodComplemento =  result
                .Select(x => new dtoObjetoComboBoxInteface
                {
                    label = x.label,
                    valor = x.valor
                })
                .ToList();
        }
        
        public async Task CarregaTela()
        {
            //carrega as informação para o cb de inserção
            await CarregaComplemento();
            await CarregaCodigoHistorico();
            await CarregaCodigoReduzido();
            //carrega os dados do banco e preenche o datagrid
            dvgParametrizacao.AllowUserToAddRows = true;
            DataTable dt = await AtualizarDataGrid();
            dvgParametrizacao.DataSource = dt;
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Nenhum item parametrizado encontrado. Clique em 'Adicionar Item' para criar uma nova parametrização.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (DataGridViewRow row in dvgParametrizacao.Rows)
            {
                row.ReadOnly = true;
            }
        }




        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
