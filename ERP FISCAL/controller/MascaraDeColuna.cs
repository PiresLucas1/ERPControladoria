using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.Controller
{
    public class DataGridViewMaskedTextBoxColumn : DataGridViewColumn
    {
        public string Mask { get; set; }

        public DataGridViewMaskedTextBoxColumn() : base(new DataGridViewMaskedTextBoxCell())
        {
        }

        public override object Clone()
        {
            var col = (DataGridViewMaskedTextBoxColumn)base.Clone();
            col.Mask = this.Mask;
            return col;
        }
    }

    public class DataGridViewMaskedTextBoxCell : DataGridViewTextBoxCell
    {
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue,
        DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            var ctl = DataGridView.EditingControl as MaskedTextBoxEditingControl;

            if (this.OwningColumn is DataGridViewMaskedTextBoxColumn col)
            {
                ctl.Mask = col.Mask;
            }

            // Aqui está a parte crucial:
            ctl.Text = this.Value?.ToString() ?? ""; 
        }


        public override Type EditType => typeof(MaskedTextBoxEditingControl);
        public override Type ValueType => typeof(string);
        public override object DefaultNewRowValue => "";
    }

    public class MaskedTextBoxEditingControl : MaskedTextBox, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;

        public MaskedTextBoxEditingControl()
        {
            this.Mask = "00/00/0000";
            this.TextChanged += MaskedTextBoxEditingControl_TextChanged; // conecta o evento ao método
        }

        // Este método precisa existir!
        private void MaskedTextBoxEditingControl_TextChanged(object sender, EventArgs e)
        {
            this.valueChanged = true; // sinaliza que o valor mudou
            this.EditingControlDataGridView?.NotifyCurrentCellDirty(true); // avisa ao DataGridView
        }

        public object EditingControlFormattedValue
        {
            get => this.Text;
            set => this.Text = (string)value;
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context) => this.Text;

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex { get => rowIndex; set => rowIndex = value; }
        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey) => true;
        public void PrepareEditingControlForEdit(bool selectAll) { }
        public bool RepositionEditingControlOnValueChange => false;
        public DataGridView EditingControlDataGridView { get => dataGridView; set => dataGridView = value; }
        public bool EditingControlValueChanged { get => valueChanged; set => valueChanged = value; }
        public Cursor EditingPanelCursor => base.Cursor;
    }


}
