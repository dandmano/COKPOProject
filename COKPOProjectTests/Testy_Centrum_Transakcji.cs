using System;
using COKPOProjectLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace COKPOProjectTests
{
    [TestClass]
    public class Testy_Centrum_Transakcji
    {
        [TestMethod]
        public void DodajBank_ExpectedExistingBankInList()
        {
            // Arrange
            var testowe_centrum = new CentrumTransakcji();
            // Act
            testowe_centrum.DodajBank("Bank_Testowy");
            // Assert
            Assert.IsTrue(testowe_centrum.Banki[0].NazwaBanku == "Bank_Testowy");
        }
        [TestMethod]
        public void DodajTransakcje_ExpectedTransactionInList()
        {
            var testowe_centrum = MetodyDoTestow.StworzTestoweDane();
            testowe_centrum.DodajTransakcje((Firma)testowe_centrum.Banki[0].Klienci[1], (decimal)100.50, "1111000099992222");
            Assert.IsTrue(testowe_centrum.Transakcje[0].BankFirmy == "Millenium");
        }
        [TestMethod]
        public void DodajTransakcje_ExpectedWrongCardNumberException()
        {
            var testowe_centrum = MetodyDoTestow.StworzTestoweDane();
            try
            {
                testowe_centrum.DodajTransakcje((Firma)testowe_centrum.Banki[0].Klienci[1], (decimal)100.50, "1234000099992222");
            }
            catch (WrongCardNumberException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsTrue(false);
        }
    }
}
