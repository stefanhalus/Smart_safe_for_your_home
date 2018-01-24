namespace arduino
{
    partial class HelpUserGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpUserGuide));
            this.wbInstructiuni = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbInstructiuni
            // 
            this.wbInstructiuni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbInstructiuni.Location = new System.Drawing.Point(0, 0);
            this.wbInstructiuni.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbInstructiuni.Name = "wbInstructiuni";
            this.wbInstructiuni.Size = new System.Drawing.Size(856, 454);
            this.wbInstructiuni.TabIndex = 0;
            // 
            // HelpUserGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(856, 454);
            this.Controls.Add(this.wbInstructiuni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HelpUserGuide";
            this.Text = "User Guide";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbInstructiuni;
    }
}