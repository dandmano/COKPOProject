using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COKPOProject
{
    class Transakcja
    {
        public readonly int IdTransakcji;
        public readonly decimal Kwota;
        public readonly DateTime Data;
        public readonly string NrKarty;
        public readonly string NrKartyFrimy;
        public readonly int IdFirmy;
        public readonly int IdWlasciciela;
        private bool StatusAutoryzacji = false;

        public Transakcja(KlientCentrum Firma, decimal Kwota, DateTime Data, string NrKarty)
        {
            this.Kwota = Kwota;
            this.Data = Data;
            this.NrKarty = NrKarty;
            this.NrKartyFrimy = Firma.GetKarty()[0].NrKarty;
        }

        public bool GetStatus() => StatusAutoryzacji;
        public void SetStatus(bool Status) { this.StatusAutoryzacji = Status; }
    }
}
