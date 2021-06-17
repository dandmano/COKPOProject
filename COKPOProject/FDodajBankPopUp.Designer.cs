
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
            this.LabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxBankName
            // 
            this.TextBoxBankName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxBankName.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxBankName.Location = new System.Drawing.Point(43, 64);
            this.TextBoxBankName.MaxLength = 40;
            this.TextBoxBankName.Name = "TextBoxBankName";
            this.TextBoxBankName.Size = new System.Drawing.Size(331, 40);
            this.TextBoxBankName.TabIndex = 0;
            this.TextBoxBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.ButtonBankAddCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonBankAddCancel.Location = new System.Drawing.Point(254, 141);
            this.ButtonBankAddCancel.Name = "ButtonBankAddCancel";
            this.ButtonBankAddCancel.Size = new System.Drawing.Size(120, 40);
            this.ButtonBankAddCancel.TabIndex = 2;
            this.ButtonBankAddCancel.Text = "Anuluj";
            this.ButtonBankAddCancel.UseVisualStyleBackColor = true;
            this.ButtonBankAddCancel.Click += new System.EventHandler(this.BankAddCancelButton_Click);
            // 
            // LabelText
            // 
            this.LabelText.BackColor = System.Drawing.Color.Transparent;
            this.LabelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelText.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelText.Location = new System.Drawing.Point(0, 0);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(425, 61);
            this.LabelText.TabIndex = 3;
            this.LabelText.Text = "Wpisz nazwę banku:";
            this.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FDodajBankPopUp
            // 
            this.AcceptButton = this.ButtonBankAddAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::COKPOProject.Properties.Resources.Tlo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.ButtonBankAddCancel;
            this.ClientSize = new System.Drawing.Size(425, 209);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.ButtonBankAddCancel);
            this.Controls.Add(this.ButtonBankAddAccept);
            this.Controls.Add(this.TextBoxBankName);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDodajBankPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FDodajBankPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxBankName;
        private System.Windows.Forms.Button ButtonBankAddAccept;
        private System.Windows.Forms.Button ButtonBankAddCancel;
        private System.Windows.Forms.Label LabelText;
    }
}