
namespace COKPOProject
{
    partial class FDodajTransakcjiePopUp
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
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ComboBoxFirmy = new System.Windows.Forms.ComboBox();
            this.ComboBoxCards = new System.Windows.Forms.ComboBox();
            this.LabelFirma = new System.Windows.Forms.Label();
            this.LabelCards = new System.Windows.Forms.Label();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Location = new System.Drawing.Point(44, 282);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(274, 50);
            this.ButtonAccept.TabIndex = 0;
            this.ButtonAccept.Text = "Akceptuj";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(355, 282);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(260, 50);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Anuluj";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ComboBoxFirmy
            // 
            this.ComboBoxFirmy.FormattingEnabled = true;
            this.ComboBoxFirmy.Location = new System.Drawing.Point(40, 51);
            this.ComboBoxFirmy.Name = "ComboBoxFirmy";
            this.ComboBoxFirmy.Size = new System.Drawing.Size(575, 27);
            this.ComboBoxFirmy.TabIndex = 2;
            this.ComboBoxFirmy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFirmy_SelectedIndexChanged);
            // 
            // ComboBoxCards
            // 
            this.ComboBoxCards.FormattingEnabled = true;
            this.ComboBoxCards.Location = new System.Drawing.Point(40, 131);
            this.ComboBoxCards.Name = "ComboBoxCards";
            this.ComboBoxCards.Size = new System.Drawing.Size(575, 27);
            this.ComboBoxCards.TabIndex = 3;
            // 
            // LabelFirma
            // 
            this.LabelFirma.BackColor = System.Drawing.Color.Transparent;
            this.LabelFirma.Location = new System.Drawing.Point(113, 9);
            this.LabelFirma.Name = "LabelFirma";
            this.LabelFirma.Size = new System.Drawing.Size(428, 39);
            this.LabelFirma.TabIndex = 4;
            this.LabelFirma.Text = "Wybierz firmę zlecającą transakcję";
            this.LabelFirma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCards
            // 
            this.LabelCards.BackColor = System.Drawing.Color.Transparent;
            this.LabelCards.Location = new System.Drawing.Point(40, 85);
            this.LabelCards.Name = "LabelCards";
            this.LabelCards.Size = new System.Drawing.Size(575, 43);
            this.LabelCards.TabIndex = 5;
            this.LabelCards.Text = "Wybierz kartę do obciążenia";
            this.LabelCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Location = new System.Drawing.Point(40, 206);
            this.TextBoxAmount.MaxLength = 12;
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(575, 27);
            this.TextBoxAmount.TabIndex = 6;
            this.TextBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAmount_KeyPress);
            // 
            // LabelAmount
            // 
            this.LabelAmount.BackColor = System.Drawing.Color.Transparent;
            this.LabelAmount.Location = new System.Drawing.Point(40, 165);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(575, 38);
            this.LabelAmount.TabIndex = 7;
            this.LabelAmount.Text = "Kwota transakcji";
            this.LabelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FDodajTransakcjiePopUp
            // 
            this.AcceptButton = this.ButtonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(665, 379);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.TextBoxAmount);
            this.Controls.Add(this.LabelCards);
            this.Controls.Add(this.LabelFirma);
            this.Controls.Add(this.ComboBoxCards);
            this.Controls.Add(this.ComboBoxFirmy);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAccept);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDodajTransakcjiePopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FDodajTransakcjiePopUp";
            this.Load += new System.EventHandler(this.FDodajTransakcjiePopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox ComboBoxFirmy;
        private System.Windows.Forms.ComboBox ComboBoxCards;
        private System.Windows.Forms.Label LabelFirma;
        private System.Windows.Forms.Label LabelCards;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.Label LabelAmount;
    }
}