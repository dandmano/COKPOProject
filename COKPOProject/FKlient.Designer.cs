
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
            this.SuspendLayout();
            // 
            // ClientiLabel
            // 
            this.ClientiLabel.AutoSize = true;
            this.ClientiLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClientiLabel.Location = new System.Drawing.Point(394, 26);
            this.ClientiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientiLabel.Name = "ClientiLabel";
            this.ClientiLabel.Size = new System.Drawing.Size(70, 26);
            this.ClientiLabel.TabIndex = 1;
            this.ClientiLabel.Text = "Klient";
            this.ClientiLabel.Click += new System.EventHandler(this.ClientiLabel_Click);
            // 
            // CardListBox
            // 
            this.CardListBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CardListBox.FormattingEnabled = true;
            this.CardListBox.ItemHeight = 17;
            this.CardListBox.Location = new System.Drawing.Point(11, 65);
            this.CardListBox.Margin = new System.Windows.Forms.Padding(2);
            this.CardListBox.Name = "CardListBox";
            this.CardListBox.Size = new System.Drawing.Size(264, 378);
            this.CardListBox.Sorted = true;
            this.CardListBox.TabIndex = 6;
            // 
            // ClientButtonBack
            // 
            this.ClientButtonBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ClientButtonBack.Location = new System.Drawing.Point(805, 561);
            this.ClientButtonBack.Margin = new System.Windows.Forms.Padding(2);
            this.ClientButtonBack.Name = "ClientButtonBack";
            this.ClientButtonBack.Size = new System.Drawing.Size(70, 40);
            this.ClientButtonBack.TabIndex = 12;
            this.ClientButtonBack.Text = "Wstecz";
            this.ClientButtonBack.UseVisualStyleBackColor = true;
            // 
            // GoToCardButton
            // 
            this.GoToCardButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.GoToCardButton.Location = new System.Drawing.Point(632, 65);
            this.GoToCardButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoToCardButton.Name = "GoToCardButton";
            this.GoToCardButton.Size = new System.Drawing.Size(200, 40);
            this.GoToCardButton.TabIndex = 13;
            this.GoToCardButton.Text = "Przejdź do Karty";
            this.GoToCardButton.UseVisualStyleBackColor = true;
            this.GoToCardButton.Click += new System.EventHandler(this.GoToCardButton_Click);
            // 
            // AddCardButton
            // 
            this.AddCardButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AddCardButton.Location = new System.Drawing.Point(632, 109);
            this.AddCardButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(200, 40);
            this.AddCardButton.TabIndex = 14;
            this.AddCardButton.Text = "Dodaj Kartę";
            this.AddCardButton.UseVisualStyleBackColor = true;
            // 
            // CardRemoveButton
            // 
            this.CardRemoveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.CardRemoveButton.Location = new System.Drawing.Point(634, 153);
            this.CardRemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.CardRemoveButton.Name = "CardRemoveButton";
            this.CardRemoveButton.Size = new System.Drawing.Size(200, 40);
            this.CardRemoveButton.TabIndex = 15;
            this.CardRemoveButton.Text = "Usuń Kartę";
            this.CardRemoveButton.UseVisualStyleBackColor = true;
            // 
            // ChangeClientNameButton
            // 
            this.ChangeClientNameButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ChangeClientNameButton.Location = new System.Drawing.Point(632, 197);
            this.ChangeClientNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeClientNameButton.Name = "ChangeClientNameButton";
            this.ChangeClientNameButton.Size = new System.Drawing.Size(200, 40);
            this.ChangeClientNameButton.TabIndex = 16;
            this.ChangeClientNameButton.Text = "Zmień Nazwę Klienta";
            this.ChangeClientNameButton.UseVisualStyleBackColor = true;
            // 
            // RegisterTransactionButton
            // 
            this.RegisterTransactionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.RegisterTransactionButton.Location = new System.Drawing.Point(632, 403);
            this.RegisterTransactionButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterTransactionButton.Name = "RegisterTransactionButton";
            this.RegisterTransactionButton.Size = new System.Drawing.Size(200, 40);
            this.RegisterTransactionButton.TabIndex = 17;
            this.RegisterTransactionButton.Text = "Rejestruj Transakcję";
            this.RegisterTransactionButton.UseVisualStyleBackColor = true;
            // 
            // FKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.RegisterTransactionButton);
            this.Controls.Add(this.ChangeClientNameButton);
            this.Controls.Add(this.CardRemoveButton);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.GoToCardButton);
            this.Controls.Add(this.ClientButtonBack);
            this.Controls.Add(this.CardListBox);
            this.Controls.Add(this.ClientiLabel);
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
    }
}