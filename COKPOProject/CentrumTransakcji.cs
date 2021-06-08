using System;
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
        public Transakcja GetTransakcja(int IdTransakcji) => Transakcje.Find(x => x.IdTransakcji.Equals(IdTransakcji)); //Obsluzyc?


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

        //Metoda sprawdzająca czy stan na koncie karty jest wystarczający/ czy można wykonać transakcję (karta bankomatowa nie wspierana)
        private bool SprawdzTransakcje(Transakcja T)
        {
            try
            {
                var karta = ZnajdzKartePoNumerze(T.NrKarty);
                return karta.CzyWystarczajaceSaldo(T.Kwota);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message, "Uwaga!");
                throw exe;
            }

        }

        //Metoda wyszukująca kartę po numerze
        private Karta ZnajdzKartePoNumerze(string NrKarty)
        {
            foreach (var karta in Banki.SelectMany(bank => bank.Klienci, (bank, klient) => klient.Karty.Find(x => x.NrKarty.Equals(NrKarty))).Where(karta => karta != null))
            {
                return karta;
            }

            throw new Exception("Nie znaleziono karty o takim numerze!");
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
