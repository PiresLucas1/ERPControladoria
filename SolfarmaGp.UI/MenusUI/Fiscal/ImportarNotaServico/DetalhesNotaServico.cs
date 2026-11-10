namespace SolfarmaGP.UI.MenusUI.Fiscal.ImportarNotaServicoView
{
    // Mostra, somente leitura, todas as informações visíveis de uma linha da grade de notas de serviço
    public partial class DetalhesNotaServico : Form
    {
        public DetalhesNotaServico(DataGridViewRow linha)
        {
            InitializeComponent();

            string documento = linha.Cells["Documento"].Value?.ToString();
            string razaoSocial = linha.Cells["Razão Social Prestador"].Value?.ToString();
            Text = $"Nota {documento} - {razaoSocial}";

            CarregarCampos(linha);
        }

        private void CarregarCampos(DataGridViewRow linha)
        {
            var colunas = linha.DataGridView.Columns
                .Cast<DataGridViewColumn>()
                .Where(col => col.Visible && col.Name != "Selecionar")
                .OrderBy(col => col.DisplayIndex);

            tlpCampos.SuspendLayout();

            foreach (DataGridViewColumn coluna in colunas)
            {
                var valor = linha.Cells[coluna.Index].FormattedValue?.ToString() ?? string.Empty;

                var label = new Label
                {
                    Text = coluna.HeaderText,
                    AutoSize = true,
                    Anchor = AnchorStyles.Left,
                    Font = new Font(Font, FontStyle.Bold),
                    Margin = new Padding(3, 6, 10, 3)
                };

                // TextBox somente leitura para permitir copiar o valor
                var texto = new TextBox
                {
                    Text = valor,
                    ReadOnly = true,
                    Dock = DockStyle.Fill,
                    BackColor = SystemColors.Window
                };

                // Campos com texto longo (ex.: discriminação do serviço, retorno) ficam em várias linhas
                if (valor.Length > 70 || valor.Contains('\n'))
                {
                    texto.Multiline = true;
                    texto.ScrollBars = ScrollBars.Vertical;
                    texto.Height = 80;
                }

                tlpCampos.RowCount++;
                tlpCampos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tlpCampos.Controls.Add(label, 0, tlpCampos.RowCount - 1);
                tlpCampos.Controls.Add(texto, 1, tlpCampos.RowCount - 1);
            }

            tlpCampos.ResumeLayout();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
