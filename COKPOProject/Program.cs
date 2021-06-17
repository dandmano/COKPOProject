using COKPOProjectLogic;
using System;
using System.Windows.Forms;

namespace COKPOProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var centrumTransakcji = CentrumTransakcji.Wczytywanie("dane.json");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FStronaGlowna(centrumTransakcji));
        }

    }
}
