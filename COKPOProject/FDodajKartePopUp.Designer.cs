
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
            this.LabelChooseCardType = new System.Windows.Forms.Label();
            this.LabelCardNumber = new System.Windows.Forms.Label();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.LabelSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxCardNumber
            // 
            this.TextBoxCardNumber.BackColor = System.Drawing.Color.White;
            this.TextBoxCardNumber.Location = new System.Drawing.Point(50, 142);
            this.TextBoxCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCardNumber.MaxLength = 16;
            this.TextBoxCardNumber.Name = "TextBoxCardNumber";
            this.TextBoxCardNumber.Size = new System.Drawing.Size(406, 27);
            this.TextBoxCardNumber.TabIndex = 2;
            this.TextBoxCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCardNumber_KeyPress);
            // 
            // TextBoxCardSaldo
            // 
            this.TextBoxCardSaldo.BackColor = System.Drawing.Color.White;
            this.TextBoxCardSaldo.Location = new System.Drawing.Point(50, 205);
            this.TextBoxCardSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCardSaldo.MaxLength = 12;
            this.TextBoxCardSaldo.Name = "TextBoxCardSaldo";
            this.TextBoxCardSaldo.Size = new System.Drawing.Size(406, 27);
            this.TextBoxCardSaldo.TabIndex = 3;
            this.TextBoxCardSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCardSaldo_KeyPress);
            // 
            // ComboBoxChooseCard
            // 
            this.ComboBoxChooseCard.FormattingEnabled = true;
            this.ComboBoxChooseCard.Items.AddRange(new object[] {
            "Karta Debetowa",
            "Karta Kredytowa",
            "Karta Bankomatowa"});
            this.ComboBoxChooseCard.Location = new System.Drawing.Point(50, 75);
            this.ComboBoxChooseCard.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxChooseCard.Name = "ComboBoxChooseCard";
            this.ComboBoxChooseCard.Size = new System.Drawing.Size(406, 27);
            this.ComboBoxChooseCard.TabIndex = 4;
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
            this.ButtonCancelAddCard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancelAddCard.Location = new System.Drawing.Point(272, 258);
            this.ButtonCancelAddCard.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancelAddCard.Name = "ButtonCancelAddCard";
            this.ButtonCancelAddCard.Size = new System.Drawing.Size(186, 52);
            this.ButtonCancelAddCard.TabIndex = 6;
            this.ButtonCancelAddCard.Text = "Anuluj";
            this.ButtonCancelAddCard.UseVisualStyleBackColor = true;
            this.ButtonCancelAddCard.Click += new System.EventHandler(this.ButtonCancelAddCard_Click);
            // 
            // LabelChooseCardType
            // 
            this.LabelChooseCardType.BackColor = System.Drawing.Color.Transparent;
            this.LabelChooseCardType.Location = new System.Drawing.Point(46, 44);
            this.LabelChooseCardType.Name = "LabelChooseCardType";
            this.LabelChooseCardType.Size = new System.Drawing.Size(223, 28);
            this.LabelChooseCardType.TabIndex = 8;
            this.LabelChooseCardType.Text = "Wybierz rodzaj karty";
            this.LabelChooseCardType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelCardNumber.Location = new System.Drawing.Point(46, 111);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(327, 28);
            this.LabelCardNumber.TabIndex = 9;
            this.LabelCardNumber.Text = "(Opcjonalnie) Numer Karty";
            this.LabelCardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelWarning
            // 
            this.LabelWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.BackColor = System.Drawing.Color.Transparent;
            this.LabelWarning.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelWarning.Location = new System.Drawing.Point(167, 10);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(135, 25);
            this.LabelWarning.TabIndex = 7;
            this.LabelWarning.Text = "Stwórz Kartę";
            this.LabelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSaldo
            // 
            this.LabelSaldo.BackColor = System.Drawing.Color.Transparent;
            this.LabelSaldo.Location = new System.Drawing.Point(46, 174);
            this.LabelSaldo.Name = "LabelSaldo";
            this.LabelSaldo.Size = new System.Drawing.Size(232, 28);
            this.LabelSaldo.TabIndex = 10;
            this.LabelSaldo.Text = "(Opcjolanie) Saldo";
            this.LabelSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FDodajKartePopUp
            // 
            this.AcceptButton = this.ButtonAcceptAddCard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.ButtonCancelAddCard;
            this.ClientSize = new System.Drawing.Size(513, 339);
            this.Controls.Add(this.LabelSaldo);
            this.Controls.Add(this.LabelCardNumber);
            this.Controls.Add(this.LabelChooseCardType);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label LabelChooseCardType;
        private System.Windows.Forms.Label LabelCardNumber;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.Label LabelSaldo;
    }
}