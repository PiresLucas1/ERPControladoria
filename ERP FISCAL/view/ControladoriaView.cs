using DocumentFormat.OpenXml.Spreadsheet;
using ERP_FISCAL.Controller.SegCadastroController;
using ERP_FISCAL.Utils;
using ERP_FISCAL.view.ContabilView;
using ERP_FISCAL.view.FiscalView;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view
{
    public enum MenuTela
    {
        AlteracaoFiscal = 1,
        ImportacaoXML= 5,
        ExportarNotasBig = 8,
        AlteracaoMovimento = 10,
        DevolucaoNotas = 11,
        ImportarRecebimento = 13,
        CadUsuario = 15

    }
    public partial class Portal : Form
    {
        public string nomeUsuario = "";
        public int perfil = 0;
        public int contadorTheme = 0;
        public Portal()
        {
            InitializeComponent();

            this.Shown += Portal_Shown;           
            DesabilitaItemMenu(menuBarTop,"", false);
            this.nomeUsuario = Environment.UserName;

            // 🔹 Carrega a cor salva
            string corSalva = Properties.Settings.Default.CorCabecalho;
            if (!string.IsNullOrEmpty(corSalva))
            {
                System.Drawing.Color cor = ColorTranslator.FromHtml(corSalva);
                menuBarBottom.BackColor = cor;
                menuBarTop.BackColor = cor;
                txtVersao.BackColor = cor;
            }
            Version versaoAssembly = Assembly.GetExecutingAssembly().GetName().Version;
            //preenche footer com informações do sistema e usuário
            txtVersao.Text = $"Versão: {versaoAssembly}";
            txtNomeUsuario.Text = $"Usuário: {nomeUsuario}";

            
            AplicarFonte.AplicarFonteForm(this,new System.Drawing.Font(this.Font.FontFamily, Properties.Settings.Default.FonteTamanho));


        }
        private async void Portal_Shown(object sender, EventArgs e)
        {

            this.Shown -= Portal_Shown;

            PrimeiroLogin primeiroLogin = new PrimeiroLogin();
            primeiroLogin.StartPosition = FormStartPosition.CenterScreen;                
            primeiroLogin.Show();   // Aparece apenas uma vez

            await Task.Delay(2000); // Simula tempo de carregamento

            SegCadastroController segCadastroController = new SegCadastroController();
            var result = await segCadastroController.ConsultaUnicoUsuario(nomeUsuario);



            if (result == null || result.Rows.Count == 0)
            {
                primeiroLogin.Close();
                MessageBox.Show("Nenhum Usuário encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            string usuario = result.Rows[0]["NomeUsuario"].ToString();
            int idUsuarioPerfil = Convert.ToInt32(result.Rows[0]["IDUsuarioPerfil"]);
            perfil = idUsuarioPerfil;
            if (usuario == nomeUsuario && idUsuarioPerfil == 12)
            {
                DesabilitaItemMenu(menuBarTop, "", true);
            }
            if(usuario == nomeUsuario)
            {
                
                LiberaOpcoesDeAcordoComPermissoes(perfil);
            }

            
            // Fecha o splash!
            primeiroLogin.Close();

        }

        public void LiberaOpcoesDeAcordoComPermissoes(int permissaoMenu)
        {
            switch (permissaoMenu)
            {
                case 1:
                    DesabilitaItemMenu(menuBarTop, "FiscalMenu",true);
                    cadastrarUsuarioToolStripMenuItem.Enabled = false;
                    cadastrarUsuarioToolStripMenuItem.Visible = false;
                    break;
                case 3:
                    DesabilitaItemMenu(menuBarTop, "FiscalMenu", true);
                    DesabilitaItemMenu(menuBarTop, "ZanupMenu", true);
                    cadastrarUsuarioToolStripMenuItem.Enabled = false;
                    cadastrarUsuarioToolStripMenuItem.Visible = false;
                    break;


            }

        }

        private void importarNFSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////ImportarNotaView eRPFiscal = new ImportarNotaView();
            ////eRPFiscal.Show();

            //using (var eRPFiscal = new ImportarNotaView())
            //{
            //    eRPFiscal.ShowDialog(this);
            //}

        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!FormAberto(typeof(ImportarNotaView)))
            {
                ImportarNotaView eRPFiscal = new ImportarNotaView();                
                eRPFiscal.Show();

            }
        }

        private void importarNotasParaOBigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!FormAberto(typeof(ExportaDadosBig)))
            {
                ExportaDadosBig exportaDadosBig = new ExportaDadosBig();                
                exportaDadosBig.Show();
            }

        }

        private void alterarContaFreteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(!FormAberto(typeof (AlterarContaDebitoFrete)))
            //{
            //    AlterarContaDebitoFrete alterarContaDebitoFrete = new AlterarContaDebitoFrete();
            //    alterarContaDebitoFrete.Show();
            //}
            
        }
        private bool FormAberto(Type tipoForm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == tipoForm)
                {
                    form.Focus(); // traz o form existente para frente
                    return true;
                }
            }
            return false;
        }

        private void alterarCorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria o seletor de cores
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Cor inicial (opcional)
                colorDialog.Color = this.BackColor;

                // Exibe o seletor
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {

                    // Se quiser pegar o valor RGB:
                    System.Drawing.Color corSelecionada = colorDialog.Color;
                    
                    menuBarBottom.BackColor = corSelecionada;
                    menuBarTop.BackColor = corSelecionada;
                    txtVersao.BackColor = corSelecionada;

                    // 🔹 Salva no Settings (convertendo para HTML: #RRGGBB)
                    Properties.Settings.Default.CorCabecalho = ColorTranslator.ToHtml(corSelecionada);
                    Properties.Settings.Default.Save();


                }
            }
        }

        private void devoluçaoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAberto(typeof(ConsultaSaldoNotasFiscais)))
            {
                ConsultaSaldoNotasFiscais alteraTipoMovimento = new ConsultaSaldoNotasFiscais();                
                alteraTipoMovimento.Show();
            }
        }

        private void importarRecebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAberto(typeof(ImportacaoRecebimento)))
            {
                ImportacaoRecebimento importacaoRecebimento = new ImportacaoRecebimento();                
                importacaoRecebimento.Show();
            }
            
        }

        private void atualizarGestãoPatrimonialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAberto(typeof(ImportacaoRecebimento)))
            {
                ImportacaoRecebimento importacaoRecebimento = new ImportacaoRecebimento();                
                importacaoRecebimento.Show();
            }
        }

        private void txtVersao_Click(object sender, EventArgs e)
        {
            contadorTheme++;

            if (contadorTheme == 5)
            {
                MessageBox.Show("Tema Secreto habilitado");
                

            }
        }

        public void HabilitaThema()
        {
            string caminho = Path.Combine(Application.StartupPath, "theme", "themeDracula.json");
            
            //this.BackColor 

        }

        private void alteraçãoUnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAberto(typeof(AlteraTipoMovimento)))
            {
                AlteraTipoMovimento alteraTipoMovimento = new AlteraTipoMovimento();                
                alteraTipoMovimento.Show();
            }
        }

        private void alteraçãoEmListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAberto(typeof(AlterarTipoMovimentoLista)))
            {
                AlterarTipoMovimentoLista alteraTipoMovimentoLista = new AlterarTipoMovimentoLista();                
                alteraTipoMovimentoLista.Show();
            }
        }

        private async void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!FormAberto(typeof(CadUsu)))
            {
                SegCadastroController segCadastroController = new SegCadastroController();
                DataTable dt = await segCadastroController.ListaDados("%", 1);
                CadUsu cadastroUsuario = new CadUsu(dt);                
                cadastroUsuario.Show();
            }
        }

        public void DesabilitaItemMenu(MenuStrip menu, string nomeItem, bool valor)
        {
            // Se não passar nada → desabilita tudo
            if (string.IsNullOrWhiteSpace(nomeItem))
            {
                foreach (ToolStripMenuItem item in menu.Items)
                {
                    DesabilitaTodosItensRecursivo(item, valor);
                }
                return;
            }

            // Caso contrário → habilita apenas o item especificado
            foreach (ToolStripMenuItem item in menu.Items)
            {
                DesabilitaItemMenuRecursivo(item, nomeItem, valor);
            }
        }

        private void DesabilitaTodosItensRecursivo(ToolStripMenuItem item, bool valor)
        {
            item.Enabled = valor;
            item.Visible = valor;

            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem sub)
                    DesabilitaTodosItensRecursivo(sub, valor);
            }
        }

        private void DesabilitaItemMenuRecursivo(ToolStripMenuItem item, string nomeItem, bool valor)
        {
            if (item.Name == nomeItem)
            {
                item.Enabled = valor;
                item.Visible = valor;
                AplicaValorRecursivo(item, valor);
                return;
            }

            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem sub)
                    DesabilitaItemMenuRecursivo(sub, nomeItem, valor);
            }
        }

        private void AplicaValorRecursivo(ToolStripMenuItem item, bool valor)
        {
            item.Enabled = valor;
            item.Visible = valor;

            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem sub)
                    AplicaValorRecursivo(sub, valor);
            }
        }

        private void xMLPostoDoLagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAberto(typeof(ExportaXml)))
            {
                ExportaXml exportaXml = new ExportaXml();                
                exportaXml.Show();
            }
            
        }

        private void grandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alteraTamanhoFonte(12);
        }

        private void médioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alteraTamanhoFonte(10);
        }

        private void pequenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alteraTamanhoFonte(8);
        }

        public void alteraTamanhoFonte(int valor)
        {
            Properties.Settings.Default.FonteTamanho = valor;
            Properties.Settings.Default.Save();
        }
    }
}

