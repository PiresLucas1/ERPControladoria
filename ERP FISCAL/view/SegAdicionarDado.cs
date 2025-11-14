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
        
        public SegAdicionarDado(DataTable dt, string nomeCampo= "Nome Menu")
        {
            InitializeComponent();
            CarregaDados(dt);
            lblNome.Text = nomeCampo;

            if(nomeCampo == "Nome Perfil")
            {
                txtDescApp.Enabled = false;
            }
        }
        public void CarregaDados(DataTable dt)
        {
            dvgItens.DataSource = dt;
        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            SegCadastroController segCadastroController = new SegCadastroController();
            string DescrNome = txtNome.Text;
            if (lblNomeAplicacao.Text != "Nome Perfil")
            {
                await segCadastroController.InseriInformacao(DescrNome);

            }else
                DescrNome = txtNome.Text;
                string DescrApp = txtDescApp.Text;
                await segCadastroController.InseriInformacao(DescrNome, DescrApp);

            MessageBox.Show("Item adicionado com sucesso!");
        }
    }
}
