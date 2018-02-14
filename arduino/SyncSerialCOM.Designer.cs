namespace arduino
{
    partial class SyncSerialCOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyncSerialCOM));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSerialComPort = new System.Windows.Forms.ComboBox();
            this.btnSetPort = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select COM port";
            // 
            // cbSerialComPort
            // 
            this.cbSerialComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSerialComPort.FormattingEnabled = true;
            this.cbSerialComPort.Location = new System.Drawing.Point(156, 33);
            this.cbSerialComPort.Name = "cbSerialComPort";
            this.cbSerialComPort.Size = new System.Drawing.Size(181, 28);
            this.cbSerialComPort.TabIndex = 1;
            // 
            // btnSetPort
            // 
            this.btnSetPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetPort.ForeColor = System.Drawing.Color.Black;
            this.btnSetPort.Location = new System.Drawing.Point(344, 33);
            this.btnSetPort.Name = "btnSetPort";
            this.btnSetPort.Size = new System.Drawing.Size(100, 45);
            this.btnSetPort.TabIndex = 2;
            this.btnSetPort.Text = "Set port";
            this.btnSetPort.UseVisualStyleBackColor = true;
            this.btnSetPort.Click += new System.EventHandler(this.btnSetPort_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(199, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SyncSerialCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(493, 134);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSetPort);
            this.Controls.Add(this.cbSerialComPort);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SyncSerialCOM";
            this.Text = "Serial COM port selection";
            this.Load += new System.EventHandler(this.SyncSerialCOM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSerialComPort;
        private System.Windows.Forms.Button btnSetPort;
        private System.Windows.Forms.Button btnClose;
    }
}