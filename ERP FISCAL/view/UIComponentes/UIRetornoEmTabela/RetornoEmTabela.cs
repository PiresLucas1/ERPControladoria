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
        public DataTable _data = new DataTable();
        public RetornoEmTabela(DataTable dt)
        {
            InitializeComponent();
            _data = dt;
            this.Load += RetornoEmTabela_Load;

        }


        private void RetornoEmTabela_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        public void CarregaDataGrid()
        {
            dataGridRetorno.AutoGenerateColumns = false;
            dataGridRetorno.Columns.Clear();

            foreach (DataColumn column in _data.Columns)
            {
                var coluna = new DataGridViewAutoFilterTextBoxColumn
                {
                    HeaderText = column.ColumnName,
                    DataPropertyName = column.ColumnName,
                    Name = column.ColumnName
                };

                dataGridRetorno.Columns.Add(coluna);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = _data;
            dataGridRetorno.DataSource = bs;

            // Ajuste visual
            dataGridRetorno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridRetorno.AllowUserToAddRows = false;
            dataGridRetorno.ReadOnly = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
