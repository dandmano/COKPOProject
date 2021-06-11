﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace COKPOProject
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

        //Metoda znajdująca i zwracająca transakcję o podanym ID
        public Transakcja GetTransakcjaWithID(int IdTransakcji) => Transakcje.Find(x => x.IdTransakcji.Equals(IdTransakcji)); //Obsluzyc?

        //Metoda usuwająca transkację
        public void UsunTransakcje(int IdTransakcji)
        {
            if (!Transakcje.Remove(GetTransakcjaWithID(IdTransakcji))) throw new WrongIndexException("Nie ma transakcji o takim indexsie w liscie!", IdTransakcji);
        }

        //Metoda Autoryzująca na podstawie wyniku metody SprawdzTransakcję
        public bool AutoryzujTransakcje(Transakcja T)
        {
            Transakcje.Add(T);
            if (SprawdzTransakcje(T))
            {
                T.StatusAutoryzacji = true;
                return true;
            }
            T.StatusAutoryzacji = false;
            return false;
        }

        public void DodajBank(string NazwaBanku)
        {
            Banki.Add(new Bank(NazwaBanku));
        }

        public bool DodajTransakcje(Firma Firma, decimal Kwota, string NrKarty)
        {
            var idtransakcji = 1;
            if (Transakcje.Count > 0) idtransakcji = Transakcje.Last().IdTransakcji + 1;
            var tmp = new Transakcja(Firma, Kwota, NrKarty, idtransakcji);
            return AutoryzujTransakcje(tmp);
        }

        //Metoda sprawdzająca czy stan na koncie karty jest wystarczający/ czy można wykonać transakcję (karta bankomatowa nie wspierana)
        private bool SprawdzTransakcje(Transakcja T)
        {
            try
            {
                var karta = ZnajdzKartePoNumerze(T.NrKarty);
                return karta.CzyWystarczajaceSaldo(T.Kwota);
            }
            catch (WrongCardNumberException exe)
            {
                MessageBox.Show(exe.Message + " Nr karty = " + exe.WrongCardNumber, "Uwaga!");
            }
            catch (BankomatCardNotSupportedException exe)
            {
                MessageBox.Show(exe.Message + " Nr karty = " + exe.WrongCard, "Uwaga!");
            }

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
                Console.WriteLine(exception);
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
        public void Zapisywanie(string filePath)
        {
            var xd = JsonConvert.SerializeObject(this,
                new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    TypeNameHandling = TypeNameHandling.All
                });
            File.WriteAllText(filePath, xd);
        }


    }
}
