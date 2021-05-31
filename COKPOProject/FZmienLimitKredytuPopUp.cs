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
    public partial class FZmienLimitKredytuPopUp : Form
    {
        private readonly KartaKredytowa karta;
        //Konstruktor forma
        public FZmienLimitKredytuPopUp(KartaKredytowa karta)
        {
            this.karta = karta;
            InitializeComponent();
        }

        //
        //Metody przycisków oraz wydarzeń
        //

        //Metoda wydarzenia Text boxu - jak wciśnięty enter
        private void TextBoxCreditValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                karta.LimitKredytu = decimal.Parse(TextBoxCreditValue.Text);
                this.Close();
            }
        }

        //Metoda przycisku - Akceptuj
        private void ButtonAcceptChangeCreditLimit(object sender, EventArgs e)
        {
            karta.LimitKredytu = decimal.Parse(TextBoxCreditValue.Text);
            this.Close();
        }

        //Metoda przycisku - Anuluj
        private void ButtonCancelChangeCreditLimit_Click(object sender, EventArgs e)
        {
            throw new Exception("Anulowano");
        }

        //Metoda pozwalająca wpisywać liczby oraz przecinek do text boxu
        private void TextBoxCreditValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
