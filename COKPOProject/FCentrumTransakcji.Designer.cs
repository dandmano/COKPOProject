
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
            this.LabelCentrumTransakcji = new System.Windows.Forms.Label();
            this.ListBoxBanks = new System.Windows.Forms.ListBox();
            this.ButtonAddBank = new System.Windows.Forms.Button();
            this.ButtonRemoveBank = new System.Windows.Forms.Button();
            this.ButtonEditBank = new System.Windows.Forms.Button();
            this.ButtonGoToBank = new System.Windows.Forms.Button();
            this.ListBoxAwaitingTransaction = new System.Windows.Forms.ListBox();
            this.ListBoxDoneTransaction = new System.Windows.Forms.ListBox();
            this.LabelBankList = new System.Windows.Forms.Label();
            this.LabelAwaitingTransacjtion = new System.Windows.Forms.Label();
            this.LabelTransactionArchives = new System.Windows.Forms.Label();
            this.ButtonAddTransaction = new System.Windows.Forms.Button();
            this.ButtonRemoveTransaction = new System.Windows.Forms.Button();
            this.ButtonAuthorizeTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCentrumTransakcji
            // 
            this.LabelCentrumTransakcji.AutoSize = true;
            this.LabelCentrumTransakcji.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCentrumTransakcji.Location = new System.Drawing.Point(427, 9);
            this.LabelCentrumTransakcji.Name = "LabelCentrumTransakcji";
            this.LabelCentrumTransakcji.Size = new System.Drawing.Size(326, 39);
            this.LabelCentrumTransakcji.TabIndex = 0;
            this.LabelCentrumTransakcji.Text = "Centrum Transakcji";
            // 
            // ListBoxBanks
            // 
            this.ListBoxBanks.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxBanks.FormattingEnabled = true;
            this.ListBoxBanks.ItemHeight = 22;
            this.ListBoxBanks.Location = new System.Drawing.Point(29, 102);
            this.ListBoxBanks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxBanks.Name = "ListBoxBanks";
            this.ListBoxBanks.Size = new System.Drawing.Size(265, 378);
            this.ListBoxBanks.Sorted = true;
            this.ListBoxBanks.TabIndex = 1;
            // 
            // ButtonAddBank
            // 
            this.ButtonAddBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAddBank.Location = new System.Drawing.Point(29, 495);
            this.ButtonAddBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddBank.Name = "ButtonAddBank";
            this.ButtonAddBank.Size = new System.Drawing.Size(267, 49);
            this.ButtonAddBank.TabIndex = 2;
            this.ButtonAddBank.Text = "Dodaj Bank";
            this.ButtonAddBank.UseVisualStyleBackColor = true;
            this.ButtonAddBank.Click += new System.EventHandler(this.ButtonAddBank_Click);
            // 
            // ButtonRemoveBank
            // 
            this.ButtonRemoveBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRemoveBank.Location = new System.Drawing.Point(29, 550);
            this.ButtonRemoveBank.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRemoveBank.Name = "ButtonRemoveBank";
            this.ButtonRemoveBank.Size = new System.Drawing.Size(267, 49);
            this.ButtonRemoveBank.TabIndex = 3;
            this.ButtonRemoveBank.Text = "Usun Bank";
            this.ButtonRemoveBank.UseVisualStyleBackColor = true;
            this.ButtonRemoveBank.Click += new System.EventHandler(this.ButtonRemoveBank_Click);
            // 
            // ButtonEditBank
            // 
            this.ButtonEditBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEditBank.Location = new System.Drawing.Point(29, 606);
            this.ButtonEditBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonEditBank.Name = "ButtonEditBank";
            this.ButtonEditBank.Size = new System.Drawing.Size(267, 49);
            this.ButtonEditBank.TabIndex = 4;
            this.ButtonEditBank.Text = "Edytuj Nazwę Banku";
            this.ButtonEditBank.UseVisualStyleBackColor = true;
            this.ButtonEditBank.Click += new System.EventHandler(this.ButtonEditBank_Click);
            // 
            // ButtonGoToBank
            // 
            this.ButtonGoToBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonGoToBank.Location = new System.Drawing.Point(29, 661);
            this.ButtonGoToBank.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonGoToBank.Name = "ButtonGoToBank";
            this.ButtonGoToBank.Size = new System.Drawing.Size(267, 49);
            this.ButtonGoToBank.TabIndex = 5;
            this.ButtonGoToBank.Text = "Przejdź Do Banku";
            this.ButtonGoToBank.UseVisualStyleBackColor = true;
            this.ButtonGoToBank.Click += new System.EventHandler(this.ButtonGoToBank_Click);
            // 
            // ListBoxAwaitingTransaction
            // 
            this.ListBoxAwaitingTransaction.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxAwaitingTransaction.FormattingEnabled = true;
            this.ListBoxAwaitingTransaction.ItemHeight = 22;
            this.ListBoxAwaitingTransaction.Location = new System.Drawing.Point(327, 102);
            this.ListBoxAwaitingTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxAwaitingTransaction.Name = "ListBoxAwaitingTransaction";
            this.ListBoxAwaitingTransaction.Size = new System.Drawing.Size(265, 378);
            this.ListBoxAwaitingTransaction.Sorted = true;
            this.ListBoxAwaitingTransaction.TabIndex = 6;
            // 
            // ListBoxDoneTransaction
            // 
            this.ListBoxDoneTransaction.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxDoneTransaction.FormattingEnabled = true;
            this.ListBoxDoneTransaction.ItemHeight = 22;
            this.ListBoxDoneTransaction.Location = new System.Drawing.Point(620, 102);
            this.ListBoxDoneTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxDoneTransaction.Name = "ListBoxDoneTransaction";
            this.ListBoxDoneTransaction.Size = new System.Drawing.Size(265, 378);
            this.ListBoxDoneTransaction.Sorted = true;
            this.ListBoxDoneTransaction.TabIndex = 7;
            // 
            // LabelBankList
            // 
            this.LabelBankList.AutoSize = true;
            this.LabelBankList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBankList.Location = new System.Drawing.Point(24, 65);
            this.LabelBankList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBankList.Name = "LabelBankList";
            this.LabelBankList.Size = new System.Drawing.Size(76, 23);
            this.LabelBankList.TabIndex = 8;
            this.LabelBankList.Text = "Banki :";
            // 
            // LabelAwaitingTransacjtion
            // 
            this.LabelAwaitingTransacjtion.AutoSize = true;
            this.LabelAwaitingTransacjtion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAwaitingTransacjtion.Location = new System.Drawing.Point(321, 65);
            this.LabelAwaitingTransacjtion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAwaitingTransacjtion.Name = "LabelAwaitingTransacjtion";
            this.LabelAwaitingTransacjtion.Size = new System.Drawing.Size(252, 23);
            this.LabelAwaitingTransacjtion.TabIndex = 9;
            this.LabelAwaitingTransacjtion.Text = "Oczekujące Transakcje :";
            // 
            // LabelTransactionArchives
            // 
            this.LabelTransactionArchives.AutoSize = true;
            this.LabelTransactionArchives.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTransactionArchives.Location = new System.Drawing.Point(615, 65);
            this.LabelTransactionArchives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTransactionArchives.Name = "LabelTransactionArchives";
            this.LabelTransactionArchives.Size = new System.Drawing.Size(222, 23);
            this.LabelTransactionArchives.TabIndex = 10;
            this.LabelTransactionArchives.Text = "Archiwum Transakcji :";
            // 
            // ButtonAddTransaction
            // 
            this.ButtonAddTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAddTransaction.Location = new System.Drawing.Point(327, 495);
            this.ButtonAddTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddTransaction.Name = "ButtonAddTransaction";
            this.ButtonAddTransaction.Size = new System.Drawing.Size(267, 49);
            this.ButtonAddTransaction.TabIndex = 11;
            this.ButtonAddTransaction.Text = "Dodaj Transakcję";
            this.ButtonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // ButtonRemoveTransaction
            // 
            this.ButtonRemoveTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRemoveTransaction.Location = new System.Drawing.Point(327, 550);
            this.ButtonRemoveTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonRemoveTransaction.Name = "ButtonRemoveTransaction";
            this.ButtonRemoveTransaction.Size = new System.Drawing.Size(267, 49);
            this.ButtonRemoveTransaction.TabIndex = 12;
            this.ButtonRemoveTransaction.Text = "Usuń Transakcję";
            this.ButtonRemoveTransaction.UseVisualStyleBackColor = true;
            // 
            // ButtonAuthorizeTransaction
            // 
            this.ButtonAuthorizeTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAuthorizeTransaction.Location = new System.Drawing.Point(327, 606);
            this.ButtonAuthorizeTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAuthorizeTransaction.Name = "ButtonAuthorizeTransaction";
            this.ButtonAuthorizeTransaction.Size = new System.Drawing.Size(267, 49);
            this.ButtonAuthorizeTransaction.TabIndex = 13;
            this.ButtonAuthorizeTransaction.Text = "Autoryzuj Transakcje";
            this.ButtonAuthorizeTransaction.UseVisualStyleBackColor = true;
            // 
            // FCentrumTransakcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.ButtonAuthorizeTransaction);
            this.Controls.Add(this.ButtonRemoveTransaction);
            this.Controls.Add(this.ButtonAddTransaction);
            this.Controls.Add(this.LabelTransactionArchives);
            this.Controls.Add(this.LabelAwaitingTransacjtion);
            this.Controls.Add(this.LabelBankList);
            this.Controls.Add(this.ListBoxDoneTransaction);
            this.Controls.Add(this.ListBoxAwaitingTransaction);
            this.Controls.Add(this.ButtonGoToBank);
            this.Controls.Add(this.ButtonEditBank);
            this.Controls.Add(this.ButtonRemoveBank);
            this.Controls.Add(this.ButtonAddBank);
            this.Controls.Add(this.ListBoxBanks);
            this.Controls.Add(this.LabelCentrumTransakcji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCentrumTransakcji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Centrum Transakcji";
            this.Load += new System.EventHandler(this.FCentrumTransakcji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCentrumTransakcji;
        private System.Windows.Forms.ListBox ListBoxBanks;
        private System.Windows.Forms.Button ButtonAddBank;
        private System.Windows.Forms.Button ButtonRemoveBank;
        private System.Windows.Forms.Button ButtonEditBank;
        private System.Windows.Forms.Button ButtonGoToBank;
        private System.Windows.Forms.ListBox ListBoxAwaitingTransaction;
        private System.Windows.Forms.ListBox ListBoxDoneTransaction;
        private System.Windows.Forms.Label LabelBankList;
        private System.Windows.Forms.Label LabelAwaitingTransacjtion;
        private System.Windows.Forms.Label LabelTransactionArchives;
        private System.Windows.Forms.Button ButtonAddTransaction;
        private System.Windows.Forms.Button ButtonRemoveTransaction;
        private System.Windows.Forms.Button ButtonAuthorizeTransaction;
    }
}