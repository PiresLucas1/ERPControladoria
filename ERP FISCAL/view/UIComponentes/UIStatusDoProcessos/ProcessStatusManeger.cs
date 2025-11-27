using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.view.UIComponentes.UIStatusDoProcessos
{
    public static class ProcessStatusManager
    {
        private static StatusProcess _form;

        public static void Start(string message = "Processando...")
        {
            if (_form != null && !_form.IsDisposed)
                return;

            _form = new StatusProcess();
            _form.SetMessage(message);

            Task.Run(() =>
            {
                _form.ShowDialog();
            });
        }

        public static void Update(string message)
        {
            if (_form != null && !_form.IsDisposed)
                _form.SetMessage(message);
        }

        public static void Stop()
        {
            if (_form != null && !_form.IsDisposed)
            {
                _form.CloseComponent();
                _form = null;
            }
        }

        public static void Error(Exception ex)
        {
            Stop();
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
