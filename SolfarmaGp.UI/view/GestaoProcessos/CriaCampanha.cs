using System;
using System.Windows.Forms;

namespace ERP_FISCAL.view.GestaoProcessos
{
    public partial class CriaCampanha : Form
    {
        public CriaCampanha()
        {
            InitializeComponent();
            
            tbGatilhoVenda.Enabled = false;
            tbGatilhoPositivacao.Enabled = false;
            string[] tipoValores = { "Valor Venda", "Receita Líquida" };
            cbValores.Items.AddRange(tipoValores);
            cbValores.SelectedIndex = 0;
        }

        private void chckGatilhoVenda_CheckedChanged(object sender, EventArgs e)
        {
            tbGatilhoVenda.Enabled = !tbGatilhoVenda.Enabled;

        }

        private void chckbGatilhoPositivacao_CheckedChanged(object sender, EventArgs e)
        {
            tbGatilhoPositivacao.Enabled = !tbGatilhoPositivacao.Enabled;
        }

        private void tbGatilhoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            var returno = validaCaracterDigitado(e);
            if (!returno) return;
        }

        private void tbGatilhoPositivacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            var returno = validaCaracterDigitado(e);
            if (!returno) return;
        }

        private void tbMeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            var returno = validaCaracterDigitado(e);
            if (!returno) return;
        }
        public bool validaCaracterDigitado(KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return true;
            }
            return false;
        }

        private void btnBuscalApuracao_Click(object sender, EventArgs e)
        {

        }
    }
}
