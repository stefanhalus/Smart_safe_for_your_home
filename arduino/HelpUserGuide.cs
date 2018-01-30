using System;
using System.IO;
using System.Windows.Forms;

namespace arduino
{
    public partial class HelpUserGuide : Form
    {
        public HelpUserGuide()
        {
            InitializeComponent();
            String curDir = Directory.GetCurrentDirectory();
            wbInstructiuni.Url = new Uri(String.Format("file:///{0}/UserGuide.html", curDir));
        }
    }
}
