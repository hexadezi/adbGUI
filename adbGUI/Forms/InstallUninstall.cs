using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class InstallUninstall : Form
    {
        private AdbOps adb;
        private FormMethods formMethods;

        public InstallUninstall(AdbOps adbFrm, FormMethods formMethodsFrm)
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
                adb.StartProcessing("install " + s, formMethods.SelectedDevice());

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

            adb.StartProcessing("uninstall " + s, formMethods.SelectedDevice());

            RefreshInstalledApps();
        }

        private void Btn_InstallUninstallRefreshApps_Click(object sender, EventArgs e)
        {
            RefreshInstalledApps();
        }

        private void RefreshInstalledApps()
        {
            cbx_InstallUninstallPackageUninstall.Items.Clear();

            cbx_InstallUninstallPackageUninstall.Enabled = false;

            string output = adb.StartProcessingInThread("shell \"pm list packages -3 | cut -c9- | sort\"", formMethods.SelectedDevice());

            foreach (var item in output.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                cbx_InstallUninstallPackageUninstall.Items.Add(item);
            }

            if (cbx_InstallUninstallPackageUninstall.Items.Count > 0)
            {
                cbx_InstallUninstallPackageUninstall.SelectedIndex = 0;
            }

            cbx_InstallUninstallPackageUninstall.Enabled = true;
        }
    }
}