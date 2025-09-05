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

namespace ERP_FISCAL.view.UIComponentes.UIConsultaItem
{
    public partial class ConsultaItem : Form
    {
        DataTable tabelaDados;
        int row;
        int coligada;
        public ConsultaItem(int row, int coligada,DataTable tabelaDados)
        {
            InitializeComponent();
            this.tabelaDados = tabelaDados;
            this.row = row;
            this.coligada = coligada;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string valor = inputValor.Text;
            
            var tabelaFiltradaPorColigada = tabelaDados.AsEnumerable()
                .Where(row => row.Field<int>("CODCOLIGADA") == coligada
                           && row.Field<string>("DESCRICAO_NATUREZA").Contains(valor))
                .CopyToDataTable();
            CarregarDataGridView(tabelaFiltradaPorColigada);
        }
        public void CarregarDataGridView(DataTable table)
        {
            dataGridView1.DataSource = table;

        }
    }
}
