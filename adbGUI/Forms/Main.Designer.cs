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
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("Files");
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("Sideload");
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("All User");
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("Max User");
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("IMEI");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("Accounts");
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("Backup Restore");
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode208,
            treeNode209,
            treeNode210,
            treeNode211,
            treeNode212,
            treeNode213,
            treeNode214});
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("Screenshot");
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("Screenrecord");
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("Resolution");
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("Density");
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode216,
            treeNode217,
            treeNode218,
            treeNode219});
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("Get Prop");
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("Set Prop");
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode221,
            treeNode222});
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("Battery Service State");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode226,
            treeNode227,
            treeNode228});
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("Remount System");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode223,
            treeNode224,
            treeNode225,
            treeNode229,
            treeNode230,
            treeNode231,
            treeNode232,
            treeNode233,
            treeNode234,
            treeNode235,
            treeNode236});
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("Network Info");
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("Spoof MAC");
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode238,
            treeNode239,
            treeNode240,
            treeNode241,
            treeNode242,
            treeNode243});
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("Install and Uninstall");
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode245,
            treeNode246,
            treeNode247,
            treeNode248});
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("Clear all buffers");
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("Logcat Advanced");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode254,
            treeNode255,
            treeNode256,
            treeNode257,
            treeNode258,
            treeNode259,
            treeNode260});
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode250,
            treeNode251,
            treeNode252,
            treeNode253,
            treeNode261});
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("Dumpsys");
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode262,
            treeNode263,
            treeNode264});
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("Devices");
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("Fastboot", new System.Windows.Forms.TreeNode[] {
            treeNode266,
            treeNode267,
            treeNode268,
            treeNode269,
            treeNode270});
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode272,
            treeNode273});
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("Credits");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            treeNode274,
            treeNode275});
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
            this.btn_executeCommand.Location = new System.Drawing.Point(792, 527);
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
            treeNode208.Name = "Knoten0";
            treeNode208.Tag = "#files";
            treeNode208.Text = "Files";
            treeNode209.Name = "Knoten2";
            treeNode209.Tag = "#sideload";
            treeNode209.Text = "Sideload";
            treeNode210.Name = "Knoten15";
            treeNode210.Tag = "adb shell pm list users";
            treeNode210.Text = "All User";
            treeNode211.Name = "Knoten17";
            treeNode211.Tag = "adb shell pm get-max-users";
            treeNode211.Text = "Max User";
            treeNode212.Name = "Knoten19";
            treeNode212.Tag = "adb shell service call iphonesubinfo 1";
            treeNode212.Text = "IMEI";
            treeNode213.Name = "Knoten27";
            treeNode213.Tag = "adb shell dumpsys account";
            treeNode213.Text = "Accounts";
            treeNode214.Name = "Knoten3";
            treeNode214.Tag = "#backuprestore";
            treeNode214.Text = "Backup Restore";
            treeNode215.Name = "Knoten3";
            treeNode215.Text = "Phone";
            treeNode216.Name = "Knoten31";
            treeNode216.Tag = "#screenshot";
            treeNode216.Text = "Screenshot";
            treeNode216.ToolTipText = "Take a screenshot";
            treeNode217.Name = "Knoten0";
            treeNode217.Tag = "#screenrecord";
            treeNode217.Text = "Screenrecord";
            treeNode217.ToolTipText = "Record screen up to 3 minutes";
            treeNode218.Name = "Knoten1";
            treeNode218.Tag = "#resolution";
            treeNode218.Text = "Resolution";
            treeNode218.ToolTipText = "Change Resolution";
            treeNode219.Name = "Knoten2";
            treeNode219.Tag = "#density";
            treeNode219.Text = "Density";
            treeNode220.Name = "Knoten0";
            treeNode220.Text = "Display";
            treeNode221.Name = "Knoten4";
            treeNode221.Tag = "adb shell getprop";
            treeNode221.Text = "Get Prop";
            treeNode222.Name = "Knoten1";
            treeNode222.Tag = "#prop";
            treeNode222.Text = "Set Prop";
            treeNode223.Name = "Knoten0";
            treeNode223.Text = "Prop";
            treeNode224.Name = "Knoten8";
            treeNode224.Tag = "adb shell ps";
            treeNode224.Text = "Processes";
            treeNode225.Name = "Knoten9";
            treeNode225.Tag = "adb shell dumpsys meminfo";
            treeNode225.Text = "Memory";
            treeNode226.Name = "Knoten1";
            treeNode226.Tag = "adb shell dumpsys battery";
            treeNode226.Text = "Battery Service State";
            treeNode227.Name = "Knoten2";
            treeNode227.Tag = "adb shell dumpsys batterystats";
            treeNode227.Text = "Collected Battery Stats";
            treeNode228.Name = "Knoten3";
            treeNode228.Tag = "adb shell dumpsys batterystats --reset";
            treeNode228.Text = "Reset Battery Stats";
            treeNode229.Name = "Knoten22";
            treeNode229.Tag = "";
            treeNode229.Text = "Battery";
            treeNode230.Name = "Knoten12";
            treeNode230.Tag = "adb shell dumpsys alarm";
            treeNode230.Text = "Alarm Manager State";
            treeNode231.Name = "Knoten16";
            treeNode231.Tag = "adb shell uptime";
            treeNode231.Text = "Uptime";
            treeNode232.Name = "Knoten24";
            treeNode232.Tag = "adb shell dumpsys cpuinfo";
            treeNode232.Text = "CPU Info";
            treeNode233.Name = "Knoten26";
            treeNode233.Tag = "adb shell dumpsys diskstats";
            treeNode233.Text = "Diskstats";
            treeNode234.Name = "Knoten28";
            treeNode234.Tag = "adb shell pm list permissions";
            treeNode234.Text = "Permissions";
            treeNode235.Name = "Knoten0";
            treeNode235.Tag = "adb shell df -h";
            treeNode235.Text = "Filesystem";
            treeNode236.Name = "Knoten0";
            treeNode236.Tag = "adb remount";
            treeNode236.Text = "Remount System";
            treeNode237.Name = "Knoten0";
            treeNode237.Text = "System";
            treeNode238.Name = "Knoten7";
            treeNode238.Tag = "adb shell iftop";
            treeNode238.Text = "Network Traffic";
            treeNode239.Name = "Knoten25";
            treeNode239.Tag = "adb shell netstat";
            treeNode239.Text = "Netstat";
            treeNode240.Name = "Knoten23";
            treeNode240.Tag = "adb shell dumpsys wifi";
            treeNode240.Text = "WiFi Info";
            treeNode241.Name = "Knoten29";
            treeNode241.Tag = "adb shell cat /etc/hosts";
            treeNode241.Text = "Hosts";
            treeNode242.Name = "Knoten0";
            treeNode242.Tag = "adb shell ifconfig";
            treeNode242.Text = "Network Info";
            treeNode243.Name = "Knoten3";
            treeNode243.Tag = "#spoofmac";
            treeNode243.Text = "Spoof MAC";
            treeNode244.Name = "Knoten1";
            treeNode244.Text = "Network";
            treeNode245.Name = "Knoten11";
            treeNode245.Tag = "adb shell pm list packages -f";
            treeNode245.Text = "All packages";
            treeNode246.Name = "Knoten13";
            treeNode246.Tag = "adb shell pm list libraries";
            treeNode246.Text = "Libraries";
            treeNode247.Name = "Knoten10";
            treeNode247.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
            treeNode247.Text = "Features";
            treeNode248.Name = "Knoten1";
            treeNode248.Tag = "#installuninstall";
            treeNode248.Text = "Install and Uninstall";
            treeNode249.Name = "Knoten2";
            treeNode249.Text = "Packages";
            treeNode250.Name = "Knoten1";
            treeNode250.Tag = "adb logcat";
            treeNode250.Text = "Logcat Live";
            treeNode251.Name = "Knoten6";
            treeNode251.Tag = "adb logcat -d";
            treeNode251.Text = "Logcat Dump";
            treeNode252.Name = "Knoten0";
            treeNode252.Tag = "adb logcat -b all -c";
            treeNode252.Text = "Clear all buffers";
            treeNode253.Name = "Knoten0";
            treeNode253.Tag = "#logcatadvanced";
            treeNode253.Text = "Logcat Advanced";
            treeNode254.Name = "Knoten4";
            treeNode254.Tag = "adb logcat *:V";
            treeNode254.Text = "Verbose";
            treeNode255.Name = "Knoten5";
            treeNode255.Tag = "adb logcat *:D";
            treeNode255.Text = "Debug";
            treeNode256.Name = "Knoten6";
            treeNode256.Tag = "adb logcat *:I";
            treeNode256.Text = "Info";
            treeNode257.Name = "Knoten7";
            treeNode257.Tag = "adb logcat *:W";
            treeNode257.Text = "Warning";
            treeNode258.Name = "Knoten8";
            treeNode258.Tag = "adb logcat *:E";
            treeNode258.Text = "Error";
            treeNode259.Name = "Knoten9";
            treeNode259.Tag = "adb logcat *:F";
            treeNode259.Text = "Fatal";
            treeNode260.Name = "Knoten11";
            treeNode260.Tag = "adb logcat *:S";
            treeNode260.Text = "Silent";
            treeNode261.Name = "Knoten3";
            treeNode261.Text = "Filter";
            treeNode262.Name = "Knoten0";
            treeNode262.Text = "Logcat";
            treeNode263.Name = "Knoten5";
            treeNode263.Tag = "adb shell dumpsys";
            treeNode263.Text = "Dumpsys";
            treeNode264.Name = "Knoten21";
            treeNode264.Tag = "adb shell dmesg";
            treeNode264.Text = "Kernel Messages";
            treeNode265.Name = "Knoten20";
            treeNode265.Text = "Logs";
            treeNode266.Name = "Knoten2";
            treeNode266.Tag = "fastboot devices";
            treeNode266.Text = "Devices";
            treeNode267.Name = "Knoten4";
            treeNode267.Tag = "fastboot reboot";
            treeNode267.Text = "Reboot Normal";
            treeNode268.Name = "Knoten3";
            treeNode268.Tag = "fastboot reboot bootloader";
            treeNode268.Text = "Reboot Bootloader";
            treeNode269.Name = "Knoten1";
            treeNode269.Tag = "fastboot help";
            treeNode269.Text = "Help";
            treeNode270.Name = "Knoten3";
            treeNode270.Tag = "fastboot --version";
            treeNode270.Text = "Version";
            treeNode271.Name = "Knoten0";
            treeNode271.Text = "Fastboot";
            treeNode272.Name = "Knoten1";
            treeNode272.Tag = "adb help";
            treeNode272.Text = "Help";
            treeNode273.Name = "Knoten2";
            treeNode273.Tag = "adb version";
            treeNode273.Text = "Version";
            treeNode274.Name = "Knoten0";
            treeNode274.Text = "Adb";
            treeNode275.Name = "Knoten1";
            treeNode275.Tag = "#credits";
            treeNode275.Text = "Credits";
            treeNode276.Name = "Knoten0";
            treeNode276.Text = "About";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode215,
            treeNode220,
            treeNode237,
            treeNode244,
            treeNode249,
            treeNode265,
            treeNode271,
            treeNode276});
            this.trv_commandTreeView.Size = new System.Drawing.Size(204, 510);
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
            this.cbx_customCommand.Location = new System.Drawing.Point(221, 528);
            this.cbx_customCommand.Name = "cbx_customCommand";
            this.cbx_customCommand.Size = new System.Drawing.Size(565, 21);
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
            this.rtb_console.Size = new System.Drawing.Size(805, 479);
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
            this.panel1.Location = new System.Drawing.Point(221, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 481);
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
            // btn_consoleClear
            // 
            this.btn_consoleClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consoleClear.Location = new System.Drawing.Point(873, 527);
            this.btn_consoleClear.Name = "btn_consoleClear";
            this.btn_consoleClear.Size = new System.Drawing.Size(75, 23);
            this.btn_consoleClear.TabIndex = 0;
            this.btn_consoleClear.Text = "Clear";
            this.btn_consoleClear.UseVisualStyleBackColor = true;
            this.btn_consoleClear.Click += new System.EventHandler(this.Btn_consoleClear_Click);
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
            this.tsc_ConnectedDevices.Name = "tsc_ConnectedDevices";
            this.tsc_ConnectedDevices.Size = new System.Drawing.Size(150, 23);
            // 
            // tsd_Power
            // 
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
            this.tsd_Power.Size = new System.Drawing.Size(103, 20);
            this.tsd_Power.Text = "Power Menu";
            // 
            // tsm_PowerRebootNormal
            // 
            this.tsm_PowerRebootNormal.Name = "tsm_PowerRebootNormal";
            this.tsm_PowerRebootNormal.Size = new System.Drawing.Size(173, 22);
            this.tsm_PowerRebootNormal.Text = "Reboot Normal";
            this.tsm_PowerRebootNormal.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerRebootRecovery
            // 
            this.tsm_PowerRebootRecovery.Name = "tsm_PowerRebootRecovery";
            this.tsm_PowerRebootRecovery.Size = new System.Drawing.Size(173, 22);
            this.tsm_PowerRebootRecovery.Text = "Reboot Recovery";
            this.tsm_PowerRebootRecovery.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerRebootBootloader
            // 
            this.tsm_PowerRebootBootloader.Name = "tsm_PowerRebootBootloader";
            this.tsm_PowerRebootBootloader.Size = new System.Drawing.Size(173, 22);
            this.tsm_PowerRebootBootloader.Text = "Reboot Bootloader";
            this.tsm_PowerRebootBootloader.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerRebootFastboot
            // 
            this.tsm_PowerRebootFastboot.Name = "tsm_PowerRebootFastboot";
            this.tsm_PowerRebootFastboot.Size = new System.Drawing.Size(173, 22);
            this.tsm_PowerRebootFastboot.Text = "Reboot Fastboot";
            this.tsm_PowerRebootFastboot.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerSideloadMode
            // 
            this.tsm_PowerSideloadMode.Name = "tsm_PowerSideloadMode";
            this.tsm_PowerSideloadMode.Size = new System.Drawing.Size(173, 22);
            this.tsm_PowerSideloadMode.Text = "Sideload Mode";
            this.tsm_PowerSideloadMode.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerShutdown
            // 
            this.tsm_PowerShutdown.Name = "tsm_PowerShutdown";
            this.tsm_PowerShutdown.Size = new System.Drawing.Size(173, 22);
            this.tsm_PowerShutdown.Text = "Shutdown";
            this.tsm_PowerShutdown.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerSleep
            // 
            this.tsm_PowerSleep.Name = "tsm_PowerSleep";
            this.tsm_PowerSleep.Size = new System.Drawing.Size(173, 22);
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
            this.tsd_WirelessAdb.Size = new System.Drawing.Size(105, 20);
            this.tsd_WirelessAdb.Text = "Wireless ADB";
            // 
            // tst_IpAdress
            // 
            this.tst_IpAdress.Name = "tst_IpAdress";
            this.tst_IpAdress.Size = new System.Drawing.Size(100, 23);
            this.tst_IpAdress.Text = "192.168.0.44:5555";
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
            this.ClientSize = new System.Drawing.Size(1040, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_consoleStop);
            this.Controls.Add(this.trv_commandTreeView);
            this.Controls.Add(this.btn_consoleClear);
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

