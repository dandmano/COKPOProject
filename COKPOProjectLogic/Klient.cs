using System.Collections.Generic;

namespace COKPOProjectLogic
{
    public abstract class Klient
    {
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
                    Karty.Add(new KartaDebetowa(this, BankKlienta, saldo, nrkarty));
                    break;
                case 1:
                    Karty.Add(new KartaKredytowa(this, BankKlienta, saldo, nrkarty));
                    break;
                case 2:
                    Karty.Add(new KartaBankomatowa(this, BankKlienta, saldo, nrkarty));
                    break;
                default:
                    throw new WrongIndexException("Nie istnieje taki index przy tworzeniu karty", wybor);
            }
        }

        public void UstawBank(Bank bank)
        {
            BankKlienta = bank;
        }

        public override string ToString()
        {
            return NazwaKlienta; //Do wypisywania w textboxach
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Klient)) return false;
            var tmp = obj as Klient;
            return tmp.NazwaKlienta.Equals(this.NazwaKlienta);
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
