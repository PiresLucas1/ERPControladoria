using ERP_FISCAL.Controller.ConsultaSaldoNotasZanup;
using ERP_FISCAL.Utils;
using ERP_FISCAL.view.UIComponentes.UIStatusDoProcessos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view
{
    public partial class ConsultaSaldoNotasFiscais : Form
    {
        public ConsultaSaldoNotasFiscais()
        {
            InitializeComponent();
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            int idProduto;

            if (string.IsNullOrWhiteSpace(txtBoxIDProduto.Text))
            {
                MessageBox.Show("Preencha o campo ID Produto por favor!",
                                "Campo obrigatório",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBoxIDProduto.Text, out idProduto))
            {
                MessageBox.Show("Digite apenas números no campo ID Produto!",
                                "Entrada inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ConsultaSaldoNotasZanupController consultaSaldoNotasZanup = new ConsultaSaldoNotasZanupController();
                DataTable retorno = await consultaSaldoNotasZanup.ConsultaSaldoNotas(idProduto);

                if (retorno.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado!");
                }

                CarregaDataTable(retorno);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado ao consultar notas: " + ex.Message,
                                "Erro no sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
        public void CarregaDataTable(DataTable data)
        {
            if (!data.Columns.Contains("Selecionar"))
            {
                DataColumn colCheck = new DataColumn("Selecionar", typeof(bool));
                colCheck.DefaultValue = false;
                data.Columns.Add(colCheck);
            }


            dtConsultaNotas.DataSource = data;
            dtConsultaNotas.Columns["Selecionar"].DisplayIndex = 0;
            dtConsultaNotas.Columns["Selecionar"].HeaderText = "✓";
            dtConsultaNotas.Columns["Selecionar"].Width = 30;
            dtConsultaNotas.Columns["Selecionar"].Width = 30;


        }

        private void dtConsultaNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora cliques no header

            // Remove a seleção de todas as linhas
            dtConsultaNotas.ClearSelection();

            // Destaca a linha clicada
            dtConsultaNotas.Rows[e.RowIndex].Selected = true;

            // Opcional: Define cores personalizadas para a linha selecionada
            dtConsultaNotas.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dtConsultaNotas.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;

        }

        private void dtConsultaNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtConsultaNotas.Columns[e.ColumnIndex].Name == "Selecionar")
            {
                // Desmarca todas as outras linhas
                foreach (DataGridViewRow row in dtConsultaNotas.Rows)
                {
                    if (row.Index != e.RowIndex)
                        row.Cells["Selecionar"].Value = false;
                }

                // Atualiza o grid
                dtConsultaNotas.EndEdit();
            }
        }

        private void btnCriaNotaFiscal_Click(object sender, EventArgs e)
        {
            var dtOriginal = (DataTable)dtConsultaNotas.DataSource;

            var linhasSelecionadas = dtOriginal.AsEnumerable()
                .Where(r => r.Field<bool>("Selecionar"))
                .ToList();


            if (linhasSelecionadas.Count <= 0)
            {
                MessageBox.Show("Nenhum movimento selecionado para alteração.");
                return;
            }


            StatusProcess splashScreen = new StatusProcess();

            splashScreen.Show(this); // 'this' como owner para ficar modal
            splashScreen.SetMessage("Alterando Tipo de Movimento...");

            DataRowToObject dataRowToObject = new DataRowToObject();
            dataRowToObject.TranformaDataRowToObject(linhasSelecionadas[0]);
        }
    }
}
