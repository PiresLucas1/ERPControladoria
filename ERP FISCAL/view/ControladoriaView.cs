using ERP_FISCAL.view.ContabilView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            // 🔹 Carrega a cor salva
            string corSalva = Properties.Settings.Default.CorCabecalho;
            if (!string.IsNullOrEmpty(corSalva))
            {
                Color cor = ColorTranslator.FromHtml(corSalva);
                menuBarBottom.BackColor = cor;
                menuBarTop.BackColor = cor;
                txtVersao.BackColor = cor;
            }

            Version versaoAssembly = Assembly.GetExecutingAssembly().GetName().Version;
            txtVersao.Text = $"Versão: {versaoAssembly}";


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
                    Color corSelecionada = colorDialog.Color;
                    
                    menuBarBottom.BackColor = corSelecionada;
                    menuBarTop.BackColor = corSelecionada;
                    txtVersao.BackColor = corSelecionada;

                    // 🔹 Salva no Settings (convertendo para HTML: #RRGGBB)
                    Properties.Settings.Default.CorCabecalho = ColorTranslator.ToHtml(corSelecionada);
                    Properties.Settings.Default.Save();


                }
            }
        }

        private void alterarTipoDeMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAberto(typeof(AlteraTipoMovimento)))
            {
                AlteraTipoMovimento alteraTipoMovimento = new AlteraTipoMovimento();
                alteraTipoMovimento.Show();
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



        //private void alteraTipoMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (!FormAberto(typeof(AlterarContaDebitoFrete)))
        //    {
        //        AlteraTipoMovimento alteraTipoMovimento = new AlteraTipoMovimento();
        //        alteraTipoMovimento.Show();
        //    }
        //}
    }
}
