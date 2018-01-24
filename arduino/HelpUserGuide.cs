using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduino
{
    public partial class HelpUserGuide : Form
    {
        public HelpUserGuide()
        {
            InitializeComponent();
            //try
            //{
                string html = File.ReadAllText("Instructiuni.html");
                wbInstructiuni.DocumentText = html;
            //}
            //catch (Exception ex) { }
        }
    }
}
