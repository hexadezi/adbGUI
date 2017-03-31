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
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("Files");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("Sideload");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("All User");
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("Max User");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("IMEI");
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("Accounts");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("Backup Restore");
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode309,
            treeNode310,
            treeNode311,
            treeNode312,
            treeNode313,
            treeNode314,
            treeNode315});
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("Screenshot");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("Screenrecord");
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("Resolution");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("Density");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode317,
            treeNode318,
            treeNode319,
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("Shutdown");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("Reboot Recovery");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("Reboot Fastboot");
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("Sideload Mode");
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("Sleep Mode");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("Power", new System.Windows.Forms.TreeNode[] {
            treeNode322,
            treeNode323,
            treeNode324,
            treeNode325,
            treeNode326,
            treeNode327,
            treeNode328});
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("Get Prop");
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("Set Prop");
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode330,
            treeNode331});
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("Battery Service State");
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode335,
            treeNode336,
            treeNode337});
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("Remount System");
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode332,
            treeNode333,
            treeNode334,
            treeNode338,
            treeNode339,
            treeNode340,
            treeNode341,
            treeNode342,
            treeNode343,
            treeNode344,
            treeNode345});
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("Network Info");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("Spoof MAC");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode347,
            treeNode348,
            treeNode349,
            treeNode350,
            treeNode351,
            treeNode352});
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("Install and Uninstall");
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode354,
            treeNode355,
            treeNode356,
            treeNode357});
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("Clear all buffers");
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("Logcat Advanced");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode363,
            treeNode364,
            treeNode365,
            treeNode366,
            treeNode367,
            treeNode368,
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode359,
            treeNode360,
            treeNode361,
            treeNode362,
            treeNode370});
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("Dumpsys Input Diagnostics");
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode371,
            treeNode372,
            treeNode373});
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("Devices");
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("Fastboot", new System.Windows.Forms.TreeNode[] {
            treeNode375,
            treeNode376,
            treeNode377,
            treeNode378,
            treeNode379});
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode381,
            treeNode382});
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("Credits");
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            treeNode383,
            treeNode384});
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
            treeNode309.Name = "Knoten0";
            treeNode309.Tag = "#files";
            treeNode309.Text = "Files";
            treeNode310.Name = "Knoten2";
            treeNode310.Tag = "#sideload";
            treeNode310.Text = "Sideload";
            treeNode311.Name = "Knoten15";
            treeNode311.Tag = "adb shell pm list users";
            treeNode311.Text = "All User";
            treeNode312.Name = "Knoten17";
            treeNode312.Tag = "adb shell pm get-max-users";
            treeNode312.Text = "Max User";
            treeNode313.Name = "Knoten19";
            treeNode313.Tag = "adb shell service call iphonesubinfo 1";
            treeNode313.Text = "IMEI";
            treeNode314.Name = "Knoten27";
            treeNode314.Tag = "adb shell dumpsys account";
            treeNode314.Text = "Accounts";
            treeNode315.Name = "Knoten3";
            treeNode315.Tag = "#backuprestore";
            treeNode315.Text = "Backup Restore";
            treeNode316.Name = "Knoten3";
            treeNode316.Text = "Phone";
            treeNode317.Name = "Knoten31";
            treeNode317.Tag = "#screenshot";
            treeNode317.Text = "Screenshot";
            treeNode317.ToolTipText = "Take a screenshot";
            treeNode318.Name = "Knoten0";
            treeNode318.Tag = "#screenrecord";
            treeNode318.Text = "Screenrecord";
            treeNode318.ToolTipText = "Record screen up to 3 minutes";
            treeNode319.Name = "Knoten1";
            treeNode319.Tag = "#resolution";
            treeNode319.Text = "Resolution";
            treeNode319.ToolTipText = "Change Resolution";
            treeNode320.Name = "Knoten2";
            treeNode320.Tag = "#density";
            treeNode320.Text = "Density";
            treeNode321.Name = "Knoten0";
            treeNode321.Text = "Display";
            treeNode322.Name = "Knoten1";
            treeNode322.Tag = "adb shell reboot -p";
            treeNode322.Text = "Shutdown";
            treeNode323.Name = "Knoten2";
            treeNode323.Tag = "adb reboot";
            treeNode323.Text = "Reboot Normal";
            treeNode324.Name = "Knoten3";
            treeNode324.Tag = "adb reboot bootloader";
            treeNode324.Text = "Reboot Bootloader";
            treeNode325.Name = "Knoten5";
            treeNode325.Tag = "adb reboot recovery";
            treeNode325.Text = "Reboot Recovery";
            treeNode326.Name = "Knoten0";
            treeNode326.Tag = "adb reboot fastboot";
            treeNode326.Text = "Reboot Fastboot";
            treeNode327.Name = "Knoten4";
            treeNode327.Tag = "adb reboot sideload";
            treeNode327.Text = "Sideload Mode";
            treeNode328.Name = "Knoten6";
            treeNode328.Tag = "adb shell input keyevent POWER";
            treeNode328.Text = "Sleep Mode";
            treeNode329.Name = "Knoten0";
            treeNode329.Text = "Power";
            treeNode330.Name = "Knoten4";
            treeNode330.Tag = "adb shell getprop";
            treeNode330.Text = "Get Prop";
            treeNode331.Name = "Knoten1";
            treeNode331.Tag = "#prop";
            treeNode331.Text = "Set Prop";
            treeNode332.Name = "Knoten0";
            treeNode332.Text = "Prop";
            treeNode333.Name = "Knoten8";
            treeNode333.Tag = "adb shell ps";
            treeNode333.Text = "Processes";
            treeNode334.Name = "Knoten9";
            treeNode334.Tag = "adb shell dumpsys meminfo";
            treeNode334.Text = "Memory";
            treeNode335.Name = "Knoten1";
            treeNode335.Tag = "adb shell dumpsys battery";
            treeNode335.Text = "Battery Service State";
            treeNode336.Name = "Knoten2";
            treeNode336.Tag = "adb shell dumpsys batterystats";
            treeNode336.Text = "Collected Battery Stats";
            treeNode337.Name = "Knoten3";
            treeNode337.Tag = "adb shell dumpsys batterystats --reset";
            treeNode337.Text = "Reset Battery Stats";
            treeNode338.Name = "Knoten22";
            treeNode338.Tag = "";
            treeNode338.Text = "Battery";
            treeNode339.Name = "Knoten12";
            treeNode339.Tag = "adb shell dumpsys alarm";
            treeNode339.Text = "Alarm Manager State";
            treeNode340.Name = "Knoten16";
            treeNode340.Tag = "adb shell uptime";
            treeNode340.Text = "Uptime";
            treeNode341.Name = "Knoten24";
            treeNode341.Tag = "adb shell dumpsys cpuinfo";
            treeNode341.Text = "CPU Info";
            treeNode342.Name = "Knoten26";
            treeNode342.Tag = "adb shell dumpsys diskstats";
            treeNode342.Text = "Diskstats";
            treeNode343.Name = "Knoten28";
            treeNode343.Tag = "adb shell pm list permissions";
            treeNode343.Text = "Permissions";
            treeNode344.Name = "Knoten0";
            treeNode344.Tag = "adb shell df -h";
            treeNode344.Text = "Filesystem";
            treeNode345.Name = "Knoten0";
            treeNode345.Tag = "adb remount";
            treeNode345.Text = "Remount System";
            treeNode346.Name = "Knoten0";
            treeNode346.Text = "System";
            treeNode347.Name = "Knoten7";
            treeNode347.Tag = "adb shell iftop";
            treeNode347.Text = "Network Traffic";
            treeNode348.Name = "Knoten25";
            treeNode348.Tag = "adb shell netstat";
            treeNode348.Text = "Netstat";
            treeNode349.Name = "Knoten23";
            treeNode349.Tag = "adb shell dumpsys wifi";
            treeNode349.Text = "WiFi Info";
            treeNode350.Name = "Knoten29";
            treeNode350.Tag = "adb shell cat /etc/hosts";
            treeNode350.Text = "Hosts";
            treeNode351.Name = "Knoten0";
            treeNode351.Tag = "adb shell ifconfig";
            treeNode351.Text = "Network Info";
            treeNode352.Name = "Knoten3";
            treeNode352.Tag = "#spoofmac";
            treeNode352.Text = "Spoof MAC";
            treeNode353.Name = "Knoten1";
            treeNode353.Text = "Network";
            treeNode354.Name = "Knoten11";
            treeNode354.Tag = "adb shell pm list packages -f";
            treeNode354.Text = "All packages";
            treeNode355.Name = "Knoten13";
            treeNode355.Tag = "adb shell pm list libraries";
            treeNode355.Text = "Libraries";
            treeNode356.Name = "Knoten10";
            treeNode356.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
            treeNode356.Text = "Features";
            treeNode357.Name = "Knoten1";
            treeNode357.Tag = "#installuninstall";
            treeNode357.Text = "Install and Uninstall";
            treeNode358.Name = "Knoten2";
            treeNode358.Text = "Packages";
            treeNode359.Name = "Knoten1";
            treeNode359.Tag = "adb logcat";
            treeNode359.Text = "Logcat Live";
            treeNode360.Name = "Knoten6";
            treeNode360.Tag = "adb logcat -d";
            treeNode360.Text = "Logcat Dump";
            treeNode361.Name = "Knoten0";
            treeNode361.Tag = "adb logcat -b all -c";
            treeNode361.Text = "Clear all buffers";
            treeNode362.Name = "Knoten0";
            treeNode362.Tag = "#logcatadvanced";
            treeNode362.Text = "Logcat Advanced";
            treeNode363.Name = "Knoten4";
            treeNode363.Tag = "adb logcat *:V";
            treeNode363.Text = "Verbose";
            treeNode364.Name = "Knoten5";
            treeNode364.Tag = "adb logcat *:D";
            treeNode364.Text = "Debug";
            treeNode365.Name = "Knoten6";
            treeNode365.Tag = "adb logcat *:I";
            treeNode365.Text = "Info";
            treeNode366.Name = "Knoten7";
            treeNode366.Tag = "adb logcat *:W";
            treeNode366.Text = "Warning";
            treeNode367.Name = "Knoten8";
            treeNode367.Tag = "adb logcat *:E";
            treeNode367.Text = "Error";
            treeNode368.Name = "Knoten9";
            treeNode368.Tag = "adb logcat *:F";
            treeNode368.Text = "Fatal";
            treeNode369.Name = "Knoten11";
            treeNode369.Tag = "adb logcat *:S";
            treeNode369.Text = "Silent";
            treeNode370.Name = "Knoten3";
            treeNode370.Text = "Filter";
            treeNode371.Name = "Knoten0";
            treeNode371.Text = "Logcat";
            treeNode372.Name = "Knoten5";
            treeNode372.Tag = "adb shell dumpsys";
            treeNode372.Text = "Dumpsys Input Diagnostics";
            treeNode373.Name = "Knoten21";
            treeNode373.Tag = "adb shell dmesg";
            treeNode373.Text = "Kernel Messages";
            treeNode374.Name = "Knoten20";
            treeNode374.Text = "Logs";
            treeNode375.Name = "Knoten2";
            treeNode375.Tag = "fastboot devices";
            treeNode375.Text = "Devices";
            treeNode376.Name = "Knoten4";
            treeNode376.Tag = "fastboot reboot";
            treeNode376.Text = "Reboot Normal";
            treeNode377.Name = "Knoten3";
            treeNode377.Tag = "fastboot reboot bootloader";
            treeNode377.Text = "Reboot Bootloader";
            treeNode378.Name = "Knoten1";
            treeNode378.Tag = "fastboot help";
            treeNode378.Text = "Help";
            treeNode379.Name = "Knoten3";
            treeNode379.Tag = "fastboot --version";
            treeNode379.Text = "Version";
            treeNode380.Name = "Knoten0";
            treeNode380.Text = "Fastboot";
            treeNode381.Name = "Knoten1";
            treeNode381.Tag = "adb help";
            treeNode381.Text = "Help";
            treeNode382.Name = "Knoten2";
            treeNode382.Tag = "adb version";
            treeNode382.Text = "Version";
            treeNode383.Name = "Knoten0";
            treeNode383.Text = "Adb";
            treeNode384.Name = "Knoten1";
            treeNode384.Tag = "#credits";
            treeNode384.Text = "Credits";
            treeNode385.Name = "Knoten0";
            treeNode385.Text = "About";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode316,
            treeNode321,
            treeNode329,
            treeNode346,
            treeNode353,
            treeNode358,
            treeNode374,
            treeNode380,
            treeNode385});
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
            this.rtb_console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_console.Size = new System.Drawing.Size(803, 480);
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
        public System.Windows.Forms.ToolStripComboBox tsc_ConnectedDevices;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsb_AdbUnroot;
        private System.Windows.Forms.ToolStripButton tsb_AlwaysClearConsole;
    }
}

