
namespace COKPOProject
{
    partial class FDodajBankPopUp
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
            this.TextBoxBankName = new System.Windows.Forms.TextBox();
            this.ButtonBankAddAccept = new System.Windows.Forms.Button();
            this.ButtonBankAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxBankName
            // 
            this.TextBoxBankName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxBankName.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxBankName.Location = new System.Drawing.Point(43, 53);
            this.TextBoxBankName.Name = "TextBoxBankName";
            this.TextBoxBankName.Size = new System.Drawing.Size(331, 48);
            this.TextBoxBankName.TabIndex = 0;
            this.TextBoxBankName.Text = "Wpisz nazwę banku";
            this.TextBoxBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAddBank_KeyDown);
            // 
            // ButtonBankAddAccept
            // 
            this.ButtonBankAddAccept.Location = new System.Drawing.Point(43, 141);
            this.ButtonBankAddAccept.Name = "ButtonBankAddAccept";
            this.ButtonBankAddAccept.Size = new System.Drawing.Size(120, 40);
            this.ButtonBankAddAccept.TabIndex = 1;
            this.ButtonBankAddAccept.Text = "Zatwierdź";
            this.ButtonBankAddAccept.UseVisualStyleBackColor = true;
            this.ButtonBankAddAccept.Click += new System.EventHandler(this.BankAddAcceptButton_Click);
            // 
            // ButtonBankAddCancel
            // 
            this.ButtonBankAddCancel.Location = new System.Drawing.Point(254, 141);
            this.ButtonBankAddCancel.Name = "ButtonBankAddCancel";
            this.ButtonBankAddCancel.Size = new System.Drawing.Size(120, 40);
            this.ButtonBankAddCancel.TabIndex = 2;
            this.ButtonBankAddCancel.Text = "Anuluj";
            this.ButtonBankAddCancel.UseVisualStyleBackColor = true;
            this.ButtonBankAddCancel.Click += new System.EventHandler(this.BankAddCancelButton_Click);
            // 
            // FDodajBankPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(425, 209);
            this.Controls.Add(this.ButtonBankAddCancel);
            this.Controls.Add(this.ButtonBankAddAccept);
            this.Controls.Add(this.TextBoxBankName);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDodajBankPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDodajBankPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxBankName;
        private System.Windows.Forms.Button ButtonBankAddAccept;
        private System.Windows.Forms.Button ButtonBankAddCancel;
    }
}