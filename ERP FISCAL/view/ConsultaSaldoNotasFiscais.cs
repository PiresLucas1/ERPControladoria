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
        public DataTable dataItensSelecionados = new DataTable();
        public DataTable dataItensPesquisado = new DataTable();
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

            if (dvgConsultaNotas.RowCount > 0)
                ImportaItemParaDvgItensSelecionado();

            try
            {
                ConsultaSaldoNotasZanupController consultaSaldoNotasZanup = new ConsultaSaldoNotasZanupController();
                DataTable retorno = await consultaSaldoNotasZanup.ConsultaSaldoNotas(idProduto);
                
                if(dataItensSelecionados.Columns.Count <= 0)
                    dataItensSelecionados = retorno.Clone();


                if (retorno.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado!");
                }
                dataItensPesquisado = retorno;
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


            dvgConsultaNotas.DataSource = data;
            dvgConsultaNotas.Columns["Selecionar"].DisplayIndex = 0;
            dvgConsultaNotas.Columns["Selecionar"].HeaderText = "✓";
            dvgConsultaNotas.Columns["Selecionar"].Width = 30;
            dvgConsultaNotas.Columns["Selecionar"].Width = 30;


        }

        private void dvgConsultaNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora cliques no header

            // Remove a seleção de todas as linhas
            dvgConsultaNotas.ClearSelection();

            // Destaca a linha clicada
            dvgConsultaNotas.Rows[e.RowIndex].Selected = true;

            // Opcional: Define cores personalizadas para a linha selecionada
            dvgConsultaNotas.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dvgConsultaNotas.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;


        }

        private void dvgConsultaNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dvgConsultaNotas.Columns[e.ColumnIndex].Name == "Selecionar")
            {
                // Desmarca todas as outras linhas
                foreach (DataGridViewRow row in dvgConsultaNotas.Rows)
                {
                    if (row.Index != e.RowIndex)
                        row.Cells["Selecionar"].Value = false;
                }

                // Atualiza o grid
                dvgConsultaNotas.EndEdit();
            }
        }

        public void CriarNotaFiscal()
        {
            var dtOriginal = (DataTable)dvgConsultaNotas.DataSource;

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

            splashScreen.Close();
        }

        private void btGerarNotaFiscal_Click(object sender, EventArgs e)
        {
            CriarNotaFiscal();
        }

        public void ImportaItemParaDvgItensSelecionado()
        {
            if (dvgConsultaNotas.RowCount > 0)
            {
                var dtOriginal = (DataTable)dvgConsultaNotas.DataSource;

                var linhasSelecionadas = dtOriginal.AsEnumerable()
                    .Where(r => r.Field<bool>("Selecionar"))
                    .ToList();

                foreach (var linha in linhasSelecionadas)
                {
                    dataItensSelecionados.ImportRow(linha);
                }
                //dvgItensSelecionados.DataSource = dataItensSelecionados;
            }
        }

        private void tabNavegacaoAba_Selected(object sender, TabControlEventArgs e)
        {
            if (tabNavegacaoAba.SelectedTab == tabItensSelecionado)
            {
                dvgItensSelecionados.DataSource = dataItensSelecionados;

                if (!dvgItensSelecionados.Columns.Contains("DeleteIcone"))
                {
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    imageColumn.Name = "DeleteIcone";
                    imageColumn.HeaderText = "Ícone";
                    dvgItensSelecionados.Columns.Add(imageColumn);
                    //Image icon = Properties.Resources.trash2;

                }

                
            }
        }

        private void dvgItensSelecionados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
