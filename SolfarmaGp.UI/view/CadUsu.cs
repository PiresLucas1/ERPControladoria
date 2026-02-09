using DocumentFormat.OpenXml.Drawing.Charts;
using ERP_FISCAL.Controller.SegCadastroController;
using ERP_FISCAL.view.UIComponentes;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;


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
    
            SegAdicionarDado seg = new SegAdicionarDado(retorno, 2,"Nome Perfil");

            seg.ShowDialog();

        }

        public static async Task<DataTable> ListaInformacao(string parametro, int tipoPesquisa)
        {
            SegCadastroController segCadastroController = new SegCadastroController();
            if (tipoPesquisa == 2)
            {
                DataTable retorno = await segCadastroController.ListaDados("%", 2);
                return retorno;
            }
            if(tipoPesquisa == 3)
            {
                DataTable retorno = await segCadastroController.ListaDados("%", 3);
                return retorno;
            }
            return null;
        }

        private async void btnAdicionarMenu_Click(object sender, EventArgs e)
        {
            SegCadastroController segCadastroController = new SegCadastroController();
            DataTable retorno = await segCadastroController.ListaDados("%", 3);

            SegAdicionarDado seg = new SegAdicionarDado(retorno, 1);

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
