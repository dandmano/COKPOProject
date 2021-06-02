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
            UpdateBankList();
            Owner = OwnerForm;
        }

        //Odpala się przy otwieraniu forma
        private void FCentrumTransakcji_Load(object sender, EventArgs e)
        {
            this.Location = Owner.Location;
            UpdateBankList();
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

        //
        // Metody przycisków
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
    }
}
