
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
            this.ComboBoxChooseClient = new System.Windows.Forms.ComboBox();
            this.TextBoxClientName = new System.Windows.Forms.TextBox();
            this.TextBoxCardNumber = new System.Windows.Forms.TextBox();
            this.TextBoxCardSaldo = new System.Windows.Forms.TextBox();
            this.ComboBoxChooseCard = new System.Windows.Forms.ComboBox();
            this.ButtonAcceptAddClient = new System.Windows.Forms.Button();
            this.ButtonCancelAddClient = new System.Windows.Forms.Button();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxChooseClient
            // 
            this.ComboBoxChooseClient.FormattingEnabled = true;
            this.ComboBoxChooseClient.Items.AddRange(new object[] {
            "Klient Zwykły",
            "Klient Centrum"});
            this.ComboBoxChooseClient.Location = new System.Drawing.Point(50, 72);
            this.ComboBoxChooseClient.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxChooseClient.Name = "ComboBoxChooseClient";
            this.ComboBoxChooseClient.Size = new System.Drawing.Size(406, 31);
            this.ComboBoxChooseClient.TabIndex = 0;
            this.ComboBoxChooseClient.Text = "Wybierz rodzaj klienta";
            this.ComboBoxChooseClient.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseClient_SelectedIndexChanged);
            // 
            // TextBoxClientName
            // 
            this.TextBoxClientName.Location = new System.Drawing.Point(50, 128);
            this.TextBoxClientName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxClientName.MaxLength = 30;
            this.TextBoxClientName.Name = "TextBoxClientName";
            this.TextBoxClientName.Size = new System.Drawing.Size(406, 32);
            this.TextBoxClientName.TabIndex = 1;
            this.TextBoxClientName.Text = "Wpisz nazwę klienta";
            this.TextBoxClientName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxClientName_KeyDown);
            // 
            // TextBoxCardNumber
            // 
            this.TextBoxCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextBoxCardNumber.Location = new System.Drawing.Point(50, 243);
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
            this.TextBoxCardSaldo.Location = new System.Drawing.Point(50, 296);
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
            this.ComboBoxChooseCard.Location = new System.Drawing.Point(50, 184);
            this.ComboBoxChooseCard.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxChooseCard.Name = "ComboBoxChooseCard";
            this.ComboBoxChooseCard.Size = new System.Drawing.Size(406, 31);
            this.ComboBoxChooseCard.TabIndex = 4;
            this.ComboBoxChooseCard.Text = "Wybierz rodzaj karty";
            this.ComboBoxChooseCard.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseCard_SelectedIndexChanged);
            // 
            // ButtonAcceptAddClient
            // 
            this.ButtonAcceptAddClient.Location = new System.Drawing.Point(50, 364);
            this.ButtonAcceptAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAcceptAddClient.Name = "ButtonAcceptAddClient";
            this.ButtonAcceptAddClient.Size = new System.Drawing.Size(186, 52);
            this.ButtonAcceptAddClient.TabIndex = 5;
            this.ButtonAcceptAddClient.Text = "Akceptuj";
            this.ButtonAcceptAddClient.UseVisualStyleBackColor = true;
            this.ButtonAcceptAddClient.Click += new System.EventHandler(this.ButtonAcceptAddClient_Click);
            // 
            // ButtonCancelAddClient
            // 
            this.ButtonCancelAddClient.Location = new System.Drawing.Point(272, 364);
            this.ButtonCancelAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancelAddClient.Name = "ButtonCancelAddClient";
            this.ButtonCancelAddClient.Size = new System.Drawing.Size(186, 52);
            this.ButtonCancelAddClient.TabIndex = 6;
            this.ButtonCancelAddClient.Text = "Anuluj";
            this.ButtonCancelAddClient.UseVisualStyleBackColor = true;
            this.ButtonCancelAddClient.Click += new System.EventHandler(this.ButtonCancelAddClient_Click);
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.Location = new System.Drawing.Point(54, 29);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(402, 23);
            this.LabelWarning.TabIndex = 7;
            this.LabelWarning.Text = "Wpisywane wartości potwierdź enterem!";
            // 
            // FDodajKlientaPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(512, 442);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.ButtonCancelAddClient);
            this.Controls.Add(this.ButtonAcceptAddClient);
            this.Controls.Add(this.ComboBoxChooseCard);
            this.Controls.Add(this.TextBoxCardSaldo);
            this.Controls.Add(this.TextBoxCardNumber);
            this.Controls.Add(this.TextBoxClientName);
            this.Controls.Add(this.ComboBoxChooseClient);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDodajKlientaPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDodajKlientaPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxChooseClient;
        private System.Windows.Forms.TextBox TextBoxClientName;
        private System.Windows.Forms.TextBox TextBoxCardNumber;
        private System.Windows.Forms.TextBox TextBoxCardSaldo;
        private System.Windows.Forms.ComboBox ComboBoxChooseCard;
        private System.Windows.Forms.Button ButtonAcceptAddClient;
        private System.Windows.Forms.Button ButtonCancelAddClient;
        private System.Windows.Forms.Label LabelWarning;
    }
}