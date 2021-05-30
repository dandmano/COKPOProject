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
    public partial class FBank : Form
    {
        private Bank bank;
        private FCentrumTransakcji previusform;
        public FBank(Bank bank, FCentrumTransakcji fCentrumTransakcji)
        {
            this.bank = bank;
            this.previusform = fCentrumTransakcji;
            InitializeComponent();
            BankLabel.Text = bank.GetNazwaBanku();
            UpdateClientList();
        }

        private void FBank_Load(object sender, EventArgs e)
        {
            BankLabel.Text = bank.GetNazwaBanku();
            UpdateClientList();
        }

        private void ButtonChangeBankName_Click(object sender, EventArgs e)
        {

            try
            {
                FDodajBankPopUp fDodajBankPopUp = new FDodajBankPopUp();
                fDodajBankPopUp.ShowDialog();

                bank.SetNazwaBanku(fDodajBankPopUp.ZwrocNazweBanku());
                BankLabel.Text = bank.GetNazwaBanku();

            }
            catch (Exception ex)
            {
                //XD
            }

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            previusform.ShowDialog();
            this.Close();
        }

        private void UpdateClientList()
        {
            ClientListBox.Update();
            ClientListBox.Items.Clear();
            foreach (Klient klient in bank.GetKlienci())
            {
                ClientListBox.Items.Add(klient);
            }
            ClientListBox.EndUpdate();
        }

        private void ButtonOpenClient_Click(object sender, EventArgs e)
        {
            FKlient fKlient = new FKlient((Klient)ClientListBox.SelectedItem, this);
            fKlient.ShowDialog();
            this.Hide();
        }

        private void ButtonAllClients_Click(object sender, EventArgs e)
        {
            UpdateClientList();
        }

        private void ButtonNormalClient_Click(object sender, EventArgs e)
        {
            ClientListBox.Update();
            ClientListBox.Items.Clear();
            foreach (Klient klient in bank.GetKlienci())
            {
                if (klient is KlientZwykly)
                    ClientListBox.Items.Add(klient);
            }
            ClientListBox.EndUpdate();
        }

        private void ButtonClientCentrum_Click(object sender, EventArgs e)
        {
            ClientListBox.Update();
            ClientListBox.Items.Clear();
            foreach (Klient klient in bank.GetKlienci())
            {
                if (klient is KlientCentrum)
                    ClientListBox.Items.Add(klient);
            }
            ClientListBox.EndUpdate();
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {

        }
    }
}
