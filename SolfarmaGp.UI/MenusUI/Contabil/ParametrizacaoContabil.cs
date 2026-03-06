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

            dvgParametrizacao.DataError += (s, e) =>
            {
                e.ThrowException = false;
            };

            cbTipoPesquisa.Items.AddRange(new object[] {
                "Cod. Conta Debito",
                "Cod. Conta Credito",
                "Cod. Historico",
                "Complemento",
                "Descrição Extrato",
                "Filial"
            });
            cbColigada.Items.AddRange(new object[] { 10 });
            dvgParametrizacao.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dvgParametrizacao.IsCurrentCellDirty)
                    dvgParametrizacao.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
        }
        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!ValidaFormularioAberto.FormAberto(typeof(AdicionarItemParametro)))
            {
                AdicionarItemParametro adicionarItemParametro = new AdicionarItemParametro();
                adicionarItemParametro.StartPosition = FormStartPosition.CenterParent;
                DialogResult resultado = adicionarItemParametro.ShowDialog(this);

                if (resultado == DialogResult.Cancel)
                {
                    return;
                }
                if (resultado == DialogResult.OK)
                {
                    await CarregaTela();
                }
            }
        }

        private async void ParametrizacaoContabil_Load(object sender, EventArgs e)
        {
            await CarregaTela();

        }
        public async Task<DataTable> AtualizarDataGrid(int codcoligada = 0)
        {
            ConsultaLancamentoContabilParametrizadoUseCase usecase = new ConsultaLancamentoContabilParametrizadoUseCase();
            DataTable dt = await usecase.Execute(codcoligada);
            return dt;
        }       
        public async Task CarregaCodigoReduzido()
        {
            ConsultaContaUseCase usecase = new ConsultaContaUseCase();
            var result = await usecase.Execute();
            cbContaCotabil = result
                .Select(x => new dtoObjetoComboBoxInteface
                {
                    label = x.label,
                    valor = x.valor
                })
                .ToList();            

        }
        public async Task CarregaCodigoHistorico()
        {
            ConsultaCodigoHistorioUseCase usecase = new ConsultaCodigoHistorioUseCase();
            var result = await usecase.Execute();
            cbHistorico = result
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
            cbCodComplemento = result
                .Select(x => new dtoObjetoComboBoxInteface
                {
                    label = x.label,
                    valor = x.valor
                })
                .ToList();
            
        }

        public async Task CarregaTela()
        {
            await CarregaComplemento();
            await CarregaCodigoHistorico();
            await CarregaCodigoReduzido();

            dvgParametrizacao.AutoGenerateColumns = false;
            dvgParametrizacao.AllowUserToAddRows = true;
            dvgParametrizacao.RowHeadersVisible = false;
            dvgParametrizacao.ReadOnly = false;
            dvgParametrizacao.EditMode = DataGridViewEditMode.EditOnEnter;

            dvgParametrizacao.Columns.Clear();
            ConfigurarColunasCombo();

            DataTable dt = await AtualizarDataGrid();
            dvgParametrizacao.DataSource = dt;

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show(
                    "Nenhum item parametrizado encontrado. Clique em 'Adicionar Item' para criar uma nova parametrização.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            tbCount.Text = dt.Rows.Count.ToString();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dvgParametrizacao.DataSource;

            string valorPesquisa = tbValorPesquisa.Text;
            string valorFiltro = cbTipoPesquisa.Text;

            if (string.IsNullOrEmpty(valorFiltro))
            {
                dvgParametrizacao.DataSource = dt;
                return;
            }
            valorPesquisa = valorPesquisa.Replace("'", "''");
            DataView dv = new DataView(dt);
            dv.RowFilter = $"{valorFiltro} LIKE '%{valorPesquisa}%'";

            dvgParametrizacao.DataSource = dv;
        }

        private async void cbColigada_SelectedValueChanged(object sender, EventArgs e)
        {
            int valorCodColigada = Convert.ToInt32(cbColigada.SelectedValue.ToString());
            await AtualizarDataGrid(valorCodColigada);

        }

        private async void btnAdicionaLinha_Click(object sender, EventArgs e)
        {
            

            DataGridViewRow novaLinha = dvgParametrizacao.CurrentRow;

            var contaDebito = novaLinha.Cells["Cod. Conta Debito"].Value?.ToString();
            var contaCredito = novaLinha.Cells["Cod. Conta Credito"].Value?.ToString();
            var codHistorico = novaLinha.Cells["Cod. Historico"].Value?.ToString();
            var complemento = novaLinha.Cells["Complemento"].Value?.ToString();
            var extrato = novaLinha.Cells["Descricão Extrato"].Value?.ToString();
            var filial = novaLinha.Cells["Filial"].Value?.ToString();
            var coligada = novaLinha.Cells["Cod. Coligada"].Value?.ToString();

            DtoLancamentoNovo novoLancamento = new DtoLancamentoNovo{
                IDContaContabilDebito= Convert.ToInt32(contaDebito),
                IDContaContabilCredito = Convert.ToInt32(contaCredito),
                IDHistorico = Convert.ToInt32(codHistorico),
                IDComplemento = Convert.ToInt32(complemento),
                DescricaoExtrato = extrato,
                Filial = Convert.ToInt32(filial),
                CodColigada = Convert.ToInt32(coligada)

            };

            AdicionaLancamentoParametrizadoUseCase usecase = new AdicionaLancamentoParametrizadoUseCase();
            await usecase.Execute(novoLancamento);
            await CarregaTela();


        }
        private void ConfigurarColunasCombo()
        {
            dvgParametrizacao.Columns.Clear();

            var colDebito = new DataGridViewComboBoxColumn
            {
                HeaderText = "Conta Débito",
                DataPropertyName = "Cod. Conta Debito",
                DataSource = cbContaCotabil,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            };

            var colCredito = new DataGridViewComboBoxColumn
            {
                HeaderText = "Conta Crédito",
                DataPropertyName = "Cod. Conta Credito",
                DataSource = cbContaCotabil,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            };

            var colHistorico = new DataGridViewComboBoxColumn
            {
                HeaderText = "Histórico",
                DataPropertyName = "Cod. Historico",
                DataSource = cbHistorico,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            };

            var colComplemento = new DataGridViewComboBoxColumn
            {
                HeaderText = "Complemento",
                DataPropertyName = "Complemento",
                DataSource = cbCodComplemento,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            };

            var colDescricao = new DataGridViewTextBoxColumn
            {
                HeaderText = "Descrição Extrato",
                DataPropertyName = "Descricão Extrato"
            };

            var colFilial = new DataGridViewTextBoxColumn
            {
                HeaderText = "Filial",
                DataPropertyName = "Filial"
            };

            var colColigada = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cod. Coligada",
                DataPropertyName = "Cod. Coligada"
            };

            var colBanco = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cod. Banco",
                DataPropertyName = "Cod. Banco"
            };

            dvgParametrizacao.Columns.AddRange(
                colDebito,
                colCredito,
                colHistorico,
                colComplemento,
                colDescricao,
                colFilial,
                colColigada,
                colBanco
            );
        }
    }
}
