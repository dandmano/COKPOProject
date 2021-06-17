using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using COKPOProjectLogic;

namespace COKPOProjectTests
{
    [TestClass]
    public class Testy_Klient
    {
        [TestMethod]
        public void DodajKarte_ExpectedNewDebetCard()
        {
            var ct = MetodyDoTestow.StworzTestoweDane();
            ct.Banki[0].Klienci[0].DodajKarte(0, 150, "12345678910111");
            Assert.IsTrue(ct.Banki[0].Klienci[0].Karty[2].NrKarty == "12345678910111");
        }
        [TestMethod]
        public void DodajKarte_ExpectedNewCreditCard()
        {
            var ct = MetodyDoTestow.StworzTestoweDane();
            ct.Banki[0].Klienci[1].DodajKarte(1, 150, "12345678910112");
            Assert.IsTrue(ct.Banki[0].Klienci[1].Karty[2].NrKarty == "12345678910112");
        }
        [TestMethod]
        public void DodajKarte_ExpectedNewBankomatCard()
        {
            var ct = MetodyDoTestow.StworzTestoweDane();
            ct.Banki[1].Klienci[0].DodajKarte(2, 150, "12345678910112");
            Assert.IsTrue(ct.Banki[1].Klienci[0].Karty[2].NrKarty == "12345678910112");
        }
        [TestMethod]
        public void DodajKarte_ExpectedNewWrongIndexException()
        {
            var ct = MetodyDoTestow.StworzTestoweDane();
            try
            {
                ct.Banki[0].Klienci[1].DodajKarte(5, 150, "12345678910112");
            }
            catch (WrongIndexException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsTrue(false);
        }
    }
}
