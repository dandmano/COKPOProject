using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace COKPOProject
{
    abstract class Karta
    {
        public readonly string NrKarty;
        protected decimal Saldo;
        public readonly Bank BankWydajacy;
        public readonly Klient Wlasciciel;

        public decimal GetSaldo() => Saldo;
        public void SetSaldo(decimal Kwota) { Saldo = Kwota; }
        public abstract bool CzyWystarczajaceSaldo(decimal Kwota);
        public Karta(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty)
        {
            this.Wlasciciel = Wlasciciel;
            this.BankWydajacy = BankWydajacy;
            this.Saldo = Saldo;
            this.NrKarty = NrKarty;
        }
    }

    class KartaDebetowa : Karta
    {
        public KartaDebetowa(Klient Wlasciciel, Bank BankWydajacy)
        {
            this.Wlasciciel = Wlasciciel;
            this.BankWydajacy = BankWydajacy;
        }
        public KartaDebetowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo)
        {
            this.Wlasciciel = Wlasciciel;
            this.BankWydajacy = BankWydajacy;
            this.Saldo = Saldo;
        }
        public KartaDebetowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty) : base(Wlasciciel, BankWydajacy, Saldo, NrKarty)
        {

        }
        public override bool CzyWystarczajaceSaldo(decimal Kwota)
        {

        }
    }

    class KartaKredytowa : Karta
    {
        private decimal LimitKredytu;
        public KartaKredytowa(Klient Wlasciciel, Bank BankWydajacy)
        {

        }
        public KartaKredytowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo)
        {

        }
        public KartaKredytowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty)
        {

        }
        public void SetLimitKredytu(decimal Kwota) { LimitKredytu = Kwota; }
        public decimal GetLimitKredytu() => LimitKredytu;
        public override bool CzyWystarczajaceSaldo(decimal Kwota)
        {

        }
    }

    class KartaBankomatowa : Karta
    {
        public KartaBankomatowa(Klient Wlasciciel, Bank BankWydajacy)
        {

        }
        public KartaBankomatowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo)
        {

        }
        public KartaBankomatowa(Klient Wlasciciel, Bank BankWydajacy, decimal Saldo, string NrKarty)
        {

        }
        public override bool CzyWystarczajaceSaldo(decimal Kwota)
        {

        }
    }
}
