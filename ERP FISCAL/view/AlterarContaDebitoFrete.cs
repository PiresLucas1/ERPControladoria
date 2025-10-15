using ERP_FISCAL.Controller.ContaDebitoFreteController;
using ERP_FISCAL.view.UIComponentes.UIDialog.UIAltetarEmBloco;
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
    public partial class AlterarContaDebitoFrete : Form
    {
        public AlterarContaDebitoFrete()
        {
            InitializeComponent();
            cbItensParaMostrar.Items.Add("Todos");
            cbItensParaMostrar.Items.Add("Apenas com divergência");

            cbTipoMovimento.Items.Add("1.2.61");
            cbTipoMovimento.Items.Add("1.2.62");
            cbTipoMovimento.Items.Add("Todos");

        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            var dataInicio = dateTimePickerInicio.Value;
            var dataFim = dateTimePickerFim.Value;

            if(dataInicio > dataFim)
            {
                MessageBox.Show("Período invalido!");
                return;
            }
            StatusProcess splashScreen = new StatusProcess();
            splashScreen.Show(this); 
            splashScreen.SetMessage("Carregando informações ...");
            splashScreen.UpdateProgress(40);
            AlteraContaDebitoController alteraContaDebitoController = new AlteraContaDebitoController();
            DataTable result = await alteraContaDebitoController.PesuisarNotas(dataInicio, dataFim);

            dtContabilizacaoFrete.DataSource = result;

            /*adicionando algumas configuraçõs no data grid*/
            dtContabilizacaoFrete.AllowUserToResizeColumns = true;
            dtContabilizacaoFrete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dtContabilizacaoFrete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtContabilizacaoFrete.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dtContabilizacaoFrete.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


            dtContabilizacaoFrete.DefaultCellStyle.SelectionBackColor = dtContabilizacaoFrete.DefaultCellStyle.BackColor;
            dtContabilizacaoFrete.DefaultCellStyle.SelectionForeColor = dtContabilizacaoFrete.DefaultCellStyle.ForeColor;

            if (!result.Columns.Contains("Selecionar"))
            {
                DataColumn colCheck = new DataColumn("Selecionar", typeof(bool));
                colCheck.DefaultValue = false;
                result.Columns.Add(colCheck);
            }

            if (!result.Columns.Contains("Selecionar"))
            {
                DataColumn colCheck = new DataColumn("Selecionar", typeof(bool));
                colCheck.DefaultValue = false;
                result.Columns.Add(colCheck);
            }

            dtContabilizacaoFrete.Columns["Selecionar"].DisplayIndex = 0;
            dtContabilizacaoFrete.Columns["Selecionar"].HeaderText = "✓";
            dtContabilizacaoFrete.Columns["Selecionar"].Width = 30;
            dtContabilizacaoFrete.Columns["Selecionar"].Width = 30;

            splashScreen.SetMessage("Finalizando...");
            splashScreen.UpdateProgress(100);
            splashScreen.Close();



        }

        private void cbItensParaMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbItensParaMostrar.SelectedItem.ToString() == "Todos")
            {
                (dtContabilizacaoFrete.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dtContabilizacaoFrete.DataSource as DataTable).DefaultView.RowFilter = "[Situação] = 'CORRIGIR'";
            }
        }

        private void dtContabilizacaoFrete_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var grid = sender as DataGridView;

            // Garante que a linha é válida
            if (e.RowIndex >= 0)
            {
                // Pega a linha atual
                var row = grid.Rows[e.RowIndex];

                // Verifica se a célula "Situação" existe e não é nula
                if (row.Cells["Situação"].Value != null)
                {
                    string situacao = row.Cells["Situação"].Value.ToString();

                    // Se for "Corrigir", pinta a linha de vermelho
                    if (situacao.Equals("CORRIGIR", StringComparison.OrdinalIgnoreCase))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 250, 200) ;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        // Mantém as cores padrão
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void dtContabilizacaoFrete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora cliques no header

            // Remove a seleção de todas as linhas
            dtContabilizacaoFrete.ClearSelection();

            // Destaca a linha clicada
            dtContabilizacaoFrete.Rows[e.RowIndex].Selected = true;

            // Opcional: Define cores personalizadas para a linha selecionada
            dtContabilizacaoFrete.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dtContabilizacaoFrete.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void btnAlterarEmBloco_Click(object sender, EventArgs e)
        {
            DTOAlteraEmBloco dto = new DTOAlteraEmBloco
            {
                TextLabel1 = "Conta Débito "
            };

            // Passa também o DataGridView atual
            AlteraEmBloco alterarEmBloco = new AlteraEmBloco(dto, dtContabilizacaoFrete);
            alterarEmBloco.ShowDialog();
        }
        private void SelecionarTodos(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtContabilizacaoFrete.Rows)
            {
                row.Cells["Selecionar"].Value = true;
            }
        }
        private void DesmarcarTodos()
        {
            foreach (DataGridViewRow row in dtContabilizacaoFrete.Rows)
            {
                row.Cells["Selecionar"].Value = false;
            }
        }
        private void SelecionarCelulasComDivergencia()
        {
            foreach (DataGridViewRow row in dtContabilizacaoFrete.Rows)
            {
                string situacao = row.Cells["Situação"].Value.ToString();

                if (situacao.Equals("CORRIGIR", StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["Selecionar"].Value = true;
                }
            }
        }

        private void cbSelecionaItensComDivergencia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelecionaItensComDivergencia.Checked)
                SelecionarCelulasComDivergencia();
            else
                DesmarcarTodos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoMovimento.SelectedItem.ToString() == "1.2.61")
            {
                (dtContabilizacaoFrete.DataSource as DataTable).DefaultView.RowFilter = "[Cod. TMV] = '1.2.61'";
            }
            else if(cbTipoMovimento.SelectedItem.ToString() == "1.2.61")
            {
                (dtContabilizacaoFrete.DataSource as DataTable).DefaultView.RowFilter = "[Cod. TMV] = '1.2.62'";
            }
            else
            {
                (dtContabilizacaoFrete.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }
    }
}
