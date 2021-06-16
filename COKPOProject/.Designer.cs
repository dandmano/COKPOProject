
namespace COKPOProject
{
    partial class FStronaGlowna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStronaGlowna));
            this.LabelMainMenuText = new System.Windows.Forms.Label();
            this.ButtonBegin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelMainMenuText
            // 
            this.LabelMainMenuText.AutoSize = true;
            this.LabelMainMenuText.BackColor = System.Drawing.Color.Transparent;
            this.LabelMainMenuText.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelMainMenuText.Location = new System.Drawing.Point(500, 180);
            this.LabelMainMenuText.Name = "LabelMainMenuText";
            this.LabelMainMenuText.Size = new System.Drawing.Size(581, 34);
            this.LabelMainMenuText.TabIndex = 0;
            this.LabelMainMenuText.Text = "Witaj w Centrum Obsługi Kart Płatniczych!";
            // 
            // ButtonBegin
            // 
            this.ButtonBegin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonBegin.Location = new System.Drawing.Point(675, 421);
            this.ButtonBegin.Name = "ButtonBegin";
            this.ButtonBegin.Size = new System.Drawing.Size(218, 58);
            this.ButtonBegin.TabIndex = 1;
            this.ButtonBegin.Text = "Zaczynajmy!";
            this.ButtonBegin.UseVisualStyleBackColor = true;
            this.ButtonBegin.Click += new System.EventHandler(this.ButtonBegin_Click);
            // 
            // FStronaGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.ButtonBegin);
            this.Controls.Add(this.LabelMainMenuText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FStronaGlowna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centrum Obsługi Kart Płatniczych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMainMenuText;
        private System.Windows.Forms.Button ButtonBegin;
    }
}

