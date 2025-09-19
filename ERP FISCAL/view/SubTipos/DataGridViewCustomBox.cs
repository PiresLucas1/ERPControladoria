using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ERP_FISCAL.view.SubTipos
{
    public class DataGridViewCustomBoxCell : DataGridViewTextBoxCell
    {
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

            // Desenha "…" dentro do botão
            TextRenderer.DrawText(graphics, "…", cellStyle.Font, botaoRect, cellStyle.ForeColor,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}