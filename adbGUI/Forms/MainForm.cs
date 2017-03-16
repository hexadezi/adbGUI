using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Linq;

namespace adbGUI
{
    public partial class MainForm : Form
    {
        private Form _rebootmenu;
        public MainForm()
        {
            InitializeComponent();
            txt_customcommand.Select();

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


        //Refresh cbserials
        private void RefreshCBserials()
        {
            cbSerials.Invoke((MethodInvoker)(() => cbSerials.Items.Clear()));

            foreach (var item in StandardIO.GetDevices())
            {
                cbSerials.Invoke((MethodInvoker)(() => cbSerials.Items.Add(item)));
            }
            cbSerials.Invoke((MethodInvoker)(() => cbSerials.SelectedIndex = cbSerials.Items.Count - 1));
        }

        private void RefreshInformationTextbox()
        {
            while (true)
            {
                string s = null;

                Thread tr = new Thread(() => { s = StandardIO.AdbCMDBackground("", "devices -l"); });
                tr.Start();
                tr.Join();

                txt_devices.Invoke((MethodInvoker)(() => txt_devices.Text = s.ToUpper()));
                Thread.Sleep(1000);
            }

        }

        private void RefreshRestartButtonColor()
        {
            while (true)
            {
                if (Process.GetProcessesByName("adb").Length > 0)
                {
                    btnKillserver.Invoke((MethodInvoker)(() => btnKillserver.ForeColor = Color.ForestGreen));
                }

                else
                {
                    btnKillserver.Invoke((MethodInvoker)(() => btnKillserver.ForeColor = Color.Red));
                    txt_devices.Invoke((MethodInvoker)(() => txt_devices.Text = "STARTING SERVER..."));
                }

                Thread.Sleep(1100);
            }


        }

        private string GetSelectedSerialnumber()
        {
            if (cbSerials.Items.Count == 0)
            {
                return "";
            }
            else
            {
                return cbSerials.SelectedItem.ToString();

            }
        }

        private void GetInstalledApps(string serial)
        {
            cbInstalledApps.Invoke((MethodInvoker)(() => { cbInstalledApps.Items.Clear(); }));

            string output = null;

            output = StandardIO.AdbCMDBackground("", "shell \"pm list packages -3 | cut -c9- | sort\"", " -s " + serial);

            foreach (var item in output.Split(new string[] { "\r\r\n", }, StringSplitOptions.RemoveEmptyEntries))
            {
                cbInstalledApps.Invoke((MethodInvoker)(() => { cbInstalledApps.Items.Add(item); }));
            }



        }

        private void RefreshInstalledAps()
        {
            if (cbSerials.SelectedItem != null)
            {
                cbInstalledApps.Enabled = false;
                string serial = GetSelectedSerialnumber();
                Thread thr = new Thread(() => { GetInstalledApps(serial); });

                thr.IsBackground = true;

                thr.Start();

                while (thr.IsAlive)
                {
                    Application.DoEvents();
                }
                cbInstalledApps.Enabled = true;
                try
                {
                    cbInstalledApps.SelectedIndex = 0;
                }
                catch (Exception)
                {

                    //throw;
                }
            }
        }

        //Get all the information
        private void GetInformationAndOpenViewer(string a, string b, string titel, int width = 850, int height = 606, FormWindowState windowstate = FormWindowState.Normal)
        {
            if (cbSerials.SelectedItem != null)
            {
                string serial = GetSelectedSerialnumber();

                Thread thr = new Thread(() => { ToViewer(StandardIO.AdbCMDBackground("", b, " -s " + serial), titel, width, height, windowstate); });

                thr.IsBackground = true;

                thr.Start();

                while (thr.IsAlive)
                {
                    groupBox11.Enabled = false;
                    tabControl1.Enabled = false;
                    Application.DoEvents();
                    //Cursor = Cursors.AppStarting;
                }
                groupBox11.Enabled = true;
                tabControl1.Enabled = true;
                //Cursor = Cursors.Default;

            }
            else
            {
                StandardIO.NoDeviceConnected();
            }

        }

        //Opens the textviewer
        private void ToViewer(string value, string title, int x, int y, FormWindowState windowstate = FormWindowState.Normal)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, string, int, int, FormWindowState>(ToViewer), value, title, x, y,
                      windowstate);
                return;
            }


            var v = new Viewer();

