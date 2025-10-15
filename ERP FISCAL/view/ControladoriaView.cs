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

            Console.WriteLine(usuario + " " + dominio);
           
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
    }
}
