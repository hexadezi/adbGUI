using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
                  _adbMethods = new adbMethods(this);

                  var printDevices = new Thread(AdbMethods.DevicesToTxtBox);
                  printDevices.IsBackground = true;
                  printDevices.Start();

                  var checkStatus = new Thread(AdbMethods.IsRunning);
                  checkStatus.IsBackground = true;
                  checkStatus.Start();

                  txt_customcommand.Select();
            }

            public adbMethods AdbMethods
            {
                  get { return _adbMethods; }
            }

            //Exit with escape
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                  if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
                  Close();
                  return true;
            }

            private Form _rebootmenu;
            private readonly adbMethods _adbMethods;

            private void btn_reboot_Click(object sender, EventArgs e)
            {
                  if ((_rebootmenu == null) || (_rebootmenu.IsDisposed))
                  {
                        _rebootmenu = new RebootMenu();
                  }
                  _rebootmenu.Show();
                  _rebootmenu.Focus();
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
                        AdbMethods.callADB_w(s);
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
                        AdbMethods.callADB_w(s);
                  }
            }

            private void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                  Thread tr = new Thread(AdbMethods.KillServer);
                  tr.IsBackground = true;
                  tr.Start(); 
                  Application.Exit();
                  Environment.Exit(0);
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
                        AdbMethods.callADB_w(s);
                  }
            }

            private void btn_openshell_Click(object sender, EventArgs e)
            {
                  AdbMethods.callADB_w("shell");
            }

            private void btn_phoneinformation_getprop_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell getprop", "Properties");
            }

            private void btn_phoneinformation_installedpackages_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell \"pm list packages -f | cut -c9- | sort\"", "All Packages");
            }

            private void btn_phoneinformation_logcat_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell logcat -d", "Logcat Dump", 850, 600, FormWindowState.Maximized);
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
                        AdbMethods.callADB_wo("", "shell su root busybox ifconfig wlan0 hw ether " + txt_phoneinformation_mac.Text);
                  }
            }

            private async void button2_Click(object sender, EventArgs e)
            {
                  AdbMethods.callADB_wo("", "shell su root busybox ifconfig wlan0 down");
                  await Task.Delay(200);
                  AdbMethods.callADB_wo("", "shell su root busybox ifconfig wlan0 up");
            }

            private void btn_phoneinformation_showmac_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell cat /sys/class/net/wlan0/address", "MAC Adress", 280, 110);
            }

            private void btn_phoneinformation_dumpsys_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell dumpsys", "Dumpsys Input Diagnostics", 850, 600, FormWindowState.Maximized);
            }

            private void btn_phoneinformation_meminfo_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell dumpsys meminfo", "Memory Information");
            }

            private void btn_phoneinformation_processes_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell ps", "Processes");
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
                        AdbMethods.callADB_w("install " + s);
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
                        AdbMethods.callADB_w("uninstall " + s);
                  }
                  else
                  {
                        MessageBox.Show("Please select a Package!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
            }

            private void btn_packages_installed_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell \"pm list packages -3 | cut -c9- | sort\"", "Installed Packages", 500, 750);
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
                        AdbMethods.callADB_w(s);
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
                  AdbMethods.callADB_w("version");
            }

            private void button4_Click(object sender, EventArgs e)
            {
                  AdbMethods.callADB_w("help");
            }

            private void btn_phoneinformation_features_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell \"pm list features | cut -c9- | sort\"", "Phone Features");
            }

            private void btn_phoneinformation_libraries_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell pm list libraries", "Libraries", 500, 400);
            }

            private void btn_phoneinformation_users_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell pm list users", "All User", 600, 250);
            }

            private void btn_phoneinformation_maxusers_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell pm get-max-users", "Max User", 600, 250);
            }

            private void btn_phoneinformation_permissions_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell pm list permissions", "Permissions", 700);
            }

            private void btn_phoneinformation_getimei_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell service call iphonesubinfo 1", "IMEI", 550, 130);
            }

            private void btn_phoneinformation_dmesg_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell dmesg", "Kernel Messages", 850, 600, FormWindowState.Maximized);
            }

            private void btn_phoneinformation_battery_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell dumpsys battery", "Battery Stats", 280, 300);
            }

            private void btn_phoneinformation_wifiinfo_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell dumpsys wifi", "WIFI Information", 850, 600, FormWindowState.Maximized);
            }

            private void btn_phoneinformation_cpuinfo_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell dumpsys cpuinfo", "CPU Information", 750, 500);
            }

            private void btn_phoneinformation_accounts_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell dumpsys account", "Accounts", 1500);
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

                        AdbMethods.callADB_w("backup" + apk + shared + all + system + name);
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
                              AdbMethods.callADB_w("backup -apk " + package + name);
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
                        AdbMethods.callADB_w("restore \"" + txt_restore_path.Text + "\"");
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
                  AdbMethods.GetInformation("", "shell dumpsys diskstats", "Diskstats", 600, 350);
            }

            private void btn_phoneinformation_netstat_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell busybox netstat", "Netstat", 950, 700);
            }

            private void btn_phoneinformation_uptime_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell uptime", "Uptime", 550, 100);
            }

            private void btn_donate_Click(object sender, EventArgs e)
            {
                  var url = "";

                  const string business = "laboo.lm@gmail.com"; // your paypal email
                  const string description = "Donation"; // '%20' represents a space. remember HTML!
                  const string country = "DE"; // AU, US, etc.
                  const string currency = "EUR"; // AUD, USD, etc.

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
                  AdbMethods.GetInformation("", "shell wm density", "Density", 280, 110);
            }

            private void btn_phoneinformation_changedpi_Click(object sender, EventArgs e)
            {
                  AdbMethods.callADB_wo("", "shell wm density " + txt_phoneinformation_dpi.Text + "&& tools\\adb reboot");
            }

            private void btn_phoneinformation_resetdpi_Click(object sender, EventArgs e)
            {
                  AdbMethods.callADB_wo("", "shell wm density reset && tools\\adb reboot");
            }

            private void btn_connect_Click(object sender, EventArgs e)
            {
                  var tr = new Thread(AdbMethods.ConnectWifi);
                  tr.IsBackground = true;
                  tr.Start();
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
                  AdbMethods.callADB_wo("", "shell wm size " + txt_phoneinformation_resolution.Text);
            }

            private void button7_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell wm size", "Resolution", 280, 110);
            }

            private void button6_Click(object sender, EventArgs e)
            {
                  AdbMethods.callADB_wo("", "shell wm size reset");
            }

            private void btn_phoninformation_hosts_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell cat /etc/hosts", "Hosts", 750);
            }

            private void btn_phoneinformation_activities_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell dumpsys activity", "Activities");
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
                  AdbMethods.callADB_wo("", "remount");
            }

            private void btnAlarm_Click(object sender, EventArgs e)
            {
                  AdbMethods.GetInformation("", "shell dumpsys alarm", "Current Alarm Manager State", 950);
            }

            private void btnKillserver_Click(object sender, EventArgs e)
            {
                  Thread tr = new Thread(AdbMethods.KillServer);
                  tr.IsBackground = true;
                  tr.Start();
                  cbSerials.Items.Clear();
            }

            private void button5_Click_1(object sender, EventArgs e)
            {
                  Thread tr = new Thread(AdbMethods.DisconnectWifi);
                  tr.IsBackground = true;
                  tr.Start();
            }

            private void txt_devices_TextChanged(object sender, EventArgs e)
            {
                  Thread tr = new Thread(AdbMethods.SerialnumberToComboBox);
                  tr.IsBackground = true;
                  tr.Start();
            }
      }
}