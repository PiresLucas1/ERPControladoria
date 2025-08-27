using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ERP_FISCAL;
using ERP_FISCAL.controller;
using ERP_FISCAL.view.interfaces;




namespace ERP_FISCAL.view
{
    public partial class NaturezaFiscal : Form
    {
        // Saídas para o form chamador
        public string CFOPSelecionado { get; private set; }
        public string DescricaoSelecionada { get; private set; }

        public int codColigada { get; set; }
        public int indexCelula { get; set; }
        public ImportarNota _formPai {  get; set; }
        public string numDoc { get; set; }
        public string codVerificacao { get; set; }
        public string cnpjPrestador { get; set; }


        // Dados carregados do controller
        private IAjusteComboBoxUi _cfops;

        public NaturezaFiscal(INaturezaFiscalType data)
        {
            InitializeComponent();

            // estados iniciais de UI
            comboBoxNatureza.Enabled = false;
            codColigada = data.ReqCodColigada;
            indexCelula = data.ReqIndexCelula;
            _formPai = data.FormFocus;
            numDoc = data.NumDoc;
            codVerificacao = data.CodVerificacao;
            cnpjPrestador= data.CnpjPrestador;



            // carrega dados no Load (para poder usar await)
            this.Load += NaturezaFiscal_Load;
        }


        public async void CarregaInformacoesNaturezaForms()
        {
            try
            {
                var carregaComboBoxCfop = new CarregaCFOPController();
                _cfops = await carregaComboBoxCfop.ListaTodosCFOPController();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar coligadas/naturezas: " + ex.Message, "Natureza Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nomeColigada = carregaNameColigada();
            comboBoxColigada.SelectedValue = codColigada;
            comboBoxColigada.Text = nomeColigada;
            comboBoxColigada.Enabled = false;

            textBoxNumDoc.Text = numDoc;
            textBoxCnpj.Text = cnpjPrestador;
            textBoxCodVerificacao.Text = codVerificacao;





        }
        private async void NaturezaFiscal_Load(object sender, EventArgs e)
        {

            CarregaInformacoesNaturezaForms();
            CarregarNaturezasDaColigada();
        }
        public string carregaNameColigada()
        {
            var nomeColigada = _cfops.DicionarioColigada.TryGetValue(codColigada.ToString(), out string valorEncontrado);

            if (!nomeColigada)
            {
                return "Não foi possivel localizar coligada";
            }
            string nomeColigadaConcatenado = codColigada.ToString() + " - " + valorEncontrado;

            return nomeColigadaConcatenado;

        }


        private void CarregarNaturezasDaColigada()
        {
            comboBoxNatureza.Items.Clear();

            if (_cfops == null || _cfops.DatatableNatureza == null || _cfops.DatatableNatureza.Rows.Count == 0)
            {
                comboBoxNatureza.Enabled = false;
                return;
            }

            foreach (DataRow row in _cfops.DatatableNatureza.Rows)
            {
                var itemKey = Convert.ToInt32(row["CODCOLIGADA"]);
                if (itemKey != codColigada) continue;

                string key = Convert.ToString(row["IDNATUREZA"]);
                string desc = Convert.ToString(row["DESCRICAO_NATUREZA"]);
                string value = key + " - " + desc;

                comboBoxNatureza.Items.Add(new KeyValuePair<string, string>(key, value));
            }

            comboBoxNatureza.DisplayMember = "Value";
            comboBoxNatureza.ValueMember = "Key";
            comboBoxNatureza.Enabled = comboBoxNatureza.Items.Count > 0;


        }

        private void comboBoxNatureza_SelectedIndexChanged(object sender, EventArgs e)
        {

            object selObj = comboBoxNatureza.SelectedItem;
            if (!(selObj is KeyValuePair<string, string>)) return;
            var sel = (KeyValuePair<string, string>)selObj;

            var dataRowNatureza = _cfops.DatatableNatureza.Select($"IDNATUREZA = '{sel.Key}' AND CODCOLIGADA = {codColigada}" );



            DataRow rowTeste = dataRowNatureza[0];
            //Console.WriteLine(rowTeste[3]);
            //Console.WriteLine(rowTeste[4]);
            string tipoContabilizacao = rowTeste[3].ToString();
            string codigoConta = rowTeste[4].ToString();

            textBoxTipoContabilizacao.Text = tipoContabilizacao;
            textBoxCodigoConta.Text = codigoConta;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (comboBoxNatureza.SelectedIndex == -1) return;

            object selObj = comboBoxNatureza.SelectedItem;
            if (!(selObj is KeyValuePair<string, string>)) return;
            var sel = (KeyValuePair<string, string>)selObj;

            CFOPSelecionado = sel.Key;    // exemplo: "5102"
            DescricaoSelecionada = sel.Value; // exemplo: "5102 - Venda de produção...


            _formPai.AtualizaCFOP(indexCelula, CFOPSelecionado);
            this.Close();
        }

        private void SelecionarIrProximo_Click(object sender, EventArgs e)
        {
            int indexContador = indexCelula;
            object selObj = comboBoxNatureza.SelectedItem;
            if (!(selObj is KeyValuePair<string, string>)) return;
            var sel = (KeyValuePair<string, string>)selObj;

            _formPai.AtualizaCFOP(indexContador, sel.Key);

            indexContador++;
            DtoFormNotaParaNatureza novosValores = new DtoFormNotaParaNatureza();
            novosValores = _formPai.PegaInformacaoParaNatureza(indexContador);

            this.codColigada = int.Parse(novosValores.CodColigada);
            this.numDoc = novosValores.NumDoc;
            this.cnpjPrestador = novosValores.CnpjPrestador;
            this.codVerificacao = novosValores.CodVerificacao;

            CarregaInformacoesNaturezaForms();


        }
    }
}
