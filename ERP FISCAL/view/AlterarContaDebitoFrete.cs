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
    public partial class AlterarContaDebitoFrete : Form
    {
        public AlterarContaDebitoFrete()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var dataInicio = dateTimePickerInicio.Value;
            var dataFim = dateTimePickerFim.Value;

            if(dataInicio <= dataFim)
            {

            }
        }
    }
}
