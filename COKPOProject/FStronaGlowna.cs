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
