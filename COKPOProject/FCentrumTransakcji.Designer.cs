
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
            this.CentrumTransakcjiLabel.Location = new System.Drawing.Point(343, 10);
            this.CentrumTransakcjiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CentrumTransakcjiLabel.Name = "CentrumTransakcjiLabel";
            this.CentrumTransakcjiLabel.Size = new System.Drawing.Size(217, 26);
            this.CentrumTransakcjiLabel.TabIndex = 0;
            this.CentrumTransakcjiLabel.Text = "Centrum Transakcji";
            // 
            // ListaBankow
            // 
            this.ListaBankow.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListaBankow.FormattingEnabled = true;
            this.ListaBankow.ItemHeight = 17;
            this.ListaBankow.Location = new System.Drawing.Point(22, 83);
            this.ListaBankow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListaBankow.Name = "ListaBankow";
            this.ListaBankow.Size = new System.Drawing.Size(200, 310);
            this.ListaBankow.Sorted = true;
            this.ListaBankow.TabIndex = 1;
            this.ListaBankow.SelectedIndexChanged += new System.EventHandler(this.ListaBankow_SelectedIndexChanged);
            // 
            // AddBankButton
            // 
            this.AddBankButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBankButton.Location = new System.Drawing.Point(22, 402);
            this.AddBankButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBankButton.Name = "AddBankButton";
            this.AddBankButton.Size = new System.Drawing.Size(200, 40);
            this.AddBankButton.TabIndex = 2;
            this.AddBankButton.Text = "Dodaj Bank";
            this.AddBankButton.UseVisualStyleBackColor = true;
            this.AddBankButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveBankButton
            // 
            this.RemoveBankButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveBankButton.Location = new System.Drawing.Point(22, 447);
            this.RemoveBankButton.Name = "RemoveBankButton";
            this.RemoveBankButton.Size = new System.Drawing.Size(200, 40);
            this.RemoveBankButton.TabIndex = 3;
            this.RemoveBankButton.Text = "Usun Bank";
            this.RemoveBankButton.UseVisualStyleBackColor = true;
            this.RemoveBankButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BankEditButton
            // 
            this.BankEditButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BankEditButton.Location = new System.Drawing.Point(22, 492);
            this.BankEditButton.Margin = new System.Windows.Forms.Padding(2);
            this.BankEditButton.Name = "BankEditButton";
            this.BankEditButton.Size = new System.Drawing.Size(200, 40);
            this.BankEditButton.TabIndex = 4;
            this.BankEditButton.Text = "Edytuj Nazwę Banku";
            this.BankEditButton.UseVisualStyleBackColor = true;
            this.BankEditButton.Click += new System.EventHandler(this.BankEditButton_Click);
            // 
            // GoToBankButton
            // 
            this.GoToBankButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoToBankButton.Location = new System.Drawing.Point(22, 537);
            this.GoToBankButton.Name = "GoToBankButton";
            this.GoToBankButton.Size = new System.Drawing.Size(200, 40);
            this.GoToBankButton.TabIndex = 5;
            this.GoToBankButton.Text = "Przejdź Do Banku";
            this.GoToBankButton.UseVisualStyleBackColor = true;
            this.GoToBankButton.Click += new System.EventHandler(this.GoToBankButton_Click);
            // 
            // AwaitingTransactionListBox
            // 
            this.AwaitingTransactionListBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AwaitingTransactionListBox.FormattingEnabled = true;
            this.AwaitingTransactionListBox.ItemHeight = 17;
            this.AwaitingTransactionListBox.Location = new System.Drawing.Point(245, 83);
            this.AwaitingTransactionListBox.Margin = new System.Windows.Forms.Padding(2);
            this.AwaitingTransactionListBox.Name = "AwaitingTransactionListBox";
            this.AwaitingTransactionListBox.Size = new System.Drawing.Size(200, 310);
            this.AwaitingTransactionListBox.Sorted = true;
            this.AwaitingTransactionListBox.TabIndex = 6;
            this.AwaitingTransactionListBox.SelectedIndexChanged += new System.EventHandler(this.AwaitingTransactionListBox_SelectedIndexChanged);
            // 
            // DoneTranstacionListBox
            // 
            this.DoneTranstacionListBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DoneTranstacionListBox.FormattingEnabled = true;
            this.DoneTranstacionListBox.ItemHeight = 17;
            this.DoneTranstacionListBox.Location = new System.Drawing.Point(465, 83);
            this.DoneTranstacionListBox.Margin = new System.Windows.Forms.Padding(2);
            this.DoneTranstacionListBox.Name = "DoneTranstacionListBox";
            this.DoneTranstacionListBox.Size = new System.Drawing.Size(200, 310);
            this.DoneTranstacionListBox.Sorted = true;
            this.DoneTranstacionListBox.TabIndex = 7;
            this.DoneTranstacionListBox.SelectedIndexChanged += new System.EventHandler(this.DoneTranstacionListBox_SelectedIndexChanged);
            // 
            // BankListLabel
            // 
            this.BankListLabel.AutoSize = true;
            this.BankListLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BankListLabel.Location = new System.Drawing.Point(18, 53);
            this.BankListLabel.Name = "BankListLabel";
            this.BankListLabel.Size = new System.Drawing.Size(60, 19);
            this.BankListLabel.TabIndex = 8;
            this.BankListLabel.Text = "Banki :";
            // 
            // AwaitingTransacjtionLabel
            // 
            this.AwaitingTransacjtionLabel.AutoSize = true;
            this.AwaitingTransacjtionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AwaitingTransacjtionLabel.Location = new System.Drawing.Point(241, 53);
            this.AwaitingTransacjtionLabel.Name = "AwaitingTransacjtionLabel";
            this.AwaitingTransacjtionLabel.Size = new System.Drawing.Size(198, 19);
            this.AwaitingTransacjtionLabel.TabIndex = 9;
            this.AwaitingTransacjtionLabel.Text = "Oczekujące Transakcje :";
            // 
            // TransactionArchivesLabel
            // 
            this.TransactionArchivesLabel.AutoSize = true;
            this.TransactionArchivesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransactionArchivesLabel.Location = new System.Drawing.Point(461, 53);
            this.TransactionArchivesLabel.Name = "TransactionArchivesLabel";
            this.TransactionArchivesLabel.Size = new System.Drawing.Size(178, 19);
            this.TransactionArchivesLabel.TabIndex = 10;
            this.TransactionArchivesLabel.Text = "Archiwum Transakcji :";
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddTransactionButton.Location = new System.Drawing.Point(245, 402);
            this.AddTransactionButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(200, 40);
            this.AddTransactionButton.TabIndex = 11;
            this.AddTransactionButton.Text = "Dodaj Transakcję";
            this.AddTransactionButton.UseVisualStyleBackColor = true;
            // 
            // RemoveTransactionButton
            // 
            this.RemoveTransactionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveTransactionButton.Location = new System.Drawing.Point(245, 447);
            this.RemoveTransactionButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveTransactionButton.Name = "RemoveTransactionButton";
            this.RemoveTransactionButton.Size = new System.Drawing.Size(200, 40);
            this.RemoveTransactionButton.TabIndex = 12;
            this.RemoveTransactionButton.Text = "Usuń Transakcję";
            this.RemoveTransactionButton.UseVisualStyleBackColor = true;
            this.RemoveTransactionButton.Click += new System.EventHandler(this.RemoveTransactionButton_Click);
            // 
            // AuthorizeTransactionButton
            // 
            this.AuthorizeTransactionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AuthorizeTransactionButton.Location = new System.Drawing.Point(245, 492);
            this.AuthorizeTransactionButton.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorizeTransactionButton.Name = "AuthorizeTransactionButton";
            this.AuthorizeTransactionButton.Size = new System.Drawing.Size(200, 40);
            this.AuthorizeTransactionButton.TabIndex = 13;
            this.AuthorizeTransactionButton.Text = "Autoryzuj Transakcje";
            this.AuthorizeTransactionButton.UseVisualStyleBackColor = true;
            // 
            // FCentrumTransakcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 612);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FCentrumTransakcji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centrum Transakcji";
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