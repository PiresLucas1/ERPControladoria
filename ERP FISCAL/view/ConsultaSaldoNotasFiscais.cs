using ERP_FISCAL.Controller.ConsultaSaldoNotasZanup;
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

                dtConsultaNotas.DataSource = retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado ao consultar notas: " + ex.Message,
                                "Erro no sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
    }
}
