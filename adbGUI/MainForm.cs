using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI
{
      public partial class MainForm : Form
      {
            //--------------------------------------------------------------------------------------------------
            //-------------------Windows Forms------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------



            public MainForm()
            {
                  InitializeComponent();
            }

            //Exit with escape
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                  if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
                  Close();
                  return true;
            }

            //--------------------------------------------------------------------------------------------------
            //-------------------Methods------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------

            private static void StartServer()
            {
                  var psi = new ProcessStartInfo("tools\\adb", "start-server");
                  psi.WindowStyle = ProcessWindowStyle.Hidden;
                  Process.Start(psi);
            }

            private static void KillServer()
            {
                  foreach (var pr in Process.GetProcessesByName("adb"))
                  {
                        pr.Kill();
                  }
            }

            private void GetInformation(string a, string b, string titel, int width = 850, int height = 600, FormWindowState windowstate = FormWindowState.Normal)
            {
                  int i = Convert.ToInt32(txt_devices.Lines.Count().ToString());

                  if (i == 4 || txt_serialno.Text != "")
                  {
                        var thread = new Thread(delegate() { CallAdb(a, b, titel, width, height, windowstate); });
                        thread.Start();
                        while (thread.IsAlive)
                        {
                              tabControl1.Enabled = false;
                              //Cursor = Cursors.AppStarting;
                              Application.DoEvents();
                        }
                        tabControl1.Enabled = true;
                        //Cursor = Cursors.Default;
                  }
                  else if (i == 3)
                  {
                        //No device connected
                        MessageBox.Show("No device connected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                  }
                  else if (i >= 4 && Serialno() == "")
                  {
                        //More than 4 devices connected and no serial number
                        MessageBox.Show("There are more than 1 devices connected. \r\nType in the serial number in the main tab.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
            }

            private void ToViewer(string value, string title, int x, int y,
                  FormWindowState windowstate = FormWindowState.Normal)
            {
                  if (InvokeRequired)
                  {
                        Invoke(new Action<string, string, int, int, FormWindowState>(ToViewer), value, title, x, y,
                              windowstate);
                        return;
                  }
                  if (value == "")
                  {
                        MessageBox.Show("Make sure, your device is online and the serial number is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
                  else
                  {
                        var v = new Viewer();

                        v.txt_output.TabIndex = 2;
                        v.txt_output.Text += value;
                        v.Text = title;
                        v.WindowState = windowstate;
                        v.Width = x;
                        v.Height = y;
                        v.Show();
                  }
            }

            private async void CallAdb(string a, string b, string c, int x, int y,
                  FormWindowState windowstate = FormWindowState.Normal)
            {
                  var filename = "cmd.exe";
                  var arguments = "/C " + a + " tools\\adb " + Serialno() + " " + b;
                  var startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                  };
                  var process = new Process { StartInfo = startInfo };

                  process.Start();

                  string s = process.StandardOutput.ReadToEnd();

                  ToViewer(s, c, x, y, windowstate);
                  process.StandardOutput.Dispose();
            }

            private void callADB_w(string x)
            {
                  const string filename = "cmd.exe";
                  var arguments = "/C prompt $g & tools\\adb " + Serialno() + " " + x + " & echo. & pause";
                  var startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        WindowStyle = ProcessWindowStyle.Normal,
                        Arguments = arguments
                  };
                  var process = new Process { StartInfo = startInfo };
                  process.Start();
            }

            public void callADB_wo(string x, string y)
            {
                  var filename = "cmd.exe";
                  var arguments = "/C " + x + " tools\\adb " + Serialno() + " " + y;
                  var startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        WindowStyle = ProcessWindowStyle.Hidden
                  };

                  var process = new Process { StartInfo = startInfo };

                  process.Start();
            }

            private string Serialno()
            {
                  var s = "";

                  if (txt_serialno.Text != "")
                  {
                        s = "-s " + txt_serialno.Text;
                  }
                  return s.ToLower();
            }

            private void IsRunning()
            {
                  var a = "adbGUI - Server is running";
                  var b = "adbGUI - Server is not running";
                  while (true)
                  {
                        if (Process.GetProcessesByName("adb").Length > 0)
                        {
                              if (InvokeRequired)
                              {
                                    Invoke(new Action<string>(ServerOn), a);
                              }
                        }
                        else
                        {
                              if (InvokeRequired)
                              {
                                    Invoke(new Action<string>(ServerOff), b);
                              }
                        }
                        Thread.Sleep(150);
                  }
            }

            private void ServerOn(string s)
            {
                  Text = s;
            }

            private void ServerOff(string s)
            {
                  Text = s;
                  txt_devices.Text = string.Empty;
                  txt_serialno.Text = string.Empty;
            }

            private async void DevicesToTxtBox()
            {
                  const string filename = "cmd.exe";
                  const string arguments = "/C tools\\adb devices -l";
                  var startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                  };
                  var process = new Process { StartInfo = startInfo };

                  while (true)
                  {
                        if (Process.GetProcessesByName("adb").Length > 0)
                        {
                              process.Start();
                        }

                        else
                        {
                              StartServer();
                              await Task.Delay(500);
                              process.Start();
                        }

                        string s2 = process.StandardOutput.ReadToEnd();

                        txt_devices.Invoke((MethodInvoker)(() => txt_devices.Text = s2.ToUpper()));

                        Thread.Sleep(1000);

                  }
            }

            private void GetSerialnumber()
            {

                  const string filename = "cmd.exe";
                  const string arguments = "/C tools\\adb devices";
                  var startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                  };
                  var process = new Process { StartInfo = startInfo };
                  process.Start();
                  string s2 = process.StandardOutput.ReadToEnd();


                  if (s2.Length > 29)
                  {
                        using (StringReader s = new StringReader(s2))
                        {
                              string line;

                              while (s.Peek() != -1)
                              {
                                    line = s.ReadLine();

                                    if (line.StartsWith("List") || line.StartsWith("\r\n") || line.Trim() == "")
                                          continue;

                                    if (line.IndexOf('\t') != -1)
                                    {
                                          line = line.Substring(0, line.IndexOf('\t'));
                                          txt_serialno.Invoke((MethodInvoker)(() => txt_serialno.Text = line.ToUpper()));
                                    }
                              }
                              s.Close();
                              s.Dispose();
                        }
                  }
            }

            public Form Rebootmenu;
            private void btn_reboot_Click(object sender, EventArgs e)
            {
                  //RebootMenu _rebootmenu = new RebootMenu(txt_devices.Lines.Count().ToString());
                  if ((Rebootmenu == null) || (Rebootmenu.IsDisposed))
                  {
                        Rebootmenu = new RebootMenu(Convert.ToInt32(txt_devices.Lines.Count().ToString()));
                  }
                  Rebootmenu.Show();
                  Rebootmenu.Focus();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                  openFileDialog1.FileName = "";
                  openFileDialog1.CheckFileExists = true;
                  openFileDialog1.CheckPathExists = true;
                  openFileDialog1.Filter = @" .zip|*.zip";


                  if (openFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                        txt_sideload_path.Text = openFileDialog1.FileName;
                  }
            }

            private void btn_sideload_sideload_Click(object sender, EventArgs e)
            {
                  if (txt_sideload_path.Text != "")
                  {
                        var s = "sideload \"" + txt_sideload_path.Text + "\"";
                        callADB_w(s);
                  }
                  else
                  {
                        MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
            }

            private void btn_push_openfile_Click(object sender, EventArgs e)
            {
                  openFileDialog1.FileName = "";
                  openFileDialog1.CheckFileExists = true;
                  openFileDialog1.CheckPathExists = true;
                  openFileDialog1.Filter = "";


                  if (openFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                        txt_push_fromfilepath.Text = openFileDialog1.FileName;
                  }
            }

            private void btn_push_push_Click(object sender, EventArgs e)
            {
                  if (txt_push_fromfilepath.Text == "" || txt_push_tofilepath.Text == "")
                  {
                        MessageBox.Show("Please select a file and chose destination!", "Error", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                  }
                  else
                  {
                        var s = "push \"" + txt_push_fromfilepath.Text + "\"" + " \"" + txt_push_tofilepath.Text + "\"";
                        callADB_w(s);
                  }
            }

            private void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                  KillServer();
                  Environment.Exit(Environment.ExitCode);
            }

            private void btn_run_Click(object sender, EventArgs e)
            {

                  var s = txt_customcommand.Text;
                  if (s == "")
                  {
                        MessageBox.Show("Please type in a command!", "Error");
                  }
                  else
                  {
                        callADB_w(s);
                  }
            }

            private void btn_openshell_Click(object sender, EventArgs e)
            {
                  callADB_w("shell");
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                  var printDevices = new Thread(DevicesToTxtBox);
                  printDevices.IsBackground = true;
                  printDevices.Start();

                  var checkStatus = new Thread(IsRunning);
                  checkStatus.IsBackground = true;
                  checkStatus.Start();
                  txt_customcommand.Select();
            }

            private void btn_phoneinformation_getprop_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell getprop", "Properties");
            }

            private void btn_phoneinformation_installedpackages_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell \"pm list packages -f | cut -c9- | sort\"", "All Packages");
            }

            private void btn_phoneinformation_logcat_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell logcat -d", "Logcat Dump", 850, 600, FormWindowState.Maximized);
            }

            private void txt_customcommand_KeyDown(object sender, KeyEventArgs e)
            {
                  if (e.KeyCode == Keys.Enter)
                  {
                        btn_run.PerformClick();
                        e.SuppressKeyPress = true;
                  }
            }

            private void btn_phoneinformation_spoofmac_Click(object sender, EventArgs e)
            {
                  var s = txt_phoneinformation_mac.Text;
                  if (s == "")
                  {
                        MessageBox.Show("Please type in a mac address", "Error");
                  }
                  else
                  {
                        callADB_wo("", "shell su root busybox ifconfig wlan0 hw ether " + txt_phoneinformation_mac.Text);
                  }
            }

            private async void button2_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "shell su root busybox ifconfig wlan0 down");
                  await Task.Delay(200);
                  callADB_wo("", "shell su root busybox ifconfig wlan0 up");
            }

            private void btn_phoneinformation_showmac_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell cat /sys/class/net/wlan0/address", "MAC Adress", 280, 110);
            }

            private void btn_phoneinformation_dumpsys_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell dumpsys", "Dumpsys Input Diagnostics", 850, 600, FormWindowState.Maximized);
            }

            private void btn_phoneinformation_meminfo_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell dumpsys meminfo", "Memory Information");
            }

            private void btn_phoneinformation_processes_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell ps", "Processes");
            }

            private void btn_packages_open_Click(object sender, EventArgs e)
            {
                  openFileDialog1.FileName = "";
                  openFileDialog1.CheckFileExists = true;
                  openFileDialog1.CheckPathExists = true;
                  openFileDialog1.Filter = " .apk|*.apk";


                  if (openFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                        txt_packages_path.Text = openFileDialog1.FileName;
                  }
            }

            private void btn_packages_install_Click_1(object sender, EventArgs e)
            {
                  var s = "\"" + txt_packages_path.Text + "\"";

                  if (txt_packages_path.Text != "")
                  {
                        callADB_w("install " + s);
                  }
                  else
                  {
                        MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
            }

            private void btn_packages_uninstall_Click(object sender, EventArgs e)
            {
                  var s = "\"" + txt_packages_package.Text + "\"";
                  if (txt_packages_package.Text != "")
                  {
                        callADB_w("uninstall " + s);
                  }
                  else
                  {
                        MessageBox.Show("Please select a Package!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
            }

            private void btn_packages_installed_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell \"pm list packages -3 | cut -c9- | sort\"", "Installed Packages", 500, 750);
            }

            private void btn_pull_saveto_Click(object sender, EventArgs e)
            {
                  folderBrowserDialog1.Description = "Where should the file be saved?";

                  if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                  {
                        txt_pull_pathto.Text = folderBrowserDialog1.SelectedPath;
                  }
            }

            private void btn_pull_pull_Click(object sender, EventArgs e)
            {
                  if (txt_pull_pathto.Text == "" || txt_pull_pathfrom.Text == "")
                  {
                        MessageBox.Show("Please select a file and chose destination!", "Error", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                  }
                  else
                  {
                        var s = "pull \"" + txt_pull_pathfrom.Text + "\"" + " \"" + txt_pull_pathto.Text + "\"";
                        callADB_w(s);
                  }
            }

            private void txt_push_tofilepath_KeyDown(object sender, KeyEventArgs e)
            {
                  if (e.KeyCode == Keys.Enter)
                  {
                        btn_push_push.PerformClick();
                        e.SuppressKeyPress = true;
                  }
            }

            private void txt_pull_pathfrom_KeyDown(object sender, KeyEventArgs e)
            {
                  if (e.KeyCode == Keys.Enter)
                  {
                        btn_pull_pull.PerformClick();
                        e.SuppressKeyPress = true;
                  }
            }

            private void txt_phoneinformation_mac_KeyDown(object sender, KeyEventArgs e)
            {
                  if (e.KeyCode == Keys.Enter)
                  {
                        btn_phoneinformation_spoofmac.PerformClick();
                        e.SuppressKeyPress = true;
                  }
            }

            private void button3_Click(object sender, EventArgs e)
            {
                  callADB_w("version");
            }

            private void button4_Click(object sender, EventArgs e)
            {
                  callADB_w("help");
            }

            private void btn_phoneinformation_features_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell \"pm list features | cut -c9- | sort\"", "Phone Features");
            }

            private void btn_phoneinformation_libraries_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell pm list libraries", "Libraries", 500, 400);
            }

            private void btn_phoneinformation_users_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell pm list users", "All User", 600, 250);
            }

            private void btn_phoneinformation_maxusers_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell pm get-max-users", "Max User", 600, 250);
            }

            private void btn_phoneinformation_permissions_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell pm list permissions", "Permissions", 700);
            }

            private void btn_phoneinformation_getimei_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell service call iphonesubinfo 1", "IMEI", 550, 130);
            }

            private void btn_phoneinformation_dmesg_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell dmesg", "Kernel Messages", 850, 600, FormWindowState.Maximized);
            }

            private void btn_phoneinformation_battery_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell dumpsys battery", "Battery Stats", 280, 300);
            }

            private void btn_phoneinformation_wifiinfo_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell dumpsys wifi", "WIFI Information", 850, 600, FormWindowState.Maximized);
            }

            private void btn_phoneinformation_cpuinfo_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell dumpsys cpuinfo", "CPU Information", 750, 500);
            }

            private void btn_phoneinformation_accounts_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell dumpsys account", "Accounts", 1500);
            }

            private void btn_backup_backup_Click(object sender, EventArgs e)
            {
                  var name = " -f \"" + txt_backup_path.Text + "\"";
                  var apk = " -noapk";
                  var shared = " -noshared";
                  var all = " -all";
                  var system = " -system";
                  var package = txt_backup_packagename.Text;


                  if (cb_backup_package.Checked == false)
                  {
                        if (txt_backup_path.Text == "")
                        {
                              MessageBox.Show("Please select a destination!", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
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

                        callADB_w("backup" + apk + shared + all + system + name);
                  }
                  else
                  {
                        if (txt_backup_path.Text == "")
                        {
                              MessageBox.Show("Please select a destination!", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                        else
                        {
                              callADB_w("backup -apk " + package + name);
                        }
                  }
            }

            private void btn_backup_saveto_Click(object sender, EventArgs e)
            {
                  saveFileDialog1.Filter = " .ab|*.ab";
                  if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                        txt_backup_path.Text = saveFileDialog1.FileName;
                  }
            }

            private void btn_restore_openfile_Click(object sender, EventArgs e)
            {
                  openFileDialog1.FileName = "";
                  openFileDialog1.CheckFileExists = true;
                  openFileDialog1.CheckPathExists = true;
                  openFileDialog1.Filter = " .ab|*.ab";


                  if (openFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                        txt_restore_path.Text = openFileDialog1.FileName;
                  }
            }

            private void btn_restore_restore_Click(object sender, EventArgs e)
            {
                  if (txt_restore_path.Text == "")
                  {
                        MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
                  else
                  {
                        callADB_w("restore \"" + txt_restore_path.Text + "\"");
                  }
            }

            private void cb_backup_package_CheckedChanged(object sender, EventArgs e)
            {
                  if (cb_backup_package.Checked)
                  {
                        cb_backup_nosystem.Enabled = false;
                        cb_backup_nosystem.Checked = false;
                        cb_backup_shared.Enabled = false;
                        cb_backup_shared.Checked = false;
                        cb_backup_withapk.Enabled = false;
                        cb_backup_withapk.Checked = false;
                        label8.Visible = true;
                        txt_backup_packagename.Visible = true;
                        txt_backup_path.Size = new Size(209, 20);
                  }
                  else
                  {
                        cb_backup_nosystem.Enabled = true;
                        cb_backup_shared.Enabled = true;
                        label8.Visible = false;
                        txt_backup_packagename.Visible = false;
                        txt_backup_path.Size = new Size(324, 20);
                        cb_backup_withapk.Enabled = true;
                        txt_backup_packagename.Text = "";
                  }
            }

            private void btn_phoneinformation_diskstats_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell dumpsys diskstats", "Diskstats", 600, 350);
            }

            private void btn_phoneinformation_netstat_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell busybox netstat", "Netstat", 950, 700);
            }

            private void btn_phoneinformation_uptime_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell uptime", "Uptime", 550, 100);
            }

            private void btn_donate_Click(object sender, EventArgs e)
            {
                  var url = "";

                  var business = "laboo.lm@gmail.com"; // your paypal email
                  var description = "Donation"; // '%20' represents a space. remember HTML!
                  var country = "DE"; // AU, US, etc.
                  var currency = "EUR"; // AUD, USD, etc.

                  url += "https://www.paypal.com/cgi-bin/webscr" +
                         "?cmd=" + "_donations" +
                         "&business=" + business +
                         "&lc=" + country +
                         "&item_name=" + description +
                         "&currency_code=" + currency +
                         "&bn=" + "PP%2dDonationsBF";

                  Process.Start(url);
            }

            private void btn_phoneinformation_show_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell wm density", "Density", 280, 110);
            }

            private async void btn_phoneinformation_changedpi_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "shell wm density " + txt_phoneinformation_dpi.Text);
                  await Task.Delay(400);
                  callADB_wo("", "reboot");
            }

            private async void btn_phoneinformation_resetdpi_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "shell wm density reset");
                  await Task.Delay(400);
                  callADB_wo("", "reboot");
            }

            private void btn_connect_Click(object sender, EventArgs e)
            {
                  string s;
                  s = @txt_ip.Text;
                  if (s == "")
                  {
                        MessageBox.Show("Please type in IP and port!", "Error");
                  }
                  else
                  {
                        callADB_wo("", "connect " + s);
                  }
            }

            private void txt_ip_KeyDown(object sender, KeyEventArgs e)
            {
                  if (e.KeyCode == Keys.Enter)
                  {
                        btn_connect.PerformClick();
                        e.SuppressKeyPress = true;
                  }
            }

            private void button5_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "shell wm size " + txt_phoneinformation_resolution.Text);
            }

            private void button7_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell wm size", "Resolution", 280, 110);
            }

            private void button6_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "shell wm size reset");
            }

            private void btn_phoninformation_hosts_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell cat /etc/hosts", "Hosts", 750);
            }

            private void btn_phoneinformation_activities_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell dumpsys activity", "Activities");
            }

            private void btn_phoneinformation_screenshot_Click(object sender, EventArgs e)
            {
                  var proc = new Process();
                  proc.StartInfo.FileName = "tools\\screenshot.bat";
                  proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                  proc.Start();
                  while (proc.HasExited == false)
                  {
                        //Cursor = Cursors.WaitCursor;
                  }
                  //Cursor = Cursors.Default;
            }

            private void txt_phoneinformation_dpi_KeyDown(object sender, KeyEventArgs e)
            {
                  if (e.KeyCode == Keys.Enter)
                  {
                        btn_phoneinformation_changedpi.PerformClick();
                        e.SuppressKeyPress = true;
                  }
            }

            private void txt_phoneinformation_resolution_KeyDown(object sender, KeyEventArgs e)
            {
                  if (e.KeyCode == Keys.Enter)
                  {
                        btn_phoneinformation_setsize.PerformClick();
                        e.SuppressKeyPress = true;
                  }
            }

            private void btn_remountsystem_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "remount");
            }

            private void btnAlarm_Click(object sender, EventArgs e)
            {
                  GetInformation("", "shell dumpsys alarm", "Current Alarm Manager State", 950);
            }

            private void btnKillserver_Click(object sender, EventArgs e)
            {
                  KillServer();
            }

            private void button5_Click_1(object sender, EventArgs e)
            {
                  callADB_wo("", "disconnect ");
            }

            private async void button6_Click_1(object sender, EventArgs e)
            {






                  const string filename = "cmd.exe";
                  const string arguments = "/C tools\\adb devices";
                  var startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                  };
                  var process = new Process { StartInfo = startInfo };

                  if (Process.GetProcessesByName("adb").Length > 0)
                  {
                        process.Start();
                  }

                  else
                  {
                        StartServer();
                        await Task.Delay(500);
                        process.Start();
                  }

                  var s2 = process.StandardOutput.ReadToEnd();


                  var deviceList = s2;
                  if (deviceList.Length > 29)
                  {
                        using (StringReader s = new StringReader(deviceList))
                        {
                              string line;

                              while (s.Peek() != -1)
                              {
                                    line = s.ReadLine();

                                    if (line.StartsWith("List") || line.StartsWith("\r\n") || line.Trim() == "")
                                          continue;

                                    if (line.IndexOf('\t') != -1)
                                    {
                                          line = line.Substring(0, line.IndexOf('\t'));
                                          txt_serialno.Text = line;
                                    }
                              }
                              s.Close();
                              s.Dispose();
                        }
                  }
            }

            private void txt_devices_TextChanged(object sender, EventArgs e)
            {
                  if (txt_devices.Lines.Count() == 3)
                  {
                        txt_serialno.Text = "";
                  }
                  Thread tr = new Thread(GetSerialnumber);
                  tr.IsBackground = true;
                  tr.Start();
            }
      }
}