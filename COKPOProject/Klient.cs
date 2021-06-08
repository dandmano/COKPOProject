using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COKPOProject
{
    public abstract class Klient
    {
        //public readonly int IdKlienta;
        public Bank BankKlienta { get; private set; }
        public string NazwaKlienta { get; set; }
        public List<Karta> Karty { get; } = new List<Karta>();

        protected Klient(string NazwaKlienta, Bank BankKlienta)
        {
            this.NazwaKlienta = NazwaKlienta;
            this.BankKlienta = BankKlienta;
        }

        //Metoda dodająca kartę do klienta mając typ karty (0-Debetowa,1-Kredytowa,2-Bankomatowa)
        public void DodajKarte(int wybor, decimal saldo, string nrkarty)
        {
            switch (wybor)
            {
                case 0:
                    DodajKarteDebetowa(saldo, nrkarty);
                    break;
                case 1:
                    DodajKarteKredytowa(saldo, nrkarty);
                    break;
                case 2:
                    DodajKarteBankomatowa(saldo, nrkarty);
                    break;
                default:
                    throw new WrongIndexException("Nie istnieje taki index przy tworzeniu karty", wybor);
            }
        }

        private void DodajKarteDebetowa(decimal saldo, string nrkarty)
        {
            if (nrkarty == "" && saldo == -1)
                Karty.Add(new KartaDebetowa(this, BankKlienta));
            else if (nrkarty != "" && saldo == -1)
                Karty.Add(new KartaDebetowa(this, BankKlienta, 0, nrkarty));
            else if (nrkarty != "" && saldo != -1)
                Karty.Add(new KartaDebetowa(this, BankKlienta, saldo, nrkarty));
            else if (nrkarty == "" && saldo != -1)
                Karty.Add(new KartaDebetowa(this, BankKlienta, saldo));
            else throw new Exception("Błąd przy tworzeniu karty");
        }

        private void DodajKarteKredytowa(decimal saldo, string nrkarty)
        {
            if (nrkarty == "" && saldo == -1)
                Karty.Add(new KartaKredytowa(this, BankKlienta));
            else if (nrkarty != "" && saldo == -1)
                Karty.Add(new KartaKredytowa(this, BankKlienta, 0, nrkarty));
            else if (nrkarty != "" && saldo != -1)
                Karty.Add(new KartaKredytowa(this, BankKlienta, saldo, nrkarty));
            else if (nrkarty == "" && saldo != -1)
                Karty.Add(new KartaKredytowa(this, BankKlienta, saldo));
            else throw new Exception("Błąd przy tworzeniu karty");
        }

        private void DodajKarteBankomatowa(decimal saldo, string nrkarty)
        {
            if (nrkarty == "" && saldo == -1)
                Karty.Add(new KartaBankomatowa(this, BankKlienta));
            else if (nrkarty != "" && saldo == -1)
                Karty.Add(new KartaBankomatowa(this, BankKlienta, 0, nrkarty));
            else if (nrkarty != "" && saldo != -1)
                Karty.Add(new KartaBankomatowa(this, BankKlienta, saldo, nrkarty));
            else if (nrkarty == "" && saldo != -1)
                Karty.Add(new KartaBankomatowa(this, BankKlienta, saldo));
            else throw new Exception("Błąd przy tworzeniu karty");
        }

        public void UstawBank(Bank bank)
        {
            BankKlienta = bank;
        }

        public override string ToString()
        {
            return NazwaKlienta; //Do wypisywania w textboxach
        }
    }



    public class Firma : Klient
    {
        public Firma(string NazwaKlienta, Bank BankKlienta) : base(NazwaKlienta, BankKlienta) { }
    }



    public class ZwyklyKlient : Klient
    {
        public ZwyklyKlient(string NazwaKlienta, Bank BankKlienta) : base(NazwaKlienta, BankKlienta) { }
    }
}
