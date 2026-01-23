using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_FISCAL.Controller;
using ERP_FISCAL.Repositories;

namespace ERP_FISCAL.view.UIComponentes.UIConsultaItem
{
    public partial class ConsultaItem : Form
    {
        UIController controller;
        DataGridViewRow row;
        int coligada;
        DataGridViewRow rowSelecionada = null;
        ExportarNotasTotvs importarNotaViewForm;
        public ConsultaItem(DataGridViewRow row, int coligada, UIController controller, String Name, ExportarNotasTotvs importarNotaViewForm)
        {
            InitializeComponent();
            this.controller = controller;
            this.row = row;
            this.coligada = coligada;
            this.Name= Name; 
            this.importarNotaViewForm = importarNotaViewForm;
            this.Text = Name;
        }

        public async void btnPesquisar_Click(object sender, EventArgs e)
        {
            await PesquisaValor();
        }
        public void CarregarDataGridView(DataTable table)
        {
            if (table == null)
            {
                MessageBox.Show("Não foi possivel localizar");
                return;
            }        

            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtBoxCountItems.Text = table.Rows.Count.ToString();
        }
        public async Task<DataTable> RetornaTodosOsDados(int codColigada)
        {
            DataTable data =   await controller.CarregaTodos(codColigada);
            return data;          
        }
        public async Task<DataTable> RetornaDadosDaOcorrencia(string valor, int codColigada)
        {
            DataTable data = await controller.CarregaComOcorrencia(valor , codColigada);
            return data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow rowDataGridView = dataGridView1.Rows[e.RowIndex];
                rowSelecionada = rowDataGridView;

                DataRowView convertRow = rowSelecionada.DataBoundItem as DataRowView;

                DataRow datarow = convertRow.Row;

                importarNotaViewForm.AlteraValorDataRow(datarow, this.Name, row);
                this.Close();

            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (rowSelecionada == null)
                return;

            
            DataRowView convertRow = rowSelecionada.DataBoundItem as DataRowView;

            DataRow datarow = convertRow.Row;
            
            importarNotaViewForm.AlteraValorDataRow(datarow, this.Name, row);

            this.Close();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowDataGridView = dataGridView1.Rows[e.RowIndex];
                rowSelecionada = rowDataGridView;

                DataRowView convertRow = rowSelecionada.DataBoundItem as DataRowView;

                DataRow datarow = convertRow.Row;

                importarNotaViewForm.AlteraValorDataRow(datarow, this.Name, row);
                this.Close();
            }
        }

        private async void inputValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputValor.Focused)
            {

                if (e.KeyChar == 13)
                {
                    //Executa  a pesquisa
                    await PesquisaValor();
                }
            }


        }
        public async Task PesquisaValor()
        {
            string valor = inputValor.Text;
            DataTable tabelaDados;
            if (valor.Length == 0)
            {
                tabelaDados = await RetornaTodosOsDados(coligada);
            }
            else
            {
                tabelaDados = await RetornaDadosDaOcorrencia(valor,coligada);

            }
            CarregarDataGridView(tabelaDados);
        }
        public async Task PesquisaValorPorString(string valor)
        {           
            DataTable tabelaDados;
            if (valor.Length == 0)
            {
                tabelaDados = await RetornaTodosOsDados(coligada);
            }
            else
            {
                tabelaDados = await RetornaDadosDaOcorrencia(valor, coligada);

            }
            CarregarDataGridView(tabelaDados);
        }
    }
}
