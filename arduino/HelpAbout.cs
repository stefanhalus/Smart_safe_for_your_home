using System;
using System.Windows.Forms;

namespace arduino
{
    public partial class HelpAbout : Form
    {
        public HelpAbout()
        {
            InitializeComponent();
            lblVersion.Text = "1.1";
            lblAuthor.Text = String.Format(
                "Team 3 Altran: \n{0} \n{1} \n{2} \n{3} \n{4} \n{5} ",
                " - Diana Pop-Coman",
                " - Liviu Seplecan",
                " - Loredana Toma",
                " - Silvia Paius",
                " - Ștefan Halus",
                " - Timotei Dig"
                );
            lblLastUpdated.Text = "28.01.2018";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
