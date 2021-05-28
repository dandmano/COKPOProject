
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
            this.DodajBankTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DodajBankTextBox
            // 
            this.DodajBankTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DodajBankTextBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajBankTextBox.Location = new System.Drawing.Point(43, 76);
            this.DodajBankTextBox.Name = "DodajBankTextBox";
            this.DodajBankTextBox.Size = new System.Drawing.Size(331, 48);
            this.DodajBankTextBox.TabIndex = 0;
            this.DodajBankTextBox.Text = "Wpisz nazwę banku";
            this.DodajBankTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DodajBankTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DodajBankTextBox_KeyDown);
            // 
            // FDodajBankPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(425, 209);
            this.Controls.Add(this.DodajBankTextBox);
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

        private System.Windows.Forms.TextBox DodajBankTextBox;
    }
}