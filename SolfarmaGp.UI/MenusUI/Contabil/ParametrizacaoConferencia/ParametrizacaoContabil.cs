using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.CodigoHistorico;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Complemento;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Conta;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dados;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dto;
using SolfarmaGp.UI.ComponentesTelaUI.ProcessoCarregamento.UIStatusDoProcessos;
using SolfarmaGp.UI.Utils;
using System.Data;
using static SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.ConsultaLancamentoContabilParametrizadoUseCase;
using static SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dados.ConsultaLancamentoContabilParametrizadoDadosUseCase;

namespace SolfarmaGp.UI.MenusUI.Contabil
{
    public partial class ParametrizacaoContabil : Form
    {

        public List<dtoObjetoComboBoxInteface> cbHistorico { get; set; }
        public List<dtoObjetoComboBoxInteface> cbCodComplemento { get; set; }
        public List<dtoObjetoComboBoxInteface> cbContaCotabil { get; set; }

        private DataTable _tabela;
        private BindingSource _bs = new BindingSource();

        public ParametrizacaoContabil()
        {
            InitializeComponent();

            dvgParametrizacao.DataSource = _bs;
            dvgParametrizacao.DataError += (s, e) =>
            {
                e.ThrowException = false;
            };

            cbColigada.Items.AddRange(new object[] { 10 });
            dvgParametrizacao.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dvgParametrizacao.IsCurrentCellDirty)
                    dvgParametrizacao.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            toolTip1.SetToolTip(btnLimpaFiltro, "Limpar Filtro");
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
                    await CarregaTela(new ObjetoPesquisaParametrosContabilDados { CodColigada = 0, banco = 0, filial = 0, reduzidoCredito = 0, reduzidoDebito = 0 });
                }
            }
        }

        private async void ParametrizacaoContabil_Load(object sender, EventArgs e)
        {
            await CarregaTela(new ObjetoPesquisaParametrosContabilDados { CodColigada = 0, banco = 0, filial = 0, reduzidoCredito = 0, reduzidoDebito = 0 });

        }
        public async Task<DataTable> AtualizarDataGrid(ObjetoPesquisaParametrosContabilDados objeto)
        {
            DataTable dt = new DataTable();
            ConsultaLancamentoContabilParametrizadoDadosUseCase usecase = new ConsultaLancamentoContabilParametrizadoDadosUseCase();
            dt = await usecase.Execute(objeto);
            return dt;


        }
        public async Task CarregaCodigoReduzido()
        {
            ConsultaContaUseCase usecase = new ConsultaContaUseCase();
            var result = await usecase.Execute();
            cbContaCotabil = result
                .Select(x => new dtoObjetoComboBoxInteface
                {
                    label = x.label.Trim(),
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
                    label = x.label.Trim(),
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
                    label = x.label.Trim(),
                    valor = x.valor
                })
                .ToList();

        }

        public async Task CarregaTela(ObjetoPesquisaParametrosContabilDados objeto)
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
            //DataTable dt = new DataTable();
            var parametros = objeto ?? new ObjetoPesquisaParametrosContabilDados
            {
                CodColigada = 0,
                banco = 0,
                filial = 0,
                reduzidoCredito = 0,
                reduzidoDebito = 0
            };
            DataTable dt = await AtualizarDataGrid(parametros);


            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show(
                    "Nenhum item parametrizado encontrado. Clique em 'Adicionar Item' para criar uma nova parametrização.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            PopularGrid(dt);

            tbCount.Text = dt.Rows.Count.ToString();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int CodColigada = cbColigada.Text != "" ? Convert.ToInt32(cbColigada.Text) : 0;
            int filial = tbFilial.Text != "" ? Convert.ToInt32(tbFilial.Text) : 0;
            int banco = tbBanco.Text != "" ? Convert.ToInt32(tbBanco.Text) : 0;
            int reduzidoCredito = tbReduzidoCredito.Text != "" ? Convert.ToInt32(tbReduzidoCredito.Text) : 0;
            int reduzidoDebito = tbReduzidoDebito.Text != "" ? Convert.ToInt32(tbReduzidoDebito.Text) : 0;

            ObjetoPesquisaParametrosContabilDados pesquisa = new ObjetoPesquisaParametrosContabilDados
            {
                CodColigada = CodColigada,
                filial = filial,
                banco = banco,
                reduzidoCredito = reduzidoCredito,
                reduzidoDebito = reduzidoDebito
            };

            FiltraValorTabel(pesquisa);
        }
        public void FiltraValorTabel(ObjetoPesquisaParametrosContabilDados parametros)
        {
            List<string> filtros = new List<string>();
            if (parametros.CodColigada != 0)
                filtros.Add($"CodColigada = {parametros.CodColigada}");

            if (parametros.filial != 0)
                filtros.Add($"Filial = {parametros.filial}");

            if (parametros.banco != 0)
                filtros.Add($"CodBanco = {parametros.banco}");

            if (parametros.reduzidoCredito != 0)
                filtros.Add($"CodContaCredito = {parametros.reduzidoCredito}");

            if (parametros.reduzidoDebito != 0)
                filtros.Add($"CodContaDebito = {parametros.reduzidoDebito}");

            _bs.Filter = string.Join(" AND ", filtros);

            tbCount.Text = _bs.Count.ToString();
        }
        public void LimpaFiltro()
        {
            _bs.Filter = "";
            tbCount.Text = _bs.Count.ToString();
        }



        private void ConfigurarColunasCombo()
        {
            dvgParametrizacao.Columns.Clear();

            var colDebito = new DataGridViewComboBoxColumn
            {
                Name = "ContaDebito",
                HeaderText = "Conta Débito",
                DataPropertyName = "CodContaDebito",
                DataSource = cbContaCotabil,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat,
                ReadOnly = true
            };

            var colCredito = new DataGridViewComboBoxColumn
            {
                Name = "ContaCredito",
                HeaderText = "Conta Crédito",
                DataPropertyName = "CodContaCredito",
                DataSource = cbContaCotabil,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat,
                ReadOnly = true
            };

            var colHistorico = new DataGridViewComboBoxColumn
            {
                Name = "Historico",
                HeaderText = "Histórico",
                DataPropertyName = "CodHistorico",
                DataSource = cbHistorico,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat,
                ReadOnly = true
            };

            var colComplemento = new DataGridViewComboBoxColumn
            {
                Name = "Complemento",
                HeaderText = "Complemento",
                DataPropertyName = "Complemento",
                DataSource = cbCodComplemento,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat,
                ReadOnly = true
            };

            var colDescricao = new DataGridViewTextBoxColumn
            {
                Name = "DescricaoExtrato",
                HeaderText = "Descrição Extrato",
                DataPropertyName = "DescricaoExtrato",
            };

            var colFilial = new DataGridViewTextBoxColumn
            {
                Name = "Filial",
                HeaderText = "Filial",
                DataPropertyName = "Filial",

            };

            var colColigada = new DataGridViewTextBoxColumn
            {
                Name = "CodColigada",
                HeaderText = "Cod. Coligada",
                DataPropertyName = "CodColigada",

            };

            var colBanco = new DataGridViewTextBoxColumn
            {
                Name = "CodBanco",
                HeaderText = "Cod. Banco",
                DataPropertyName = "CodBanco"

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
        private void PopularGrid(DataTable dt)
        {
            //População de dvg e binding
            _tabela = dt;
            _bs.DataSource = _tabela;
            dvgParametrizacao.DataSource = _bs;
        }

        private void dvgParametrizacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dvgParametrizacao.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = Color.DarkSalmon;

            var cell = dvgParametrizacao.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell is DataGridViewComboBoxCell)
            {
                cell.ReadOnly = false;
                dvgParametrizacao.BeginEdit(true);
            }




        }

        private void dvgParametrizacao_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dvgParametrizacao.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = Color.White;

            var cell = dvgParametrizacao.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell is DataGridViewComboBoxCell)
            {
                cell.ReadOnly = true;
            }

        }

        private async void btnSalvaParametros_Click(object sender, EventArgs e)
        {
            // Confirma qualquer edição pendente no grid
            _bs.EndEdit();
            DataTable dtParaSalvar = PrepararTabelaParaSalvar();

            // Pega só as linhas que foram alteradas (Added, Modified, Deleted)
            //DataTable alteracoes = _tabela.GetChanges();

            //if (alteracoes == null || alteracoes.Rows.Count == 0)
            //{
            //    MessageBox.Show("Nenhuma alteração encontrada.", "Informação",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            ProcessStatusManager.Start("Carregando dados...");
            ProcessStatusManager.Update("Processando...");
            try
            {
                string user = new Portal().pegaValorUsuario();
                AlteraLancamentoParametrizadoUseCase usecase = new AlteraLancamentoParametrizadoUseCase();
                var result = await usecase.Execute(dtParaSalvar, user);

                if (result)
                {
                    // Confirma as alterações no DataTable (limpa os RowState)
                    _tabela.AcceptChanges();
                    await CarregaTela(new ObjetoPesquisaParametrosContabilDados
                    {
                        CodColigada = 0,
                        banco = 0,
                        filial = 0,
                        reduzidoCredito = 0,
                        reduzidoDebito = 0
                    });
                }
            }
            catch (Exception ex)
            {
                ProcessStatusManager.Error(ex);
                MessageBox.Show(ex.Message, "Erro Ao salvar Parametros",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProcessStatusManager.Stop();
            }
        }
        private DataTable PrepararTabelaParaSalvar()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("CodContaDebito", typeof(int));
            dt.Columns.Add("CodContaCredito", typeof(int));
            dt.Columns.Add("CodHistorico", typeof(int));
            dt.Columns.Add("Complemento", typeof(int));
            dt.Columns.Add("DescricaoExtrato", typeof(string));
            dt.Columns.Add("Filial", typeof(int));
            dt.Columns.Add("CodColigada", typeof(int));
            dt.Columns.Add("CodBanco", typeof(int));

            foreach (DataRow row in _tabela.Rows)
            {
                // ignora linhas deletadas
                if (row.RowState == DataRowState.Deleted)
                    continue;

                dt.Rows.Add(
                    row["CodContaDebito"],
                    row["CodContaCredito"],
                    row["CodHistorico"],
                    row["Complemento"],
                    row["DescricaoExtrato"],
                    row["Filial"],
                    row["CodColigada"],
                    row["CodBanco"]
                );
            }

            return dt;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(_bs.Current == null)
            {
                return;
            }
            if(_bs.Current is DataRowView drv && drv.Row.RowState == DataRowState.Added)
            {
                _bs.RemoveCurrent();
            }
            else
            {
                (_bs.Current as DataRowView)?.Row.Delete();
            }
            tbCount.Text = _bs.Count.ToString();
        }

        private void btnLimpaFiltro_Click(object sender, EventArgs e)
        {
            LimpaFiltro();
        }
    }
}
