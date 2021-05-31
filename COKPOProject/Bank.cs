using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COKPOProject
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
                    Klienci.Add(new KlientCentrum(nazwa, this));
                    break;
                case 2:
                    Klienci.Add(new KlientZwykly(nazwa, this));
                    break;
            }
        }
        public void UsunKlienta(Klient klient)
        {
            Klienci.Remove(klient);
        }
        public override string ToString()
        {
            return NazwaBanku; //Do wyswietlania na listachboxach
        }
    }
}
