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
    public partial class FCentrumTransakcji : Form
    {
        CentrumTransakcji centrumTransakcji;
        public FCentrumTransakcji(CentrumTransakcji centrumTransakcji)
        {
            this.centrumTransakcji = centrumTransakcji;
            InitializeComponent();
            UzupelnijListe();
        }

        private void ListaBankow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FDodajBankPopUp fDodajBankPopUp = new FDodajBankPopUp();
            fDodajBankPopUp.ShowDialog();
            centrumTransakcji.DodajBank(fDodajBankPopUp.ZwrocNazweBanku());
            ListaBankow.BeginUpdate();
            ListaBankow.Items.Add(centrumTransakcji.GetBanki().Last());
            ListaBankow.EndUpdate();
        }

        private void UzupelnijListe()
        {
            ListaBankow.BeginUpdate();
            foreach (Bank bank in centrumTransakcji.GetBanki())
            {
                ListaBankow.Items.Add(bank);
            }
            ListaBankow.EndUpdate();
        }
    }
}
