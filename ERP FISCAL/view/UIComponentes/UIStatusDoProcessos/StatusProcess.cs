using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view.UIComponentes.UIStatusDoProcessos
{
    public partial class StatusProcess : Form
    {
        private delegate void ProgressDelegate(int progress);
        private ProgressDelegate del;

        public StatusProcess()
        {
            InitializeComponent();
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = 0;
            del = this.UpdateProgressInternal;

            // Configurações de UX
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }
        private void UpdateProgressInternal(int progress)
        {
            if (this.IsHandleCreated && !this.IsDisposed)
            {
                this.progressBar1.Value = Math.Min(progress, 100);
                this.progressBar1.Update();
            }
        }

        public void UpdateProgress(int progress)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(del, progress);
            }
            else
            {
                UpdateProgressInternal(progress);
            }
        }

        public void SetMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(SetMessage), message);
            }
            else if (this.IsHandleCreated && !this.IsDisposed)
            {
                if (this.Controls.Contains(this.label1)) // assumindo que tem um label
                {
                    this.label1.Text = message;
                }
            }
        }
    }
}
