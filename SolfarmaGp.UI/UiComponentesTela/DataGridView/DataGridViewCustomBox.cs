using System.Windows.Forms.VisualStyles;

namespace SolfarmaGp.UI.View.SubTipos
{
    public class DataGridViewCustomBoxCell : DataGridViewTextBoxCell
    {
    private bool isHovering = false;
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds,
                                      int rowIndex, DataGridViewElementStates cellState, object value,
                                      object formattedValue, string errorText,
                                      DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
                                      DataGridViewPaintParts paintParts)
        {
            // Pinta a célula padrão
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue,
                       errorText, cellStyle, advancedBorderStyle, paintParts);

            // Desenha o botão no canto direito
            Rectangle botaoRect = new Rectangle(cellBounds.Right - 20, cellBounds.Top + 2, 18, cellBounds.Height - 4);
            ButtonRenderer.DrawButton(graphics, botaoRect, PushButtonState.Normal);

            var estadoBotao = isHovering ? PushButtonState.Hot : PushButtonState.Normal;
            // Desenha "…" dentro do botão
            TextRenderer.DrawText(graphics, "…", cellStyle.Font, botaoRect, cellStyle.ForeColor,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        public void UpdateHover(bool hovering)
        {
            if (isHovering != hovering)
            {
                isHovering = hovering;
                this.DataGridView?.InvalidateCell(this); // Força redraw
            }
        }
    }

    public class DataGridViewCustomBoxColumn : DataGridViewColumn
    {
        public DataGridViewCustomBoxColumn() : base(new DataGridViewCustomBoxCell())
        {
            this.CellTemplate = new DataGridViewCustomBoxCell();
        }
    }
    

    }