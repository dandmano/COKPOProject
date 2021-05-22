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
    public partial class CentrumObslugi : Form
    {
        public CentrumObslugi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCentrumTransakcji fCentrumTransakcji = new FCentrumTransakcji();
            fCentrumTransakcji.ShowDialog();
            this.Close();
        }
    }
}
