using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolfarmaGp.UI.MenusUI.Fiscal.BaseCheia
{
    public partial class ArrumaBaseCheia : Form
    {
        public ArrumaBaseCheia()
        {
            InitializeComponent();

            // Alinhar ao centro
            rtbInformacao.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            DateTime dtInicio = dtpDataInicio.Value.Date;
            DateTime dtFIm = dtpDataFim.Value.Date;

            if (dtInicio > dtFIm)
            {
                MessageBox.Show("Data inválida");
                return;
            }

            DialogResult resultado =
                MessageBox.Show(
                    "Deseja confirmar o cálculo?",
                    "Confirmação",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information
                    );

            if (resultado == DialogResult.OK)
            {
                
            }
        }
    }
}
