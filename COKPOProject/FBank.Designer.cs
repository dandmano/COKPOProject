﻿
namespace COKPOProject
{
    partial class FBank
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
            this.BankLabel = new System.Windows.Forms.Label();
            this.ButtonAddClient = new System.Windows.Forms.Button();
            this.ButtonDeleteCustomer = new System.Windows.Forms.Button();
            this.ButtonChangeBankName = new System.Windows.Forms.Button();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.ButtonOpenClient = new System.Windows.Forms.Button();
            this.ButtonChangeClientsName = new System.Windows.Forms.Button();
            this.ButtonNormalClient = new System.Windows.Forms.Button();
            this.ButtonAllClients = new System.Windows.Forms.Button();
            this.ButtonClientCentrum = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BankLabel
            // 
            this.BankLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BankLabel.AutoSize = true;
            this.BankLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BankLabel.Location = new System.Drawing.Point(416, 16);
            this.BankLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(71, 26);
            this.BankLabel.TabIndex = 1;
            this.BankLabel.Text = "BANK";
            this.BankLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BankLabel.Click += new System.EventHandler(this.CentrumTransakcjiLabel_Click);
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonAddClient.Location = new System.Drawing.Point(480, 58);
            this.ButtonAddClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(200, 40);
            this.ButtonAddClient.TabIndex = 2;
            this.ButtonAddClient.Text = "Dodaj klienta";
            this.ButtonAddClient.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteCustomer
            // 
            this.ButtonDeleteCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonDeleteCustomer.Location = new System.Drawing.Point(685, 58);
            this.ButtonDeleteCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonDeleteCustomer.Name = "ButtonDeleteCustomer";
            this.ButtonDeleteCustomer.Size = new System.Drawing.Size(200, 40);
            this.ButtonDeleteCustomer.TabIndex = 3;
            this.ButtonDeleteCustomer.Text = "Usuń klienta";
            this.ButtonDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeBankName
            // 
            this.ButtonChangeBankName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonChangeBankName.Location = new System.Drawing.Point(662, 408);
            this.ButtonChangeBankName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonChangeBankName.Name = "ButtonChangeBankName";
            this.ButtonChangeBankName.Size = new System.Drawing.Size(200, 40);
            this.ButtonChangeBankName.TabIndex = 4;
            this.ButtonChangeBankName.Text = "Zmień Nazwę Banku";
            this.ButtonChangeBankName.UseVisualStyleBackColor = true;
            this.ButtonChangeBankName.Click += new System.EventHandler(this.ButtonChangeBankName_Click);
            // 
            // ClientListBox
            // 
            this.ClientListBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.ItemHeight = 17;
            this.ClientListBox.Location = new System.Drawing.Point(9, 58);
            this.ClientListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(264, 378);
            this.ClientListBox.Sorted = true;
            this.ClientListBox.TabIndex = 5;
            this.ClientListBox.SelectedIndexChanged += new System.EventHandler(this.ClientListBox_SelectedIndexChanged);
            // 
            // ButtonOpenClient
            // 
            this.ButtonOpenClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonOpenClient.Location = new System.Drawing.Point(276, 58);
            this.ButtonOpenClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonOpenClient.Name = "ButtonOpenClient";
            this.ButtonOpenClient.Size = new System.Drawing.Size(200, 40);
            this.ButtonOpenClient.TabIndex = 6;
            this.ButtonOpenClient.Text = "Przejdź do Klienta";
            this.ButtonOpenClient.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeClientsName
            // 
            this.ButtonChangeClientsName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonChangeClientsName.Location = new System.Drawing.Point(662, 356);
            this.ButtonChangeClientsName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonChangeClientsName.Name = "ButtonChangeClientsName";
            this.ButtonChangeClientsName.Size = new System.Drawing.Size(200, 40);
            this.ButtonChangeClientsName.TabIndex = 7;
            this.ButtonChangeClientsName.Text = "Zmień nazwę klienta";
            this.ButtonChangeClientsName.UseVisualStyleBackColor = true;
            // 
            // ButtonNormalClient
            // 
            this.ButtonNormalClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonNormalClient.Location = new System.Drawing.Point(9, 453);
            this.ButtonNormalClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonNormalClient.Name = "ButtonNormalClient";
            this.ButtonNormalClient.Size = new System.Drawing.Size(200, 40);
            this.ButtonNormalClient.TabIndex = 8;
            this.ButtonNormalClient.Text = "Zwykli klienci";
            this.ButtonNormalClient.UseVisualStyleBackColor = true;
            // 
            // ButtonAllClients
            // 
            this.ButtonAllClients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonAllClients.Location = new System.Drawing.Point(9, 498);
            this.ButtonAllClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAllClients.Name = "ButtonAllClients";
            this.ButtonAllClients.Size = new System.Drawing.Size(200, 40);
            this.ButtonAllClients.TabIndex = 9;
            this.ButtonAllClients.Text = "Wszyscy klienci";
            this.ButtonAllClients.UseVisualStyleBackColor = true;
            // 
            // ButtonClientCentrum
            // 
            this.ButtonClientCentrum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonClientCentrum.Location = new System.Drawing.Point(9, 543);
            this.ButtonClientCentrum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonClientCentrum.Name = "ButtonClientCentrum";
            this.ButtonClientCentrum.Size = new System.Drawing.Size(200, 40);
            this.ButtonClientCentrum.TabIndex = 10;
            this.ButtonClientCentrum.Text = "Klienci centrum";
            this.ButtonClientCentrum.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonBack.Location = new System.Drawing.Point(792, 543);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(70, 40);
            this.ButtonBack.TabIndex = 11;
            this.ButtonBack.Text = "Wstecz";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // FBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonClientCentrum);
            this.Controls.Add(this.ButtonAllClients);
            this.Controls.Add(this.ButtonNormalClient);
            this.Controls.Add(this.ButtonChangeClientsName);
            this.Controls.Add(this.ButtonOpenClient);
            this.Controls.Add(this.ClientListBox);
            this.Controls.Add(this.ButtonChangeBankName);
            this.Controls.Add(this.ButtonDeleteCustomer);
            this.Controls.Add(this.ButtonAddClient);
            this.Controls.Add(this.BankLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBank";
            this.Load += new System.EventHandler(this.FBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.Button ButtonAddClient;
        private System.Windows.Forms.Button ButtonDeleteCustomer;
        private System.Windows.Forms.Button ButtonChangeBankName;
        private System.Windows.Forms.ListBox ClientListBox;
        private System.Windows.Forms.Button ButtonOpenClient;
        private System.Windows.Forms.Button ButtonChangeClientsName;
        private System.Windows.Forms.Button ButtonNormalClient;
        private System.Windows.Forms.Button ButtonAllClients;
        private System.Windows.Forms.Button ButtonClientCentrum;
        private System.Windows.Forms.Button ButtonBack;
    }
}