using Microsoft.IdentityModel.Tokens;
using SolfarmaGP.UI.MenuUI.Fiscal.ImportarNotaServicoView;
using System.Data;

namespace SolfarmaGp.UI.ComponentesTelaUI.Dialogos.UIConsultaItem
{
    public partial class ConsultaItem : Form
    {        
        DataGridViewRow row;
        int coligada;
        DataGridViewRow rowSelecionada = null;
        ImportarNotasTotvs importarNotaViewForm;
        private DataTable _dtOriginal;
        public ConsultaItem(DataGridViewRow row, int coligada,DataTable dtSource, String Name, ImportarNotasTotvs importarNotaViewForm)
        {
            InitializeComponent();            
            this.row = row;
            this.coligada = coligada;
            this.Name= Name; 
            this.importarNotaViewForm = importarNotaViewForm;
            this.Text = Name;
            this._dtOriginal = dtSource;
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
            if(valor.IsNullOrEmpty())
            {
                dataGridView1.DataSource = _dtOriginal;
                return;
            }
            else
            {
               DataView view = new DataView(_dtOriginal);
               view.RowFilter = $"Convert([{_dtOriginal.Columns[0].ColumnName}], System.String) LIKE '%{valor}%'";
               dataGridView1.DataSource = view;
            }
            
        }
    }
}
