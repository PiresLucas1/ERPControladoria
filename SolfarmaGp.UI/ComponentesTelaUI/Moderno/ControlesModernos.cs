using System.Drawing.Drawing2D;

namespace SolfarmaGp.UI.ComponentesTelaUI.Moderno
{
    internal static class FormasModernas
    {
        public static GraphicsPath RetanguloArredondado(Rectangle r, int raio)
        {
            int d = raio * 2;
            var path = new GraphicsPath();
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }

    /// <summary>Painel branco com cantos arredondados e borda fina, usado como "cartão" de seção.</summary>
    public class CartaoPanel : Panel
    {
        public int Raio { get; set; } = 10;
        public Color CorBorda { get; set; } = Color.FromArgb(222, 225, 230);

        public CartaoPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (Width > 2 && Height > 2)
            {
                using var path = FormasModernas.RetanguloArredondado(new Rectangle(0, 0, Width, Height), Raio);
                var antiga = Region;
                Region = new Region(path);
                antiga?.Dispose();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var path = FormasModernas.RetanguloArredondado(new Rectangle(0, 0, Width - 1, Height - 1), Raio);
            using var pen = new Pen(CorBorda);
            e.Graphics.DrawPath(pen, path);
        }
    }

    /// <summary>Botão plano com cantos arredondados. Principal = laranja cheio; secundário = só contorno.</summary>
    public class BotaoModerno : Button
    {
        private bool _passando;

        public bool Principal { get; set; }
        public int Raio { get; set; } = 8;

        public BotaoModerno()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnMouseEnter(EventArgs e) { _passando = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _passando = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnEnabledChanged(EventArgs e) { Invalidate(); base.OnEnabledChanged(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Parent?.BackColor ?? SystemColors.Control);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color fundo, texto, borda;
            if (!Enabled)
            {
                fundo = Color.FromArgb(236, 238, 241);
                texto = Color.FromArgb(150, 154, 160);
                borda = Color.FromArgb(226, 228, 232);
            }
            else if (Principal)
            {
                fundo = _passando ? Color.FromArgb(207, 74, 6) : Color.FromArgb(232, 89, 12);
                texto = Color.White;
                borda = fundo;
            }
            else
            {
                fundo = _passando ? Color.FromArgb(245, 246, 248) : Color.White;
                texto = Color.FromArgb(40, 40, 40);
                borda = Color.FromArgb(190, 194, 200);
            }

            using var path = FormasModernas.RetanguloArredondado(new Rectangle(0, 0, Width - 1, Height - 1), Raio);
            using (var pincel = new SolidBrush(fundo))
                g.FillPath(pincel, path);
            using (var pen = new Pen(borda))
                g.DrawPath(pen, path);

            TextRenderer.DrawText(g, Text, Font, ClientRectangle, texto,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }
    }
}
