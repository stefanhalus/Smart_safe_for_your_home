using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduino
{
    public partial class HelpAbout : Form
    {
        public HelpAbout()
        {
            InitializeComponent();
            lblVersion.Text = "1.0";
            lblAuthor.Text = "Team 3 Altran";
            lblLastUpdated.Text = "24.01.2018";
            lblContact.Text = "will appear soon...";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
