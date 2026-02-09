using ERP_FISCAL.Repositories.AlteraTipoMovimentoRepositories;
using SolfarmaGp.UI.UiComponentesTela.Dialogos.UIDialog.UIAltetarEmBloco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view.UIComponentes.UIDialog.UIAltetarEmBloco
{
    public partial class AlteraEmBloco : Form
    {
        private readonly DTOAlteraEmBloco _data;
        private readonly DataTable _dataGrid;
        private readonly int _codLayout;
        private readonly string[] _valorLabel;
        private readonly string[] _valorTextBox;
        private readonly AlteraTipoMovimentoRepositories _repo;
        public AlteraEmBloco( int codLayout, string[] valoresLabel, string[] valorTextBox, AlteraTipoMovimentoRepositories repo, DataTable tabela = null)
        {
            InitializeComponent();
            //_data = data;
            _dataGrid = tabela;
            _codLayout = codLayout;
            _valorLabel = valoresLabel;
            _valorTextBox = valorTextBox;
            _repo = repo;

            //lb1.Text = data.TextLabel1;
            CarregaTerceiroLayout();
        }


        public void CarregaTerceiroLayout()
        {
            if(_codLayout == 3)
            {
                lb1.Text = _valorLabel[0];
                lb2.Text = _valorLabel[1];
                lb3.Text = _valorLabel[2];

                txtValorNovo.Text = _valorTextBox[0] != "" ? _valorTextBox[0] : "";
                txtValorNovo2.Text = _valorTextBox[1] != "" ? _valorTextBox[1] : "";
                txtValorNovo3.Text = _valorTextBox[2] != "" ? _valorTextBox[2] : "";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
