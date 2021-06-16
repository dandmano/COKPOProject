using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace COKPOProjectTests
{
    [TestClass]
    public class Testy_Bank
    {

        [TestMethod]
        public void DodajBank_ExpectedExisitngKlient()
        {
            var ct = MetodyDoTestow.StworzTestoweDane();
            ct.Banki[0].DodajKlienta("Rysiek z klanu", 0, 0, 1200, "");
            Assert.IsTrue(ct.Banki[0].Klienci[2].NazwaKlienta == "Rysiek z klanu");
        }
    }
}
