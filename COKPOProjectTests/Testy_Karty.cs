using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace COKPOProjectTests
{
    [TestClass]
    public class Testy_Karty
    {
        [TestMethod]
        public void WplacLubWyplac_ExpectedCorrectValueChange()
        {
            var ct = MetodyDoTestow.StworzTestoweDane();
            var tmp = ct.Banki[0].Klienci[0].Karty[0].Saldo;
            ct.Banki[0].Klienci[0].Karty[0].WplacLubWyplac(30);
            ct.Banki[0].Klienci[0].Karty[0].WplacLubWyplac(-20);
            Assert.IsTrue(tmp + 10 == ct.Banki[0].Klienci[0].Karty[0].Saldo);
        }
        [TestMethod]
        public void CzyWystarczajaceSaldo_ExpectedTrue()
        {
            var ct = MetodyDoTestow.StworzTestoweDane();
            Assert.IsTrue(ct.Banki[0].Klienci[0].Karty[0].CzyWystarczajaceSaldo(1500));
        }
        [TestMethod]
        public void CzyWystarczajaceSaldo_ExpectedFalse()
        {
            var ct = MetodyDoTestow.StworzTestoweDane();
            Assert.IsFalse(ct.Banki[0].Klienci[0].Karty[0].CzyWystarczajaceSaldo(1600));
        }
    }

}
