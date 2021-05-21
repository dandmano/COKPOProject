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
        public readonly Bank BankKlienta; //UWAGA BłĄD TYMCZASOWY (BANK)
        protected string NazwaKlienta;
        protected List<Karta> Karty; //UWAGA BŁĄD TYMCZASOWY (KARTA)

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
        public void dodajKarte()
        {
            //Uzupełnić po napisaniu klasy KARTA!!!  
        }
        public virtual void RejestrujTransakcje(decimal Kwota, string NrKarty) { }
    }
}
