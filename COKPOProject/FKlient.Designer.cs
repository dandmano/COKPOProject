
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
            this.ButtonDonate = new System.Windows.Forms.Button();
            this.ButtonWithdraw = new System.Windows.Forms.Button();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientiLabel
            // 
            this.ClientiLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientiLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClientiLabel.Location = new System.Drawing.Point(148, 7);
            this.ClientiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientiLabel.Name = "ClientiLabel";
            this.ClientiLabel.Size = new System.Drawing.Size(593, 64);
            this.ClientiLabel.TabIndex = 1;
            this.ClientiLabel.Text = "Klient";
            this.ClientiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBoxCards
            // 
            this.ListBoxCards.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxCards.FormattingEnabled = true;
            this.ListBoxCards.ItemHeight = 17;
            this.ListBoxCards.Location = new System.Drawing.Point(9, 98);
            this.ListBoxCards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListBoxCards.Name = "ListBoxCards";
            this.ListBoxCards.Size = new System.Drawing.Size(264, 361);
            this.ListBoxCards.Sorted = true;
            this.ListBoxCards.TabIndex = 6;
            this.ListBoxCards.SelectedIndexChanged += new System.EventHandler(this.ListBoxCards_SelectedIndexChanged);
            // 
            // ButtonClientReturn
            // 
            this.ButtonClientReturn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonClientReturn.Location = new System.Drawing.Point(788, 551);
            this.ButtonClientReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonClientReturn.Name = "ButtonClientReturn";
            this.ButtonClientReturn.Size = new System.Drawing.Size(70, 40);
            this.ButtonClientReturn.TabIndex = 12;
            this.ButtonClientReturn.Text = "Wstecz";
            this.ButtonClientReturn.UseVisualStyleBackColor = true;
            this.ButtonClientReturn.Click += new System.EventHandler(this.ButtonClientReturn_Click);
            // 
            // ButtonAddCard
            // 
            this.ButtonAddCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonAddCard.Location = new System.Drawing.Point(657, 116);
            this.ButtonAddCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAddCard.Name = "ButtonAddCard";
            this.ButtonAddCard.Size = new System.Drawing.Size(200, 40);
            this.ButtonAddCard.TabIndex = 14;
            this.ButtonAddCard.Text = "Dodaj Kartę";
            this.ButtonAddCard.UseVisualStyleBackColor = true;
            this.ButtonAddCard.Click += new System.EventHandler(this.ButtonAddCard_Click);
            // 
            // ButtonDeleteCard
            // 
            this.ButtonDeleteCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonDeleteCard.Location = new System.Drawing.Point(657, 181);
            this.ButtonDeleteCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonDeleteCard.Name = "ButtonDeleteCard";
            this.ButtonDeleteCard.Size = new System.Drawing.Size(200, 40);
            this.ButtonDeleteCard.TabIndex = 15;
            this.ButtonDeleteCard.Text = "Usuń Kartę";
            this.ButtonDeleteCard.UseVisualStyleBackColor = true;
            this.ButtonDeleteCard.Click += new System.EventHandler(this.ButtonDeleteCard_Click);
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.AutoSize = true;
            this.LabelCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCardNumber.Location = new System.Drawing.Point(345, 160);
            this.LabelCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(105, 19);
            this.LabelCardNumber.TabIndex = 19;
            this.LabelCardNumber.Text = "Numer Karty";
            // 
            // TextBoxCardNumber
            // 
            this.TextBoxCardNumber.BackColor = System.Drawing.Color.White;
            this.TextBoxCardNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCardNumber.Location = new System.Drawing.Point(348, 181);
            this.TextBoxCardNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxCardNumber.Name = "TextBoxCardNumber";
            this.TextBoxCardNumber.ReadOnly = true;
            this.TextBoxCardNumber.Size = new System.Drawing.Size(233, 27);
            this.TextBoxCardNumber.TabIndex = 18;
            // 
            // LabelSaldo
            // 
            this.LabelSaldo.AutoSize = true;
            this.LabelSaldo.BackColor = System.Drawing.Color.Transparent;
            this.LabelSaldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSaldo.Location = new System.Drawing.Point(345, 232);
            this.LabelSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSaldo.Name = "LabelSaldo";
            this.LabelSaldo.Size = new System.Drawing.Size(53, 19);
            this.LabelSaldo.TabIndex = 21;
            this.LabelSaldo.Text = "Saldo";
            // 
            // TextBoxSaldo
            // 
            this.TextBoxSaldo.BackColor = System.Drawing.Color.White;
            this.TextBoxSaldo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxSaldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxSaldo.Location = new System.Drawing.Point(348, 253);
            this.TextBoxSaldo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxSaldo.Name = "TextBoxSaldo";
            this.TextBoxSaldo.ReadOnly = true;
            this.TextBoxSaldo.Size = new System.Drawing.Size(233, 27);
            this.TextBoxSaldo.TabIndex = 20;
            // 
            // LabelBank
            // 
            this.LabelBank.AutoSize = true;
            this.LabelBank.BackColor = System.Drawing.Color.Transparent;
            this.LabelBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBank.Location = new System.Drawing.Point(345, 300);
            this.LabelBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBank.Name = "LabelBank";
            this.LabelBank.Size = new System.Drawing.Size(48, 19);
            this.LabelBank.TabIndex = 23;
            this.LabelBank.Text = "Bank";
            // 
            // TextBoxBank
            // 
            this.TextBoxBank.BackColor = System.Drawing.Color.White;
            this.TextBoxBank.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxBank.Location = new System.Drawing.Point(348, 321);
            this.TextBoxBank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxBank.Name = "TextBoxBank";
            this.TextBoxBank.ReadOnly = true;
            this.TextBoxBank.Size = new System.Drawing.Size(233, 27);
            this.TextBoxBank.TabIndex = 22;
            // 
            // LabelListBoxCards
            // 
            this.LabelListBoxCards.AutoSize = true;
            this.LabelListBoxCards.BackColor = System.Drawing.Color.Transparent;
            this.LabelListBoxCards.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelListBoxCards.Location = new System.Drawing.Point(9, 77);
            this.LabelListBoxCards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelListBoxCards.Name = "LabelListBoxCards";
            this.LabelListBoxCards.Size = new System.Drawing.Size(75, 19);
            this.LabelListBoxCards.TabIndex = 24;
            this.LabelListBoxCards.Text = "Lista Kart";
            // 
            // LabelCardType
            // 
            this.LabelCardType.AutoSize = true;
            this.LabelCardType.BackColor = System.Drawing.Color.Transparent;
            this.LabelCardType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCardType.Location = new System.Drawing.Point(345, 95);
            this.LabelCardType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCardType.Name = "LabelCardType";
            this.LabelCardType.Size = new System.Drawing.Size(79, 19);
            this.LabelCardType.TabIndex = 26;
            this.LabelCardType.Text = "Typ Karty";
            // 
            // TextBoxCardType
            // 
            this.TextBoxCardType.BackColor = System.Drawing.Color.White;
            this.TextBoxCardType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxCardType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCardType.Location = new System.Drawing.Point(348, 116);
            this.TextBoxCardType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxCardType.Name = "TextBoxCardType";
            this.TextBoxCardType.ReadOnly = true;
            this.TextBoxCardType.Size = new System.Drawing.Size(233, 27);
            this.TextBoxCardType.TabIndex = 25;
            // 
            // LabelCreditLimit
            // 
            this.LabelCreditLimit.AutoSize = true;
            this.LabelCreditLimit.BackColor = System.Drawing.Color.Transparent;
            this.LabelCreditLimit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCreditLimit.Location = new System.Drawing.Point(345, 412);
            this.LabelCreditLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCreditLimit.Name = "LabelCreditLimit";
            this.LabelCreditLimit.Size = new System.Drawing.Size(107, 19);
            this.LabelCreditLimit.TabIndex = 28;
            this.LabelCreditLimit.Text = "Limit Kredytu";
            this.LabelCreditLimit.Visible = false;
            // 
            // TextBoxCreditLimit
            // 
            this.TextBoxCreditLimit.BackColor = System.Drawing.Color.White;
            this.TextBoxCreditLimit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxCreditLimit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCreditLimit.Location = new System.Drawing.Point(348, 433);
            this.TextBoxCreditLimit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxCreditLimit.Name = "TextBoxCreditLimit";
            this.TextBoxCreditLimit.ReadOnly = true;
            this.TextBoxCreditLimit.Size = new System.Drawing.Size(233, 27);
            this.TextBoxCreditLimit.TabIndex = 27;
            this.TextBoxCreditLimit.Visible = false;
            // 
            // ButtonChangeCreditLimit
            // 
            this.ButtonChangeCreditLimit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonChangeCreditLimit.Location = new System.Drawing.Point(657, 425);
            this.ButtonChangeCreditLimit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonChangeCreditLimit.Name = "ButtonChangeCreditLimit";
            this.ButtonChangeCreditLimit.Size = new System.Drawing.Size(200, 40);
            this.ButtonChangeCreditLimit.TabIndex = 29;
            this.ButtonChangeCreditLimit.Text = "Zmień limit kredytu";
            this.ButtonChangeCreditLimit.UseVisualStyleBackColor = true;
            this.ButtonChangeCreditLimit.Visible = false;
            this.ButtonChangeCreditLimit.Click += new System.EventHandler(this.ButtonChangeCreditLimit_Click);
            // 
            // ButtonDonate
            // 
            this.ButtonDonate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonDonate.Location = new System.Drawing.Point(657, 308);
            this.ButtonDonate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonDonate.Name = "ButtonDonate";
            this.ButtonDonate.Size = new System.Drawing.Size(200, 40);
            this.ButtonDonate.TabIndex = 30;
            this.ButtonDonate.Text = "Wpłać";
            this.ButtonDonate.UseVisualStyleBackColor = true;
            this.ButtonDonate.Click += new System.EventHandler(this.ButtonDonate_Click);
            // 
            // ButtonWithdraw
            // 
            this.ButtonWithdraw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonWithdraw.Location = new System.Drawing.Point(657, 352);
            this.ButtonWithdraw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonWithdraw.Name = "ButtonWithdraw";
            this.ButtonWithdraw.Size = new System.Drawing.Size(200, 40);
            this.ButtonWithdraw.TabIndex = 31;
            this.ButtonWithdraw.Text = "Wypłać";
            this.ButtonWithdraw.UseVisualStyleBackColor = true;
            this.ButtonWithdraw.Click += new System.EventHandler(this.ButtonWithdraw_Click);
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.BackColor = System.Drawing.Color.White;
            this.TextBoxAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxAmount.Location = new System.Drawing.Point(657, 277);
            this.TextBoxAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(201, 27);
            this.TextBoxAmount.TabIndex = 32;
            this.TextBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAmount_KeyPress);
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.BackColor = System.Drawing.Color.Transparent;
            this.LabelAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAmount.Location = new System.Drawing.Point(653, 253);
            this.LabelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(57, 19);
            this.LabelAmount.TabIndex = 33;
            this.LabelAmount.Text = "Kwota";
            // 
            // FKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COKPOProject.Properties.Resources.Tlo_1;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.TextBoxAmount);
            this.Controls.Add(this.ButtonWithdraw);
            this.Controls.Add(this.ButtonDonate);
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
        private System.Windows.Forms.Button ButtonDonate;
        private System.Windows.Forms.Button ButtonWithdraw;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.Label LabelAmount;
    }
}