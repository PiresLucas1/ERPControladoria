using ERP_FISCAL.Controller.ConsultaSaldoNotasFiscais;
using ERP_FISCAL.Controller.ConsultaSaldoNotasZanup;
using ERP_FISCAL.Utils;
using ERP_FISCAL.view.UIComponentes.UIStatusDoProcessos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view.ZanupView
{
    public partial class ConsultaNotaItem : Form
    {
        public ConsultaNotaItem()
        {
            InitializeComponent();
        }

        private async void btnPesquisa_Click(object sender, EventArgs e)
        {
           if(dtInicio.Value > dtFim.Value)
            {
                MessageBox.Show("Valor de data invalido");
                return;
            }
           DateTime dataInicio = dtInicio.Value;
           DateTime dataFim = dtFim.Value;
           string cnpjCpf = tbCnpjCpf.Text == "" ? null : tbCnpjCpf.Text;
           int idProduto = tbIdProduto.Text != "" ? int.Parse(tbIdProduto.Text) : 0;
           await CarregaGrid(dataInicio, dataFim, cnpjCpf, idProduto);

        }
        public async Task CarregaGrid(DateTime dataInicio, DateTime dataFim, string cnpjCpf, int idProduto = 0)
        {            
            try
            {
                BindingSource bsRetorno = new BindingSource();

                ProcessStatusManager.Start("Carregando dados...");
                ProcessStatusManager.Update("Processando...");
                btnPesquisa.Enabled = false;

                ConsultaNotasZanupItemController consultaSaldoNotasController = new ConsultaNotasZanupItemController();
                DataTable retorno = await consultaSaldoNotasController.ConsultaNotasZanupItem(dataInicio, dataFim, cnpjCpf, idProduto);

                DataTable dtFormatada = AdicionaColunaCheckBox(retorno);
                bsRetorno.DataSource = dtFormatada;

                dvgRetorno.DataSource = bsRetorno;
                dvgRetorno.Columns["Selecionar"].DisplayIndex = 0;
            }
            catch (Exception ex)
            {
                ProcessStatusManager.Error(ex); // Fecha e mostra o erro
            }
            finally
            {
                ProcessStatusManager.Stop(); // Garante o fechamento
                btnPesquisa.Enabled = true;
            }
                                   
        }
        public DataTable AdicionaColunaCheckBox(DataTable retorno)
        {
            if (!retorno.Columns.Contains("Selecionar"))
            {
                DataColumn col = new DataColumn("Selecionar", typeof(bool));
                col.DefaultValue = false;
                retorno.Columns.Add(col);
            }
            if(!retorno.Columns.Contains("QtdParaDevolver"))
            {
                DataColumn colQtdParaDevolver = new DataColumn("QtdParaDevolver", typeof(int));
                colQtdParaDevolver.DefaultValue = 0;
                retorno.Columns.Add(colQtdParaDevolver);
            }
            return retorno;
            //if (!dvgRetorno.Columns.Contains("Selecionar"))
            //{                                
            //    dvgRetorno.Columns.Clear();
            //    DataGridViewCheckBoxColumn colSelecionar = new DataGridViewCheckBoxColumn
            //    {
            //        Name = "Selecionar",
            //        HeaderText = "Selecionar",
            //        Width = 30,
            //        ReadOnly = false,
            //        FalseValue = false,
            //        TrueValue = true
            //    };
            //    dvgRetorno.Columns.Insert(0, colSelecionar);
            //}
        }
        

        private void btnMarcarTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvgRetorno.Rows)
            {
                row.Cells["Selecionar"].Value = true;
            }
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dvgRetorno.Rows)
            {
                row.Cells["Selecionar"].Value = false;
            }
        }

        private void cbLinhasSelecionadas_CheckedChanged(object sender, EventArgs e)
        {
            BindingSource bs = dvgRetorno.DataSource as BindingSource;            
            if (cbLinhasSelecionadas.Checked)
            {
                bs.Filter = "Selecionar = true";
                
            }
            else
            {
                bs.RemoveFilter();
                
            }
        }

        private async Task CriarNotaBling(List<NotaProdutoDTO> linhasSelecionadas)
        {          
            ConsultaNotasZanupItemController consultaNotasZanupItemController = new ConsultaNotasZanupItemController();
            await consultaNotasZanupItemController.CriaNotaZanup(linhasSelecionadas);
        }

        private async void btnCriarNota_Click_1(object sender, EventArgs e)
        {
            List<NotaProdutoDTO> linhasSelecionadas = dvgRetorno.Rows
               .Cast<DataGridViewRow>()
               .Where(r => !r.IsNewRow &&
                            r.Cells["Selecionar"].Value != null && (bool)r.Cells["Selecionar"].Value)
               .Select(r => new NotaProdutoDTO
               {
                   CnpjCpf = r.Cells["CPF/CNPJ"].Value?.ToString(),
                   Nome = r.Cells["Nome Destinatario"].Value?.ToString(),
                   NumeroNota = Convert.ToInt32(r.Cells["Num. Nota"].Value),
                   Serie = r.Cells["Serie"].Value?.ToString(),
                   DataEmissao = Convert.ToDateTime(r.Cells["Data Emissão"].Value),
                   CodigoProduto = Convert.ToInt32(r.Cells["Cod. Produto"].Value),
                   Produto = r.Cells["Produto"].Value?.ToString(),
                   ValorTotalProduto = Convert.ToDecimal(r.Cells["ValorTotalProduto"].Value),
                   IcmsBase = Convert.ToDecimal(r.Cells["ICMSBase"].Value),
                   IcmsAliquota = Convert.ToDecimal(r.Cells["ICMSAliquota"].Value),
                   IcmsValor = Convert.ToDecimal(r.Cells["ICMSValor"].Value),
                   ChaveAcesso = r.Cells["ChaveAcesso"].Value?.ToString(),
                   QtdParaDevolver = r.Cells["QtdParaDevolver"].Value != null ? Convert.ToInt32(r.Cells["QtdParaDevolver"].Value) : 0,

               })
               .ToList();

            if (!linhasSelecionadas.Any())
            {
                MessageBox.Show("Nenhuma nota Selecionada.");
                return;
            }
           await CriarNotaBling(linhasSelecionadas);
            
        }
    }
}
