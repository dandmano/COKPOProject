
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
            this.ClientiLabel = new System.Windows.Forms.Label();
            this.CardListBox = new System.Windows.Forms.ListBox();
            this.ClientButtonBack = new System.Windows.Forms.Button();
            this.GoToCardButton = new System.Windows.Forms.Button();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.CardRemoveButton = new System.Windows.Forms.Button();
            this.ChangeClientNameButton = new System.Windows.Forms.Button();
            this.RegisterTransactionButton = new System.Windows.Forms.Button();
            this.CardInformationBox = new System.Windows.Forms.TextBox();
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
            this.GoToCardButton.Location = new System.Drawing.Point(843, 80);
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
            this.AddCardButton.Location = new System.Drawing.Point(843, 134);
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
            this.CardRemoveButton.Location = new System.Drawing.Point(845, 188);
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
            this.ChangeClientNameButton.Location = new System.Drawing.Point(843, 242);
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
            this.RegisterTransactionButton.Location = new System.Drawing.Point(843, 496);
            this.RegisterTransactionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterTransactionButton.Name = "RegisterTransactionButton";
            this.RegisterTransactionButton.Size = new System.Drawing.Size(267, 49);
            this.RegisterTransactionButton.TabIndex = 17;
            this.RegisterTransactionButton.Text = "Rejestruj Transakcję";
            this.RegisterTransactionButton.UseVisualStyleBackColor = true;
            // 
            // CardInformationBox
            // 
            this.CardInformationBox.BackColor = System.Drawing.Color.White;
            this.CardInformationBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CardInformationBox.Location = new System.Drawing.Point(438, 101);
            this.CardInformationBox.Multiline = true;
            this.CardInformationBox.Name = "CardInformationBox";
            this.CardInformationBox.ReadOnly = true;
            this.CardInformationBox.Size = new System.Drawing.Size(267, 197);
            this.CardInformationBox.TabIndex = 18;
            // 
            // FKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 753);
            this.Controls.Add(this.CardInformationBox);
            this.Controls.Add(this.RegisterTransactionButton);
            this.Controls.Add(this.ChangeClientNameButton);
            this.Controls.Add(this.CardRemoveButton);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.GoToCardButton);
            this.Controls.Add(this.ClientButtonBack);
            this.Controls.Add(this.CardListBox);
            this.Controls.Add(this.ClientiLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FKlient";
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
        private System.Windows.Forms.TextBox CardInformationBox;
    }
}