using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class InstallUninstall : Form
    {
        private CmdProcess adb;
        private FormMethods formMethods;

        public InstallUninstall(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();

            adb = adbFrm;
            formMethods = formMethodsFrm;
        }

        private void Btn_InstallUninstallInstall_Click(object sender, EventArgs e)
        {
            var s = "\"" + txt_InstallUninstallPackageInstall.Text + "\"";
            string serial = " -s " + formMethods.SelectedDevice();

            if (txt_InstallUninstallPackageInstall.Text != "")
            {
                adb.StartProcessing("adb install " + s, formMethods.SelectedDevice());

                RefreshInstalledApps();
            }
            else
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_InstallUninstallBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = " .apk|*.apk";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_InstallUninstallPackageInstall.Text = openFileDialog.FileName;
            }
        }

        private void Btn_InstallUninstallUninstall_Click(object sender, EventArgs e)
        {
            var s = "\"" + cbx_InstallUninstallPackageUninstall.SelectedItem + "\"";

            adb.StartProcessing("adb uninstall " + s, formMethods.SelectedDevice());

            RefreshInstalledApps();
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

            string output = adb.StartProcessingInThread("adb shell \"pm list packages -3", formMethods.SelectedDevice());

            foreach (var item in output.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                cbx_InstallUninstallPackageUninstall.Items.Add(item.Remove(0,8));
            }

            cbx_InstallUninstallPackageUninstall.Sorted = true;

            if (cbx_InstallUninstallPackageUninstall.Items.Count > 0)
            {
                cbx_InstallUninstallPackageUninstall.SelectedIndex = 0;
            }

            cbx_InstallUninstallPackageUninstall.Enabled = true;
        }
    }
}