using ERP_FISCAL.Service.UploadFile;
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
    public partial class ImportacaoRecebimento : Form
    {
        public string caminho;
        public ImportacaoRecebimento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadFileService uploadFileService = new UploadFileService();
            string novoCaminho = uploadFileService.SelecionarArquivo();

            DataTable dtRetorno = uploadFileService.FormatarPlanilhaSicoob(novoCaminho);

            dgRecebimento.DataSource= dtRetorno;
            uploadFileService.FormatarGridVisual(dgRecebimento);
        }
    }
}
