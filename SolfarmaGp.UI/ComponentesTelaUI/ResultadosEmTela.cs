using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SolfarmaGp.UI.ComponentesTelaUI
{
    public partial class ResultadosEmTela : Form
    {
        public class ItemResultado
        {
            public string Label { get; set; }
            public string Valor { get; set; }
        }

        private readonly List<ItemResultado> _itens;

        public ResultadosEmTela(IEnumerable<ItemResultado> itens)
        {
            InitializeComponent();
            _itens = itens?.ToList() ?? new List<ItemResultado>();
            Load += ResultadosEmTela_Load;
        }

        private void ResultadosEmTela_Load(object sender, EventArgs e)
        {
            CarregaResultados();
        }

        private void CarregaResultados()
        {
            pnlContainer.Controls.Clear();

            const int alturaLinha = 36;
            const int margem = 10;

            for (int i = 0; i < _itens.Count; i++)
            {
                ItemResultado item = _itens[i];
                int y = margem + (i * alturaLinha);

                Label label = new Label
                {
                    Text = item.Label,
                    Location = new Point(margem, y + 4),
                    
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold)
                };

                TextBox textBox = new TextBox
                {
                    Text = item.Valor,
                    Location = new Point(190, y),
                    Size = new Size(260, 27),
                    ReadOnly = true
                };

                pnlContainer.Controls.Add(label);
                pnlContainer.Controls.Add(textBox);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
