using ERP_FISCAL.Controller.AlteraTipoMovimentoController;
using ERP_FISCAL.Controller.Fiscal.AlteraDataDocumentoMovimentoTotvs;
using ERP_FISCAL.Utils;
using ERP_FISCAL.view.UIComponentes.UIDialog.AlteraUnicoItemEmBloco;
using ERP_FISCAL.view.UIComponentes.UIRetornoEmTabela;
using ERP_FISCAL.view.UIComponentes.UIStatusDoProcessos;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view.FiscalView
{
    public partial class AlterarTipoMovimentoLista : Form
    {
        public AlterarTipoMovimentoLista()
        {
            
            InitializeComponent();
            cbColigada.Items.Add(2);
            rbAlteraDataDocumento.Checked = true;
            AplicarFonte.AplicarFonteForm(this, new System.Drawing.Font(this.Font.FontFamily, Properties.Settings.Default.FonteTamanho));
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
                    retorno = await new AlteraDataDocumentoMovimentoTotvs().ConsultaMovimentoTovts(2, dataInicio, dataFim);
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
            AlterarTipoMovimentoController alterarTipoMovimento = new AlterarTipoMovimentoController();
            var textoSeparadoPorVirugula = txtFiltroInput.Text.
                Replace("\n", ",")
                .Replace("\r\n", ",");
            var textoFormatoParaConsulta = textoSeparadoPorVirugula.Substring(0, textoSeparadoPorVirugula.Length - 1);
            
            DataTable retorno = await alterarTipoMovimento.ConsultaListaMovimento(textoFormatoParaConsulta);
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
            AlterarTipoMovimentoController alterarTipoMovimento = new AlterarTipoMovimentoController();
            DataTable retorno = await alterarTipoMovimento.AlteraListaMovimento(dt);

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
                        
        }

        private async void btnAlteraDataDocumento_Click(object sender, EventArgs e)
        {
            if (!rbAlteraDataDocumento.Checked)
            {
                return;
            }
            DataTable retorno =  await new AlteraDataDocumentoMovimentoTotvs().AlteraDataDocumentoTotvs((DataTable)dvgIDMovs.DataSource);

        }
    }
}
