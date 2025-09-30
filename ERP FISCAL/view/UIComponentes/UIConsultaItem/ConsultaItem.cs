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
        int row;
        int coligada;
        DataGridViewRow rowSelecionada = null;
        ImportarNotaView importarNotaViewForm;
        public ConsultaItem(int row, int coligada, UIController controller, String Name, ImportarNotaView importarNotaViewForm)
        {
            InitializeComponent();
            this.controller = controller;
            this.row = row;
            this.coligada = coligada;
            this.Name= Name; ;
            this.importarNotaViewForm = importarNotaViewForm;
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
            Console.WriteLine(table.Columns["CODCOLIGADA"].DataType);
            var query = table.AsEnumerable()
                .Where(row => Convert.ToInt32(row["CODCOLIGADA"]) == coligada);

            if(query.Count() < 1)
            {
                MessageBox.Show("Não foi possivel localizar");
                return;
            }

            DataTable tabelaFiltrada = query.CopyToDataTable();

            dataGridView1.DataSource = tabelaFiltrada;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public async Task<DataTable> RetornaTodosOsDados()
        {
            DataTable data =   await controller.CarregaTodos();
            return data;          
        }
        public async Task<DataTable> RetornaDadosDaOcorrencia(string valor)
        {
            DataTable data = await controller.CarregaComOcorrencia(valor);
            return data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow rowDataGridView = dataGridView1.Rows[e.RowIndex];
                rowSelecionada = rowDataGridView;

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
                tabelaDados = await RetornaTodosOsDados();
            }
            else
            {
                tabelaDados = await RetornaDadosDaOcorrencia(valor);

            }
            CarregarDataGridView(tabelaDados);
        }
        public async Task PesquisaValorPorString(string valor)
        {           
            DataTable tabelaDados;
            if (valor.Length == 0)
            {
                tabelaDados = await RetornaTodosOsDados();
            }
            else
            {
                tabelaDados = await RetornaDadosDaOcorrencia(valor);

            }
            CarregarDataGridView(tabelaDados);
        }
    }
}
