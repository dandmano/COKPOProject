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
        public void DodajKlienta(string nazwa, int wybor)
        {
            switch (wybor)
            {
                case 1:
                    Klienci.Add(new Firma(nazwa, this));
                    break;
                case 2:
                    Klienci.Add(new ZwyklyKlient(nazwa, this));
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
