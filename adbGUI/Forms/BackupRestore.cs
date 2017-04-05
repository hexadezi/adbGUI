using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class BackupRestore : Form
    {
        // todo backup restore testen

        private CmdProcess adb;
        private FormMethods formMethods;

        public BackupRestore(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();

            adb = adbFrm;
            formMethods = formMethodsFrm;
        }

        private void Btn_BackupBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "backup_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '.');
            saveFileDialog.Filter = " .ab|*.ab";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_BackupPathTo.Text = saveFileDialog.FileName;
            }
        }

        private void Btn_BackupStart_Click(object sender, EventArgs e)
        {
            var name = " -f \"" + txt_BackupPathTo.Text + "\"";
            var apk = " -noapk";
            var shared = " -noshared";
            var all = " -all";
            var system = " -system";


            if (cbo_BackupPackage.Checked == false)
            {
                if (txt_BackupPathTo.Text == "")
                {
                    MessageBox.Show("Please select a destination!", "Error", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                }
                else
                {
                    if (cbo_BackupWithApk.Checked)
                    {
                        apk = " -apk";
                    }
                    if (cbo_BackupShared.Checked)
                    {
                        shared = " -shared";
                    }
                    if (cbo_BackupNoSystem.Checked)
                    {
                        system = " -nosystem";
                    }

                    adb.StartProcessing("adb backup" + apk + shared + all + system + name, formMethods.SelectedDevice());
                }
            }
            else
            {
                var package = cbx_BackupPackage.SelectedItem.ToString();

                if (txt_BackupPathTo.Text == "")
                {
                    MessageBox.Show("Please select a destination!", "Error", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                }
                else
                {
                    adb.StartProcessing("adb backup -apk " + package + name, formMethods.SelectedDevice());
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

                string output = adb.StartProcessingInThread("adb shell pm list packages -3", formMethods.SelectedDevice());

                if (!String.IsNullOrEmpty(output))
                {
                    foreach (var item in output.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        cbx_BackupPackage.Items.Add(item.Remove(0, 8));
                    }

                    cbx_BackupPackage.Sorted = true;

                    if (cbx_BackupPackage.Items.Count > 0)
                    {
                        cbx_BackupPackage.SelectedIndex = 0;
                    }
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
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                adb.StartProcessing("adb restore \"" + txt_RestorePath.Text + "\"", formMethods.SelectedDevice());
            }
        }

        private void Btn_RestoreBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = " .ab|*.ab";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_RestorePath.Text = openFileDialog.FileName;
            }
        }

    }
}
