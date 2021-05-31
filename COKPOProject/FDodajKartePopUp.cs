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
    public partial class FDodajKartePopUp : Form
    {
        private readonly Klient klient;
        private string cardNumber = "";
        private decimal saldo = -1;

        //Konstruktor forma
        public FDodajKartePopUp(Klient klient)
        {
            this.klient = klient;
            InitializeComponent();
        }

        //
        // Metody przycisków oraz wydarzeń
        //

        //Metoda wykrywająca enter w textboxie numeru karty i akceptujaca nazwę
        private void TextBoxCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxCardNumber.Text.Length < 16)
                {
                    MessageBox.Show("Numer karty składa się z 16 cyfr!");
                    TextBoxCardNumber.Text = "(Opcjonalnie)Numer Karty";
                    return;
                }
                cardNumber = TextBoxCardNumber.Text;
                TextBoxCardNumber.BackColor = Color.DarkSeaGreen;
            }
        }

        //Metoda wykrywająca enter w textboxie salda i akceptujaca saldo
        private void TextBoxCardSaldo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saldo = decimal.Parse(TextBoxCardSaldo.Text);
                TextBoxCardSaldo.BackColor = Color.DarkSeaGreen;
            }
        }

        //Metoda przycisku - Akceptuj - akceptująca wprowadzone dane i kontynuująca program
        private void ButtonAcceptAddCard_Click(object sender, EventArgs e)
        {
            if (ComboBoxChooseCard.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz rodzaj karty!");
                return;
            }
            //Case= 0-debetowa 1-kredytowa 2-bankomatowa
            switch (ComboBoxChooseCard.SelectedIndex)
            {
                case 0:
                    klient.DodajKarte(0, saldo, cardNumber);
                    break;
                case 1:
                    klient.DodajKarte(1, saldo, cardNumber);
                    break;
                case 2:
                    klient.DodajKarte(2, saldo, cardNumber);
                    break;
                default:
                    throw new Exception("Błąd w wyborze opcji karty!");
            }

            Close();
        }

        //Metoda przycisku - Anuluj - porzuca zmiany
        private void ButtonCancelAddCard_Click(object sender, EventArgs e)
        {
            throw new Exception("Cancelbutton pressed");
        }

        //Metoda zmieniająca kolor background podczas wyboru rodzaju karty
        private void ComboBoxChooseCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxChooseCard.BackColor = Color.DarkSeaGreen;
        }

        //
        //Metody obsługujące ograniczenia wpisywania w TextBoxach
        //

        //Metoda pozwalająca wpisywać liczby oraz przecinek do text boxu
        private void TextBoxCardSaldo_KeyPress(object sender, KeyPressEventArgs e)
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

        //Metoda pozwalająca wpisywać tylko liczby
        private void TextBoxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
