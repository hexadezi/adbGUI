using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using adbGUI.Methods;

namespace adbGUI.Forms
{
	public partial class SpoofMac : ExtForm
	{
		public SpoofMac()
		{
			InitializeComponent();
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
				HelperClass.Execute("adb shell su root ifconfig wlan0 hw ether " + s);
			else
				MessageBox.Show(@"Please enter a valid MAC address", @"Error");
		}

		private void Btn_SpoofMacReset_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb shell su root ifconfig wlan0 down");
		}

		private void Btn_SpoofMacShow_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb shell su root cat /sys/class/net/wlan0/address");
		}

		private void Txt_SpoofMacAdress_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			btn_SpoofMacSet.PerformClick();
			e.SuppressKeyPress = true;
		}
	}
}