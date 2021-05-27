
namespace COKPOProject
{
    partial class CentrumObslugiStronaGlowna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CentrumObslugiStronaGlowna));
            this.WitajLabel = new System.Windows.Forms.Label();
            this.PrzyciskZaczynajmy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WitajLabel
            // 
            this.WitajLabel.AutoSize = true;
            this.WitajLabel.BackColor = System.Drawing.Color.Transparent;
            this.WitajLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WitajLabel.Location = new System.Drawing.Point(294, 133);
            this.WitajLabel.Name = "WitajLabel";
            this.WitajLabel.Size = new System.Drawing.Size(581, 34);
            this.WitajLabel.TabIndex = 0;
            this.WitajLabel.Text = "Witaj w Centrum Obsługi Kart Płatniczych!";
            this.WitajLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrzyciskZaczynajmy
            // 
            this.PrzyciskZaczynajmy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrzyciskZaczynajmy.Location = new System.Drawing.Point(469, 374);
            this.PrzyciskZaczynajmy.Name = "PrzyciskZaczynajmy";
            this.PrzyciskZaczynajmy.Size = new System.Drawing.Size(218, 58);
            this.PrzyciskZaczynajmy.TabIndex = 1;
            this.PrzyciskZaczynajmy.Text = "Zaczynajmy!";
            this.PrzyciskZaczynajmy.UseVisualStyleBackColor = true;
            this.PrzyciskZaczynajmy.Click += new System.EventHandler(this.button1_Click);
            // 
            // CentrumObslugiStronaGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.PrzyciskZaczynajmy);
            this.Controls.Add(this.WitajLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CentrumObslugiStronaGlowna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centrum Obsługi Kart Płatniczych";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WitajLabel;
        private System.Windows.Forms.Button PrzyciskZaczynajmy;
    }
}

