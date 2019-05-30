// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
    using Methods;
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    public partial class BackupRestore : Form
    {
        // todo backup restore testen

        private readonly CmdProcess _adb;
        private readonly FormMethods _formMethods;

        public BackupRestore(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();

            _adb = adbFrm;
            _formMethods = formMethodsFrm;
        }

        private void Btn_BackupBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "backup_" + DateTime.Now.ToString(CultureInfo.InvariantCulture).Replace(' ', '_')
                                          .Replace(':', '.');
            saveFileDialog.Filter = @" .ab|*.ab";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) txt_BackupPathTo.Text = saveFileDialog.FileName;
        }

        private void Btn_BackupStart_Click(object sender, EventArgs e)
        {
            var name = " -f \"" + txt_BackupPathTo.Text + "\"";
            var apk = " -noapk";
            var shared = " -noshared";
            const string all = " -all";
            var system = " -system";

            if (!cbo_BackupPackage.Checked)
            {
                if (txt_BackupPathTo.Text?.Length == 0)
                {
                    MessageBox.Show(@"Please select a destination!", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (cbo_BackupWithApk.Checked) apk = " -apk";
                    if (cbo_BackupShared.Checked) shared = " -shared";
                    if (cbo_BackupNoSystem.Checked) system = " -nosystem";

                    _adb.StartProcessing("adb backup" + apk + shared + all + system + name,
                        _formMethods.SelectedDevice());
                }
            }
            else
            {
                var package = cbx_BackupPackage.SelectedItem.ToString();

                if (txt_BackupPathTo.Text?.Length == 0)
                {
                    MessageBox.Show(@"Please select a destination!", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    _adb.StartProcessing("adb backup -apk " + package + name, _formMethods.SelectedDevice());
                }
            }
        }

        private void Btn_RestoreBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = @" .ab|*.ab";

            if (openFileDialog.ShowDialog() == DialogResult.OK) txt_RestorePath.Text = openFileDialog.FileName;
        }

        private void Btn_RestoreStart_Click(object sender, EventArgs e)
        {
            if (txt_RestorePath.Text?.Length == 0)
            {
                MessageBox.Show(@"Please select a file!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _adb.StartProcessing("adb restore \"" + txt_RestorePath.Text + "\"", _formMethods.SelectedDevice());
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

                var output =
                    CmdProcess.StartProcessingInThread("adb shell pm list packages -3", _formMethods.SelectedDevice());

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
    }
}