
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
            this.Kwota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BankFirmy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrKarty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BankKlienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelIdSearch = new System.Windows.Forms.Label();
            this.DateTimePickerLowerValue = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerHigherValue = new System.Windows.Forms.DateTimePicker();
            this.LableDateSearch = new System.Windows.Forms.Label();
            this.TextBoxLowerAmount = new System.Windows.Forms.TextBox();
            this.TextBoxHigherAmount = new System.Windows.Forms.TextBox();
            this.LabelFromDate = new System.Windows.Forms.Label();
            this.LabelToDate = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.LabelFirmName = new System.Windows.Forms.Label();
            this.TextBoxFirmName = new System.Windows.Forms.TextBox();
            this.LabelFirmsBank = new System.Windows.Forms.Label();
            this.TextBoxFirmsBank = new System.Windows.Forms.TextBox();
            this.LabelCardNumber = new System.Windows.Forms.Label();
            this.TextBoxCardNumber = new System.Windows.Forms.TextBox();
            this.LabelClientsBank = new System.Windows.Forms.Label();
            this.TextBoxClientsBank = new System.Windows.Forms.TextBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelFilters = new System.Windows.Forms.Label();
            this.ButtonResetFilters = new System.Windows.Forms.Button();
            this.CheckBoxId = new System.Windows.Forms.CheckBox();
            this.CheckBoxDate = new System.Windows.Forms.CheckBox();
            this.CheckBoxAmount = new System.Windows.Forms.CheckBox();
            this.CheckBoxFirm = new System.Windows.Forms.CheckBox();
            this.CheckBoxFirmsBank = new System.Windows.Forms.CheckBox();
            this.CheckBoxCardNumber = new System.Windows.Forms.CheckBox();
            this.CheckBoxClientsBank = new System.Windows.Forms.CheckBox();
            this.CheckBoxStatus = new System.Windows.Forms.CheckBox();
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.LabelFromAmount = new System.Windows.Forms.Label();
            this.LabelToAmount = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonSaveAndExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCentrumTransakcji
            // 
            this.LabelCentrumTransakcji.AutoSize = true;
            this.LabelCentrumTransakcji.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCentrumTransakcji.Location = new System.Drawing.Point(560, 9);
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
            this.ListBoxBanks.Location = new System.Drawing.Point(44, 102);
            this.ListBoxBanks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxBanks.Name = "ListBoxBanks";
            this.ListBoxBanks.Size = new System.Drawing.Size(263, 356);
            this.ListBoxBanks.Sorted = true;
            this.ListBoxBanks.TabIndex = 1;
            this.ListBoxBanks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxBanks_MouseDoubleClick);
            // 
            // ButtonAddBank
            // 
            this.ButtonAddBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAddBank.Location = new System.Drawing.Point(44, 495);
            this.ButtonAddBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddBank.Name = "ButtonAddBank";
            this.ButtonAddBank.Size = new System.Drawing.Size(264, 49);
            this.ButtonAddBank.TabIndex = 2;
            this.ButtonAddBank.Text = "Dodaj Bank";
            this.ButtonAddBank.UseVisualStyleBackColor = true;
            this.ButtonAddBank.Click += new System.EventHandler(this.ButtonAddBank_Click);
            // 
            // ButtonRemoveBank
            // 
            this.ButtonRemoveBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRemoveBank.Location = new System.Drawing.Point(44, 550);
            this.ButtonRemoveBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonRemoveBank.Name = "ButtonRemoveBank";
            this.ButtonRemoveBank.Size = new System.Drawing.Size(264, 49);
            this.ButtonRemoveBank.TabIndex = 3;
            this.ButtonRemoveBank.Text = "Usun Bank";
            this.ButtonRemoveBank.UseVisualStyleBackColor = true;
            this.ButtonRemoveBank.Click += new System.EventHandler(this.ButtonRemoveBank_Click);
            // 
            // ButtonEditBank
            // 
            this.ButtonEditBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEditBank.Location = new System.Drawing.Point(44, 606);
            this.ButtonEditBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonEditBank.Name = "ButtonEditBank";
            this.ButtonEditBank.Size = new System.Drawing.Size(264, 49);
            this.ButtonEditBank.TabIndex = 4;
            this.ButtonEditBank.Text = "Edytuj Nazwę Banku";
            this.ButtonEditBank.UseVisualStyleBackColor = true;
            this.ButtonEditBank.Click += new System.EventHandler(this.ButtonEditBank_Click);
            // 
            // ButtonGoToBank
            // 
            this.ButtonGoToBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonGoToBank.Location = new System.Drawing.Point(44, 661);
            this.ButtonGoToBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonGoToBank.Name = "ButtonGoToBank";
            this.ButtonGoToBank.Size = new System.Drawing.Size(264, 49);
            this.ButtonGoToBank.TabIndex = 5;
            this.ButtonGoToBank.Text = "Przejdź Do Banku";
            this.ButtonGoToBank.UseVisualStyleBackColor = true;
            this.ButtonGoToBank.Click += new System.EventHandler(this.ButtonGoToBank_Click);
            // 
            // LabelBankList
            // 
            this.LabelBankList.AutoSize = true;
            this.LabelBankList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBankList.Location = new System.Drawing.Point(40, 65);
            this.LabelBankList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBankList.Name = "LabelBankList";
            this.LabelBankList.Size = new System.Drawing.Size(76, 23);
            this.LabelBankList.TabIndex = 8;
            this.LabelBankList.Text = "Banki :";
            // 
            // LabelTransactionArchives
            // 
            this.LabelTransactionArchives.AutoSize = true;
            this.LabelTransactionArchives.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTransactionArchives.Location = new System.Drawing.Point(356, 65);
            this.LabelTransactionArchives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTransactionArchives.Name = "LabelTransactionArchives";
            this.LabelTransactionArchives.Size = new System.Drawing.Size(222, 23);
            this.LabelTransactionArchives.TabIndex = 10;
            this.LabelTransactionArchives.Text = "Archiwum Transakcji :";
            // 
            // ButtonRemoveTransaction
            // 
            this.ButtonRemoveTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRemoveTransaction.Location = new System.Drawing.Point(360, 550);
            this.ButtonRemoveTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonRemoveTransaction.Name = "ButtonRemoveTransaction";
            this.ButtonRemoveTransaction.Size = new System.Drawing.Size(272, 49);
            this.ButtonRemoveTransaction.TabIndex = 12;
            this.ButtonRemoveTransaction.Text = "Usuń Transakcję z Historii";
            this.ButtonRemoveTransaction.UseVisualStyleBackColor = true;
            this.ButtonRemoveTransaction.Click += new System.EventHandler(this.ButtonRemoveTransaction_Click);
            // 
            // ButtonAuthorizeTransaction
            // 
            this.ButtonAuthorizeTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAuthorizeTransaction.Location = new System.Drawing.Point(360, 495);
            this.ButtonAuthorizeTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAuthorizeTransaction.Name = "ButtonAuthorizeTransaction";
            this.ButtonAuthorizeTransaction.Size = new System.Drawing.Size(272, 49);
            this.ButtonAuthorizeTransaction.TabIndex = 13;
            this.ButtonAuthorizeTransaction.Text = "Autoryzuj Transakcje";
            this.ButtonAuthorizeTransaction.UseVisualStyleBackColor = true;
            this.ButtonAuthorizeTransaction.Click += new System.EventHandler(this.ButtonAuthorizeTransaction_Click);
            // 
            // ButtonSearchTransaction
            // 
            this.ButtonSearchTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSearchTransaction.Location = new System.Drawing.Point(361, 606);
            this.ButtonSearchTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSearchTransaction.Name = "ButtonSearchTransaction";
            this.ButtonSearchTransaction.Size = new System.Drawing.Size(271, 49);
            this.ButtonSearchTransaction.TabIndex = 14;
            this.ButtonSearchTransaction.Text = "Filtruj";
            this.ButtonSearchTransaction.UseVisualStyleBackColor = true;
            this.ButtonSearchTransaction.Click += new System.EventHandler(this.ButtonSearchTransaction_Click);
            // 
            // ListViewTransactions
            // 
            this.ListViewTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListViewTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Data,
            this.Kwota,
            this.Firma,
            this.BankFirmy,
            this.NrKarty,
            this.BankKlienta,
            this.Status});
            this.ListViewTransactions.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListViewTransactions.FullRowSelect = true;
            this.ListViewTransactions.GridLines = true;
            this.ListViewTransactions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewTransactions.HideSelection = false;
            this.ListViewTransactions.Location = new System.Drawing.Point(361, 102);
            this.ListViewTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListViewTransactions.MultiSelect = false;
            this.ListViewTransactions.Name = "ListViewTransactions";
            this.ListViewTransactions.Size = new System.Drawing.Size(1178, 379);
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
            // Kwota
            // 
            this.Kwota.Text = "Kwota";
            this.Kwota.Width = 135;
            // 
            // Firma
            // 
            this.Firma.Text = "Firma";
            this.Firma.Width = 119;
            // 
            // BankFirmy
            // 
            this.BankFirmy.Text = "Bank Firmy";
            this.BankFirmy.Width = 113;
            // 
            // NrKarty
            // 
            this.NrKarty.Text = "Nr Karty";
            this.NrKarty.Width = 124;
            // 
            // BankKlienta
            // 
            this.BankKlienta.Text = "Bank Klienta";
            this.BankKlienta.Width = 125;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 131;
            // 
            // LabelIdSearch
            // 
            this.LabelIdSearch.AutoSize = true;
            this.LabelIdSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelIdSearch.Location = new System.Drawing.Point(672, 535);
            this.LabelIdSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelIdSearch.Name = "LabelIdSearch";
            this.LabelIdSearch.Size = new System.Drawing.Size(35, 23);
            this.LabelIdSearch.TabIndex = 17;
            this.LabelIdSearch.Text = "Id:";
            // 
            // DateTimePickerLowerValue
            // 
            this.DateTimePickerLowerValue.Checked = false;
            this.DateTimePickerLowerValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateTimePickerLowerValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerLowerValue.Location = new System.Drawing.Point(803, 572);
            this.DateTimePickerLowerValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTimePickerLowerValue.Name = "DateTimePickerLowerValue";
            this.DateTimePickerLowerValue.Size = new System.Drawing.Size(164, 32);
            this.DateTimePickerLowerValue.TabIndex = 20;
            this.DateTimePickerLowerValue.Visible = false;
            // 
            // DateTimePickerHigherValue
            // 
            this.DateTimePickerHigherValue.Checked = false;
            this.DateTimePickerHigherValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateTimePickerHigherValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerHigherValue.Location = new System.Drawing.Point(1024, 572);
            this.DateTimePickerHigherValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTimePickerHigherValue.Name = "DateTimePickerHigherValue";
            this.DateTimePickerHigherValue.Size = new System.Drawing.Size(160, 32);
            this.DateTimePickerHigherValue.TabIndex = 21;
            this.DateTimePickerHigherValue.Visible = false;
            // 
            // LableDateSearch
            // 
            this.LableDateSearch.AutoSize = true;
            this.LableDateSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LableDateSearch.Location = new System.Drawing.Point(672, 576);
            this.LableDateSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LableDateSearch.Name = "LableDateSearch";
            this.LableDateSearch.Size = new System.Drawing.Size(62, 23);
            this.LableDateSearch.TabIndex = 22;
            this.LableDateSearch.Text = "Data:";
            // 
            // TextBoxLowerAmount
            // 
            this.TextBoxLowerAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxLowerAmount.Location = new System.Drawing.Point(803, 613);
            this.TextBoxLowerAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxLowerAmount.Name = "TextBoxLowerAmount";
            this.TextBoxLowerAmount.Size = new System.Drawing.Size(164, 32);
            this.TextBoxLowerAmount.TabIndex = 23;
            this.TextBoxLowerAmount.Visible = false;
            this.TextBoxLowerAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLowerAmount_KeyPress);
            // 
            // TextBoxHigherAmount
            // 
            this.TextBoxHigherAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxHigherAmount.Location = new System.Drawing.Point(1024, 613);
            this.TextBoxHigherAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxHigherAmount.Name = "TextBoxHigherAmount";
            this.TextBoxHigherAmount.Size = new System.Drawing.Size(160, 32);
            this.TextBoxHigherAmount.TabIndex = 24;
            this.TextBoxHigherAmount.Visible = false;
            this.TextBoxHigherAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHigherAmount_KeyPress);
            // 
            // LabelFromDate
            // 
            this.LabelFromDate.AutoSize = true;
            this.LabelFromDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFromDate.Location = new System.Drawing.Point(751, 576);
            this.LabelFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFromDate.Name = "LabelFromDate";
            this.LabelFromDate.Size = new System.Drawing.Size(40, 23);
            this.LabelFromDate.TabIndex = 25;
            this.LabelFromDate.Text = "Od";
            this.LabelFromDate.Visible = false;
            // 
            // LabelToDate
            // 
            this.LabelToDate.AutoSize = true;
            this.LabelToDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelToDate.Location = new System.Drawing.Point(976, 576);
            this.LabelToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelToDate.Name = "LabelToDate";
            this.LabelToDate.Size = new System.Drawing.Size(37, 23);
            this.LabelToDate.TabIndex = 26;
            this.LabelToDate.Text = "Do";
            this.LabelToDate.Visible = false;
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAmount.Location = new System.Drawing.Point(672, 615);
            this.LabelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(76, 23);
            this.LabelAmount.TabIndex = 27;
            this.LabelAmount.Text = "Kwota:";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxId.Location = new System.Drawing.Point(803, 532);
            this.TextBoxId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(164, 32);
            this.TextBoxId.TabIndex = 28;
            this.TextBoxId.Visible = false;
            this.TextBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIdSearch_KeyPress);
            // 
            // LabelFirmName
            // 
            this.LabelFirmName.AutoSize = true;
            this.LabelFirmName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFirmName.Location = new System.Drawing.Point(672, 657);
            this.LabelFirmName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFirmName.Name = "LabelFirmName";
            this.LabelFirmName.Size = new System.Drawing.Size(69, 23);
            this.LabelFirmName.TabIndex = 29;
            this.LabelFirmName.Text = "Firma:";
            // 
            // TextBoxFirmName
            // 
            this.TextBoxFirmName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxFirmName.Location = new System.Drawing.Point(803, 654);
            this.TextBoxFirmName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxFirmName.Name = "TextBoxFirmName";
            this.TextBoxFirmName.Size = new System.Drawing.Size(164, 32);
            this.TextBoxFirmName.TabIndex = 30;
            this.TextBoxFirmName.Visible = false;
            // 
            // LabelFirmsBank
            // 
            this.LabelFirmsBank.AutoSize = true;
            this.LabelFirmsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFirmsBank.Location = new System.Drawing.Point(1221, 535);
            this.LabelFirmsBank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFirmsBank.Name = "LabelFirmsBank";
            this.LabelFirmsBank.Size = new System.Drawing.Size(123, 23);
            this.LabelFirmsBank.TabIndex = 31;
            this.LabelFirmsBank.Text = "Bank Firmy:";
            // 
            // TextBoxFirmsBank
            // 
            this.TextBoxFirmsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxFirmsBank.Location = new System.Drawing.Point(1372, 532);
            this.TextBoxFirmsBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxFirmsBank.Name = "TextBoxFirmsBank";
            this.TextBoxFirmsBank.Size = new System.Drawing.Size(167, 32);
            this.TextBoxFirmsBank.TabIndex = 32;
            this.TextBoxFirmsBank.Visible = false;
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.AutoSize = true;
            this.LabelCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCardNumber.Location = new System.Drawing.Point(1221, 576);
            this.LabelCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(92, 23);
            this.LabelCardNumber.TabIndex = 33;
            this.LabelCardNumber.Text = "Nr Karty:";
            // 
            // TextBoxCardNumber
            // 
            this.TextBoxCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCardNumber.Location = new System.Drawing.Point(1372, 572);
            this.TextBoxCardNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxCardNumber.MaxLength = 16;
            this.TextBoxCardNumber.Name = "TextBoxCardNumber";
            this.TextBoxCardNumber.Size = new System.Drawing.Size(167, 32);
            this.TextBoxCardNumber.TabIndex = 34;
            this.TextBoxCardNumber.Visible = false;
            this.TextBoxCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCardNumber_KeyPress);
            // 
            // LabelClientsBank
            // 
            this.LabelClientsBank.AutoSize = true;
            this.LabelClientsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelClientsBank.Location = new System.Drawing.Point(1221, 617);
            this.LabelClientsBank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelClientsBank.Name = "LabelClientsBank";
            this.LabelClientsBank.Size = new System.Drawing.Size(131, 23);
            this.LabelClientsBank.TabIndex = 35;
            this.LabelClientsBank.Text = "BankKlienta:";
            // 
            // TextBoxClientsBank
            // 
            this.TextBoxClientsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxClientsBank.Location = new System.Drawing.Point(1372, 613);
            this.TextBoxClientsBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxClientsBank.Name = "TextBoxClientsBank";
            this.TextBoxClientsBank.Size = new System.Drawing.Size(167, 32);
            this.TextBoxClientsBank.TabIndex = 36;
            this.TextBoxClientsBank.Visible = false;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelStatus.Location = new System.Drawing.Point(1221, 655);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(72, 23);
            this.LabelStatus.TabIndex = 37;
            this.LabelStatus.Text = "Status:";
            // 
            // LabelFilters
            // 
            this.LabelFilters.AutoSize = true;
            this.LabelFilters.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFilters.Location = new System.Drawing.Point(655, 494);
            this.LabelFilters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFilters.Name = "LabelFilters";
            this.LabelFilters.Size = new System.Drawing.Size(81, 32);
            this.LabelFilters.TabIndex = 39;
            this.LabelFilters.Text = "Filtry:";
            // 
            // ButtonResetFilters
            // 
            this.ButtonResetFilters.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonResetFilters.Location = new System.Drawing.Point(360, 661);
            this.ButtonResetFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonResetFilters.Name = "ButtonResetFilters";
            this.ButtonResetFilters.Size = new System.Drawing.Size(271, 49);
            this.ButtonResetFilters.TabIndex = 40;
            this.ButtonResetFilters.Text = "Resetuj Filtry";
            this.ButtonResetFilters.UseVisualStyleBackColor = true;
            this.ButtonResetFilters.Click += new System.EventHandler(this.ButtonResetFilters_Click);
            // 
            // CheckBoxId
            // 
            this.CheckBoxId.AutoSize = true;
            this.CheckBoxId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxId.Location = new System.Drawing.Point(649, 539);
            this.CheckBoxId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxId.Name = "CheckBoxId";
            this.CheckBoxId.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxId.TabIndex = 41;
            this.CheckBoxId.UseVisualStyleBackColor = true;
            this.CheckBoxId.CheckedChanged += new System.EventHandler(this.CheckBoxId_CheckedChanged);
            // 
            // CheckBoxDate
            // 
            this.CheckBoxDate.AutoSize = true;
            this.CheckBoxDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxDate.Location = new System.Drawing.Point(649, 580);
            this.CheckBoxDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxDate.TabIndex = 42;
            this.CheckBoxDate.UseVisualStyleBackColor = true;
            this.CheckBoxDate.CheckedChanged += new System.EventHandler(this.CheckBoxDate_CheckedChanged);
            // 
            // CheckBoxAmount
            // 
            this.CheckBoxAmount.AutoSize = true;
            this.CheckBoxAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxAmount.Location = new System.Drawing.Point(649, 619);
            this.CheckBoxAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxAmount.Name = "CheckBoxAmount";
            this.CheckBoxAmount.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxAmount.TabIndex = 43;
            this.CheckBoxAmount.UseVisualStyleBackColor = true;
            this.CheckBoxAmount.CheckedChanged += new System.EventHandler(this.CheckBoxAmount_CheckedChanged);
            // 
            // CheckBoxFirm
            // 
            this.CheckBoxFirm.AutoSize = true;
            this.CheckBoxFirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxFirm.Location = new System.Drawing.Point(649, 661);
            this.CheckBoxFirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxFirm.Name = "CheckBoxFirm";
            this.CheckBoxFirm.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxFirm.TabIndex = 44;
            this.CheckBoxFirm.UseVisualStyleBackColor = true;
            this.CheckBoxFirm.CheckedChanged += new System.EventHandler(this.CheckBoxFirm_CheckedChanged);
            // 
            // CheckBoxFirmsBank
            // 
            this.CheckBoxFirmsBank.AutoSize = true;
            this.CheckBoxFirmsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxFirmsBank.Location = new System.Drawing.Point(1193, 539);
            this.CheckBoxFirmsBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxFirmsBank.Name = "CheckBoxFirmsBank";
            this.CheckBoxFirmsBank.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxFirmsBank.TabIndex = 45;
            this.CheckBoxFirmsBank.UseVisualStyleBackColor = true;
            this.CheckBoxFirmsBank.CheckedChanged += new System.EventHandler(this.CheckBoxFirmsBank_CheckedChanged);
            // 
            // CheckBoxCardNumber
            // 
            this.CheckBoxCardNumber.AutoSize = true;
            this.CheckBoxCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxCardNumber.Location = new System.Drawing.Point(1193, 580);
            this.CheckBoxCardNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxCardNumber.Name = "CheckBoxCardNumber";
            this.CheckBoxCardNumber.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxCardNumber.TabIndex = 46;
            this.CheckBoxCardNumber.UseVisualStyleBackColor = true;
            this.CheckBoxCardNumber.CheckedChanged += new System.EventHandler(this.CheckBoxCardNumber_CheckedChanged);
            // 
            // CheckBoxClientsBank
            // 
            this.CheckBoxClientsBank.AutoSize = true;
            this.CheckBoxClientsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxClientsBank.Location = new System.Drawing.Point(1193, 622);
            this.CheckBoxClientsBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxClientsBank.Name = "CheckBoxClientsBank";
            this.CheckBoxClientsBank.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxClientsBank.TabIndex = 47;
            this.CheckBoxClientsBank.UseVisualStyleBackColor = true;
            this.CheckBoxClientsBank.CheckedChanged += new System.EventHandler(this.CheckBoxClientsBank_CheckedChanged);
            // 
            // CheckBoxStatus
            // 
            this.CheckBoxStatus.AutoSize = true;
            this.CheckBoxStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxStatus.Location = new System.Drawing.Point(1193, 661);
            this.CheckBoxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxStatus.Name = "CheckBoxStatus";
            this.CheckBoxStatus.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxStatus.TabIndex = 48;
            this.CheckBoxStatus.UseVisualStyleBackColor = true;
            this.CheckBoxStatus.CheckedChanged += new System.EventHandler(this.CheckBoxStatus_CheckedChanged);
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Items.AddRange(new object[] {
            "Zaakceptowana",
            "Odrzucona"});
            this.ComboBoxStatus.Location = new System.Drawing.Point(1304, 655);
            this.ComboBoxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(235, 31);
            this.ComboBoxStatus.TabIndex = 49;
            this.ComboBoxStatus.Visible = false;
            // 
            // LabelFromAmount
            // 
            this.LabelFromAmount.AutoSize = true;
            this.LabelFromAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFromAmount.Location = new System.Drawing.Point(751, 615);
            this.LabelFromAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFromAmount.Name = "LabelFromAmount";
            this.LabelFromAmount.Size = new System.Drawing.Size(40, 23);
            this.LabelFromAmount.TabIndex = 50;
            this.LabelFromAmount.Text = "Od";
            this.LabelFromAmount.Visible = false;
            // 
            // LabelToAmount
            // 
            this.LabelToAmount.AutoSize = true;
            this.LabelToAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelToAmount.Location = new System.Drawing.Point(976, 615);
            this.LabelToAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelToAmount.Name = "LabelToAmount";
            this.LabelToAmount.Size = new System.Drawing.Size(37, 23);
            this.LabelToAmount.TabIndex = 51;
            this.LabelToAmount.Text = "Do";
            this.LabelToAmount.Visible = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSave.Location = new System.Drawing.Point(1251, 21);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(128, 57);
            this.ButtonSave.TabIndex = 52;
            this.ButtonSave.Text = "Zapisz";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonSaveAndExit
            // 
            this.ButtonSaveAndExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSaveAndExit.Location = new System.Drawing.Point(1384, 21);
            this.ButtonSaveAndExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSaveAndExit.Name = "ButtonSaveAndExit";
            this.ButtonSaveAndExit.Size = new System.Drawing.Size(155, 57);
            this.ButtonSaveAndExit.TabIndex = 53;
            this.ButtonSaveAndExit.Text = "Zapisz i Wyjdź";
            this.ButtonSaveAndExit.UseVisualStyleBackColor = true;
            this.ButtonSaveAndExit.Click += new System.EventHandler(this.ButtonSaveAndExit_Click);
            // 
            // FCentrumTransakcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 753);
            this.Controls.Add(this.ButtonSaveAndExit);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelToAmount);
            this.Controls.Add(this.LabelFromAmount);
            this.Controls.Add(this.ComboBoxStatus);
            this.Controls.Add(this.CheckBoxStatus);
            this.Controls.Add(this.CheckBoxClientsBank);
            this.Controls.Add(this.CheckBoxCardNumber);
            this.Controls.Add(this.CheckBoxFirmsBank);
            this.Controls.Add(this.CheckBoxFirm);
            this.Controls.Add(this.CheckBoxAmount);
            this.Controls.Add(this.CheckBoxDate);
            this.Controls.Add(this.CheckBoxId);
            this.Controls.Add(this.ButtonResetFilters);
            this.Controls.Add(this.LabelFilters);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.TextBoxClientsBank);
            this.Controls.Add(this.LabelClientsBank);
            this.Controls.Add(this.TextBoxCardNumber);
            this.Controls.Add(this.LabelCardNumber);
            this.Controls.Add(this.TextBoxFirmsBank);
            this.Controls.Add(this.LabelFirmsBank);
            this.Controls.Add(this.TextBoxFirmName);
            this.Controls.Add(this.LabelFirmName);
            this.Controls.Add(this.TextBoxId);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.LabelToDate);
            this.Controls.Add(this.LabelFromDate);
            this.Controls.Add(this.TextBoxHigherAmount);
            this.Controls.Add(this.TextBoxLowerAmount);
            this.Controls.Add(this.LableDateSearch);
            this.Controls.Add(this.DateTimePickerHigherValue);
            this.Controls.Add(this.DateTimePickerLowerValue);
            this.Controls.Add(this.LabelIdSearch);
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
        private System.Windows.Forms.Label LabelIdSearch;
        private System.Windows.Forms.DateTimePicker DateTimePickerLowerValue;
        private System.Windows.Forms.DateTimePicker DateTimePickerHigherValue;
        private System.Windows.Forms.ColumnHeader BankFirmy;
        private System.Windows.Forms.ColumnHeader BankKlienta;
        private System.Windows.Forms.Label LableDateSearch;
        private System.Windows.Forms.TextBox TextBoxLowerAmount;
        private System.Windows.Forms.TextBox TextBoxHigherAmount;
        private System.Windows.Forms.Label LabelFromDate;
        private System.Windows.Forms.Label LabelToDate;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Label LabelFirmName;
        private System.Windows.Forms.TextBox TextBoxFirmName;
        private System.Windows.Forms.Label LabelFirmsBank;
        private System.Windows.Forms.TextBox TextBoxFirmsBank;
        private System.Windows.Forms.Label LabelCardNumber;
        private System.Windows.Forms.TextBox TextBoxCardNumber;
        private System.Windows.Forms.Label LabelClientsBank;
        private System.Windows.Forms.TextBox TextBoxClientsBank;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelFilters;
        private System.Windows.Forms.Button ButtonResetFilters;
        private System.Windows.Forms.CheckBox CheckBoxId;
        private System.Windows.Forms.CheckBox CheckBoxDate;
        private System.Windows.Forms.CheckBox CheckBoxAmount;
        private System.Windows.Forms.CheckBox CheckBoxFirm;
        private System.Windows.Forms.CheckBox CheckBoxFirmsBank;
        private System.Windows.Forms.CheckBox CheckBoxCardNumber;
        private System.Windows.Forms.CheckBox CheckBoxClientsBank;
        private System.Windows.Forms.CheckBox CheckBoxStatus;
        private System.Windows.Forms.ComboBox ComboBoxStatus;
        private System.Windows.Forms.Label LabelFromAmount;
        private System.Windows.Forms.Label LabelToAmount;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonSaveAndExit;
    }
}