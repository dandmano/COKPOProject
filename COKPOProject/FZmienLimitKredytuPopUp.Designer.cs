
namespace COKPOProject
{
    partial class FZmienLimitKredytuPopUp
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
            this.TextBoxCreditValue = new System.Windows.Forms.TextBox();
            this.ButtonCreditChangeAccept = new System.Windows.Forms.Button();
            this.ButtonCreditChangeCancel = new System.Windows.Forms.Button();
            this.LabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxCreditValue
            // 
            this.TextBoxCreditValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCreditValue.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCreditValue.Location = new System.Drawing.Point(43, 65);
            this.TextBoxCreditValue.Name = "TextBoxCreditValue";
            this.TextBoxCreditValue.Size = new System.Drawing.Size(331, 48);
            this.TextBoxCreditValue.TabIndex = 0;
            this.TextBoxCreditValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxCreditValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCreditValue_KeyDown);
            this.TextBoxCreditValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCreditValue_KeyPress);
            // 
            // ButtonCreditChangeAccept
            // 
            this.ButtonCreditChangeAccept.Location = new System.Drawing.Point(43, 141);
            this.ButtonCreditChangeAccept.Name = "ButtonCreditChangeAccept";
            this.ButtonCreditChangeAccept.Size = new System.Drawing.Size(120, 40);
            this.ButtonCreditChangeAccept.TabIndex = 1;
            this.ButtonCreditChangeAccept.Text = "Zatwierdź";
            this.ButtonCreditChangeAccept.UseVisualStyleBackColor = true;
            this.ButtonCreditChangeAccept.Click += new System.EventHandler(this.ButtonAcceptChangeCreditLimit);
            // 
            // ButtonCreditChangeCancel
            // 
            this.ButtonCreditChangeCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCreditChangeCancel.Location = new System.Drawing.Point(254, 141);
            this.ButtonCreditChangeCancel.Name = "ButtonCreditChangeCancel";
            this.ButtonCreditChangeCancel.Size = new System.Drawing.Size(120, 40);
            this.ButtonCreditChangeCancel.TabIndex = 2;
            this.ButtonCreditChangeCancel.Text = "Anuluj";
            this.ButtonCreditChangeCancel.UseVisualStyleBackColor = true;
            this.ButtonCreditChangeCancel.Click += new System.EventHandler(this.ButtonCancelChangeCreditLimit_Click);
            // 
            // LabelText
            // 
            this.LabelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelText.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelText.Location = new System.Drawing.Point(0, 0);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(425, 62);
            this.LabelText.TabIndex = 3;
            this.LabelText.Text = "Podaj nowy limit kredytu";
            this.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FZmienLimitKredytuPopUp
            // 
            this.AcceptButton = this.ButtonCreditChangeAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.ButtonCreditChangeCancel;
            this.ClientSize = new System.Drawing.Size(425, 209);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.ButtonCreditChangeCancel);
            this.Controls.Add(this.ButtonCreditChangeAccept);
            this.Controls.Add(this.TextBoxCreditValue);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FZmienLimitKredytuPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FDodajBankPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxCreditValue;
        private System.Windows.Forms.Button ButtonCreditChangeAccept;
        private System.Windows.Forms.Button ButtonCreditChangeCancel;
        private System.Windows.Forms.Label LabelText;
    }
}