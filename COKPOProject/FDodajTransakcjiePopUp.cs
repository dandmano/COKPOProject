using COKPOProjectLogic;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace COKPOProject
{
    public partial class FDodajTransakcjiePopUp : Form
    {
        private readonly CentrumTransakcji centrumTransakcji;
        public FDodajTransakcjiePopUp(CentrumTransakcji centrumTransakcji)
        {
            this.centrumTransakcji = centrumTransakcji;
            InitializeComponent();
        }

        //Metoda wywołująca się przy otworzeniu forma
        private void FDodajTransakcjiePopUp_Load(object sender, EventArgs e)
        {
            foreach (var klient in centrumTransakcji.Banki.SelectMany(bank => bank.Klienci).OfType<Firma>())
            {
                ComboBoxFirmy.Items.Add(klient);
            }

            foreach (var karta in from bank in centrumTransakcji.Banki from klient in bank.Klienci from karta in klient.Karty select karta)
            {
                ComboBoxCards.Items.Add(karta + " - " + karta.Wlasciciel.NazwaKlienta + " => " + karta.Saldo.ToString("C"));
            }
        }

        //
        //Metody przycisków oraz wydarzeń
        //

        //Metoda przycisku - akceptuj
        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            if (ComboBoxCards.SelectedIndex == -1 || ComboBoxFirmy.SelectedIndex == -1 || string.IsNullOrEmpty(TextBoxAmount.Text))
            {
                MessageBox.Show("Podaj i wybierz wymagane wartości", "Uwaga!");
                return;
            }
            var firma = (Firma)ComboBoxFirmy.SelectedItem;
            var kwota = decimal.Parse(TextBoxAmount.Text);
            var nrkarty = (string)ComboBoxCards.SelectedItem;
            nrkarty = nrkarty.Substring(0, 16);
            try
            {
                centrumTransakcji.DodajTransakcje(firma, kwota, nrkarty);
            }
            catch (WrongCardNumberException exe)
            {
                MessageBox.Show(exe.Message + " Nr karty = " + exe.WrongCardNumber, "Uwaga!");
            }
            catch (BankomatCardNotSupportedException exe)
            {
                MessageBox.Show(exe.Message + " Nr karty = " + exe.WrongCard, "Uwaga!");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //Metoda wydarzenia zmiana wybranej firmy
        private void ComboBoxFirmy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxCards.Items.Clear();
            var wybranaFirma = (Klient)ComboBoxFirmy.SelectedItem;
            foreach (var klient in from bank in centrumTransakcji.Banki from klient in bank.Klienci where !klient.Equals(wybranaFirma) select klient)
            {
                klient.Karty.ForEach(karta => ComboBoxCards.Items.Add(karta + " - " + karta.Wlasciciel.NazwaKlienta + " => " + karta.Saldo.ToString("C")));
            }
        }

        //Metoda pozwalająca na wpisywanie tylko liczb
        private void TextBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
