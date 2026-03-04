using OfficeOpenXml;
using System.Data;

namespace SolfarmaGp.UI.MenusUI.Contabil.ConferenciaBoleto
{
    public partial class ConfereciaBoleto : Form
    {
        public ConfereciaBoleto()
        {
            InitializeComponent();
            ExcelPackage.License.SetNonCommercialPersonal("SolfarmaGP");
        }

        private void btnImportarArquivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Selecione o arquivo Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        FileInfo fileInfo = new FileInfo(filePath);

                        txtFileName.Text = fileInfo.Name;

                        using (ExcelPackage package = new ExcelPackage(fileInfo))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                            if (worksheet.Dimension == null)
                            {
                                MessageBox.Show("A planilha está vazia.");
                                return;
                            }

                            DataTable dt = new DataTable();

                            bool hasHeader = true;

                            // Criar colunas
                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                string columnName = hasHeader
                                    ? worksheet.Cells[1, col].Text
                                    : $"Column {col}";

                                dt.Columns.Add(string.IsNullOrWhiteSpace(columnName)
                                    ? $"Column {col}"
                                    : columnName);
                            }

                            int startRow = hasHeader ? 2 : 1;

                            // Preencher linhas
                            for (int row = startRow; row <= worksheet.Dimension.End.Row; row++)
                            {
                                DataRow newRow = dt.NewRow();

                                for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                                {
                                    newRow[col - 1] = worksheet.Cells[row, col].Text;
                                }

                                dt.Rows.Add(newRow);
                            }

                            dvgRelacaoBoletos.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao importar o arquivo:\n" + ex.Message);
                    }
                }
            }

        }


    }
}
