﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COKPOProject
{
    public class Bank
    {
        //public int IdBanku;
        private List<Klient> Klienci = new List<Klient>();
        private string NazwaBanku;

        public Bank(string nazwa)
        {
            this.NazwaBanku = nazwa;
        }
        public void DodajKlienta(string nazwa, int wybor)
        {
            if (wybor == 1) Klienci.Add(new KlientCentrum(nazwa, this));
            if (wybor == 2) Klienci.Add(new KlientZwykly(nazwa, this));
        }
        public void UsunKlienta(int idx)
        {
            if (idx > 0 && idx <= Klienci.Count) Klienci.RemoveAt(idx - 1);
            else { } //Dodać popup informujący o złej wartości indeksu 
        }
        public void UsunKlienta(Klient klient)
        {
            Klienci.Remove(klient);
        }
        public List<Klient> GetKlienci()
        {
            return Klienci;
        }
        public string GetNazwaBanku()
        {
            return NazwaBanku;
        }
        public void SetNazwaBanku(string nazwa)
        {
            this.NazwaBanku = nazwa;
        }
        public override string ToString()
        {
            return NazwaBanku; //Do edycji z ID
        }

    }
}
