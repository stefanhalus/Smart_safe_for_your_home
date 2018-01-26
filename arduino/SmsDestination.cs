using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace arduino
{
    public partial class SmsDestination : Form
    {
        DbAdaptor db = new DbAdaptor();
        public SmsDestination()
        {
            InitializeComponent();
            tbCurrentSmsNumber.Text = Properties.Settings.Default.smartSmsNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.smartSmsNumber = cbNewSmsNumber.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show(
                    "Success! \nNew number is: \n\t" + Properties.Settings.Default.smartSmsNumber,
                    "Changeing SMS number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            this.Close();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DataTable table = db.PopulateDGVUsers();
            List<String> phoneNumbersList = new List<String>();
            foreach (DataRow nr in table.Rows)
                phoneNumbersList.Add(nr["phone"].ToString());
            cbNewSmsNumber.DataSource = phoneNumbersList;
            lblNewSmsNumber.Visible = true;
            cbNewSmsNumber.Visible = true;
            btnChange.Visible = false;
        }

        private void cbNewSmsNumber_SelectedValueChanged(object sender, EventArgs e)
        {
            btnSave.Visible = true;
        }
    }
}
