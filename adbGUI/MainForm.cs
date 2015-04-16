using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
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
                  int maxTries = 200;

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
                                    MessageBox.Show("Is your device connected?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                  string arguments = " /C prompt $g & tools\\adb " + x + " & echo. & pause";
                  ProcessStartInfo startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        WindowStyle = ProcessWindowStyle.Normal,
                        Arguments = arguments
                  };
                  Process process = new Process { StartInfo = startInfo };
                  process.Start();

                  ListViewItem lvi = new ListViewItem(DateTime.Now.ToString("h:mm:ss tt"));
                  lvi.SubItems.Add(filename + " " + arguments);
                  listView1.Items.Add(lvi);
            }

            public void callADB_wo(string x, string y)
            {
                  string filename = "cmd.exe";
                  string arguments = "/C " + x + " tools\\adb " + y;
                  ProcessStartInfo startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        WindowStyle = ProcessWindowStyle.Hidden
                  };

                  Process process = new Process { StartInfo = startInfo };

                  process.Start();

                  ListViewItem lvi = new ListViewItem(DateTime.Now.ToString("h:mm:ss tt"));
                  lvi.SubItems.Add(filename + " " + arguments);
                  listView1.Items.Add(lvi);
            }

            public void AddToLog(string x)
            {


            }

            private void btn_startserver_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "start-server");
            }

            private void btn_killserver_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "kill-server");
            }

            private void btn_reboot_Click(object sender, EventArgs e)
            {
                  RebootMenu rebootmenu = new RebootMenu();
                  rebootmenu.Show();
            }

            private void btn_rebootrecovery_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "reboot recovery");
            }

            private void btn_rebootbootloader_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "reboot bootloader");
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
                  callADB_w("devices -l");
            }

            private async void btn_restartserver_Click(object sender, EventArgs e)
            {
                  callADB_wo("", "kill-server");
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

            private void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                  Directory.Delete("tmp", true);
                  callADB_wo("", "kill-server");
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
            private void Form1_Load(object sender, EventArgs e)
            {
                  CreateHiddenFolder("tmp");
                  txt_customcommand.Select();
                  callADB_wo("", "start-server");
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
                  callADB_wo("mkdir tmp & del " + file + " & ", "shell pm list packages -3 > " + file);
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

            //private void button_Click(object sender, EventArgs e)
            //{
            //      switch((Button)sender)
            //      {
            //            case sender.Equals(button1):

            //      }
            //}

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
                  callADB_w("shell pm list users");
            }

            private void btn_phoneinformation_maxusers_Click(object sender, EventArgs e)
            {
                  callADB_w("shell pm get-max-users");
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
                  callADB_w("shell uptime");
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
                  string s = txt_ip.Text;
                  if (s == "")
                  {
                        MessageBox.Show("Please type in IP and port!", "Error");
                  }
                  else
                  {
                        callADB_w("connect " + txt_ip.Text);
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