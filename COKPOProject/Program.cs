using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var centrumTransakcji = new CentrumTransakcji();
            Stworzbankitd(centrumTransakcji);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FStronaGlowna(centrumTransakcji));

        }

        private static void Stworzbankitd(CentrumTransakcji centrumTransakcji)
        {
            centrumTransakcji.DodajBank("Millenium");
            centrumTransakcji.DodajBank("Alior");
            centrumTransakcji.Banki[0].DodajKlienta("Jan Kowalski", 2);
            centrumTransakcji.Banki[0].Klienci[0].DodajKarte(0, 1500, "");
            centrumTransakcji.Banki[0].Klienci[0].DodajKarte(0, 25, "");
            centrumTransakcji.Banki[0].DodajKlienta("Mlekpol", 1);
            centrumTransakcji.Banki[0].Klienci[1].DodajKarte(1, 13000, "");
            centrumTransakcji.Banki[0].Klienci[1].DodajKarte(0, 50, "");
            centrumTransakcji.Banki[1].DodajKlienta("Mateusz Debil", 2);
            centrumTransakcji.Banki[1].Klienci[0].DodajKarte(0, 69, "");
            centrumTransakcji.Banki[1].Klienci[0].DodajKarte(1, 6969, "");
            centrumTransakcji.Banki[1].DodajKlienta("Adidasz", 1);
            centrumTransakcji.Banki[1].Klienci[1].DodajKarte(1, 1513214, "");
            centrumTransakcji.Banki[1].Klienci[1].DodajKarte(0, 3232, "");

        }
    }
}
