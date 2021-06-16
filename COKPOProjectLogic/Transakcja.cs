using Newtonsoft.Json;
using System;

namespace COKPOProjectLogic
{
    public class Transakcja
    {
        public readonly int IdTransakcji;
        public readonly decimal Kwota;
        public readonly DateTime Data;
        public readonly string NrKarty;
        public readonly string BankFirmy;
        public readonly string BankKlienta;
        public readonly string NazwaFirmy;
        public bool StatusAutoryzacji { get; set; } = false;

        public Transakcja(Firma Firma, decimal Kwota, string NrKarty, int IdTransakcji, string BankKlienta)
        {
            this.Kwota = Kwota;
            this.Data = DateTime.Now;
            this.NrKarty = NrKarty;
            this.IdTransakcji = IdTransakcji;
            this.NazwaFirmy = Firma.NazwaKlienta;
            this.BankFirmy = Firma.BankKlienta.NazwaBanku;
            this.BankKlienta = BankKlienta;
        }
        [JsonConstructor]
        public Transakcja(int IdTransakcji, decimal Kwota, DateTime Data, string NrKarty, string BankFirmy, string BankKlienta, string NazwaFirmy)
        {
            this.IdTransakcji = IdTransakcji;
            this.Kwota = Kwota;
            this.Data = Data;
            this.NrKarty = NrKarty;
            this.BankFirmy = BankFirmy;
            this.BankKlienta = BankKlienta;
            this.NazwaFirmy = NazwaFirmy;
        }

        public override string ToString()
        {
            return IdTransakcji.ToString();
        }
    }
}
