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
        public FBank(Bank bank)
        {
            this.bank = bank;
            InitializeComponent();
            BankLabel.Text = bank.GetNazwaBanku();
        }

        private void CentrumTransakcjiLabel_Click(object sender, EventArgs e)
        {

        }

        private void FBank_Load(object sender, EventArgs e)
        {

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

        }

        private void ClientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
