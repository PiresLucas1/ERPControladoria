using ERP_FISCAL.Controller.MetaComissaoFarmaController;
using ERP_FISCAL.view.UIComponentes;
using System;
using System.Data;
using System.Windows.Forms;

namespace ERP_FISCAL.view.MetasComissaoFarma
{
    public partial class MetaComissao : Form
    {
        public MetaComissao()
        {
            InitializeComponent();
        }

        private void tabConfiguracoes_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDataBase_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtbLoreal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            ObjetoPesquisa objetoPesquisa = new ObjetoPesquisa
            {
                INdatDatabase = dtpDataBase.Checked ? dtpDataBase.Value : null,

                INnumMetaReceitaLiquidaTotal = decimal.TryParse(txtbMetaTotal.Text, out var metaTotal) ? metaTotal : null,

                INnumMetaReceitaLiquidaHPC = decimal.TryParse(txtbHPC.Text, out var hpc) ? hpc : null,

                INnumMetaReceitaLiquidaGenerico = decimal.TryParse(txtbGenerico.Text, out var generico) ? generico : null,

                INnumMetaReceitaLiquidaNestle = decimal.TryParse(txtbNestle.Text, out var nestle) ? nestle : null,

                INnumMetaReceitaLiquidaLoreal = decimal.TryParse(txtbLoreal.Text, out var loreal) ? loreal : null,

                INnumMetaReceitaLiquidaEtico = decimal.TryParse(txtbEtico.Text, out var etico) ? etico : null,

                INnumMetaReceitaLiquidaEmpresaFoco1 = decimal.TryParse(txtbEmpresaFoco1.Text, out var emp1) ? emp1 : null,

                INnumMetaReceitaLiquidaEmpresaFoco2 = decimal.TryParse(txtbEmpresaFoco2.Text, out var emp2) ? emp2 : null,

                INnumMetaReceitaLiquidaEmpresaFoco3 = decimal.TryParse(txtbEmpresaFoco3.Text, out var emp3) ? emp3 : null,

                INnumMetaReceitaLiquidaEmpresaFoco4 = decimal.TryParse(txtbEmpresaFoco4.Text, out var emp4) ? emp4 : null,

                INnumMetaReceitaLiquidaEmpresaFoco5 = decimal.TryParse(txtbEmpresaFoco5.Text, out var emp5) ? emp5 : null,

                INvchIDFabricanteEmpresaFoco1 = string.IsNullOrWhiteSpace(txtbFabricanteEmpFoco1.Text) ? null : txtbFabricanteEmpFoco1.Text,

                INvchIDFabricanteEmpresaFoco2 = string.IsNullOrWhiteSpace(txtbFabricanteEmpFoco2.Text) ? null : txtbFabricanteEmpFoco2.Text,

                INvchIDFabricanteEmpresaFoco3 = string.IsNullOrWhiteSpace(txtbFabricanteEmpFoco3.Text) ? null : txtbFabricanteEmpFoco3.Text,

                INvchIDFabricanteEmpresaFoco4 = string.IsNullOrWhiteSpace(txtbFabricanteEmpFoco4.Text) ? null : txtbFabricanteEmpFoco4.Text,

                INvchIDFabricanteEmpresaFoco5 = string.IsNullOrWhiteSpace(txtbFabricanteEmpFoco5.Text) ? null : txtbFabricanteEmpFoco5.Text,

                INvchIDSetorDesconsiderar = string.IsNullOrWhiteSpace(txtbSetorDesconsiderar.Text) ? null : txtbSetorDesconsiderar.Text,

                INintNroMeses = int.TryParse(txtbNumeroMeses.Text, out var meses) ? meses : null,

                INvchIDPessoaSupervisoresRateio = string.IsNullOrWhiteSpace(txtbSuper.Text) ? null : txtbSuper.Text,

                INvchPercentualRateioSupervisores = string.IsNullOrWhiteSpace(txtbSuperRateio.Text) ? null : txtbSuperRateio.Text,

                INvchPercentualRateioSupervisoresHPC = string.IsNullOrWhiteSpace(txtbSuperHpc.Text) ? null : txtbSuperHpc.Text,

                INvchPercentualRateioSupervisoresGenerico = string.IsNullOrWhiteSpace(txtbSuperGen.Text) ? null : txtbSuperGen.Text,

                INvchPercentualRateioSupervisoresNestle = string.IsNullOrWhiteSpace(txtbSuperNest.Text)  ? null : txtbSuperNest.Text,

                INvchPercentualRateioSupervisoresLoreal = string.IsNullOrWhiteSpace(txtSuperLor.Text) ? null : txtSuperLor.Text,

                INvchPercentualRateioSupervisoresEtico = string.IsNullOrWhiteSpace(txtbSupeEti.Text) ? null : txtbSupeEti.Text,

                INvchIDProdutoLinhaEmpresaFoco1 = string.IsNullOrWhiteSpace(txtbEmpLinha1.Text) ? null : txtbEmpLinha1.Text,

                INvchIDProdutoLinhaEmpresaFoco2 =  string.IsNullOrWhiteSpace(txtbEmpLinha2.Text) ? null : txtbEmpLinha2.Text,

                INvchIDProdutoLinhaEmpresaFoco3 = string.IsNullOrWhiteSpace(txtbEmpLinha3.Text) ? null : txtbEmpLinha3.Text,

                INvchIDProdutoLinhaEmpresaFoco4 = string.IsNullOrWhiteSpace(txtbEmpLinha4.Text) ? null : txtbEmpLinha4.Text,

                INvchIDProdutoLinhaEmpresaFoco5 = string.IsNullOrWhiteSpace(txtbEmpLinha5.Text) ? null : txtbEmpLinha5.Text,

                INnumMetaTotalIndustriasGolden = decimal.TryParse(txtbIndustriaGolden.Text, out var golden) ? golden : null,

                INvchIDFabricantesIndustriasGolden = string.IsNullOrWhiteSpace(txtIndustriaFabricanteGolden.Text) ? null : txtIndustriaFabricanteGolden.Text,

                INvchIDProdutoLinhaIndustriasGolden = string.IsNullOrWhiteSpace(txtbLinhaIndustriaGolden.Text) ? null : txtbLinhaIndustriaGolden.Text
            };

            MetaComissaoFarmaController metaComissaoFarmaController = new MetaComissaoFarmaController();
            DataTable resultado = await metaComissaoFarmaController.BuscaComissaoMetas(objetoPesquisa);




        }

        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            if (sender is not TextBox textBox)
                return;
            Console.WriteLine(textBox.Name);

            using (var insereTexto = new InsereTexto())
            {
                if (insereTexto.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = insereTexto.TextoConfirmado;
                }
            }
        }


    }
}
