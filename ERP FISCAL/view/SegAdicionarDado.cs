using ERP_FISCAL.Controller.SegCadastroController;
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
    public partial class SegAdicionarDado : Form
    {
        public int tipoForm;
        public DataTable data = new DataTable();
        public SegAdicionarDado(DataTable dt, int tipoForm, string nomeCampo= "Nome Menu")
        {
            /*
             * tipo form 
             * 1 = Menu = 3
             * 2 = Perfil = 2
             */
            InitializeComponent();
            CarregaDados(dt);
            lblNome.Text = nomeCampo;
            this.tipoForm = tipoForm;
            this.data = dt;

            if (nomeCampo == "Nome Perfil")
            {
                txtDescApp.Enabled = false;
            }
        }
        public void CarregaDados(DataTable dt)
        {
            data = dt;
            dvgItens.DataSource = data;
        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            SegCadastroController segCadastroController = new SegCadastroController();
            int apoioTipoPesquisa = 0;            
            string DescrNome = txtNome.Text;
            if (tipoForm != 1)
            {
                await segCadastroController.InseriInformacao(DescrNome);
                apoioTipoPesquisa = 2;
            }
            else
            {
                DescrNome = txtNome.Text;
                string DescrApp = txtDescApp.Text;
                await segCadastroController.InseriInformacao(DescrNome, DescrApp);
                apoioTipoPesquisa = 3;

            }

            MessageBox.Show("Item adicionado com sucesso!");
            DataTable retorno = await CadUsu.ListaInformacao("%", apoioTipoPesquisa);
            AtualizaInformacao(retorno);
        }
        private void AtualizaInformacao(DataTable newData)
        {
            data = newData;
            dvgItens.DataSource = data;


        }
    }
}
