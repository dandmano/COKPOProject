using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COKPOProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CentrumTransakcji centrumTransakcji = new CentrumTransakcji();
            Stworzbankitd(centrumTransakcji);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CentrumObslugiStronaGlowna(centrumTransakcji));

        }

        static void Stworzbankitd(CentrumTransakcji centrumTransakcji)
        {
            centrumTransakcji.DodajBank("Millenium");
            centrumTransakcji.DodajBank("Alior");
            centrumTransakcji.GetBanki()[0].DodajKlienta("Jan Kowalski", 2);
            centrumTransakcji.GetBanki()[0].GetKlienci()[0].DodajKarte(0, 1500, "");
            centrumTransakcji.GetBanki()[0].GetKlienci()[0].DodajKarte(0, 25, "");
            centrumTransakcji.GetBanki()[0].DodajKlienta("Mlekpol", 1);
            centrumTransakcji.GetBanki()[0].GetKlienci()[1].DodajKarte(1, 13000, "");
            centrumTransakcji.GetBanki()[0].GetKlienci()[1].DodajKarte(0, 50, "");
            centrumTransakcji.GetBanki()[1].DodajKlienta("Mateusz Debil", 2);
            centrumTransakcji.GetBanki()[1].GetKlienci()[0].DodajKarte(0, 69, "");
            centrumTransakcji.GetBanki()[1].GetKlienci()[0].DodajKarte(1, 6969, "");
            centrumTransakcji.GetBanki()[1].DodajKlienta("Adidasz", 1);
            centrumTransakcji.GetBanki()[1].GetKlienci()[1].DodajKarte(1, 1513214, "");
            centrumTransakcji.GetBanki()[1].GetKlienci()[1].DodajKarte(0, 3232, "");

        }
    }
}
