using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using adbGUI.Methods;

namespace adbGUI.Forms
{
	public partial class InstallUninstall : ExtForm
	{
		public InstallUninstall()
		{
			InitializeComponent();
		}

		private void Btn_InstallUninstallInstall_Click(object sender, EventArgs e)
		{
			var s = "\"" + txt_InstallUninstallPackageInstall.Text + "\"";

			if (txt_InstallUninstallPackageInstall.Text != "")
			{
				HelperClass.Execute("adb install " + s);
			}
			else
			{
				MessageBox.Show(@"Please select a file!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Btn_InstallUninstallBrowse_Click(object sender, EventArgs e)
		{
			openFileDialog.FileName = "";
			openFileDialog.CheckFileExists = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.Filter = @" .apk|*.apk";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
				txt_InstallUninstallPackageInstall.Text = openFileDialog.FileName;
		}

		private void Btn_InstallUninstallUninstall_Click(object sender, EventArgs e)
		{
			var s = "\"" + cbx_InstallUninstallPackageUninstall.SelectedItem + "\"";

			HelperClass.Execute("adb uninstall " + s);
		}

		private void Btn_InstallUninstallRefreshApps_Click(object sender, EventArgs e)
		{
			groupBox1.Enabled = false;
			groupBox3.Enabled = false;
			RefreshInstalledApps();
			groupBox1.Enabled = true;
			groupBox3.Enabled = true;
		}

		private void RefreshInstalledApps()
		{
			cbx_InstallUninstallPackageUninstall.Items.Clear();

			cbx_InstallUninstallPackageUninstall.Enabled = false;

			var output = HelperClass.ExecuteWithOutput("adb shell pm list packages -3");

			if (!string.IsNullOrEmpty(output))
			{
				foreach (var item in output.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
				{
					cbx_InstallUninstallPackageUninstall.Items.Add(item.Remove(0, 8));
				}

				cbx_InstallUninstallPackageUninstall.Sorted = true;

				if (cbx_InstallUninstallPackageUninstall.Items.Count > 0)
				{
					cbx_InstallUninstallPackageUninstall.SelectedIndex = 0;
				}
			}

			cbx_InstallUninstallPackageUninstall.Enabled = true;
		}

		private void InstallUninstall_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

		private void InstallUninstall_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = ((string[])e.Data.GetData(DataFormats.FileDrop));
			txt_InstallUninstallPackageInstall.Text = files[0];
		}
	}
}