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
    public partial class FKlient : Form
    {
        private Klient klient;
        private FBank previuousform;

        public FKlient(Klient klient, FBank fBank)
        {
            this.klient = klient;
            this.previuousform = fBank;
            InitializeComponent();
            ClientiLabel.Text = klient.GetNazwa();
            UpdateCardList();
        }

        private void FKlient_Load(object sender, EventArgs e)
        {
            ClientiLabel.Text = klient.GetNazwa();
            UpdateCardList();
        }

        private void ClientiLabel_Click(object sender, EventArgs e)
        {

        }

        private void GoToCardButton_Click(object sender, EventArgs e)
        {

        }
        private void UpdateCardList()
        {
            CardListBox.Update();
            CardListBox.Items.Clear();
            foreach (Karta karta in klient.GetKarty())
            {
                CardListBox.Items.Add(karta);
            }
            CardListBox.EndUpdate();
        }

        private void ClientButtonBack_Click(object sender, EventArgs e)
        {
            previuousform.ShowDialog();
            this.Close();
        }
    }
}
