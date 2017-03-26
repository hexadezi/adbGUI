using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.Management;
using adbGUI.Methods;
using System.Runtime.InteropServices;
using adbGUI.Forms;

namespace adbGUI
{
    public partial class MainForm : Form
    {
        private ScreenRecord screenRecord;

        public FormMethods formMethods;


        AdbOps adb = new AdbOps();
        DeviceWatcher dw = new DeviceWatcher();
        StringBuilder builder = new StringBuilder();

        public MainForm()
        {

            // todo aapt implementieren

            InitializeComponent();

            // pass the formMethods the created Form
            formMethods = new FormMethods(this);

            adb.GetProcess.Start();

            // Begin and cancel so the RichTextBox will stay clean. Otherwise it will start in line 2.
            adb.GetProcess.BeginOutputReadLine();
            adb.GetProcess.CancelOutputRead();

            adb.GetProcess.OutputDataReceived += AppendReceivedData;
            adb.GetProcess.ErrorDataReceived += AppendReceivedData;

            Thread.Sleep(100);

            adb.GetProcess.BeginOutputReadLine();
            adb.GetProcess.BeginErrorReadLine();


            adb.CommandExecutionStarted += Adb_CommandExecutionStarted;
            adb.CommandExecutionStopped += formMethods.ShowMboxAborted;
            // Select custom command control
            cbx_customCommand.Select();

            // Start the watcher which fires if devices changed
            dw.DeviceChanged += Dw_DeviceChanged;
            dw.StartDeviceWatcher();

        }

