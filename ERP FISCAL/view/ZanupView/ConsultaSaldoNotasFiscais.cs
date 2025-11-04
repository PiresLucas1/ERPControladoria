using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using ERP_FISCAL.Controller;
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
using System.Windows;
using System.Windows.Forms;
using Color = System.Drawing.Color;


namespace ERP_FISCAL.view
{

    public partial class ConsultaSaldoNotasFiscais : Form
    {
        public DataGridViewRow cellAlteracao;
        public int colAlteracao;
        public System.Data.DataTable dataItensSelecionados = new System.Data.DataTable();
        public System.Data.DataTable dataItensPesquisado = new System.Data.DataTable();
        public ConsultaSaldoNotasFiscais()
        {
            InitializeComponent();
            cbFiltroSaldo.Items.Add("IDProduto");
            cbFiltroSaldo.Items.Add("Num.doc");
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            int ValorFiltro;

            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MessageBox.Show("Preencha o campo!",
                                "Campo obrigatório",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if ((!int.TryParse(txtFiltro.Text, out ValorFiltro)))
            {
                MessageBox.Show("Digite apenas números!",
                                "Entrada inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            StatusProcess splashScreen = new StatusProcess();
            splashScreen.Show(this); // 'this' como owner para ficar modal
            splashScreen.SetMessage("Carregando...");
            splashScreen.UpdateProgress(70);
            btnListaNotas.Enabled = false;
            btnListaNotas.Enabled = false;
            try
            {
                ConsultaSaldoNotasZanupController consultaSaldoNotasZanup = new ConsultaSaldoNotasZanupController();

                System.Data.DataTable retorno = new System.Data.DataTable();

                if (cbFiltroSaldo.SelectedIndex == 0)
                {
                    retorno = await consultaSaldoNotasZanup.ConsultaSaldoNotas(ValorFiltro, 0);

                }
                else
                {
                    retorno = await consultaSaldoNotasZanup.ConsultaSaldoNotas(0,ValorFiltro);
                }


                if (dataItensSelecionados.Columns.Count <= 0)
                   
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

            splashScreen.Close();
            btnListaNotas.Enabled = true;

        }
        public void CarregaDataTable(System.Data.DataTable data)
        {
            if (!data.Columns.Contains("Qtd para Devolver"))
            {
                DataColumn colQuantidade = new DataColumn("Qtd para Devolver", typeof(int));
                colQuantidade.DefaultValue = 0;
                data.Columns.Add(colQuantidade);

            }
            dvgConsultaNotas.DataSource = data;


            dvgConsultaNotas.Columns["Qtd para Devolver"].DisplayIndex = 0;
            dvgConsultaNotas.Columns["Qtd para Devolver"].Width = 30;
            dvgConsultaNotas.Columns["Qtd para Devolver"].Width = 30;
            dvgConsultaNotas.Columns["Qtd para Devolver"].DefaultCellStyle.ForeColor = Color.Red;

            dvgConsultaNotas.RowHeadersVisible = false;


        }

        private void dvgConsultaNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return; // Ignora cliques no header
            // Remove a seleção de todas as linhas
            dvgConsultaNotas.ClearSelection();
            // Destaca a linha clicada
            dvgConsultaNotas.Rows[e.RowIndex].Selected = true;


            // Opcional: Define cores personalizadas para a linha selecionada
            dvgConsultaNotas.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dvgConsultaNotas.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;



        }

        public async Task CriarNotaFiscal()
        {
            var dtOriginal = (System.Data.DataTable)dvgItensSelecionados.DataSource;

            var linhasSelecionadas = dtOriginal.AsEnumerable()
                .ToList();



            StatusProcess splashScreen = new StatusProcess();

            splashScreen.Show(this); // 'this' como owner para ficar modal
            splashScreen.SetMessage("Gerando nota fical no bling...");

            DataRowToObject dataRowToObject = new DataRowToObject();
            await dataRowToObject.TranformaDataRowToObject(linhasSelecionadas);
            btGerarNotaFiscal.Enabled = false;

            splashScreen.Close();
            btGerarNotaFiscal.Enabled = true;
        }

        private async void btGerarNotaFiscal_Click(object sender, EventArgs e)
        {
            if (dataItensSelecionados.Rows.Count <= 0)
            {
                return;
            }
            await CriarNotaFiscal();
        }

        public void ImportaItemParaDvgItensSelecionado(List<DataRow> linhasSelecionadas)
        {
            var dtOriginal = (System.Data.DataTable)dvgConsultaNotas.DataSource;
            dataItensSelecionados = dtOriginal.Clone();
            foreach (var linha in linhasSelecionadas)
            {
                dataItensSelecionados.ImportRow(linha);
                int index = dtOriginal.Rows.IndexOf(linha);

                dvgConsultaNotas.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            MessageBox.Show("Itens importados com sucesso!");

        }

        private void tabNavegacaoAba_Selected(object sender, TabControlEventArgs e)
        {
            if (tabNavegacaoAba.SelectedTab == tabItensSelecionado)
            {
                if(dataItensSelecionados.Rows.Count > 0)
                {

                    dvgItensSelecionados.DataSource = dataItensSelecionados;
                    dvgItensSelecionados.Columns["Qtd para Devolver"].DisplayIndex = 0;
                    dvgItensSelecionados.Columns["Qtd para Devolver"].DefaultCellStyle.ForeColor = Color.Red;
                }

                return;


            }
        }

        private void btnRelacionaItens_Click(object sender, EventArgs e)
        {
            if (dvgConsultaNotas.RowCount > 0)
            {

                var dtOriginal = (System.Data.DataTable)dvgConsultaNotas.DataSource;
                if(!dtOriginal.Columns.Contains("Qtd para Devolver"))
                {
                    DataColumn colQuantidade = new DataColumn("Qtd para Devolver", typeof(int));
                    colQuantidade.DefaultValue = 0;
                    dtOriginal.Columns.Add(colQuantidade);

                }

                var linhasSelecionadas = dtOriginal.AsEnumerable()
                    .Where(r => r.Field<int>("Qtd para Devolver") != 0)
                    .ToList();

                bool existeCelulaVaiza = false;
                bool existeValorIncorreto = false;
                foreach (DataRow row in linhasSelecionadas)
                {
                    string qtd = row["Qtd para Devolver"]?.ToString();
                    if (string.IsNullOrWhiteSpace(qtd) || Convert.ToInt32(qtd) == 0 )
                    {
                        int index = dtOriginal.Rows.IndexOf(row);
                        dvgConsultaNotas.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
                        existeCelulaVaiza = true;
                    }
                    if(Convert.ToUInt32(qtd) > Convert.ToInt32(row["Saldo Restante"].ToString()))
                    {
                        int index = dtOriginal.Rows.IndexOf(row);
                        dvgConsultaNotas.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
                        existeValorIncorreto = true;
                    }
                }
                if (existeValorIncorreto)
                {
                    MessageBox.Show("Existe algumas linhas que o valor de devolução esta incorreto");
                    return;
                }
                if (existeCelulaVaiza)
                {
                    MessageBox.Show("Existe algumas linhas que o valor de devolução não foi informado");
                    return;
                }

                if (linhasSelecionadas.Count > 0)
                    ImportaItemParaDvgItensSelecionado(linhasSelecionadas);
                else
                    MessageBox.Show("Nenhum item selecionado");

            }
            else
                MessageBox.Show("Nenhum item para importar!");
        }

        private void dvgConsultaNotas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {

                textBox.PreviewKeyDown -= TextBox_PreviewKeyDown;
                textBox.PreviewKeyDown += TextBox_PreviewKeyDown;


                cellAlteracao = dvgConsultaNotas.CurrentRow;
                colAlteracao = dvgConsultaNotas.CurrentCell.ColumnIndex;
            }
        }
        private void TextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var cellParaTextBox = sender as TextBox;

                var valorSaldoRestante = cellAlteracao.Cells["Saldo Restante"].Value.ToString();
                int saldoRestante = Convert.ToInt32(valorSaldoRestante);
                int valorDevolvido = Convert.ToInt32(cellParaTextBox.Text);
                if (valorDevolvido >saldoRestante )
                {
                    MessageBox.Show("Valor de Devolução não pode ser maior que o valor de Saldo Restante");
                    cellAlteracao.Cells["Qtd para Devolver"].Value = "";
                    return;
                }



            }
        }

        /* EVENTO DA TABELA DE SELECIONADOS */
        private void dvgItensSelecionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabNavegacaoAba.SelectedTab == tabItensSelecionado)
            {
                if(dataItensSelecionados.Rows.Count <= 0)
                {
                    return;
                }
                DialogResult retorno = MessageBox.Show("Deseja excluir este item da relação", "Aviso",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (retorno == DialogResult.OK)
                {
                    dataItensSelecionados.Rows.RemoveAt(e.RowIndex);
                    dvgItensSelecionados.DataSource = dataItensSelecionados;
                }

            }
        }
        private void dvgItensSelecionados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgItensSelecionados.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSalmon;
            dvgItensSelecionados.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;

        }

        private void cbFiltroSaldo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFiltroSaldo.SelectedIndex == 0)
            {

            }
        }

    }
}
