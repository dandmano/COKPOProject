using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COKPOProject
{
    class CentrumTransakcji
    {
        private List<Transakcja> Transakcje;
        private List<Bank> Banki;

        public CentrumTransakcji()
        {
            Transakcje = new List<Transakcja>();
            Banki = new List<Bank>();
        }
        public Transakcja GetTransakcja(int IdTransakcji) => Transakcje.Find(x => x.IdTransakcji.Equals(IdTransakcji));

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

        private bool SprawdzTransakcje(Transakcja T)
        {
            Karta karta = ZnajdzKartePoNumerze(T.NrKarty);
            return karta.CzyWystarczajaceSaldo(T.Kwota);
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
