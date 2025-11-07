using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view.ContabilView
{
    public partial class GestaoPatrimonio : Form
    {
        public GestaoPatrimonio()
        {
            InitializeComponent();
            cbColigada.Items.Add(2);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //pega informações do datapicker
            //valida informação
            //abre o controller
            //caso de certo retornar OK, caso contrário mensagem de erro
        }
    }
}
