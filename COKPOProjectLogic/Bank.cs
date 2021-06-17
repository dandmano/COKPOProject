using System.Collections.Generic;

namespace COKPOProjectLogic
{
    public class Bank
    {
        public string NazwaBanku { get; set; }

        public List<Klient> Klienci { get; } = new List<Klient>();

        public Bank(string nazwa)
        {
            this.NazwaBanku = nazwa;
        }

        //Metoda dodająca klienta wiedząc jaki typ to mam być (1-Klient Centrum, 2-Zwykly Klient)
        public void DodajKlienta(string nazwa, int wybor, int wyborkarty, decimal saldo, string nrkarty)
        {
            switch (wybor)
            {
                case 0:
                    var klient = new ZwyklyKlient(nazwa, this);
                    klient.DodajKarte(wyborkarty, saldo, nrkarty);
                    Klienci.Add(klient);
                    break;
                case 1:
                    var klient2 = new Firma(nazwa, this);
                    klient2.DodajKarte(wyborkarty, saldo, nrkarty);
                    Klienci.Add(klient2);
                    break;
                default:
                    throw new WrongIndexException("Nie istnieje taki index w dodaj klienta!", wybor);
            }
        }
        public void UsunKlienta(Klient klient)
        {
            if (!Klienci.Remove(klient)) throw new ClientDoesNotExistException(klient);
        }
        public override string ToString()
        {
            return NazwaBanku; //Do wyswietlania na listachboxach
        }
    }
}
