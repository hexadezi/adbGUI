using adbGUI.Forms;
using adbGUI.Methods;
using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace adbGUI
{
    public partial class MainForm : Form
    {
        private ScreenRecord screenRecord;
        private SpoofMac spoofMac;
        private ResolutionChange resolutionChange;
        private DpiChange dpiChange;
        private FileOps fileOps;
        private InstallUninstall installUninstall;

        public FormMethods formMethods;

        private AdbOps adb = new AdbOps();
        private DeviceWatcher dw = new DeviceWatcher();
        private StringBuilder builder = new StringBuilder();

        public MainForm()
        {
            // todo aapt implementieren

            InitializeComponent();

            // pass formMethods the created Form this
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

        private void Btn_killServer_Click(object sender, EventArgs e)
        {
            formMethods.KillServer();
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

        private void Btn_remountSystemClick(object sender, EventArgs e)
        {
            adb.StartProcessing("remount", formMethods.SelectedDevice());
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

        private void AppendReceivedData(object sender, DataReceivedEventArgs e)
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

                            case "#spoofmac":
                                if (spoofMac == null || spoofMac.IsDisposed)
                                {
                                    spoofMac = new SpoofMac(adb, formMethods);
                                    spoofMac.Show();
                                }
                                else
                                {
                                    spoofMac.Focus();
                                }
                                break;

                            case "#resolution":
                                if (resolutionChange == null || resolutionChange.IsDisposed)
                                {
                                    resolutionChange = new ResolutionChange(adb, formMethods);
                                    resolutionChange.Show();
                                }
                                else
                                {
                                    resolutionChange.Focus();
                                }
                                break;

                            case "#density":
                                if (dpiChange == null || dpiChange.IsDisposed)
                                {
                                    dpiChange = new DpiChange(adb, formMethods);
                                    dpiChange.Show();
                                }
                                else
                                {
                                    dpiChange.Focus();
                                }
                                break;

                            case "#files":
                                if (fileOps == null || fileOps.IsDisposed)
                                {
                                    fileOps = new FileOps(adb, formMethods);
                                    fileOps.Show();
                                }
                                else
                                {
                                    fileOps.Focus();
                                }
                                break;

                            case "#installuninstall":
                                if (installUninstall == null || installUninstall.IsDisposed)
                                {
                                    installUninstall = new InstallUninstall(adb, formMethods);
                                    installUninstall.Show();
                                }
                                else
                                {
                                    installUninstall.Focus();
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
            if (keyData == Keys.Escape)
            {
                adb.StopProcessing();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}