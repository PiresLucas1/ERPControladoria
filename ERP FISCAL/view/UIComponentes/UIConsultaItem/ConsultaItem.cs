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
        public ConsultaItem(int row, int coligada, UIController controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.row = row;
            this.coligada = coligada;
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            string valor = inputValor.Text;
            DataTable tabelaDados;
            if(valor.Length == 0 )
            {
                tabelaDados = await RetornaTodosOsDados();
            }
            else
            {
                tabelaDados = await RetornaDadosDaOcorrencia(valor);

            }
            CarregarDataGridView(tabelaDados);
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
                .Where(row => row.Field<int>("CODCOLIGADA") == coligada);

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
    }
}
