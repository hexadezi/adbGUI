// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
    using Methods;
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class SpoofMac : Form
    {
        private readonly CmdProcess _adb;
        private readonly FormMethods _formMethods;

        public SpoofMac(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            _adb = adbFrm;
            _formMethods = formMethodsFrm;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            Close();
            return true;
        }

        private void Btn_SpoofMacSet_Click(object sender, EventArgs e)
        {
            var s = txt_SpoofMacAdress.Text;

            var r = new Regex(@"(([a-f]|[0-9]|[A-F]){2}\:){5}([a-f]|[0-9]|[A-F]){2}\b");

            if (r.Match(s).Success)
                _adb.StartProcessing("adb shell su root ifconfig wlan0 hw ether " + s, _formMethods.SelectedDevice());
            else
                MessageBox.Show(@"Please enter a valid MAC address", @"Error");
        }

        private void Btn_SpoofMacReset_Click(object sender, EventArgs e)
        {
            _adb.StartProcessing("adb shell su root ifconfig wlan0 down", _formMethods.SelectedDevice());
        }

        private void Btn_SpoofMacShow_Click(object sender, EventArgs e)
        {
            _adb.StartProcessing("adb shell su root cat /sys/class/net/wlan0/address", _formMethods.SelectedDevice());
        }

        private void Txt_SpoofMacAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btn_SpoofMacSet.PerformClick();
            e.SuppressKeyPress = true;
        }
    }
}