using ERP_FISCAL.controller;
using ERP_FISCAL.Controller.ExportaDadosBigController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view
{
    public partial class ExportaDadosBig : Form
    {
        public ExportaDadosBig()
        {
            InitializeComponent();
            cbConferida.Items.Add("Sim");
            cbConferida.Items.Add("Não");
            cbConferida.Items.Add("Todos");
            cbConferida.SelectedIndex = 1;
        }

        public async Task<DataTable> BuscaDataTable(DateTime dataInicio, DateTime dataFim, int filial,char verificaConferida)
        {
            ExportaDadosBigController exportaDadosBigController = new ExportaDadosBigController();
            DataTable retorno = await exportaDadosBigController.BuscaNotasDoBigNaoEncontradoNaTotvs(dataInicio, dataFim, filial, verificaConferida);

            return retorno;
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (dtPickerInicio.Value > dtPickerFinal.Value)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string verifacaConferida =
                cbConferida.SelectedItem.ToString() == "Sim" ? "S" :
                cbConferida.SelectedItem.ToString() == "Não" ? "N" :
                cbConferida.SelectedItem.ToString() == "Todos" ? "T" : "T";
            string filial = txtFilial.Text == "" ? null : txtFilial.Text;
            DataTable dataRetorno = await BuscaDataTable(dtPickerInicio.Value, dtPickerFinal.Value, Convert.ToInt32(filial), Convert.ToChar(verifacaConferida));
            CarregaDataTable(dataRetorno);
        }
        public void CarregaDataTable(DataTable data)
        {
            if (!data.Columns.Contains("Selecionar"))
            {
                DataColumn colCheck = new DataColumn("Selecionar", typeof(bool));
                colCheck.DefaultValue = false;
                data.Columns.Add(colCheck);
            }


            dtNotasImportadas.DataSource = data;
            dtNotasImportadas.Columns["Selecionar"].DisplayIndex = 0;
            dtNotasImportadas.Columns["Selecionar"].HeaderText = "✓";
            dtNotasImportadas.Columns["Selecionar"].Width = 30;
            dtNotasImportadas.Columns["Selecionar"].Width = 30;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //NotasController exportServiceNotes = new NotasController();
            var dtOriginal = (DataTable)dtNotasImportadas.DataSource;
            var linhasSelecionadas = dtOriginal.AsEnumerable()
                .Where(r => r.Field<bool>("Selecionar"))
                .ToList();

            Console.WriteLine(linhasSelecionadas);

        }
    }
}
