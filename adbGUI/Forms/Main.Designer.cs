namespace adbGUI
{
      partial class MainForm
      {
            /// <summary>
            /// Erforderliche Designervariable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Verwendete Ressourcen bereinigen.
            /// </summary>
            /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
            protected override void Dispose(bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose();
                  }
                  base.Dispose(disposing);
            }

            #region Vom Windows Form-Designer generierter Code

            /// <summary>
            /// Erforderliche Methode für die Designerunterstützung.
            /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
            /// </summary>
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer;
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Files");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Sideload");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("All User");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Max User");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("IMEI");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Accounts");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Backup Restore");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Screenshot");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Screenrecord");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Resolution");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Density");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode84,
            treeNode85,
            treeNode86,
            treeNode87});
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Shutdown");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Reboot Recovery");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Reboot Fastboot");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Sideload Mode");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Sleep Mode");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Power", new System.Windows.Forms.TreeNode[] {
            treeNode89,
            treeNode90,
            treeNode91,
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Get Prop");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Set Prop");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode97,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Battery Service State");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode102,
            treeNode103,
            treeNode104});
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Remount System");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode99,
            treeNode100,
            treeNode101,
            treeNode105,
            treeNode106,
            treeNode107,
            treeNode108,
            treeNode109,
            treeNode110,
            treeNode111,
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Network Info");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Spoof MAC");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode114,
            treeNode115,
            treeNode116,
            treeNode117,
            treeNode118,
            treeNode119});
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("Install and Uninstall");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode121,
            treeNode122,
            treeNode123,
            treeNode124});
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Dumpsys Input Diagnostics");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode130,
            treeNode131,
            treeNode132,
            treeNode133,
            treeNode134,
            treeNode135,
            treeNode136});
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode128,
            treeNode129,
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode126,
            treeNode127,
            treeNode138});
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("Devices");
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("Fastboot", new System.Windows.Forms.TreeNode[] {
            treeNode140,
            treeNode141,
            treeNode142,
            treeNode143,
            treeNode144});
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode146,
            treeNode147});
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("Credits");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            treeNode148,
            treeNode149});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txt_DevicesAdb = new System.Windows.Forms.TextBox();
            this.cbo_clearEverytime = new System.Windows.Forms.CheckBox();
            this.btn_executeCommand = new System.Windows.Forms.Button();
            this.trv_commandTreeView = new System.Windows.Forms.TreeView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbx_customCommand = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_consoleStop = new System.Windows.Forms.Button();
            this.btn_consoleClear = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsc_ConnectedDevices = new System.Windows.Forms.ToolStripComboBox();
            this.tsd_WirelessAdb = new System.Windows.Forms.ToolStripDropDownButton();
            this.tst_IpAdress = new System.Windows.Forms.ToolStripTextBox();
            this.tsm_WirelessConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_WirelessDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_KillServer = new System.Windows.Forms.ToolStripButton();
            this.tsb_OpenShell = new System.Windows.Forms.ToolStripButton();
            this.tsb_AdbRoot = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsb_AdbUnroot = new System.Windows.Forms.ToolStripButton();
            timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 200;
            timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // txt_DevicesAdb
            // 
            this.txt_DevicesAdb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DevicesAdb.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DevicesAdb.Location = new System.Drawing.Point(12, 555);
            this.txt_DevicesAdb.Multiline = true;
            this.txt_DevicesAdb.Name = "txt_DevicesAdb";
            this.txt_DevicesAdb.ReadOnly = true;
            this.txt_DevicesAdb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DevicesAdb.Size = new System.Drawing.Size(1009, 50);
            this.txt_DevicesAdb.TabIndex = 5;
            // 
            // cbo_clearEverytime
            // 
            this.cbo_clearEverytime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_clearEverytime.AutoSize = true;
            this.cbo_clearEverytime.BackColor = System.Drawing.SystemColors.Control;
            this.cbo_clearEverytime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbo_clearEverytime.Location = new System.Drawing.Point(904, 588);
            this.cbo_clearEverytime.Name = "cbo_clearEverytime";
            this.cbo_clearEverytime.Size = new System.Drawing.Size(98, 17);
            this.cbo_clearEverytime.TabIndex = 8;
            this.cbo_clearEverytime.Text = "Clear everytime";
            this.cbo_clearEverytime.UseVisualStyleBackColor = false;
            // 
            // btn_executeCommand
            // 
            this.btn_executeCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_executeCommand.Location = new System.Drawing.Point(786, 528);
            this.btn_executeCommand.Name = "btn_executeCommand";
            this.btn_executeCommand.Size = new System.Drawing.Size(75, 22);
            this.btn_executeCommand.TabIndex = 1;
            this.btn_executeCommand.Text = "Execute";
            this.btn_executeCommand.UseVisualStyleBackColor = true;
            this.btn_executeCommand.Click += new System.EventHandler(this.Btn_executeCommand_Click);
            // 
            // trv_commandTreeView
            // 
            this.trv_commandTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trv_commandTreeView.Location = new System.Drawing.Point(12, 39);
            this.trv_commandTreeView.Name = "trv_commandTreeView";
            treeNode76.Name = "Knoten0";
            treeNode76.Tag = "#files";
            treeNode76.Text = "Files";
            treeNode77.Name = "Knoten2";
            treeNode77.Tag = "#sideload";
            treeNode77.Text = "Sideload";
            treeNode78.Name = "Knoten15";
            treeNode78.Tag = "adb shell pm list users";
            treeNode78.Text = "All User";
            treeNode79.Name = "Knoten17";
            treeNode79.Tag = "adb shell pm get-max-users";
            treeNode79.Text = "Max User";
            treeNode80.Name = "Knoten19";
            treeNode80.Tag = "adb shell service call iphonesubinfo 1";
            treeNode80.Text = "IMEI";
            treeNode81.Name = "Knoten27";
            treeNode81.Tag = "adb shell dumpsys account";
            treeNode81.Text = "Accounts";
            treeNode82.Name = "Knoten3";
            treeNode82.Tag = "#backuprestore";
            treeNode82.Text = "Backup Restore";
            treeNode83.Name = "Knoten3";
            treeNode83.Text = "Phone";
            treeNode84.Name = "Knoten31";
            treeNode84.Tag = "#screenshot";
            treeNode84.Text = "Screenshot";
            treeNode84.ToolTipText = "Take a screenshot";
            treeNode85.Name = "Knoten0";
            treeNode85.Tag = "#screenrecord";
            treeNode85.Text = "Screenrecord";
            treeNode85.ToolTipText = "Record screen up to 3 minutes";
            treeNode86.Name = "Knoten1";
            treeNode86.Tag = "#resolution";
            treeNode86.Text = "Resolution";
            treeNode86.ToolTipText = "Change Resolution";
            treeNode87.Name = "Knoten2";
            treeNode87.Tag = "#density";
            treeNode87.Text = "Density";
            treeNode88.Name = "Knoten0";
            treeNode88.Text = "Display";
            treeNode89.Name = "Knoten1";
            treeNode89.Tag = "adb shell reboot -p";
            treeNode89.Text = "Shutdown";
            treeNode90.Name = "Knoten2";
            treeNode90.Tag = "adb reboot";
            treeNode90.Text = "Reboot Normal";
            treeNode91.Name = "Knoten3";
            treeNode91.Tag = "adb reboot bootloader";
            treeNode91.Text = "Reboot Bootloader";
            treeNode92.Name = "Knoten5";
            treeNode92.Tag = "adb reboot recovery";
            treeNode92.Text = "Reboot Recovery";
            treeNode93.Name = "Knoten0";
            treeNode93.Tag = "adb reboot fastboot";
            treeNode93.Text = "Reboot Fastboot";
            treeNode94.Name = "Knoten4";
            treeNode94.Tag = "adb reboot sideload";
            treeNode94.Text = "Sideload Mode";
            treeNode95.Name = "Knoten6";
            treeNode95.Tag = "adb shell input keyevent POWER";
            treeNode95.Text = "Sleep Mode";
            treeNode96.Name = "Knoten0";
            treeNode96.Text = "Power";
            treeNode97.Name = "Knoten4";
            treeNode97.Tag = "adb shell getprop";
            treeNode97.Text = "Get Prop";
            treeNode98.Name = "Knoten1";
            treeNode98.Tag = "#prop";
            treeNode98.Text = "Set Prop";
            treeNode99.Name = "Knoten0";
            treeNode99.Text = "Prop";
            treeNode100.Name = "Knoten8";
            treeNode100.Tag = "adb shell ps";
            treeNode100.Text = "Processes";
            treeNode101.Name = "Knoten9";
            treeNode101.Tag = "adb shell dumpsys meminfo";
            treeNode101.Text = "Memory";
            treeNode102.Name = "Knoten1";
            treeNode102.Tag = "adb shell dumpsys battery";
            treeNode102.Text = "Battery Service State";
            treeNode103.Name = "Knoten2";
            treeNode103.Tag = "adb shell dumpsys batterystats";
            treeNode103.Text = "Collected Battery Stats";
            treeNode104.Name = "Knoten3";
            treeNode104.Tag = "adb shell dumpsys batterystats --reset";
            treeNode104.Text = "Reset Battery Stats";
            treeNode105.Name = "Knoten22";
            treeNode105.Tag = "";
            treeNode105.Text = "Battery";
            treeNode106.Name = "Knoten12";
            treeNode106.Tag = "adb shell dumpsys alarm";
            treeNode106.Text = "Alarm Manager State";
            treeNode107.Name = "Knoten16";
            treeNode107.Tag = "adb shell uptime";
            treeNode107.Text = "Uptime";
            treeNode108.Name = "Knoten24";
            treeNode108.Tag = "adb shell dumpsys cpuinfo";
            treeNode108.Text = "CPU Info";
            treeNode109.Name = "Knoten26";
            treeNode109.Tag = "adb shell dumpsys diskstats";
            treeNode109.Text = "Diskstats";
            treeNode110.Name = "Knoten28";
            treeNode110.Tag = "adb shell pm list permissions";
            treeNode110.Text = "Permissions";
            treeNode111.Name = "Knoten0";
            treeNode111.Tag = "adb shell df -h";
            treeNode111.Text = "Filesystem";
            treeNode112.Name = "Knoten0";
            treeNode112.Tag = "adb remount";
            treeNode112.Text = "Remount System";
            treeNode113.Name = "Knoten0";
            treeNode113.Text = "System";
            treeNode114.Name = "Knoten7";
            treeNode114.Tag = "adb shell iftop";
            treeNode114.Text = "Network Traffic";
            treeNode115.Name = "Knoten25";
            treeNode115.Tag = "adb shell netstat";
            treeNode115.Text = "Netstat";
            treeNode116.Name = "Knoten23";
            treeNode116.Tag = "adb shell dumpsys wifi";
            treeNode116.Text = "WiFi Info";
            treeNode117.Name = "Knoten29";
            treeNode117.Tag = "adb shell cat /etc/hosts";
            treeNode117.Text = "Hosts";
            treeNode118.Name = "Knoten0";
            treeNode118.Tag = "adb shell ifconfig";
            treeNode118.Text = "Network Info";
            treeNode119.Name = "Knoten3";
            treeNode119.Tag = "#spoofmac";
            treeNode119.Text = "Spoof MAC";
            treeNode120.Name = "Knoten1";
            treeNode120.Text = "Network";
            treeNode121.Name = "Knoten11";
            treeNode121.Tag = "adb shell pm list packages -f";
            treeNode121.Text = "All packages";
            treeNode122.Name = "Knoten13";
            treeNode122.Tag = "adb shell pm list libraries";
            treeNode122.Text = "Libraries";
            treeNode123.Name = "Knoten10";
            treeNode123.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
            treeNode123.Text = "Features";
            treeNode124.Name = "Knoten1";
            treeNode124.Tag = "#installuninstall";
            treeNode124.Text = "Install and Uninstall";
            treeNode125.Name = "Knoten2";
            treeNode125.Text = "Packages";
            treeNode126.Name = "Knoten5";
            treeNode126.Tag = "adb shell dumpsys";
            treeNode126.Text = "Dumpsys Input Diagnostics";
            treeNode127.Name = "Knoten21";
            treeNode127.Tag = "adb shell dmesg";
            treeNode127.Text = "Kernel Messages";
            treeNode128.Name = "Knoten1";
            treeNode128.Tag = "adb logcat";
            treeNode128.Text = "Logcat Live";
            treeNode129.Name = "Knoten6";
            treeNode129.Tag = "shell logcat -d";
            treeNode129.Text = "Logcat Dump";
            treeNode130.Name = "Knoten4";
            treeNode130.Tag = "adb logcat *:V";
            treeNode130.Text = "Verbose";
            treeNode131.Name = "Knoten5";
            treeNode131.Tag = "adb logcat *:D";
            treeNode131.Text = "Debug";
            treeNode132.Name = "Knoten6";
            treeNode132.Tag = "adb logcat *:I";
            treeNode132.Text = "Info";
            treeNode133.Name = "Knoten7";
            treeNode133.Tag = "adb logcat *:W";
            treeNode133.Text = "Warning";
            treeNode134.Name = "Knoten8";
            treeNode134.Tag = "adb logcat *:E";
            treeNode134.Text = "Error";
            treeNode135.Name = "Knoten9";
            treeNode135.Tag = "adb logcat *:F";
            treeNode135.Text = "Fatal";
            treeNode136.Name = "Knoten11";
            treeNode136.Tag = "adb logcat *:S";
            treeNode136.Text = "Silent";
            treeNode137.Name = "Knoten3";
            treeNode137.Text = "Filter";
            treeNode138.Name = "Knoten0";
            treeNode138.Text = "Logcat";
            treeNode139.Name = "Knoten20";
            treeNode139.Text = "Logs";
            treeNode140.Name = "Knoten2";
            treeNode140.Tag = "fastboot devices";
            treeNode140.Text = "Devices";
            treeNode141.Name = "Knoten4";
            treeNode141.Tag = "fastboot reboot";
            treeNode141.Text = "Reboot Normal";
            treeNode142.Name = "Knoten3";
            treeNode142.Tag = "fastboot reboot bootloader";
            treeNode142.Text = "Reboot Bootloader";
            treeNode143.Name = "Knoten1";
            treeNode143.Tag = "fastboot help";
            treeNode143.Text = "Help";
            treeNode144.Name = "Knoten3";
            treeNode144.Tag = "fastboot --version";
            treeNode144.Text = "Version";
            treeNode145.Name = "Knoten0";
            treeNode145.Text = "Fastboot";
            treeNode146.Name = "Knoten1";
            treeNode146.Tag = "adb help";
            treeNode146.Text = "Help";
            treeNode147.Name = "Knoten2";
            treeNode147.Tag = "adb version";
            treeNode147.Text = "Version";
            treeNode148.Name = "Knoten0";
            treeNode148.Text = "Adb";
            treeNode149.Name = "Knoten1";
            treeNode149.Text = "Credits";
            treeNode150.Name = "Knoten0";
            treeNode150.Text = "About";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode83,
            treeNode88,
            treeNode96,
            treeNode113,
            treeNode120,
            treeNode125,
            treeNode139,
            treeNode145,
            treeNode150});
            this.trv_commandTreeView.Size = new System.Drawing.Size(199, 510);
            this.trv_commandTreeView.TabIndex = 0;
            this.trv_commandTreeView.DoubleClick += new System.EventHandler(this.Trv_commandTreeView_DoubleClick);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 250;
            this.toolTip.ReshowDelay = 100;
            // 
            // cbx_customCommand
            // 
            this.cbx_customCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_customCommand.AutoCompleteCustomSource.AddRange(new string[] {
            "devices"});
            this.cbx_customCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_customCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_customCommand.FormattingEnabled = true;
            this.cbx_customCommand.Location = new System.Drawing.Point(217, 528);
            this.cbx_customCommand.Name = "cbx_customCommand";
            this.cbx_customCommand.Size = new System.Drawing.Size(562, 21);
            this.cbx_customCommand.TabIndex = 12;
            this.cbx_customCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbx_customCommand_KeyDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // rtb_console
            // 
            this.rtb_console.BackColor = System.Drawing.Color.Black;
            this.rtb_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_console.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_console.ForeColor = System.Drawing.Color.White;
            this.rtb_console.HideSelection = false;
            this.rtb_console.Location = new System.Drawing.Point(0, 0);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_console.Size = new System.Drawing.Size(803, 481);
            this.rtb_console.TabIndex = 11;
            this.rtb_console.Text = "";
            this.rtb_console.Resize += new System.EventHandler(this.Rtb_console_Resize);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtb_console);
            this.panel1.Location = new System.Drawing.Point(217, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 483);
            this.panel1.TabIndex = 12;
            // 
            // btn_consoleStop
            // 
            this.btn_consoleStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consoleStop.Location = new System.Drawing.Point(948, 528);
            this.btn_consoleStop.Name = "btn_consoleStop";
            this.btn_consoleStop.Size = new System.Drawing.Size(75, 22);
            this.btn_consoleStop.TabIndex = 1;
            this.btn_consoleStop.Text = "Abort";
            this.btn_consoleStop.UseVisualStyleBackColor = true;
            this.btn_consoleStop.Click += new System.EventHandler(this.Btn_consoleStop_Click);
            // 
            // btn_consoleClear
            // 
            this.btn_consoleClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consoleClear.Location = new System.Drawing.Point(867, 528);
            this.btn_consoleClear.Name = "btn_consoleClear";
            this.btn_consoleClear.Size = new System.Drawing.Size(75, 22);
            this.btn_consoleClear.TabIndex = 0;
            this.btn_consoleClear.Text = "Clear";
            this.btn_consoleClear.UseVisualStyleBackColor = true;
            this.btn_consoleClear.Click += new System.EventHandler(this.Btn_consoleClear_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsc_ConnectedDevices,
            this.tsd_WirelessAdb,
            this.tsb_KillServer,
            this.tsb_OpenShell,
            this.tsb_AdbRoot,
            this.toolStripLabel1,
            this.tsb_AdbUnroot});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(12, 10, 17, 3);
            this.toolStrip1.Size = new System.Drawing.Size(1040, 36);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsc_ConnectedDevices
            // 
            this.tsc_ConnectedDevices.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsc_ConnectedDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsc_ConnectedDevices.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tsc_ConnectedDevices.Name = "tsc_ConnectedDevices";
            this.tsc_ConnectedDevices.Size = new System.Drawing.Size(200, 23);
            // 
            // tsd_WirelessAdb
            // 
            this.tsd_WirelessAdb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_IpAdress,
            this.tsm_WirelessConnect,
            this.tsm_WirelessDisconnect});
            this.tsd_WirelessAdb.Image = global::adbGUI.Properties.Resources.wifi;
            this.tsd_WirelessAdb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsd_WirelessAdb.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsd_WirelessAdb.Name = "tsd_WirelessAdb";
            this.tsd_WirelessAdb.Size = new System.Drawing.Size(105, 20);
            this.tsd_WirelessAdb.Text = "Wireless ADB";
            // 
            // tst_IpAdress
            // 
            this.tst_IpAdress.Name = "tst_IpAdress";
            this.tst_IpAdress.Size = new System.Drawing.Size(100, 23);
            this.tst_IpAdress.Text = "192.168.0.44";
            // 
            // tsm_WirelessConnect
            // 
            this.tsm_WirelessConnect.Name = "tsm_WirelessConnect";
            this.tsm_WirelessConnect.Size = new System.Drawing.Size(160, 22);
            this.tsm_WirelessConnect.Text = "Connect";
            this.tsm_WirelessConnect.Click += new System.EventHandler(this.Tsm_WirelessConnect_Click);
            // 
            // tsm_WirelessDisconnect
            // 
            this.tsm_WirelessDisconnect.Name = "tsm_WirelessDisconnect";
            this.tsm_WirelessDisconnect.Size = new System.Drawing.Size(160, 22);
            this.tsm_WirelessDisconnect.Text = "Disconnect";
            this.tsm_WirelessDisconnect.Click += new System.EventHandler(this.Tsm_WirelessDisconnect_Click);
            // 
            // tsb_KillServer
            // 
            this.tsb_KillServer.Image = ((System.Drawing.Image)(resources.GetObject("tsb_KillServer.Image")));
            this.tsb_KillServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_KillServer.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsb_KillServer.Name = "tsb_KillServer";
            this.tsb_KillServer.Size = new System.Drawing.Size(78, 20);
            this.tsb_KillServer.Text = "Kill Server";
            this.tsb_KillServer.Click += new System.EventHandler(this.Tsb_KillServer_Click);
            // 
            // tsb_OpenShell
            // 
            this.tsb_OpenShell.Image = ((System.Drawing.Image)(resources.GetObject("tsb_OpenShell.Image")));
            this.tsb_OpenShell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_OpenShell.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsb_OpenShell.Name = "tsb_OpenShell";
            this.tsb_OpenShell.Size = new System.Drawing.Size(84, 20);
            this.tsb_OpenShell.Text = "Open Shell";
            this.tsb_OpenShell.Click += new System.EventHandler(this.Tsb_OpenShell_Click);
            // 
            // tsb_AdbRoot
            // 
            this.tsb_AdbRoot.Image = global::adbGUI.Properties.Resources.hash;
            this.tsb_AdbRoot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AdbRoot.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsb_AdbRoot.Name = "tsb_AdbRoot";
            this.tsb_AdbRoot.Size = new System.Drawing.Size(78, 20);
            this.tsb_AdbRoot.Text = "ADB Root";
            this.tsb_AdbRoot.Click += new System.EventHandler(this.Tsb_AdbRoot_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 20);
            this.toolStripLabel1.Text = "Connected Devices: ";
            // 
            // tsb_AdbUnroot
            // 
            this.tsb_AdbUnroot.Image = global::adbGUI.Properties.Resources.unroot;
            this.tsb_AdbUnroot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AdbUnroot.Name = "tsb_AdbUnroot";
            this.tsb_AdbUnroot.Size = new System.Drawing.Size(90, 20);
            this.tsb_AdbUnroot.Text = "ADB Unroot";
            this.tsb_AdbUnroot.Click += new System.EventHandler(this.Tsb_AdbUnroot_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 617);
            this.Controls.Add(this.cbo_clearEverytime);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_DevicesAdb);
            this.Controls.Add(this.cbx_customCommand);
            this.Controls.Add(this.btn_consoleStop);
            this.Controls.Add(this.btn_consoleClear);
            this.Controls.Add(this.btn_executeCommand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trv_commandTreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adbGUI";
            this.toolTip.SetToolTip(this, "Enter command without adb.");
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.ToolTip toolTip;
            private System.Windows.Forms.OpenFileDialog openFileDialog;
            private System.Windows.Forms.Button btn_executeCommand;
            private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
            private System.Windows.Forms.SaveFileDialog saveFileDialog;
            public System.Windows.Forms.TextBox txt_DevicesAdb;
        private System.Windows.Forms.TreeView trv_commandTreeView;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consoleStop;
        private System.Windows.Forms.Button btn_consoleClear;
        private System.Windows.Forms.ComboBox cbx_customCommand;
        private System.Windows.Forms.CheckBox cbo_clearEverytime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsd_WirelessAdb;
        private System.Windows.Forms.ToolStripTextBox tst_IpAdress;
        private System.Windows.Forms.ToolStripMenuItem tsm_WirelessConnect;
        private System.Windows.Forms.ToolStripMenuItem tsm_WirelessDisconnect;
        private System.Windows.Forms.ToolStripButton tsb_KillServer;
        private System.Windows.Forms.ToolStripButton tsb_OpenShell;
        private System.Windows.Forms.ToolStripButton tsb_AdbRoot;
        public System.Windows.Forms.ToolStripComboBox tsc_ConnectedDevices;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsb_AdbUnroot;
    }
}

