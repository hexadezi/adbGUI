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
        private Sideload sideLoad;
        private BackupRestore backupRestore;

        public FormMethods formMethods;

        private AdbOps adb = new AdbOps();
        private FastbootOps fastboot = new FastbootOps();

        private DeviceWatcherAdb dwAdb = new DeviceWatcherAdb();
        private DeviceWatcherFastboot dwFastboot = new DeviceWatcherFastboot();

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







            fastboot.GetProcess.Start();

            // Begin and cancel so the RichTextBox will stay clean. Otherwise it will start in line 2.
            fastboot.GetProcess.BeginOutputReadLine();
            fastboot.GetProcess.CancelOutputRead();

            fastboot.GetProcess.OutputDataReceived += AppendReceivedData;
            fastboot.GetProcess.ErrorDataReceived += AppendReceivedData;

            Thread.Sleep(100);

            fastboot.GetProcess.BeginOutputReadLine();
            fastboot.GetProcess.BeginErrorReadLine();

            // todo fix
            fastboot.CommandExecutionStarted += Adb_CommandExecutionStarted;
            fastboot.CommandExecutionStopped += formMethods.ShowMboxAborted;







            // Select custom command control
            cbx_customCommand.Select();




            // Start the watcher which fires if adb devices changed
            dwAdb.DeviceChanged += DwAdb_DeviceChangedAdb;
            dwAdb.StartDeviceWatcher();

            // Start the watcher which fires if fastboot devices changed
            dwFastboot.DeviceChangedFastboot += DwFastboot_DeviceChangedFastboot;
            dwFastboot.StartDeviceWatcher();
        }

        private void DwFastboot_DeviceChangedFastboot(DeviceWatcherFastboot sender, DeviceListFastboot e)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                //formMethods.RefreshSerialsInCombobox(e.DeviceList);
                txt_DevicesFastboot.Text = e.DevicesRaw.ToUpper();
            });
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

        private void DwAdb_DeviceChangedAdb(DeviceWatcherAdb dw, DeviceListAdb e)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                formMethods.RefreshSerialsInCombobox(e.DeviceList);
                txt_DevicesAdb.Text = e.DevicesRaw.ToUpper();
            });
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

                            case "#screenshot":

                                saveFileDialog.FileName = "screenshot_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '.');
                                saveFileDialog.Filter = "PNG Image(.png)|*.png";
                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    adb.StartProcessing("shell screencap -p > " + saveFileDialog.FileName, formMethods.SelectedDevice());
                                }
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

                            case "#sideload":
                                if (sideLoad == null || sideLoad.IsDisposed)
                                {
                                    sideLoad = new Sideload(adb, formMethods);
                                    sideLoad.Show();
                                }
                                else
                                {
                                    sideLoad.Focus();
                                }
                                break;

                            case "#backuprestore":
                                if (backupRestore == null || backupRestore.IsDisposed)
                                {
                                    backupRestore = new BackupRestore(adb, formMethods);
                                    backupRestore.Show();
                                }
                                else
                                {
                                    backupRestore.Focus();
                                }
                                break;
                        }
                    }

                    if (tag.StartsWith("+"))
                    {
                        if (tag.StartsWith("++"))
                        {

                        }
                        else
                        {
                            // todo seriennummer und command fixen
                            fastboot.StartProcessing(tag.Remove(0,1), "");
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
    }
}