namespace arduino
{
	partial class Profiles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profiles));
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.tdelay = new System.Windows.Forms.TextBox();
            this.tstart = new System.Windows.Forms.TextBox();
            this.tend = new System.Windows.Forms.TextBox();
            this.binsert = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.bdel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfiles
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvProfiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfiles.BackgroundColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfiles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProfiles.GridColor = System.Drawing.Color.Snow;
            this.dgvProfiles.Location = new System.Drawing.Point(71, 125);
            this.dgvProfiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvProfiles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProfiles.RowTemplate.Height = 24;
            this.dgvProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfiles.Size = new System.Drawing.Size(494, 238);
            this.dgvProfiles.TabIndex = 0;
            this.dgvProfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_profiles_CellContentClick);
            this.dgvProfiles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_profiles_RowHeaderMouseClick);
            this.dgvProfiles.SelectionChanged += new System.EventHandler(this.dataGridView_profiles_SelectionChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.Aqua;
            this.lblID.Location = new System.Drawing.Point(12, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 20);
            this.lblID.TabIndex = 900;
            this.lblID.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Aqua;
            this.lblName.Location = new System.Drawing.Point(86, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name ";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.ForeColor = System.Drawing.Color.Aqua;
            this.lblDelay.Location = new System.Drawing.Point(252, 18);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(49, 20);
            this.lblDelay.TabIndex = 3;
            this.lblDelay.Text = "Delay";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.ForeColor = System.Drawing.Color.Aqua;
            this.lblStart.Location = new System.Drawing.Point(386, 18);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(48, 20);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start ";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(523, 18);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(42, 20);
            this.lblEnd.TabIndex = 7;
            this.lblEnd.Text = "End ";
            // 
            // tid
            // 
            this.tid.BackColor = System.Drawing.Color.SlateGray;
            this.tid.ForeColor = System.Drawing.Color.Aqua;
            this.tid.Location = new System.Drawing.Point(2, 54);
            this.tid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(57, 26);
            this.tid.TabIndex = 900;
            this.tid.TabStop = false;
            this.tid.Visible = false;
            // 
            // tname
            // 
            this.tname.BackColor = System.Drawing.Color.SlateGray;
            this.tname.ForeColor = System.Drawing.Color.Aqua;
            this.tname.Location = new System.Drawing.Point(90, 54);
            this.tname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(146, 26);
            this.tname.TabIndex = 2;
            // 
            // tdelay
            // 
            this.tdelay.BackColor = System.Drawing.Color.SlateGray;
            this.tdelay.ForeColor = System.Drawing.Color.Aqua;
            this.tdelay.Location = new System.Drawing.Point(256, 54);
            this.tdelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tdelay.Name = "tdelay";
            this.tdelay.Size = new System.Drawing.Size(112, 26);
            this.tdelay.TabIndex = 4;
            // 
            // tstart
            // 
            this.tstart.BackColor = System.Drawing.Color.SlateGray;
            this.tstart.ForeColor = System.Drawing.Color.Aqua;
            this.tstart.Location = new System.Drawing.Point(390, 54);
            this.tstart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tstart.Name = "tstart";
            this.tstart.Size = new System.Drawing.Size(112, 26);
            this.tstart.TabIndex = 6;
            // 
            // tend
            // 
            this.tend.BackColor = System.Drawing.Color.SlateGray;
            this.tend.ForeColor = System.Drawing.Color.Aqua;
            this.tend.Location = new System.Drawing.Point(527, 54);
            this.tend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tend.Name = "tend";
            this.tend.Size = new System.Drawing.Size(112, 26);
            this.tend.TabIndex = 8;
            // 
            // binsert
            // 
            this.binsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.binsert.ForeColor = System.Drawing.Color.Red;
            this.binsert.Location = new System.Drawing.Point(589, 125);
            this.binsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.binsert.Name = "binsert";
            this.binsert.Size = new System.Drawing.Size(105, 59);
            this.binsert.TabIndex = 9;
            this.binsert.Text = "Insert";
            this.binsert.UseVisualStyleBackColor = true;
            this.binsert.Click += new System.EventHandler(this.binsert_Click);
            // 
            // bupdate
            // 
            this.bupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bupdate.ForeColor = System.Drawing.Color.Red;
            this.bupdate.Location = new System.Drawing.Point(589, 201);
            this.bupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(105, 48);
            this.bupdate.TabIndex = 10;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = true;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // bdel
            // 
            this.bdel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdel.ForeColor = System.Drawing.Color.Red;
            this.bdel.Location = new System.Drawing.Point(589, 268);
            this.bdel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bdel.Name = "bdel";
            this.bdel.Size = new System.Drawing.Size(105, 47);
            this.bdel.TabIndex = 11;
            this.bdel.Text = "Delete";
            this.bdel.UseVisualStyleBackColor = true;
            this.bdel.Click += new System.EventHandler(this.bdel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(293, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 38);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Profiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(733, 440);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bdel);
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.binsert);
            this.Controls.Add(this.tend);
            this.Controls.Add(this.tstart);
            this.Controls.Add(this.tdelay);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dgvProfiles);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Profiles";
            this.Text = "Profilescs";
            this.Load += new System.EventHandler(this.Profiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProfiles;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblDelay;
		private System.Windows.Forms.Label lblStart;
		private System.Windows.Forms.Label lblEnd;
		private System.Windows.Forms.TextBox tid;
		private System.Windows.Forms.TextBox tname;
		private System.Windows.Forms.TextBox tdelay;
		private System.Windows.Forms.TextBox tstart;
		private System.Windows.Forms.TextBox tend;
		private System.Windows.Forms.Button binsert;
		private System.Windows.Forms.Button bupdate;
		private System.Windows.Forms.Button bdel;
        private System.Windows.Forms.Button btnClose;
    }
}