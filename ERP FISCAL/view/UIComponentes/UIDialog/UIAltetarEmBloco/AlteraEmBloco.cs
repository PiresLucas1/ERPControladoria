using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view.UIComponentes.UIDialog.UIAltetarEmBloco
{
    public partial class AlteraEmBloco : Form
    {
        private readonly DTOAlteraEmBloco _data;
        private readonly DataGridView _dataGrid;
        public AlteraEmBloco(DTOAlteraEmBloco data, DataGridView tabela)
        {
            InitializeComponent();
            _data = data;
            _dataGrid = tabela;

            label1.Text = data.TextLabel1;
            label1.AutoSize = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_dataGrid == null || _dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in _dataGrid.SelectedRows)
            {
                if (_dataGrid.Columns.Contains("Conta Débito")) // verifica se existe essa coluna
                {
                    row.Cells["Conta Débito"].Value = textBoxValorNovo.Text; // aplica o novo valor
                }
            }

            MessageBox.Show("Linhas alteradas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
