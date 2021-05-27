
namespace COKPOProject
{
    partial class FCentrumTransakcji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCentrumTransakcji));
            this.CentrumTransakcjiLabel = new System.Windows.Forms.Label();
            this.ListaBankow = new System.Windows.Forms.ListBox();
            this.AddBankButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CentrumTransakcjiLabel
            // 
            this.CentrumTransakcjiLabel.AutoSize = true;
            this.CentrumTransakcjiLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CentrumTransakcjiLabel.Location = new System.Drawing.Point(410, 43);
            this.CentrumTransakcjiLabel.Name = "CentrumTransakcjiLabel";
            this.CentrumTransakcjiLabel.Size = new System.Drawing.Size(274, 34);
            this.CentrumTransakcjiLabel.TabIndex = 0;
            this.CentrumTransakcjiLabel.Text = "Centrum Transakcji";
            // 
            // ListaBankow
            // 
            this.ListaBankow.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListaBankow.FormattingEnabled = true;
            this.ListaBankow.ItemHeight = 22;
            this.ListaBankow.Location = new System.Drawing.Point(29, 123);
            this.ListaBankow.Name = "ListaBankow";
            this.ListaBankow.Size = new System.Drawing.Size(352, 488);
            this.ListaBankow.Sorted = true;
            this.ListaBankow.TabIndex = 1;
            this.ListaBankow.SelectedIndexChanged += new System.EventHandler(this.ListaBankow_SelectedIndexChanged);
            // 
            // AddBankButton
            // 
            this.AddBankButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBankButton.Location = new System.Drawing.Point(928, 123);
            this.AddBankButton.Name = "AddBankButton";
            this.AddBankButton.Size = new System.Drawing.Size(166, 39);
            this.AddBankButton.TabIndex = 2;
            this.AddBankButton.Text = "Dodaj Bank";
            this.AddBankButton.UseVisualStyleBackColor = true;
            this.AddBankButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FCentrumTransakcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.AddBankButton);
            this.Controls.Add(this.ListaBankow);
            this.Controls.Add(this.CentrumTransakcjiLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCentrumTransakcji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centrum Transakcji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CentrumTransakcjiLabel;
        private System.Windows.Forms.ListBox ListaBankow;
        private System.Windows.Forms.Button AddBankButton;
    }
}