            //v.txt_output.TabIndex = 3;
            v.Text = title;
            v.WindowState = windowstate;
            v.Width = x;
            v.Height = y;
            v.Show();
            v.txt_output.Text = value;

        }




        //--------------------------------------------------------------------------------------------------
        //-------------------Windows Forms------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"tools\adb.exe"))
            {
                Thread refreshinformationtextbox = new Thread(RefreshInformationTextbox);
                refreshinformationtextbox.IsBackground = true;

                if (!refreshinformationtextbox.IsAlive)
                {
                    refreshinformationtextbox.Start();
                }

                Thread refreshrestartbuttoncolor = new Thread(RefreshRestartButtonColor);
                refreshrestartbuttoncolor.IsBackground = true;

                if (!refreshrestartbuttoncolor.IsAlive)
                {
                    refreshrestartbuttoncolor.Start();
                }
            }

            else
            {
                MessageBox.Show("adb.exe not found. Make soure adbGUI.exe is in the tools folder.", "Error - adb.exe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void btn_reboot_Click(object sender, EventArgs e)
        {
            _rebootmenu = new RebootMenu();
            _rebootmenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
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
                StandardIO.AdbCMD(s, " -s " + GetSelectedSerialnumber());
            }
            else
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_push_openfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = " "; //This is not a normal whitespace. ALT + 255
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.ValidateNames = false;
            openFileDialog1.Filter = "All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if (openFileDialog1.SafeFileName == " ") //This is not a normal whitespace. ALT + 255
                {
                    txt_push_fromfilepath.Text =
                          openFileDialog1.FileName.Remove(openFileDialog1.FileName.Length - 2, 2);
                }
                else
                {
                    txt_push_fromfilepath.Text = openFileDialog1.FileName;
                }
            }
        }

        private void btn_push_push_Click(object sender, EventArgs e)
        {
            if (txt_push_fromfilepath.Text == "" || txt_push_tofilepath.Text == "")
            {
                MessageBox.Show("Please select a file and chose destination!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var s = "push \"" + txt_push_fromfilepath.Text + "\"" + " \"" + txt_push_tofilepath.Text + "\"";
                StandardIO.AdbCMD(s, " -s " + GetSelectedSerialnumber());
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            var s = txt_customcommand.Text;
            if (s == "")
            {
                MessageBox.Show("Please enter a command!", "Error");
            }
            else
            {
                StandardIO.AdbCMD(@s, " -s " + GetSelectedSerialnumber());
            }
        }

        private void btn_openshell_Click(object sender, EventArgs e)
        {
            StandardIO.AdbCMD("shell", " -s " + GetSelectedSerialnumber());
        }

        private void btn_phoneinformation_getprop_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell getprop", "Properties");
        }

        private void btn_phoneinformation_installedpackages_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell \"pm list packages -f | cut -c9- | sort\"", "All Packages");
        }

        private void btn_phoneinformation_logcat_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell logcat -d", "Logcat Dump", 850, 600, FormWindowState.Maximized);
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

            var r = new Regex(@"(([a-f]|[0-9]|[A-F]){2}\:){5}([a-f]|[0-9]|[A-F]){2}\b");

            if (r.Match(s).Success)
            {
                string serial = GetSelectedSerialnumber();

                Thread thr = new Thread(() => { StandardIO.AdbCMDBackgroundNoReturn("", "shell su root busybox ifconfig wlan0 hw ether " + s, "-s " + serial); });

                thr.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid MAC address", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string serial = GetSelectedSerialnumber();

            Thread thr = new Thread(() => { StandardIO.AdbCMDBackgroundNoReturn("", "shell su root busybox ifconfig wlan0 down", " -s " + serial); });
            thr.Start();

            Thread thr2 = new Thread(() => { StandardIO.AdbCMDBackground("", "shell su root busybox ifconfig wlan0 up", " -s " + serial); });
            thr2.Start();

        }

        private void btn_phoneinformation_showmac_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell cat /sys/class/net/wlan0/address", "MAC Adress", 280, 110);
        }

        private void btn_phoneinformation_dumpsys_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell dumpsys", "Dumpsys Input Diagnostics", 850, 600, FormWindowState.Maximized);
        }

        private void btn_phoneinformation_meminfo_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell dumpsys meminfo", "Memory Information");
        }

        private void btn_phoneinformation_processes_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell ps", "Processes");
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
            string serial = " -s " + GetSelectedSerialnumber();

            if (txt_packages_path.Text != "")
            {
                //StandardIO.AdbCMD("install " + s, " -s " + GetSelectedSerialnumber());


                string output = null;
                groupBox11.Enabled = false;
                tabControl1.Enabled = false;

                ThreadStart starter = () => { output = StandardIO.AdbCMDBackground("", "install " + s, serial); };
                starter += () =>
                {
                    groupBox11.Invoke((MethodInvoker)(() => groupBox11.Enabled = true));
                    tabControl1.Invoke((MethodInvoker)(() => tabControl1.Enabled = true));
                    MessageBox.Show(output, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                Thread thread = new Thread(starter) { IsBackground = true };

                thread.Start();

                while (thread.IsAlive)
                {
                    Application.DoEvents();
                }
                RefreshInstalledAps();

            }
            else
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_packages_uninstall_Click(object sender, EventArgs e)
        {
            var s = "\"" + cbInstalledApps.SelectedItem + "\"";

            string serial = " -s " + GetSelectedSerialnumber();

            string output = null;

            groupBox11.Enabled = false;
            tabControl1.Enabled = false;
            ThreadStart starter = () => { output = StandardIO.AdbCMDBackground("", "uninstall " + s, serial); };

            starter += () =>
            {
                groupBox11.Invoke((MethodInvoker)(() => groupBox11.Enabled = true));
                tabControl1.Invoke((MethodInvoker)(() => tabControl1.Enabled = true));

                MessageBox.Show(output, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            };

            Thread thread = new Thread(starter) { IsBackground = true };

            thread.Start();

            while (thread.IsAlive)
            {
                Application.DoEvents();
            }
            RefreshInstalledAps();

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
                StandardIO.AdbCMD(s, " -s " + GetSelectedSerialnumber());
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
            StandardIO.AdbCMD("version", " - s" + GetSelectedSerialnumber());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StandardIO.AdbCMD("help", " -s " + GetSelectedSerialnumber());
        }

        private void btn_phoneinformation_features_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell \"pm list features | cut -c9- | sort\"", "Phone Features");
        }

        private void btn_phoneinformation_libraries_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell pm list libraries", "Libraries", 500, 400);
        }

        private void btn_phoneinformation_users_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell pm list users", "All User", 600, 250);
        }

        private void btn_phoneinformation_maxusers_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell pm get-max-users", "Max User", 600, 250);
        }

        private void btn_phoneinformation_permissions_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell pm list permissions", "Permissions", 700);
        }

        private void btn_phoneinformation_getimei_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell service call iphonesubinfo 1", "IMEI", 550, 130);
        }

        private void btn_phoneinformation_dmesg_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell dmesg", "Kernel Messages", 850, 600, FormWindowState.Maximized);
        }

        private void btn_phoneinformation_battery_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell dumpsys battery", "Battery Stats", 280, 300);
        }

        private void btn_phoneinformation_wifiinfo_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell dumpsys wifi", "WIFI Information", 850, 600, FormWindowState.Maximized);
        }

        private void btn_phoneinformation_cpuinfo_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell dumpsys cpuinfo", "CPU Information", 750, 500);
        }

        private void btn_phoneinformation_accounts_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell dumpsys account", "Accounts", 1500);
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
                    StandardIO.AdbCMD("backup" + apk + shared + all + system + name, " -s " + GetSelectedSerialnumber());
                }

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
                    StandardIO.AdbCMD("backup -apk " + package + name, " -s " + GetSelectedSerialnumber());
                }
            }
        }

        private void btn_backup_saveto_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "backup_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '.');
            saveFileDialog1.Filter = " .ab|*.ab";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_backup_path.Text = saveFileDialog1.FileName;
            }
        }

        private void btn_restore_openfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
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
                StandardIO.AdbCMD("restore \"" + txt_restore_path.Text + "\"", " -s " + GetSelectedSerialnumber());
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
                txt_backup_path.Size = new Size(251, 20);
            }
            else
            {
                cb_backup_nosystem.Enabled = true;
                cb_backup_shared.Enabled = true;
                label8.Visible = false;
                txt_backup_packagename.Visible = false;
                txt_backup_path.Size = new Size(444, 20);
                cb_backup_withapk.Enabled = true;
                txt_backup_packagename.Text = "";
            }
        }

        private void btn_phoneinformation_diskstats_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell dumpsys diskstats", "Diskstats", 600, 350);
        }

        private void btn_phoneinformation_netstat_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell busybox netstat", "Netstat", 950, 700);
        }

        private void btn_phoneinformation_uptime_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell uptime", "Uptime", 550, 100);
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
            GetInformationAndOpenViewer("", "shell wm density", "Density", 280, 110);
        }

        private void btn_phoneinformation_changedpi_Click(object sender, EventArgs e)
        {
            StandardIO.AdbCMDBackground("", "shell wm density " + txt_phoneinformation_dpi.Text + "&& tools\\adb reboot");
        }

        private void btn_phoneinformation_resetdpi_Click(object sender, EventArgs e)
        {
            StandardIO.AdbCMDBackground("", "shell wm density reset && tools\\adb reboot");
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {

            var r = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");

            string ipadress = @txt_ip.Text;

            if (r.Match(ipadress).Success)
            {
                string output = null;
                groupBox11.Enabled = false;
                tabControl1.Enabled = false;

                ThreadStart starter = () => { output = StandardIO.AdbCMDBackground("", "connect " + ipadress, ""); };
                starter += () =>
                {
                    groupBox11.Invoke((MethodInvoker)(() => groupBox11.Enabled = true));
                    tabControl1.Invoke((MethodInvoker)(() => tabControl1.Enabled = true));

                    MessageBox.Show(output, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                Thread thread = new Thread(starter) { IsBackground = true };

                thread.Start();

            }
            else
            {
                MessageBox.Show("Please enter a valid IP adress", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string serial = GetSelectedSerialnumber();

            Thread thr = new Thread(() => { StandardIO.AdbCMDBackgroundNoReturn("", "shell wm size " + txt_phoneinformation_resolution.Text, " -s " + serial); });
            thr.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell wm size", "Resolution", 280, 110);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string serial = GetSelectedSerialnumber();

            Thread thr = new Thread(() => { StandardIO.AdbCMDBackgroundNoReturn("", "shell wm size reset", " -s " + serial); });
            thr.Start();
        }

        private void btn_phoninformation_hosts_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell cat /etc/hosts", "Hosts", 750);
        }

        private void btn_phoneinformation_activities_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell dumpsys activity", "Activities");
        }

        private void btn_phoneinformation_screenshot_Click(object sender, EventArgs e)
        {
            var proc = new Process();

            proc.StartInfo.FileName = "tools\\screenshot.bat";

            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            proc.Start();

            while (proc.HasExited == false)
            {
                groupBox11.Enabled = false;
                tabControl1.Enabled = false;

                //Cursor = Cursors.WaitCursor;
            }
            groupBox11.Enabled = true;
            tabControl1.Enabled = true;
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
            StandardIO.AdbCMDBackgroundNoReturn("", "remount");
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            GetInformationAndOpenViewer("", "shell dumpsys alarm", "Current Alarm Manager State", 950);
        }

        private void btnKillserver_Click(object sender, EventArgs e)
        {
            Thread tr = new Thread(StandardIO.KillServer);
            tr.IsBackground = true;
            tr.Start();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            groupBox11.Enabled = false;
            tabControl1.Enabled = false;

            ThreadStart starter = () => { StandardIO.AdbCMDBackground("", "disconnect", ""); };
            starter += () =>
            {
                groupBox11.Invoke((MethodInvoker)(() => groupBox11.Enabled = true));
                tabControl1.Invoke((MethodInvoker)(() => tabControl1.Enabled = true));
                MessageBox.Show("Successfully disconnected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            Thread thread = new Thread(starter) { IsBackground = true };

            thread.Start();
        }

        private void txt_devices_TextChanged(object sender, EventArgs e)
        {
            Thread tr = new Thread(RefreshCBserials);
            if (!tr.IsAlive)
            {
                tr.Start();
            }
        }

        private void cbSerials_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshInstalledAps();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);

        }

        private void btn_refreshInstalledApps_Click(object sender, EventArgs e)
        {
            RefreshInstalledAps();
        }

        private void btnPushDestinationLS_Click(Object sender, EventArgs e)
        {
            string path = txt_push_tofilepath.Text;
            List<string> resultList = StandardIO.AdbCMDBackground("", "shell ls \"" + path + "\" -F").Split(Environment.NewLine.ToCharArray()).ToList();
            resultList = FixFileListing(resultList);
            MessageBox.Show(string.Join(Environment.NewLine, resultList), "File Listing");
        }

        private void btnPullDestinationLS_Click(Object sender, EventArgs e)
        {
            string path = txt_pull_pathfrom.Text;
            List<string> resultList = StandardIO.AdbCMDBackground("", "shell ls \"" + path + "\" -F").Split(Environment.NewLine.ToCharArray()).ToList();
            resultList = FixFileListing(resultList);
            MessageBox.Show(string.Join(Environment.NewLine, resultList), "File Listing");
        }

        private List<string> FixFileListing(List<string> inputList)
        {
            inputList = inputList.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            inputList = inputList.Where(x => !x.EndsWith("Permission denied")).ToList();
            if (inputList.Count == 1 && inputList[0].EndsWith("No such file or directory"))
            {
                return inputList;
            }
            else
            // Clean the results
            {
                for (int j = 0; j < inputList.Count; j++)
                {
                    string part1 = inputList[j].Split(' ')[0];
                    string part2 = inputList[j].Remove(0, part1.Length);
                    if (part1 == "d")
                    {
                        inputList[j] = "Directory: " + part2;
                    }
                    else
                    {
                        inputList[j] = "File: " + part2;
                    }
                }
            }
            return inputList;
        }
    }
}