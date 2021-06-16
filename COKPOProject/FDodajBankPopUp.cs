using System;
using System.Windows.Forms;

namespace COKPOProject
{
    public partial class FDodajBankPopUp : Form
    {
        public string BankName { get; set; }

        //Konstruktor forma
        public FDodajBankPopUp()
        {
            InitializeComponent();
        }
        //Konstruktor wpisujący inny środek w textbox
        public FDodajBankPopUp(string name)
        {
            InitializeComponent();
            LabelText.Text = name;
        }

        //
        //Metody użytkowe
        //

        public void ChangeTextBoxValue(string newValue)
        {
            TextBoxBankName.Text = newValue;
        }

        //
        //Metody przycisków oraz wydarzeń
        //

        //Metoda przycisku - Akceptuj
        private void BankAddAcceptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxBankName.Text))
            {
                this.DialogResult = DialogResult.OK;
                BankName = TextBoxBankName.Text;
                this.Close();
            }
            else MessageBox.Show("Nazwa banku nie może być pusta!", "Uwaga!");
        }

        //Metoda przycisku - Anuluj
        private void BankAddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
