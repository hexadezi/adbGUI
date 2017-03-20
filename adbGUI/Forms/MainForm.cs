using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text;

namespace adbGUI
{
    public partial class MainForm : Form
    {
        public FormMethods formMethods;

        AdbOps adb = new AdbOps();
        StringBuilder builder = new StringBuilder();
        string devicesOldString = "";

        public MainForm()
        {

            InitializeComponent();
            DoubleBuffered = true;

            adb.GetProcess.OutputDataReceived -= Display;
            adb.GetProcess.OutputDataReceived += Display;


            //
            //
            //
            //
            //
            //
            // Error in rot formatieren
            adb.GetProcess.ErrorDataReceived -= Display;
            adb.GetProcess.ErrorDataReceived += Display;

            formMethods = new FormMethods(this);

            txt_customCommand.Select();

        }

        //Eventhandler
        void Display(object sender, DataReceivedEventArgs e)
        {
            builder.AppendLine(e.Data);
        }

        //Exit with escape
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            Close();
            return true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"tools\adb.exe") && File.Exists(@"tools\AdbWinApi.dll") && File.Exists(@"tools\AdbWinUsbApi.dll"))
            {
                trv_commandTreeView.ExpandAll();
                trv_commandTreeView.SelectedNode = trv_commandTreeView.Nodes[0];
            }
            else
            {
                //todo Wenn Dateien fehlen, Exception. Behandeln.
                MessageBox.Show("Missing files. Make soure adbGUI.exe, AdbWinApi.dll adn AdbWinUsbApi.dll are in the tools folder.", "Error - Missing files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string devicesRefreshedString = adb.StartProcessingInThread("devices -l", "");

            if (!devicesOldString.Equals(devicesRefreshedString))
            {
                Cursor.Current = Cursors.WaitCursor;
                txt_devices.Text = devicesRefreshedString;
                devicesOldString = devicesRefreshedString;
                formMethods.refreshSerialsInCombobox(formMethods.parseDevicesL(devicesRefreshedString));
                Cursor.Current = Cursors.Default;
            }

            try
            {
                if (builder.Length > 1)
                {
                    //todo Leerzeilen im Galaxy entfernen
                    rtb_console.AppendText(builder.ToString());
                    builder.Clear();
                }

            }
            catch (Exception)
            {
            }

        }

        private void btn_killServer_Click(object sender, EventArgs e)
        {
            formMethods.killServer();
        }

        private void btn_reboot_Click(object sender, EventArgs e)
        {
            PowerMenu powerMenu = new PowerMenu(this);

            powerMenu.ShowDialog();
        }

        private void btn_push_openfile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = " "; //This is not a normal whitespace. ALT + 255
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ValidateNames = false;
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (openFileDialog.SafeFileName == " ") //This is not a normal whitespace. ALT + 255
                {
                    txt_pushFilePathTo.Text =
                          openFileDialog.FileName.Remove(openFileDialog.FileName.Length - 2, 2);
                }
                else
                {
                    txt_pushFilePathTo.Text = openFileDialog.FileName;
                }
            }
        }

        private void btn_pushFile_Click(object sender, EventArgs e)
        {
            if (txt_pushFilePathTo.Text == "" || txt_pushFilePathFrom.Text == "")
            {
                MessageBox.Show("Please select a file and chose destination!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var s = "push \"" + txt_pushFilePathTo.Text + "\"" + " \"" + txt_pushFilePathFrom.Text + "\"";
                adb.StartProcessing(s, formMethods.selectedDevice());
            }
        }

        private void btn_executeCommand_Click(object sender, EventArgs e)
        {
            var s = txt_customCommand.Text;
            if (s == "")
            {
                MessageBox.Show("Please enter a command!", "Error");
            }
            else
            {
                adb.StartProcessing(txt_customCommand.Text.ToString(), formMethods.selectedDevice());
            }
        }

        private void btn_openShell_Click(object sender, EventArgs e)
        {
            //StandardIO.AdbCMD("shell", " -s " + formMethods.selectedDevice());
            //todo Implementierung
        }

        private void btn_showMac_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell su root cat /sys/class/net/wlan0/address", formMethods.selectedDevice());
        }

        private void btn_setNewMac_Click(object sender, EventArgs e)
        {
            var s = txt_phoneMacAdress.Text;

            var r = new Regex(@"(([a-f]|[0-9]|[A-F]){2}\:){5}([a-f]|[0-9]|[A-F]){2}\b");

            if (r.Match(s).Success)
            {
                adb.StartProcessing("shell su root ifconfig wlan0 hw ether " + r, formMethods.selectedDevice());
            }
            else
            {
                MessageBox.Show("Please enter a valid MAC address", "Error");
            }
        }

        private void btn_packagesOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = " .apk|*.apk";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_packageFilePathTo.Text = openFileDialog.FileName;
            }
        }

        private void btn_installPackage_Click_1(object sender, EventArgs e)
        {
            var s = "\"" + txt_packageFilePathTo.Text + "\"";
            string serial = " -s " + formMethods.selectedDevice();

            if (txt_packageFilePathTo.Text != "")
            {

                adb.StartProcessing("install " + s, formMethods.selectedDevice());

                formMethods.refreshInstalledAppsInCombobox();

            }
            else
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_uninstallPackage_Click(object sender, EventArgs e)
        {
            var s = "\"" + cbx_installedApps.SelectedItem + "\"";

            adb.StartProcessing("uninstall " + s, formMethods.selectedDevice());

            formMethods.refreshInstalledAppsInCombobox();

        }

        private void btn_pullFile_Click(object sender, EventArgs e)
        {
            if (txt_pullFilePathTo.Text == "" || txt_pullFilePathFrom.Text == "")
            {
                MessageBox.Show("Please select a file and chose destination!", "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
            else
            {
                var s = "pull \"" + txt_pullFilePathFrom.Text + "\"" + " \"" + txt_pullFilePathTo.Text + "\"";
                adb.StartProcessing(s, formMethods.selectedDevice());
            }
        }

        private void btn_pullfolderBrowserDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Where should the file be saved?";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_pullFilePathTo.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btn_startBackup_Click(object sender, EventArgs e)
        {
            var name = " -f \"" + txt_backupFilePathTo.Text + "\"";
            var apk = " -noapk";
            var shared = " -noshared";
            var all = " -all";
            var system = " -system";
            var package = txt_backup_packagename.Text;


            if (cbo_backupPackage.Checked == false)
            {
                if (txt_backupFilePathTo.Text == "")
                {
                    MessageBox.Show("Please select a destination!", "Error", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                }
                else
                {
                    if (cb_backup_withapk.Checked)
                    {
                        apk = " -apk";
                    }
                    if (cb_backup_shared.Checked)
                    {
                        shared = " -shared";
                    }
                    if (cb_backup_nosystem.Checked)
                    {
                        system = " -nosystem";
                    }

                    adb.StartProcessing("backup" + apk + shared + all + system + name, formMethods.selectedDevice());

                }

            }
            else
            {
                if (txt_backupFilePathTo.Text == "")
                {
                    MessageBox.Show("Please select a destination!", "Error", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                }
                else
                {
                    adb.StartProcessing("backup -apk " + package + name, formMethods.selectedDevice());
                }
            }
        }

        private void btn_backupSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "backup_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '.');
            saveFileDialog.Filter = " .ab|*.ab";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_backupFilePathTo.Text = saveFileDialog.FileName;
            }
        }

        private void btn_restoreOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = " .ab|*.ab";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_restore_path.Text = openFileDialog.FileName;
            }
        }

        private void btn_restoreBackup_Click(object sender, EventArgs e)
        {
            if (txt_restore_path.Text == "")
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                adb.StartProcessing("restore \"" + txt_restore_path.Text + "\"", formMethods.selectedDevice());
            }
        }

        private void btn_showDpi_show_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm density", formMethods.selectedDevice());
        }

        private void btn_resetSpoofedMac_Click(object sender, EventArgs e)
        {
            string serial = formMethods.selectedDevice();

            adb.StartProcessing("shell su root ifconfig wlan0 down", formMethods.selectedDevice());
            adb.StartProcessing("shell su root ifconfig wlan0 up", formMethods.selectedDevice());

            //todo Beide Befehle eventuelll zusammenführen
        }

        private void btn_consoleStop_Click(object sender, EventArgs e)
        {
            adb.StopProcessing();
        }

        private void btn_consoleClear_Click(object sender, EventArgs e)
        {
            rtb_console.Clear();
        }

        private void btn_refreshInstalledApps_Click(object sender, EventArgs e)
        {
            formMethods.refreshInstalledAppsInCombobox();
        }

        private void btn_sideloadOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = @" .zip|*.zip";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_sideload_path.Text = openFileDialog.FileName;
            }
        }

        private void btn_setDpi_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm density " + txt_phoneDpi.Text, formMethods.selectedDevice());
        }

        private void btn_resetDpi_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm density reset", formMethods.selectedDevice());
        }

        private void btn_remountSystemClick(object sender, EventArgs e)
        {
            adb.StartProcessing("remount", formMethods.selectedDevice());
        }

        private void btn_connectWirelessDevice_Click(object sender, EventArgs e)
        {

            var r = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");

            string ipadress = txt_wirelessDeviceIp.Text;

            if (r.Match(ipadress).Success)
            {
                adb.StartProcessing("connect " + ipadress, formMethods.selectedDevice());
            }
            else
            {
                MessageBox.Show("Please enter a valid IP adress", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_setResolution_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size " + txt_phoneResolution.Text, formMethods.selectedDevice());
        }

        private void btn_showResolution_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size", formMethods.selectedDevice());
        }

        private void btn_resetResolution_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size reset", formMethods.selectedDevice());

        }

        private void btn_disconnectWirelessDevices_Click_1(object sender, EventArgs e)
        {
            adb.StartProcessing("disconnect", "");
        }

        private void btn_listPushDestination_Click(Object sender, EventArgs e)
        {
            string path = txt_pushFilePathFrom.Text;
            adb.StartProcessing("shell ls -la \"" + path + "\" -F", formMethods.selectedDevice());
        }

        private void btn_listPullDestination_Click(Object sender, EventArgs e)
        {
            string path = txt_pullFilePathFrom.Text;
            adb.StartProcessing("shell ls -la \"" + path + "\" -F", formMethods.selectedDevice());
        }

        private void trv_commandTreeView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string tag;

                if ((tag = trv_commandTreeView.SelectedNode.Tag.ToString()) != null)
                {
                    adb.StartProcessing(trv_commandTreeView.SelectedNode.Tag.ToString(), formMethods.selectedDevice());
                }

            }
            catch (Exception) { }
        }

        private void txt_phoneResolution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_setResolution.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_phoneDpi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_setDpi.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_wirelessDeviceIp_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                btn_connectWirelessDevice.PerformClick();
                e.SuppressKeyPress = true;

            }
        }

        private void txt_customCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_executeCommand.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_pushFilePathFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_pushFile.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_phoneMacAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_setNewMac.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_pullFilePathFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_pullFile.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cbo_backupPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbo_backupPackage.Checked)
            {
                cb_backup_nosystem.Enabled = false;
                cb_backup_nosystem.Checked = false;
                cb_backup_shared.Enabled = false;
                cb_backup_shared.Checked = false;
                cb_backup_withapk.Enabled = false;
                cb_backup_withapk.Checked = false;
                label8.Visible = true;
                txt_backup_packagename.Visible = true;

            }
            else
            {
                cb_backup_nosystem.Enabled = true;
                cb_backup_shared.Enabled = true;
                label8.Visible = false;
                txt_backup_packagename.Visible = false;
                cb_backup_withapk.Enabled = true;
                txt_backup_packagename.Text = "";
            }
        }

        private void cbx_connectedDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            formMethods.refreshInstalledAppsInCombobox();
        }

        private void btn_sideloadFile_Click(object sender, EventArgs e)
        {
            if (txt_sideload_path.Text != "")
            {
                var s = "sideload \"" + txt_sideload_path.Text + "\"";
                adb.StartProcessing(s, formMethods.selectedDevice());
            }
            else
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //todo controls richtig benennen

    }
}