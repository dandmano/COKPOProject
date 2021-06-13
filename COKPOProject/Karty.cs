using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace COKPOProject
{
    public abstract class Karta
    {
        public readonly string NrKarty;
        public decimal Saldo { get; private set; } = 0;
        public Bank BankWydajacy { get; private set; }
        public Klient Wlasciciel { get; private set; }
        private static readonly Random Random = new Random();

        protected Karta(Klient Wlasciciel, Bank BankWydajacy, decimal saldo, string nrkarty)
        {
            this.Wlasciciel = Wlasciciel;
            this.BankWydajacy = BankWydajacy;
            if (nrkarty == "" && saldo == -1) this.NrKarty = LosujNumerKarty();
            else if (nrkarty != "" && saldo == -1) this.NrKarty = nrkarty;
            else if (nrkarty != "" && saldo != -1)
            {
                this.NrKarty = nrkarty;
                this.Saldo = saldo;
            }
            else if (nrkarty == "" && saldo != -1)
            {
                this.NrKarty = LosujNumerKarty();
                this.Saldo = saldo;
            }
            else throw new Exception("Błąd przy tworzeniu karty");
        }

        //Metoda dokonująca zmiany salda (wplac wyplac)
        public void WplacLubWyplac(decimal kwota)
        {
            Saldo += kwota;
        }

        //Metoda porównująca kwotę z saldem i oceniająca czy transkacja jest możliwa
        public abstract bool CzyWystarczajaceSaldo(decimal Kwota);

        public void UstawBankKlient(Bank bank, Klient klient)
        {
            BankWydajacy = bank;
            Wlasciciel = klient;
        }

        //Wewnętrzna metoda losująca numer karty
        private static string LosujNumerKarty()
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 16).Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public override string ToString()
        {
            return NrKarty; //Do wypisywania w textboxach
        }
    }




    public class KartaDebetowa : Karta
    {
        [JsonConstructor]
        public KartaDebetowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty) : base(Wlasciciel, BankWydajacy, Saldo, NrKarty) { }

        public override bool CzyWystarczajaceSaldo(decimal Kwota) => Kwota <= Saldo;

    }




    public class KartaKredytowa : Karta
    {
        public decimal LimitKredytu { get; set; } = 5000;

        [JsonConstructor]
        public KartaKredytowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty) : base(Wlasciciel, BankWydajacy, Saldo, NrKarty) { }

        public override bool CzyWystarczajaceSaldo(decimal Kwota) => Kwota <= Saldo + LimitKredytu;
    }




    public class KartaBankomatowa : Karta
    {
        [JsonConstructor]
        public KartaBankomatowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty) : base(Wlasciciel, BankWydajacy, Saldo, NrKarty) { }

        public override bool CzyWystarczajaceSaldo(decimal Kwota) => false;
    }
}
