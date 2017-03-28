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
        private Density densityChange;
        private FileOps fileOps;
        private InstallUninstall installUninstall;
        private Sideload sideLoad;
        private BackupRestore backupRestore;

        public FormMethods formMethods;

        private CmdProcess cmdProcess = new CmdProcess();

        private DeviceWatcher dwAdb = new DeviceWatcher(true);
        private DeviceWatcher dwFastboot = new DeviceWatcher(false);

        private StringBuilder builder = new StringBuilder();

        public MainForm()
        {
            // todo aapt implementieren

            InitializeComponent();

            // pass formMethods the created Form this
            formMethods = new FormMethods(this);


            cmdProcess.GetProcess.Start();

            // Begin and cancel so the RichTextBox will stay clean. Otherwise it will start in line 2.
            cmdProcess.GetProcess.BeginOutputReadLine();
            cmdProcess.GetProcess.CancelOutputRead();


            cmdProcess.GetProcess.OutputDataReceived += AppendReceivedData;
            cmdProcess.GetProcess.ErrorDataReceived += AppendReceivedData;

            Thread.Sleep(200);

            cmdProcess.GetProcess.BeginOutputReadLine();
            cmdProcess.GetProcess.BeginErrorReadLine();

            cmdProcess.CommandExecutionStarted += CommandExecutionStarted;
            cmdProcess.CommandExecutionStopped += formMethods.ShowMboxAborted;


            // Select custom command control
            cbx_customCommand.Select();


            // Start the watcher which fires if adb devices changed
            dwAdb.DeviceChanged += DwAdb_DeviceChanged;
            dwAdb.StartDeviceWatcher();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                cmdProcess.StopProcessing();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CommandExecutionStarted()
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                if (cbo_clearEverytime.Checked)
                {
                    rtb_console.Clear();
                }
            });
        }

        private void DwAdb_DeviceChanged(DeviceWatcher dw, DeviceList e)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                formMethods.RefreshAdbSerialsInCombobox(e.GetDevicesList);
                txt_DevicesAdb.Text = e.GetDevicesRaw.ToUpper().TrimEnd();
            });
        }

        private void Btn_connectWirelessDevice_Click(object sender, EventArgs e)
        {
            var r = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");

            string ipadress = txt_wirelessDeviceIp.Text;

            if (r.Match(ipadress).Success)
            {
                cmdProcess.StartProcessing("adb connect " + ipadress, "");
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
            cmdProcess.StopProcessing();
        }

        private void Btn_disconnectWirelessDevices_Click_1(object sender, EventArgs e)
        {
            cmdProcess.StartProcessing("adb disconnect", "");
        }

        private void Btn_executeCommand_Click(object sender, EventArgs e)
        {
            string command = cbx_customCommand.Text;

            if (!String.IsNullOrEmpty(command))
            {
                cbx_customCommand.Items.Add(command);

                cmdProcess.StartProcessing(command, formMethods.SelectedDevice());
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
            if (!string.IsNullOrEmpty(formMethods.SelectedDevice()))
            {
                string serial = "";

                serial += "-s " + formMethods.SelectedDevice() + " ";

                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = "/K tools\\adb " + serial + " shell",
                    }
                };

                process.Start();
            }
            else
            {
                MessageBox.Show("No device connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_remountSystemClick(object sender, EventArgs e)
        {
            cmdProcess.StartProcessing("adb remount", formMethods.SelectedDevice());
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

                    if (tag.StartsWith("adb ") || tag.StartsWith("fastboot "))
                    {
                        // seriennummer für fastboot implementieren
                        cmdProcess.StartProcessing(tag, formMethods.SelectedDevice());
                    }

                    else if (tag.StartsWith("#"))
                    {
                        switch (tag)
                        {
                            case "#prop":
                                new SetProp(cmdProcess, formMethods).Show();
                                break;

                            case "#screenshot":

                                saveFileDialog.FileName = "screenshot_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '.');
                                saveFileDialog.Filter = "PNG Image(.png)|*.png";
                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    cmdProcess.StartProcessing("adb shell screencap -p > " + saveFileDialog.FileName, formMethods.SelectedDevice());
                                }
                                break;

                            case "#screenrecord":
                                if (screenRecord == null || screenRecord.IsDisposed)
                                {
                                    screenRecord = new ScreenRecord(cmdProcess, formMethods);
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
                                    spoofMac = new SpoofMac(cmdProcess, formMethods);
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
                                    resolutionChange = new ResolutionChange(cmdProcess, formMethods);
                                    resolutionChange.Show();
                                }
                                else
                                {
                                    resolutionChange.Focus();
                                }
                                break;

                            case "#density":
                                if (densityChange == null || densityChange.IsDisposed)
                                {
                                    densityChange = new Density(cmdProcess, formMethods);
                                    densityChange.Show();
                                }
                                else
                                {
                                    densityChange.Focus();
                                }
                                break;

                            case "#files":
                                if (fileOps == null || fileOps.IsDisposed)
                                {
                                    fileOps = new FileOps(cmdProcess, formMethods);
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
                                    installUninstall = new InstallUninstall(cmdProcess, formMethods);
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
                                    sideLoad = new Sideload(cmdProcess, formMethods);
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
                                    backupRestore = new BackupRestore(cmdProcess, formMethods);
                                    backupRestore.Show();
                                }
                                else
                                {
                                    backupRestore.Focus();
                                }
                                break;
                        }
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
            cmdProcess.StartProcessing("adb root", formMethods.SelectedDevice());
        }

        private void Btn_adbUnroot_Click(object sender, EventArgs e)
        {
            cmdProcess.StartProcessing("adb unroot", formMethods.SelectedDevice());
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
                cmdProcess.GetProcess.Kill();
                cmdProcess.GetProcess.Dispose();
            }
            catch (Exception)
            { }
        }
    }
}