using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace arduino
{
    public partial class Form1 : Form
	{
        //DbAdaptor bază de date
        private DbAdaptor db = new DbAdaptor();
        //Răspunsul serial de la Arduino
        private String mStr;
        
		public Form1()
		{
			InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Definim valoarea implicită a stringului de conexiune
            //Dacă nu se poate conecta la placa Aruino, acesta va fi mesajul implicit
            mStr = " - lipsă conexiune - ";
            //Verificăm conexiunea serială
            try
            {
                spArduino.Open();
            }
            catch (Exception ex)
            {
                syncProfilesToolStripMenuItem.Enabled = false;
                syncSMSNumberToolStripMenuItem.Enabled = false;
                syncUsersToolStripMenuItem.Enabled = false;
                MessageBox.Show(
                    ex.Message.ToString(), 
                    "Placa Arduino", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            }
            //Pornim cronometrul de reîmprospătare al statusului plăcii
            timer1.Start();
            //Populăm lista de utilizatori în DataGridVie-ulong inițial
            dgvUsers.DataSource = db.PopulateDGVUsers();
        }
        
        /* 
         * Acțiunea butolului insert
         * După salvarea în baza de date se curăță și se repopulează DataGridView-ul
        */
        private void binsert_Click(object sender, EventArgs e)
        {
            List<DataUser> usr = new List<DataUser>();
            usr.Add(
                new DataUser() {
                    Name = tname.Text,
                    Pass = tpass.Text,
                    Phone = tphone.Text
                });
            db.InsertUsers(usr);
            curataDate();
            dgvUsers.DataSource = db.PopulateDGVUsers();
        }

        //Acțiunea butonului de actualizare
        private void bupdate_Click(object sender, EventArgs e)
        {
            List<DataUser> usr = new List<DataUser>() {
                new DataUser() {
                    Id = Convert.ToInt16(tid.Text),
                    Name = tname.Text,
                    Pass = tpass.Text,
                    Phone = tphone.Text
                } };
            db.UpdateUsers(usr);
            curataDate();
            dgvUsers.DataSource = db.PopulateDGVUsers();
        }

        //Acțiunea butonului de ștergere
        private void bdel_Click(object sender, EventArgs e)
        {
            db.DeleteUsers(Convert.ToInt16(tid.Text));
            curataDate();
            dgvUsers.DataSource = db.PopulateDGVUsers();
        }

        //Acțiune Meniu Profile -> deschide fereastra de administrare a profilurilor
        private void setProfilesMain_Click(object sender, EventArgs e)
		{
		    Profiles profiles = new Profiles();
            profiles.ShowDialog();
		}
        
        //Definire cap de rând pentru DataGridView
        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tid.Text = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
            tname.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            tpass.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            tphone.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        /* 
         * Metodă care va curăța valorile din TextBox-uri
         */
        private void curataDate()
        {
            tid.Text = "0";
            tname.Text = "";
            tpass.Text = "";
            tphone.Text = "";
        }

        //La trecerea pe un rînd nou, se curălă valorile din cormularul de actualizare
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            curataDate();
        }

        //Acțiunea de actualizare a cronometrului
        private void timer1_Tick(object sender, EventArgs e)
        {
            tarm.Text = mStr;
        }

        //Impune textul obținut de la Arduino serial în stringul de stare afișat
        private void spArduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            mStr = spArduino.ReadLine();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpAbout about = new HelpAbout();
            about.ShowDialog();
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpUserGuide userGuide = new HelpUserGuide();
            userGuide.Show();
        }

        private void setSMSDestinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmsDestination sms = new SmsDestination();
            sms.Show();
        }

        private void syncSMSNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var phoneNumberToSync = Properties.Settings.Default.smartSmsNumber;
                spArduino.WriteLine("*" + phoneNumberToSync + "$");
                MessageBox.Show(
                    "Success! \nNew number set to Arduino!",
                    "Arduino syncronized",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed! Syncronization error! \nReason: " + ex.Message,
                    "Arduino not syncronized",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void syncUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var usersDataToSync = db.SyncUsers();
                spArduino.WriteLine(usersDataToSync);
                MessageBox.Show(
                    "Success! \nUsers were stored to Arduino!",
                    "Arduino syncronized",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed! Syncronization error! \nReason: " + ex.Message,
                    "Arduino not syncronized",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void syncProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                spArduino.WriteLine(db.SyncProfiles());
                MessageBox.Show(
                    "Success! \nProfiles were stored to Arduino!",
                    "Arduino syncronized",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed! Syncronization error! \nReason: " + ex.Message,
                    "Arduino not syncronized",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }
    }
}
