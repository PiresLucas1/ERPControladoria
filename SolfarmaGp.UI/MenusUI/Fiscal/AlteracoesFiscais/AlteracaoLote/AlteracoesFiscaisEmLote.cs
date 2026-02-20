using SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.AlteraDataDocumento;
using SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.AlteraTipoMovimentoUnico;
using SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.TipoDeConsultas.ConsultaMovimentoPorFiltro;
using SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.TipoDeConsultas.ConsultaMovimentoSeparadoPorPontoVirgula;
using SolfarmaGp.UI.ComponentesTelaUI.Dialogos.UIDialog.AlteraUnicoItemEmBloco;
using SolfarmaGp.UI.ComponentesTelaUI.ProcessoCarregamento.UIStatusDoProcessos;
using SolfarmaGp.UI.ComponentesTelaUI.Tabelas.UIRetornoEmTabela;
using System.Data;
using System.Globalization;

namespace SolfarmaGp.UI.MenusUI.Fiscal.AlteracoesFiscais.AlteracaoLote
{
    public partial class AlteracoesFiscaisEmLote : Form
    {
        public AlteracoesFiscaisEmLote()
        {
            
            InitializeComponent();
            cbColigada.Items.Add(2);
            rbAlteraDataDocumento.Checked = true;
            //AplicarFonte.AplicarFonteForm(this, new System.Drawing.Font(this.Font.FontFamily, Properties.Settings.Default.FonteTamanho));
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (rbAlteraDataDocumento.Checked)
            {
                var dataInicio = dtInicio.Value.Date;
                var dataFim = dtFim.Value.Date;
                var codColigada = cbColigada.SelectedItem;
                DataTable retorno = new DataTable();
                if (dataInicio > dataFim)
                {
                    MessageBox.Show("A data de início não pode ser maior que a data final.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (codColigada == null)
                {
                    MessageBox.Show("Por favor, selecione uma coligada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    ProcessStatusManager.Start("Carregando dados...");
                    ProcessStatusManager.Update("Processando...");
                    retorno = await new ConsultaMovimentoPorFiltro().Executar(2, dataInicio, dataFim);
                }
                catch (Exception ex)
                {
                    ProcessStatusManager.Error(ex); // Fecha e mostra o erro
                }
                finally
                {
                    ProcessStatusManager.Stop(); // Garante o fechamento
                }

                
                CarregaDataGridView(retorno);
                txtCountRows.Text = retorno.Rows.Count.ToString();

            }
            if (rbAlteraCodTmtv.Checked)
            {
                if (txtFiltroInput.Text == "")
                {
                    MessageBox.Show("Por favor, insira um valor para consulta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable retorno = new DataTable();
                try
                {
                    ProcessStatusManager.Start("Carregando dados...");
                    ProcessStatusManager.Update("Processando...");
                    retorno = await BuscaMovimentos();

                }
                catch (Exception ex)
                {
                    ProcessStatusManager.Error(ex); // Fecha e mostra o erro
                }
                finally
                {
                    ProcessStatusManager.Stop(); // Garante o fechamento
                }


                CarregaDataGridView(retorno);
                txtCountRows.Text = retorno.Rows.Count.ToString();
            }
            
        }

        public async Task<DataTable> BuscaMovimentos()
        {
            ConsultaMovSeparadoPorPontoVirgulaUseCase alterarTipoMovimento = new ConsultaMovSeparadoPorPontoVirgulaUseCase();
            var textoSeparadoPorVirugula = txtFiltroInput.Text.
                Replace("\n", ",")
                .Replace("\r\n", ",");
            var textoFormatoParaConsulta = textoSeparadoPorVirugula.Substring(0, textoSeparadoPorVirugula.Length);
            
            DataTable retorno = await alterarTipoMovimento.Executar(textoFormatoParaConsulta);
            return retorno;
        }
        public void CarregaDataGridView(DataTable data)
        {
            if (data == null)
            {
                MessageBox.Show("Não existe nenhum dado para ser carregado no Data Grid", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!rbAlteraDataDocumento.Checked)
            {
                if (!data.Columns.Contains("Cod TMV novo"))
                {
                    DataColumn colQuantidade = new DataColumn("Cod TMV novo", typeof(string));                    
                    colQuantidade.DefaultValue = 0;
                    data.Columns.Add(colQuantidade);
                }
            }          
            if (!data.Columns.Contains("colSelecionado"))
            {
                DataColumn colSelecionado = new DataColumn("colSelecionado", typeof(bool));
                colSelecionado.DefaultValue = 0;
                data.Columns.Add(colSelecionado);
            }
            dvgIDMovs.DataSource = data;
            if (!rbAlteraDataDocumento.Checked)
            {
                dvgIDMovs.Columns["Cod TMV novo"].DefaultCellStyle.BackColor = Color.PaleGreen;
                dvgIDMovs.Columns["Cod TMV novo"].DefaultCellStyle.ForeColor = Color.Black;

            }
            if (rbAlteraDataDocumento.Checked)
            {
                dvgIDMovs.Columns["Data Pagamento"].DefaultCellStyle.BackColor = Color.PaleGreen;
            }
            dvgIDMovs.Columns["colSelecionado"].DisplayIndex = 0;
            dvgIDMovs.Columns["colSelecionado"].HeaderText = "✓";



        }

        private void btnSelecionarTudo_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dvgIDMovs.Rows)
            {
                row.Cells["colSelecionado"].Value = true;
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvgIDMovs.Rows)
            {
                row.Cells["colSelecionado"].Value = false;
            }
        }

        private void btnAlterarSelecionados_Click(object sender, EventArgs e)
        {
            string valorRetorno ="";
            using (AlteraUnicoValorEmBloco frm = new AlteraUnicoValorEmBloco())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    valorRetorno = frm.valorDigitado;
                }
            }
            if (valorRetorno != "")
            {
                AlteraValorCodTMV(valorRetorno);

            }
        }
        private void AlteraValorCodTMV(string valor)
        {
            DataTable dt = (DataTable)dvgIDMovs.DataSource;

            foreach (DataRow row in dt.Rows)
            {
                row["Cod TMV novo"] = valor;
            }
            
        }

        private async void btnAlteraCodMovimento_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IDMOV", typeof(long));
            dt.Columns.Add("COD. TMV", typeof(string));

            DataTable dtToDvg = (DataTable)dvgIDMovs.DataSource;

            foreach(DataRow row in dtToDvg.Rows)
            {
                if (Convert.ToBoolean(row["colSelecionado"]) == true)
                {
                    DataRow novaLinha = dt.NewRow();
                    novaLinha["IDMOV"] = Convert.ToInt64(row["IDMOV"]);
                    novaLinha["COD. TMV"] = row["Cod TMV novo"].ToString();
                    dt.Rows.Add(novaLinha);
                }
            }
            AltListaMovimentoUseCase alterarTipoMovimento = new AltListaMovimentoUseCase();
            DataTable retorno = await alterarTipoMovimento.Executar(dt);

            RetornoEmTabela retornoEmTabela = new RetornoEmTabela(retorno);
            retornoEmTabela.ShowDialog();


        }

        private void rbAlteraCodTmtv_CheckedChanged(object sender, EventArgs e)
        {            
            dtInicio.Enabled = !dtInicio.Enabled;
            dtFim.Enabled = !dtFim.Enabled;
            cbColigada.Enabled = !cbColigada.Enabled;
        }

        private void rbAlteraDataDocumento_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltroInput.Enabled = !txtFiltroInput.Enabled;
        }

