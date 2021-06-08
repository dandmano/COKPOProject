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
            LabelBank.Text = bank.NazwaBanku;
            UpdateClientList();
        }

        //Metoda uruchamiająca się przy ładowaniu
        private void FBank_Load(object sender, EventArgs e)
        {
            this.Location = previusform.Location;
            LabelBank.Text = bank.NazwaBanku;
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
            foreach (var klient in bank.Klienci)
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
            previusform.Location = this.Location;
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
            foreach (var klient in bank.Klienci.OfType<ZwyklyKlient>())
            {
                ListBoxClients.Items.Add(klient);
            }
            ListBoxClients.EndUpdate();
        }

        //Metoda przycisku - Klienci Centrum
        private void ButtonFirm_Click(object sender, EventArgs e)
        {
            ListBoxClients.Update();
            ListBoxClients.Items.Clear();
            foreach (var klient in bank.Klienci.OfType<Firma>())
            {
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
            else MessageBox.Show("Wybierz klienta do którego chcesz przejść", "Uwaga!");
        }

        //Metoda przycisku - Dodaj Klienta
        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            var fDodajKlientaPopUp = new FDodajKlientaPopUp(bank);
            fDodajKlientaPopUp.ShowDialog();
            if (fDodajKlientaPopUp.DialogResult != DialogResult.OK) return;
            UpdateClientList();
        }

        //Metoda przycisku - Usuń Klienta
        private void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (ListBoxClients.SelectedItem != null)
            {
                try
                {
                    bank.UsunKlienta((Klient)ListBoxClients.SelectedItem);
                    ListBoxClients.Items.Remove(ListBoxClients.SelectedItem);
                }
                catch (ClientDoesNotExistException ex)
                {
                    MessageBox.Show("Nie istnieje klient o nazwie: " + ex.NotExistingClient.NazwaKlienta, "Uwaga!");
                }
            }
            else
            {
                MessageBox.Show("Wybierz klienta którego chcesz usunąć.", "Uwaga");
            }
        }

        //Metoda przycisku - Zmień nazwę klienta
        private void ButtonChangeClientsName_Click(object sender, EventArgs e)
        {
            if (ListBoxClients.SelectedItem != null)
            {

                var tmp = (Klient)ListBoxClients.SelectedItem;
                var f = new FDodajBankPopUp("Wpisz nazwę klienta");
                f.ChangeTextBoxValue(tmp.NazwaKlienta);
                f.ShowDialog();
                if (f.DialogResult != DialogResult.OK) return;
                tmp.NazwaKlienta = f.BankName;
                ListBoxClients.Items.Remove(ListBoxClients.SelectedItem);
                ListBoxClients.Items.Add(tmp);
            }
            else
            {
                MessageBox.Show("Wybierz klienta którego nazwę chcesz edytować.", "Uwaga");
            }
        }

        //Metoda wydarzenia double mouse click w liście klientów
        private void ListBoxClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ButtonGoToClient_Click(sender, e);
        }
    }
}
