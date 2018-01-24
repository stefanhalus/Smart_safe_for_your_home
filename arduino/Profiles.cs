using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace arduino
{
    public partial class Profiles : Form
	{
		
        /* 
         * Definim o variabilă care să conține ID-ul pentru Update/Delete
         */
        int ID = 0;

        DbAdaptor db = new DbAdaptor();

        public Profiles()
		{
			InitializeComponent();
		}
        
		private void Profiles_Load(object sender, EventArgs e)
		{
            this.SuspendLayout();
            dgvProfiles.DataSource = db.PopulateDGVProfiles();
            this.ResumeLayout();
		}

		private void binsert_Click(object sender, EventArgs e)
		{
            List<DataProfile> profil = new List<DataProfile>();
            profil.Add(new DataProfile() {
                Name = tname.Text,
                Delay = Convert.ToInt16(tdelay.Text),
                HourStart = tstart.Text,
                HourEnd = tend.Text
            } );
            db.InsertProfiles(profil);
            curataDate();
            dgvProfiles.DataSource = db.PopulateDGVProfiles();
		}

		private void bupdate_Click(object sender, EventArgs e)
		{
            List<DataProfile> profil = new List<DataProfile>();
            profil.Add(new DataProfile()
            {
                Id = Convert.ToInt16(tid.Text),
                Name = tname.Text,
                Delay = Convert.ToInt16(tdelay.Text),
                HourStart = tstart.Text,
                HourEnd = tend.Text
            });
            db.UpdateProfiles(profil);
            // METODĂ DE CURĂȚARE
            curataDate();
            dgvProfiles.DataSource = db.PopulateDGVProfiles();
		}

		private void bdel_Click(object sender, EventArgs e)
		{
            db.DeleteProfiles(Convert.ToInt16(tid.Text));
            // METODĂ DE CURĂȚARE
            curataDate();
            dgvProfiles.DataSource = db.PopulateDGVProfiles();
		}

        private void curataDate() {
            ID = 0;
            tid.Text = "";
            tname.Text = "";
            tdelay.Text = "";
            tstart.Text = "";
            tend.Text = "";
        }

		private void dataGridView_profiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void dataGridView_profiles_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_profiles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tid.Text = dgvProfiles.Rows[e.RowIndex].Cells[0].Value.ToString();
            tname.Text = dgvProfiles.Rows[e.RowIndex].Cells[1].Value.ToString();
            tdelay.Text = dgvProfiles.Rows[e.RowIndex].Cells[2].Value.ToString();
            tstart.Text = dgvProfiles.Rows[e.RowIndex].Cells[3].Value.ToString();
            tend.Text = dgvProfiles.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


