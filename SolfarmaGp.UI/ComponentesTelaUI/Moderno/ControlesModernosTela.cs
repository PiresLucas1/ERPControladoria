using System.Drawing.Drawing2D;
using MeuGrid = SolfarmaGp.UI.ComponentesTelaUI.DataGridView.MyDataGridView;

namespace SolfarmaGp.UI.ComponentesTelaUI.Moderno
{
    /// <summary>
    /// GroupBox com aparência de cartão (branco, cantos arredondados, título em negrito).
    /// Mantém o mesmo sistema de coordenadas do GroupBox: os controles filhos não mudam de posição.
    /// </summary>
    public class CartaoGroupBox : GroupBox
    {
        public int Raio { get; set; } = 10;
        public Color CorBorda { get; set; } = Color.FromArgb(222, 225, 230);

        public CartaoGroupBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Parent?.BackColor ?? SystemColors.Control);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Cartão dentro de cartão fica pesado: um grupo aninhado vira só um subtítulo discreto
            // (sem fundo e sem borda) e, se não tiver título, é apenas um contêiner invisível.
            bool aninhado = Parent is CartaoGroupBox;

            if (!aninhado)
            {
                using (var path = FormasModernas.RetanguloArredondado(new Rectangle(0, 0, Width - 1, Height - 1), Raio))
                {
                    using (var pincel = new SolidBrush(BackColor))
                        g.FillPath(pincel, path);
                    using (var pen = new Pen(CorBorda))
                        g.DrawPath(pen, path);
                }
            }

            if (!string.IsNullOrEmpty(Text))
            {
                Color cor = Enabled
                    ? (aninhado ? Color.FromArgb(96, 96, 96) : Color.FromArgb(40, 40, 40))
                    : SystemColors.GrayText;

                if (aninhado)
                {
                    TextRenderer.DrawText(g, Text, Font, new Point(2, 0), cor,
                        TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
                }
                else
                {
                    using var negrito = new Font(Font, FontStyle.Bold);
                    TextRenderer.DrawText(g, Text, negrito, new Point(10, 3), cor,
                        TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
                }
            }
        }
    }

    /// <summary>
    /// Grade com visual moderno (cabeçalho cinza, linhas alternadas, seleção suave). Só aparência:
    /// não altera edição, seleção, colunas nem qualquer comportamento.
    /// </summary>
    public class GradeModerna : MeuGrid
    {
        public GradeModerna()
        {
            BackgroundColor = Color.White;
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridColor = Color.FromArgb(235, 237, 240);
            EnableHeadersVisualStyles = false;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(245, 246, 248),
                ForeColor = Color.FromArgb(60, 60, 60),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                SelectionBackColor = Color.FromArgb(245, 246, 248),
                SelectionForeColor = Color.FromArgb(60, 60, 60),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                WrapMode = DataGridViewTriState.False
            };

            DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(40, 40, 40),
                SelectionBackColor = Color.FromArgb(253, 232, 220),
                SelectionForeColor = Color.FromArgb(40, 40, 40)
            };

            AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(250, 251, 252)
            };
        }
    }
}
