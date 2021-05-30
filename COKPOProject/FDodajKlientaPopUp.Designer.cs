
namespace COKPOProject
{
    partial class FDodajKlientaPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseClientTypeBox = new System.Windows.Forms.ComboBox();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.CardSaldoTextBox = new System.Windows.Forms.TextBox();
            this.ChooseCardTypeBox = new System.Windows.Forms.ComboBox();
            this.AcceptButton2 = new System.Windows.Forms.Button();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseClientTypeBox
            // 
            this.ChooseClientTypeBox.FormattingEnabled = true;
            this.ChooseClientTypeBox.Items.AddRange(new object[] {
            "Klient Zwykły",
            "Klient Centrum"});
            this.ChooseClientTypeBox.Location = new System.Drawing.Point(114, 39);
            this.ChooseClientTypeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChooseClientTypeBox.Name = "ChooseClientTypeBox";
            this.ChooseClientTypeBox.Size = new System.Drawing.Size(406, 31);
            this.ChooseClientTypeBox.TabIndex = 0;
            this.ChooseClientTypeBox.Text = "Wybierz rodzaj klienta";
            this.ChooseClientTypeBox.SelectedIndexChanged += new System.EventHandler(this.ChooseClientTypeBox_SelectedIndexChanged);
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(114, 95);
            this.ClientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientNameTextBox.MaxLength = 30;
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(406, 32);
            this.ClientNameTextBox.TabIndex = 1;
            this.ClientNameTextBox.Text = "Wpisz nazwę klienta";
            this.ClientNameTextBox.TextChanged += new System.EventHandler(this.ClientNameTextBox_TextChanged);
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Location = new System.Drawing.Point(114, 210);
            this.CardNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardNumberTextBox.MaxLength = 16;
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(406, 32);
            this.CardNumberTextBox.TabIndex = 2;
            this.CardNumberTextBox.Text = "(Opcjonalnie) Numer Karty";
            this.CardNumberTextBox.TextChanged += new System.EventHandler(this.CardNumberTextBox_TextChanged);
            this.CardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumberTextBox_KeyPress);
            // 
            // CardSaldoTextBox
            // 
            this.CardSaldoTextBox.Location = new System.Drawing.Point(114, 263);
            this.CardSaldoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardSaldoTextBox.MaxLength = 12;
            this.CardSaldoTextBox.Name = "CardSaldoTextBox";
            this.CardSaldoTextBox.Size = new System.Drawing.Size(406, 32);
            this.CardSaldoTextBox.TabIndex = 3;
            this.CardSaldoTextBox.Text = "(Opcjonalnie) Saldo";
            this.CardSaldoTextBox.TextChanged += new System.EventHandler(this.CardSaldoTextBox_TextChanged);
            this.CardSaldoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardSaldoTextBox_KeyPress);
            // 
            // ChooseCardTypeBox
            // 
            this.ChooseCardTypeBox.FormattingEnabled = true;
            this.ChooseCardTypeBox.Items.AddRange(new object[] {
            "Karta Debetowa",
            "Karta Kredytowa",
            "Karta Bankomatowa"});
            this.ChooseCardTypeBox.Location = new System.Drawing.Point(114, 151);
            this.ChooseCardTypeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChooseCardTypeBox.Name = "ChooseCardTypeBox";
            this.ChooseCardTypeBox.Size = new System.Drawing.Size(406, 31);
            this.ChooseCardTypeBox.TabIndex = 4;
            this.ChooseCardTypeBox.Text = "Wybierz rodzaj karty";
            // 
            // AcceptButton2
            // 
            this.AcceptButton2.Location = new System.Drawing.Point(114, 331);
            this.AcceptButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AcceptButton2.Name = "AcceptButton2";
            this.AcceptButton2.Size = new System.Drawing.Size(186, 52);
            this.AcceptButton2.TabIndex = 5;
            this.AcceptButton2.Text = "Akceptuj";
            this.AcceptButton2.UseVisualStyleBackColor = true;
            this.AcceptButton2.Click += new System.EventHandler(this.AcceptButton2_Click);
            // 
            // CancelButton2
            // 
            this.CancelButton2.Location = new System.Drawing.Point(336, 331);
            this.CancelButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(186, 52);
            this.CancelButton2.TabIndex = 6;
            this.CancelButton2.Text = "Anuluj";
            this.CancelButton2.UseVisualStyleBackColor = true;
            this.CancelButton2.Click += new System.EventHandler(this.CancelButton2_Click);
            // 
            // FDodajKlientaPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(638, 417);
            this.Controls.Add(this.CancelButton2);
            this.Controls.Add(this.AcceptButton2);
            this.Controls.Add(this.ChooseCardTypeBox);
            this.Controls.Add(this.CardSaldoTextBox);
            this.Controls.Add(this.CardNumberTextBox);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.ChooseClientTypeBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FDodajKlientaPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDodajKlientaPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseClientTypeBox;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.TextBox CardSaldoTextBox;
        private System.Windows.Forms.ComboBox ChooseCardTypeBox;
        private System.Windows.Forms.Button AcceptButton2;
        private System.Windows.Forms.Button CancelButton2;
    }
}