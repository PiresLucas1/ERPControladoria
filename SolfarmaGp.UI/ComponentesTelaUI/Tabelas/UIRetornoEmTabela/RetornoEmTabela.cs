using System.Data;


namespace SolfarmaGp.UI.UiComponentesTela.Tabelas.UIRetornoEmTabela
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
                var coluna = new DataGridViewColumn
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

            txtBoxCount.Text = $"Registros: {_data.Rows.Count}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
