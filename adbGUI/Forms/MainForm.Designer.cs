namespace adbGUI.Forms
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
			System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Files");
			System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Sideload");
			System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("All User");
			System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Max User");
			System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("IMEI");
			System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Accounts");
			System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Backup Restore");
			System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode75,
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81});
			System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Screenshot");
			System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Screenrecord");
			System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Resolution");
			System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Density");
			System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode83,
            treeNode84,
            treeNode85,
            treeNode86});
			System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Get Prop");
			System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Set Prop");
			System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode88,
            treeNode89});
			System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Processes");
			System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Memory");
			System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Battery Service State");
			System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
			System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
			System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode93,
            treeNode94,
            treeNode95});
			System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Alarm Manager State");
			System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Uptime");
			System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("CPU Info");
			System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Diskstats");
			System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Permissions");
			System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Filesystem");
			System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Remount System");
			System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode90,
            treeNode91,
            treeNode92,
            treeNode96,
            treeNode97,
            treeNode98,
            treeNode99,
            treeNode100,
            treeNode101,
            treeNode102,
            treeNode103});
			System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Network Traffic");
			System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Netstat");
			System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("WiFi Info");
			System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Hosts");
			System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("Network Info");
			System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Spoof MAC");
			System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode105,
            treeNode106,
            treeNode107,
            treeNode108,
            treeNode109,
            treeNode110});
			System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("All packages");
			System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("Libraries");
			System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("Features");
			System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("Install and Uninstall");
			System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode112,
            treeNode113,
            treeNode114,
            treeNode115});
			System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Logcat Live");
			System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Logcat Dump");
			System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Dump to file");
			System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Clear all buffers");
			System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("Logcat Advanced");
			System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("Verbose");
			System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("Debug");
			System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("Info");
			System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("Warning");
			System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Error");
			System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Fatal");
			System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("Silent");
			System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode122,
            treeNode123,
            treeNode124,
            treeNode125,
            treeNode126,
            treeNode127,
            treeNode128});
			System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode117,
            treeNode118,
            treeNode119,
            treeNode120,
            treeNode121,
            treeNode129});
			System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("Dumpsys");
			System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("Kernel Messages");
			System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("Logging", new System.Windows.Forms.TreeNode[] {
            treeNode130,
            treeNode131,
            treeNode132});
			System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("Devices");
			System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("Continue Boot");
			System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("Reboot Normal");
			System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
			System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("Erase");
			System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("Erase Recovery");
			System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("Flash");
			System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("Help");
			System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("Version");
			System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("Fastboot", new System.Windows.Forms.TreeNode[] {
            treeNode134,
            treeNode135,
            treeNode136,
            treeNode137,
            treeNode138,
            treeNode139,
            treeNode140,
            treeNode141,
            treeNode142});
			System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("Help");
			System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("Version");
			System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode144,
            treeNode145});
			System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("Credits");
			System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            treeNode146,
            treeNode147});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btn_executeCommand = new System.Windows.Forms.Button();
			this.trv_commandTreeView = new System.Windows.Forms.TreeView();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.cbx_customCommand = new System.Windows.Forms.ComboBox();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.rtb_console = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_consoleStop = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsc_ConnectedDevices = new System.Windows.Forms.ToolStripComboBox();
			this.tsd_Power = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsm_PowerRebootNormal = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerRebootRecovery = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerRebootBootloader = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerRebootFastboot = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerSideloadMode = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerShutdown = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerSleep = new System.Windows.Forms.ToolStripMenuItem();
			this.tsd_WirelessAdb = new System.Windows.Forms.ToolStripDropDownButton();
			this.tst_IpAdress = new System.Windows.Forms.ToolStripTextBox();
			this.tsm_WirelessConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_WirelessDisconnect = new System.Windows.Forms.ToolStripMenuItem();
			this.tsb_KillServer = new System.Windows.Forms.ToolStripButton();
			this.tsb_OpenShell = new System.Windows.Forms.ToolStripButton();
			this.tsb_AdbRoot = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.tsb_AdbUnroot = new System.Windows.Forms.ToolStripButton();
			this.tsb_AlwayClearConsole = new System.Windows.Forms.ToolStripButton();
			this.btn_ConsoleClear = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_executeCommand
			// 
			this.btn_executeCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_executeCommand.Location = new System.Drawing.Point(849, 567);
			this.btn_executeCommand.Name = "btn_executeCommand";
			this.btn_executeCommand.Size = new System.Drawing.Size(54, 23);
			this.btn_executeCommand.TabIndex = 1;
			this.btn_executeCommand.Text = "Execute";
			this.btn_executeCommand.UseVisualStyleBackColor = true;
			this.btn_executeCommand.Click += new System.EventHandler(this.Btn_executeCommand_Click);
			// 
			// trv_commandTreeView
			// 
			this.trv_commandTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.trv_commandTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trv_commandTreeView.Location = new System.Drawing.Point(2, 2);
			this.trv_commandTreeView.Margin = new System.Windows.Forms.Padding(2);
			this.trv_commandTreeView.Name = "trv_commandTreeView";
			treeNode75.Name = "Knoten0";
			treeNode75.Tag = "#FileOps";
			treeNode75.Text = "Files";
			treeNode76.Name = "Knoten2";
			treeNode76.Tag = "#Sideload";
			treeNode76.Text = "Sideload";
			treeNode77.Name = "Knoten15";
			treeNode77.Tag = "adb shell pm list users";
			treeNode77.Text = "All User";
			treeNode78.Name = "Knoten17";
			treeNode78.Tag = "adb shell pm get-max-users";
			treeNode78.Text = "Max User";
			treeNode79.Name = "Knoten19";
			treeNode79.Tag = "adb exec-out \"service call iphonesubinfo 4 | cut -c 52-66 | tr -d \'.[:space:]\'\"";
			treeNode79.Text = "IMEI";
			treeNode80.Name = "Knoten27";
			treeNode80.Tag = "adb shell dumpsys account";
			treeNode80.Text = "Accounts";
			treeNode81.Name = "Knoten3";
			treeNode81.Tag = "#BackupRestore";
			treeNode81.Text = "Backup Restore";
			treeNode82.Name = "Knoten3";
			treeNode82.Tag = "0";
			treeNode82.Text = "Phone";
			treeNode83.Name = "Knoten31";
			treeNode83.Tag = "%screenshot";
			treeNode83.Text = "Screenshot";
			treeNode83.ToolTipText = "Take a screenshot";
			treeNode84.Name = "Knoten0";
			treeNode84.Tag = "#ScreenRecord";
			treeNode84.Text = "Screenrecord";
			treeNode84.ToolTipText = "Record screen up to 3 minutes";
			treeNode85.Name = "Knoten1";
			treeNode85.Tag = "#ResolutionChange";
			treeNode85.Text = "Resolution";
			treeNode85.ToolTipText = "Change Resolution";
			treeNode86.Name = "Knoten2";
			treeNode86.Tag = "#Density";
			treeNode86.Text = "Density";
			treeNode87.Name = "Knoten0";
			treeNode87.Tag = "0";
			treeNode87.Text = "Display";
			treeNode88.Name = "Knoten4";
			treeNode88.Tag = "adb shell getprop";
			treeNode88.Text = "Get Prop";
			treeNode89.Name = "Knoten1";
			treeNode89.Tag = "#SetProp";
			treeNode89.Text = "Set Prop";
			treeNode90.Name = "Knoten0";
			treeNode90.Tag = "0";
			treeNode90.Text = "Prop";
			treeNode91.Name = "Knoten8";
			treeNode91.Tag = "adb shell ps";
			treeNode91.Text = "Processes";
			treeNode92.Name = "Knoten9";
			treeNode92.Tag = "adb shell dumpsys meminfo";
			treeNode92.Text = "Memory";
			treeNode93.Name = "Knoten1";
			treeNode93.Tag = "adb shell dumpsys battery";
			treeNode93.Text = "Battery Service State";
			treeNode94.Name = "Knoten2";
			treeNode94.Tag = "adb shell dumpsys batterystats";
			treeNode94.Text = "Collected Battery Stats";
			treeNode95.Name = "Knoten3";
			treeNode95.Tag = "adb shell dumpsys batterystats --reset";
			treeNode95.Text = "Reset Battery Stats";
			treeNode96.Name = "Knoten22";
			treeNode96.Tag = "";
			treeNode96.Text = "Battery";
			treeNode97.Name = "Knoten12";
			treeNode97.Tag = "adb shell dumpsys alarm";
			treeNode97.Text = "Alarm Manager State";
			treeNode98.Name = "Knoten16";
			treeNode98.Tag = "adb shell uptime";
			treeNode98.Text = "Uptime";
			treeNode99.Name = "Knoten24";
			treeNode99.Tag = "adb shell dumpsys cpuinfo";
			treeNode99.Text = "CPU Info";
			treeNode100.Name = "Knoten26";
			treeNode100.Tag = "adb shell dumpsys diskstats";
			treeNode100.Text = "Diskstats";
			treeNode101.Name = "Knoten28";
			treeNode101.Tag = "adb shell pm list permissions";
			treeNode101.Text = "Permissions";
			treeNode102.Name = "Knoten0";
			treeNode102.Tag = "adb shell df -h";
			treeNode102.Text = "Filesystem";
			treeNode103.Name = "Knoten0";
			treeNode103.Tag = "adb remount";
			treeNode103.Text = "Remount System";
			treeNode104.Name = "Knoten0";
			treeNode104.Tag = "0";
			treeNode104.Text = "System";
			treeNode105.Name = "Knoten7";
			treeNode105.Tag = "adb shell iftop";
			treeNode105.Text = "Network Traffic";
			treeNode106.Name = "Knoten25";
			treeNode106.Tag = "adb shell netstat";
			treeNode106.Text = "Netstat";
			treeNode107.Name = "Knoten23";
			treeNode107.Tag = "adb shell dumpsys wifi";
			treeNode107.Text = "WiFi Info";
			treeNode108.Name = "Knoten29";
			treeNode108.Tag = "adb shell cat /etc/hosts";
			treeNode108.Text = "Hosts";
			treeNode109.Name = "Knoten0";
			treeNode109.Tag = "adb shell ifconfig";
			treeNode109.Text = "Network Info";
			treeNode110.Name = "Knoten3";
			treeNode110.Tag = "#SpoofMac";
			treeNode110.Text = "Spoof MAC";
			treeNode111.Name = "Knoten1";
			treeNode111.Tag = "0";
			treeNode111.Text = "Network";
			treeNode112.Name = "Knoten11";
			treeNode112.Tag = "adb shell pm list packages -f";
			treeNode112.Text = "All packages";
			treeNode113.Name = "Knoten13";
			treeNode113.Tag = "adb shell pm list libraries";
			treeNode113.Text = "Libraries";
			treeNode114.Name = "Knoten10";
			treeNode114.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
			treeNode114.Text = "Features";
			treeNode115.Name = "Knoten1";
			treeNode115.Tag = "#InstallUninstall";
			treeNode115.Text = "Install and Uninstall";
			treeNode116.Name = "Knoten2";
			treeNode116.Tag = "0";
			treeNode116.Text = "Packages";
			treeNode117.Name = "Knoten1";
			treeNode117.Tag = "adb logcat";
			treeNode117.Text = "Logcat Live";
			treeNode118.Name = "Knoten6";
			treeNode118.Tag = "adb logcat -d";
			treeNode118.Text = "Logcat Dump";
			treeNode119.Name = "Knoten0";
			treeNode119.Tag = "adb logcat -d > logcat.txt";
			treeNode119.Text = "Dump to file";
			treeNode120.Name = "Knoten0";
			treeNode120.Tag = "adb logcat -b all -c";
			treeNode120.Text = "Clear all buffers";
			treeNode121.Name = "Knoten0";
			treeNode121.Tag = "#LogcatAdvanced";
			treeNode121.Text = "Logcat Advanced";
			treeNode122.Name = "Knoten4";
			treeNode122.Tag = "adb logcat *:V";
			treeNode122.Text = "Verbose";
			treeNode123.Name = "Knoten5";
			treeNode123.Tag = "adb logcat *:D";
			treeNode123.Text = "Debug";
			treeNode124.Name = "Knoten6";
			treeNode124.Tag = "adb logcat *:I";
			treeNode124.Text = "Info";
			treeNode125.Name = "Knoten7";
			treeNode125.Tag = "adb logcat *:W";
			treeNode125.Text = "Warning";
			treeNode126.Name = "Knoten8";
			treeNode126.Tag = "adb logcat *:E";
			treeNode126.Text = "Error";
			treeNode127.Name = "Knoten9";
			treeNode127.Tag = "adb logcat *:F";
			treeNode127.Text = "Fatal";
			treeNode128.Name = "Knoten11";
			treeNode128.Tag = "adb logcat *:S";
			treeNode128.Text = "Silent";
			treeNode129.Name = "Knoten3";
			treeNode129.Tag = "0";
			treeNode129.Text = "Filter";
			treeNode130.Name = "Knoten0";
			treeNode130.Tag = "0";
			treeNode130.Text = "Logcat";
			treeNode131.Name = "Knoten5";
			treeNode131.Tag = "adb shell dumpsys";
			treeNode131.Text = "Dumpsys";
			treeNode132.Name = "Knoten21";
			treeNode132.Tag = "adb shell dmesg";
			treeNode132.Text = "Kernel Messages";
			treeNode133.Name = "Knoten20";
			treeNode133.Tag = "0";
			treeNode133.Text = "Logging";
			treeNode134.Name = "Knoten2";
			treeNode134.Tag = "fastboot devices";
			treeNode134.Text = "Devices";
			treeNode135.Name = "Knoten8";
			treeNode135.Tag = "fastboot continue";
			treeNode135.Text = "Continue Boot";
			treeNode136.Name = "Knoten4";
			treeNode136.Tag = "fastboot reboot";
			treeNode136.Text = "Reboot Normal";
			treeNode137.Name = "Knoten3";
			treeNode137.Tag = "fastboot reboot bootloader";
			treeNode137.Text = "Reboot Bootloader";
			treeNode138.Name = "Knoten5";
			treeNode138.Tag = "#Erase";
			treeNode138.Text = "Erase";
			treeNode139.Name = "Knoten6";
			treeNode139.Tag = "fastboot erase recovery";
			treeNode139.Text = "Erase Recovery";
			treeNode140.Name = "Knoten7";
			treeNode140.Tag = "#Flash";
			treeNode140.Text = "Flash";
			treeNode141.Name = "Knoten1";
			treeNode141.Tag = "fastboot help";
			treeNode141.Text = "Help";
			treeNode142.Name = "Knoten3";
			treeNode142.Tag = "fastboot --version";
			treeNode142.Text = "Version";
			treeNode143.Name = "Knoten0";
			treeNode143.Tag = "0";
			treeNode143.Text = "Fastboot";
			treeNode144.Name = "Knoten1";
			treeNode144.Tag = "adb help";
			treeNode144.Text = "Help";
			treeNode145.Name = "Knoten2";
			treeNode145.Tag = "adb version";
			treeNode145.Text = "Version";
			treeNode146.Name = "Knoten0";
			treeNode146.Tag = "0";
			treeNode146.Text = "Adb";
			treeNode147.Name = "Knoten1";
			treeNode147.Tag = "#Credits";
			treeNode147.Text = "Credits";
			treeNode148.Name = "Knoten0";
			treeNode148.Tag = "0";
			treeNode148.Text = "About";
			this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode82,
            treeNode87,
            treeNode104,
            treeNode111,
            treeNode116,
            treeNode133,
            treeNode143,
            treeNode148});
			this.trv_commandTreeView.Size = new System.Drawing.Size(194, 546);
			this.trv_commandTreeView.TabIndex = 0;
			this.trv_commandTreeView.DoubleClick += new System.EventHandler(this.Trv_commandTreeView_DoubleClick);
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 500;
			this.toolTip.ReshowDelay = 100;
			this.toolTip.UseFading = false;
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
			this.cbx_customCommand.Location = new System.Drawing.Point(215, 568);
			this.cbx_customCommand.Name = "cbx_customCommand";
			this.cbx_customCommand.Size = new System.Drawing.Size(628, 21);
			this.cbx_customCommand.TabIndex = 12;
			this.cbx_customCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbx_customCommand_KeyDown);
			// 
			// rtb_console
			// 
			this.rtb_console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_console.BackColor = System.Drawing.Color.White;
			this.rtb_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb_console.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtb_console.HideSelection = false;
			this.rtb_console.Location = new System.Drawing.Point(2, 2);
			this.rtb_console.Margin = new System.Windows.Forms.Padding(2);
			this.rtb_console.Name = "rtb_console";
			this.rtb_console.ReadOnly = true;
			this.rtb_console.Size = new System.Drawing.Size(801, 516);
			this.rtb_console.TabIndex = 11;
			this.rtb_console.Text = "";
			this.rtb_console.Resize += new System.EventHandler(this.Rtb_console_Resize);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.rtb_console);
			this.panel1.Location = new System.Drawing.Point(215, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(807, 522);
			this.panel1.TabIndex = 12;
			// 
			// btn_consoleStop
			// 
			this.btn_consoleStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_consoleStop.Location = new System.Drawing.Point(909, 567);
			this.btn_consoleStop.Name = "btn_consoleStop";
			this.btn_consoleStop.Size = new System.Drawing.Size(54, 23);
			this.btn_consoleStop.TabIndex = 1;
			this.btn_consoleStop.Text = "Stop";
			this.btn_consoleStop.UseVisualStyleBackColor = true;
			this.btn_consoleStop.Click += new System.EventHandler(this.Btn_consoleStop_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsc_ConnectedDevices,
            this.tsd_Power,
            this.tsd_WirelessAdb,
            this.tsb_KillServer,
            this.tsb_OpenShell,
            this.tsb_AdbRoot,
            this.toolStripLabel1,
            this.tsb_AdbUnroot,
            this.tsb_AlwayClearConsole});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(12, 10, 11, 3);
			this.toolStrip1.Size = new System.Drawing.Size(1034, 36);
			this.toolStrip1.TabIndex = 13;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsc_ConnectedDevices
			// 
			this.tsc_ConnectedDevices.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsc_ConnectedDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tsc_ConnectedDevices.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
			this.tsc_ConnectedDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsc_ConnectedDevices.Name = "tsc_ConnectedDevices";
			this.tsc_ConnectedDevices.Size = new System.Drawing.Size(150, 23);
			this.tsc_ConnectedDevices.SelectedIndexChanged += new System.EventHandler(this.Tsc_ConnectedDevices_SelectedIndexChanged);
			// 
			// tsd_Power
			// 
			this.tsd_Power.AutoToolTip = false;
			this.tsd_Power.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_PowerRebootNormal,
            this.tsm_PowerRebootRecovery,
            this.tsm_PowerRebootBootloader,
            this.tsm_PowerRebootFastboot,
            this.tsm_PowerSideloadMode,
            this.tsm_PowerShutdown,
            this.tsm_PowerSleep});
			this.tsd_Power.Image = global::adbGUI.Properties.Resources.power;
			this.tsd_Power.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsd_Power.Name = "tsd_Power";
			this.tsd_Power.Size = new System.Drawing.Size(96, 20);
			this.tsd_Power.Text = "Power Menu";
			// 
			// tsm_PowerRebootNormal
			// 
			this.tsm_PowerRebootNormal.Name = "tsm_PowerRebootNormal";
			this.tsm_PowerRebootNormal.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerRebootNormal.Text = "Reboot Normal";
			this.tsm_PowerRebootNormal.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerRebootRecovery
			// 
			this.tsm_PowerRebootRecovery.Name = "tsm_PowerRebootRecovery";
			this.tsm_PowerRebootRecovery.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerRebootRecovery.Text = "Reboot Recovery";
			this.tsm_PowerRebootRecovery.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerRebootBootloader
			// 
			this.tsm_PowerRebootBootloader.Name = "tsm_PowerRebootBootloader";
			this.tsm_PowerRebootBootloader.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerRebootBootloader.Text = "Reboot Bootloader";
			this.tsm_PowerRebootBootloader.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerRebootFastboot
			// 
			this.tsm_PowerRebootFastboot.Name = "tsm_PowerRebootFastboot";
			this.tsm_PowerRebootFastboot.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerRebootFastboot.Text = "Reboot Fastboot";
			this.tsm_PowerRebootFastboot.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerSideloadMode
			// 
			this.tsm_PowerSideloadMode.Name = "tsm_PowerSideloadMode";
			this.tsm_PowerSideloadMode.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerSideloadMode.Text = "Sideload Mode";
			this.tsm_PowerSideloadMode.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerShutdown
			// 
			this.tsm_PowerShutdown.Name = "tsm_PowerShutdown";
			this.tsm_PowerShutdown.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerShutdown.Text = "Shutdown";
			this.tsm_PowerShutdown.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerSleep
			// 
			this.tsm_PowerSleep.Name = "tsm_PowerSleep";
			this.tsm_PowerSleep.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerSleep.Text = "Sleep";
			this.tsm_PowerSleep.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsd_WirelessAdb
			// 
			this.tsd_WirelessAdb.AutoToolTip = false;
			this.tsd_WirelessAdb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_IpAdress,
            this.tsm_WirelessConnect,
            this.tsm_WirelessDisconnect});
			this.tsd_WirelessAdb.Image = global::adbGUI.Properties.Resources.wifi;
			this.tsd_WirelessAdb.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsd_WirelessAdb.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.tsd_WirelessAdb.Name = "tsd_WirelessAdb";
			this.tsd_WirelessAdb.Size = new System.Drawing.Size(101, 20);
			this.tsd_WirelessAdb.Text = "Wireless ADB";
			// 
			// tst_IpAdress
			// 
			this.tst_IpAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tst_IpAdress.Name = "tst_IpAdress";
			this.tst_IpAdress.Size = new System.Drawing.Size(123, 20);
			this.tst_IpAdress.Text = "192.168.0.44:5555";
			// 
			// tsm_WirelessConnect
			// 
			this.tsm_WirelessConnect.Name = "tsm_WirelessConnect";
			this.tsm_WirelessConnect.Size = new System.Drawing.Size(183, 22);
			this.tsm_WirelessConnect.Text = "Connect Device";
			this.tsm_WirelessConnect.Click += new System.EventHandler(this.Tsm_WirelessConnect_Click);
			// 
			// tsm_WirelessDisconnect
			// 
			this.tsm_WirelessDisconnect.Name = "tsm_WirelessDisconnect";
			this.tsm_WirelessDisconnect.Size = new System.Drawing.Size(183, 22);
			this.tsm_WirelessDisconnect.Text = "Disconnect All";
			this.tsm_WirelessDisconnect.Click += new System.EventHandler(this.Tsm_WirelessDisconnect_Click);
			// 
			// tsb_KillServer
			// 
			this.tsb_KillServer.AutoToolTip = false;
			this.tsb_KillServer.Image = ((System.Drawing.Image)(resources.GetObject("tsb_KillServer.Image")));
			this.tsb_KillServer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_KillServer.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.tsb_KillServer.Name = "tsb_KillServer";
			this.tsb_KillServer.Size = new System.Drawing.Size(74, 20);
			this.tsb_KillServer.Text = "Kill Server";
			this.tsb_KillServer.Click += new System.EventHandler(this.Tsb_KillServer_Click);
			// 
			// tsb_OpenShell
			// 
			this.tsb_OpenShell.AutoToolTip = false;
			this.tsb_OpenShell.Image = ((System.Drawing.Image)(resources.GetObject("tsb_OpenShell.Image")));
			this.tsb_OpenShell.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_OpenShell.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.tsb_OpenShell.Name = "tsb_OpenShell";
			this.tsb_OpenShell.Size = new System.Drawing.Size(79, 20);
			this.tsb_OpenShell.Text = "Open Shell";
			this.tsb_OpenShell.Click += new System.EventHandler(this.Tsb_OpenShell_Click);
			// 
			// tsb_AdbRoot
			// 
			this.tsb_AdbRoot.AutoToolTip = false;
			this.tsb_AdbRoot.Image = global::adbGUI.Properties.Resources.hash;
			this.tsb_AdbRoot.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_AdbRoot.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.tsb_AdbRoot.Name = "tsb_AdbRoot";
			this.tsb_AdbRoot.Size = new System.Drawing.Size(75, 20);
			this.tsb_AdbRoot.Text = "ADB Root";
			this.tsb_AdbRoot.Click += new System.EventHandler(this.Tsb_AdbRoot_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(107, 20);
			this.toolStripLabel1.Text = "Connected Devices: ";
			// 
			// tsb_AdbUnroot
			// 
			this.tsb_AdbUnroot.AutoToolTip = false;
			this.tsb_AdbUnroot.Image = global::adbGUI.Properties.Resources.unroot;
			this.tsb_AdbUnroot.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_AdbUnroot.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.tsb_AdbUnroot.Name = "tsb_AdbUnroot";
			this.tsb_AdbUnroot.Size = new System.Drawing.Size(84, 20);
			this.tsb_AdbUnroot.Text = "ADB Unroot";
			this.tsb_AdbUnroot.Click += new System.EventHandler(this.Tsb_AdbUnroot_Click);
			// 
			// tsb_AlwayClearConsole
			// 
			this.tsb_AlwayClearConsole.CheckOnClick = true;
			this.tsb_AlwayClearConsole.Image = global::adbGUI.Properties.Resources.eraser;
			this.tsb_AlwayClearConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_AlwayClearConsole.Name = "tsb_AlwayClearConsole";
			this.tsb_AlwayClearConsole.Size = new System.Drawing.Size(128, 20);
			this.tsb_AlwayClearConsole.Text = "Always Clear Console";
			this.tsb_AlwayClearConsole.CheckedChanged += new System.EventHandler(this.Tsb_AlwayClearConsole_CheckedChanged);
			// 
			// btn_ConsoleClear
			// 
			this.btn_ConsoleClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ConsoleClear.Location = new System.Drawing.Point(969, 567);
			this.btn_ConsoleClear.Name = "btn_ConsoleClear";
			this.btn_ConsoleClear.Size = new System.Drawing.Size(54, 23);
			this.btn_ConsoleClear.TabIndex = 14;
			this.btn_ConsoleClear.Text = "Clear";
			this.btn_ConsoleClear.UseVisualStyleBackColor = true;
			this.btn_ConsoleClear.Click += new System.EventHandler(this.Btn_ConsoleClear_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.trv_commandTreeView);
			this.panel2.Location = new System.Drawing.Point(13, 39);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 550);
			this.panel2.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 601);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btn_ConsoleClear);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_consoleStop);
			this.Controls.Add(this.btn_executeCommand);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.cbx_customCommand);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(1050, 640);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "adbGUI";
			this.toolTip.SetToolTip(this, "Enter command without adb.");
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.panel1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.ToolTip toolTip;
            private System.Windows.Forms.Button btn_executeCommand;
            private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TreeView trv_commandTreeView;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consoleStop;
        private System.Windows.Forms.ComboBox cbx_customCommand;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsd_WirelessAdb;
        private System.Windows.Forms.ToolStripTextBox tst_IpAdress;
        private System.Windows.Forms.ToolStripMenuItem tsm_WirelessConnect;
        private System.Windows.Forms.ToolStripMenuItem tsm_WirelessDisconnect;
        private System.Windows.Forms.ToolStripButton tsb_KillServer;
        private System.Windows.Forms.ToolStripButton tsb_OpenShell;
        private System.Windows.Forms.ToolStripButton tsb_AdbRoot;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsb_AdbUnroot;
        internal System.Windows.Forms.ToolStripComboBox tsc_ConnectedDevices;
        private System.Windows.Forms.ToolStripDropDownButton tsd_Power;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootNormal;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootRecovery;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootBootloader;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootFastboot;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerSideloadMode;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerSleep;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerShutdown;
		private System.Windows.Forms.Button btn_ConsoleClear;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStripButton tsb_AlwayClearConsole;
	}
}

