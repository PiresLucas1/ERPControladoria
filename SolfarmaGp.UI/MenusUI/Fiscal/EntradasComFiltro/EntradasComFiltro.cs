using Microsoft.IdentityModel.Tokens;
using SolfarmaGp.Controllers.UseCase.Fiscal.BuscaEntradasComFiltroUseCase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;


namespace SolfarmaGp.UI.MenusUI.Fiscal.EntradasComFiltro
{
    public partial class BuscaEntradasComFiltro : Form
    {
        private DataTable dtResultado;
        public BuscaEntradasComFiltro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbDtFim_Click(object sender, EventArgs e)
        {

        }

        private async void btPesquisar_Click(object sender, EventArgs e)
        {

            try
            {


                DateTime dataInicio = dtDataInicio.Value.Date;
                DateTime dataFim = dtDataFim.Value.Date;

                int coligada = int.Parse(txtBxColigada.Text);
                int filial = string.IsNullOrWhiteSpace(txtBxFilial.Text) ? 0 : int.Parse(txtBxFilial.Text);

                string tipoMovimento;

                if (chBxEntrada.Checked && !chBxSaida.Checked)
                {
                    tipoMovimento = "E";
                }
                else if (!chBxEntrada.Checked && chBxSaida.Checked)
                {
                    tipoMovimento = "S";
                }
                else if (chBxEntrada.Checked && chBxSaida.Checked)
                {
                    tipoMovimento = "E,S"; // Entrada + Saída
                }
                else
                {
                    MessageBox.Show(
                        "Selecione Entrada ou Saída.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            

                BuscaEntradasComFiltroUseCase useCase = new BuscaEntradasComFiltroUseCase();

                dtResultado = await useCase.Execute(
                    dataInicio,
                    dataFim,
                    coligada,
                    filial,
                    tipoMovimento
                );
                MessageBox.Show($"Linhas retornadas: {dtResultado.Rows.Count}");

                dtEntradasComFiltro.DataSource = dtResultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtResultado == null || dtResultado.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Não existem dados para exportar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                SaveFileDialog salvar = new SaveFileDialog
                {
                    Filter = "Arquivo TXT (*.txt)|*.txt",
                    Title = "Salvar arquivo TXT",
                    FileName = "Entradas.txt"
                };

                if (salvar.ShowDialog() != DialogResult.OK)
                    return;

                using (StreamWriter writer = new StreamWriter(
                    salvar.FileName,
                    false,
                    System.Text.Encoding.UTF8))
                {
                    // CABEÇALHO
                    string cabecalho = string.Join(
                        "|",
                        dtResultado.Columns
                            .Cast<DataColumn>()
                            .Select(coluna => coluna.ColumnName)
                    );

                    writer.WriteLine(cabecalho);

                    // DADOS
                    foreach (DataRow row in dtResultado.Rows)
                    {
                        string linha = string.Join(
                             "|",
                             row.ItemArray.Select(valor =>
                                 valor is DateTime data
                                     ? data.ToString("dd/MM/yyyy")
                                     : valor?.ToString() ?? ""
                             )
                         );

                        writer.WriteLine(linha);
                    }
                }

                MessageBox.Show(
                    "Arquivo exportado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
