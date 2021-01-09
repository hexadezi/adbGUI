using System;
using System.Windows.Forms;
using adbGUI.Methods;

namespace adbGUI.Forms
{
	public partial class SetProp : ExtForm
	{
		public SetProp()
		{
			InitializeComponent();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
			Close();
			return true;
		}

		private void Btn_setProp_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb shell su root setprop " + txt_setPropKey.Text + " " + txt_setPropValue.Text);
		}
	}
}