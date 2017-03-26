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
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Sideload Mode");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Sleep Mode");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Power", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Get Prop");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Set Prop");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Battery Service State");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Network Info");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Spoof MAC");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Install and Uninstall");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Dumpsys Input Diagnostics");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58,
            treeNode59});
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode51,
            treeNode52,
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode49,
            treeNode50,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode63,
            treeNode64});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txt_devices = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_clearEverytime = new System.Windows.Forms.CheckBox();
            this.btn_adbUnroot = new System.Windows.Forms.Button();
            this.btn_adbRoot = new System.Windows.Forms.Button();
            this.btn_remountSystem = new System.Windows.Forms.Button();
            this.btn_killServer = new System.Windows.Forms.Button();
            this.btn_openShell = new System.Windows.Forms.Button();
            this.btn_executeCommand = new System.Windows.Forms.Button();
            this.trv_commandTreeView = new System.Windows.Forms.TreeView();
            this.cbx_connectedDevices = new System.Windows.Forms.ComboBox();
            this.btn_disconnectWirelessDevices = new System.Windows.Forms.Button();
            this.txt_wirelessDeviceIp = new System.Windows.Forms.TextBox();
            this.btn_connectWirelessDevice = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbx_customCommand = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbox_wireless = new System.Windows.Forms.GroupBox();
            this.gbox_devices = new System.Windows.Forms.GroupBox();
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_consoleStop = new System.Windows.Forms.Button();
            this.btn_consoleClear = new System.Windows.Forms.Button();
            timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.gbox_wireless.SuspendLayout();
            this.gbox_devices.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 200;
            timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // txt_devices
            // 
            this.txt_devices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_devices.Enabled = false;
            this.txt_devices.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_devices.Location = new System.Drawing.Point(12, 473);
            this.txt_devices.Multiline = true;
            this.txt_devices.Name = "txt_devices";
            this.txt_devices.Size = new System.Drawing.Size(1010, 78);
            this.txt_devices.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbo_clearEverytime);
            this.groupBox1.Controls.Add(this.btn_adbUnroot);
            this.groupBox1.Controls.Add(this.btn_adbRoot);
            this.groupBox1.Controls.Add(this.btn_remountSystem);
            this.groupBox1.Controls.Add(this.btn_killServer);
            this.groupBox1.Controls.Add(this.btn_openShell);
            this.groupBox1.Location = new System.Drawing.Point(509, 557);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Commands";
            // 
            // cbo_clearEverytime
            // 
            this.cbo_clearEverytime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_clearEverytime.AutoSize = true;
            this.cbo_clearEverytime.Location = new System.Drawing.Point(411, 23);
            this.cbo_clearEverytime.Name = "cbo_clearEverytime";
            this.cbo_clearEverytime.Size = new System.Drawing.Size(98, 17);
            this.cbo_clearEverytime.TabIndex = 8;
            this.cbo_clearEverytime.Text = "Clear everytime";
            this.cbo_clearEverytime.UseVisualStyleBackColor = true;
            // 
            // btn_adbUnroot
            // 
            this.btn_adbUnroot.Location = new System.Drawing.Point(330, 19);
            this.btn_adbUnroot.Name = "btn_adbUnroot";
            this.btn_adbUnroot.Size = new System.Drawing.Size(75, 23);
            this.btn_adbUnroot.TabIndex = 7;
            this.btn_adbUnroot.Text = "ADB Unroot";
            this.btn_adbUnroot.UseVisualStyleBackColor = true;
            this.btn_adbUnroot.Click += new System.EventHandler(this.Btn_adbUnroot_Click);
            // 
            // btn_adbRoot
            // 
            this.btn_adbRoot.Location = new System.Drawing.Point(249, 19);
            this.btn_adbRoot.Name = "btn_adbRoot";
            this.btn_adbRoot.Size = new System.Drawing.Size(75, 23);
            this.btn_adbRoot.TabIndex = 6;
            this.btn_adbRoot.Text = "ADB Root";
            this.btn_adbRoot.UseVisualStyleBackColor = true;
            this.btn_adbRoot.Click += new System.EventHandler(this.Btn_adbRoot_Click);
            // 
            // btn_remountSystem
            // 
            this.btn_remountSystem.Location = new System.Drawing.Point(168, 19);
            this.btn_remountSystem.Name = "btn_remountSystem";
            this.btn_remountSystem.Size = new System.Drawing.Size(75, 23);
            this.btn_remountSystem.TabIndex = 3;
            this.btn_remountSystem.Text = "Remount";
            this.toolTip.SetToolTip(this.btn_remountSystem, "Remounts the /system partition on the device read-write");
            this.btn_remountSystem.UseVisualStyleBackColor = true;
            this.btn_remountSystem.Click += new System.EventHandler(this.Btn_remountSystemClick);
            // 
            // btn_killServer
            // 
            this.btn_killServer.AccessibleDescription = "";
            this.btn_killServer.Location = new System.Drawing.Point(6, 19);
            this.btn_killServer.Name = "btn_killServer";
            this.btn_killServer.Size = new System.Drawing.Size(75, 23);
            this.btn_killServer.TabIndex = 2;
            this.btn_killServer.Text = "Kill Server";
            this.toolTip.SetToolTip(this.btn_killServer, "Restart the adb process");
            this.btn_killServer.UseVisualStyleBackColor = true;
            this.btn_killServer.Click += new System.EventHandler(this.Btn_killServer_Click);
            // 
            // btn_openShell
            // 
            this.btn_openShell.AccessibleDescription = "";
            this.btn_openShell.Location = new System.Drawing.Point(87, 19);
            this.btn_openShell.Name = "btn_openShell";
            this.btn_openShell.Size = new System.Drawing.Size(75, 23);
            this.btn_openShell.TabIndex = 5;
            this.btn_openShell.Text = "Open Shell";
            this.toolTip.SetToolTip(this.btn_openShell, "Open the shell");
            this.btn_openShell.UseVisualStyleBackColor = true;
            this.btn_openShell.Click += new System.EventHandler(this.Btn_openShell_Click);
            // 
            // btn_executeCommand
            // 
            this.btn_executeCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_executeCommand.Location = new System.Drawing.Point(786, 446);
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
            this.trv_commandTreeView.Location = new System.Drawing.Point(12, 12);
            this.trv_commandTreeView.Name = "trv_commandTreeView";
            treeNode1.Name = "Knoten0";
            treeNode1.Tag = "#files";
            treeNode1.Text = "Files";
            treeNode2.Name = "Knoten2";
            treeNode2.Tag = "#sideload";
            treeNode2.Text = "Sideload";
            treeNode3.Name = "Knoten15";
            treeNode3.Tag = "shell pm list users";
            treeNode3.Text = "All User";
            treeNode4.Name = "Knoten17";
            treeNode4.Tag = "shell pm get-max-users";
            treeNode4.Text = "Max User";
            treeNode5.Name = "Knoten19";
            treeNode5.Tag = "shell service call iphonesubinfo 1";
            treeNode5.Text = "IMEI";
            treeNode6.Name = "Knoten27";
            treeNode6.Tag = "shell dumpsys account";
            treeNode6.Text = "Accounts";
            treeNode7.Name = "Knoten3";
            treeNode7.Tag = "#backuprestore";
            treeNode7.Text = "Backup Restore";
            treeNode8.Name = "Knoten3";
            treeNode8.Text = "Phone";
            treeNode9.Name = "Knoten31";
            treeNode9.Tag = "shell screencap -p > screen.png";
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
            treeNode14.Tag = "shell reboot -p";
            treeNode14.Text = "Shutdown";
            treeNode15.Name = "Knoten2";
            treeNode15.Tag = "reboot";
            treeNode15.Text = "Reboot Normal";
            treeNode16.Name = "Knoten3";
            treeNode16.Tag = "reboot bootloader";
            treeNode16.Text = "Reboot Bootloader";
            treeNode17.Name = "Knoten5";
            treeNode17.Tag = "reboot recovery";
            treeNode17.Text = "Reboot Recovery";
            treeNode18.Name = "Knoten4";
            treeNode18.Tag = "reboot sideload";
            treeNode18.Text = "Sideload Mode";
            treeNode19.Name = "Knoten6";
            treeNode19.Tag = "shell input keyevent POWER";
            treeNode19.Text = "Sleep Mode";
            treeNode20.Name = "Knoten0";
            treeNode20.Text = "Power";
            treeNode21.Name = "Knoten4";
            treeNode21.Tag = "shell getprop";
            treeNode21.Text = "Get Prop";
            treeNode22.Name = "Knoten1";
            treeNode22.Tag = "#prop";
            treeNode22.Text = "Set Prop";
            treeNode23.Name = "Knoten0";
            treeNode23.Text = "Prop";
            treeNode24.Name = "Knoten8";
            treeNode24.Tag = "shell ps";
            treeNode24.Text = "Processes";
            treeNode25.Name = "Knoten9";
            treeNode25.Tag = "shell dumpsys meminfo";
            treeNode25.Text = "Memory";
            treeNode26.Name = "Knoten1";
            treeNode26.Tag = "shell dumpsys battery";
            treeNode26.Text = "Battery Service State";
            treeNode27.Name = "Knoten2";
            treeNode27.Tag = "shell dumpsys batterystats";
            treeNode27.Text = "Collected Battery Stats";
            treeNode28.Name = "Knoten3";
            treeNode28.Tag = "shell dumpsys batterystats --reset";
            treeNode28.Text = "Reset Battery Stats";
            treeNode29.Name = "Knoten22";
            treeNode29.Tag = "";
            treeNode29.Text = "Battery";
            treeNode30.Name = "Knoten12";
            treeNode30.Tag = "shell dumpsys alarm";
            treeNode30.Text = "Alarm Manager State";
            treeNode31.Name = "Knoten16";
            treeNode31.Tag = "shell uptime";
            treeNode31.Text = "Uptime";
            treeNode32.Name = "Knoten24";
            treeNode32.Tag = "shell dumpsys cpuinfo";
            treeNode32.Text = "CPU Info";
            treeNode33.Name = "Knoten26";
            treeNode33.Tag = "shell dumpsys diskstats";
            treeNode33.Text = "Diskstats";
            treeNode34.Name = "Knoten28";
            treeNode34.Tag = "shell pm list permissions";
            treeNode34.Text = "Permissions";
            treeNode35.Name = "Knoten0";
            treeNode35.Tag = "shell df -h";
            treeNode35.Text = "Filesystem";
            treeNode36.Name = "Knoten0";
            treeNode36.Text = "System";
            treeNode37.Name = "Knoten7";
            treeNode37.Tag = "shell iftop";
            treeNode37.Text = "Network Traffic";
            treeNode38.Name = "Knoten25";
            treeNode38.Tag = "shell netstat";
            treeNode38.Text = "Netstat";
            treeNode39.Name = "Knoten23";
            treeNode39.Tag = "shell dumpsys wifi";
            treeNode39.Text = "WiFi Info";
            treeNode40.Name = "Knoten29";
            treeNode40.Tag = "shell cat /etc/hosts";
            treeNode40.Text = "Hosts";
            treeNode41.Name = "Knoten0";
            treeNode41.Tag = "shell ifconfig";
            treeNode41.Text = "Network Info";
            treeNode42.Name = "Knoten3";
            treeNode42.Tag = "#spoofmac";
            treeNode42.Text = "Spoof MAC";
            treeNode43.Name = "Knoten1";
            treeNode43.Text = "Network";
            treeNode44.Name = "Knoten11";
            treeNode44.Tag = "shell \"pm list packages -f | cut -c9- | sort\"";
            treeNode44.Text = "All packages";
            treeNode45.Name = "Knoten13";
            treeNode45.Tag = "shell pm list libraries";
            treeNode45.Text = "Libraries";
            treeNode46.Name = "Knoten10";
            treeNode46.Tag = "shell \"pm list features | cut -c9- | sort\\";
            treeNode46.Text = "Features";
            treeNode47.Name = "Knoten1";
            treeNode47.Tag = "#installuninstall";
            treeNode47.Text = "Install and Uninstall";
            treeNode48.Name = "Knoten2";
            treeNode48.Text = "Packages";
            treeNode49.Name = "Knoten5";
            treeNode49.Tag = "shell dumpsys";
            treeNode49.Text = "Dumpsys Input Diagnostics";
            treeNode50.Name = "Knoten21";
            treeNode50.Tag = "shell dmesg";
            treeNode50.Text = "Kernel Messages";
            treeNode51.Name = "Knoten1";
            treeNode51.Tag = "logcat";
            treeNode51.Text = "Logcat Live";
            treeNode52.Name = "Knoten6";
            treeNode52.Tag = "shell logcat -d";
            treeNode52.Text = "Logcat Dump";
            treeNode53.Name = "Knoten4";
            treeNode53.Tag = "logcat *:V";
            treeNode53.Text = "Verbose";
            treeNode54.Name = "Knoten5";
            treeNode54.Tag = "logcat *:D";
            treeNode54.Text = "Debug";
            treeNode55.Name = "Knoten6";
            treeNode55.Tag = "logcat *:I";
            treeNode55.Text = "Info";
            treeNode56.Name = "Knoten7";
            treeNode56.Tag = "logcat *:W";
            treeNode56.Text = "Warning";
            treeNode57.Name = "Knoten8";
            treeNode57.Tag = "logcat *:E";
            treeNode57.Text = "Error";
            treeNode58.Name = "Knoten9";
            treeNode58.Tag = "logcat *:F";
            treeNode58.Text = "Fatal";
            treeNode59.Name = "Knoten11";
            treeNode59.Tag = "logcat *:S";
            treeNode59.Text = "Silent";
            treeNode60.Name = "Knoten3";
            treeNode60.Text = "Filter";
            treeNode61.Name = "Knoten0";
            treeNode61.Text = "Logcat";
            treeNode62.Name = "Knoten20";
            treeNode62.Text = "Logs";
            treeNode63.Name = "Knoten1";
            treeNode63.Tag = "help";
            treeNode63.Text = "Help";
            treeNode64.Name = "Knoten2";
            treeNode64.Tag = "version";
            treeNode64.Text = "Version";
            treeNode65.Name = "Knoten0";
            treeNode65.Text = "Adb";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode13,
            treeNode20,
            treeNode36,
            treeNode43,
            treeNode48,
            treeNode62,
            treeNode65});
            this.trv_commandTreeView.Size = new System.Drawing.Size(199, 455);
            this.trv_commandTreeView.TabIndex = 0;
            this.trv_commandTreeView.DoubleClick += new System.EventHandler(this.Trv_commandTreeView_DoubleClick);
            // 
            // cbx_connectedDevices
            // 
            this.cbx_connectedDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_connectedDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_connectedDevices.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_connectedDevices.FormattingEnabled = true;
            this.cbx_connectedDevices.Location = new System.Drawing.Point(6, 20);
            this.cbx_connectedDevices.Name = "cbx_connectedDevices";
            this.cbx_connectedDevices.Size = new System.Drawing.Size(187, 22);
            this.cbx_connectedDevices.TabIndex = 6;
            // 
            // btn_disconnectWirelessDevices
            // 
            this.btn_disconnectWirelessDevices.Location = new System.Drawing.Point(205, 19);
            this.btn_disconnectWirelessDevices.Name = "btn_disconnectWirelessDevices";
            this.btn_disconnectWirelessDevices.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnectWirelessDevices.TabIndex = 8;
            this.btn_disconnectWirelessDevices.Text = "Disconnect";
            this.btn_disconnectWirelessDevices.UseVisualStyleBackColor = true;
            this.btn_disconnectWirelessDevices.Click += new System.EventHandler(this.Btn_disconnectWirelessDevices_Click_1);
            // 
            // txt_wirelessDeviceIp
            // 
            this.txt_wirelessDeviceIp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wirelessDeviceIp.Location = new System.Drawing.Point(6, 19);
            this.txt_wirelessDeviceIp.MaxLength = 15;
            this.txt_wirelessDeviceIp.Name = "txt_wirelessDeviceIp";
            this.txt_wirelessDeviceIp.Size = new System.Drawing.Size(112, 22);
            this.txt_wirelessDeviceIp.TabIndex = 6;
            this.txt_wirelessDeviceIp.Text = "192.168.0.31";
            this.txt_wirelessDeviceIp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_wirelessDeviceIp_KeyDown);
            // 
            // btn_connectWirelessDevice
            // 
            this.btn_connectWirelessDevice.Location = new System.Drawing.Point(124, 19);
            this.btn_connectWirelessDevice.Name = "btn_connectWirelessDevice";
            this.btn_connectWirelessDevice.Size = new System.Drawing.Size(75, 23);
            this.btn_connectWirelessDevice.TabIndex = 7;
            this.btn_connectWirelessDevice.Text = "Connect";
            this.btn_connectWirelessDevice.UseVisualStyleBackColor = true;
            this.btn_connectWirelessDevice.Click += new System.EventHandler(this.Btn_connectWirelessDevice_Click);
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
            this.cbx_customCommand.Location = new System.Drawing.Point(217, 446);
            this.cbx_customCommand.Name = "cbx_customCommand";
            this.cbx_customCommand.Size = new System.Drawing.Size(562, 21);
            this.cbx_customCommand.TabIndex = 12;
            this.toolTip.SetToolTip(this.cbx_customCommand, "Enter commands without adb.");
            this.cbx_customCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbx_customCommand_KeyDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // gbox_wireless
            // 
            this.gbox_wireless.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbox_wireless.Controls.Add(this.btn_connectWirelessDevice);
            this.gbox_wireless.Controls.Add(this.txt_wirelessDeviceIp);
            this.gbox_wireless.Controls.Add(this.btn_disconnectWirelessDevices);
            this.gbox_wireless.Location = new System.Drawing.Point(217, 557);
            this.gbox_wireless.Name = "gbox_wireless";
            this.gbox_wireless.Size = new System.Drawing.Size(286, 48);
            this.gbox_wireless.TabIndex = 9;
            this.gbox_wireless.TabStop = false;
            this.gbox_wireless.Text = "Wireless ADB";
            // 
            // gbox_devices
            // 
            this.gbox_devices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbox_devices.Controls.Add(this.cbx_connectedDevices);
            this.gbox_devices.Location = new System.Drawing.Point(12, 557);
            this.gbox_devices.Name = "gbox_devices";
            this.gbox_devices.Size = new System.Drawing.Size(199, 48);
            this.gbox_devices.TabIndex = 10;
            this.gbox_devices.TabStop = false;
            this.gbox_devices.Text = "Connected Devices";
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
            this.rtb_console.Size = new System.Drawing.Size(803, 426);
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
            this.panel1.Location = new System.Drawing.Point(217, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 428);
            this.panel1.TabIndex = 12;
            // 
            // btn_consoleStop
            // 
            this.btn_consoleStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consoleStop.Location = new System.Drawing.Point(948, 446);
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
            this.btn_consoleClear.Location = new System.Drawing.Point(867, 446);
            this.btn_consoleClear.Name = "btn_consoleClear";
            this.btn_consoleClear.Size = new System.Drawing.Size(75, 22);
            this.btn_consoleClear.TabIndex = 0;
            this.btn_consoleClear.Text = "Clear";
            this.btn_consoleClear.UseVisualStyleBackColor = true;
            this.btn_consoleClear.Click += new System.EventHandler(this.Btn_consoleClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 617);
            this.Controls.Add(this.txt_devices);
            this.Controls.Add(this.cbx_customCommand);
            this.Controls.Add(this.btn_consoleStop);
            this.Controls.Add(this.btn_consoleClear);
            this.Controls.Add(this.gbox_wireless);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_executeCommand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbox_devices);
            this.Controls.Add(this.trv_commandTreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adbGUI";
            this.toolTip.SetToolTip(this, "Enter command without adb.");
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbox_wireless.ResumeLayout(false);
            this.gbox_wireless.PerformLayout();
            this.gbox_devices.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.ToolTip toolTip;
            private System.Windows.Forms.Button btn_remountSystem;
            private System.Windows.Forms.OpenFileDialog openFileDialog;
            private System.Windows.Forms.Button btn_executeCommand;
            private System.Windows.Forms.Button btn_openShell;
            private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
            public System.Windows.Forms.TextBox txt_wirelessDeviceIp;
            private System.Windows.Forms.Button btn_connectWirelessDevice;
            private System.Windows.Forms.SaveFileDialog saveFileDialog;
            public System.Windows.Forms.TextBox txt_devices;
            private System.Windows.Forms.Button btn_disconnectWirelessDevices;
            public System.Windows.Forms.ComboBox cbx_connectedDevices;
            public System.Windows.Forms.Button btn_killServer;
        private System.Windows.Forms.TreeView trv_commandTreeView;
        public System.Windows.Forms.GroupBox gbox_wireless;
        public System.Windows.Forms.GroupBox gbox_devices;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consoleStop;
        private System.Windows.Forms.Button btn_consoleClear;
        private System.Windows.Forms.Button btn_adbUnroot;
        private System.Windows.Forms.Button btn_adbRoot;
        private System.Windows.Forms.ComboBox cbx_customCommand;
        private System.Windows.Forms.CheckBox cbo_clearEverytime;
    }
}

