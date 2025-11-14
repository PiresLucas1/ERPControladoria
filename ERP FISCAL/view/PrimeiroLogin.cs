using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view
{
    public partial class PrimeiroLogin : Form
    {
        // Caminho onde o nome do usuário será salvo
        
        public string[] usuariosComPermissoesTotais = { "rudinei.cferreira", "lucas.pires", "aamaiello" };
        public PrimeiroLogin()
        {
            InitializeComponent();
            CarregarPerfil();
            pBarCarregaPerfil.Style = ProgressBarStyle.Marquee;
        }        
        public async void CarregarPerfil()
        {
            string usuario = Environment.UserName;
            await Task.Delay(800);

            if (usuariosComPermissoesTotais.Contains(usuario))
            {

                Portal portal = new Portal();
                portal.Show();
            }
            this.Hide();
        }


    }
}
