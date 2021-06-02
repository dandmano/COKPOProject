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
    public partial class FKlient : Form
    {
        private readonly Klient klient;
        private readonly FBank previuousform;

        //Konstruktor Forma
        public FKlient(Klient klient, FBank fBank)
        {
            this.klient = klient;
            this.previuousform = fBank;
            InitializeComponent();
            ClientiLabel.Text = klient.NazwaKlienta;
            UpdateCardList();
            if (klient is KlientCentrum) ButtonRegisterTransaction.Visible = true;
        }

        //Metoda uruchamiająca się przy ładowaniu forma
        private void FKlient_Load(object sender, EventArgs e)
        {
            ClientiLabel.Text = klient.NazwaKlienta;
            UpdateCardList();
        }

        //
        //Metody użytkowe
        //

        //Metoda do aktualizacji/uzupełniania listy kart
        private void UpdateCardList()
        {
            ListBoxCards.Update();
            ListBoxCards.Items.Clear();
            foreach (var karta in klient.Karty)
            {
                ListBoxCards.Items.Add(karta);
            }
            ListBoxCards.EndUpdate();
        }

        //
        //Metody przycisków i wydarzeń 
        //

        //Metoda przycisku - Wstecz
        private void ButtonClientReturn_Click(object sender, EventArgs e)
        {
            previuousform.Show();
            this.Close();
        }

        //Metoda przycisku - Dodaj kartę
        private void ButtonAddCard_Click(object sender, EventArgs e)
        {

            var fDodajKartePopUp = new FDodajKartePopUp(klient);
            fDodajKartePopUp.ShowDialog();
            if (fDodajKartePopUp.DialogResult != DialogResult.OK) return;
            UpdateCardList();
        }

        //Metoda przycisku - Usuń kartę
        private void ButtonDeleteCard_Click(object sender, EventArgs e)
        {
            if (ListBoxCards.SelectedItem != null)
            {
                klient.Karty.Remove((Karta)ListBoxCards.SelectedItem);
                UpdateCardList();
            }
            else MessageBox.Show("Wybierz kartę, którą chcesz usunąć.", "Uwaga!");
        }

        //Metoda wykrywająca zmianę zaznaczonej karty i zmienia jej wyświetlane wartości
        private void ListBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmp = (Karta)ListBoxCards.SelectedItem;

            switch (tmp)
            {
                case KartaDebetowa karta:
                    ChangeDisplay(tmp.NrKarty, tmp.Saldo.ToString("C"), tmp.BankWydajacy.ToString(), "Debetowa", false, false, false);
                    break;

                case KartaKredytowa karta:
                    ChangeDisplay(tmp.NrKarty, tmp.Saldo.ToString("C"), tmp.BankWydajacy.ToString(), "Kredytowa", true, true, true);
                    TextBoxCreditLimit.Text = karta.LimitKredytu.ToString("C");
                    break;

                case KartaBankomatowa karta:
                    ChangeDisplay(tmp.NrKarty, tmp.Saldo.ToString("C"), tmp.BankWydajacy.ToString(), "Bankomatowa", false, false, false);
                    break;

                default:
                    ChangeDisplay("", "", "", "", false, false, false);
                    break;
            }
        }

        private void ChangeDisplay(string cardnumber, string saldo, string bank, string cardtype, bool label, bool text,
            bool button)
        {
            TextBoxCardNumber.Text = cardnumber;
            TextBoxSaldo.Text = saldo;
            TextBoxBank.Text = bank;
            TextBoxCardType.Text = cardtype;
            LabelCreditLimit.Visible = label;
            TextBoxCreditLimit.Visible = text;
            ButtonChangeCreditLimit.Visible = button;
        }

        //Metoda zmieniająca limit kredytu
        private void ButtonChangeCreditLimit_Click(object sender, EventArgs e)
        {
            var tmp = (KartaKredytowa)ListBoxCards.SelectedItem;
            var fZmienLimitKredytuPopUp = new FZmienLimitKredytuPopUp(tmp);
            fZmienLimitKredytuPopUp.ShowDialog();
            if (fZmienLimitKredytuPopUp.DialogResult != DialogResult.OK) return;
            TextBoxCreditLimit.Text = tmp.LimitKredytu.ToString("C");
        }
    }
}
