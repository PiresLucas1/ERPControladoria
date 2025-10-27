using ERP_FISCAL.controller;
using ERP_FISCAL.Controller.ExportaDadosBigController;
using ERP_FISCAL.Repositories.ExportaDadosBigRepositories;
using ERP_FISCAL.view.UIComponentes.UIRetornoEmTabela;
using ERP_FISCAL.view.UIComponentes.UIStatusDoProcessos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view
{
    public partial class ExportaDadosBig : Form
    {
        public ExportaDadosBig()
        {
            InitializeComponent();
            cbConferida.Items.Add("Sim");
            cbConferida.Items.Add("Não");
            cbConferida.Items.Add("Todos");
            cbConferida.SelectedIndex = 2;
            txtNumeroNota.Enabled = false;
        }

        public async Task<DataTable> BuscaDataTable(DateTime dataInicio, DateTime dataFim, int filial, char verificaConferida)
        {
            ExportaDadosBigController exportaDadosBigController = new ExportaDadosBigController();
            DataTable retorno = await exportaDadosBigController.BuscaNotasDoBigNaoEncontradoNaTotvs(dataInicio, dataFim, filial, verificaConferida);

            return retorno;
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtFilial.Text == "")
            {
                MessageBox.Show("O campo filial é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusProcess splashScreen = new StatusProcess();
            splashScreen.Show(this); // 'this' como owner para ficar modal
            splashScreen.SetMessage("Carregando...");
            splashScreen.UpdateProgress(70);
            if (dtPickerInicio.Value > dtPickerFinal.Value)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string verifacaConferida =
                cbConferida.SelectedItem.ToString() == "Sim" ? "S" :
                cbConferida.SelectedItem.ToString() == "Não" ? "N" :
                cbConferida.SelectedItem.ToString() == "Todos" ? "T" : "T";
            string filial = txtFilial.Text == "" ? null : txtFilial.Text;
            DataTable dataRetorno = await BuscaDataTable(dtPickerInicio.Value, dtPickerFinal.Value, Convert.ToInt32(filial), Convert.ToChar(verifacaConferida));
            CarregaDataTable(dataRetorno);
            splashScreen.Close();

            txtCount.Text = dtNotasImportadas.Rows.Count.ToString();


        }
        public void CarregaDataTable(DataTable data)
        {
            if (!data.Columns.Contains("Selecionar"))
            {
                DataColumn colCheck = new DataColumn("Selecionar", typeof(bool));
                colCheck.DefaultValue = false;
                data.Columns.Add(colCheck);
            }


            dtNotasImportadas.DataSource = data;
            dtNotasImportadas.Columns["Selecionar"].DisplayIndex = 0;
            dtNotasImportadas.Columns["Selecionar"].HeaderText = "✓";
            dtNotasImportadas.Columns["Selecionar"].Width = 30;
            dtNotasImportadas.Columns["Selecionar"].Width = 30;

            if (data.Rows.Count > 0)
            {
                txtNumeroNota.Enabled = true;
            }
            else
            {
                txtNumeroNota.Enabled = false;
            }
        }

        private async void btn_Click(object sender, EventArgs e)
        {
            //NotasController exportServiceNotes = new NotasController();
            var dtOriginal = (DataTable)dtNotasImportadas.DataSource;
            var linhasSelecionadas = dtOriginal.AsEnumerable()
                .Where(r => r.Field<bool>("Selecionar"))
                .ToList();

            string[] valorNumeroNota = linhasSelecionadas.Select(r => r.ItemArray[5].ToString() ?? string.Empty).ToArray();
            DateTime dataInicio = dtPickerInicio.Value;
            DateTime dataFim = dtPickerFinal.Value;
            int filial = Convert.ToInt32(txtFilial.Text);
            int substituir = chkSubstituir.Checked ? 1 : 0;
            int conferida = chkNaoConferida.Checked ? 1 : 0;

            StatusProcess splashScreen = new StatusProcess();
            splashScreen.Show(this);
            splashScreen.SetMessage("Importando notas...");
            splashScreen.UpdateProgress(70);
            ExportaDadosBigController exportaDadosBigController = new ExportaDadosBigController();
            RetornoExportaBigRepository retornoExportaBigRepository = new RetornoExportaBigRepository();
            retornoExportaBigRepository = await exportaDadosBigController.ImportaNotaBigParaTotvs(valorNumeroNota, dataInicio, dataFim, substituir, conferida, filial);

            MessageBox.Show(retornoExportaBigRepository.MensagemRetorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            splashScreen.Close();

            foreach (DataGridViewRow row in dtNotasImportadas.SelectedRows)
            {
                row.DefaultCellStyle.BackColor = Color.LightYellow;

            }

            using (RetornoEmTabela retornoEmTabela = new RetornoEmTabela(retornoExportaBigRepository.DtRetorno))
            {
                var resultado = retornoEmTabela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    // O usuário clicou no botão "OK" (ou equivalente)
                    dtNotasImportadas.Refresh();
                }
                else
                {
                    dtNotasImportadas.Refresh();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumeroNota.Text == "")
            {
                (dtNotasImportadas.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dtNotasImportadas.DataSource as DataTable).DefaultView.RowFilter = "[Nro. NF] =" + txtNumeroNota.Text;
            }
        }

        private void dtNotasImportadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora cliques no header

            // Remove a seleção de todas as linhas
            dtNotasImportadas.ClearSelection();

            // Destaca a linha clicada
            dtNotasImportadas.Rows[e.RowIndex].Selected = true;

            // Opcional: Define cores personalizadas para a linha selecionada
            dtNotasImportadas.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dtNotasImportadas.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtNotasImportadas.Rows)
            {
                row.Cells["Selecionar"].Value = true;
            }
        }

        private void chkSelecionado_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSelecionado.Checked)
            {
                (dtNotasImportadas.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dtNotasImportadas.DataSource as DataTable).DefaultView.RowFilter = "[Selecionar] =" + true;
            }
        }
    }
}
