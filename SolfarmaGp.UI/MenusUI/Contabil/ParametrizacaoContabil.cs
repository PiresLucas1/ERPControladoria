using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.CodigoHistorico;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Complemento;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Conta;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dto;
using SolfarmaGp.UI.ComponentesTelaUI.ProcessoCarregamento.UIStatusDoProcessos;
using SolfarmaGp.UI.Utils;
using System.Data;
using static SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.ConsultaLancamentoContabilParametrizadoUseCase;

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
                    await CarregaTela(new ObjetoPesquisaParametrosContabil { CodColigada = 0, banco = 0, filial = 0, reduzidoCredito = 0, reduzidoDebito = 0 });
                }
            }
        }

        private async void ParametrizacaoContabil_Load(object sender, EventArgs e)
        {
            await CarregaTela(new ObjetoPesquisaParametrosContabil { CodColigada = 0, banco = 0, filial = 0, reduzidoCredito = 0, reduzidoDebito=0});

        }
        public async Task<DataTable> AtualizarDataGrid(ObjetoPesquisaParametrosContabil objeto)
        {
            ConsultaLancamentoContabilParametrizadoUseCase usecase = new ConsultaLancamentoContabilParametrizadoUseCase();
            DataTable dt = new DataTable();
            if (objeto != null)
            {
                dt = await usecase.Execute(objeto);
                return dt;
            }
             await usecase.Execute(new ObjetoPesquisaParametrosContabil { CodColigada = 0, banco = 0, filial = 0, reduzidoCredito = 0, reduzidoDebito = 0 });
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

        public async Task CarregaTela(ObjetoPesquisaParametrosContabil objeto)
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
            DataTable dt = new DataTable();
            if (objeto != null)
            {
                 dt = await AtualizarDataGrid(objeto);
            }
            else
            {
                dt = await AtualizarDataGrid(new ObjetoPesquisaParametrosContabil { CodColigada = 0, banco = 0, filial = 0, reduzidoCredito = 0, reduzidoDebito = 0 });

            }


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
        private async void btnFiltrar_Click(object sender, EventArgs e)
        {            
            int CodColigada = cbColigada.Text  != "" ? Convert.ToInt32(cbColigada.Text) : 0;
            int filial = tbFilial.Text != "" ? Convert.ToInt32(tbFilial.Text) : 0;
            int banco = tbBanco.Text != "" ?  Convert.ToInt32(tbBanco.Text) : 0;
            int reduzidoCredito = tbReduzidoCredito.Text != "" ? Convert.ToInt32(tbReduzidoCredito.Text): 0;
            int reduzidoDebito = tbReduzidoDebito.Text != "" ? Convert.ToInt32(tbReduzidoDebito.Text) : 0;

            ObjetoPesquisaParametrosContabil pesquisa = new ObjetoPesquisaParametrosContabil
            {
                CodColigada = CodColigada ,
                filial = filial ,
                banco = banco ,
                reduzidoCredito = reduzidoCredito,
                reduzidoDebito = reduzidoDebito 
            };

            await CarregaTela(pesquisa);
        }



        private void ConfigurarColunasCombo()
        {
            dvgParametrizacao.Columns.Clear();

            var colDebito = new DataGridViewComboBoxColumn
            {
                Name = "ContaDebito",
                HeaderText = "Conta Débito",
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
            };

            var colFilial = new DataGridViewTextBoxColumn
            {
                Name = "Filial",
                HeaderText = "Filial",

            };

            var colColigada = new DataGridViewTextBoxColumn
            {
                Name = "CodColigada",
                HeaderText = "Cod. Coligada",

            };

            var colBanco = new DataGridViewTextBoxColumn
            {
                Name = "CodBanco",
                HeaderText = "Cod. Banco",

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
            dvgParametrizacao.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int index = dvgParametrizacao.Rows.Add();

                dvgParametrizacao.Rows[index].Cells["ContaDebito"].Value = row["Cod. Conta Debito"];
                dvgParametrizacao.Rows[index].Cells["ContaCredito"].Value = row["Cod. Conta Credito"];
                dvgParametrizacao.Rows[index].Cells["Historico"].Value = row["Cod. Historico"];
                dvgParametrizacao.Rows[index].Cells["Complemento"].Value = row["Complemento"];
                dvgParametrizacao.Rows[index].Cells["DescricaoExtrato"].Value = row["Descricão Extrato"];
                dvgParametrizacao.Rows[index].Cells["Filial"].Value = row["Filial"];
                dvgParametrizacao.Rows[index].Cells["CodColigada"].Value = row["Cod. Coligada"];
                dvgParametrizacao.Rows[index].Cells["CodBanco"].Value = row["Cod. Banco"];
            }
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
            DataTable dt = new DataTable();

            dt.Columns.Add("CodContaDebito", typeof(int));
            dt.Columns.Add("CodContaCredito", typeof(int));
            dt.Columns.Add("CodHistorico", typeof(int));
            dt.Columns.Add("Complemento", typeof(int));
            dt.Columns.Add("DescricaoExtrato", typeof(string));
            dt.Columns.Add("Filial", typeof(int));
            dt.Columns.Add("CodColigada", typeof(int));
            dt.Columns.Add("CodBanco", typeof(int));

            foreach (DataGridViewRow row in dvgParametrizacao.Rows)
            {
                if (row.IsNewRow)
                    continue;

                dt.Rows.Add(
                    row.Cells["ContaDebito"].Value,
                    row.Cells["ContaCredito"].Value,
                    row.Cells["Historico"].Value,
                    row.Cells["Complemento"].Value,
                    row.Cells["DescricaoExtrato"].Value,
                    row.Cells["Filial"].Value,
                    row.Cells["CodColigada"].Value,
                    row.Cells["CodBanco"].Value
                );
            }
            
            StatusProcess statusProcess = new StatusProcess();
            try
            {
                statusProcess.Visible = true;
                string user = new Portal().pegaValorUsuario();
                AlteraLancamentoParametrizadoUseCase usecase = new AlteraLancamentoParametrizadoUseCase();
                var result = await usecase.Execute(dt, user);
                if (result)
                {
                    await CarregaTela(new ObjetoPesquisaParametrosContabil { CodColigada = 0, banco = 0, filial = 0, reduzidoCredito = 0, reduzidoDebito = 0 });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro Ao salvar Parametros",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                statusProcess.Visible = false;
                statusProcess.Close();
            }
           



        }
    }
}
