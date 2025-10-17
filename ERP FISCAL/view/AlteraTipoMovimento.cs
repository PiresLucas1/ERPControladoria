using ERP_FISCAL.Controller.AlteraTipoMovimentoController;
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
    public partial class AlteraTipoMovimento : Form
    {
        DataTable dataTableComModificacoes = new DataTable();
        int idmov;
        int idColigada;
        public AlteraTipoMovimento()
        {
            InitializeComponent();
        }

        private async void btnConsulta_Click(object sender, EventArgs e)
        {
            if (tbCodMovimento.Text == "" || tbColigada.Text == "")
            {
                MessageBox.Show("Você precisa inserir o número do movimento e a coligada");
                return;
            }
            int codMovimento = Convert.ToInt32(tbCodMovimento.Text);
            int coligada = tbColigada.Text == "" ? 0 : Convert.ToInt32(tbColigada.Text);
            AlterarTipoMovimentoController alterarTipoMovimento = new AlterarTipoMovimentoController();
            DataTable dataRetorno = await alterarTipoMovimento.ConsultaMovimentoTotvs(codMovimento, coligada);

            StatusProcess splashScreen = new StatusProcess();
            splashScreen.Show(this); // 'this' como owner para ficar modal
            splashScreen.SetMessage("Carregando...");
            splashScreen.UpdateProgress(70);

            CarregaDataTable(dataRetorno);
            splashScreen.Close();
        }
        public void CarregaDataTable(DataTable data)
        {
            if (!data.Columns.Contains("Selecionar"))
            {
                DataColumn colCheck = new DataColumn("Selecionar", typeof(bool));
                colCheck.DefaultValue = false;
                data.Columns.Add(colCheck);
            }

            if (dataTableComModificacoes.Columns.Count == 0)
            {
                dataTableComModificacoes = data.Clone(); // apenas esquema, sem dados
            }

            foreach (DataRow row in data.Rows)
            {
                // Checa se já existe uma linha com mesma coligada e codigo
                bool exists = dataTableComModificacoes.AsEnumerable().Any(r =>
                    object.Equals(r["CODCOLIGADA"], row["CODCOLIGADA"]) &&
                    object.Equals(r["IDMOV"], row["IDMOV"])
                );

                if (!exists)
                {
                    dataTableComModificacoes.ImportRow(row);
                }
            }


            dtAlteracoes.DataSource = dataTableComModificacoes;
            dtAlteracoes.Columns["Selecionar"].DisplayIndex = 0;
            dtAlteracoes.Columns["Selecionar"].HeaderText = "✓";
            dtAlteracoes.Columns["Selecionar"].Width = 30;
            dtAlteracoes.Columns["Selecionar"].Width = 30;
        }


        private async void btnAlterar_Click(object sender, EventArgs e)
        {

            var dtOriginal = (DataTable)dtAlteracoes.DataSource;
            var linhasSelecionadas = dtOriginal.AsEnumerable()
                .Where(r => r.Field<bool>("Selecionar"))
                .ToList();

            if (linhasSelecionadas.Count <= 0)
            {
                MessageBox.Show("Nenhum movimento selecionado para alteração.");
                return;
            }

            var primeiraLinha = linhasSelecionadas[0];
            var coligada = primeiraLinha["CODCOLIGADA"];
            var idmov = primeiraLinha["IDMOV"];

            StatusProcess splashScreen = new StatusProcess();

            splashScreen.Show(this); // 'this' como owner para ficar modal
            splashScreen.SetMessage("Alterando Tipo de Movimento...");

            AlterarTipoMovimentoController alteraTipoMovimento = new AlterarTipoMovimentoController();
            var resultado = await alteraTipoMovimento.AlterarTipoMovimento(Convert.ToInt32(idmov), Convert.ToInt32(coligada), tbCodTmv.Text);
            splashScreen.Close();


            MessageBox.Show(resultado);
            if (resultado != null && resultado.Trim().Equals("Tipo de Movimento alterado com sucesso!", StringComparison.OrdinalIgnoreCase))
            {
                bool jaExiste = dataTableComModificacoes.AsEnumerable().Any(r =>
                    Convert.ToInt32(r.Field<short>("CODCOLIGADA")) == Convert.ToInt32(coligada) &&
                     r.Field<int>("IDMOV") == Convert.ToInt32(idmov) 
                 );

                if (!jaExiste)
                {
                    // Adiciona uma nova linha copiando os valores desejados
                    DataRow novaLinha = dataTableComModificacoes.NewRow();
                    novaLinha["CODTMV"] = tbCodTmv.Text;

                    

                    dataTableComModificacoes.Rows.Add(novaLinha);
                    CarregaDataTable(dataTableComModificacoes);
                }
            }
            
            return;



        }

        private void dtAlteracoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora cliques no header

            // Remove a seleção de todas as linhas
            dtAlteracoes.ClearSelection();

            // Destaca a linha clicada
            dtAlteracoes.Rows[e.RowIndex].Selected = true;

            // Opcional: Define cores personalizadas para a linha selecionada
            dtAlteracoes.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dtAlteracoes.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
