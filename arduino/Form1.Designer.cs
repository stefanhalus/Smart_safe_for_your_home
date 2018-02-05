namespace arduino
{
	partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.name = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.tphone = new System.Windows.Forms.TextBox();
            this.tpass = new System.Windows.Forms.TextBox();
            this.binsert = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.bdel = new System.Windows.Forms.Button();
            this.tid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tarm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setSMSDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncronizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncSelectCOMPort = new System.Windows.Forms.ToolStripMenuItem();
            this.syncSMSNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label2.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Aqua;
            label2.Location = new System.Drawing.Point(286, 52);
            label2.MaximumSize = new System.Drawing.Size(1350, 0);
            label2.MinimumSize = new System.Drawing.Size(619, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(619, 38);
            label2.TabIndex = 0;
            label2.Text = "Smart Safe For Your Home";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.ForeColor = System.Drawing.Color.Aqua;
            this.name.Location = new System.Drawing.Point(106, 241);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.ForeColor = System.Drawing.Color.Aqua;
            this.phone.Location = new System.Drawing.Point(523, 241);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(55, 20);
            this.phone.TabIndex = 9;
            this.phone.Text = "Phone";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.ForeColor = System.Drawing.Color.Aqua;
            this.pass.Location = new System.Drawing.Point(327, 241);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(78, 20);
            this.pass.TabIndex = 6;
            this.pass.Text = "Password";
            this.pass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tname
            // 
            this.tname.BackColor = System.Drawing.Color.SlateGray;
            this.tname.ForeColor = System.Drawing.Color.Aqua;
            this.tname.Location = new System.Drawing.Point(110, 265);
            this.tname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(179, 26);
            this.tname.TabIndex = 5;
            // 
            // tphone
            // 
            this.tphone.BackColor = System.Drawing.Color.SlateGray;
            this.tphone.ForeColor = System.Drawing.Color.Aqua;
            this.tphone.Location = new System.Drawing.Point(527, 265);
            this.tphone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tphone.Name = "tphone";
            this.tphone.Size = new System.Drawing.Size(167, 26);
            this.tphone.TabIndex = 10;
            // 
            // tpass
            // 
            this.tpass.BackColor = System.Drawing.Color.SlateGray;
            this.tpass.ForeColor = System.Drawing.Color.Aqua;
            this.tpass.Location = new System.Drawing.Point(331, 265);
            this.tpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(153, 26);
            this.tpass.TabIndex = 8;
            // 
            // binsert
            // 
            this.binsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.binsert.AutoSize = true;
            this.binsert.ForeColor = System.Drawing.Color.Red;
            this.binsert.Location = new System.Drawing.Point(745, 320);
            this.binsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.binsert.Name = "binsert";
            this.binsert.Size = new System.Drawing.Size(150, 55);
            this.binsert.TabIndex = 11;
            this.binsert.Text = "Insert";
            this.binsert.UseVisualStyleBackColor = true;
            this.binsert.Click += new System.EventHandler(this.binsert_Click);
            // 
            // bupdate
            // 
            this.bupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bupdate.AutoSize = true;
            this.bupdate.ForeColor = System.Drawing.Color.Red;
            this.bupdate.Location = new System.Drawing.Point(745, 380);
            this.bupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(150, 55);
            this.bupdate.TabIndex = 12;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = true;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // bdel
            // 
            this.bdel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bdel.AutoSize = true;
            this.bdel.ForeColor = System.Drawing.Color.Red;
            this.bdel.Location = new System.Drawing.Point(745, 440);
            this.bdel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bdel.Name = "bdel";
            this.bdel.Size = new System.Drawing.Size(150, 55);
            this.bdel.TabIndex = 13;
            this.bdel.Text = "Delete";
            this.bdel.UseVisualStyleBackColor = true;
            this.bdel.Click += new System.EventHandler(this.bdel_Click);
            // 
            // tid
            // 
            this.tid.BackColor = System.Drawing.Color.SlateGray;
            this.tid.ForeColor = System.Drawing.Color.Aqua;
            this.tid.Location = new System.Drawing.Point(24, 265);
            this.tid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(52, 26);
            this.tid.TabIndex = 0;
            this.tid.TabStop = false;
            this.tid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(20, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            this.label1.Visible = false;
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUsers.GridColor = System.Drawing.Color.SlateGray;
            this.dgvUsers.Location = new System.Drawing.Point(14, 319);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(714, 327);
            this.dgvUsers.TabIndex = 3;
            this.dgvUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_RowHeaderMouseClick);
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 170);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(327, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "* do not start with \"0\"";
            // 
            // tarm
            // 
            this.tarm.BackColor = System.Drawing.Color.SlateGray;
            this.tarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tarm.ForeColor = System.Drawing.Color.Aqua;
            this.tarm.HideSelection = false;
            this.tarm.Location = new System.Drawing.Point(541, 131);
            this.tarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tarm.Name = "tarm";
            this.tarm.ReadOnly = true;
            this.tarm.Size = new System.Drawing.Size(292, 39);
            this.tarm.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(379, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Status alarm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSMSDestinationToolStripMenuItem,
            this.syncronizeToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(970, 33);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setSMSDestinationToolStripMenuItem
            // 
            this.setSMSDestinationToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.setSMSDestinationToolStripMenuItem.Name = "setSMSDestinationToolStripMenuItem";
            this.setSMSDestinationToolStripMenuItem.Size = new System.Drawing.Size(183, 29);
            this.setSMSDestinationToolStripMenuItem.Text = "Set SMS destination";
            this.setSMSDestinationToolStripMenuItem.Click += new System.EventHandler(this.setSMSDestinationToolStripMenuItem_Click);
            // 
            // syncronizeToolStripMenuItem
            // 
            this.syncronizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncSelectCOMPort,
            this.syncSMSNumberToolStripMenuItem,
            this.syncUsersToolStripMenuItem});
            this.syncronizeToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.syncronizeToolStripMenuItem.Name = "syncronizeToolStripMenuItem";
            this.syncronizeToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.syncronizeToolStripMenuItem.Text = "Syncronize";
            // 
            // syncSelectCOMPort
            // 
            this.syncSelectCOMPort.BackColor = System.Drawing.SystemColors.Control;
            this.syncSelectCOMPort.ForeColor = System.Drawing.Color.Red;
            this.syncSelectCOMPort.Name = "syncSelectCOMPort";
            this.syncSelectCOMPort.Size = new System.Drawing.Size(227, 30);
            this.syncSelectCOMPort.Text = "Select COM port";
            this.syncSelectCOMPort.Click += new System.EventHandler(this.syncSelectCOMPort_Click);
            // 
            // syncSMSNumberToolStripMenuItem
            // 
            this.syncSMSNumberToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.syncSMSNumberToolStripMenuItem.Name = "syncSMSNumberToolStripMenuItem";
            this.syncSMSNumberToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.syncSMSNumberToolStripMenuItem.Text = "SMS Number";
            this.syncSMSNumberToolStripMenuItem.Click += new System.EventHandler(this.syncSMSNumberToolStripMenuItem_Click);
            // 
            // syncUsersToolStripMenuItem
            // 
            this.syncUsersToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.syncUsersToolStripMenuItem.Name = "syncUsersToolStripMenuItem";
            this.syncUsersToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.syncUsersToolStripMenuItem.Text = "Users";
            this.syncUsersToolStripMenuItem.Click += new System.EventHandler(this.syncUsersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.helpToolStripMenuItem.Text = "_Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.userGuideToolStripMenuItem.Text = "User guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.aboutToolStripMenuItem.Text = "About application";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 29);
            // 
            // spArduino
            // 
            this.spArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spArduino_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(970, 659);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tarm);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.bdel);
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.binsert);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.tphone);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Smart safe for your home";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label phone;
		private System.Windows.Forms.Label pass;
		private System.Windows.Forms.TextBox tname;
		private System.Windows.Forms.TextBox tphone;
		private System.Windows.Forms.TextBox tpass;
		private System.Windows.Forms.Button binsert;
		private System.Windows.Forms.Button bupdate;
		private System.Windows.Forms.Button bdel;
		private System.Windows.Forms.TextBox tid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tarm;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.IO.Ports.SerialPort spArduino;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSMSDestinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem syncronizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncSMSNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncSelectCOMPort;
    }
}

