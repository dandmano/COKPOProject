using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COKPOProject
{
    public class CentrumTransakcji
    {
        public List<Transakcja> Transakcje { get; }
        public List<Bank> Banki { get; }

        public CentrumTransakcji()
        {
            Transakcje = new List<Transakcja>();
            Banki = new List<Bank>();
        }

        //Metoda znajdująca i zwracająca transakcję o podanym ID
        public Transakcja GetTransakcja(int IdTransakcji) => Transakcje.Find(x => x.IdTransakcji.Equals(IdTransakcji)); //Obsluzyc?


        //Metoda Autoryzująca na podstawie wyniku metody SprawdzTransakcję
        public bool AutoryzujTransakcje(Transakcja T)
        {
            Transakcje.Add(T);
            if (SprawdzTransakcje(T))
            {
                T.StatusAutoryzacji = true;
                return true;
            }
            T.StatusAutoryzacji = false;
            return false;
        }

        public void DodajBank(string NazwaBanku)
        {
            Banki.Add(new Bank(NazwaBanku));
        }

        //Metoda sprawdzająca czy stan na koncie karty jest wystarczający/ czy można wykonać transakcję (karta bankomatowa nie wspierana)
        private bool SprawdzTransakcje(Transakcja T)
        {
            try
            {
                var karta = ZnajdzKartePoNumerze(T.NrKarty);
                return karta.CzyWystarczajaceSaldo(T.Kwota);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message, "Uwaga!");
                throw exe;
            }

        }

        //Metoda wyszukująca kartę po numerze
        private Karta ZnajdzKartePoNumerze(string NrKarty)
        {
            foreach (var karta in Banki.SelectMany(bank => bank.Klienci, (bank, klient) => klient.Karty.Find(x => x.NrKarty.Equals(NrKarty))).Where(karta => karta != null))
            {
                return karta;
            }

            throw new Exception("Nie znaleziono karty o takim numerze!");
        }
    }
}
