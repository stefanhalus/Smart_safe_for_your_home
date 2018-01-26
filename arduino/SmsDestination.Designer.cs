namespace arduino
{
    partial class SmsDestination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmsDestination));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentNumber = new System.Windows.Forms.Label();
            this.tbCurrentSmsNumber = new System.Windows.Forms.TextBox();
            this.cbNewSmsNumber = new System.Windows.Forms.ComboBox();
            this.lblNewSmsNumber = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(332, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(180, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrentNumber
            // 
            this.lblCurrentNumber.AutoSize = true;
            this.lblCurrentNumber.Location = new System.Drawing.Point(27, 41);
            this.lblCurrentNumber.Name = "lblCurrentNumber";
            this.lblCurrentNumber.Size = new System.Drawing.Size(159, 20);
            this.lblCurrentNumber.TabIndex = 5;
            this.lblCurrentNumber.Text = "Current SMS number";
            // 
            // tbCurrentSmsNumber
            // 
            this.tbCurrentSmsNumber.AcceptsTab = true;
            this.tbCurrentSmsNumber.BackColor = System.Drawing.Color.SlateGray;
            this.tbCurrentSmsNumber.ForeColor = System.Drawing.Color.Aqua;
            this.tbCurrentSmsNumber.Location = new System.Drawing.Point(31, 64);
            this.tbCurrentSmsNumber.Name = "tbCurrentSmsNumber";
            this.tbCurrentSmsNumber.Size = new System.Drawing.Size(155, 26);
            this.tbCurrentSmsNumber.TabIndex = 6;
            // 
            // cbNewSmsNumber
            // 
            this.cbNewSmsNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNewSmsNumber.BackColor = System.Drawing.Color.SlateGray;
            this.cbNewSmsNumber.ForeColor = System.Drawing.Color.Aqua;
            this.cbNewSmsNumber.FormattingEnabled = true;
            this.cbNewSmsNumber.Location = new System.Drawing.Point(31, 133);
            this.cbNewSmsNumber.Name = "cbNewSmsNumber";
            this.cbNewSmsNumber.Size = new System.Drawing.Size(260, 28);
            this.cbNewSmsNumber.TabIndex = 7;
            this.cbNewSmsNumber.Visible = false;
            this.cbNewSmsNumber.SelectedValueChanged += new System.EventHandler(this.cbNewSmsNumber_SelectedValueChanged);
            // 
            // lblNewSmsNumber
            // 
            this.lblNewSmsNumber.AutoSize = true;
            this.lblNewSmsNumber.Location = new System.Drawing.Point(27, 110);
            this.lblNewSmsNumber.Name = "lblNewSmsNumber";
            this.lblNewSmsNumber.Size = new System.Drawing.Size(159, 20);
            this.lblNewSmsNumber.TabIndex = 8;
            this.lblNewSmsNumber.Text = "Current SMS number";
            this.lblNewSmsNumber.Visible = false;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.ForeColor = System.Drawing.Color.Red;
            this.btnChange.Location = new System.Drawing.Point(334, 64);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(137, 35);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // SmsDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(483, 272);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblNewSmsNumber);
            this.Controls.Add(this.cbNewSmsNumber);
            this.Controls.Add(this.tbCurrentSmsNumber);
            this.Controls.Add(this.lblCurrentNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SmsDestination";
            this.Text = "Sms Destination Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCurrentNumber;
        private System.Windows.Forms.TextBox tbCurrentSmsNumber;
        private System.Windows.Forms.ComboBox cbNewSmsNumber;
        private System.Windows.Forms.Label lblNewSmsNumber;
        private System.Windows.Forms.Button btnChange;
    }
}