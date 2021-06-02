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

        //Metoda przycisku - Akceptuj - akceptująca wprowadzone dane i kontynuująca program
        private void ButtonAcceptAddCard_Click(object sender, EventArgs e)
        {
            if (ComboBoxChooseCard.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz rodzaj karty!", "Uwaga!");
                return;
            }

            if (!string.IsNullOrEmpty(TextBoxCardSaldo.Text))
            {
                this.saldo = decimal.Parse(TextBoxCardSaldo.Text);
            }
            
            if (TextBoxCardNumber.TextLength == 16)
            {
                this.cardNumber = TextBoxCardNumber.Text;
            }
            else if (!string.IsNullOrEmpty(TextBoxCardNumber.Text))
            {
                MessageBox.Show("Nr Karty musi składaś się z 16 cyfr!", "Uwaga!");
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
            

            this.DialogResult = DialogResult.OK;
            Close();
        }

        //Metoda przycisku - Anuluj - porzuca zmiany
        private void ButtonCancelAddCard_Click(object sender, EventArgs e)
        {
            this.Close();
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
