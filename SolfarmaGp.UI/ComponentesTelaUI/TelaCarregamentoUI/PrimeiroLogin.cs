namespace PrimeiroLoginView
{
    public partial class PrimeiroLogin : Form
    {
        // Caminho onde o nome do usuário será salvo
        
        //public string[] usuariosComPermissoesTotais = { "rudinei.cferreira", "lucas.pires", "aamaiello" };
        public PrimeiroLogin()
        {
            InitializeComponent();            
            pBarCarregaPerfil.Style = ProgressBarStyle.Marquee;
        }        
    }
}
