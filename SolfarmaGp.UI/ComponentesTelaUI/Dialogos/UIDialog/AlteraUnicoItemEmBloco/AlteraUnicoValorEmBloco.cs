using Newtonsoft.Json.Linq;

namespace SolfarmaGp.UI.ComponentesTelaUI.Dialogos.UIDialog.AlteraUnicoItemEmBloco
{
    public partial class AlteraUnicoValorEmBloco : Form
    {
        public string valorDigitado;
        public int? tipo;   
     
        public AlteraUnicoValorEmBloco(int? tipo = null, string[]? opcoes = null)
        {
            InitializeComponent();
            this.tipo = tipo;
            txtValor.Enabled = false;
            txtValor.Visible = false;
            cbValue.Enabled = false;
            cbValue.Visible = false;

            if (tipo == null) {
                txtValor.Enabled = true;
                txtValor.Visible = true;
            }if(tipo == 2)
            {
                cbValue.Enabled = true;
                cbValue.Visible = true;
                cbValue.Items.AddRange(opcoes ?? Array.Empty<string>());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tipo == 2)
            {
                valorDigitado = cbValue.SelectedItem.ToString() ?? string.Empty;   // guarda o valor selecionado
                this.DialogResult = DialogResult.OK; // fecha o form como OK
                this.Close();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtValor.Text))
                return;

            valorDigitado = txtValor.Text;   // guarda o valor
            this.DialogResult = DialogResult.OK; // fecha o form como OK
            this.Close();

        }
    }
}
