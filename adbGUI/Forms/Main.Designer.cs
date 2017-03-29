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
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Files");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Sideload");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("All User");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Max User");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("IMEI");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Accounts");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Backup Restore");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82,
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Screenshot");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Screenrecord");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Resolution");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Density");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode85,
            treeNode86,
            treeNode87,
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Shutdown");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Reboot Recovery");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Reboot Fastboot");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Sideload Mode");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Sleep Mode");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Power", new System.Windows.Forms.TreeNode[] {
            treeNode90,
            treeNode91,
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95,
            treeNode96});
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Get Prop");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Set Prop");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode98,
            treeNode99});
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Battery Service State");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode103,
            treeNode104,
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("Remount System");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode100,
            treeNode101,
            treeNode102,
            treeNode106,
            treeNode107,
            treeNode108,
            treeNode109,
            treeNode110,
            treeNode111,
            treeNode112,
            treeNode113});
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Network Info");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Spoof MAC");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode115,
            treeNode116,
            treeNode117,
            treeNode118,
            treeNode119,
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("Install and Uninstall");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode122,
            treeNode123,
            treeNode124,
            treeNode125});
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Dumpsys Input Diagnostics");
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("Clear all buffers");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode132,
            treeNode133,
            treeNode134,
            treeNode135,
            treeNode136,
            treeNode137,
            treeNode138});
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode129,
            treeNode130,
            treeNode131,
            treeNode139});
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode127,
            treeNode128,
            treeNode140});
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("Devices");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("Fastboot", new System.Windows.Forms.TreeNode[] {
            treeNode142,
            treeNode143,
            treeNode144,
            treeNode145,
            treeNode146});
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode148,
            treeNode149});
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("Credits");
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            treeNode150,
            treeNode151});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txt_DevicesAdb = new System.Windows.Forms.TextBox();
            this.btn_executeCommand = new System.Windows.Forms.Button();
            this.trv_commandTreeView = new System.Windows.Forms.TreeView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbx_customCommand = new System.Windows.Forms.ComboBox();
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
            this.tsb_AlwaysClearConsole = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.trv_commandTreeView.AllowDrop = true;
            this.trv_commandTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trv_commandTreeView.Location = new System.Drawing.Point(12, 39);
            this.trv_commandTreeView.Name = "trv_commandTreeView";
            treeNode77.Name = "Knoten0";
            treeNode77.Tag = "#files";
            treeNode77.Text = "Files";
            treeNode78.Name = "Knoten2";
            treeNode78.Tag = "#sideload";
            treeNode78.Text = "Sideload";
            treeNode79.Name = "Knoten15";
            treeNode79.Tag = "adb shell pm list users";
            treeNode79.Text = "All User";
            treeNode80.Name = "Knoten17";
            treeNode80.Tag = "adb shell pm get-max-users";
            treeNode80.Text = "Max User";
            treeNode81.Name = "Knoten19";
            treeNode81.Tag = "adb shell service call iphonesubinfo 1";
            treeNode81.Text = "IMEI";
            treeNode82.Name = "Knoten27";
            treeNode82.Tag = "adb shell dumpsys account";
            treeNode82.Text = "Accounts";
            treeNode83.Name = "Knoten3";
            treeNode83.Tag = "#backuprestore";
            treeNode83.Text = "Backup Restore";
            treeNode84.Name = "Knoten3";
            treeNode84.Text = "Phone";
            treeNode85.Name = "Knoten31";
            treeNode85.Tag = "#screenshot";
            treeNode85.Text = "Screenshot";
            treeNode85.ToolTipText = "Take a screenshot";
            treeNode86.Name = "Knoten0";
            treeNode86.Tag = "#screenrecord";
            treeNode86.Text = "Screenrecord";
            treeNode86.ToolTipText = "Record screen up to 3 minutes";
            treeNode87.Name = "Knoten1";
            treeNode87.Tag = "#resolution";
            treeNode87.Text = "Resolution";
            treeNode87.ToolTipText = "Change Resolution";
            treeNode88.Name = "Knoten2";
            treeNode88.Tag = "#density";
            treeNode88.Text = "Density";
            treeNode89.Name = "Knoten0";
            treeNode89.Text = "Display";
            treeNode90.Name = "Knoten1";
            treeNode90.Tag = "adb shell reboot -p";
            treeNode90.Text = "Shutdown";
            treeNode91.Name = "Knoten2";
            treeNode91.Tag = "adb reboot";
            treeNode91.Text = "Reboot Normal";
            treeNode92.Name = "Knoten3";
            treeNode92.Tag = "adb reboot bootloader";
            treeNode92.Text = "Reboot Bootloader";
            treeNode93.Name = "Knoten5";
            treeNode93.Tag = "adb reboot recovery";
            treeNode93.Text = "Reboot Recovery";
            treeNode94.Name = "Knoten0";
            treeNode94.Tag = "adb reboot fastboot";
            treeNode94.Text = "Reboot Fastboot";
            treeNode95.Name = "Knoten4";
            treeNode95.Tag = "adb reboot sideload";
            treeNode95.Text = "Sideload Mode";
            treeNode96.Name = "Knoten6";
            treeNode96.Tag = "adb shell input keyevent POWER";
            treeNode96.Text = "Sleep Mode";
            treeNode97.Name = "Knoten0";
            treeNode97.Text = "Power";
            treeNode98.Name = "Knoten4";
            treeNode98.Tag = "adb shell getprop";
            treeNode98.Text = "Get Prop";
            treeNode99.Name = "Knoten1";
            treeNode99.Tag = "#prop";
            treeNode99.Text = "Set Prop";
            treeNode100.Name = "Knoten0";
            treeNode100.Text = "Prop";
            treeNode101.Name = "Knoten8";
            treeNode101.Tag = "adb shell ps";
            treeNode101.Text = "Processes";
            treeNode102.Name = "Knoten9";
            treeNode102.Tag = "adb shell dumpsys meminfo";
            treeNode102.Text = "Memory";
            treeNode103.Name = "Knoten1";
            treeNode103.Tag = "adb shell dumpsys battery";
            treeNode103.Text = "Battery Service State";
            treeNode104.Name = "Knoten2";
            treeNode104.Tag = "adb shell dumpsys batterystats";
            treeNode104.Text = "Collected Battery Stats";
            treeNode105.Name = "Knoten3";
            treeNode105.Tag = "adb shell dumpsys batterystats --reset";
            treeNode105.Text = "Reset Battery Stats";
            treeNode106.Name = "Knoten22";
            treeNode106.Tag = "";
            treeNode106.Text = "Battery";
            treeNode107.Name = "Knoten12";
            treeNode107.Tag = "adb shell dumpsys alarm";
            treeNode107.Text = "Alarm Manager State";
            treeNode108.Name = "Knoten16";
            treeNode108.Tag = "adb shell uptime";
            treeNode108.Text = "Uptime";
            treeNode109.Name = "Knoten24";
            treeNode109.Tag = "adb shell dumpsys cpuinfo";
            treeNode109.Text = "CPU Info";
            treeNode110.Name = "Knoten26";
            treeNode110.Tag = "adb shell dumpsys diskstats";
            treeNode110.Text = "Diskstats";
            treeNode111.Name = "Knoten28";
            treeNode111.Tag = "adb shell pm list permissions";
            treeNode111.Text = "Permissions";
            treeNode112.Name = "Knoten0";
            treeNode112.Tag = "adb shell df -h";
            treeNode112.Text = "Filesystem";
            treeNode113.Name = "Knoten0";
            treeNode113.Tag = "adb remount";
            treeNode113.Text = "Remount System";
            treeNode114.Name = "Knoten0";
            treeNode114.Text = "System";
            treeNode115.Name = "Knoten7";
            treeNode115.Tag = "adb shell iftop";
            treeNode115.Text = "Network Traffic";
            treeNode116.Name = "Knoten25";
            treeNode116.Tag = "adb shell netstat";
            treeNode116.Text = "Netstat";
            treeNode117.Name = "Knoten23";
            treeNode117.Tag = "adb shell dumpsys wifi";
            treeNode117.Text = "WiFi Info";
            treeNode118.Name = "Knoten29";
            treeNode118.Tag = "adb shell cat /etc/hosts";
            treeNode118.Text = "Hosts";
            treeNode119.Name = "Knoten0";
            treeNode119.Tag = "adb shell ifconfig";
            treeNode119.Text = "Network Info";
            treeNode120.Name = "Knoten3";
            treeNode120.Tag = "#spoofmac";
            treeNode120.Text = "Spoof MAC";
            treeNode121.Name = "Knoten1";
            treeNode121.Text = "Network";
            treeNode122.Name = "Knoten11";
            treeNode122.Tag = "adb shell pm list packages -f";
            treeNode122.Text = "All packages";
            treeNode123.Name = "Knoten13";
            treeNode123.Tag = "adb shell pm list libraries";
            treeNode123.Text = "Libraries";
            treeNode124.Name = "Knoten10";
            treeNode124.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
            treeNode124.Text = "Features";
            treeNode125.Name = "Knoten1";
            treeNode125.Tag = "#installuninstall";
            treeNode125.Text = "Install and Uninstall";
            treeNode126.Name = "Knoten2";
            treeNode126.Text = "Packages";
            treeNode127.Name = "Knoten5";
            treeNode127.Tag = "adb shell dumpsys";
            treeNode127.Text = "Dumpsys Input Diagnostics";
            treeNode128.Name = "Knoten21";
            treeNode128.Tag = "adb shell dmesg";
            treeNode128.Text = "Kernel Messages";
            treeNode129.Name = "Knoten1";
            treeNode129.Tag = "adb logcat";
            treeNode129.Text = "Logcat Live";
            treeNode130.Name = "Knoten6";
            treeNode130.Tag = "adb logcat -d";
            treeNode130.Text = "Logcat Dump";
            treeNode131.Name = "Knoten0";
            treeNode131.Tag = "adb logcat -b all -c";
            treeNode131.Text = "Clear all buffers";
            treeNode132.Name = "Knoten4";
            treeNode132.Tag = "adb logcat *:V";
            treeNode132.Text = "Verbose";
            treeNode133.Name = "Knoten5";
            treeNode133.Tag = "adb logcat *:D";
            treeNode133.Text = "Debug";
            treeNode134.Name = "Knoten6";
            treeNode134.Tag = "adb logcat *:I";
            treeNode134.Text = "Info";
            treeNode135.Name = "Knoten7";
            treeNode135.Tag = "adb logcat *:W";
            treeNode135.Text = "Warning";
            treeNode136.Name = "Knoten8";
            treeNode136.Tag = "adb logcat *:E";
            treeNode136.Text = "Error";
            treeNode137.Name = "Knoten9";
            treeNode137.Tag = "adb logcat *:F";
            treeNode137.Text = "Fatal";
            treeNode138.Name = "Knoten11";
            treeNode138.Tag = "adb logcat *:S";
            treeNode138.Text = "Silent";
            treeNode139.Name = "Knoten3";
            treeNode139.Text = "Filter";
            treeNode140.Name = "Knoten0";
            treeNode140.Text = "Logcat";
            treeNode141.Name = "Knoten20";
            treeNode141.Text = "Logs";
            treeNode142.Name = "Knoten2";
            treeNode142.Tag = "fastboot devices";
            treeNode142.Text = "Devices";
            treeNode143.Name = "Knoten4";
            treeNode143.Tag = "fastboot reboot";
            treeNode143.Text = "Reboot Normal";
            treeNode144.Name = "Knoten3";
            treeNode144.Tag = "fastboot reboot bootloader";
            treeNode144.Text = "Reboot Bootloader";
            treeNode145.Name = "Knoten1";
            treeNode145.Tag = "fastboot help";
            treeNode145.Text = "Help";
            treeNode146.Name = "Knoten3";
            treeNode146.Tag = "fastboot --version";
            treeNode146.Text = "Version";
            treeNode147.Name = "Knoten0";
            treeNode147.Text = "Fastboot";
            treeNode148.Name = "Knoten1";
            treeNode148.Tag = "adb help";
            treeNode148.Text = "Help";
            treeNode149.Name = "Knoten2";
            treeNode149.Tag = "adb version";
            treeNode149.Text = "Version";
            treeNode150.Name = "Knoten0";
            treeNode150.Text = "Adb";
            treeNode151.Name = "Knoten1";
            treeNode151.Tag = "#credits";
            treeNode151.Text = "Credits";
            treeNode152.Name = "Knoten0";
            treeNode152.Text = "About";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode84,
            treeNode89,
            treeNode97,
            treeNode114,
            treeNode121,
            treeNode126,
            treeNode141,
            treeNode147,
            treeNode152});
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
            // rtb_console
            // 
            this.rtb_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_console.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tsb_AdbUnroot,
            this.tsb_AlwaysClearConsole});
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
            this.tsb_AdbUnroot.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsb_AdbUnroot.Name = "tsb_AdbUnroot";
            this.tsb_AdbUnroot.Size = new System.Drawing.Size(90, 20);
            this.tsb_AdbUnroot.Text = "ADB Unroot";
            this.tsb_AdbUnroot.Click += new System.EventHandler(this.Tsb_AdbUnroot_Click);
            // 
            // tsb_AlwaysClearConsole
            // 
            this.tsb_AlwaysClearConsole.Image = global::adbGUI.Properties.Resources.eraser;
            this.tsb_AlwaysClearConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AlwaysClearConsole.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsb_AlwaysClearConsole.Name = "tsb_AlwaysClearConsole";
            this.tsb_AlwaysClearConsole.Size = new System.Drawing.Size(135, 20);
            this.tsb_AlwaysClearConsole.Text = "Alway Clear Console";
            this.tsb_AlwaysClearConsole.Click += new System.EventHandler(this.Tsb_AlwaysClearConsole_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 617);
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
            private System.Windows.Forms.Button btn_executeCommand;
            private System.Windows.Forms.SaveFileDialog saveFileDialog;
            public System.Windows.Forms.TextBox txt_DevicesAdb;
        private System.Windows.Forms.TreeView trv_commandTreeView;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consoleStop;
        private System.Windows.Forms.Button btn_consoleClear;
        private System.Windows.Forms.ComboBox cbx_customCommand;
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
        private System.Windows.Forms.ToolStripButton tsb_AlwaysClearConsole;
    }
}

