
namespace COKPOProject
{
    partial class FDodajKartePopUp
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
            this.TextBoxCardNumber = new System.Windows.Forms.TextBox();
            this.TextBoxCardSaldo = new System.Windows.Forms.TextBox();
            this.ComboBoxChooseCard = new System.Windows.Forms.ComboBox();
            this.ButtonAcceptAddCard = new System.Windows.Forms.Button();
            this.ButtonCancelAddCard = new System.Windows.Forms.Button();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxCardNumber
            // 
            this.TextBoxCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextBoxCardNumber.Location = new System.Drawing.Point(50, 137);
            this.TextBoxCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCardNumber.MaxLength = 16;
            this.TextBoxCardNumber.Name = "TextBoxCardNumber";
            this.TextBoxCardNumber.Size = new System.Drawing.Size(406, 32);
            this.TextBoxCardNumber.TabIndex = 2;
            this.TextBoxCardNumber.Text = "(Opcjonalnie) Numer Karty";
            this.TextBoxCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCardNumber_KeyDown);
            this.TextBoxCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCardNumber_KeyPress);
            // 
            // TextBoxCardSaldo
            // 
            this.TextBoxCardSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextBoxCardSaldo.Location = new System.Drawing.Point(50, 190);
            this.TextBoxCardSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCardSaldo.MaxLength = 12;
            this.TextBoxCardSaldo.Name = "TextBoxCardSaldo";
            this.TextBoxCardSaldo.Size = new System.Drawing.Size(406, 32);
            this.TextBoxCardSaldo.TabIndex = 3;
            this.TextBoxCardSaldo.Text = "(Opcjonalnie) Saldo";
            this.TextBoxCardSaldo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCardSaldo_KeyDown);
            this.TextBoxCardSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCardSaldo_KeyPress);
            // 
            // ComboBoxChooseCard
            // 
            this.ComboBoxChooseCard.FormattingEnabled = true;
            this.ComboBoxChooseCard.Items.AddRange(new object[] {
            "Karta Debetowa",
            "Karta Kredytowa",
            "Karta Bankomatowa"});
            this.ComboBoxChooseCard.Location = new System.Drawing.Point(50, 87);
            this.ComboBoxChooseCard.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxChooseCard.Name = "ComboBoxChooseCard";
            this.ComboBoxChooseCard.Size = new System.Drawing.Size(406, 31);
            this.ComboBoxChooseCard.TabIndex = 4;
            this.ComboBoxChooseCard.Text = "Wybierz rodzaj karty";
            this.ComboBoxChooseCard.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseCard_SelectedIndexChanged);
            // 
            // ButtonAcceptAddCard
            // 
            this.ButtonAcceptAddCard.Location = new System.Drawing.Point(50, 258);
            this.ButtonAcceptAddCard.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAcceptAddCard.Name = "ButtonAcceptAddCard";
            this.ButtonAcceptAddCard.Size = new System.Drawing.Size(186, 52);
            this.ButtonAcceptAddCard.TabIndex = 5;
            this.ButtonAcceptAddCard.Text = "Akceptuj";
            this.ButtonAcceptAddCard.UseVisualStyleBackColor = true;
            this.ButtonAcceptAddCard.Click += new System.EventHandler(this.ButtonAcceptAddCard_Click);
            // 
            // ButtonCancelAddCard
            // 
            this.ButtonCancelAddCard.Location = new System.Drawing.Point(272, 258);
            this.ButtonCancelAddCard.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancelAddCard.Name = "ButtonCancelAddCard";
            this.ButtonCancelAddCard.Size = new System.Drawing.Size(186, 52);
            this.ButtonCancelAddCard.TabIndex = 6;
            this.ButtonCancelAddCard.Text = "Anuluj";
            this.ButtonCancelAddCard.UseVisualStyleBackColor = true;
            this.ButtonCancelAddCard.Click += new System.EventHandler(this.ButtonCancelAddCard_Click);
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.Location = new System.Drawing.Point(54, 36);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(402, 23);
            this.LabelWarning.TabIndex = 7;
            this.LabelWarning.Text = "Wpisywane wartości potwierdź enterem!";
            // 
            // FDodajKartePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(512, 336);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.ButtonCancelAddCard);
            this.Controls.Add(this.ButtonAcceptAddCard);
            this.Controls.Add(this.ComboBoxChooseCard);
            this.Controls.Add(this.TextBoxCardSaldo);
            this.Controls.Add(this.TextBoxCardNumber);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDodajKartePopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDodajKlientaPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxCardNumber;
        private System.Windows.Forms.TextBox TextBoxCardSaldo;
        private System.Windows.Forms.ComboBox ComboBoxChooseCard;
        private System.Windows.Forms.Button ButtonAcceptAddCard;
        private System.Windows.Forms.Button ButtonCancelAddCard;
        private System.Windows.Forms.Label LabelWarning;
    }
}