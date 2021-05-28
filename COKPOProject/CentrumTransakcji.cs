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
        private List<Transakcja> Transakcje;
        private List<Bank> Banki;

        public CentrumTransakcji()
        {
            Transakcje = new List<Transakcja>();
            Banki = new List<Bank>();
        }
        public Transakcja GetTransakcja(int IdTransakcji) => Transakcje.Find(x => x.IdTransakcji.Equals(IdTransakcji)); //Obsluzyc?

        public List<Transakcja> GetTransakcje() => Transakcje;

        public bool AutoryzujTransakcje(Transakcja T)
        {
            Transakcje.Add(T);
            if (SprawdzTransakcje(T))
            {
                T.SetStatus(true);
                return true;
            }
            else
            {
                T.SetStatus(false);
                return false;
            }
        }

        public void DodajBank(string NazwaBanku)
        {
            Bank bank = new Bank(NazwaBanku);
            Banki.Add(bank);
        }

        public List<Bank> GetBanki() => Banki;

        private bool SprawdzTransakcje(Transakcja T)
        {
            Karta karta;
            try
            {
                karta = ZnajdzKartePoNumerze(T.NrKarty);
                return karta.CzyWystarczajaceSaldo(T.Kwota);
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie znaleziono karty o takim numerze z transakcji!");
                throw new Exception("Nie znaleziono karty o takim numerze!");
            }

        }
        private Karta ZnajdzKartePoNumerze(string NrKarty)
        {
            foreach (Bank bank in Banki)
            {
                foreach (Klient klient in bank.GetKlienci())
                {
                    Karta karta = klient.GetKarty().Find(x => x.NrKarty.Equals(NrKarty));
                    if (karta != null) return karta;
                }
            }
            throw new Exception("Nie znaleziono banku!");
        }
    }
}
