﻿using System;
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
            try
            {
                FDodajBankPopUp fDodajBankPopUp = new FDodajBankPopUp();
                fDodajBankPopUp.ShowDialog();
                centrumTransakcji.DodajBank(fDodajBankPopUp.ZwrocNazweBanku());
                ListaBankow.BeginUpdate();
                ListaBankow.Items.Add(centrumTransakcji.GetBanki().Last());
                ListaBankow.EndUpdate();
            }
            catch (Exception ex)
            {
                //XD
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ListaBankow.SelectedItem != null) ListaBankow.Items.Remove(ListaBankow.SelectedItem);
        }

        private void BankEditButton_Click(object sender, EventArgs e)
        {
            if (ListaBankow.SelectedItem != null)
            {
                try
                {
                    FDodajBankPopUp fDodajBankPopUp = new FDodajBankPopUp();
                    fDodajBankPopUp.ShowDialog();
                    ListaBankow.BeginUpdate();
                    if (ListaBankow.SelectedItem is Bank)
                    {
                        Bank tmp = (Bank)ListaBankow.SelectedItem;
                        tmp.SetNazwaBanku(fDodajBankPopUp.ZwrocNazweBanku());
                        ListaBankow.Items.Clear();
                        UzupelnijListe();
                    }
                    ListaBankow.EndUpdate();

                }
                catch (Exception ex)
                {
                    //XD
                }
            }
        }

        private void GoToBankButton_Click(object sender, EventArgs e)
        {

        }

        private void DoneTranstacionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AwaitingTransactionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveTransactionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