        private void Adb_CommandExecutionStarted()
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                if (cbo_clearEverytime.Checked)
                {
                    rtb_console.Clear();
                }
            });
        }

        private void Dw_DeviceChanged(DeviceWatcher dw, DevicesList e)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {

                formMethods.RefreshSerialsInCombobox(e.DeviceList);
                txt_devices.Text = e.DevicesRaw.ToUpper();

            });
        }

        private void Btn_backupSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "backup_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '.');
            saveFileDialog.Filter = " .ab|*.ab";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_backupFilePathTo.Text = saveFileDialog.FileName;
            }
        }

        private void Btn_connectWirelessDevice_Click(object sender, EventArgs e)
        {

            var r = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");

            string ipadress = txt_wirelessDeviceIp.Text;

            if (r.Match(ipadress).Success)
            {
                adb.StartProcessing("connect " + ipadress, "");
            }
            else
            {
                MessageBox.Show("Please enter a valid IP adress", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_consoleClear_Click(object sender, EventArgs e)
        {
            rtb_console.Clear();
        }

        private void Btn_consoleStop_Click(object sender, EventArgs e)
        {
            adb.StopProcessing();
        }

        private void Btn_disconnectWirelessDevices_Click_1(object sender, EventArgs e)
        {
            adb.StartProcessing("disconnect", "");
        }

        private void Btn_executeCommand_Click(object sender, EventArgs e)
        {
            string command = cbx_customCommand.Text;

            if (!String.IsNullOrEmpty(command))
            {
                cbx_customCommand.Items.Add(command);

                adb.StartProcessing(command, formMethods.SelectedDevice());
            }
            else
            {
                MessageBox.Show("Please enter a command!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_installPackage_Click_1(object sender, EventArgs e)
        {
            var s = "\"" + txt_packageFilePathTo.Text + "\"";
            string serial = " -s " + formMethods.SelectedDevice();

            if (txt_packageFilePathTo.Text != "")
            {

                adb.StartProcessing("install " + s, formMethods.SelectedDevice());

                formMethods.RefreshInstalledAppsInCombobox();

            }
            else
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_killServer_Click(object sender, EventArgs e)
        {
            formMethods.KillServer();
        }

        private void Btn_listPullDestination_Click(Object sender, EventArgs e)
        {
            string path = txt_pullFilePathFrom.Text;
            adb.StartProcessing("shell ls -la \"" + path + "\" -F", formMethods.SelectedDevice());
        }

        private void Btn_listPushDestination_Click(Object sender, EventArgs e)
        {
            string path = txt_pushFilePathFrom.Text;
            adb.StartProcessing("shell ls -la \"" + path + "\" -F", formMethods.SelectedDevice());
        }

        private void Btn_openShell_Click(object sender, EventArgs e)
        {

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"tools\adb",
                    Arguments = "shell",
                }
            };

            process.Start();
        }

        private void Btn_packagesOpenFileDialog_Click(object sender, EventArgs e)
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

        private void Btn_pullFile_Click(object sender, EventArgs e)
        {
            if (txt_pullFilePathTo.Text == "" || txt_pullFilePathFrom.Text == "")
            {
                MessageBox.Show("Please select a file and chose destination!", "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
            else
            {
                var s = "pull \"" + txt_pullFilePathFrom.Text + "\"" + " \"" + txt_pullFilePathTo.Text + "\"";
                adb.StartProcessing(s, formMethods.SelectedDevice());
            }
        }

        private void Btn_pullfolderBrowserDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Where should the file be saved?";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_pullFilePathTo.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Btn_push_openfile_Click(object sender, EventArgs e)
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

        private void Btn_pushFile_Click(object sender, EventArgs e)
        {
            if (txt_pushFilePathTo.Text == "" || txt_pushFilePathFrom.Text == "")
            {
                MessageBox.Show("Please select a file and chose destination!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var s = "push \"" + txt_pushFilePathTo.Text + "\"" + " \"" + txt_pushFilePathFrom.Text + "\"";
                adb.StartProcessing(s, formMethods.SelectedDevice());
            }
        }

        private void Btn_refreshInstalledApps_Click(object sender, EventArgs e)
        {
            formMethods.RefreshInstalledAppsInCombobox();
        }

        private void Btn_remountSystemClick(object sender, EventArgs e)
        {
            adb.StartProcessing("remount", formMethods.SelectedDevice());
        }

        private void Btn_resetDpi_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm density reset", formMethods.SelectedDevice());
        }

        private void Btn_resetResolution_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size reset", formMethods.SelectedDevice());

        }

        private void Btn_resetSpoofedMac_Click(object sender, EventArgs e)
        {
            string serial = formMethods.SelectedDevice();

            adb.StartProcessing("shell su root ifconfig wlan0 down", formMethods.SelectedDevice());
            //adb.StartProcessing("shell su root ifconfig wlan0 up", formMethods.SelectedDevice());

            //todo Beide Befehle eventuelll zusammenführen
        }

        private void Btn_restoreBackup_Click(object sender, EventArgs e)
        {
            if (txt_restore_path.Text == "")
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                adb.StartProcessing("restore \"" + txt_restore_path.Text + "\"", formMethods.SelectedDevice());
            }
        }

        private void Btn_restoreOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = " .ab|*.ab";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_restore_path.Text = openFileDialog.FileName;
            }
        }

        private void Btn_setDpi_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm density " + txt_phoneDpi.Text, formMethods.SelectedDevice());
        }

        private void Btn_setNewMac_Click(object sender, EventArgs e)
        {
            var s = txt_phoneMacAdress.Text;

            var r = new Regex(@"(([a-f]|[0-9]|[A-F]){2}\:){5}([a-f]|[0-9]|[A-F]){2}\b");

            if (r.Match(s).Success)
            {
                adb.StartProcessing("shell su root ifconfig wlan0 hw ether " + s, formMethods.SelectedDevice());
            }
            else
            {
                MessageBox.Show("Please enter a valid MAC address", "Error");
            }
        }

        private void Btn_setResolution_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size " + txt_phoneResolution.Text, formMethods.SelectedDevice());
        }

        private void Btn_showDpi_show_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm density", formMethods.SelectedDevice());
        }

        private void Btn_showMac_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell su root cat /sys/class/net/wlan0/address", formMethods.SelectedDevice());
        }

        private void Btn_showResolution_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size", formMethods.SelectedDevice());
        }

        private void Btn_sideloadFile_Click(object sender, EventArgs e)
        {
            if (txt_sideload_path.Text != "")
            {
                var s = "sideload \"" + txt_sideload_path.Text + "\"";
                adb.StartProcessing(s, formMethods.SelectedDevice());
            }
            else
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_sideloadOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = @" .zip|*.zip";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_sideload_path.Text = openFileDialog.FileName;
            }
        }

        private void Btn_startBackup_Click(object sender, EventArgs e)
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

                    adb.StartProcessing("backup" + apk + shared + all + system + name, formMethods.SelectedDevice());

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
                    adb.StartProcessing("backup -apk " + package + name, formMethods.SelectedDevice());
                }
            }
        }

        private void Btn_uninstallPackage_Click(object sender, EventArgs e)
        {
            var s = "\"" + cbx_installedApps.SelectedItem + "\"";

            adb.StartProcessing("uninstall " + s, formMethods.SelectedDevice());

            formMethods.RefreshInstalledAppsInCombobox();

        }

        private void Cbo_backupPackage_CheckedChanged(object sender, EventArgs e)
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

        private void Cbx_connectedDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            formMethods.RefreshInstalledAppsInCombobox();
        }

        void AppendReceivedData(object sender, DataReceivedEventArgs e)
        {
            builder.AppendLine(e.Data);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            trv_commandTreeView.ExpandAll();
            trv_commandTreeView.SelectedNode = trv_commandTreeView.Nodes[0];
        }


        private void Rtb_console_Resize(object sender, EventArgs e)
        {
            rtb_console.ScrollToCaret();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ProcessTick();
        }

        private void ProcessTick()
        {
            try
            {

                rtb_console.AppendText(builder.ToString());


                builder.Clear();
            }
            catch (Exception)
            { }
        }

        private void Trv_commandTreeView_DoubleClick(object sender, EventArgs e)
        {
            // todo add network capture tcpdump
            try
            {
                string tag;

                if ((tag = trv_commandTreeView.SelectedNode.Tag.ToString()) != null)
                {
                    if (tag.StartsWith("#"))
                    {
                        switch (tag)
                        {
                            case "#prop":
                                new SetProp(adb, formMethods).Show();
                                break;


                            case "#screenrecord":
                                if (screenRecord == null || screenRecord.IsDisposed)
                                {
                                    screenRecord = new ScreenRecord(adb, formMethods);
                                    screenRecord.Show();
                                }
                                else
                                {
                                    screenRecord.Focus();
                                }
                                break;
                        }
                    }
                    else
                    {
                        adb.StartProcessing(tag, formMethods.SelectedDevice());
                    }

                }

            }
            catch (Exception) { }
        }

        private void Txt_customCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_executeCommand.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Txt_phoneDpi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_setDpi.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Txt_phoneMacAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_setNewMac.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Txt_phoneResolution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_setResolution.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void Txt_pullFilePathFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_pullFile.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Txt_pushFilePathFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_pushFile.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Txt_wirelessDeviceIp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_connectWirelessDevice.PerformClick();
                e.SuppressKeyPress = true;

            }
        }

        private void Btn_adbRoot_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("root", formMethods.SelectedDevice());
        }

        private void Btn_adbUnroot_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("unroot", formMethods.SelectedDevice());
        }

        private void Cbx_customCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_executeCommand.PerformClick();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            // Kill the process
            // todo rename Forms
            try
            {
                //adb.StopProcessing();
                adb.GetProcess.Kill();
                adb.GetProcess.Dispose();

            }
            catch (Exception)
            { }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            adb.StopProcessing();
            return true;
        }
    }
}