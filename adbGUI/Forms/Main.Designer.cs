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
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("Files");
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("Sideload");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("All User");
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("Max User");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("IMEI");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("Accounts");
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("Backup Restore");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode232,
            treeNode233,
            treeNode234,
            treeNode235,
            treeNode236,
            treeNode237,
            treeNode238});
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("Screenshot");
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("Screenrecord");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("Resolution");
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("Density");
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode240,
            treeNode241,
            treeNode242,
            treeNode243});
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("Shutdown");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("Reboot Recovery");
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("Reboot Fastboot");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("Sideload Mode");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("Sleep Mode");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("Power", new System.Windows.Forms.TreeNode[] {
            treeNode245,
            treeNode246,
            treeNode247,
            treeNode248,
            treeNode249,
            treeNode250,
            treeNode251});
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("Get Prop");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("Set Prop");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode253,
            treeNode254});
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("Battery Service State");
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode258,
            treeNode259,
            treeNode260});
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("Remount System");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode255,
            treeNode256,
            treeNode257,
            treeNode261,
            treeNode262,
            treeNode263,
            treeNode264,
            treeNode265,
            treeNode266,
            treeNode267,
            treeNode268});
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("Network Info");
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("Spoof MAC");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode270,
            treeNode271,
            treeNode272,
            treeNode273,
            treeNode274,
            treeNode275});
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("Install and Uninstall");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode277,
            treeNode278,
            treeNode279,
            treeNode280});
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("Clear all buffers");
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("Logcat Advanced");
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode286,
            treeNode287,
            treeNode288,
            treeNode289,
            treeNode290,
            treeNode291,
            treeNode292});
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode282,
            treeNode283,
            treeNode284,
            treeNode285,
            treeNode293});
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("Dumpsys Input Diagnostics");
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode294,
            treeNode295,
            treeNode296});
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("Devices");
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("Fastboot", new System.Windows.Forms.TreeNode[] {
            treeNode298,
            treeNode299,
            treeNode300,
            treeNode301,
            treeNode302});
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode304,
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("Credits");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            treeNode306,
            treeNode307});
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
            treeNode232.Name = "Knoten0";
            treeNode232.Tag = "#files";
            treeNode232.Text = "Files";
            treeNode233.Name = "Knoten2";
            treeNode233.Tag = "#sideload";
            treeNode233.Text = "Sideload";
            treeNode234.Name = "Knoten15";
            treeNode234.Tag = "adb shell pm list users";
            treeNode234.Text = "All User";
            treeNode235.Name = "Knoten17";
            treeNode235.Tag = "adb shell pm get-max-users";
            treeNode235.Text = "Max User";
            treeNode236.Name = "Knoten19";
            treeNode236.Tag = "adb shell service call iphonesubinfo 1";
            treeNode236.Text = "IMEI";
            treeNode237.Name = "Knoten27";
            treeNode237.Tag = "adb shell dumpsys account";
            treeNode237.Text = "Accounts";
            treeNode238.Name = "Knoten3";
            treeNode238.Tag = "#backuprestore";
            treeNode238.Text = "Backup Restore";
            treeNode239.Name = "Knoten3";
            treeNode239.Text = "Phone";
            treeNode240.Name = "Knoten31";
            treeNode240.Tag = "#screenshot";
            treeNode240.Text = "Screenshot";
            treeNode240.ToolTipText = "Take a screenshot";
            treeNode241.Name = "Knoten0";
            treeNode241.Tag = "#screenrecord";
            treeNode241.Text = "Screenrecord";
            treeNode241.ToolTipText = "Record screen up to 3 minutes";
            treeNode242.Name = "Knoten1";
            treeNode242.Tag = "#resolution";
            treeNode242.Text = "Resolution";
            treeNode242.ToolTipText = "Change Resolution";
            treeNode243.Name = "Knoten2";
            treeNode243.Tag = "#density";
            treeNode243.Text = "Density";
            treeNode244.Name = "Knoten0";
            treeNode244.Text = "Display";
            treeNode245.Name = "Knoten1";
            treeNode245.Tag = "adb shell reboot -p";
            treeNode245.Text = "Shutdown";
            treeNode246.Name = "Knoten2";
            treeNode246.Tag = "adb reboot";
            treeNode246.Text = "Reboot Normal";
            treeNode247.Name = "Knoten3";
            treeNode247.Tag = "adb reboot bootloader";
            treeNode247.Text = "Reboot Bootloader";
            treeNode248.Name = "Knoten5";
            treeNode248.Tag = "adb reboot recovery";
            treeNode248.Text = "Reboot Recovery";
            treeNode249.Name = "Knoten0";
            treeNode249.Tag = "adb reboot fastboot";
            treeNode249.Text = "Reboot Fastboot";
            treeNode250.Name = "Knoten4";
            treeNode250.Tag = "adb reboot sideload";
            treeNode250.Text = "Sideload Mode";
            treeNode251.Name = "Knoten6";
            treeNode251.Tag = "adb shell input keyevent POWER";
            treeNode251.Text = "Sleep Mode";
            treeNode252.Name = "Knoten0";
            treeNode252.Text = "Power";
            treeNode253.Name = "Knoten4";
            treeNode253.Tag = "adb shell getprop";
            treeNode253.Text = "Get Prop";
            treeNode254.Name = "Knoten1";
            treeNode254.Tag = "#prop";
            treeNode254.Text = "Set Prop";
            treeNode255.Name = "Knoten0";
            treeNode255.Text = "Prop";
            treeNode256.Name = "Knoten8";
            treeNode256.Tag = "adb shell ps";
            treeNode256.Text = "Processes";
            treeNode257.Name = "Knoten9";
            treeNode257.Tag = "adb shell dumpsys meminfo";
            treeNode257.Text = "Memory";
            treeNode258.Name = "Knoten1";
            treeNode258.Tag = "adb shell dumpsys battery";
            treeNode258.Text = "Battery Service State";
            treeNode259.Name = "Knoten2";
            treeNode259.Tag = "adb shell dumpsys batterystats";
            treeNode259.Text = "Collected Battery Stats";
            treeNode260.Name = "Knoten3";
            treeNode260.Tag = "adb shell dumpsys batterystats --reset";
            treeNode260.Text = "Reset Battery Stats";
            treeNode261.Name = "Knoten22";
            treeNode261.Tag = "";
            treeNode261.Text = "Battery";
            treeNode262.Name = "Knoten12";
            treeNode262.Tag = "adb shell dumpsys alarm";
            treeNode262.Text = "Alarm Manager State";
            treeNode263.Name = "Knoten16";
            treeNode263.Tag = "adb shell uptime";
            treeNode263.Text = "Uptime";
            treeNode264.Name = "Knoten24";
            treeNode264.Tag = "adb shell dumpsys cpuinfo";
            treeNode264.Text = "CPU Info";
            treeNode265.Name = "Knoten26";
            treeNode265.Tag = "adb shell dumpsys diskstats";
            treeNode265.Text = "Diskstats";
            treeNode266.Name = "Knoten28";
            treeNode266.Tag = "adb shell pm list permissions";
            treeNode266.Text = "Permissions";
            treeNode267.Name = "Knoten0";
            treeNode267.Tag = "adb shell df -h";
            treeNode267.Text = "Filesystem";
            treeNode268.Name = "Knoten0";
            treeNode268.Tag = "adb remount";
            treeNode268.Text = "Remount System";
            treeNode269.Name = "Knoten0";
            treeNode269.Text = "System";
            treeNode270.Name = "Knoten7";
            treeNode270.Tag = "adb shell iftop";
            treeNode270.Text = "Network Traffic";
            treeNode271.Name = "Knoten25";
            treeNode271.Tag = "adb shell netstat";
            treeNode271.Text = "Netstat";
            treeNode272.Name = "Knoten23";
            treeNode272.Tag = "adb shell dumpsys wifi";
            treeNode272.Text = "WiFi Info";
            treeNode273.Name = "Knoten29";
            treeNode273.Tag = "adb shell cat /etc/hosts";
            treeNode273.Text = "Hosts";
            treeNode274.Name = "Knoten0";
            treeNode274.Tag = "adb shell ifconfig";
            treeNode274.Text = "Network Info";
            treeNode275.Name = "Knoten3";
            treeNode275.Tag = "#spoofmac";
            treeNode275.Text = "Spoof MAC";
            treeNode276.Name = "Knoten1";
            treeNode276.Text = "Network";
            treeNode277.Name = "Knoten11";
            treeNode277.Tag = "adb shell pm list packages -f";
            treeNode277.Text = "All packages";
            treeNode278.Name = "Knoten13";
            treeNode278.Tag = "adb shell pm list libraries";
            treeNode278.Text = "Libraries";
            treeNode279.Name = "Knoten10";
            treeNode279.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
            treeNode279.Text = "Features";
            treeNode280.Name = "Knoten1";
            treeNode280.Tag = "#installuninstall";
            treeNode280.Text = "Install and Uninstall";
            treeNode281.Name = "Knoten2";
            treeNode281.Text = "Packages";
            treeNode282.Name = "Knoten1";
            treeNode282.Tag = "adb logcat";
            treeNode282.Text = "Logcat Live";
            treeNode283.Name = "Knoten6";
            treeNode283.Tag = "adb logcat -d";
            treeNode283.Text = "Logcat Dump";
            treeNode284.Name = "Knoten0";
            treeNode284.Tag = "adb logcat -b all -c";
            treeNode284.Text = "Clear all buffers";
            treeNode285.Name = "Knoten0";
            treeNode285.Tag = "#logcatadvanced";
            treeNode285.Text = "Logcat Advanced";
            treeNode286.Name = "Knoten4";
            treeNode286.Tag = "adb logcat *:V";
            treeNode286.Text = "Verbose";
            treeNode287.Name = "Knoten5";
            treeNode287.Tag = "adb logcat *:D";
            treeNode287.Text = "Debug";
            treeNode288.Name = "Knoten6";
            treeNode288.Tag = "adb logcat *:I";
            treeNode288.Text = "Info";
            treeNode289.Name = "Knoten7";
            treeNode289.Tag = "adb logcat *:W";
            treeNode289.Text = "Warning";
            treeNode290.Name = "Knoten8";
            treeNode290.Tag = "adb logcat *:E";
            treeNode290.Text = "Error";
            treeNode291.Name = "Knoten9";
            treeNode291.Tag = "adb logcat *:F";
            treeNode291.Text = "Fatal";
            treeNode292.Name = "Knoten11";
            treeNode292.Tag = "adb logcat *:S";
            treeNode292.Text = "Silent";
            treeNode293.Name = "Knoten3";
            treeNode293.Text = "Filter";
            treeNode294.Name = "Knoten0";
            treeNode294.Text = "Logcat";
            treeNode295.Name = "Knoten5";
            treeNode295.Tag = "adb shell dumpsys";
            treeNode295.Text = "Dumpsys Input Diagnostics";
            treeNode296.Name = "Knoten21";
            treeNode296.Tag = "adb shell dmesg";
            treeNode296.Text = "Kernel Messages";
            treeNode297.Name = "Knoten20";
            treeNode297.Text = "Logs";
            treeNode298.Name = "Knoten2";
            treeNode298.Tag = "fastboot devices";
            treeNode298.Text = "Devices";
            treeNode299.Name = "Knoten4";
            treeNode299.Tag = "fastboot reboot";
            treeNode299.Text = "Reboot Normal";
            treeNode300.Name = "Knoten3";
            treeNode300.Tag = "fastboot reboot bootloader";
            treeNode300.Text = "Reboot Bootloader";
            treeNode301.Name = "Knoten1";
            treeNode301.Tag = "fastboot help";
            treeNode301.Text = "Help";
            treeNode302.Name = "Knoten3";
            treeNode302.Tag = "fastboot --version";
            treeNode302.Text = "Version";
            treeNode303.Name = "Knoten0";
            treeNode303.Text = "Fastboot";
            treeNode304.Name = "Knoten1";
            treeNode304.Tag = "adb help";
            treeNode304.Text = "Help";
            treeNode305.Name = "Knoten2";
            treeNode305.Tag = "adb version";
            treeNode305.Text = "Version";
            treeNode306.Name = "Knoten0";
            treeNode306.Text = "Adb";
            treeNode307.Name = "Knoten1";
            treeNode307.Tag = "#credits";
            treeNode307.Text = "Credits";
            treeNode308.Name = "Knoten0";
            treeNode308.Text = "About";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode239,
            treeNode244,
            treeNode252,
            treeNode269,
            treeNode276,
            treeNode281,
            treeNode297,
            treeNode303,
            treeNode308});
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

