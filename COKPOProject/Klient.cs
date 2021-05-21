using System;
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
        protected List<Karta> Karty;

        public List<Karta> getKarty() => Karty;

        public string getNazwa() => NazwaKlienta;

        public void setNazwa(string Nazwa)
        {
            this.NazwaKlienta = Nazwa;
        }
        public void usunKarte(int index)
        {
            //Dodac wyjatek!!!!
            Karty.Remove(Karty[index - 1]);
        }
        public void dodajKarte(int wybor)
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
