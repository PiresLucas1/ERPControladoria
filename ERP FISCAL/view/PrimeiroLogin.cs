using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ERP_FISCAL.view
{
    public partial class PrimeiroLogin : Form
    {
        // Caminho onde o nome do usuário será salvo
        private readonly string caminhoUsuario = Path.Combine(Application.StartupPath, "user.config");
        public string[] usuariosComPermissoesTotais = { "rudinei.cferreira", "lucas.pires", "aamaiello" };
        public PrimeiroLogin()
        {
            InitializeComponent();
        }

        // Evento do botão "Entrar"
        private void button1_Click(object sender, EventArgs e)
        {
            // Supondo que você tenha um TextBox chamado "txtUsuario"
            string usuario = txtUsu.Text.Trim();

            // Verifica se o usuário digitou algo
            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor, digite seu nome de usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (usuariosComPermissoesTotais.Contains(txtUsu.Text))
            {
                Portal formPrincipal = new Portal();
                formPrincipal.Show();                
                this.Hide();
            }
            //else { 
            //    try
            //    {
            //        // Salva o nome do usuário no arquivo user.config
            //        File.WriteAllText(caminhoUsuario, usuario);

            //        // Abre a tela principal (você pode trocar o nome do form aqui)
            //        Portal formPrincipal = new Portal(usuario);
            //        formPrincipal.Show();

            //        // Fecha a tela de login
            //        this.Hide();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Erro ao salvar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
    }
}
