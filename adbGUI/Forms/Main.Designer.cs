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
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("Files");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("Sideload");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("All User");
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("Max User");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("IMEI");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("Accounts");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("Backup Restore");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode277,
            treeNode278,
            treeNode279,
            treeNode280,
            treeNode281,
            treeNode282,
            treeNode283});
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("Screenshot");
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("Screenrecord");
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("Resolution");
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("Density");
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode285,
            treeNode286,
            treeNode287,
            treeNode288});
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("Get Prop");
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("Set Prop");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode290,
            treeNode291});
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("Battery Service State");
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode295,
            treeNode296,
            treeNode297});
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("Remount System");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode292,
            treeNode293,
            treeNode294,
            treeNode298,
            treeNode299,
            treeNode300,
            treeNode301,
            treeNode302,
            treeNode303,
            treeNode304,
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("Network Info");
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("Spoof MAC");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode307,
            treeNode308,
            treeNode309,
            treeNode310,
            treeNode311,
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("Install and Uninstall");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode314,
            treeNode315,
            treeNode316,
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("Clear all buffers");
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("Logcat Advanced");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode323,
            treeNode324,
            treeNode325,
            treeNode326,
            treeNode327,
            treeNode328,
            treeNode329});
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode319,
            treeNode320,
            treeNode321,
            treeNode322,
            treeNode330});
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("Dumpsys");
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode331,
            treeNode332,
            treeNode333});
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("Devices");
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("Fastboot", new System.Windows.Forms.TreeNode[] {
            treeNode335,
            treeNode336,
            treeNode337,
            treeNode338,
            treeNode339});
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode341,
            treeNode342});
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("Credits");
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            treeNode343,
            treeNode344});
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
            this.txt_DevicesAdb.Size = new System.Drawing.Size(1016, 50);
            this.txt_DevicesAdb.TabIndex = 5;
            // 
            // btn_executeCommand
            // 
            this.btn_executeCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_executeCommand.Location = new System.Drawing.Point(873, 527);
            this.btn_executeCommand.Name = "btn_executeCommand";
            this.btn_executeCommand.Size = new System.Drawing.Size(75, 23);
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
            treeNode277.Name = "Knoten0";
            treeNode277.Tag = "#files";
            treeNode277.Text = "Files";
            treeNode278.Name = "Knoten2";
            treeNode278.Tag = "#sideload";
            treeNode278.Text = "Sideload";
            treeNode279.Name = "Knoten15";
            treeNode279.Tag = "adb shell pm list users";
            treeNode279.Text = "All User";
            treeNode280.Name = "Knoten17";
            treeNode280.Tag = "adb shell pm get-max-users";
            treeNode280.Text = "Max User";
            treeNode281.Name = "Knoten19";
            treeNode281.Tag = "adb shell service call iphonesubinfo 1";
            treeNode281.Text = "IMEI";
            treeNode282.Name = "Knoten27";
            treeNode282.Tag = "adb shell dumpsys account";
            treeNode282.Text = "Accounts";
            treeNode283.Name = "Knoten3";
            treeNode283.Tag = "#backuprestore";
            treeNode283.Text = "Backup Restore";
            treeNode284.Name = "Knoten3";
            treeNode284.Text = "Phone";
            treeNode285.Name = "Knoten31";
            treeNode285.Tag = "#screenshot";
            treeNode285.Text = "Screenshot";
            treeNode285.ToolTipText = "Take a screenshot";
            treeNode286.Name = "Knoten0";
            treeNode286.Tag = "#screenrecord";
            treeNode286.Text = "Screenrecord";
            treeNode286.ToolTipText = "Record screen up to 3 minutes";
            treeNode287.Name = "Knoten1";
            treeNode287.Tag = "#resolution";
            treeNode287.Text = "Resolution";
            treeNode287.ToolTipText = "Change Resolution";
            treeNode288.Name = "Knoten2";
            treeNode288.Tag = "#density";
            treeNode288.Text = "Density";
            treeNode289.Name = "Knoten0";
            treeNode289.Text = "Display";
            treeNode290.Name = "Knoten4";
            treeNode290.Tag = "adb shell getprop";
            treeNode290.Text = "Get Prop";
            treeNode291.Name = "Knoten1";
            treeNode291.Tag = "#prop";
            treeNode291.Text = "Set Prop";
            treeNode292.Name = "Knoten0";
            treeNode292.Text = "Prop";
            treeNode293.Name = "Knoten8";
            treeNode293.Tag = "adb shell ps";
            treeNode293.Text = "Processes";
            treeNode294.Name = "Knoten9";
            treeNode294.Tag = "adb shell dumpsys meminfo";
            treeNode294.Text = "Memory";
            treeNode295.Name = "Knoten1";
            treeNode295.Tag = "adb shell dumpsys battery";
            treeNode295.Text = "Battery Service State";
            treeNode296.Name = "Knoten2";
            treeNode296.Tag = "adb shell dumpsys batterystats";
            treeNode296.Text = "Collected Battery Stats";
            treeNode297.Name = "Knoten3";
            treeNode297.Tag = "adb shell dumpsys batterystats --reset";
            treeNode297.Text = "Reset Battery Stats";
            treeNode298.Name = "Knoten22";
            treeNode298.Tag = "";
            treeNode298.Text = "Battery";
            treeNode299.Name = "Knoten12";
            treeNode299.Tag = "adb shell dumpsys alarm";
            treeNode299.Text = "Alarm Manager State";
            treeNode300.Name = "Knoten16";
            treeNode300.Tag = "adb shell uptime";
            treeNode300.Text = "Uptime";
            treeNode301.Name = "Knoten24";
            treeNode301.Tag = "adb shell dumpsys cpuinfo";
            treeNode301.Text = "CPU Info";
            treeNode302.Name = "Knoten26";
            treeNode302.Tag = "adb shell dumpsys diskstats";
            treeNode302.Text = "Diskstats";
            treeNode303.Name = "Knoten28";
            treeNode303.Tag = "adb shell pm list permissions";
            treeNode303.Text = "Permissions";
            treeNode304.Name = "Knoten0";
            treeNode304.Tag = "adb shell df -h";
            treeNode304.Text = "Filesystem";
            treeNode305.Name = "Knoten0";
            treeNode305.Tag = "adb remount";
            treeNode305.Text = "Remount System";
            treeNode306.Name = "Knoten0";
            treeNode306.Text = "System";
            treeNode307.Name = "Knoten7";
            treeNode307.Tag = "adb shell iftop";
            treeNode307.Text = "Network Traffic";
            treeNode308.Name = "Knoten25";
            treeNode308.Tag = "adb shell netstat";
            treeNode308.Text = "Netstat";
            treeNode309.Name = "Knoten23";
            treeNode309.Tag = "adb shell dumpsys wifi";
            treeNode309.Text = "WiFi Info";
            treeNode310.Name = "Knoten29";
            treeNode310.Tag = "adb shell cat /etc/hosts";
            treeNode310.Text = "Hosts";
            treeNode311.Name = "Knoten0";
            treeNode311.Tag = "adb shell ifconfig";
            treeNode311.Text = "Network Info";
            treeNode312.Name = "Knoten3";
            treeNode312.Tag = "#spoofmac";
            treeNode312.Text = "Spoof MAC";
            treeNode313.Name = "Knoten1";
            treeNode313.Text = "Network";
            treeNode314.Name = "Knoten11";
            treeNode314.Tag = "adb shell pm list packages -f";
            treeNode314.Text = "All packages";
            treeNode315.Name = "Knoten13";
            treeNode315.Tag = "adb shell pm list libraries";
            treeNode315.Text = "Libraries";
            treeNode316.Name = "Knoten10";
            treeNode316.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
            treeNode316.Text = "Features";
            treeNode317.Name = "Knoten1";
            treeNode317.Tag = "#installuninstall";
            treeNode317.Text = "Install and Uninstall";
            treeNode318.Name = "Knoten2";
            treeNode318.Text = "Packages";
            treeNode319.Name = "Knoten1";
            treeNode319.Tag = "adb logcat";
            treeNode319.Text = "Logcat Live";
            treeNode320.Name = "Knoten6";
            treeNode320.Tag = "adb logcat -d";
            treeNode320.Text = "Logcat Dump";
            treeNode321.Name = "Knoten0";
            treeNode321.Tag = "adb logcat -b all -c";
            treeNode321.Text = "Clear all buffers";
            treeNode322.Name = "Knoten0";
            treeNode322.Tag = "#logcatadvanced";
            treeNode322.Text = "Logcat Advanced";
            treeNode323.Name = "Knoten4";
            treeNode323.Tag = "adb logcat *:V";
            treeNode323.Text = "Verbose";
            treeNode324.Name = "Knoten5";
            treeNode324.Tag = "adb logcat *:D";
            treeNode324.Text = "Debug";
            treeNode325.Name = "Knoten6";
            treeNode325.Tag = "adb logcat *:I";
            treeNode325.Text = "Info";
            treeNode326.Name = "Knoten7";
            treeNode326.Tag = "adb logcat *:W";
            treeNode326.Text = "Warning";
            treeNode327.Name = "Knoten8";
            treeNode327.Tag = "adb logcat *:E";
            treeNode327.Text = "Error";
            treeNode328.Name = "Knoten9";
            treeNode328.Tag = "adb logcat *:F";
            treeNode328.Text = "Fatal";
            treeNode329.Name = "Knoten11";
            treeNode329.Tag = "adb logcat *:S";
            treeNode329.Text = "Silent";
            treeNode330.Name = "Knoten3";
            treeNode330.Text = "Filter";
            treeNode331.Name = "Knoten0";
            treeNode331.Text = "Logcat";
            treeNode332.Name = "Knoten5";
            treeNode332.Tag = "adb shell dumpsys";
            treeNode332.Text = "Dumpsys";
            treeNode333.Name = "Knoten21";
            treeNode333.Tag = "adb shell dmesg";
            treeNode333.Text = "Kernel Messages";
            treeNode334.Name = "Knoten20";
            treeNode334.Text = "Logs";
            treeNode335.Name = "Knoten2";
            treeNode335.Tag = "fastboot devices";
            treeNode335.Text = "Devices";
            treeNode336.Name = "Knoten4";
            treeNode336.Tag = "fastboot reboot";
            treeNode336.Text = "Reboot Normal";
            treeNode337.Name = "Knoten3";
            treeNode337.Tag = "fastboot reboot bootloader";
            treeNode337.Text = "Reboot Bootloader";
            treeNode338.Name = "Knoten1";
            treeNode338.Tag = "fastboot help";
            treeNode338.Text = "Help";
            treeNode339.Name = "Knoten3";
            treeNode339.Tag = "fastboot --version";
            treeNode339.Text = "Version";
            treeNode340.Name = "Knoten0";
            treeNode340.Text = "Fastboot";
            treeNode341.Name = "Knoten1";
            treeNode341.Tag = "adb help";
            treeNode341.Text = "Help";
            treeNode342.Name = "Knoten2";
            treeNode342.Tag = "adb version";
            treeNode342.Text = "Version";
            treeNode343.Name = "Knoten0";
            treeNode343.Text = "Adb";
            treeNode344.Name = "Knoten1";
            treeNode344.Tag = "#credits";
            treeNode344.Text = "Credits";
            treeNode345.Name = "Knoten0";
            treeNode345.Text = "About";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode284,
            treeNode289,
            treeNode306,
            treeNode313,
            treeNode318,
            treeNode334,
            treeNode340,
            treeNode345});
            this.trv_commandTreeView.Size = new System.Drawing.Size(200, 510);
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
            this.cbx_customCommand.Location = new System.Drawing.Point(218, 528);
            this.cbx_customCommand.Name = "cbx_customCommand";
            this.cbx_customCommand.Size = new System.Drawing.Size(649, 21);
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
            this.rtb_console.Size = new System.Drawing.Size(808, 480);
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
            this.panel1.Location = new System.Drawing.Point(218, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 482);
            this.panel1.TabIndex = 12;
            // 
            // btn_consoleStop
            // 
            this.btn_consoleStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consoleStop.Location = new System.Drawing.Point(954, 527);
            this.btn_consoleStop.Name = "btn_consoleStop";
            this.btn_consoleStop.Size = new System.Drawing.Size(75, 23);
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
            this.tsb_AlwaysClearConsole});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(12, 10, 11, 3);
            this.toolStrip1.Size = new System.Drawing.Size(1040, 36);
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
            this.tsd_Power.Image = global::adbGUI.Properties.Resources.power_button_off;
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
            this.tst_IpAdress.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_IpAdress.Name = "tst_IpAdress";
            this.tst_IpAdress.Size = new System.Drawing.Size(123, 18);
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
            // tsb_AlwaysClearConsole
            // 
            this.tsb_AlwaysClearConsole.AutoToolTip = false;
            this.tsb_AlwaysClearConsole.Checked = true;
            this.tsb_AlwaysClearConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsb_AlwaysClearConsole.Image = global::adbGUI.Properties.Resources.eraser;
            this.tsb_AlwaysClearConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AlwaysClearConsole.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.tsb_AlwaysClearConsole.Name = "tsb_AlwaysClearConsole";
            this.tsb_AlwaysClearConsole.Size = new System.Drawing.Size(123, 20);
            this.tsb_AlwaysClearConsole.Text = "Alway Clear Console";
            this.tsb_AlwaysClearConsole.Click += new System.EventHandler(this.Tsb_AlwaysClearConsole_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_consoleStop);
            this.Controls.Add(this.trv_commandTreeView);
            this.Controls.Add(this.btn_executeCommand);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbx_customCommand);
            this.Controls.Add(this.txt_DevicesAdb);
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
        private System.Windows.Forms.ToolStripDropDownButton tsd_Power;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootNormal;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootRecovery;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootBootloader;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootFastboot;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerSideloadMode;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerSleep;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerShutdown;
    }
}

