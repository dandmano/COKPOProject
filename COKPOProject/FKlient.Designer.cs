
namespace COKPOProject
{
    partial class FKlient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKlient));
            this.ClientiLabel = new System.Windows.Forms.Label();
            this.ListBoxCards = new System.Windows.Forms.ListBox();
            this.ButtonClientReturn = new System.Windows.Forms.Button();
            this.ButtonAddCard = new System.Windows.Forms.Button();
            this.ButtonDeleteCard = new System.Windows.Forms.Button();
            this.LabelCardNumber = new System.Windows.Forms.Label();
            this.TextBoxCardNumber = new System.Windows.Forms.TextBox();
            this.LabelSaldo = new System.Windows.Forms.Label();
            this.TextBoxSaldo = new System.Windows.Forms.TextBox();
            this.LabelBank = new System.Windows.Forms.Label();
            this.TextBoxBank = new System.Windows.Forms.TextBox();
            this.LabelListBoxCards = new System.Windows.Forms.Label();
            this.LabelCardType = new System.Windows.Forms.Label();
            this.TextBoxCardType = new System.Windows.Forms.TextBox();
            this.LabelCreditLimit = new System.Windows.Forms.Label();
            this.TextBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.ButtonChangeCreditLimit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientiLabel
            // 
            this.ClientiLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClientiLabel.Location = new System.Drawing.Point(198, 9);
            this.ClientiLabel.Name = "ClientiLabel";
            this.ClientiLabel.Size = new System.Drawing.Size(791, 79);
            this.ClientiLabel.TabIndex = 1;
            this.ClientiLabel.Text = "Klient";
            this.ClientiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBoxCards
            // 
            this.ListBoxCards.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxCards.FormattingEnabled = true;
            this.ListBoxCards.ItemHeight = 22;
            this.ListBoxCards.Location = new System.Drawing.Point(12, 121);
            this.ListBoxCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxCards.Name = "ListBoxCards";
            this.ListBoxCards.Size = new System.Drawing.Size(351, 444);
            this.ListBoxCards.Sorted = true;
            this.ListBoxCards.TabIndex = 6;
            this.ListBoxCards.SelectedIndexChanged += new System.EventHandler(this.ListBoxCards_SelectedIndexChanged);
            // 
            // ButtonClientReturn
            // 
            this.ButtonClientReturn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonClientReturn.Location = new System.Drawing.Point(1050, 678);
            this.ButtonClientReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonClientReturn.Name = "ButtonClientReturn";
            this.ButtonClientReturn.Size = new System.Drawing.Size(93, 49);
            this.ButtonClientReturn.TabIndex = 12;
            this.ButtonClientReturn.Text = "Wstecz";
            this.ButtonClientReturn.UseVisualStyleBackColor = true;
            this.ButtonClientReturn.Click += new System.EventHandler(this.ButtonClientReturn_Click);
            // 
            // ButtonAddCard
            // 
            this.ButtonAddCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonAddCard.Location = new System.Drawing.Point(876, 143);
            this.ButtonAddCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddCard.Name = "ButtonAddCard";
            this.ButtonAddCard.Size = new System.Drawing.Size(267, 49);
            this.ButtonAddCard.TabIndex = 14;
            this.ButtonAddCard.Text = "Dodaj Kartę";
            this.ButtonAddCard.UseVisualStyleBackColor = true;
            this.ButtonAddCard.Click += new System.EventHandler(this.ButtonAddCard_Click);
            // 
            // ButtonDeleteCard
            // 
            this.ButtonDeleteCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonDeleteCard.Location = new System.Drawing.Point(876, 223);
            this.ButtonDeleteCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonDeleteCard.Name = "ButtonDeleteCard";
            this.ButtonDeleteCard.Size = new System.Drawing.Size(267, 49);
            this.ButtonDeleteCard.TabIndex = 15;
            this.ButtonDeleteCard.Text = "Usuń Kartę";
            this.ButtonDeleteCard.UseVisualStyleBackColor = true;
            this.ButtonDeleteCard.Click += new System.EventHandler(this.ButtonDeleteCard_Click);
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.AutoSize = true;
            this.LabelCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCardNumber.Location = new System.Drawing.Point(460, 197);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(130, 23);
            this.LabelCardNumber.TabIndex = 19;
            this.LabelCardNumber.Text = "Numer Karty";
            // 
            // TextBoxCardNumber
            // 
            this.TextBoxCardNumber.BackColor = System.Drawing.Color.White;
            this.TextBoxCardNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCardNumber.Location = new System.Drawing.Point(464, 223);
            this.TextBoxCardNumber.Name = "TextBoxCardNumber";
            this.TextBoxCardNumber.ReadOnly = true;
            this.TextBoxCardNumber.Size = new System.Drawing.Size(309, 32);
            this.TextBoxCardNumber.TabIndex = 18;
            // 
            // LabelSaldo
            // 
            this.LabelSaldo.AutoSize = true;
            this.LabelSaldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSaldo.Location = new System.Drawing.Point(460, 285);
            this.LabelSaldo.Name = "LabelSaldo";
            this.LabelSaldo.Size = new System.Drawing.Size(64, 23);
            this.LabelSaldo.TabIndex = 21;
            this.LabelSaldo.Text = "Saldo";
            // 
            // TextBoxSaldo
            // 
            this.TextBoxSaldo.BackColor = System.Drawing.Color.White;
            this.TextBoxSaldo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxSaldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxSaldo.Location = new System.Drawing.Point(464, 311);
            this.TextBoxSaldo.Name = "TextBoxSaldo";
            this.TextBoxSaldo.ReadOnly = true;
            this.TextBoxSaldo.Size = new System.Drawing.Size(309, 32);
            this.TextBoxSaldo.TabIndex = 20;
            // 
            // LabelBank
            // 
            this.LabelBank.AutoSize = true;
            this.LabelBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBank.Location = new System.Drawing.Point(460, 369);
            this.LabelBank.Name = "LabelBank";
            this.LabelBank.Size = new System.Drawing.Size(59, 23);
            this.LabelBank.TabIndex = 23;
            this.LabelBank.Text = "Bank";
            // 
            // TextBoxBank
            // 
            this.TextBoxBank.BackColor = System.Drawing.Color.White;
            this.TextBoxBank.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxBank.Location = new System.Drawing.Point(464, 395);
            this.TextBoxBank.Name = "TextBoxBank";
            this.TextBoxBank.ReadOnly = true;
            this.TextBoxBank.Size = new System.Drawing.Size(309, 32);
            this.TextBoxBank.TabIndex = 22;
            // 
            // LabelListBoxCards
            // 
            this.LabelListBoxCards.AutoSize = true;
            this.LabelListBoxCards.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelListBoxCards.Location = new System.Drawing.Point(12, 95);
            this.LabelListBoxCards.Name = "LabelListBoxCards";
            this.LabelListBoxCards.Size = new System.Drawing.Size(95, 23);
            this.LabelListBoxCards.TabIndex = 24;
            this.LabelListBoxCards.Text = "Lista Kart";
            // 
            // LabelCardType
            // 
            this.LabelCardType.AutoSize = true;
            this.LabelCardType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCardType.Location = new System.Drawing.Point(460, 117);
            this.LabelCardType.Name = "LabelCardType";
            this.LabelCardType.Size = new System.Drawing.Size(98, 23);
            this.LabelCardType.TabIndex = 26;
            this.LabelCardType.Text = "Typ Karty";
            // 
            // TextBoxCardType
            // 
            this.TextBoxCardType.BackColor = System.Drawing.Color.White;
            this.TextBoxCardType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxCardType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCardType.Location = new System.Drawing.Point(464, 143);
            this.TextBoxCardType.Name = "TextBoxCardType";
            this.TextBoxCardType.ReadOnly = true;
            this.TextBoxCardType.Size = new System.Drawing.Size(309, 32);
            this.TextBoxCardType.TabIndex = 25;
            // 
            // LabelCreditLimit
            // 
            this.LabelCreditLimit.AutoSize = true;
            this.LabelCreditLimit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCreditLimit.Location = new System.Drawing.Point(460, 507);
            this.LabelCreditLimit.Name = "LabelCreditLimit";
            this.LabelCreditLimit.Size = new System.Drawing.Size(134, 23);
            this.LabelCreditLimit.TabIndex = 28;
            this.LabelCreditLimit.Text = "Limit Kredytu";
            this.LabelCreditLimit.Visible = false;
            // 
            // TextBoxCreditLimit
            // 
            this.TextBoxCreditLimit.BackColor = System.Drawing.Color.White;
            this.TextBoxCreditLimit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxCreditLimit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCreditLimit.Location = new System.Drawing.Point(464, 533);
            this.TextBoxCreditLimit.Name = "TextBoxCreditLimit";
            this.TextBoxCreditLimit.ReadOnly = true;
            this.TextBoxCreditLimit.Size = new System.Drawing.Size(309, 32);
            this.TextBoxCreditLimit.TabIndex = 27;
            this.TextBoxCreditLimit.Visible = false;
            // 
            // ButtonChangeCreditLimit
            // 
            this.ButtonChangeCreditLimit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonChangeCreditLimit.Location = new System.Drawing.Point(876, 523);
            this.ButtonChangeCreditLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonChangeCreditLimit.Name = "ButtonChangeCreditLimit";
            this.ButtonChangeCreditLimit.Size = new System.Drawing.Size(267, 49);
            this.ButtonChangeCreditLimit.TabIndex = 29;
            this.ButtonChangeCreditLimit.Text = "Zmień limit kredytu";
            this.ButtonChangeCreditLimit.UseVisualStyleBackColor = true;
            this.ButtonChangeCreditLimit.Visible = false;
            this.ButtonChangeCreditLimit.Click += new System.EventHandler(this.ButtonChangeCreditLimit_Click);
            // 
            // FKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 753);
            this.Controls.Add(this.ButtonChangeCreditLimit);
            this.Controls.Add(this.LabelCreditLimit);
            this.Controls.Add(this.TextBoxCreditLimit);
            this.Controls.Add(this.LabelCardType);
            this.Controls.Add(this.TextBoxCardType);
            this.Controls.Add(this.LabelListBoxCards);
            this.Controls.Add(this.LabelBank);
            this.Controls.Add(this.TextBoxBank);
            this.Controls.Add(this.LabelSaldo);
            this.Controls.Add(this.TextBoxSaldo);
            this.Controls.Add(this.LabelCardNumber);
            this.Controls.Add(this.TextBoxCardNumber);
            this.Controls.Add(this.ButtonDeleteCard);
            this.Controls.Add(this.ButtonAddCard);
            this.Controls.Add(this.ButtonClientReturn);
            this.Controls.Add(this.ListBoxCards);
            this.Controls.Add(this.ClientiLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FKlient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FKlient";
            this.Load += new System.EventHandler(this.FKlient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientiLabel;
        private System.Windows.Forms.ListBox ListBoxCards;
        private System.Windows.Forms.Button ButtonClientReturn;
        private System.Windows.Forms.Button ButtonAddCard;
        private System.Windows.Forms.Button ButtonDeleteCard;
        private System.Windows.Forms.Label LabelCardNumber;
        private System.Windows.Forms.TextBox TextBoxCardNumber;
        private System.Windows.Forms.Label LabelSaldo;
        private System.Windows.Forms.TextBox TextBoxSaldo;
        private System.Windows.Forms.Label LabelBank;
        private System.Windows.Forms.TextBox TextBoxBank;
        private System.Windows.Forms.Label LabelListBoxCards;
        private System.Windows.Forms.Label LabelCardType;
        private System.Windows.Forms.TextBox TextBoxCardType;
        private System.Windows.Forms.Label LabelCreditLimit;
        private System.Windows.Forms.TextBox TextBoxCreditLimit;
        private System.Windows.Forms.Button ButtonChangeCreditLimit;
    }
}