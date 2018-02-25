using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using adbGUI.Methods;

namespace adbGUI.Forms
{
    public partial class MainForm : Form, IDisposable
    {
        private readonly CmdProcess _cmdProcess = new CmdProcess();
        private BackupRestore _backupRestore;
        private Density _densityChange;
        private FileOps _fileOps;
        private InstallUninstall _installUninstall;
        private LogcatAdvanced _logcatAdvanced;
        private ResolutionChange _resolutionChange;
        private ScreenRecord _screenRecord;
        private Sideload _sideLoad;
        private SpoofMac _spoofMac;
        public FormMethods FormMethods;

        public MainForm()
        {
            InitializeComponent();

            // pass formMethods the created Form this
            FormMethods = new FormMethods(this);

            _cmdProcess.GetProcess.Start();

            // Begin and cancel so the RichTextBox will stay clean. Otherwise it will start in line 2.
            _cmdProcess.GetProcess.BeginOutputReadLine();
            _cmdProcess.GetProcess.CancelOutputRead();

            _cmdProcess.GetProcess.OutputDataReceived += AppendReceivedData;
            _cmdProcess.GetProcess.ErrorDataReceived += AppendReceivedData;

            Thread.Sleep(20);

            _cmdProcess.GetProcess.BeginOutputReadLine();
            _cmdProcess.GetProcess.BeginErrorReadLine();
            rtb_console.Clear();

            _cmdProcess.CommandExecutionStarted += CommandExecutionStarted;
            _cmdProcess.ClearConsole += () => { rtb_console.Clear(); };

            // Select custom command control
            cbx_customCommand.Select();

            // Start the watcher which fires if adb devices changed
            AdbDeviceWatcher.DeviceChanged += DwAdb_DeviceChanged;
            AdbDeviceWatcher.StartDeviceWatcher();
        }

