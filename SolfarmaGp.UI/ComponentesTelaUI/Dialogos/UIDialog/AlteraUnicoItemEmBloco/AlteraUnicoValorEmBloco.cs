namespace SolfarmaGp.UI.ComponentesTelaUI.Dialogos.UIDialog.AlteraUnicoItemEmBloco
{
    public partial class AlteraUnicoValorEmBloco : Form
    {
        public string valorDigitado;
        public AlteraUnicoValorEmBloco()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
                return;

            valorDigitado = txtValor.Text;   // guarda o valor
            this.DialogResult = DialogResult.OK; // fecha o form como OK
            this.Close();

        }
    }
}
