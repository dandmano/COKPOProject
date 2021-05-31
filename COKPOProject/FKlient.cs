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
            ClientiLabel.Text = klient.GetNazwa();
            UpdateCardList();
            if (klient is KlientCentrum) ButtonRegisterTransaction.Visible = true;
        }

        //Metoda uruchamiająca się przy ładowaniu forma
        private void FKlient_Load(object sender, EventArgs e)
        {
            ClientiLabel.Text = klient.GetNazwa();
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
            foreach (var karta in klient.GetKarty())
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
            try
            {
                var fDodajKartePopUp = new FDodajKartePopUp(klient);
                fDodajKartePopUp.ShowDialog();
                UpdateCardList();
            }
            catch
            {
                //xD
            }
        }

        //Metoda przycisku - Usuń kartę
        private void ButtonDeleteCard_Click(object sender, EventArgs e)
        {
            if (ListBoxCards.SelectedItem != null)
            {
                klient.GetKarty().Remove((Karta)ListBoxCards.SelectedItem);
                UpdateCardList();
            }
            else MessageBox.Show("Wybierz kartę, którą chcesz usunąć.");
        }

        //Metoda wykrywająca zmianę zaznaczonej karty i zmienia jej wyświetlane wartości
        private void ListBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmp = (Karta)ListBoxCards.SelectedItem;
            TextBoxCardNumber.Text = tmp.NrKarty;
            TextBoxSaldo.Text = tmp.SaldoProp.ToString("C");
            TextBoxBank.Text = tmp.BankWydajacy.ToString();
            switch (tmp)
            {
                case KartaDebetowa karta:
                    TextBoxCardType.Text = "Debetowa";
                    LabelCreditLimit.Visible = false;
                    TextBoxCreditLimit.Visible = false;
                    ButtonChangeCreditLimit.Visible = false;
                    break;
                case KartaKredytowa karta:
                    TextBoxCardType.Text = "Kredytowa";
                    TextBoxCreditLimit.Text = karta.LimitKredytu.ToString("C");
                    LabelCreditLimit.Visible = true;
                    TextBoxCreditLimit.Visible = true;
                    ButtonChangeCreditLimit.Visible = true;
                    break;
                case KartaBankomatowa karta:
                    TextBoxCardType.Text = "Bankomatowa";
                    LabelCreditLimit.Visible = false;
                    TextBoxCreditLimit.Visible = false;
                    ButtonChangeCreditLimit.Visible = false;
                    break;
            }
        }

        //Metoda zmieniająca limit kredytu
        private void ButtonChangeCreditLimit_Click(object sender, EventArgs e)
        {
            try
            {
                var tmp = (KartaKredytowa)ListBoxCards.SelectedItem;
                var fZmienLimitKredytuPopUp = new FZmienLimitKredytuPopUp(tmp);
                fZmienLimitKredytuPopUp.ShowDialog();
                TextBoxCreditLimit.Text = tmp.LimitKredytu.ToString("C");
            }
            catch
            {
                //XD
            }
        }
    }
}
