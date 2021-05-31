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
    public partial class FDodajKlientaPopUp : Form
    {
        private Klient klient;
        private string clientname = "";
        private string numerkarty = "";
        private decimal saldo = -1;
        private string saldoo = "";
        private Bank bank;
        public FDodajKlientaPopUp(Bank bank)
        {
            this.bank = bank;
            InitializeComponent();
        }

        private void ChooseClientTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        { // 0-zwyklyklient 1-klientcentrum
            if (ChooseClientTypeBox.SelectedIndex == 0)
            {
                ClientNameTextBox.Text = "Imię i nazwisko";
            }
            else if (ChooseClientTypeBox.SelectedIndex == 1)
            {
                ClientNameTextBox.Text = "Nazwa firmy";
            }
        }

        private void ClientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            clientname = ClientNameTextBox.Text;
        }

        private void CardNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            numerkarty = CardNumberTextBox.Text;
        }

        private void CardSaldoTextBox_TextChanged(object sender, EventArgs e)
        {
            saldoo = CardSaldoTextBox.Text;
        }

        private void AcceptButton2_Click(object sender, EventArgs e)
        {
            if (clientname == "" || ChooseClientTypeBox.SelectedIndex == -1 || ChooseCardTypeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Wpisz i wybierz wymagane wartości!");
            }
            else //0-debetowa 1-kredytowa 2-bankomatowa
            {
                if (saldoo != "") saldo = decimal.Parse(saldoo);
                if (ChooseClientTypeBox.SelectedIndex == 0 && ChooseCardTypeBox.SelectedIndex == 0)
                {
                    klient = new KlientZwykly(clientname, bank);
                    klient.DodajKarte(0, saldo, numerkarty);
                }
                else if (ChooseClientTypeBox.SelectedIndex == 0 && ChooseCardTypeBox.SelectedIndex == 1)
                {
                    klient = new KlientZwykly(clientname, bank);
                    klient.DodajKarte(1, saldo, numerkarty);
                }
                else if (ChooseClientTypeBox.SelectedIndex == 0 && ChooseCardTypeBox.SelectedIndex == 2)
                {
                    klient = new KlientZwykly(clientname, bank);
                    klient.DodajKarte(2, saldo, numerkarty);
                }
                else if (ChooseClientTypeBox.SelectedIndex == 1 && ChooseCardTypeBox.SelectedIndex == 0)
                {
                    klient = new KlientCentrum(clientname, bank);
                    klient.DodajKarte(0, saldo, numerkarty);
                }
                else if (ChooseClientTypeBox.SelectedIndex == 1 && ChooseCardTypeBox.SelectedIndex == 1)
                {
                    klient = new KlientCentrum(clientname, bank);
                    klient.DodajKarte(1, saldo, numerkarty);
                }
                else if (ChooseClientTypeBox.SelectedIndex == 1 && ChooseCardTypeBox.SelectedIndex == 2)
                {
                    klient = new KlientCentrum(clientname, bank);
                    klient.DodajKarte(2, saldo, numerkarty);
                }
                else
                {
                    MessageBox.Show("Błąd w elsie przy tworzeniu klienta");
                }
                Close();
            }
        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {
            throw new Exception("Cancelbutton");
        }

        private void CardSaldoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void CardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        public Klient GetKlientt() => klient;
    }
}
