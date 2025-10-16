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
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
            string usuario = Environment.UserName;
            string dominio = Environment.UserDomainName;

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Reflection.AssemblyName assemblyName = assembly.GetName();
            Version version = assemblyName.Version;

            txtVersao.Text = "Versão: " + version.Major + "." + version.Minor + "." + version.Build;
            //Console.WriteLine(usuario + " " + dominio);

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
            if(!FormAberto(typeof (AlterarContaDebitoFrete)))
            {
                AlterarContaDebitoFrete alterarContaDebitoFrete = new AlterarContaDebitoFrete();
                alterarContaDebitoFrete.Show();
            }
            
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
                    Color corSelecionada = colorDialog.Color;
                    
                    menuBarBottom.BackColor = corSelecionada;
                    menuBarTop.BackColor = corSelecionada;
                    txtVersao.BackColor = corSelecionada;
                }
            }
        }
    }
}