        public new void Dispose()
        {
            _logcatAdvanced?.Dispose();
            _cmdProcess?.Dispose();
            FormMethods?.Dispose();
            _cmdProcess?.GetProcess?.Dispose();
            GC.SuppressFinalize(this);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                _cmdProcess.StopProcessing();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CommandExecutionStarted()
        {
            BeginInvoke((MethodInvoker) delegate { rtb_console.Clear(); });
        }

        private void DwAdb_DeviceChanged(AdbDeviceList e)
        {
            try
            {
                BeginInvoke((MethodInvoker) delegate
                {
                    FormMethods.RefreshAdbSerialsInCombobox(e.GetDevicesList);
                    txt_DevicesAdb.Text = e.GetDevicesRaw.ToUpper().TrimEnd();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_consoleStop_Click(object sender, EventArgs e)
        {
            _cmdProcess.StopProcessing();
        }

        private void Btn_executeCommand_Click(object sender, EventArgs e)
        {
            var command = cbx_customCommand.Text;

            if (!string.IsNullOrEmpty(command))
            {
                cbx_customCommand.Items.Add(command);

                _cmdProcess.StartProcessing(command, FormMethods.SelectedDevice());
            }
            else
            {
                MessageBox.Show(@"Please enter a command!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppendReceivedData(object sender, DataReceivedEventArgs e)
        {
            try
            {
                BeginInvoke((MethodInvoker) delegate { rtb_console.AppendText(e.Data + Environment.NewLine); });
                Thread.Sleep(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void Trv_commandTreeView_DoubleClick(object sender, EventArgs e)
        {
            // todo add network capture tcpdump
            try
            {
                string tag;

                if (!string.IsNullOrEmpty(tag = trv_commandTreeView.SelectedNode.Tag.ToString()))
                    if (tag.StartsWith("adb ") || tag.StartsWith("fastboot "))
                        _cmdProcess.StartProcessing(tag, FormMethods.SelectedDevice());

                    else if (tag.StartsWith("#"))
                        switch (tag)
                        {
                            case "#prop":
                                new SetProp(_cmdProcess, FormMethods).Show();
                                break;

                            case "#screenshot":
                                if (!string.IsNullOrEmpty(FormMethods.SelectedDevice()))
                                {
                                    saveFileDialog.FileName =
                                        "screenshot_" + DateTime.Now.ToString(CultureInfo.InvariantCulture)
                                            .Replace(' ', '_').Replace(':', '.');
                                    saveFileDialog.Filter = @"PNG Image(.png)|*.png";
                                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                        _cmdProcess.StartProcessing(
                                            "adb shell screencap -p > " + saveFileDialog.FileName,
                                            FormMethods.SelectedDevice());
                                }

                                break;

                            case "#screenrecord":
                                if (_screenRecord == null || _screenRecord.IsDisposed)
                                {
                                    _screenRecord = new ScreenRecord(_cmdProcess, FormMethods);
                                    _screenRecord.Show();
                                }
                                else
                                {
                                    _screenRecord.Focus();
                                }

                                break;

                            case "#spoofmac":
                                if (_spoofMac == null || _spoofMac.IsDisposed)
                                {
                                    _spoofMac = new SpoofMac(_cmdProcess, FormMethods);
                                    _spoofMac.Show();
                                }
                                else
                                {
                                    _spoofMac.Focus();
                                }

                                break;

                            case "#resolution":
                                if (_resolutionChange == null || _resolutionChange.IsDisposed)
                                {
                                    _resolutionChange = new ResolutionChange(_cmdProcess, FormMethods);
                                    _resolutionChange.Show();
                                }
                                else
                                {
                                    _resolutionChange.Focus();
                                }

                                break;

                            case "#density":
                                if (_densityChange == null || _densityChange.IsDisposed)
                                {
                                    _densityChange = new Density(_cmdProcess, FormMethods);
                                    _densityChange.Show();
                                }
                                else
                                {
                                    _densityChange.Focus();
                                }

                                break;

                            case "#files":
                                if (_fileOps == null || _fileOps.IsDisposed)
                                {
                                    _fileOps = new FileOps(_cmdProcess, FormMethods);
                                    _fileOps.Show();
                                }
                                else
                                {
                                    _fileOps.Focus();
                                }

                                break;

                            case "#installuninstall":
                                if (_installUninstall == null || _installUninstall.IsDisposed)
                                {
                                    _installUninstall = new InstallUninstall(_cmdProcess, FormMethods);
                                    _installUninstall.Show();
                                }
                                else
                                {
                                    _installUninstall.Focus();
                                }

                                break;

                            case "#sideload":
                                if (_sideLoad == null || _sideLoad.IsDisposed)
                                {
                                    _sideLoad = new Sideload(_cmdProcess, FormMethods);
                                    _sideLoad.Show();
                                }
                                else
                                {
                                    _sideLoad.Focus();
                                }

                                break;

                            case "#backuprestore":
                                if (_backupRestore == null || _backupRestore.IsDisposed)
                                {
                                    _backupRestore = new BackupRestore(_cmdProcess, FormMethods);
                                    _backupRestore.Show();
                                }
                                else
                                {
                                    _backupRestore.Focus();
                                }

                                break;

                            case "#logcatadvanced":
                                if (_logcatAdvanced == null || _logcatAdvanced.IsDisposed)
                                {
                                    _logcatAdvanced = new LogcatAdvanced(_cmdProcess, FormMethods);
                                    _logcatAdvanced.Show();
                                }
                                else
                                {
                                    _logcatAdvanced.Focus();
                                }

                                break;

                            case "#credits":
                                new Credits().ShowDialog();
                                break;
                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cbx_customCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) btn_executeCommand.PerformClick();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Kill the process
            // todo rename Forms
            try
            {
                //adb.StopProcessing();
                _cmdProcess.GetProcess.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tsb_OpenShell_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FormMethods.SelectedDevice()))
            {
                var serial = "";

                serial += "-s " + FormMethods.SelectedDevice() + " ";

                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = "/K adb " + serial + " shell"
                    }
                };

                process.Start();
            }
            else
            {
                MessageBox.Show(@"No device connected. Please connect a device for adb commands.",
                    @"Error - No Device Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tsm_WirelessConnect_Click(object sender, EventArgs e)
        {
            var r = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}:\d{1,5}$");

            var ipadress = tst_IpAdress.Text;

            if (r.Match(ipadress).Success)
                _cmdProcess.StartProcessing("adb connect " + ipadress, "");
            else
                MessageBox.Show(@"Please enter a valid IP adress", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void Tsm_WirelessDisconnect_Click(object sender, EventArgs e)
        {
            _cmdProcess.StartProcessing("adb disconnect", "");
        }

        private void Tsb_KillServer_Click(object sender, EventArgs e)
        {
            FormMethods.KillServer();
        }

        private void Tsb_AdbRoot_Click(object sender, EventArgs e)
        {
            _cmdProcess.StartProcessing("adb root", FormMethods.SelectedDevice());
        }

        private void Tsb_AdbUnroot_Click(object sender, EventArgs e)
        {
            _cmdProcess.StartProcessing("adb unroot", FormMethods.SelectedDevice());
        }

        private void Tsb_Power_Click(object sender, EventArgs e)
        {
            switch (sender.ToString())
            {
                case "Reboot Normal":
                    _cmdProcess.StartProcessing("adb reboot", FormMethods.SelectedDevice());
                    break;


                case "Reboot Recovery":
                    _cmdProcess.StartProcessing("adb reboot recovery", FormMethods.SelectedDevice());
                    break;


                case "Reboot Bootloader":
                    _cmdProcess.StartProcessing("adb reboot bootloader", FormMethods.SelectedDevice());
                    break;


                case "Reboot Fastboot":
                    _cmdProcess.StartProcessing("adb reboot fastboot", FormMethods.SelectedDevice());
                    break;


                case "Sideload Mode":
                    _cmdProcess.StartProcessing("adb reboot sideload", FormMethods.SelectedDevice());
                    break;


                case "Shutdown":
                    _cmdProcess.StartProcessing("adb shell reboot -p", FormMethods.SelectedDevice());
                    break;


                case "Sleep":
                    _cmdProcess.StartProcessing("adb shell input keyevent POWER", FormMethods.SelectedDevice());
                    break;
            }
        }
    }
}