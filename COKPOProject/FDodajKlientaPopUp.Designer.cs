
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
            this.LabelChooseClientType = new System.Windows.Forms.Label();
            this.LabelEnterClientName = new System.Windows.Forms.Label();
            this.LabelChooseCardType = new System.Windows.Forms.Label();
            this.LabelCardNumber = new System.Windows.Forms.Label();
            this.LabelSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxChooseClient
            // 
            this.ComboBoxChooseClient.FormattingEnabled = true;
            this.ComboBoxChooseClient.Items.AddRange(new object[] {
            "Zwykły Klient",
            "Firma"});
            this.ComboBoxChooseClient.Location = new System.Drawing.Point(50, 72);
            this.ComboBoxChooseClient.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxChooseClient.Name = "ComboBoxChooseClient";
            this.ComboBoxChooseClient.Size = new System.Drawing.Size(406, 27);
            this.ComboBoxChooseClient.TabIndex = 0;
            this.ComboBoxChooseClient.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseClient_SelectedIndexChanged);
            // 
            // TextBoxClientName
            // 
            this.TextBoxClientName.Location = new System.Drawing.Point(50, 135);
            this.TextBoxClientName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxClientName.MaxLength = 30;
            this.TextBoxClientName.Name = "TextBoxClientName";
            this.TextBoxClientName.Size = new System.Drawing.Size(406, 27);
            this.TextBoxClientName.TabIndex = 1;
            // 
            // TextBoxCardNumber
            // 
            this.TextBoxCardNumber.BackColor = System.Drawing.Color.White;
            this.TextBoxCardNumber.Location = new System.Drawing.Point(50, 261);
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
            this.TextBoxCardSaldo.Location = new System.Drawing.Point(50, 324);
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
            this.ComboBoxChooseCard.Location = new System.Drawing.Point(50, 199);
            this.ComboBoxChooseCard.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxChooseCard.Name = "ComboBoxChooseCard";
            this.ComboBoxChooseCard.Size = new System.Drawing.Size(406, 27);
            this.ComboBoxChooseCard.TabIndex = 4;
            // 
            // ButtonAcceptAddClient
            // 
            this.ButtonAcceptAddClient.Location = new System.Drawing.Point(50, 377);
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
            this.ButtonCancelAddClient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancelAddClient.Location = new System.Drawing.Point(270, 377);
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
            this.LabelWarning.BackColor = System.Drawing.Color.Transparent;
            this.LabelWarning.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelWarning.Location = new System.Drawing.Point(154, 8);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(151, 25);
            this.LabelWarning.TabIndex = 7;
            this.LabelWarning.Text = "Stwórz Klienta";
            this.LabelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelChooseClientType
            // 
            this.LabelChooseClientType.BackColor = System.Drawing.Color.Transparent;
            this.LabelChooseClientType.Location = new System.Drawing.Point(46, 40);
            this.LabelChooseClientType.Name = "LabelChooseClientType";
            this.LabelChooseClientType.Size = new System.Drawing.Size(323, 28);
            this.LabelChooseClientType.TabIndex = 8;
            this.LabelChooseClientType.Text = "Wybierz rodzaj klienta";
            this.LabelChooseClientType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelEnterClientName
            // 
            this.LabelEnterClientName.BackColor = System.Drawing.Color.Transparent;
            this.LabelEnterClientName.Location = new System.Drawing.Point(46, 107);
            this.LabelEnterClientName.Name = "LabelEnterClientName";
            this.LabelEnterClientName.Size = new System.Drawing.Size(323, 28);
            this.LabelEnterClientName.TabIndex = 9;
            this.LabelEnterClientName.Text = "Wpisz nazwę klienta";
            this.LabelEnterClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelChooseCardType
            // 
            this.LabelChooseCardType.BackColor = System.Drawing.Color.Transparent;
            this.LabelChooseCardType.Location = new System.Drawing.Point(46, 167);
            this.LabelChooseCardType.Name = "LabelChooseCardType";
            this.LabelChooseCardType.Size = new System.Drawing.Size(323, 28);
            this.LabelChooseCardType.TabIndex = 10;
            this.LabelChooseCardType.Text = "Wybierz rodzaj karty";
            this.LabelChooseCardType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelCardNumber.Location = new System.Drawing.Point(46, 230);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(323, 28);
            this.LabelCardNumber.TabIndex = 11;
            this.LabelCardNumber.Text = "(Opcjonalnie) Numer Karty";
            this.LabelCardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSaldo
            // 
            this.LabelSaldo.BackColor = System.Drawing.Color.Transparent;
            this.LabelSaldo.Location = new System.Drawing.Point(46, 292);
            this.LabelSaldo.Name = "LabelSaldo";
            this.LabelSaldo.Size = new System.Drawing.Size(323, 28);
            this.LabelSaldo.TabIndex = 12;
            this.LabelSaldo.Text = "(Opcjonalnie) Saldo";
            this.LabelSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FDodajKlientaPopUp
            // 
            this.AcceptButton = this.ButtonAcceptAddClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::COKPOProject.Properties.Resources.Tlo_1;
            this.CancelButton = this.ButtonCancelAddClient;
            this.ClientSize = new System.Drawing.Size(512, 454);
            this.Controls.Add(this.LabelSaldo);
            this.Controls.Add(this.LabelCardNumber);
            this.Controls.Add(this.LabelChooseCardType);
            this.Controls.Add(this.LabelEnterClientName);
            this.Controls.Add(this.LabelChooseClientType);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label LabelChooseClientType;
        private System.Windows.Forms.Label LabelEnterClientName;
        private System.Windows.Forms.Label LabelChooseCardType;
        private System.Windows.Forms.Label LabelCardNumber;
        private System.Windows.Forms.Label LabelSaldo;
    }
}