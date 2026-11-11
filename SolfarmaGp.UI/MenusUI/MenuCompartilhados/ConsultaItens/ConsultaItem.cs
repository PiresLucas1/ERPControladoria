using SolfarmaGP.UI.MenusUI.Fiscal.ImportarNotaServicoView;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.MenuCompartilhados.ConsultaItens
{
    public partial class ConsultaItem : Form
    {        
        DataGridViewRow row;        
        DataGridViewRow rowSelecionada = null;
        ImportarNotasTotvs importarNotaViewForm;
        DataTable _tabelaOrigem;
        Action<DataRow> _aoSelecionar;
        public ConsultaItem(DataGridViewRow row, DataTable table,String Name, ImportarNotasTotvs importarNotaViewForm)
        {
            InitializeComponent();            
            this.row = row;            
            this.Name= Name; 
            this.importarNotaViewForm = importarNotaViewForm;
            this.Text = Name;
            _tabelaOrigem = table;
                CarregarDataGridView(table);
        }

        // Usado quando a seleção não é para uma linha da grade (ex.: preenchimento em lote)
        public ConsultaItem(DataTable table, String Name, Action<DataRow> aoSelecionar)
        {
            InitializeComponent();
            this.Name = Name;
            this.Text = Name;
            _aoSelecionar = aoSelecionar;
            _tabelaOrigem = table;
            CarregarDataGridView(table);
        }

        private void RetornarSelecao(DataRow datarow)
        {
            if (_aoSelecionar != null)
                _aoSelecionar(datarow);
            else
                importarNotaViewForm.AlteraValorDataRow(datarow, this.Name, row);
        }

        public async void btnPesquisar_Click(object sender, EventArgs e)
        {
             PesquisaValor();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow rowDataGridView = dataGridView1.Rows[e.RowIndex];
                rowSelecionada = rowDataGridView;

                DataRowView convertRow = rowSelecionada.DataBoundItem as DataRowView;

                DataRow datarow = convertRow.Row;

                RetornarSelecao(datarow);
                this.Close();

            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (rowSelecionada == null)
                return;

            
            DataRowView convertRow = rowSelecionada.DataBoundItem as DataRowView;

            DataRow datarow = convertRow.Row;
            
            RetornarSelecao(datarow);

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

                RetornarSelecao(datarow);
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
                    PesquisaValor();
                }
            }


        }
        public void PesquisaValor(string valorPesquisa = null)
        {
            string valor = string.Empty;
            if (valorPesquisa == null)
            {
                valor = inputValor.Text.Trim();
            }else
                            {
                valor = valorPesquisa.Trim();
            }
            DataView view = _tabelaOrigem.DefaultView;

            if(string.IsNullOrEmpty(valor))
            {
                view.RowFilter = string.Empty; // Remove o filtro se o valor estiver vazio
            }
            else
            {                
                string filterExpression = string.Join(" OR ", _tabelaOrigem.Columns.Cast<DataColumn>()
                    .Select(col => $"CONVERT([{col.ColumnName}], 'System.String') LIKE '%{valor}%'"));
                view.RowFilter = filterExpression;
            }
        }
    }
}
