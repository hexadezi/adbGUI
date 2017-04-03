using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class SpoofMac : Form
    {
        private CmdProcess adb;
        private FormMethods formMethods;

        public SpoofMac(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            adb = adbFrm;
            formMethods = formMethodsFrm;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Btn_SpoofMacSet_Click(object sender, EventArgs e)
        {
            // todo Größe der Buttons kleiner machen, damit die mit der Textbox passen
            var s = txt_SpoofMacAdress.Text;

            var r = new Regex(@"(([a-f]|[0-9]|[A-F]){2}\:){5}([a-f]|[0-9]|[A-F]){2}\b");

            if (r.Match(s).Success)
            {
                adb.StartProcessing("adb shell su root ifconfig wlan0 hw ether " + s, formMethods.SelectedDevice());
            }
            else
            {
                MessageBox.Show("Please enter a valid MAC address", "Error");
            }
        }

        private void Btn_SpoofMacReset_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("adb shell su root ifconfig wlan0 down", formMethods.SelectedDevice());
        }

        private void Btn_SpoofMacShow_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("adb shell su root cat /sys/class/net/wlan0/address", formMethods.SelectedDevice());
        }

        private void Txt_SpoofMacAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SpoofMacSet.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void SpoofMac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}