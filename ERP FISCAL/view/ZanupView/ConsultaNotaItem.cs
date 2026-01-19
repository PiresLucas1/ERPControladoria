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
           string cnpjCpf = tbCnpjCpf.Text;
           int idProduto = tbIdProduto.Text != "" ? int.Parse(tbIdProduto.Text) : 0;
           await CarregaGrid(dataInicio, dataFim, cnpjCpf, idProduto);

        }
        public async Task CarregaGrid(DateTime dataInicio, DateTime dataFim, string cnpjCpf, int idProduto = 0)
        {            
            try
            {
                ProcessStatusManager.Start("Carregando dados...");
                ProcessStatusManager.Update("Processando...");
                btnPesquisa.Enabled = false;

                ConsultaNotasZanupItemController consultaSaldoNotasController = new ConsultaNotasZanupItemController();
                DataTable retorno = await consultaSaldoNotasController.ConsultaNotasZanupItem(dataInicio, dataFim, cnpjCpf, idProduto);

                AdicionaColunaCheckBox();
                dvgRetorno.DataSource = retorno;
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
        public void AdicionaColunaCheckBox()
        {
            if (!dvgRetorno.Columns.Contains("Selecionar"))
            {                                
                dvgRetorno.Columns.Clear();
                DataGridViewCheckBoxColumn colSelecionar = new DataGridViewCheckBoxColumn
                {
                    Name = "Selecionar",
                    HeaderText = "",
                    Width = 30,
                    ReadOnly = false,
                    FalseValue = false,
                    TrueValue = true
                };
                dvgRetorno.Columns.Insert(0, colSelecionar);
            }

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

        //private void btnCriarNota_Click(object sender, EventArgs e)
        //{
        //    List<NotaProdutoDTO> linhasSelecionadas = dvgRetorno.Rows
        //        .Cast<DataGridViewRow>()
        //        .Where(r => !r.IsNewRow &&
        //                     r.Cells["Selecionar"].Value !=null && (bool)r.Cells["Selecionar"].Value)
        //        .Select(r => new NotaProdutoDTO
        //        {
        //            CnpjCpf = r.Cells["CnpjCpf"].Value?.ToString(),
        //            Nome = r.Cells["NomeCliente"].Value?.ToString(),
        //            NumeroNota = Convert.ToInt32(r.Cells["NumeroNota"].Value),
        //            Serie = r.Cells["Serie"].Value?.ToString(),
        //            DataEmissao = Convert.ToDateTime(r.Cells["DataEmissao"].Value),
        //            CodigoProduto = Convert.ToInt32(r.Cells["CodigoProduto"].Value),
        //            Produto = r.Cells["DescricaoProduto"].Value?.ToString(),
        //            ValorTotalProduto = Convert.ToDecimal(r.Cells["ValorTotalProduto"].Value),
        //            IcmsBase = Convert.ToDecimal(r.Cells["IcmsBase"].Value),
        //            IcmsAliquota = Convert.ToDecimal(r.Cells["IcmsAliquota"].Value),
        //            IcmsValor = Convert.ToDecimal(r.Cells["IcmsValor"].Value),
        //            ChaveAcesso = r.Cells["ChaveAcesso"].Value?.ToString()
        //        })
        //        .ToList();

        //    if (!linhasSelecionadas.Any())
        //    {
        //        MessageBox.Show("Nenhuma nota Selecionada.");
        //        return;
        //    }
        //    ConsultaNotasZanupItemController consultaNotasZanupItemController = new ConsultaNotasZanupItemController();
        //    consultaNotasZanupItemController.CriaNotaZanup(linhasSelecionadas);
             


        //}
    }
}
