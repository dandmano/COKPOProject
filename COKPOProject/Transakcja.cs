using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COKPOProject
{
    public class Transakcja
    {
        public readonly int IdTransakcji;
        public readonly decimal Kwota;
        public readonly DateTime Data;
        public readonly string NrKarty;
        public readonly string NrKartyFrimy;
        public readonly string NazwaFirmy;
        public bool StatusAutoryzacji { get; set; } = false;

        public Transakcja(Firma Firma, decimal Kwota, DateTime Data, string NrKarty, int IdTransakcji)
        {
            this.Kwota = Kwota;
            this.Data = Data;
            this.NrKarty = NrKarty;
            this.IdTransakcji = IdTransakcji;
            this.NrKartyFrimy = Firma.Karty[0].NrKarty;
            this.NazwaFirmy = Firma.NazwaKlienta;
        }
    }
}
