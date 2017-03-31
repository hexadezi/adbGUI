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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Files");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sideload");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("All User");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Max User");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("IMEI");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Accounts");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Backup Restore");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Screenshot");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Screenrecord");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Resolution");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Density");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Shutdown");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Reboot Recovery");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Reboot Fastboot");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Sideload Mode");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Sleep Mode");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Power", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Get Prop");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Set Prop");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Battery Service State");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Remount System");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Network Info");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Spoof MAC");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Install and Uninstall");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Clear all buffers");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Logcat Advanced");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Dumpsys Input Diagnostics");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode63,
            treeNode64,
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Devices");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Fastboot", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode68,
            treeNode69,
            treeNode70,
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Credits");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            treeNode75,
            treeNode76});
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
            this.trv_commandTreeView.Location = new System.Drawing.Point(12, 40);
            this.trv_commandTreeView.Name = "trv_commandTreeView";
            treeNode1.Name = "Knoten0";
            treeNode1.Tag = "#files";
            treeNode1.Text = "Files";
            treeNode2.Name = "Knoten2";
            treeNode2.Tag = "#sideload";
            treeNode2.Text = "Sideload";
            treeNode3.Name = "Knoten15";
            treeNode3.Tag = "adb shell pm list users";
            treeNode3.Text = "All User";
            treeNode4.Name = "Knoten17";
            treeNode4.Tag = "adb shell pm get-max-users";
            treeNode4.Text = "Max User";
            treeNode5.Name = "Knoten19";
            treeNode5.Tag = "adb shell service call iphonesubinfo 1";
            treeNode5.Text = "IMEI";
            treeNode6.Name = "Knoten27";
            treeNode6.Tag = "adb shell dumpsys account";
            treeNode6.Text = "Accounts";
            treeNode7.Name = "Knoten3";
            treeNode7.Tag = "#backuprestore";
            treeNode7.Text = "Backup Restore";
            treeNode8.Name = "Knoten3";
            treeNode8.Text = "Phone";
            treeNode9.Name = "Knoten31";
            treeNode9.Tag = "#screenshot";
            treeNode9.Text = "Screenshot";
            treeNode9.ToolTipText = "Take a screenshot";
            treeNode10.Name = "Knoten0";
            treeNode10.Tag = "#screenrecord";
            treeNode10.Text = "Screenrecord";
            treeNode10.ToolTipText = "Record screen up to 3 minutes";
            treeNode11.Name = "Knoten1";
            treeNode11.Tag = "#resolution";
            treeNode11.Text = "Resolution";
            treeNode11.ToolTipText = "Change Resolution";
            treeNode12.Name = "Knoten2";
            treeNode12.Tag = "#density";
            treeNode12.Text = "Density";
            treeNode13.Name = "Knoten0";
            treeNode13.Text = "Display";
            treeNode14.Name = "Knoten1";
            treeNode14.Tag = "adb shell reboot -p";
            treeNode14.Text = "Shutdown";
            treeNode15.Name = "Knoten2";
            treeNode15.Tag = "adb reboot";
            treeNode15.Text = "Reboot Normal";
            treeNode16.Name = "Knoten3";
            treeNode16.Tag = "adb reboot bootloader";
            treeNode16.Text = "Reboot Bootloader";
            treeNode17.Name = "Knoten5";
            treeNode17.Tag = "adb reboot recovery";
            treeNode17.Text = "Reboot Recovery";
            treeNode18.Name = "Knoten0";
            treeNode18.Tag = "adb reboot fastboot";
            treeNode18.Text = "Reboot Fastboot";
            treeNode19.Name = "Knoten4";
            treeNode19.Tag = "adb reboot sideload";
            treeNode19.Text = "Sideload Mode";
            treeNode20.Name = "Knoten6";
            treeNode20.Tag = "adb shell input keyevent POWER";
            treeNode20.Text = "Sleep Mode";
            treeNode21.Name = "Knoten0";
            treeNode21.Text = "Power";
            treeNode22.Name = "Knoten4";
            treeNode22.Tag = "adb shell getprop";
            treeNode22.Text = "Get Prop";
            treeNode23.Name = "Knoten1";
            treeNode23.Tag = "#prop";
            treeNode23.Text = "Set Prop";
            treeNode24.Name = "Knoten0";
            treeNode24.Text = "Prop";
            treeNode25.Name = "Knoten8";
            treeNode25.Tag = "adb shell ps";
            treeNode25.Text = "Processes";
            treeNode26.Name = "Knoten9";
            treeNode26.Tag = "adb shell dumpsys meminfo";
            treeNode26.Text = "Memory";
            treeNode27.Name = "Knoten1";
            treeNode27.Tag = "adb shell dumpsys battery";
            treeNode27.Text = "Battery Service State";
            treeNode28.Name = "Knoten2";
            treeNode28.Tag = "adb shell dumpsys batterystats";
            treeNode28.Text = "Collected Battery Stats";
            treeNode29.Name = "Knoten3";
            treeNode29.Tag = "adb shell dumpsys batterystats --reset";
            treeNode29.Text = "Reset Battery Stats";
            treeNode30.Name = "Knoten22";
            treeNode30.Tag = "";
            treeNode30.Text = "Battery";
            treeNode31.Name = "Knoten12";
            treeNode31.Tag = "adb shell dumpsys alarm";
            treeNode31.Text = "Alarm Manager State";
            treeNode32.Name = "Knoten16";
            treeNode32.Tag = "adb shell uptime";
            treeNode32.Text = "Uptime";
            treeNode33.Name = "Knoten24";
            treeNode33.Tag = "adb shell dumpsys cpuinfo";
            treeNode33.Text = "CPU Info";
            treeNode34.Name = "Knoten26";
            treeNode34.Tag = "adb shell dumpsys diskstats";
            treeNode34.Text = "Diskstats";
            treeNode35.Name = "Knoten28";
            treeNode35.Tag = "adb shell pm list permissions";
            treeNode35.Text = "Permissions";
            treeNode36.Name = "Knoten0";
            treeNode36.Tag = "adb shell df -h";
            treeNode36.Text = "Filesystem";
            treeNode37.Name = "Knoten0";
            treeNode37.Tag = "adb remount";
            treeNode37.Text = "Remount System";
            treeNode38.Name = "Knoten0";
            treeNode38.Text = "System";
            treeNode39.Name = "Knoten7";
            treeNode39.Tag = "adb shell iftop";
            treeNode39.Text = "Network Traffic";
            treeNode40.Name = "Knoten25";
            treeNode40.Tag = "adb shell netstat";
            treeNode40.Text = "Netstat";
            treeNode41.Name = "Knoten23";
            treeNode41.Tag = "adb shell dumpsys wifi";
            treeNode41.Text = "WiFi Info";
            treeNode42.Name = "Knoten29";
            treeNode42.Tag = "adb shell cat /etc/hosts";
            treeNode42.Text = "Hosts";
            treeNode43.Name = "Knoten0";
            treeNode43.Tag = "adb shell ifconfig";
            treeNode43.Text = "Network Info";
            treeNode44.Name = "Knoten3";
            treeNode44.Tag = "#spoofmac";
            treeNode44.Text = "Spoof MAC";
            treeNode45.Name = "Knoten1";
            treeNode45.Text = "Network";
            treeNode46.Name = "Knoten11";
            treeNode46.Tag = "adb shell pm list packages -f";
            treeNode46.Text = "All packages";
            treeNode47.Name = "Knoten13";
            treeNode47.Tag = "adb shell pm list libraries";
            treeNode47.Text = "Libraries";
            treeNode48.Name = "Knoten10";
            treeNode48.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
            treeNode48.Text = "Features";
            treeNode49.Name = "Knoten1";
            treeNode49.Tag = "#installuninstall";
            treeNode49.Text = "Install and Uninstall";
            treeNode50.Name = "Knoten2";
            treeNode50.Text = "Packages";
            treeNode51.Name = "Knoten1";
            treeNode51.Tag = "adb logcat";
            treeNode51.Text = "Logcat Live";
            treeNode52.Name = "Knoten6";
            treeNode52.Tag = "adb logcat -d";
            treeNode52.Text = "Logcat Dump";
            treeNode53.Name = "Knoten0";
            treeNode53.Tag = "adb logcat -b all -c";
            treeNode53.Text = "Clear all buffers";
            treeNode54.Name = "Knoten0";
            treeNode54.Tag = "#logcatadvanced";
            treeNode54.Text = "Logcat Advanced";
            treeNode55.Name = "Knoten4";
            treeNode55.Tag = "adb logcat *:V";
            treeNode55.Text = "Verbose";
            treeNode56.Name = "Knoten5";
            treeNode56.Tag = "adb logcat *:D";
            treeNode56.Text = "Debug";
            treeNode57.Name = "Knoten6";
            treeNode57.Tag = "adb logcat *:I";
            treeNode57.Text = "Info";
            treeNode58.Name = "Knoten7";
            treeNode58.Tag = "adb logcat *:W";
            treeNode58.Text = "Warning";
            treeNode59.Name = "Knoten8";
            treeNode59.Tag = "adb logcat *:E";
            treeNode59.Text = "Error";
            treeNode60.Name = "Knoten9";
            treeNode60.Tag = "adb logcat *:F";
            treeNode60.Text = "Fatal";
            treeNode61.Name = "Knoten11";
            treeNode61.Tag = "adb logcat *:S";
            treeNode61.Text = "Silent";
            treeNode62.Name = "Knoten3";
            treeNode62.Text = "Filter";
            treeNode63.Name = "Knoten0";
            treeNode63.Text = "Logcat";
            treeNode64.Name = "Knoten5";
            treeNode64.Tag = "adb shell dumpsys";
            treeNode64.Text = "Dumpsys Input Diagnostics";
            treeNode65.Name = "Knoten21";
            treeNode65.Tag = "adb shell dmesg";
            treeNode65.Text = "Kernel Messages";
            treeNode66.Name = "Knoten20";
            treeNode66.Text = "Logs";
            treeNode67.Name = "Knoten2";
            treeNode67.Tag = "fastboot devices";
            treeNode67.Text = "Devices";
            treeNode68.Name = "Knoten4";
            treeNode68.Tag = "fastboot reboot";
            treeNode68.Text = "Reboot Normal";
            treeNode69.Name = "Knoten3";
            treeNode69.Tag = "fastboot reboot bootloader";
            treeNode69.Text = "Reboot Bootloader";
            treeNode70.Name = "Knoten1";
            treeNode70.Tag = "fastboot help";
            treeNode70.Text = "Help";
            treeNode71.Name = "Knoten3";
            treeNode71.Tag = "fastboot --version";
            treeNode71.Text = "Version";
            treeNode72.Name = "Knoten0";
            treeNode72.Text = "Fastboot";
            treeNode73.Name = "Knoten1";
            treeNode73.Tag = "adb help";
            treeNode73.Text = "Help";
            treeNode74.Name = "Knoten2";
            treeNode74.Tag = "adb version";
            treeNode74.Text = "Version";
            treeNode75.Name = "Knoten0";
            treeNode75.Text = "Adb";
            treeNode76.Name = "Knoten1";
            treeNode76.Tag = "#credits";
            treeNode76.Text = "Credits";
            treeNode77.Name = "Knoten0";
            treeNode77.Text = "About";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode13,
            treeNode21,
            treeNode38,
            treeNode45,
            treeNode50,
            treeNode66,
            treeNode72,
            treeNode77});
            this.trv_commandTreeView.Size = new System.Drawing.Size(199, 509);
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
            this.rtb_console.Size = new System.Drawing.Size(803, 480);
            this.rtb_console.TabIndex = 11;
            this.rtb_console.Text = "";
            this.rtb_console.WordWrap = false;
            this.rtb_console.Resize += new System.EventHandler(this.Rtb_console_Resize);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtb_console);
            this.panel1.Location = new System.Drawing.Point(217, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 482);
            this.panel1.TabIndex = 12;
            // 
            // btn_consoleStop
            // 
            this.btn_consoleStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consoleStop.Location = new System.Drawing.Point(948, 528);
            this.btn_consoleStop.Name = "btn_consoleStop";
            this.btn_consoleStop.Size = new System.Drawing.Size(75, 22);
            this.btn_consoleStop.TabIndex = 1;
            this.btn_consoleStop.Text = "Stop";
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
            this.tsc_ConnectedDevices.Size = new System.Drawing.Size(150, 23);
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
            this.tsb_KillServer.AutoToolTip = false;
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
            this.tsb_OpenShell.AutoToolTip = false;
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
            this.tsb_AdbRoot.AutoToolTip = false;
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
            this.tsb_AdbUnroot.AutoToolTip = false;
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
            this.tsb_AlwaysClearConsole.AutoToolTip = false;
            this.tsb_AlwaysClearConsole.Checked = true;
            this.tsb_AlwaysClearConsole.CheckState = System.Windows.Forms.CheckState.Checked;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsb_AdbUnroot;
        internal System.Windows.Forms.ToolStripComboBox tsc_ConnectedDevices;
        internal System.Windows.Forms.ToolStripButton tsb_AlwaysClearConsole;
    }
}

