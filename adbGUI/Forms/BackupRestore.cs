using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class BackupRestore : Form
    {
        // todo backup restore testen

        private AdbOps adb;
        private FormMethods formMethods;

        public BackupRestore(AdbOps adbFrm, FormMethods formMethodsFrm)
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
            var package = txt_BackupPackageName.Text;

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

                    adb.StartProcessing("backup" + apk + shared + all + system + name, formMethods.SelectedDevice());
                }
            }
            else
            {
                if (txt_BackupPathTo.Text == "")
                {
                    MessageBox.Show("Please select a destination!", "Error", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                }
                else
                {
                    adb.StartProcessing("backup -apk " + package + name, formMethods.SelectedDevice());
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
                txt_BackupPackageName.Visible = true;
                label8.Visible = true;
            }
            else
            {
                cbo_BackupNoSystem.Enabled = true;
                cbo_BackupShared.Enabled = true;
                cbo_BackupWithApk.Enabled = true;
                txt_BackupPackageName.Visible = false;
                txt_BackupPackageName.Text = "";
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
                adb.StartProcessing("restore \"" + txt_RestorePath.Text + "\"", formMethods.SelectedDevice());
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