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
        public readonly string NazwaFirmy;
        public bool StatusAutoryzacji { get; set; } = false;

        public Transakcja(Firma Firma, decimal Kwota, string NrKarty, int IdTransakcji)
        {
            this.Kwota = Kwota;
            this.Data = DateTime.Now;
            this.NrKarty = NrKarty;
            this.IdTransakcji = IdTransakcji;
            this.NazwaFirmy = Firma.NazwaKlienta;
        }

        public override string ToString()
        {
            return IdTransakcji.ToString();
        }
    }
}
