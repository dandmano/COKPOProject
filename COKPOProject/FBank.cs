using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COKPOProject
{
    public partial class FBank : Form
    {
        private readonly Bank bank;
        private readonly FCentrumTransakcji previusform;

        //Konstruktor Forma
        public FBank(Bank bank, FCentrumTransakcji fCentrumTransakcji)
        {
            this.bank = bank;
            this.previusform = fCentrumTransakcji;
            InitializeComponent();
            LabelBank.Text = bank.GetNazwaBanku();
            UpdateClientList();
        }

        //Metoda uruchamiająca się przy ładowaniu
        private void FBank_Load(object sender, EventArgs e)
        {
            LabelBank.Text = bank.GetNazwaBanku();
            UpdateClientList();
        }

        //
        //Metody użytkowe
        //

        //Metoda aktualizująca/uzupełniająca listę klientów
        private void UpdateClientList()
        {
            ListBoxClients.Update();
            ListBoxClients.Items.Clear();
            foreach (var klient in bank.GetKlienci())
            {
                ListBoxClients.Items.Add(klient);
            }
            ListBoxClients.EndUpdate();
        }

        //
        // Metody przycisków oraz wydarzeń
        //

        //Metoda przycisku - Wstecz
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            previusform.Show();
            this.Close();
        }

        //Metoda przycisku - Wszyscy Klienci
        private void ButtonAllClients_Click(object sender, EventArgs e)
        {
            UpdateClientList();
        }

        //Metoda przycisku - Zwykli Klienci
        private void ButtonNormalClient_Click(object sender, EventArgs e)
        {
            ListBoxClients.Update();
            ListBoxClients.Items.Clear();
            foreach (var klient in bank.GetKlienci())
            {
                if (klient is KlientZwykly)
                    ListBoxClients.Items.Add(klient);
            }
            ListBoxClients.EndUpdate();
        }

        //Metoda przycisku - Klienci Centrum
        private void ButtonClientCentrum_Click(object sender, EventArgs e)
        {
            ListBoxClients.Update();
            ListBoxClients.Items.Clear();
            foreach (var klient in bank.GetKlienci())
            {
                if (klient is KlientCentrum)
                    ListBoxClients.Items.Add(klient);
            }
            ListBoxClients.EndUpdate();
        }

        //Metoda przycisku - Przejdź do klienta
        private void ButtonGoToClient_Click(object sender, EventArgs e)
        {
            if (ListBoxClients.SelectedItem != null)
            {
                var fKlient = new FKlient((Klient)ListBoxClients.SelectedItem, this);
                this.Hide();
                fKlient.ShowDialog();
            }
            else MessageBox.Show("Wybierz klienta do którego chcesz przejść");
        }

        //Metoda przycisku - Dodaj Klienta
        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                var fDodajKlientaPopUp = new FDodajKlientaPopUp(bank);
                fDodajKlientaPopUp.ShowDialog();
                UpdateClientList();
            }
            catch
            {
                //XD
            }
        }

        //Metoda przycisku - Usuń Klienta
        private void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (ListBoxClients.SelectedItem != null)
            {
                bank.GetKlienci().Remove((Klient)ListBoxClients.SelectedItem);
                ListBoxClients.Update();
                ListBoxClients.Items.Remove(ListBoxClients.SelectedItem);
                ListBoxClients.EndUpdate();
            }
            else
            {
                MessageBox.Show("Wybierz klienta którego chcesz usunąć.");
            }
        }

        //Metoda przycisku - Zmień nazwę klienta
        private void ButtonChangeClientsName_Click(object sender, EventArgs e)
        {
            if (ListBoxClients.SelectedItem != null)
            {
                try
                {
                    var tmp = bank.GetKlienci().Find(x => x == (Klient)ListBoxClients.SelectedItem);
                    var f = new FDodajBankPopUp();
                    f.ChangeTextBoxTextValue("Wpisz nazwę klienta");
                    f.ShowDialog();
                    tmp.SetNazwa(f.ReturnBankName());
                    ListBoxClients.Update();
                    ListBoxClients.Items.Remove(ListBoxClients.SelectedItem);
                    ListBoxClients.Items.Add(tmp);
                    ListBoxClients.EndUpdate();
                }
                catch
                {
                    //XD
                }
            }
            else
            {
                MessageBox.Show("Wybierz klienta którego nazwę chcesz edytować.");
            }
        }
    }
}
