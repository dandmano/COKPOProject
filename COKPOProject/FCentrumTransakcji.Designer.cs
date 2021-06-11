
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
            this.LabelBankList = new System.Windows.Forms.Label();
            this.LabelTransactionArchives = new System.Windows.Forms.Label();
            this.ButtonRemoveTransaction = new System.Windows.Forms.Button();
            this.ButtonAuthorizeTransaction = new System.Windows.Forms.Button();
            this.ButtonSearchTransaction = new System.Windows.Forms.Button();
            this.ListViewTransactions = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrKarty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kwota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LabelCentrumTransakcji
            // 
            this.LabelCentrumTransakcji.AutoSize = true;
            this.LabelCentrumTransakcji.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCentrumTransakcji.Location = new System.Drawing.Point(320, 7);
            this.LabelCentrumTransakcji.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCentrumTransakcji.Name = "LabelCentrumTransakcji";
            this.LabelCentrumTransakcji.Size = new System.Drawing.Size(265, 32);
            this.LabelCentrumTransakcji.TabIndex = 0;
            this.LabelCentrumTransakcji.Text = "Centrum Transakcji";
            // 
            // ListBoxBanks
            // 
            this.ListBoxBanks.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxBanks.FormattingEnabled = true;
            this.ListBoxBanks.ItemHeight = 17;
            this.ListBoxBanks.Location = new System.Drawing.Point(33, 83);
            this.ListBoxBanks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListBoxBanks.Name = "ListBoxBanks";
            this.ListBoxBanks.Size = new System.Drawing.Size(198, 293);
            this.ListBoxBanks.Sorted = true;
            this.ListBoxBanks.TabIndex = 1;
            this.ListBoxBanks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxBanks_MouseDoubleClick);
            // 
            // ButtonAddBank
            // 
            this.ButtonAddBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAddBank.Location = new System.Drawing.Point(33, 402);
            this.ButtonAddBank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAddBank.Name = "ButtonAddBank";
            this.ButtonAddBank.Size = new System.Drawing.Size(198, 40);
            this.ButtonAddBank.TabIndex = 2;
            this.ButtonAddBank.Text = "Dodaj Bank";
            this.ButtonAddBank.UseVisualStyleBackColor = true;
            this.ButtonAddBank.Click += new System.EventHandler(this.ButtonAddBank_Click);
            // 
            // ButtonRemoveBank
            // 
            this.ButtonRemoveBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRemoveBank.Location = new System.Drawing.Point(33, 447);
            this.ButtonRemoveBank.Name = "ButtonRemoveBank";
            this.ButtonRemoveBank.Size = new System.Drawing.Size(198, 40);
            this.ButtonRemoveBank.TabIndex = 3;
            this.ButtonRemoveBank.Text = "Usun Bank";
            this.ButtonRemoveBank.UseVisualStyleBackColor = true;
            this.ButtonRemoveBank.Click += new System.EventHandler(this.ButtonRemoveBank_Click);
            // 
            // ButtonEditBank
            // 
            this.ButtonEditBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEditBank.Location = new System.Drawing.Point(33, 492);
            this.ButtonEditBank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonEditBank.Name = "ButtonEditBank";
            this.ButtonEditBank.Size = new System.Drawing.Size(198, 40);
            this.ButtonEditBank.TabIndex = 4;
            this.ButtonEditBank.Text = "Edytuj Nazwę Banku";
            this.ButtonEditBank.UseVisualStyleBackColor = true;
            this.ButtonEditBank.Click += new System.EventHandler(this.ButtonEditBank_Click);
            // 
            // ButtonGoToBank
            // 
            this.ButtonGoToBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonGoToBank.Location = new System.Drawing.Point(33, 537);
            this.ButtonGoToBank.Name = "ButtonGoToBank";
            this.ButtonGoToBank.Size = new System.Drawing.Size(198, 40);
            this.ButtonGoToBank.TabIndex = 5;
            this.ButtonGoToBank.Text = "Przejdź Do Banku";
            this.ButtonGoToBank.UseVisualStyleBackColor = true;
            this.ButtonGoToBank.Click += new System.EventHandler(this.ButtonGoToBank_Click);
            // 
            // LabelBankList
            // 
            this.LabelBankList.AutoSize = true;
            this.LabelBankList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBankList.Location = new System.Drawing.Point(30, 53);
            this.LabelBankList.Name = "LabelBankList";
            this.LabelBankList.Size = new System.Drawing.Size(60, 19);
            this.LabelBankList.TabIndex = 8;
            this.LabelBankList.Text = "Banki :";
            // 
            // LabelTransactionArchives
            // 
            this.LabelTransactionArchives.AutoSize = true;
            this.LabelTransactionArchives.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTransactionArchives.Location = new System.Drawing.Point(267, 53);
            this.LabelTransactionArchives.Name = "LabelTransactionArchives";
            this.LabelTransactionArchives.Size = new System.Drawing.Size(178, 19);
            this.LabelTransactionArchives.TabIndex = 10;
            this.LabelTransactionArchives.Text = "Archiwum Transakcji :";
            // 
            // ButtonRemoveTransaction
            // 
            this.ButtonRemoveTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRemoveTransaction.Location = new System.Drawing.Point(270, 447);
            this.ButtonRemoveTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonRemoveTransaction.Name = "ButtonRemoveTransaction";
            this.ButtonRemoveTransaction.Size = new System.Drawing.Size(579, 40);
            this.ButtonRemoveTransaction.TabIndex = 12;
            this.ButtonRemoveTransaction.Text = "Usuń Transakcję z Historii";
            this.ButtonRemoveTransaction.UseVisualStyleBackColor = true;
            this.ButtonRemoveTransaction.Click += new System.EventHandler(this.ButtonRemoveTransaction_Click);
            // 
            // ButtonAuthorizeTransaction
            // 
            this.ButtonAuthorizeTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAuthorizeTransaction.Location = new System.Drawing.Point(270, 402);
            this.ButtonAuthorizeTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAuthorizeTransaction.Name = "ButtonAuthorizeTransaction";
            this.ButtonAuthorizeTransaction.Size = new System.Drawing.Size(579, 40);
            this.ButtonAuthorizeTransaction.TabIndex = 13;
            this.ButtonAuthorizeTransaction.Text = "Autoryzuj Transakcje";
            this.ButtonAuthorizeTransaction.UseVisualStyleBackColor = true;
            this.ButtonAuthorizeTransaction.Click += new System.EventHandler(this.ButtonAuthorizeTransaction_Click);
            // 
            // ButtonSearchTransaction
            // 
            this.ButtonSearchTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSearchTransaction.Location = new System.Drawing.Point(270, 492);
            this.ButtonSearchTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSearchTransaction.Name = "ButtonSearchTransaction";
            this.ButtonSearchTransaction.Size = new System.Drawing.Size(579, 40);
            this.ButtonSearchTransaction.TabIndex = 14;
            this.ButtonSearchTransaction.Text = "Przeszukaj Archiwum Transakcji";
            this.ButtonSearchTransaction.UseVisualStyleBackColor = true;
            // 
            // ListViewTransactions
            // 
            this.ListViewTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListViewTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Data,
            this.Firma,
            this.NrKarty,
            this.Kwota,
            this.Status});
            this.ListViewTransactions.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListViewTransactions.FullRowSelect = true;
            this.ListViewTransactions.GridLines = true;
            this.ListViewTransactions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewTransactions.HideSelection = false;
            this.ListViewTransactions.Location = new System.Drawing.Point(270, 83);
            this.ListViewTransactions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListViewTransactions.Name = "ListViewTransactions";
            this.ListViewTransactions.Size = new System.Drawing.Size(580, 308);
            this.ListViewTransactions.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.ListViewTransactions.TabIndex = 15;
            this.ListViewTransactions.UseCompatibleStateImageBehavior = false;
            this.ListViewTransactions.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 40;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 91;
            // 
            // Firma
            // 
            this.Firma.Text = "Firma";
            this.Firma.Width = 119;
            // 
            // NrKarty
            // 
            this.NrKarty.Text = "Nr Karty";
            this.NrKarty.Width = 137;
            // 
            // Kwota
            // 
            this.Kwota.Text = "Kwota";
            this.Kwota.Width = 106;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 85;
            // 
            // FCentrumTransakcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.ListViewTransactions);
            this.Controls.Add(this.ButtonSearchTransaction);
            this.Controls.Add(this.ButtonAuthorizeTransaction);
            this.Controls.Add(this.ButtonRemoveTransaction);
            this.Controls.Add(this.LabelTransactionArchives);
            this.Controls.Add(this.LabelBankList);
            this.Controls.Add(this.ButtonGoToBank);
            this.Controls.Add(this.ButtonEditBank);
            this.Controls.Add(this.ButtonRemoveBank);
            this.Controls.Add(this.ButtonAddBank);
            this.Controls.Add(this.ListBoxBanks);
            this.Controls.Add(this.LabelCentrumTransakcji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label LabelBankList;
        private System.Windows.Forms.Label LabelTransactionArchives;
        private System.Windows.Forms.Button ButtonRemoveTransaction;
        private System.Windows.Forms.Button ButtonAuthorizeTransaction;
        private System.Windows.Forms.Button ButtonSearchTransaction;
        private System.Windows.Forms.ListView ListViewTransactions;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Firma;
        private System.Windows.Forms.ColumnHeader NrKarty;
        private System.Windows.Forms.ColumnHeader Kwota;
        private System.Windows.Forms.ColumnHeader Status;
    }
}