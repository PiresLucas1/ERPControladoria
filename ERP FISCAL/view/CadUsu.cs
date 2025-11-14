using ERP_FISCAL.Controller.SegCadastroController;
using ERP_FISCAL.view.UIComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization.Configuration;

namespace ERP_FISCAL.view
{
    public partial class CadUsu : Form
    {
        public CadUsu(DataTable dt)
        {
            InitializeComponent();
            object[] dataCbFiltro = { "Nome Usuário", "Perfil", "Menu"};
            cbFiltros.Items.AddRange(dataCbFiltro);
            cbFiltros.SelectedIndex = 1;
            txtMenu.Enabled = false;
            txtPerfil.Enabled = false;            
            CarregaDataGrid(dt);
        }

        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFiltros.SelectedIndex == 0)
            {
                ativaFiltro();
                txtNomeUsu.Enabled = true;
            }
            if (cbFiltros.SelectedIndex == 1)
            {
                ativaFiltro();
                txtPerfil.Enabled = true;
            }
            if (cbFiltros.SelectedIndex == 2)
            {
                ativaFiltro();
                txtMenu.Enabled = true;
            }
            return;
        }
        private void ativaFiltro()
        {
            foreach(Control obj in gpFiltro.Controls)
            {
                if(obj is TextBox)
                {
                    obj.Enabled = false;
                }
            }
        }

        private async  void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = "";
            DataTable retorno = new DataTable();
            
            if (txtNomeUsu.Enabled)           
              filtro = txtNomeUsu.Text;
            if (txtPerfil.Enabled)           
              filtro = txtPerfil.Text;
            if(txtMenu.Enabled)
              filtro = txtMenu.Text;

            
            SegCadastroController segCadastroController = new SegCadastroController();
            retorno = await segCadastroController.ListaDados(filtro, 1);
        }

        private async void btnAdicionarPerfil_Click(object sender, EventArgs e)
        {
            SegCadastroController segCadastroController = new SegCadastroController();
            DataTable retorno =  await segCadastroController.ListaDados("%",2);
    
            SegAdicionarDado seg = new SegAdicionarDado(retorno, "Nome Perfil");

            seg.ShowDialog();

        }

        private async void btnAdicionarMenu_Click(object sender, EventArgs e)
        {
            SegCadastroController segCadastroController = new SegCadastroController();
            DataTable retorno = await segCadastroController.ListaDados("%", 3);

            SegAdicionarDado seg = new SegAdicionarDado(retorno);

            seg.ShowDialog();
        }

        private void CarregaDataGrid(DataTable dt)
        {
            dvgUsuarios.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdicionaUsuario adicionaUsuario = new AdicionaUsuario();
            adicionaUsuario.ShowDialog();
        }
    }
}
