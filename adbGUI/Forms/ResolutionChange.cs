using System;
using System.Windows.Forms;
using adbGUI.Methods;

namespace adbGUI.Forms
{
	public partial class ResolutionChange : ExtForm
	{
		public ResolutionChange()
		{
			InitializeComponent();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
			Close();
			return true;
		}

		private void Btn_ResolutionChangeSet_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb shell wm size " + txt_phoneResolution.Text);
		}

		private void Btn_ResolutionChangeReset_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb shell wm size reset");
		}

		private void Btn_ResolutionChangeShow_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb shell wm size");
		}

		private void Txt_phoneResolution_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			btn_ResolutionChangeSet.PerformClick();
			e.SuppressKeyPress = true;
		}
	}
}