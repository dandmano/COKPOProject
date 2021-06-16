using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace COKPOProjectLogic
{
    public class CentrumTransakcji
    {
        public List<Transakcja> Transakcje { get; }
        public List<Bank> Banki { get; }

        public CentrumTransakcji()
        {
            Transakcje = new List<Transakcja>();
            Banki = new List<Bank>();
        }

        //Metoda dodająca bank
        public void DodajBank(string NazwaBanku)
        {
            Banki.Add(new Bank(NazwaBanku));
        }


        //
        //Metody służące do dodawania i obłsugi transakcji
        //

        //Metoda dodająca transakcję
        public void DodajTransakcje(Firma Firma, decimal Kwota, string NrKarty)
        {
            var idtransakcji = 1;
            if (Transakcje.Count > 0) idtransakcji = Transakcje.Last().IdTransakcji + 1;
            try
            {
                var karta = ZnajdzKartePoNumerze(NrKarty);
                var tmp = new Transakcja(Firma, Kwota, NrKarty, idtransakcji, karta.BankWydajacy.NazwaBanku);
                AutoryzujTransakcje(tmp, karta);
            }
            catch (WrongCardNumberException exe)
            {
                throw exe;
            }
            catch (BankomatCardNotSupportedException exe)
            {
                throw exe;
            }
        }

        //Metoda usuwająca transkację
        public void UsunTransakcje(int IdTransakcji)
        {
            if (!Transakcje.Remove(GetTransakcjaWithID(IdTransakcji)))
            {
                throw new WrongIndexException("Nie ma transakcji o takim indexsie w liscie!", IdTransakcji);
            }
        }

        //Metoda Autoryzująca na podstawie wyniku metody SprawdzTransakcję
        public bool AutoryzujTransakcje(Transakcja T, Karta karta)
        {
            Transakcje.Add(T);
            if (karta.CzyWystarczajaceSaldo(T.Kwota))
            {
                karta.WplacLubWyplac((-1) * T.Kwota);
                T.StatusAutoryzacji = true;
                return true;
            }
            T.StatusAutoryzacji = false;
            return false;
        }

        //Metoda wyszukująca kartę po numerze
        private Karta ZnajdzKartePoNumerze(string NrKarty)
        {
            foreach (var karta in Banki.SelectMany(bank => bank.Klienci, (bank, klient) => klient.Karty.Find(x => x.NrKarty.Equals(NrKarty))).Where(karta => karta != null))
            {
                if (karta is KartaBankomatowa)
                    throw new BankomatCardNotSupportedException("Karta bankomatowa nie jest obsługiwana!", karta);
                return karta;
            }

            throw new WrongCardNumberException("Nie znaleziono karty o takim numerze!", NrKarty);
        }

        //Metoda znajdująca i zwracająca transakcję o podanym ID
        public Transakcja GetTransakcjaWithID(int IdTransakcji) => Transakcje.Find(x => x.IdTransakcji.Equals(IdTransakcji));

        //
        //Metoda pozwalająca przeszukiwać archiwum transakcji i jej metody pomocniczne
        //

        //Metoda przeszukująca główna
        public List<Transakcja> PrzeszukajTransakcje(int id, DateTime dataod, DateTime datado, bool czydata, decimal kwotaod, decimal kwotado, string nazwafirmy, string bankfirmy, string nrkarty, string bankklienta, bool status, bool czystatus)
        {
            var tmp = new List<Transakcja>(Transakcje);
        reset:
            foreach (var transakcja in tmp)
            {
                if (id != -1 && transakcja.IdTransakcji != id) { tmp.Remove(transakcja); goto reset; }
                if (czydata && ((transakcja.Data.Day < dataod.Day || transakcja.Data.Day > datado.Day) || (transakcja.Data.Year < dataod.Year || transakcja.Data.Year > datado.Year) || (transakcja.Data.Month < dataod.Month || transakcja.Data.Month > datado.Month))) { tmp.Remove(transakcja); goto reset; }
                if (transakcja.Kwota < kwotaod || transakcja.Kwota > kwotado) { tmp.Remove(transakcja); goto reset; }
                if (nazwafirmy != "" && transakcja.NazwaFirmy != nazwafirmy) { tmp.Remove(transakcja); goto reset; }
                if (nrkarty != "" && transakcja.NrKarty != nrkarty) { tmp.Remove(transakcja); goto reset; }
                if (bankfirmy != "" && transakcja.BankFirmy != bankfirmy) { tmp.Remove(transakcja); goto reset; }
                if (bankklienta != "" && transakcja.BankKlienta != bankklienta) { tmp.Remove(transakcja); goto reset; }
                if (czystatus && transakcja.StatusAutoryzacji != status) { tmp.Remove(transakcja); goto reset; }
                if (tmp.Count == 0) break;
            }
            return tmp;
        }

        //
        // Metody służące do zapisy i wczytywania danych z pliku
        //

        //Metoda służąca do wczytania danych z pliku o podanej ścieżcie i ich deserializacji
        public static CentrumTransakcji Wczytywanie(string filePath)
        {
            var tmp = new CentrumTransakcji();
            try
            {
                if (!File.Exists(filePath)) return tmp;
                tmp = JsonConvert.DeserializeObject<CentrumTransakcji>(File.ReadAllText(filePath),
                    new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.All
                    });
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
            foreach (var bank in tmp.Banki)
            {
                foreach (var klient in bank.Klienci)
                {
                    klient.UstawBank(bank);
                    foreach (var karta in klient.Karty)
                    {
                        karta.UstawBankKlient(bank, klient);
                    }
                }
            }
            return tmp;
        }

        //Metoda służąca do zapisywania danych do pliku o podanej ścieżcie i serializacji
        public void Zapisywanie(string filePath)
        {
            var tmp = JsonConvert.SerializeObject(this,
                new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    TypeNameHandling = TypeNameHandling.All
                });
            File.WriteAllText(filePath, tmp);
        }
    }
}
