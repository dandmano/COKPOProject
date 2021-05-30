
namespace COKPOProject
{
    partial class FCentrumTransakcji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCentrumTransakcji));
            this.CentrumTransakcjiLabel = new System.Windows.Forms.Label();
            this.ListaBankow = new System.Windows.Forms.ListBox();
            this.AddBankButton = new System.Windows.Forms.Button();
            this.RemoveBankButton = new System.Windows.Forms.Button();
            this.BankEditButton = new System.Windows.Forms.Button();
            this.GoToBankButton = new System.Windows.Forms.Button();
            this.AwaitingTransactionListBox = new System.Windows.Forms.ListBox();
            this.DoneTranstacionListBox = new System.Windows.Forms.ListBox();
            this.BankListLabel = new System.Windows.Forms.Label();
            this.AwaitingTransacjtionLabel = new System.Windows.Forms.Label();
            this.TransactionArchivesLabel = new System.Windows.Forms.Label();
            this.AddTransactionButton = new System.Windows.Forms.Button();
            this.RemoveTransactionButton = new System.Windows.Forms.Button();
            this.AuthorizeTransactionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CentrumTransakcjiLabel
            // 
            this.CentrumTransakcjiLabel.AutoSize = true;
            this.CentrumTransakcjiLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CentrumTransakcjiLabel.Location = new System.Drawing.Point(463, 12);
            this.CentrumTransakcjiLabel.Name = "CentrumTransakcjiLabel";
            this.CentrumTransakcjiLabel.Size = new System.Drawing.Size(274, 34);
            this.CentrumTransakcjiLabel.TabIndex = 0;
            this.CentrumTransakcjiLabel.Text = "Centrum Transakcji";
            // 
            // ListaBankow
            // 
            this.ListaBankow.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListaBankow.FormattingEnabled = true;
            this.ListaBankow.ItemHeight = 22;
            this.ListaBankow.Location = new System.Drawing.Point(29, 102);
            this.ListaBankow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListaBankow.Name = "ListaBankow";
            this.ListaBankow.Size = new System.Drawing.Size(265, 378);
            this.ListaBankow.Sorted = true;
            this.ListaBankow.TabIndex = 1;
            // 
            // AddBankButton
            // 
            this.AddBankButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBankButton.Location = new System.Drawing.Point(29, 495);
            this.AddBankButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBankButton.Name = "AddBankButton";
            this.AddBankButton.Size = new System.Drawing.Size(267, 49);
            this.AddBankButton.TabIndex = 2;
            this.AddBankButton.Text = "Dodaj Bank";
            this.AddBankButton.UseVisualStyleBackColor = true;
            this.AddBankButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveBankButton
            // 
            this.RemoveBankButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveBankButton.Location = new System.Drawing.Point(29, 550);
            this.RemoveBankButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveBankButton.Name = "RemoveBankButton";
            this.RemoveBankButton.Size = new System.Drawing.Size(267, 49);
            this.RemoveBankButton.TabIndex = 3;
            this.RemoveBankButton.Text = "Usun Bank";
            this.RemoveBankButton.UseVisualStyleBackColor = true;
            this.RemoveBankButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BankEditButton
            // 
            this.BankEditButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BankEditButton.Location = new System.Drawing.Point(29, 606);
            this.BankEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BankEditButton.Name = "BankEditButton";
            this.BankEditButton.Size = new System.Drawing.Size(267, 49);
            this.BankEditButton.TabIndex = 4;
            this.BankEditButton.Text = "Edytuj Nazwę Banku";
            this.BankEditButton.UseVisualStyleBackColor = true;
            this.BankEditButton.Click += new System.EventHandler(this.BankEditButton_Click);
            // 
            // GoToBankButton
            // 
            this.GoToBankButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoToBankButton.Location = new System.Drawing.Point(29, 661);
            this.GoToBankButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoToBankButton.Name = "GoToBankButton";
            this.GoToBankButton.Size = new System.Drawing.Size(267, 49);
            this.GoToBankButton.TabIndex = 5;
            this.GoToBankButton.Text = "Przejdź Do Banku";
            this.GoToBankButton.UseVisualStyleBackColor = true;
            this.GoToBankButton.Click += new System.EventHandler(this.GoToBankButton_Click);
            // 
            // AwaitingTransactionListBox
            // 
            this.AwaitingTransactionListBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AwaitingTransactionListBox.FormattingEnabled = true;
            this.AwaitingTransactionListBox.ItemHeight = 22;
            this.AwaitingTransactionListBox.Location = new System.Drawing.Point(327, 102);
            this.AwaitingTransactionListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AwaitingTransactionListBox.Name = "AwaitingTransactionListBox";
            this.AwaitingTransactionListBox.Size = new System.Drawing.Size(265, 378);
            this.AwaitingTransactionListBox.Sorted = true;
            this.AwaitingTransactionListBox.TabIndex = 6;
            this.AwaitingTransactionListBox.SelectedIndexChanged += new System.EventHandler(this.AwaitingTransactionListBox_SelectedIndexChanged);
            // 
            // DoneTranstacionListBox
            // 
            this.DoneTranstacionListBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DoneTranstacionListBox.FormattingEnabled = true;
            this.DoneTranstacionListBox.ItemHeight = 22;
            this.DoneTranstacionListBox.Location = new System.Drawing.Point(620, 102);
            this.DoneTranstacionListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoneTranstacionListBox.Name = "DoneTranstacionListBox";
            this.DoneTranstacionListBox.Size = new System.Drawing.Size(265, 378);
            this.DoneTranstacionListBox.Sorted = true;
            this.DoneTranstacionListBox.TabIndex = 7;
            this.DoneTranstacionListBox.SelectedIndexChanged += new System.EventHandler(this.DoneTranstacionListBox_SelectedIndexChanged);
            // 
            // BankListLabel
            // 
            this.BankListLabel.AutoSize = true;
            this.BankListLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BankListLabel.Location = new System.Drawing.Point(24, 65);
            this.BankListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BankListLabel.Name = "BankListLabel";
            this.BankListLabel.Size = new System.Drawing.Size(76, 23);
            this.BankListLabel.TabIndex = 8;
            this.BankListLabel.Text = "Banki :";
            // 
            // AwaitingTransacjtionLabel
            // 
            this.AwaitingTransacjtionLabel.AutoSize = true;
            this.AwaitingTransacjtionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AwaitingTransacjtionLabel.Location = new System.Drawing.Point(321, 65);
            this.AwaitingTransacjtionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AwaitingTransacjtionLabel.Name = "AwaitingTransacjtionLabel";
            this.AwaitingTransacjtionLabel.Size = new System.Drawing.Size(252, 23);
            this.AwaitingTransacjtionLabel.TabIndex = 9;
            this.AwaitingTransacjtionLabel.Text = "Oczekujące Transakcje :";
            // 
            // TransactionArchivesLabel
            // 
            this.TransactionArchivesLabel.AutoSize = true;
            this.TransactionArchivesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransactionArchivesLabel.Location = new System.Drawing.Point(615, 65);
            this.TransactionArchivesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransactionArchivesLabel.Name = "TransactionArchivesLabel";
            this.TransactionArchivesLabel.Size = new System.Drawing.Size(222, 23);
            this.TransactionArchivesLabel.TabIndex = 10;
            this.TransactionArchivesLabel.Text = "Archiwum Transakcji :";
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddTransactionButton.Location = new System.Drawing.Point(327, 495);
            this.AddTransactionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(267, 49);
            this.AddTransactionButton.TabIndex = 11;
            this.AddTransactionButton.Text = "Dodaj Transakcję";
            this.AddTransactionButton.UseVisualStyleBackColor = true;
            // 
            // RemoveTransactionButton
            // 
            this.RemoveTransactionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveTransactionButton.Location = new System.Drawing.Point(327, 550);
            this.RemoveTransactionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveTransactionButton.Name = "RemoveTransactionButton";
            this.RemoveTransactionButton.Size = new System.Drawing.Size(267, 49);
            this.RemoveTransactionButton.TabIndex = 12;
            this.RemoveTransactionButton.Text = "Usuń Transakcję";
            this.RemoveTransactionButton.UseVisualStyleBackColor = true;
            this.RemoveTransactionButton.Click += new System.EventHandler(this.RemoveTransactionButton_Click);
            // 
            // AuthorizeTransactionButton
            // 
            this.AuthorizeTransactionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AuthorizeTransactionButton.Location = new System.Drawing.Point(327, 606);
            this.AuthorizeTransactionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthorizeTransactionButton.Name = "AuthorizeTransactionButton";
            this.AuthorizeTransactionButton.Size = new System.Drawing.Size(267, 49);
            this.AuthorizeTransactionButton.TabIndex = 13;
            this.AuthorizeTransactionButton.Text = "Autoryzuj Transakcje";
            this.AuthorizeTransactionButton.UseVisualStyleBackColor = true;
            // 
            // FCentrumTransakcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.AuthorizeTransactionButton);
            this.Controls.Add(this.RemoveTransactionButton);
            this.Controls.Add(this.AddTransactionButton);
            this.Controls.Add(this.TransactionArchivesLabel);
            this.Controls.Add(this.AwaitingTransacjtionLabel);
            this.Controls.Add(this.BankListLabel);
            this.Controls.Add(this.DoneTranstacionListBox);
            this.Controls.Add(this.AwaitingTransactionListBox);
            this.Controls.Add(this.GoToBankButton);
            this.Controls.Add(this.BankEditButton);
            this.Controls.Add(this.RemoveBankButton);
            this.Controls.Add(this.AddBankButton);
            this.Controls.Add(this.ListaBankow);
            this.Controls.Add(this.CentrumTransakcjiLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FCentrumTransakcji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centrum Transakcji";
            this.Load += new System.EventHandler(this.FCentrumTransakcji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CentrumTransakcjiLabel;
        private System.Windows.Forms.ListBox ListaBankow;
        private System.Windows.Forms.Button AddBankButton;
        private System.Windows.Forms.Button RemoveBankButton;
        private System.Windows.Forms.Button BankEditButton;
        private System.Windows.Forms.Button GoToBankButton;
        private System.Windows.Forms.ListBox AwaitingTransactionListBox;
        private System.Windows.Forms.ListBox DoneTranstacionListBox;
        private System.Windows.Forms.Label BankListLabel;
        private System.Windows.Forms.Label AwaitingTransacjtionLabel;
        private System.Windows.Forms.Label TransactionArchivesLabel;
        private System.Windows.Forms.Button AddTransactionButton;
        private System.Windows.Forms.Button RemoveTransactionButton;
        private System.Windows.Forms.Button AuthorizeTransactionButton;
    }
}