        private async void btnAlteraDataDocumento_Click(object sender, EventArgs e)
        {
            if (!rbAlteraDataDocumento.Checked)
            {
                return;
            }
            foreach (DataGridViewRow item in dvgIDMovs.Rows)
            {
                bool isChecked = (bool)item.Cells["colSelecionado"].Value;
                if (isChecked)
                {
                    if(item.Cells["Data Pagamento"].Value == DBNull.Value)
                    {
                        DialogResult result = MessageBox.Show(
                            "Existe itens selecionados sem data marcada, deseja inserir manualmente?",
                            "Confirmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (result == DialogResult.Yes) 
                        {
                            AlteraUnicoValorEmBloco alteraUnicoValor = new AlteraUnicoValorEmBloco();
                            alteraUnicoValor.Text = "Insira a nova data de pagamento:";
                            DialogResult dialogResult = alteraUnicoValor.ShowDialog();
                            if(dialogResult == DialogResult.OK)
                            {
                                DateTime data;
                                bool ok = DateTime.TryParseExact(
                                     alteraUnicoValor.valorDigitado,
                                     "dd/MM/yyyy",
                                     CultureInfo.GetCultureInfo("pt-BR"),
                                     DateTimeStyles.None,
                                     out data
                                 );
                                if (ok)
                                {
                                    PreencheDataVazia(data);

                                }
                                else
                                {
                                    MessageBox.Show("Data inválida. Operação cancelada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                            }
                        }
                        return;
                    }
                }
            }            
            DataTable retorno =  await new AltDataDocumentoUseCase().Executar((DataTable)dvgIDMovs.DataSource);
            if(retorno.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Retornado, Verifique se a Operação foi Realizada com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            RetornoEmTabela retornoEmTabela = new RetornoEmTabela(retorno);
            retornoEmTabela.Show();
        }
        public void PreencheDataVazia(DateTime date)
        {
            foreach (DataGridViewRow item in dvgIDMovs.Rows)
            {                            
                if (item.Cells["Data Pagamento"].Value == DBNull.Value)
                {
                    item.Cells["Data Pagamento"].Value = date;
                }
            }
        }
    }
  }

