using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.CodigoHistorico;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Complemento;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Conta;
using SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dto;
using SolfarmaGp.UI.ComponentesTelaUI.ProcessoCarregamento.UIStatusDoProcessos;
using System.Data;
using static SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dados.ConsultaLancamentoContabilParametrizadoDadosUseCase;

namespace SolfarmaGp.UI.MenusUI.Contabil.ParametrizacaoConferencia
{
    public partial class AdicionaParametroResumido : Form
    {
        public DataTable dtResumo;
        public List<dtoObjetoComboBoxInteface> cbHistorico { get; set; }
        public List<dtoObjetoComboBoxInteface> cbCodComplemento { get; set; }
        public List<dtoObjetoComboBoxInteface> cbContaCotabil { get; set; }
        public AdicionaParametroResumido(DataTable dt)
        {
            InitializeComponent();
            dtResumo = dt;
            _= CarregaTelaAsync();
        }

        private async Task CarregaTelaAsync()
        {
            await CarregaCodigoReduzido();
            await CarregaCodigoHistorico();
            await CarregaComplemento();

            AjustaColunasComboBox();

            dvgResumo.AutoGenerateColumns = false;
            dvgResumo.DataSource = dtResumo;
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            //salva parametros novos

            await SalvaParametros();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cancela e volta para tela anterior
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
        public void AjustaColunasComboBox()
        {
            dvgResumo.Columns.Clear();

            var colDebito = new DataGridViewComboBoxColumn
            {
                Name = "ContaDebito",
                DataPropertyName = "CodContaDebito",
                HeaderText = "Conta Débito",
                DataSource = cbContaCotabil,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat                
            };

            var colCredito = new DataGridViewComboBoxColumn
            {
                Name = "ContaCredito",
                DataPropertyName = "CodContaCredito",
                HeaderText = "Conta Crédito",
                DataSource = cbContaCotabil,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat                
            };

            var colHistorico = new DataGridViewComboBoxColumn
            {
                Name = "Historico",
                DataPropertyName = "CodHistorico",
                HeaderText = "Histórico",
                DataSource = cbHistorico,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat                
            };

            var colComplemento = new DataGridViewComboBoxColumn
            {
                Name = "Complemento",
                DataPropertyName = "Complemento",
                HeaderText = "Complemento",
                DataSource = cbCodComplemento,
                DisplayMember = "label",
                ValueMember = "valor",
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Flat                
            };

            var colFilial = new DataGridViewTextBoxColumn
            {
                Name = "Filial",
                DataPropertyName = "Filial",
                HeaderText = "Filial",
                ReadOnly = true
            };
            var colDescricao = new DataGridViewTextBoxColumn
            {
                Name = "DescricaoExtrato",
                DataPropertyName = "DescricaoExtrato",
                HeaderText = "Descrição Extrato",
                ReadOnly = true
            };

            var colCodColigada = new DataGridViewTextBoxColumn
            {
                Name = "CodColigada",
                DataPropertyName = "CodColigada",
                HeaderText = "Coligada",
                ReadOnly = true
            };

            var colCodBanco = new DataGridViewTextBoxColumn
            {
                Name = "CodBanco",
                DataPropertyName = "CodBanco",
                HeaderText = "Banco",
                ReadOnly = true
            };

            dvgResumo.Columns.AddRange(
                colDebito,
                colCredito,
                colHistorico,
                colComplemento,
                colDescricao,
                colCodColigada,
                colFilial,
                colCodBanco
            );
        }
        //CARREGA OS COMBOBOX DE HISTORICO, COMPLEMENTO E CONTA CONTABIL
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
        //salva parametros novos
        public async Task SalvaParametros()
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

            foreach (DataGridViewRow row in dvgResumo.Rows)
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

            ProcessStatusManager.Start("Carregando dados...");
            ProcessStatusManager.Update("Processando...");
            try
            {
                string user = new Portal().pegaValorUsuario();
                AdicionaParametroResumidoUseCase usecase = new AdicionaParametroResumidoUseCase();
                var result = await usecase.Execute(dt, user);

            }
            catch (Exception ex)
            {
                ProcessStatusManager.Error(ex);
                MessageBox.Show(ex.Message, "Erro Ao salvar Parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProcessStatusManager.Stop();

            }
        }


        }
    }
