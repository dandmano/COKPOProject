
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBank));
            this.LabelBank = new System.Windows.Forms.Label();
            this.ButtonAddClient = new System.Windows.Forms.Button();
            this.ButtonDeleteClient = new System.Windows.Forms.Button();
            this.ListBoxClients = new System.Windows.Forms.ListBox();
            this.ButtonGoToClient = new System.Windows.Forms.Button();
            this.ButtonChangeClientsName = new System.Windows.Forms.Button();
            this.ButtonNormalClient = new System.Windows.Forms.Button();
            this.ButtonAllClients = new System.Windows.Forms.Button();
            this.ButtonFirm = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelListBoxClients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelBank
            // 
            this.LabelBank.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelBank.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBank.Location = new System.Drawing.Point(37, 20);
            this.LabelBank.Name = "LabelBank";
            this.LabelBank.Size = new System.Drawing.Size(1125, 71);
            this.LabelBank.TabIndex = 1;
            this.LabelBank.Text = "BANK";
            this.LabelBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonAddClient.Location = new System.Drawing.Point(863, 93);
            this.ButtonAddClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(267, 49);
            this.ButtonAddClient.TabIndex = 2;
            this.ButtonAddClient.Text = "Dodaj klienta";
            this.ButtonAddClient.UseVisualStyleBackColor = true;
            this.ButtonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // ButtonDeleteClient
            // 
            this.ButtonDeleteClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonDeleteClient.Location = new System.Drawing.Point(863, 163);
            this.ButtonDeleteClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonDeleteClient.Name = "ButtonDeleteClient";
            this.ButtonDeleteClient.Size = new System.Drawing.Size(267, 49);
            this.ButtonDeleteClient.TabIndex = 3;
            this.ButtonDeleteClient.Text = "Usuń klienta";
            this.ButtonDeleteClient.UseVisualStyleBackColor = true;
            this.ButtonDeleteClient.Click += new System.EventHandler(this.ButtonDeleteCustomer_Click);
            // 
            // ListBoxClients
            // 
            this.ListBoxClients.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxClients.FormattingEnabled = true;
            this.ListBoxClients.ItemHeight = 22;
            this.ListBoxClients.Location = new System.Drawing.Point(44, 93);
            this.ListBoxClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxClients.Name = "ListBoxClients";
            this.ListBoxClients.Size = new System.Drawing.Size(351, 466);
            this.ListBoxClients.Sorted = true;
            this.ListBoxClients.TabIndex = 5;
            // 
            // ButtonGoToClient
            // 
            this.ButtonGoToClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonGoToClient.Location = new System.Drawing.Point(863, 299);
            this.ButtonGoToClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonGoToClient.Name = "ButtonGoToClient";
            this.ButtonGoToClient.Size = new System.Drawing.Size(267, 49);
            this.ButtonGoToClient.TabIndex = 6;
            this.ButtonGoToClient.Text = "Przejdź do Klienta";
            this.ButtonGoToClient.UseVisualStyleBackColor = true;
            this.ButtonGoToClient.Click += new System.EventHandler(this.ButtonGoToClient_Click);
            // 
            // ButtonChangeClientsName
            // 
            this.ButtonChangeClientsName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonChangeClientsName.Location = new System.Drawing.Point(863, 232);
            this.ButtonChangeClientsName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonChangeClientsName.Name = "ButtonChangeClientsName";
            this.ButtonChangeClientsName.Size = new System.Drawing.Size(267, 49);
            this.ButtonChangeClientsName.TabIndex = 7;
            this.ButtonChangeClientsName.Text = "Zmień nazwę klienta";
            this.ButtonChangeClientsName.UseVisualStyleBackColor = true;
            this.ButtonChangeClientsName.Click += new System.EventHandler(this.ButtonChangeClientsName_Click);
            // 
            // ButtonNormalClient
            // 
            this.ButtonNormalClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonNormalClient.Location = new System.Drawing.Point(44, 615);
            this.ButtonNormalClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonNormalClient.Name = "ButtonNormalClient";
            this.ButtonNormalClient.Size = new System.Drawing.Size(351, 49);
            this.ButtonNormalClient.TabIndex = 8;
            this.ButtonNormalClient.Text = "Zwykli klienci";
            this.ButtonNormalClient.UseVisualStyleBackColor = true;
            this.ButtonNormalClient.Click += new System.EventHandler(this.ButtonNormalClient_Click);
            // 
            // ButtonAllClients
            // 
            this.ButtonAllClients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonAllClients.Location = new System.Drawing.Point(44, 562);
            this.ButtonAllClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAllClients.Name = "ButtonAllClients";
            this.ButtonAllClients.Size = new System.Drawing.Size(351, 49);
            this.ButtonAllClients.TabIndex = 9;
            this.ButtonAllClients.Text = "Wszyscy klienci";
            this.ButtonAllClients.UseVisualStyleBackColor = true;
            this.ButtonAllClients.Click += new System.EventHandler(this.ButtonAllClients_Click);
            // 
            // ButtonFirm
            // 
            this.ButtonFirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonFirm.Location = new System.Drawing.Point(44, 668);
            this.ButtonFirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonFirm.Name = "ButtonFirm";
            this.ButtonFirm.Size = new System.Drawing.Size(351, 49);
            this.ButtonFirm.TabIndex = 10;
            this.ButtonFirm.Text = "Firmy";
            this.ButtonFirm.UseVisualStyleBackColor = true;
            this.ButtonFirm.Click += new System.EventHandler(this.ButtonFirm_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonBack.Location = new System.Drawing.Point(1037, 668);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(93, 49);
            this.ButtonBack.TabIndex = 11;
            this.ButtonBack.Text = "Wstecz";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelListBoxClients
            // 
            this.LabelListBoxClients.AutoSize = true;
            this.LabelListBoxClients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelListBoxClients.Location = new System.Drawing.Point(40, 68);
            this.LabelListBoxClients.Name = "LabelListBoxClients";
            this.LabelListBoxClients.Size = new System.Drawing.Size(140, 23);
            this.LabelListBoxClients.TabIndex = 12;
            this.LabelListBoxClients.Text = "Lista Klientów";
            // 
            // FBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 753);
            this.Controls.Add(this.LabelListBoxClients);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonFirm);
            this.Controls.Add(this.ButtonAllClients);
            this.Controls.Add(this.ButtonNormalClient);
            this.Controls.Add(this.ButtonChangeClientsName);
            this.Controls.Add(this.ButtonGoToClient);
            this.Controls.Add(this.ListBoxClients);
            this.Controls.Add(this.ButtonDeleteClient);
            this.Controls.Add(this.ButtonAddClient);
            this.Controls.Add(this.LabelBank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FBank";
            this.Load += new System.EventHandler(this.FBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBank;
        private System.Windows.Forms.Button ButtonAddClient;
        private System.Windows.Forms.Button ButtonDeleteClient;
        private System.Windows.Forms.ListBox ListBoxClients;
        private System.Windows.Forms.Button ButtonGoToClient;
        private System.Windows.Forms.Button ButtonChangeClientsName;
        private System.Windows.Forms.Button ButtonNormalClient;
        private System.Windows.Forms.Button ButtonAllClients;
        private System.Windows.Forms.Button ButtonFirm;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelListBoxClients;
    }
}