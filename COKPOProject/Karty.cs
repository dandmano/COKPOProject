using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace COKPOProject
{
    public abstract class Karta
    {
        public readonly string NrKarty;
        public decimal Saldo { get; set; }
        public readonly Bank BankWydajacy;
        public readonly Klient Wlasciciel;
        private static readonly Random Random = new Random();

        //Metoda porównująca kwotę z saldem i oceniająca czy transkacja jest możliwa
        public abstract bool CzyWystarczajaceSaldo(decimal Kwota);

        protected Karta(Klient Wlasciciel, Bank BankWydajacy)
        {
            this.Wlasciciel = Wlasciciel;
            this.BankWydajacy = BankWydajacy;
            this.NrKarty = LosujNumerKarty();
        }

        protected Karta(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo)
        {
            this.Wlasciciel = Wlasciciel;
            this.BankWydajacy = BankWydajacy;
            this.Saldo = Saldo;
            this.NrKarty = LosujNumerKarty();
        }

        protected Karta(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty)
        {
            this.Wlasciciel = Wlasciciel;
            this.BankWydajacy = BankWydajacy;
            this.Saldo = Saldo;
            this.NrKarty = NrKarty;
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
        public KartaDebetowa(Klient Wlasciciel, Bank BankWydajacy) : base(Wlasciciel, BankWydajacy) { }

        public KartaDebetowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo) : base(Wlasciciel, BankWydajacy, Saldo) { }

        public KartaDebetowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty) : base(Wlasciciel, BankWydajacy, Saldo, NrKarty) { }

        public override bool CzyWystarczajaceSaldo(decimal Kwota) => Kwota < Saldo;

    }




    public class KartaKredytowa : Karta
    {
        public decimal LimitKredytu { get; set; } = 5000;

        public KartaKredytowa(Klient Wlasciciel, Bank BankWydajacy) : base(Wlasciciel, BankWydajacy) { }

        public KartaKredytowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo) : base(Wlasciciel, BankWydajacy, Saldo) { }

        public KartaKredytowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty) : base(Wlasciciel, BankWydajacy, Saldo, NrKarty) { }

        public override bool CzyWystarczajaceSaldo(decimal Kwota) => Kwota < Saldo + LimitKredytu;
    }




    public class KartaBankomatowa : Karta
    {
        public KartaBankomatowa(Klient Wlasciciel, Bank BankWydajacy) : base(Wlasciciel, BankWydajacy) { }

        public KartaBankomatowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo) : base(Wlasciciel, BankWydajacy, Saldo) { }

        public KartaBankomatowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty) : base(Wlasciciel, BankWydajacy, Saldo, NrKarty) { }

        public override bool CzyWystarczajaceSaldo(decimal Kwota) => false;
    }
}
