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
    public partial class FDodajBankPopUp : Form
    {
        //Konstruktor forma
        public FDodajBankPopUp()
        {
            InitializeComponent();
        }

        //
        //Metody użytkowe
        //

        public string ReturnBankName()
        {
            return TextBoxBankName.Text;
        }
        public void ChangeTextBoxTextValue(string nazwa)
        {
            TextBoxBankName.Text = nazwa;
        }

        //
        //Metody przycisków oraz wydarzeń
        //

        //Metoda wydarzenia Text boxu Banku - jak wciśnięty enter
        private void TextBoxAddBank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.Close();
        }

        //Metoda przycisku - Akceptuj
        private void BankAddAcceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metoda przycisku - Anuluj
        private void BankAddCancelButton_Click(object sender, EventArgs e)
        {
            throw new Exception("Anulowano");
        }
    }
}
