﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
	using System;
	using System.Globalization;
	using System.Windows.Forms;
	using Methods;

	public partial class BackupRestore : ExtForm
	{
		// todo backup restore testen

		public BackupRestore()
		{
			InitializeComponent();
		}

		private void Btn_BackupBrowse_Click(object sender, EventArgs e)
		{
			saveFileDialog.FileName = "backup_" + DateTime.Now.ToString(@"ddMMyyyy_HHmmss");
			saveFileDialog.Filter = @" .ab|*.ab";

			if (saveFileDialog.ShowDialog() == DialogResult.OK) txt_BackupPathTo.Text = saveFileDialog.FileName;
		}

		private void Btn_BackupStart_Click(object sender, EventArgs e)
		{
			var name = " -f \"" + txt_BackupPathTo.Text + "\"";
			var apk = " -noapk";
			var shared = " -noshared";
                        var obb = " -noobb";
                        var keyvalue = " -nokeyvalue";
			const string all = " -all";
			var system = " -system";


			if (cbo_BackupPackage.Checked)
			{
				if (cbx_BackupPackage.SelectedItem != null)
				{
					string package = cbx_BackupPackage.SelectedItem.ToString();

					if (txt_BackupPathTo.Text == "")
						MessageBox.Show(@"Please select a destination!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else
						HelperClass.Execute("adb backup -apk " + package + name);
				}
			}
			else
			{

				if (txt_BackupPathTo.Text == "")
				{
					MessageBox.Show(@"Please select a destination!", @"Error", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
				else
				{
					if (cbo_BackupWithApk.Checked) apk = " -apk";
					if (cbo_BackupShared.Checked) shared = " -shared";
					if (cbo_BackupNoSystem.Checked) system = " -nosystem";

					HelperClass.Execute("adb backup" + apk + shared + all + system + name);
				}
			}
		}

		private void Cbo_BackupPackage_CheckedChanged(object sender, EventArgs e)
		{
			if (cbo_BackupPackage.Checked)
			{
				cbo_BackupNoSystem.Enabled = false;
				cbo_BackupNoSystem.Checked = false;
				cbo_BackupShared.Enabled = false;
				cbo_BackupShared.Checked = false;
				cbo_BackupWithApk.Enabled = false;
				cbo_BackupWithApk.Checked = false;
				cbx_BackupPackage.Visible = true;
				label8.Visible = true;

				groupBox8.Enabled = false;
				groupBox14.Enabled = false;

				var output = HelperClass.ExecuteWithOutput("adb", "shell pm list packages -3");

				if (!string.IsNullOrEmpty(output))
				{
					foreach (var item in output.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
						cbx_BackupPackage.Items.Add(item.Remove(0, 8));

					cbx_BackupPackage.Sorted = true;

					if (cbx_BackupPackage.Items.Count > 0) cbx_BackupPackage.SelectedIndex = 0;
				}

				groupBox8.Enabled = true;
				groupBox14.Enabled = true;
			}
			else
			{
				cbo_BackupNoSystem.Enabled = true;
				cbo_BackupShared.Enabled = true;
				cbo_BackupWithApk.Enabled = true;
				cbx_BackupPackage.Visible = false;
				cbx_BackupPackage.Items.Clear();
				label8.Visible = false;
			}
		}

		private void Btn_RestoreStart_Click(object sender, EventArgs e)
		{
			if (txt_RestorePath.Text == "")
				MessageBox.Show(@"Please select a file!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				HelperClass.Execute("adb restore \"" + txt_RestorePath.Text + "\"");
		}

		private void Btn_RestoreBrowse_Click(object sender, EventArgs e)
		{
			openFileDialog.FileName = "";
			openFileDialog.Filter = @" .ab|*.ab";

			if (openFileDialog.ShowDialog() == DialogResult.OK) txt_RestorePath.Text = openFileDialog.FileName;
		}
	}
}
