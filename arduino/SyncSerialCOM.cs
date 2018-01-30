using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace arduino
{
    public partial class SyncSerialCOM : Form
    {
        private Form1 form1;
        public SyncSerialCOM()
        {
            InitializeComponent();
        }

        private void SyncSerialCOM_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            cbSerialComPort.DataSource = ports;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetPort_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.smartComPort = cbSerialComPort.Text;
            Properties.Settings.Default.Save();
            SerialComPortSelected = cbSerialComPort.Text;
            MessageBox.Show(
                    String.Format("The new com port was set! \nPort COM: {0} \n\nPlease restart the application to load new settings!", cbSerialComPort.Text),
                    "Setting new com port",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            this.Close();
        }

        public static String SerialComPortSelected { get; set; }
    }
}
