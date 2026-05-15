using SolfarmaGp.UI.MenusUI;
using System.Text;
using System.Globalization;
using System.Threading;

namespace SolfarmaGp.App
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //var cultura = new CultureInfo("en-US");

            //CultureInfo.DefaultThreadCurrentCulture = cultura;
            //CultureInfo.DefaultThreadCurrentUICulture = cultura;

            //Thread.CurrentThread.CurrentCulture = cultura;
            //Thread.CurrentThread.CurrentUICulture = cultura;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new Portal());
        }
    }
}