using ERP_FISCAL.Controller.ConsultaSaldoNotasFiscais;
using ERP_FISCAL.Controller.ConsultaSaldoNotasZanup;
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
    }
}
