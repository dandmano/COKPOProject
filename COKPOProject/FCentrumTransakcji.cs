using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using COKPOProjectLogic;

namespace COKPOProject
{
    public partial class FCentrumTransakcji : Form
    {
        private readonly CentrumTransakcji centrumTransakcji;
        //Zmienne do Filtrowania :
        private int id = -1;
        private bool czyData = false;
        private decimal kwotaMinimum = -1;
        private decimal kwotaMaksimum = 9999999999999;
        private string nazwaFirmy = "";
        private string nazwaBankuFirmy = "";
        private string nrKarty = "";
        private string nazwaBankuKlienta = "";
        private bool czyStatus = false;
        private bool status = false;

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
            ResetFilterVariables();
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
                item.SubItems.Add(transakcja.Kwota.ToString("C"));
                item.SubItems.Add(transakcja.NazwaFirmy);
                item.SubItems.Add(transakcja.BankFirmy);
                item.SubItems.Add(transakcja.NrKarty);
                item.SubItems.Add(transakcja.BankKlienta);
                item.SubItems.Add(transakcja.StatusAutoryzacji ? "Zaakceptowana" : "Odrzucona");
                ListViewTransactions.Items.Add(item);
            }
            ListViewTransactions.Items.
            ListViewTransactions.EndUpdate();
        }
        //Odświeżanie/uzupełnianie tymczasowej listy transakcji służącej do przeszukiwania archiwum
        private void UpdateFilteredTransactionList(List<Transakcja> tmp)
        {
            ListViewTransactions.Update();
            ListViewTransactions.Items.Clear();
            foreach (var transakcja in tmp)
            {
                var item = new ListViewItem(transakcja.ToString());
                item.SubItems.Add(transakcja.Data.ToString("d"));
                item.SubItems.Add(transakcja.Kwota.ToString("C"));
                item.SubItems.Add(transakcja.NazwaFirmy);
                item.SubItems.Add(transakcja.BankFirmy);
                item.SubItems.Add(transakcja.NrKarty);
                item.SubItems.Add(transakcja.BankKlienta);
                item.SubItems.Add(transakcja.StatusAutoryzacji ? "Zaakceptowana" : "Odrzucona");
                ListViewTransactions.Items.Add(item);
            }
            ListViewTransactions.EndUpdate();
        }

        //Resetowanie wartości filtrów
        private void ResetFilterVariables()
        {
            this.id = -1;
            this.czyData = false;
            this.kwotaMinimum = -1;
            this.kwotaMaksimum = 9999999999999;
            this.nazwaFirmy = "";
            this.nazwaBankuFirmy = "";
            this.nrKarty = "";
            this.nazwaBankuKlienta = "";
            this.czyStatus = false;
            this.status = false;
            TextBoxId.Text = "";
            TextBoxCardNumber.Text = "";
            TextBoxFirmsBank.Text = "";
            TextBoxFirmsBank.Text = "";
            TextBoxFirmName.Text = "";
            TextBoxHigherAmount.Text = "";
            TextBoxLowerAmount.Text = "";
            TextBoxClientsBank.Text = "";
            ComboBoxStatus.SelectedIndex = -1;
            DateTimePickerHigherValue.Value = DateTime.Now;
            DateTimePickerLowerValue.Value = DateTime.Now;
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

        //Metoda przycisku - CheckBoxId
        private void CheckBoxId_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxId.Visible = CheckBoxId.Checked;
            if (CheckBoxId.Checked) return;
            TextBoxId.Text = "";
            id = -1;
        }
        //Metoda przycisku - CheckBoxDate
        private void CheckBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePickerLowerValue.Visible = CheckBoxDate.Checked;
            DateTimePickerHigherValue.Visible = CheckBoxDate.Checked;
            LabelFromDate.Visible = CheckBoxDate.Checked;
            LabelToDate.Visible = CheckBoxDate.Checked;
            if (CheckBoxDate.Checked) return;
            czyData = false;
        }
        //Metoda przycisku - CheckBoxAmount
        private void CheckBoxAmount_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxLowerAmount.Visible = CheckBoxAmount.Checked;
            TextBoxHigherAmount.Visible = CheckBoxAmount.Checked;
            LabelFromAmount.Visible = CheckBoxAmount.Checked;
            LabelToAmount.Visible = CheckBoxAmount.Checked;
            if (CheckBoxAmount.Checked) return;
            TextBoxLowerAmount.Text = "";
            TextBoxHigherAmount.Text = "";
            kwotaMinimum = -1;
            kwotaMaksimum = 9999999999999;
        }
        //Metoda checkboxa - CheckBoxFirm
        private void CheckBoxFirm_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxFirmName.Visible = CheckBoxFirm.Checked;
            if (CheckBoxFirm.Checked) return;
            TextBoxFirmName.Text = "";
            nazwaFirmy = "";
        }
        //Metoda checkboxa - CheckBoxFirmsBank
        private void CheckBoxFirmsBank_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxFirmsBank.Visible = CheckBoxFirmsBank.Checked;
            if (CheckBoxFirmsBank.Checked) return;
            TextBoxFirmsBank.Text = "";
            nazwaBankuFirmy = "";
        }
        //Metoda checkboxa - CheckBoxCardNumber
        private void CheckBoxCardNumber_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxCardNumber.Visible = CheckBoxCardNumber.Checked;
            if (CheckBoxCardNumber.Checked) return;
            TextBoxCardNumber.Text = "";
            nrKarty = "";
        }
        //Metoda checkboxa - CheckBoxClientsBank
        private void CheckBoxClientsBank_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxClientsBank.Visible = CheckBoxClientsBank.Checked;
            if (CheckBoxClientsBank.Checked) return;
            TextBoxClientsBank.Text = "";
            nazwaBankuKlienta = "";
        }
        //Metoda checkboxa - CheckBoxStatus
        private void CheckBoxStatus_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStatus.Visible = CheckBoxStatus.Checked;
            if (CheckBoxStatus.Checked) return;
            ComboBoxStatus.SelectedIndex = -1;
            status = false;
        }
        //Metoda checkboxa - Filtruj
        private void ButtonSearchTransaction_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBoxId.Text)) id = int.Parse(TextBoxId.Text);
            if (CheckBoxDate.Checked)
            {
                if (DateTimePickerHigherValue.Value < DateTimePickerLowerValue.Value)
                {
                    MessageBox.Show("Błędny przedział dat!", "Błąd!"); // Exception?
                    return;
                }
                czyData = true;
            }
            if (!String.IsNullOrEmpty(TextBoxHigherAmount.Text)) kwotaMaksimum = decimal.Parse(TextBoxHigherAmount.Text);
            if (!String.IsNullOrEmpty(TextBoxLowerAmount.Text)) kwotaMinimum = decimal.Parse(TextBoxLowerAmount.Text);
            if (kwotaMaksimum < kwotaMinimum)
            {
                MessageBox.Show("Błędny przedział kwoty!", "Błąd!"); //Exception?
                return;
            }
            if (!String.IsNullOrEmpty(TextBoxFirmName.Text)) nazwaFirmy = TextBoxFirmName.Text;
            if (!String.IsNullOrEmpty(TextBoxFirmsBank.Text)) nazwaBankuFirmy = TextBoxFirmsBank.Text;
            if (!String.IsNullOrEmpty(TextBoxCardNumber.Text) || TextBoxCardNumber.Text.Length == 16)
            {
                nrKarty = TextBoxCardNumber.Text;
            }
            if (!String.IsNullOrEmpty(TextBoxClientsBank.Text)) nazwaBankuKlienta = TextBoxClientsBank.Text;
            if (ComboBoxStatus.SelectedIndex != -1)
            {
                czyStatus = true;
                switch (ComboBoxStatus.SelectedIndex)
                {
                    case 0:
                        status = true;
                        break;
                    case 1:
                        status = false;
                        break;
                }
            }
            var tmp = centrumTransakcji.PrzeszukajTransakcje(id, DateTimePickerLowerValue.Value, DateTimePickerHigherValue.Value, czyData, kwotaMinimum, kwotaMaksimum, nazwaFirmy, nazwaBankuFirmy, nrKarty, nazwaBankuKlienta, status, czyStatus);
            if (tmp.Count > 0) UpdateFilteredTransactionList(tmp);
            else
            {
                MessageBox.Show("Nie znaleziono pasujących transakcji", "Uwaga!");
            }
        }

        //Metoda przycisku - Resetuj
        private void ButtonResetFilters_Click(object sender, EventArgs e)
        {
            UpdateTransactionList();
            ResetFilterVariables();
            CheckBoxAmount.Checked = false;
            CheckBoxCardNumber.Checked = false;
            CheckBoxClientsBank.Checked = false;
            CheckBoxDate.Checked = false;
            CheckBoxFirm.Checked = false;
            CheckBoxFirmsBank.Checked = false;
            CheckBoxId.Checked = false;
            CheckBoxStatus.Checked = false;
        }

        //Metoda przycisku - Zapisz
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            centrumTransakcji.Zapisywanie("dane.json");
        }


        //Metoda przycisku - Zapisz i wyjdź
        private void ButtonSaveAndExit_Click(object sender, EventArgs e)
        {
            centrumTransakcji.Zapisywanie("dane.json");
            Application.Exit();
        }

        //Metoda wydarzenia double click w listboxie banków 
        private void ListBoxBanks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ButtonGoToBank_Click(sender, e);
        }

        //
        //Metody ograniczające wpisywanie w textboxy
        //

        //Metoda pozwalająca wpisywać tylko liczby do Id
        private void TextBoxIdSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Metoda pozwalająca wpisywać tylko liczy do minimalnej kwoty
        private void TextBoxLowerAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        //Metoda pozwalająca wpisywać tylko liczby do maksymalnej kwoty
        private void TextBoxHigherAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        //Metoda pozwalająca wpisywać tylko liczby do numeru karty
        private void TextBoxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
