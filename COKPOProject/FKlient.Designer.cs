
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
            this.CardListBox = new System.Windows.Forms.ListBox();
            this.ClientButtonBack = new System.Windows.Forms.Button();
            this.GoToCardButton = new System.Windows.Forms.Button();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.CardRemoveButton = new System.Windows.Forms.Button();
            this.ChangeClientNameButton = new System.Windows.Forms.Button();
            this.RegisterTransactionButton = new System.Windows.Forms.Button();
            this.NrKartyLabel = new System.Windows.Forms.Label();
            this.NrKartyTextBox = new System.Windows.Forms.TextBox();
            this.SaldoLabel = new System.Windows.Forms.Label();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.BankLabel = new System.Windows.Forms.Label();
            this.BankTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClientiLabel
            // 
            this.ClientiLabel.AutoSize = true;
            this.ClientiLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClientiLabel.Location = new System.Drawing.Point(525, 32);
            this.ClientiLabel.Name = "ClientiLabel";
            this.ClientiLabel.Size = new System.Drawing.Size(89, 34);
            this.ClientiLabel.TabIndex = 1;
            this.ClientiLabel.Text = "Klient";
            this.ClientiLabel.Click += new System.EventHandler(this.ClientiLabel_Click);
            // 
            // CardListBox
            // 
            this.CardListBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CardListBox.FormattingEnabled = true;
            this.CardListBox.ItemHeight = 22;
            this.CardListBox.Location = new System.Drawing.Point(12, 101);
            this.CardListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardListBox.Name = "CardListBox";
            this.CardListBox.Size = new System.Drawing.Size(351, 444);
            this.CardListBox.Sorted = true;
            this.CardListBox.TabIndex = 6;
            this.CardListBox.SelectedIndexChanged += new System.EventHandler(this.CardListBox_SelectedIndexChanged);
            // 
            // ClientButtonBack
            // 
            this.ClientButtonBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ClientButtonBack.Location = new System.Drawing.Point(1073, 690);
            this.ClientButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientButtonBack.Name = "ClientButtonBack";
            this.ClientButtonBack.Size = new System.Drawing.Size(93, 49);
            this.ClientButtonBack.TabIndex = 12;
            this.ClientButtonBack.Text = "Wstecz";
            this.ClientButtonBack.UseVisualStyleBackColor = true;
            this.ClientButtonBack.Click += new System.EventHandler(this.ClientButtonBack_Click);
            // 
            // GoToCardButton
            // 
            this.GoToCardButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.GoToCardButton.Location = new System.Drawing.Point(842, 101);
            this.GoToCardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoToCardButton.Name = "GoToCardButton";
            this.GoToCardButton.Size = new System.Drawing.Size(267, 49);
            this.GoToCardButton.TabIndex = 13;
            this.GoToCardButton.Text = "Przejdź do Karty";
            this.GoToCardButton.UseVisualStyleBackColor = true;
            this.GoToCardButton.Click += new System.EventHandler(this.GoToCardButton_Click);
            // 
            // AddCardButton
            // 
            this.AddCardButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AddCardButton.Location = new System.Drawing.Point(842, 156);
            this.AddCardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(267, 49);
            this.AddCardButton.TabIndex = 14;
            this.AddCardButton.Text = "Dodaj Kartę";
            this.AddCardButton.UseVisualStyleBackColor = true;
            // 
            // CardRemoveButton
            // 
            this.CardRemoveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.CardRemoveButton.Location = new System.Drawing.Point(842, 209);
            this.CardRemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardRemoveButton.Name = "CardRemoveButton";
            this.CardRemoveButton.Size = new System.Drawing.Size(267, 49);
            this.CardRemoveButton.TabIndex = 15;
            this.CardRemoveButton.Text = "Usuń Kartę";
            this.CardRemoveButton.UseVisualStyleBackColor = true;
            // 
            // ChangeClientNameButton
            // 
            this.ChangeClientNameButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ChangeClientNameButton.Location = new System.Drawing.Point(842, 262);
            this.ChangeClientNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeClientNameButton.Name = "ChangeClientNameButton";
            this.ChangeClientNameButton.Size = new System.Drawing.Size(267, 49);
            this.ChangeClientNameButton.TabIndex = 16;
            this.ChangeClientNameButton.Text = "Zmień Nazwę Klienta";
            this.ChangeClientNameButton.UseVisualStyleBackColor = true;
            // 
            // RegisterTransactionButton
            // 
            this.RegisterTransactionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.RegisterTransactionButton.Location = new System.Drawing.Point(842, 515);
            this.RegisterTransactionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterTransactionButton.Name = "RegisterTransactionButton";
            this.RegisterTransactionButton.Size = new System.Drawing.Size(267, 49);
            this.RegisterTransactionButton.TabIndex = 17;
            this.RegisterTransactionButton.Text = "Rejestruj Transakcję";
            this.RegisterTransactionButton.UseVisualStyleBackColor = true;
            this.RegisterTransactionButton.Visible = false;
            // 
            // NrKartyLabel
            // 
            this.NrKartyLabel.AutoSize = true;
            this.NrKartyLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NrKartyLabel.Location = new System.Drawing.Point(435, 95);
            this.NrKartyLabel.Name = "NrKartyLabel";
            this.NrKartyLabel.Size = new System.Drawing.Size(130, 23);
            this.NrKartyLabel.TabIndex = 19;
            this.NrKartyLabel.Text = "Numer Karty";
            // 
            // NrKartyTextBox
            // 
            this.NrKartyTextBox.BackColor = System.Drawing.Color.White;
            this.NrKartyTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NrKartyTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NrKartyTextBox.Location = new System.Drawing.Point(439, 121);
            this.NrKartyTextBox.Name = "NrKartyTextBox";
            this.NrKartyTextBox.ReadOnly = true;
            this.NrKartyTextBox.Size = new System.Drawing.Size(267, 32);
            this.NrKartyTextBox.TabIndex = 18;
            // 
            // SaldoLabel
            // 
            this.SaldoLabel.AutoSize = true;
            this.SaldoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaldoLabel.Location = new System.Drawing.Point(435, 183);
            this.SaldoLabel.Name = "SaldoLabel";
            this.SaldoLabel.Size = new System.Drawing.Size(64, 23);
            this.SaldoLabel.TabIndex = 21;
            this.SaldoLabel.Text = "Saldo";
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.BackColor = System.Drawing.Color.White;
            this.SaldoTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SaldoTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaldoTextBox.Location = new System.Drawing.Point(439, 209);
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.ReadOnly = true;
            this.SaldoTextBox.Size = new System.Drawing.Size(267, 32);
            this.SaldoTextBox.TabIndex = 20;
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BankLabel.Location = new System.Drawing.Point(435, 273);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(59, 23);
            this.BankLabel.TabIndex = 23;
            this.BankLabel.Text = "Bank";
            // 
            // BankTextBox
            // 
            this.BankTextBox.BackColor = System.Drawing.Color.White;
            this.BankTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BankTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BankTextBox.Location = new System.Drawing.Point(439, 299);
            this.BankTextBox.Name = "BankTextBox";
            this.BankTextBox.ReadOnly = true;
            this.BankTextBox.Size = new System.Drawing.Size(267, 32);
            this.BankTextBox.TabIndex = 22;
            // 
            // FKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 753);
            this.Controls.Add(this.BankLabel);
            this.Controls.Add(this.BankTextBox);
            this.Controls.Add(this.SaldoLabel);
            this.Controls.Add(this.SaldoTextBox);
            this.Controls.Add(this.NrKartyLabel);
            this.Controls.Add(this.NrKartyTextBox);
            this.Controls.Add(this.RegisterTransactionButton);
            this.Controls.Add(this.ChangeClientNameButton);
            this.Controls.Add(this.CardRemoveButton);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.GoToCardButton);
            this.Controls.Add(this.ClientButtonBack);
            this.Controls.Add(this.CardListBox);
            this.Controls.Add(this.ClientiLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ListBox CardListBox;
        private System.Windows.Forms.Button ClientButtonBack;
        private System.Windows.Forms.Button GoToCardButton;
        private System.Windows.Forms.Button AddCardButton;
        private System.Windows.Forms.Button CardRemoveButton;
        private System.Windows.Forms.Button ChangeClientNameButton;
        private System.Windows.Forms.Button RegisterTransactionButton;
        private System.Windows.Forms.Label NrKartyLabel;
        private System.Windows.Forms.TextBox NrKartyTextBox;
        private System.Windows.Forms.Label SaldoLabel;
        private System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.TextBox BankTextBox;
    }
}