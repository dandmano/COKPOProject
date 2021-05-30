using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace COKPOProject
{
    public abstract class Karta
    {
        public readonly string NrKarty;
        protected decimal Saldo;
        public readonly Bank BankWydajacy;
        public readonly Klient Wlasciciel;
        private static Random random = new Random();

        public decimal GetSaldo() => Saldo;
        public void SetSaldo(decimal Kwota) { Saldo = Kwota; }
        public abstract bool CzyWystarczajaceSaldo(decimal Kwota);
        protected Karta(Klient Wlasciciel, Bank BankWydajacy)
        {
            this.Wlasciciel = Wlasciciel;
            this.BankWydajacy = BankWydajacy;
            this.NrKarty = this.LosujNumerKarty();
        }
        protected Karta(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo)
        {
            this.Wlasciciel = Wlasciciel;
            this.BankWydajacy = BankWydajacy;
            this.Saldo = Saldo;
            this.NrKarty = this.LosujNumerKarty();
        }
        protected Karta(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty)
        {
            this.Wlasciciel = Wlasciciel;
            this.BankWydajacy = BankWydajacy;
            this.Saldo = Saldo;
            this.NrKarty = NrKarty;
        }
        private string LosujNumerKarty()
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 16).Select(s => s[random.Next(s.Length)]).ToArray()); //sprawdzic czy dziala
        }

        public override string ToString()
        {
            return NrKarty;
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
        private decimal LimitKredytu = 5000;
        public KartaKredytowa(Klient Wlasciciel, Bank BankWydajacy) : base(Wlasciciel, BankWydajacy) { }

        public KartaKredytowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo) : base(Wlasciciel, BankWydajacy, Saldo) { }

        public KartaKredytowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty) : base(Wlasciciel, BankWydajacy, Saldo, NrKarty) { }
        public void SetLimitKredytu(decimal Kwota) { LimitKredytu = Kwota; }
        public decimal GetLimitKredytu() => LimitKredytu;
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
