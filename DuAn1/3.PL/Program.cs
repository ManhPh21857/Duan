using _3.PL.Views;
using _3.PL.ViewsFrm;
using _3.PL.ViewData;
using _3.Presentation;

namespace _3.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application co nfiguration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmBanHang());
        }
    }
}