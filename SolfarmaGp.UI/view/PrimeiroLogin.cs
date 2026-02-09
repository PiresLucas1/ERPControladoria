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
            pBarCarregaPerfil.Style = ProgressBarStyle.Marquee;
        }        
    }
}
