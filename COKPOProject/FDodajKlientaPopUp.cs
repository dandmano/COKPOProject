using System;
using System.Windows.Forms;
using COKPOProjectLogic;

namespace COKPOProject
{
    public partial class FDodajKlientaPopUp : Form
    {
        private string clientName = "";
        private string cardNumber = "";
        private decimal saldo = -1;
        private readonly Bank bank;

        //Konstruktor forma
        public FDodajKlientaPopUp(Bank bank)
        {
            this.bank = bank;
            InitializeComponent();
        }

        //
        // Metody przycisków oraz wydarzeń
        //

        //Metoda przycisku - Akceptuj - akceptująca wprowadzone dane i kontynuująca program
        private void ButtonAcceptAddClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxClientName.Text)) clientName = TextBoxClientName.Text;

            if (clientName == "" || ComboBoxChooseClient.SelectedIndex == -1 || ComboBoxChooseCard.SelectedIndex == -1)
            {
                MessageBox.Show("Podaj i wybierz wymagane wartości", "Uwaga!");
                return;
            }
            if (!string.IsNullOrEmpty(TextBoxCardSaldo.Text)) this.saldo = decimal.Parse(TextBoxCardSaldo.Text);

            if (TextBoxCardNumber.TextLength == 16) this.cardNumber = TextBoxCardNumber.Text;

            else if (!string.IsNullOrEmpty(TextBoxCardNumber.Text))
            {
                MessageBox.Show("Nr Karty musi składaś się z 16 cyfr!", "Uwaga!");
                return;
            }
            bank.DodajKlienta(clientName, ComboBoxChooseClient.SelectedIndex, ComboBoxChooseCard.SelectedIndex, saldo,
                cardNumber);
            this.DialogResult = DialogResult.OK;
            Close();
        }
        //Metoda zmieniająca LabelNazwyKlienta w zależności od wybranego typu klienta
        private void ComboBoxChooseClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxChooseClient.SelectedIndex)
            {
                case 0:
                    LabelEnterClientName.Text = "Imie i nazwisko";
                    break;
                case 1:
                    LabelEnterClientName.Text = "Nazwa firmy";
                    break;
            }
        }

        //Metoda przycisku - Anuluj - porzuca zmiany
        private void ButtonCancelAddClient_Click(object sender, EventArgs e)
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
