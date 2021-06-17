
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
            this.LabelCentrumTransakcji.BackColor = System.Drawing.Color.Transparent;
            this.LabelCentrumTransakcji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCentrumTransakcji.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCentrumTransakcji.Location = new System.Drawing.Point(420, 7);
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
            this.ListBoxBanks.Size = new System.Drawing.Size(198, 276);
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
            this.LabelBankList.BackColor = System.Drawing.Color.Transparent;
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
            this.LabelTransactionArchives.BackColor = System.Drawing.Color.Transparent;
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
            this.ButtonRemoveTransaction.Size = new System.Drawing.Size(204, 40);
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
            this.ButtonAuthorizeTransaction.Size = new System.Drawing.Size(204, 40);
            this.ButtonAuthorizeTransaction.TabIndex = 13;
            this.ButtonAuthorizeTransaction.Text = "Autoryzuj Transakcje";
            this.ButtonAuthorizeTransaction.UseVisualStyleBackColor = true;
            this.ButtonAuthorizeTransaction.Click += new System.EventHandler(this.ButtonAuthorizeTransaction_Click);
            // 
            // ButtonSearchTransaction
            // 
            this.ButtonSearchTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSearchTransaction.Location = new System.Drawing.Point(271, 492);
            this.ButtonSearchTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSearchTransaction.Name = "ButtonSearchTransaction";
            this.ButtonSearchTransaction.Size = new System.Drawing.Size(203, 40);
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
            this.ListViewTransactions.Location = new System.Drawing.Point(271, 83);
            this.ListViewTransactions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListViewTransactions.MultiSelect = false;
            this.ListViewTransactions.Name = "ListViewTransactions";
            this.ListViewTransactions.Size = new System.Drawing.Size(884, 308);
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
            this.LabelIdSearch.BackColor = System.Drawing.Color.Transparent;
            this.LabelIdSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelIdSearch.Location = new System.Drawing.Point(504, 435);
            this.LabelIdSearch.Name = "LabelIdSearch";
            this.LabelIdSearch.Size = new System.Drawing.Size(28, 19);
            this.LabelIdSearch.TabIndex = 17;
            this.LabelIdSearch.Text = "Id:";
            // 
            // DateTimePickerLowerValue
            // 
            this.DateTimePickerLowerValue.Checked = false;
            this.DateTimePickerLowerValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateTimePickerLowerValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerLowerValue.Location = new System.Drawing.Point(602, 465);
            this.DateTimePickerLowerValue.Name = "DateTimePickerLowerValue";
            this.DateTimePickerLowerValue.Size = new System.Drawing.Size(124, 27);
            this.DateTimePickerLowerValue.TabIndex = 20;
            this.DateTimePickerLowerValue.Visible = false;
            // 
            // DateTimePickerHigherValue
            // 
            this.DateTimePickerHigherValue.Checked = false;
            this.DateTimePickerHigherValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateTimePickerHigherValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerHigherValue.Location = new System.Drawing.Point(768, 465);
            this.DateTimePickerHigherValue.Name = "DateTimePickerHigherValue";
            this.DateTimePickerHigherValue.Size = new System.Drawing.Size(121, 27);
            this.DateTimePickerHigherValue.TabIndex = 21;
            this.DateTimePickerHigherValue.Visible = false;
            // 
            // LableDateSearch
            // 
            this.LableDateSearch.AutoSize = true;
            this.LableDateSearch.BackColor = System.Drawing.Color.Transparent;
            this.LableDateSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LableDateSearch.Location = new System.Drawing.Point(504, 468);
            this.LableDateSearch.Name = "LableDateSearch";
            this.LableDateSearch.Size = new System.Drawing.Size(50, 19);
            this.LableDateSearch.TabIndex = 22;
            this.LableDateSearch.Text = "Data:";
            // 
            // TextBoxLowerAmount
            // 
            this.TextBoxLowerAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxLowerAmount.Location = new System.Drawing.Point(602, 498);
            this.TextBoxLowerAmount.Name = "TextBoxLowerAmount";
            this.TextBoxLowerAmount.Size = new System.Drawing.Size(124, 27);
            this.TextBoxLowerAmount.TabIndex = 23;
            this.TextBoxLowerAmount.Visible = false;
            this.TextBoxLowerAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLowerAmount_KeyPress);
            // 
            // TextBoxHigherAmount
            // 
            this.TextBoxHigherAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxHigherAmount.Location = new System.Drawing.Point(768, 498);
            this.TextBoxHigherAmount.Name = "TextBoxHigherAmount";
            this.TextBoxHigherAmount.Size = new System.Drawing.Size(121, 27);
            this.TextBoxHigherAmount.TabIndex = 24;
            this.TextBoxHigherAmount.Visible = false;
            this.TextBoxHigherAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHigherAmount_KeyPress);
            // 
            // LabelFromDate
            // 
            this.LabelFromDate.AutoSize = true;
            this.LabelFromDate.BackColor = System.Drawing.Color.Transparent;
            this.LabelFromDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFromDate.Location = new System.Drawing.Point(563, 468);
            this.LabelFromDate.Name = "LabelFromDate";
            this.LabelFromDate.Size = new System.Drawing.Size(33, 19);
            this.LabelFromDate.TabIndex = 25;
            this.LabelFromDate.Text = "Od";
            this.LabelFromDate.Visible = false;
            // 
            // LabelToDate
            // 
            this.LabelToDate.AutoSize = true;
            this.LabelToDate.BackColor = System.Drawing.Color.Transparent;
            this.LabelToDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelToDate.Location = new System.Drawing.Point(732, 468);
            this.LabelToDate.Name = "LabelToDate";
            this.LabelToDate.Size = new System.Drawing.Size(30, 19);
            this.LabelToDate.TabIndex = 26;
            this.LabelToDate.Text = "Do";
            this.LabelToDate.Visible = false;
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.BackColor = System.Drawing.Color.Transparent;
            this.LabelAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAmount.Location = new System.Drawing.Point(504, 500);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(61, 19);
            this.LabelAmount.TabIndex = 27;
            this.LabelAmount.Text = "Kwota:";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxId.Location = new System.Drawing.Point(602, 432);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(124, 27);
            this.TextBoxId.TabIndex = 28;
            this.TextBoxId.Visible = false;
            this.TextBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIdSearch_KeyPress);
            // 
            // LabelFirmName
            // 
            this.LabelFirmName.AutoSize = true;
            this.LabelFirmName.BackColor = System.Drawing.Color.Transparent;
            this.LabelFirmName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFirmName.Location = new System.Drawing.Point(504, 534);
            this.LabelFirmName.Name = "LabelFirmName";
            this.LabelFirmName.Size = new System.Drawing.Size(57, 19);
            this.LabelFirmName.TabIndex = 29;
            this.LabelFirmName.Text = "Firma:";
            // 
            // TextBoxFirmName
            // 
            this.TextBoxFirmName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxFirmName.Location = new System.Drawing.Point(602, 531);
            this.TextBoxFirmName.Name = "TextBoxFirmName";
            this.TextBoxFirmName.Size = new System.Drawing.Size(124, 27);
            this.TextBoxFirmName.TabIndex = 30;
            this.TextBoxFirmName.Visible = false;
            // 
            // LabelFirmsBank
            // 
            this.LabelFirmsBank.AutoSize = true;
            this.LabelFirmsBank.BackColor = System.Drawing.Color.Transparent;
            this.LabelFirmsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFirmsBank.Location = new System.Drawing.Point(916, 435);
            this.LabelFirmsBank.Name = "LabelFirmsBank";
            this.LabelFirmsBank.Size = new System.Drawing.Size(98, 19);
            this.LabelFirmsBank.TabIndex = 31;
            this.LabelFirmsBank.Text = "Bank Firmy:";
            // 
            // TextBoxFirmsBank
            // 
            this.TextBoxFirmsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxFirmsBank.Location = new System.Drawing.Point(1029, 432);
            this.TextBoxFirmsBank.Name = "TextBoxFirmsBank";
            this.TextBoxFirmsBank.Size = new System.Drawing.Size(126, 27);
            this.TextBoxFirmsBank.TabIndex = 32;
            this.TextBoxFirmsBank.Visible = false;
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.AutoSize = true;
            this.LabelCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCardNumber.Location = new System.Drawing.Point(916, 468);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(73, 19);
            this.LabelCardNumber.TabIndex = 33;
            this.LabelCardNumber.Text = "Nr Karty:";
            // 
            // TextBoxCardNumber
            // 
            this.TextBoxCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCardNumber.Location = new System.Drawing.Point(1029, 465);
            this.TextBoxCardNumber.MaxLength = 16;
            this.TextBoxCardNumber.Name = "TextBoxCardNumber";
            this.TextBoxCardNumber.Size = new System.Drawing.Size(126, 27);
            this.TextBoxCardNumber.TabIndex = 34;
            this.TextBoxCardNumber.Visible = false;
            this.TextBoxCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCardNumber_KeyPress);
            // 
            // LabelClientsBank
            // 
            this.LabelClientsBank.AutoSize = true;
            this.LabelClientsBank.BackColor = System.Drawing.Color.Transparent;
            this.LabelClientsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelClientsBank.Location = new System.Drawing.Point(916, 501);
            this.LabelClientsBank.Name = "LabelClientsBank";
            this.LabelClientsBank.Size = new System.Drawing.Size(105, 19);
            this.LabelClientsBank.TabIndex = 35;
            this.LabelClientsBank.Text = "BankKlienta:";
            // 
            // TextBoxClientsBank
            // 
            this.TextBoxClientsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxClientsBank.Location = new System.Drawing.Point(1029, 498);
            this.TextBoxClientsBank.Name = "TextBoxClientsBank";
            this.TextBoxClientsBank.Size = new System.Drawing.Size(126, 27);
            this.TextBoxClientsBank.TabIndex = 36;
            this.TextBoxClientsBank.Visible = false;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabelStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelStatus.Location = new System.Drawing.Point(916, 532);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(56, 19);
            this.LabelStatus.TabIndex = 37;
            this.LabelStatus.Text = "Status:";
            // 
            // LabelFilters
            // 
            this.LabelFilters.AutoSize = true;
            this.LabelFilters.BackColor = System.Drawing.Color.Transparent;
            this.LabelFilters.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFilters.Location = new System.Drawing.Point(491, 401);
            this.LabelFilters.Name = "LabelFilters";
            this.LabelFilters.Size = new System.Drawing.Size(63, 25);
            this.LabelFilters.TabIndex = 39;
            this.LabelFilters.Text = "Filtry:";
            // 
            // ButtonResetFilters
            // 
            this.ButtonResetFilters.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonResetFilters.Location = new System.Drawing.Point(270, 537);
            this.ButtonResetFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonResetFilters.Name = "ButtonResetFilters";
            this.ButtonResetFilters.Size = new System.Drawing.Size(203, 40);
            this.ButtonResetFilters.TabIndex = 40;
            this.ButtonResetFilters.Text = "Resetuj Filtry";
            this.ButtonResetFilters.UseVisualStyleBackColor = true;
            this.ButtonResetFilters.Click += new System.EventHandler(this.ButtonResetFilters_Click);
            // 
            // CheckBoxId
            // 
            this.CheckBoxId.AutoSize = true;
            this.CheckBoxId.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxId.Location = new System.Drawing.Point(487, 438);
            this.CheckBoxId.Name = "CheckBoxId";
            this.CheckBoxId.Size = new System.Drawing.Size(12, 11);
            this.CheckBoxId.TabIndex = 41;
            this.CheckBoxId.UseVisualStyleBackColor = false;
            this.CheckBoxId.CheckedChanged += new System.EventHandler(this.CheckBoxId_CheckedChanged);
            // 
            // CheckBoxDate
            // 
            this.CheckBoxDate.AutoSize = true;
            this.CheckBoxDate.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxDate.Location = new System.Drawing.Point(487, 471);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Size = new System.Drawing.Size(12, 11);
            this.CheckBoxDate.TabIndex = 42;
            this.CheckBoxDate.UseVisualStyleBackColor = false;
            this.CheckBoxDate.CheckedChanged += new System.EventHandler(this.CheckBoxDate_CheckedChanged);
            // 
            // CheckBoxAmount
            // 
            this.CheckBoxAmount.AutoSize = true;
            this.CheckBoxAmount.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxAmount.Location = new System.Drawing.Point(487, 503);
            this.CheckBoxAmount.Name = "CheckBoxAmount";
            this.CheckBoxAmount.Size = new System.Drawing.Size(12, 11);
            this.CheckBoxAmount.TabIndex = 43;
            this.CheckBoxAmount.UseVisualStyleBackColor = false;
            this.CheckBoxAmount.CheckedChanged += new System.EventHandler(this.CheckBoxAmount_CheckedChanged);
            // 
            // CheckBoxFirm
            // 
            this.CheckBoxFirm.AutoSize = true;
            this.CheckBoxFirm.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxFirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxFirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxFirm.Location = new System.Drawing.Point(487, 537);
            this.CheckBoxFirm.Name = "CheckBoxFirm";
            this.CheckBoxFirm.Size = new System.Drawing.Size(12, 11);
            this.CheckBoxFirm.TabIndex = 44;
            this.CheckBoxFirm.UseVisualStyleBackColor = false;
            this.CheckBoxFirm.CheckedChanged += new System.EventHandler(this.CheckBoxFirm_CheckedChanged);
            // 
            // CheckBoxFirmsBank
            // 
            this.CheckBoxFirmsBank.AutoSize = true;
            this.CheckBoxFirmsBank.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxFirmsBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxFirmsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxFirmsBank.Location = new System.Drawing.Point(895, 438);
            this.CheckBoxFirmsBank.Name = "CheckBoxFirmsBank";
            this.CheckBoxFirmsBank.Size = new System.Drawing.Size(12, 11);
            this.CheckBoxFirmsBank.TabIndex = 45;
            this.CheckBoxFirmsBank.UseVisualStyleBackColor = false;
            this.CheckBoxFirmsBank.CheckedChanged += new System.EventHandler(this.CheckBoxFirmsBank_CheckedChanged);
            // 
            // CheckBoxCardNumber
            // 
            this.CheckBoxCardNumber.AutoSize = true;
            this.CheckBoxCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxCardNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxCardNumber.Location = new System.Drawing.Point(895, 471);
            this.CheckBoxCardNumber.Name = "CheckBoxCardNumber";
            this.CheckBoxCardNumber.Size = new System.Drawing.Size(12, 11);
            this.CheckBoxCardNumber.TabIndex = 46;
            this.CheckBoxCardNumber.UseVisualStyleBackColor = false;
            this.CheckBoxCardNumber.CheckedChanged += new System.EventHandler(this.CheckBoxCardNumber_CheckedChanged);
            // 
            // CheckBoxClientsBank
            // 
            this.CheckBoxClientsBank.AutoSize = true;
            this.CheckBoxClientsBank.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxClientsBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxClientsBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxClientsBank.Location = new System.Drawing.Point(895, 505);
            this.CheckBoxClientsBank.Name = "CheckBoxClientsBank";
            this.CheckBoxClientsBank.Size = new System.Drawing.Size(12, 11);
            this.CheckBoxClientsBank.TabIndex = 47;
            this.CheckBoxClientsBank.UseVisualStyleBackColor = false;
            this.CheckBoxClientsBank.CheckedChanged += new System.EventHandler(this.CheckBoxClientsBank_CheckedChanged);
            // 
            // CheckBoxStatus
            // 
            this.CheckBoxStatus.AutoSize = true;
            this.CheckBoxStatus.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxStatus.Location = new System.Drawing.Point(895, 537);
            this.CheckBoxStatus.Name = "CheckBoxStatus";
            this.CheckBoxStatus.Size = new System.Drawing.Size(12, 11);
            this.CheckBoxStatus.TabIndex = 48;
            this.CheckBoxStatus.UseVisualStyleBackColor = false;
            this.CheckBoxStatus.CheckedChanged += new System.EventHandler(this.CheckBoxStatus_CheckedChanged);
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Items.AddRange(new object[] {
            "Zaakceptowana",
            "Odrzucona"});
            this.ComboBoxStatus.Location = new System.Drawing.Point(978, 532);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(177, 27);
            this.ComboBoxStatus.TabIndex = 49;
            this.ComboBoxStatus.Visible = false;
            // 
            // LabelFromAmount
            // 
            this.LabelFromAmount.AutoSize = true;
            this.LabelFromAmount.BackColor = System.Drawing.Color.Transparent;
            this.LabelFromAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFromAmount.Location = new System.Drawing.Point(563, 500);
            this.LabelFromAmount.Name = "LabelFromAmount";
            this.LabelFromAmount.Size = new System.Drawing.Size(33, 19);
            this.LabelFromAmount.TabIndex = 50;
            this.LabelFromAmount.Text = "Od";
            this.LabelFromAmount.Visible = false;
            // 
            // LabelToAmount
            // 
            this.LabelToAmount.AutoSize = true;
            this.LabelToAmount.BackColor = System.Drawing.Color.Transparent;
            this.LabelToAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelToAmount.Location = new System.Drawing.Point(732, 500);
            this.LabelToAmount.Name = "LabelToAmount";
            this.LabelToAmount.Size = new System.Drawing.Size(30, 19);
            this.LabelToAmount.TabIndex = 51;
            this.LabelToAmount.Text = "Do";
            this.LabelToAmount.Visible = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSave.Location = new System.Drawing.Point(938, 17);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(96, 46);
            this.ButtonSave.TabIndex = 52;
            this.ButtonSave.Text = "Zapisz";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonSaveAndExit
            // 
            this.ButtonSaveAndExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSaveAndExit.Location = new System.Drawing.Point(1038, 17);
            this.ButtonSaveAndExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSaveAndExit.Name = "ButtonSaveAndExit";
            this.ButtonSaveAndExit.Size = new System.Drawing.Size(116, 46);
            this.ButtonSaveAndExit.TabIndex = 53;
            this.ButtonSaveAndExit.Text = "Zapisz i Wyjdź";
            this.ButtonSaveAndExit.UseVisualStyleBackColor = true;
            this.ButtonSaveAndExit.Click += new System.EventHandler(this.ButtonSaveAndExit_Click);
            // 
            // FCentrumTransakcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COKPOProject.Properties.Resources.Tlo_1;
            this.ClientSize = new System.Drawing.Size(1180, 612);
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