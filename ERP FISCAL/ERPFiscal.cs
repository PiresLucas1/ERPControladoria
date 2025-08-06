using SeuProjeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERP_FISCAL
{
    public partial class ERPFiscal : Form
    {
        public ERPFiscal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DtPickerInicio.Format = DateTimePickerFormat.Custom;
            DtPickerInicio.CustomFormat = "dd/MM/yyyy";
            DtPickerFim.Format = DateTimePickerFormat.Custom;
            DtPickerFim.CustomFormat = "dd/MM/yyyy";

            btnListaNotas.FlatStyle = FlatStyle.Flat;
            btnListaNotas.BackColor = Color.SteelBlue;
            btnListaNotas.ForeColor = Color.White;
            btnListaNotas.FlatAppearance.BorderSize = 0;
            btnListaNotas.AutoSize = true;

            btnSelecionarTodas.FlatStyle = FlatStyle.Flat;
            btnSelecionarTodas.BackColor = Color.SteelBlue;
            btnSelecionarTodas.ForeColor = Color.White;
            btnSelecionarTodas.FlatAppearance.BorderSize = 0;
            btnSelecionarTodas.AutoSize = true;

            btnDesmarcarTodos.FlatStyle = FlatStyle.Flat;
            btnDesmarcarTodos.BackColor = Color.SteelBlue;
            btnDesmarcarTodos.ForeColor = Color.White;
            btnDesmarcarTodos.FlatAppearance.BorderSize = 0;
            btnDesmarcarTodos.AutoSize = true;

            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.BackColor = Color.SteelBlue;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.AutoSize = true;

            btnExportarTotvs.FlatStyle = FlatStyle.Flat;
            btnExportarTotvs.BackColor = Color.SteelBlue;
            btnExportarTotvs.ForeColor = Color.White;
            btnExportarTotvs.FlatAppearance.BorderSize = 0;
            btnExportarTotvs.AutoSize = true;

        }

        private async void btnListaNotas_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dataInicio = DtPickerInicio.Value.Date;
                DateTime dataFim = DtPickerFim.Value.Date;

                lblStatus.Text = "Carregando notas...";
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.Visible = true;

                // Executa em outra thread sem travar a UI
                DataTable notas = await Task.Run(() =>
                {
                    Carregar_Colunas util = new Carregar_Colunas();
                    return util.ObterNotas(dataInicio, dataFim);
                });

               

                dtImportacao.RowHeadersWidth = 20; 
                dtImportacao.EnableHeadersVisualStyles = false;
                dtImportacao.RowHeadersDefaultCellStyle.BackColor = Color.White;
                dtImportacao.RowHeadersDefaultCellStyle.ForeColor = Color.White;

                dtImportacao.DataSource = notas;
                dtImportacao.AllowUserToAddRows = false;
                dtImportacao.ReadOnly = false;

                if (!dtImportacao.Columns.Contains("CFOP"))
                {
                    int index = dtImportacao.Columns["Cód. Serviço TOTVS"].Index;

                    var cfopColuna = new DataGridViewTextBoxColumn();
                    cfopColuna.Name = "CFOP";
                    cfopColuna.HeaderText = "CFOP";
                    cfopColuna.ReadOnly = false;
                    cfopColuna.Width = 60;

                    dtImportacao.Columns.Insert(index + 1, cfopColuna);
                }

                if (!dtImportacao.Columns.Contains("IDMov"))
                {
                    dtImportacao.Columns.Add("IDMov", "IDMov");
                    dtImportacao.Columns["IDMov"].ReadOnly = true;
                }

                if (!dtImportacao.Columns.Contains("Retorno"))
                {
                    dtImportacao.Columns.Add("Retorno", "Retorno");
                    dtImportacao.Columns["Retorno"].ReadOnly = true;
                }

                dtImportacao.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                dtImportacao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dtImportacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dtImportacao.ColumnHeadersHeight = 30;

                dtImportacao.DefaultCellStyle.SelectionBackColor = dtImportacao.DefaultCellStyle.BackColor;
                dtImportacao.DefaultCellStyle.SelectionForeColor = dtImportacao.DefaultCellStyle.ForeColor;

                if (!notas.Columns.Contains("Selecionar"))
                {
                    DataColumn colCheck = new DataColumn("Selecionar", typeof(bool));
                    colCheck.DefaultValue = false;
                    notas.Columns.Add(colCheck);
                }
                lblStatus.Text = $"Notas carregadas: {notas.Rows.Count}";

                dtImportacao.Columns["Selecionar"].DisplayIndex = 0;
                dtImportacao.Columns["Selecionar"].HeaderText = "✓";
                dtImportacao.Columns["Selecionar"].Width = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar notas: " + ex.Message);
                lblStatus.Text = "Erro ao carregar.";
            }
            finally
            {
                progressBar1.Visible = false;
            }
        }

        private void btnSelecionarTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtImportacao.Rows)
            {
                row.Cells["Selecionar"].Value = true;
            }
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtImportacao.Rows)
            {
                row.Cells["Selecionar"].Value = false;
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            DtPickerInicio.Value = DateTime.Today;
            DtPickerFim.Value = DateTime.Today;

            // Limpa status
            lblStatus.Text = "";

            // Limpa a grid
            dtImportacao.DataSource = null;

            // Remove a coluna CFOP se existir
            if (dtImportacao.Columns.Contains("CFOP"))
                dtImportacao.Columns.Remove("CFOP");

            // Desmarca todos os checkboxes (se ainda houver dados na grid)
            foreach (DataGridViewRow row in dtImportacao.Rows)
            {
                if (row.Cells["Selecionado"] is DataGridViewCheckBoxCell chk)
                    chk.Value = false;
            }
        }

        private void btnExportarTotvs_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoBancoDeDadosTOTVS conexaoBanco = new ConexaoBancoDeDadosTOTVS();

                using (SqlConnection conexao = conexaoBanco.AbrirConexao())
                {
                    foreach (DataGridViewRow row in dtImportacao.Rows)
                    {
                        if (row.IsNewRow)
                            continue;

                        // Verifica se a linha está marcada
                        bool selecionado = Convert.ToBoolean(row.Cells["Selecionar"].Value);
                        if (!selecionado)
                            continue;

                        using (SqlCommand cmd = new SqlCommand("uspImportaNotaServico", conexao))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Parâmetros de entrada
                            cmd.Parameters.AddWithValue("@INvchCPFCNPJPrestador", row.Cells["CNPJ Prestador"].Value?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchCPFCNPJTomador", row.Cells["CNPJ Tomador"].Value?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchNumeroDocumento", row.Cells["Documento"].Value?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INdatDataEmissao", Convert.ToDateTime(row.Cells["Dt.Hora Emissão"].Value));
                            cmd.Parameters.AddWithValue("@INdatDataLancamento", DateTime.Now);
                            cmd.Parameters.AddWithValue("@INvchDiscriminacaoServico", row.Cells["Descriminação"].Value?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchCodigoVerificacao", row.Cells["Código Verificação"].Value?.ToString() ?? "");

                            cmd.Parameters.AddWithValue("@INnumValorServico", Convert.ToDecimal(row.Cells["Total Serviços"].Value));
                            cmd.Parameters.AddWithValue("@INnumValorBrutoServico", Convert.ToDecimal(row.Cells["Valor Líquido"].Value));
                            cmd.Parameters.AddWithValue("@INnumISSBaseCalculo", Convert.ToDecimal(row.Cells["Base Cálculo"].Value));
                            cmd.Parameters.AddWithValue("@INnumISSValor", Convert.ToDecimal(row.Cells["Valor ISS"].Value));
                            cmd.Parameters.AddWithValue("@INnumPISValor", Convert.ToDecimal(row.Cells["Valor Pis"].Value));
                            cmd.Parameters.AddWithValue("@INnumCOFINSValor", Convert.ToDecimal(row.Cells["Valor Cofins"].Value));
                            cmd.Parameters.AddWithValue("@INnumCSLLValor", Convert.ToDecimal(row.Cells["Valor Csll"].Value));
                            cmd.Parameters.AddWithValue("@INnumIRRFValor", Convert.ToDecimal(row.Cells["Valor IR"].Value));
                            cmd.Parameters.AddWithValue("@INnumINSSValor", Convert.ToDecimal(row.Cells["Valor INSS"].Value));

                            cmd.Parameters.AddWithValue("@INvchCodProduto", row.Cells["Cód. Serviço TOTVS"].Value?.ToString() ?? "");

                            cmd.Parameters.AddWithValue("@INvchCFOP", row.Cells["CFOP"].Value?.ToString() ?? "");

                            // Parâmetros de saída
                            var msgRetorno = new SqlParameter("@OUTvchMsgRetorno", SqlDbType.VarChar, 1000)
                            {
                                Direction = ParameterDirection.Output
                            };

                            var idMov = new SqlParameter("@OUTintIDMOV", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };

                            cmd.Parameters.Add(msgRetorno);
                            cmd.Parameters.Add(idMov);

                            // Executa a procedure
                            cmd.ExecuteNonQuery();

                            // Atualiza as colunas de retorno no DataGridView
                            row.Cells["Retorno"].Value = msgRetorno.Value?.ToString();
                            row.Cells["IDMov"].Value = idMov.Value?.ToString();
                        }
                    }

                    MessageBox.Show("Importação concluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro durante a importação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtImportacao_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Apenas evita que a exceção estoure para o usuário
            e.Cancel = true;
        }
    }
}
