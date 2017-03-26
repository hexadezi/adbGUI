using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class SpoofMac : Form
    {
        private AdbOps adb;
        private FormMethods formMethods;

        public SpoofMac(AdbOps adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            adb = adbFrm;
            formMethods = formMethodsFrm;
        }

        private void Btn_SpoofMacSet_Click(object sender, EventArgs e)
        {
            // todo Größe der Buttons kleiner machen, damit die mit der Textbox passen
            var s = txt_SpoofMacAdress.Text;

            var r = new Regex(@"(([a-f]|[0-9]|[A-F]){2}\:){5}([a-f]|[0-9]|[A-F]){2}\b");

            if (r.Match(s).Success)
            {
                adb.StartProcessing("shell su root ifconfig wlan0 hw ether " + s, formMethods.SelectedDevice());
            }
            else
            {
                MessageBox.Show("Please enter a valid MAC address", "Error");
            }
        }

        private void Btn_SpoofMacReset_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell su root ifconfig wlan0 down", formMethods.SelectedDevice());
        }

        private void Btn_SpoofMacShow_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell su root cat /sys/class/net/wlan0/address", formMethods.SelectedDevice());
        }

        private void txt_SpoofMacAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SpoofMacSet.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}