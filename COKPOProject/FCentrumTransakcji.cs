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
    public partial class FCentrumTransakcji : Form
    {
        private readonly CentrumTransakcji centrumTransakcji;

        //Konstruktor form
        public FCentrumTransakcji(Form OwnerForm, CentrumTransakcji centrumTransakcji)
        {
            this.centrumTransakcji = centrumTransakcji;
            InitializeComponent();
            Owner = OwnerForm;
        }

        //Odpala się przy otwieraniu forma
        private void FCentrumTransakcji_Load(object sender, EventArgs e)
        {
            this.Location = Owner.Location;
            UpdateBankList();
            UpdateTransactionList();
        }

        //
        //Metody użytkowe
        //

        //Odświeżanie/uzupełnianie listy banków
        private void UpdateBankList()
        {
            ListBoxBanks.BeginUpdate();
            ListBoxBanks.Items.Clear();
            foreach (var bank in centrumTransakcji.Banki)
            {
                ListBoxBanks.Items.Add(bank);
            }
            ListBoxBanks.EndUpdate();
        }
        //Odświeżanie/uzupełnianie listy transakcji
        private void UpdateTransactionList()
        {
            ListViewTransactions.Update();
            ListViewTransactions.Items.Clear();
            foreach (var transakcja in centrumTransakcji.Transakcje)
            {
                var item = new ListViewItem(transakcja.ToString());
                item.SubItems.Add(transakcja.Data.ToString("d"));
                item.SubItems.Add(transakcja.NazwaFirmy);
                item.SubItems.Add(transakcja.NrKarty);
                item.SubItems.Add(transakcja.Kwota.ToString("C"));
                item.SubItems.Add(transakcja.StatusAutoryzacji ? "Wykonana" : "Odrzucona");
                ListViewTransactions.Items.Add(item);
            }
            ListViewTransactions.EndUpdate();
        }

        //
        // Metody przycisków oraz wydarzeń
        //

        // Metoda przycisku - Dodaj Bank
        private void ButtonAddBank_Click(object sender, EventArgs e)
        {
            var fDodajBankPopUp = new FDodajBankPopUp();
            fDodajBankPopUp.ShowDialog();
            if (fDodajBankPopUp.DialogResult != DialogResult.OK) return;
            centrumTransakcji.DodajBank(fDodajBankPopUp.BankName);
            ListBoxBanks.Items.Add(centrumTransakcji.Banki.Last());
        }
        //Metoda przycisku - Usun Bank
        private void ButtonRemoveBank_Click(object sender, EventArgs e)
        {
            if (ListBoxBanks.SelectedItem != null)
            {
                centrumTransakcji.Banki.Remove((Bank)ListBoxBanks.SelectedItem);
                ListBoxBanks.Items.Remove(ListBoxBanks.SelectedItem);
            }
            else MessageBox.Show("Zaznacz bank który chcesz usunąć.", "Uwaga");
        }
        //Metoda przycisku - Edytuj nazwę Banku
        private void ButtonEditBank_Click(object sender, EventArgs e)
        {
            if (ListBoxBanks.SelectedItem != null)
            {
                var tmp = (Bank)ListBoxBanks.SelectedItem;
                var fDodajBankPopUp = new FDodajBankPopUp();
                fDodajBankPopUp.ChangeTextBoxValue(tmp.NazwaBanku);
                fDodajBankPopUp.ShowDialog();
                if (fDodajBankPopUp.DialogResult != DialogResult.OK) return;
                tmp.NazwaBanku = fDodajBankPopUp.BankName;
                UpdateBankList();
            }
            else MessageBox.Show("Zaznacz bank którego nazwę chcesz edytować.", "Uwaga!");
        }
        //Metoda przycisku - Przejdź do banku
        private void ButtonGoToBank_Click(object sender, EventArgs e)
        {
            if (ListBoxBanks.SelectedItem != null)
            {
                var fBank = new FBank((Bank)ListBoxBanks.SelectedItem, this);
                this.Hide();
                fBank.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wybierz bank do którego chcesz przejść.", "Uwaga!");
            }
        }
        //Metoda przycisku - autoryzuj transakcję
        private void ButtonAuthorizeTransaction_Click(object sender, EventArgs e)
        {
            var fDodajTransakcjePopUp = new FDodajTransakcjiePopUp(centrumTransakcji);
            fDodajTransakcjePopUp.ShowDialog();
            if (fDodajTransakcjePopUp.DialogResult != DialogResult.OK) return;
            UpdateTransactionList();
        }

        //Metoda przycisku - usuń transakcję z historii
        private void ButtonRemoveTransaction_Click(object sender, EventArgs e)
        {
            if (ListViewTransactions.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Wybierz transakcję którą chcesz usunąć.", "Uwaga!");
                return;
            }

            var tmp = ListViewTransactions.SelectedItems[0];
            try
            {
                centrumTransakcji.UsunTransakcje(int.Parse(tmp.Text));
                UpdateTransactionList();
            }
            catch (WrongIndexException ex)
            {
                MessageBox.Show($"{ex.Message} + Index = {ex.WrongIndex}", "Błąd!");
            }
        }

        //Metoda wydarzenia double click w listboxie banków 
        private void ListBoxBanks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ButtonGoToBank_Click(sender, e);
        }
    }
}
