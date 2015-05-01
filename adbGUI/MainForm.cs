using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI
{
      public partial class MainForm : Form
      {
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












            private void StartServer()
            {
                  ProcessStartInfo psi = new ProcessStartInfo("tools\\adb", "start-server");
                  psi.WindowStyle = ProcessWindowStyle.Hidden;
                  Process start = Process.Start(psi);
            }
            private void GetInformation(string a, string b, string titel, int width = 850, int height = 600, FormWindowState windowstate = FormWindowState.Normal)
            {
                  Thread thread = new Thread(delegate() { callADB(a, b, titel, width, height, windowstate); });
                  thread.Start();
                  while (thread.IsAlive)
                  {
                        tabControl1.Enabled = false;
                        //Cursor = Cursors.WaitCursor;
                        Application.DoEvents();
                  }
                  tabControl1.Enabled = true;
                  //Cursor = Cursors.Default;
            }
            public void ToViewer(string value, string title, int x, int y, FormWindowState windowstate = FormWindowState.Normal)
            {

                  if (InvokeRequired)
                  {
                        this.Invoke(new Action<string, string, int, int, FormWindowState>(ToViewer), value, title, x, y, windowstate);
                        return;
                  }
                  if (value == "")
                  {
                        MessageBox.Show(
                              "No or more devices connected. \r\nIf more than one device is connected, then type in the serial in the main tab.");
                  }
                  else
                  {
                        Viewer v = new Viewer();

                        v.txt_output.TabIndex = 2;
                        v.txt_output.Text += value;
                        v.Text = title;
                        v.WindowState = windowstate;
                        v.Width = x;
                        v.Height = y;

                        v.Show();
                  }
            }
            public async void callADB(string a, string b, string c, int x, int y, FormWindowState windowstate = FormWindowState.Normal)
            {
                  string filename = "cmd.exe";
                  string arguments = "/C " + a + " tools\\adb " + serialno() + " " + b;
                  ProcessStartInfo startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                  };
                  Process process = new Process { StartInfo = startInfo };


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

                  string s = process.StandardOutput.ReadToEnd();

                  ToViewer(s, c, x, y, windowstate);

            }



















            public async void CallViewer(string path, string name, int x = 850, int y = 600, FormWindowState state = FormWindowState.Normal)
            {

                  Viewer edit = new Viewer
                  {
                        Text = name,
                        Width = x,
                        Height = y,
                        WindowState = state
                  };


                  int count = 0;
                  int maxTries = 150;

                  while (true)
                  {
                        Cursor = Cursors.WaitCursor;

                        try
                        {
                              await Task.Delay(100);
                              StreamReader sr = new StreamReader("" + path, Encoding.Default, true);
                              string s = sr.ReadToEnd();
                              sr.Close();
                              if (s == "")
                              {
                                    MessageBox.Show("No or more devices connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Cursor = Cursors.Default;
                                    break;

                              }
                              else
                              {
                                    edit.Show();
                                    edit.txt_output.Text = s;
                                    Cursor = Cursors.Default;
                                    break;
                              }
                        }
                        catch (Exception ex)
                        {
                              if (++count == maxTries)
                              {
                                    DialogResult result = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                    if (result == DialogResult.Cancel)
                                    {
                                          Cursor = Cursors.Default;
                                          break;
                                    }
                                    count = 0;
                              }
                        }

                  }
            }

            public void CallProgram(string x, string y)
            {
                  ProcessStartInfo startInfo = new ProcessStartInfo
                  {
                        FileName = x,
                        Arguments = y,
                        WindowStyle = ProcessWindowStyle.Normal
                  };

                  Process process = new Process { StartInfo = startInfo };

                  process.Start();
            }

            public void callADB_w(string x)
            {
                  string filename = "cmd.exe";
                  string arguments = "/C prompt $g & tools\\adb " + serialno() + " " + x + " & echo. & pause";
                  ProcessStartInfo startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        WindowStyle = ProcessWindowStyle.Normal,
                        Arguments = arguments
                  };
                  Process process = new Process { StartInfo = startInfo };
                  process.Start();

                  ListViewItem lvi = new ListViewItem(DateTime.Now.ToString("HH:mm:ss tt"));
                  lvi.SubItems.Add(arguments.Remove(0, 3));
                  listView1.Items.Add(lvi);
            }

            public void callADB_wo(string x, string y)
            {
                  string filename = "cmd.exe";
                  string arguments = "/C " + x + " tools\\adb " + serialno() + " " + y;
                  ProcessStartInfo startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        WindowStyle = ProcessWindowStyle.Hidden
                  };

                  Process process = new Process { StartInfo = startInfo };

                  process.Start();

                  if (x == "")
                  {
                        arguments = arguments.Remove(0, 4);
                  }
                  else
                  {
                        arguments = arguments.Remove(0, 3);

                  }

                  ListViewItem lvi = new ListViewItem(DateTime.Now.ToString("HH:mm:ss"));
                  lvi.SubItems.Add(arguments);
                  listView1.Items.Add(lvi);


            }
            private string serialno()
            {
                  string s = "";

                  if (txt_serialno.Text != "")
                  {
                        s = "-s " + txt_serialno.Text;
                  }
                  return s;
            }

            private async void IsRunning()
            {
                  await Task.Delay(700);

                  if (Process.GetProcessesByName("adb").Length > 0)
                  {
                        this.Text = "adbGUI - Server is running";
                  }
                  else
                  {
                        this.Text = "adbGUI - Server is not running";
                  }

            }

            private void KillServer()
            {
                  Process[] prs = Process.GetProcesses();


                  foreach (Process pr in prs)
                  {
                        if (pr.ProcessName == "adb")
                        {
                              pr.Kill();
                        }
                  }
            }

            private void btn_startserver_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "start-server");
            }

            private void btn_killserver_Click(object sender, EventArgs e)
            {
                  KillServer();
            }

            private Form rebootmenu;
            private void btn_reboot_Click(object sender, EventArgs e)
            {

                  if ((rebootmenu == null) || (rebootmenu.IsDisposed))
                  {
                        rebootmenu = new RebootMenu();
                  }
                  rebootmenu.Show();
                  rebootmenu.Focus();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                  openFileDialog1.FileName = "";
                  openFileDialog1.CheckFileExists = true;
                  openFileDialog1.CheckPathExists = true;
                  openFileDialog1.Filter = " .zip|*.zip";


                  if (openFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                        txt_sideload_path.Text = openFileDialog1.FileName;
                  }
            }

            private void btn_sideload_sideload_Click(object sender, EventArgs e)
            {
                  if (txt_sideload_path.Text != "")
                  {
                        string s = "sideload \"" + txt_sideload_path.Text + "\"";
                        callADB_w(s);
                  }
                  else
                  {
                        MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
            }

            private void btn_showdevices_Click(object sender, EventArgs e)
            {
                  //callADB_w("devices -l");

                  string file = "tmp\\devices.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "devices -l> " + file);
                  //CallViewer(file, "Devices", 700, 200);
                  DevicesToTxtBox();
            }
            private async void DevicesToTxtBox()
            {
                  await Task.Delay(1000);
                  StreamReader sr = new StreamReader("tmp\\devices.txt", Encoding.Default, true);
                  txt_devices.Text = sr.ReadToEnd();
                  sr.Close();
            }
            private async void btn_restartserver_Click(object sender, EventArgs e)
            {
                  KillServer();
                  await Task.Delay(300);
                  callADB_wo("", "start-server");
            }

            private void btn_statuswindow_Click_1(object sender, EventArgs e)
            {
                  MessageBox.Show(Process.GetProcessesByName("adb").Length > 0
                        ? "The adb server is running"
                        : "The adb server is not running");
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
                        string s = "push \"" + txt_push_fromfilepath.Text + "\"" + " \"" + txt_push_tofilepath.Text + "\"";
                        callADB_w(s);
                  }
            }

            private async void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                  KillServer();
                  await Task.Delay(200);
                  Directory.Delete("tmp", true);
            }

            private void btn_run_Click(object sender, EventArgs e)
            {
                  string s = txt_customcommand.Text;
                  if (s == "")
                  {
                        MessageBox.Show("Please type in a command!", "Error");
                  }
                  else
                  {
                        callADB_w(s);
                  }
            }

            private void btn_phoneinformation_getserial_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\serialno.txt";
                  callADB_wo("mkdir tmp  & del " + file + " & ", "get-serialno > " + file);
                  CallViewer(file, "Serial Number", 270, 110);
            }

            private void btn_openshell_Click(object sender, EventArgs e)
            {
                  callADB_w("shell");
            }
            void CreateHiddenFolder(string name)
            {
                  DirectoryInfo di = new DirectoryInfo(name);
                  di.Create();
                  di.Attributes |= FileAttributes.Hidden;
            }
            private async void Form1_Load(object sender, EventArgs e)
            {
                  CreateHiddenFolder("tmp");
                  txt_customcommand.Select();
                  callADB_wo("", "start-server");

                  //Check Status
                  while (true)
                  {
                        IsRunning();
                        await Task.Delay(500);
                  }

            }

            private void btn_phoneinformation_getprop_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\prop.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell getprop >> " + file);
                  CallViewer(file, "Properties");
            }

            private void btn_phoneinformation_installedpackages_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\all_packages.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell pm list packages -f >" + file);
                  CallViewer(file, "All Packages");
            }

            private void btn_phoneinformation_logcat_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\logcat.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "logcat -d> " + file);
                  CallViewer(file, "Logcat Dump");
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
                  string s = txt_phoneinformation_mac.Text;
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
                  string file = "tmp\\macadress.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell cat /sys/class/net/wlan0/address > " + file);
                  CallViewer(file, "MAC Adress", 280, 110);
            }

            private void btn_phoneinformation_dumpsys_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\dumpsys.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell dumpsys > " + file);
                  CallViewer(file, "Dumpsys Input Diagnostics", 850, 600, FormWindowState.Maximized);
            }

            private void btn_phoneinformation_meminfo_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\meminfo.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell dumpsys meminfo > " + file);
                  CallViewer(file, "Memory");
            }

            private void btn_phoneinformation_processes_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\processes.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell ps > " + file);
                  CallViewer(file, "Processes");
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
                  string s = "\"" + txt_packages_path.Text + "\"";

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
                  string s = "\"" + txt_packages_package.Text + "\"";
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
                  string file = "tmp\\installed_packages.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell \"pm list packages -3 | cut -c9- | sort\" > " + file);
                  CallViewer(file, "Installed Packages", 500, 750);
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
                        string s = "pull \"" + txt_pull_pathfrom.Text + "\"" + " \"" + txt_pull_pathto.Text + "\"";
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
                  string file = "tmp\\phone_features.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell pm list features > " + file);
                  CallViewer(file, "Phone Features");
            }

            private void btn_phoneinformation_libraries_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\libraries.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell pm list libraries > " + file);
                  CallViewer(file, "Libraries", 500, 400);
            }

            private void btn_phoneinformation_users_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\alluser.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell pm list users > " + file);
                  CallViewer(file, "All User", 600, 250);
            }

            private void btn_phoneinformation_maxusers_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\maxuser.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell pm get-max-users > " + file);
                  CallViewer(file, "Max User", 600, 250);
            }

            private void btn_phoneinformation_permissions_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\permissions.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell pm list permissions > " + file);
                  CallViewer(file, "Permissions", 700);
            }

            private void btn_phoneinformation_getimei_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\imei.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell service call iphonesubinfo 1 > " + file);
                  CallViewer(file, "IMEI", 550, 150);
            }

            private void btn_phoneinformation_dmesg_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\dmesg.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell dmesg > " + file);
                  CallViewer(file, "Kernel Messages", 850, 600, FormWindowState.Maximized);
            }

            private void btn_shutdown_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "shell reboot -p");
            }

            private void btn_phoneinformation_battery_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\batterystats.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell dumpsys battery > " + file);
                  CallViewer(file, "Battery Stats", 280, 350);
            }

            private void btn_phoneinformation_wifiinfo_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\wifiinfo.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell dumpsys wifi > " + file);
                  CallViewer(file, "WIFI Information", 850, 600, FormWindowState.Maximized);
            }

            private void btn_phoneinformation_cpuinfo_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\cpuinfo.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell dumpsys cpuinfo > " + file);
                  CallViewer(file, "CPU Information", 750, 500);
            }

            private void btn_phoneinformation_accounts_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\accounts.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell dumpsys account > " + file);
                  CallViewer(file, "Accounts", 1500);
            }

            private void btn_backup_backup_Click(object sender, EventArgs e)
            {
                  string name = " -f \"" + txt_backup_path.Text + "\"";
                  string apk = " -noapk";
                  string shared = " -noshared";
                  string all = " -all";
                  string system = " -system";
                  string package = txt_backup_packagename.Text;


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
                  string file = "tmp\\diskstats.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell dumpsys diskstats > " + file);
                  CallViewer(file, "Diskstats", 600, 350);
            }

            private void btn_phoneinformation_netstat_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\netstat.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell busybox netstat > " + file);
                  CallViewer(file, "Netstat", 950, 700);
            }

            private void btn_phoneinformation_uptime_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\uptime.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell uptime > " + file);
                  CallViewer(file, "Netstat", 700, 250);
            }

            private void btn_donate_Click(object sender, EventArgs e)
            {
                  string url = "";

                  string business = "laboo.lm@gmail.com"; // your paypal email
                  string description = "Donation"; // '%20' represents a space. remember HTML!
                  string country = "DE"; // AU, US, etc.
                  string currency = "EUR"; // AUD, USD, etc.

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
                  string file = "tmp\\dpi.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell wm density> " + file);
                  CallViewer(file, "DPI", 280, 110);
            }

            private async void btn_phoneinformation_changedpi_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "shell wm density " + txt_phoneinformation_dpi.Text);
                  await Task.Delay(500);
                  callADB_wo("", "reboot");
            }

            private async void btn_phoneinformation_resetdpi_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "shell wm density reset");
                  await Task.Delay(500);
                  callADB_wo("", "reboot");
            }

            private void btn_connect_Click(object sender, EventArgs e)
            {
                  string s = "";
                  s = @txt_ip.Text.ToString();
                  if (s == "")
                  {
                        MessageBox.Show("Please type in IP and port!", "Error");
                  }
                  else
                  {
                        callADB_w("connect " + s);
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
                  string file = "tmp\\resolution.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell wm size> " + file);
                  CallViewer(file, "Resolution", 280, 110);
            }

            private void button6_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "shell wm size reset");
            }

            private void btn_phoninformation_hosts_Click(object sender, EventArgs e)
            {

                  string file = "tmp\\hosts.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell cat /etc/hosts> " + file);
                  CallViewer(file, "Hosts", 750);

            }

            private void btn_phoneinformation_activities_Click(object sender, EventArgs e)
            {
                  string file = "tmp\\activities.txt";
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell dumpsys activity> " + file);
                  CallViewer(file, "Activities");


            }

            private void btn_phoneinformation_screenshot_Click(object sender, EventArgs e)
            {
                  Process proc = new Process();
                  proc.StartInfo.FileName = "tools\\screenshot.bat";
                  proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                  proc.Start();
                  while (proc.HasExited == false)
                  {
                        Cursor = Cursors.WaitCursor;
                  }
                  Cursor = Cursors.Default;

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

      }
}