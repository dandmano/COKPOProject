using System;
using System.Windows.Forms;
using COKPOProjectLogic;

namespace COKPOProject
{
    public partial class FStronaGlowna : Form
    {
        private readonly CentrumTransakcji centrumTransakcji;
        //Konstruktor forma
        public FStronaGlowna(CentrumTransakcji centrumTransakcji)
        {
            this.centrumTransakcji = centrumTransakcji;
            InitializeComponent();
        }
        //
        //Metody przycisków
        //
        private void ButtonBegin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fCentrumTransakcji = new FCentrumTransakcji(this, centrumTransakcji);
            fCentrumTransakcji.ShowDialog();
            this.Close();
        }
    }
}
