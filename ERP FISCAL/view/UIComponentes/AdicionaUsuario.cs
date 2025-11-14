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

namespace ERP_FISCAL.view.UIComponentes
{
    public partial class AdicionaUsuario : Form
    {
        public AdicionaUsuario()
        {
            InitializeComponent();
            CarregaCbListaPerfil();

        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            string usuario = txtNomeUsuario.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Por favor, insira um nome de usuário válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cbListaPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, Selecione um perfil.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool retorno = await ValidaUsuario(usuario);
            if(retorno)
            {
                int idSelecionado = Convert.ToInt32(cbListaPerfil.SelectedValue);

                SegCadastroController segCadastroController = new SegCadastroController();
                DataTable usuarioNovo = await segCadastroController.InseriUsuario(usuario,idSelecionado);


                MessageBox.Show("Usuário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }
        // Corrigido: O tipo de retorno de um método assíncrono deve ser Task ou Task<T>
        private async Task<bool> ValidaUsuario(string usuario)
        {
            SegCadastroController segCadastroController = new SegCadastroController();
            DataTable retorno = await segCadastroController.ConsultaUnicoUsuario(usuario);

            retorno.Rows.Count.ToString();
            if (retorno.Rows.Count > 0)
            {
                MessageBox.Show("Usuário já existe. Por favor, escolha outro nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno.Rows.Count == 0;
        }
        private async void CarregaCbListaPerfil()
        {
            SegCadastroController segCadastroController = new SegCadastroController();
            DataTable retorno = await segCadastroController.ListaDados("%", 2);
            cbListaPerfil.DisplayMember = "NomePerfil";       // O que aparece para o usuário
            cbListaPerfil.ValueMember = "IDUsuarioPerfil";    // O que você guarda
            cbListaPerfil.DataSource = retorno;
            
        }
    }
}
