using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COKPOProjectLogic;
namespace COKPOProjectTests
{
    public static class MetodyDoTestow
    {
        public static CentrumTransakcji StworzTestoweDane()
        {
            var centrumTransakcji = new CentrumTransakcji();
            centrumTransakcji.DodajBank("Millenium");
            centrumTransakcji.DodajBank("Alior");
            centrumTransakcji.Banki[0].DodajKlienta("Jan Kowalski", 2);
            centrumTransakcji.Banki[0].Klienci[0].DodajKarte(0, 1500, "1111000099992222");
            centrumTransakcji.Banki[0].Klienci[0].DodajKarte(0, 25, "");
            centrumTransakcji.Banki[0].DodajKlienta("Mlekpol", 1);
            centrumTransakcji.Banki[0].Klienci[1].DodajKarte(1, 13000, "");
            centrumTransakcji.Banki[0].Klienci[1].DodajKarte(0, 50, "");
            centrumTransakcji.Banki[1].DodajKlienta("Leon Bober", 2);
            centrumTransakcji.Banki[1].Klienci[0].DodajKarte(0, 69, "");
            centrumTransakcji.Banki[1].Klienci[0].DodajKarte(1, 6969, "");
            centrumTransakcji.Banki[1].DodajKlienta("Adidasz", 1);
            centrumTransakcji.Banki[1].Klienci[1].DodajKarte(1, 1513214, "0000111122223333");
            centrumTransakcji.Banki[1].Klienci[1].DodajKarte(0, 3232, "");
            centrumTransakcji.DodajTransakcje((Firma)centrumTransakcji.Banki[0].Klienci[1], 690, centrumTransakcji.Banki[1].Klienci[0].Karty[1].NrKarty);
            centrumTransakcji.DodajTransakcje((Firma)centrumTransakcji.Banki[1].Klienci[1], 6969, centrumTransakcji.Banki[0].Klienci[0].Karty[0].NrKarty);
            return centrumTransakcji;
        }
    }
}
