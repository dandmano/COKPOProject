﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COKPOProject
{
    abstract class Klient
    {
        public readonly int IdKlienta;
        public readonly Bank BankKlienta;
        protected string NazwaKlienta;
        protected List<Karta> Karty = new List<Karta>();

        public List<Karta> GetKarty() => Karty;

        public string GetNazwa() => NazwaKlienta;

        public void SetNazwa(string Nazwa)
        {
            this.NazwaKlienta = Nazwa;
        }
        public void UsunKarte(int index)
        {
            if (index > 0 && index <= Karty.Count) Karty.RemoveAt(index - 1);
            else { }         //Dodac popup o błędnym indeksie
        }
        public void DodajKarte(int wybor)
        {
            switch (wybor)
            {
                case 1:
                    Karty.Add(new KartaDebetowa(this, BankKlienta));
                    break;
                case 2:
                    Karty.Add(new KartaKredytowa(this, BankKlienta));
                    break;
                case 3:
                    Karty.Add(new KartaBankomatowa(this, BankKlienta));
                    break;
            }
        }
        public virtual void RejestrujTransakcje(decimal Kwota, string NrKarty)
        {
            //Dodac pop-up w intefejscie graficznym z błedęm kart bankomatowej
        }
        public Klient(string NazwaKlienta, Bank BankKlienta)
        {
            this.NazwaKlienta = NazwaKlienta;
            this.BankKlienta = BankKlienta;
        }
    }

    class KlientCentrum : Klient
    {
        public KlientCentrum(string NazwaKlienta, Bank BankKlienta) : base(NazwaKlienta, BankKlienta) { }
        public override void RejestrujTransakcje(decimal Kwota, string NrKarty)
        {
            //Dodac rejestracje transakcji
        }
    }

    class KlientZwykly : Klient
    {
        public KlientZwykly(string NazwaKlienta, Bank BankKlienta) : base(NazwaKlienta, BankKlienta) { }
    }
}
