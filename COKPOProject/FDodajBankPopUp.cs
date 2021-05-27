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
    public partial class FDodajBankPopUp : Form
    {
        public FDodajBankPopUp()
        {
            InitializeComponent();
        }

        public string ZwrocNazweBanku()
        {
            return DodajBankTextBox.Text;
        }

        private void ZaakceptujButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajBankTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.Close();
        }
    }
}
