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
        private readonly CentrumTransakcji centrumTransakcji;

        //Konstruktor form
        public FCentrumTransakcji(CentrumTransakcji centrumTransakcji)
        {
            this.centrumTransakcji = centrumTransakcji;
            InitializeComponent();
            UzupelnijListe();
        }

        //Odpala się przy otwieraniu forma
        private void FCentrumTransakcji_Load(object sender, EventArgs e)
        {
            UzupelnijListe();
        }

        //
        //Metody użytkowe
        //

        //Odświeżanie/uzupełnianie listy banków
        private void UzupelnijListe()
        {
            ListBoxBanks.BeginUpdate();
            ListBoxBanks.Items.Clear();
            foreach (var bank in centrumTransakcji.GetBanki())
            {
                ListBoxBanks.Items.Add(bank);
            }
            ListBoxBanks.EndUpdate();
        }

        //
        // Metody przycisków
        //

        // Metoda przycisku - Dodaj Bank
        private void ButtonAddBank_Click(object sender, EventArgs e)
        {
            try
            {
                var fDodajBankPopUp = new FDodajBankPopUp();
                fDodajBankPopUp.ShowDialog();
                centrumTransakcji.DodajBank(fDodajBankPopUp.ReturnBankName());
                ListBoxBanks.BeginUpdate();
                ListBoxBanks.Items.Add(centrumTransakcji.GetBanki().Last());
                ListBoxBanks.EndUpdate();
            }
            catch
            {
                //XD
            }
        }
        //Metoda przycisku - Usun Bank
        private void ButtonRemoveBank_Click(object sender, EventArgs e)
        {
            if (ListBoxBanks.SelectedItem != null)
            {
                centrumTransakcji.GetBanki().Remove((Bank)ListBoxBanks.SelectedItem);
                ListBoxBanks.Items.Remove(ListBoxBanks.SelectedItem);
            }
            else MessageBox.Show("Zaznacz bank który chcesz usunąć.");
        }
        //Metoda przycisku - Edytuj nazwę Banku
        private void ButtonEditBank_Click(object sender, EventArgs e)
        {
            if (ListBoxBanks.SelectedItem != null)
            {
                try
                {
                    var fDodajBankPopUp = new FDodajBankPopUp();
                    fDodajBankPopUp.ShowDialog();
                    ListBoxBanks.BeginUpdate();
                    if (ListBoxBanks.SelectedItem is Bank tmp)
                    {
                        tmp.SetNazwaBanku(fDodajBankPopUp.ReturnBankName());
                        ListBoxBanks.Items.Clear();
                        UzupelnijListe();
                    }
                    ListBoxBanks.EndUpdate();

                }
                catch
                {
                    //XD
                }
            }
            else MessageBox.Show("Zaznacz bank którego nazwę chcesz edytować.");
        }
        //Metoda przycisku - Przejdź do banku
        private void ButtonGoToBank_Click(object sender, EventArgs e)
        {
            if (ListBoxBanks.SelectedItem != null)
            {
                var fBank = new FBank((Bank)ListBoxBanks.SelectedItem, this);
                this.Hide();
                fBank.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wybierz bank do którego chcesz przejść.");
            }
        }
    }
}
