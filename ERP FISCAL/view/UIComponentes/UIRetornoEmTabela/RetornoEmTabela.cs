using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewAutoFilter;


namespace ERP_FISCAL.view.UIComponentes.UIRetornoEmTabela
{
    public partial class RetornoEmTabela : Form
    {
        public RetornoEmTabela(DataTable dt)
        {
            InitializeComponent();

            CarregaDataGrid();
            
        }
        public void CarregaDataGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome");
            dt.Columns.Add("Cidade");
            dt.Rows.Add("Rudinei", "Caxias");
            dt.Rows.Add("Ana", "Porto Alegre");
            dt.Rows.Add("Carlos", "Caxias");

            // Limpa colunas existentes
            dataGridRetorno.Columns.Clear();

            // Adiciona colunas com autofiltro
            var colNome = new DataGridViewAutoFilterTextBoxColumn
            {
                HeaderText = "Nome",
                DataPropertyName = "Nome"
            };

            var colCidade = new DataGridViewAutoFilterTextBoxColumn
            {
                HeaderText = "Cidade",
                DataPropertyName = "Cidade"
            };

            dataGridRetorno.Columns.Add(colNome);
            dataGridRetorno.Columns.Add(colCidade);
            // Define a origem de dados
            dataGridRetorno.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
