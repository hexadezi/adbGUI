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
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("Files");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("Sideload");
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("All User");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("Max User");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("IMEI");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("Accounts");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("Backup Restore");
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode139,
            treeNode140,
            treeNode141,
            treeNode142,
            treeNode143,
            treeNode144,
            treeNode145});
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("Screenshot");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("Screenrecord");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("Resolution");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("Density");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode147,
            treeNode148,
            treeNode149,
            treeNode150});
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("Get Prop");
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("Set Prop");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode152,
            treeNode153});
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("Battery Service State");
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode157,
            treeNode158,
            treeNode159});
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("Remount System");
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode154,
            treeNode155,
            treeNode156,
            treeNode160,
            treeNode161,
            treeNode162,
            treeNode163,
            treeNode164,
            treeNode165,
            treeNode166,
            treeNode167});
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("Network Info");
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("Spoof MAC");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode169,
            treeNode170,
            treeNode171,
            treeNode172,
            treeNode173,
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("Install and Uninstall");
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode176,
            treeNode177,
            treeNode178,
            treeNode179});
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("Clear all buffers");
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("Logcat Advanced");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode185,
            treeNode186,
            treeNode187,
            treeNode188,
            treeNode189,
            treeNode190,
            treeNode191});
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode181,
            treeNode182,
            treeNode183,
            treeNode184,
            treeNode192});
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("Dumpsys");
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode193,
            treeNode194,
            treeNode195});
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("Devices");
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("Fastboot", new System.Windows.Forms.TreeNode[] {
            treeNode197,
            treeNode198,
            treeNode199,
            treeNode200,
            treeNode201});
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode203,
            treeNode204});
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("Credits");
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            treeNode205,
            treeNode206});
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
            treeNode139.Name = "Knoten0";
            treeNode139.Tag = "#files";
            treeNode139.Text = "Files";
            treeNode140.Name = "Knoten2";
            treeNode140.Tag = "#sideload";
            treeNode140.Text = "Sideload";
            treeNode141.Name = "Knoten15";
            treeNode141.Tag = "adb shell pm list users";
            treeNode141.Text = "All User";
            treeNode142.Name = "Knoten17";
            treeNode142.Tag = "adb shell pm get-max-users";
            treeNode142.Text = "Max User";
            treeNode143.Name = "Knoten19";
            treeNode143.Tag = "adb shell service call iphonesubinfo 1";
            treeNode143.Text = "IMEI";
            treeNode144.Name = "Knoten27";
            treeNode144.Tag = "adb shell dumpsys account";
            treeNode144.Text = "Accounts";
            treeNode145.Name = "Knoten3";
            treeNode145.Tag = "#backuprestore";
            treeNode145.Text = "Backup Restore";
            treeNode146.Name = "Knoten3";
            treeNode146.Text = "Phone";
            treeNode147.Name = "Knoten31";
            treeNode147.Tag = "#screenshot";
            treeNode147.Text = "Screenshot";
            treeNode147.ToolTipText = "Take a screenshot";
            treeNode148.Name = "Knoten0";
            treeNode148.Tag = "#screenrecord";
            treeNode148.Text = "Screenrecord";
            treeNode148.ToolTipText = "Record screen up to 3 minutes";
            treeNode149.Name = "Knoten1";
            treeNode149.Tag = "#resolution";
            treeNode149.Text = "Resolution";
            treeNode149.ToolTipText = "Change Resolution";
            treeNode150.Name = "Knoten2";
            treeNode150.Tag = "#density";
            treeNode150.Text = "Density";
            treeNode151.Name = "Knoten0";
            treeNode151.Text = "Display";
            treeNode152.Name = "Knoten4";
            treeNode152.Tag = "adb shell getprop";
            treeNode152.Text = "Get Prop";
            treeNode153.Name = "Knoten1";
            treeNode153.Tag = "#prop";
            treeNode153.Text = "Set Prop";
            treeNode154.Name = "Knoten0";
            treeNode154.Text = "Prop";
            treeNode155.Name = "Knoten8";
            treeNode155.Tag = "adb shell ps";
            treeNode155.Text = "Processes";
            treeNode156.Name = "Knoten9";
            treeNode156.Tag = "adb shell dumpsys meminfo";
            treeNode156.Text = "Memory";
            treeNode157.Name = "Knoten1";
            treeNode157.Tag = "adb shell dumpsys battery";
            treeNode157.Text = "Battery Service State";
            treeNode158.Name = "Knoten2";
            treeNode158.Tag = "adb shell dumpsys batterystats";
            treeNode158.Text = "Collected Battery Stats";
            treeNode159.Name = "Knoten3";
            treeNode159.Tag = "adb shell dumpsys batterystats --reset";
            treeNode159.Text = "Reset Battery Stats";
            treeNode160.Name = "Knoten22";
            treeNode160.Tag = "";
            treeNode160.Text = "Battery";
            treeNode161.Name = "Knoten12";
            treeNode161.Tag = "adb shell dumpsys alarm";
            treeNode161.Text = "Alarm Manager State";
            treeNode162.Name = "Knoten16";
            treeNode162.Tag = "adb shell uptime";
            treeNode162.Text = "Uptime";
            treeNode163.Name = "Knoten24";
            treeNode163.Tag = "adb shell dumpsys cpuinfo";
            treeNode163.Text = "CPU Info";
            treeNode164.Name = "Knoten26";
            treeNode164.Tag = "adb shell dumpsys diskstats";
            treeNode164.Text = "Diskstats";
            treeNode165.Name = "Knoten28";
            treeNode165.Tag = "adb shell pm list permissions";
            treeNode165.Text = "Permissions";
            treeNode166.Name = "Knoten0";
            treeNode166.Tag = "adb shell df -h";
            treeNode166.Text = "Filesystem";
            treeNode167.Name = "Knoten0";
            treeNode167.Tag = "adb remount";
            treeNode167.Text = "Remount System";
            treeNode168.Name = "Knoten0";
            treeNode168.Text = "System";
            treeNode169.Name = "Knoten7";
            treeNode169.Tag = "adb shell iftop";
            treeNode169.Text = "Network Traffic";
            treeNode170.Name = "Knoten25";
            treeNode170.Tag = "adb shell netstat";
            treeNode170.Text = "Netstat";
            treeNode171.Name = "Knoten23";
            treeNode171.Tag = "adb shell dumpsys wifi";
            treeNode171.Text = "WiFi Info";
            treeNode172.Name = "Knoten29";
            treeNode172.Tag = "adb shell cat /etc/hosts";
            treeNode172.Text = "Hosts";
            treeNode173.Name = "Knoten0";
            treeNode173.Tag = "adb shell ifconfig";
            treeNode173.Text = "Network Info";
            treeNode174.Name = "Knoten3";
            treeNode174.Tag = "#spoofmac";
            treeNode174.Text = "Spoof MAC";
            treeNode175.Name = "Knoten1";
            treeNode175.Text = "Network";
            treeNode176.Name = "Knoten11";
            treeNode176.Tag = "adb shell pm list packages -f";
            treeNode176.Text = "All packages";
            treeNode177.Name = "Knoten13";
            treeNode177.Tag = "adb shell pm list libraries";
            treeNode177.Text = "Libraries";
            treeNode178.Name = "Knoten10";
            treeNode178.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
            treeNode178.Text = "Features";
            treeNode179.Name = "Knoten1";
            treeNode179.Tag = "#installuninstall";
            treeNode179.Text = "Install and Uninstall";
            treeNode180.Name = "Knoten2";
            treeNode180.Text = "Packages";
            treeNode181.Name = "Knoten1";
            treeNode181.Tag = "adb logcat";
            treeNode181.Text = "Logcat Live";
            treeNode182.Name = "Knoten6";
            treeNode182.Tag = "adb logcat -d";
            treeNode182.Text = "Logcat Dump";
            treeNode183.Name = "Knoten0";
            treeNode183.Tag = "adb logcat -b all -c";
            treeNode183.Text = "Clear all buffers";
            treeNode184.Name = "Knoten0";
            treeNode184.Tag = "#logcatadvanced";
            treeNode184.Text = "Logcat Advanced";
            treeNode185.Name = "Knoten4";
            treeNode185.Tag = "adb logcat *:V";
            treeNode185.Text = "Verbose";
            treeNode186.Name = "Knoten5";
            treeNode186.Tag = "adb logcat *:D";
            treeNode186.Text = "Debug";
            treeNode187.Name = "Knoten6";
            treeNode187.Tag = "adb logcat *:I";
            treeNode187.Text = "Info";
            treeNode188.Name = "Knoten7";
            treeNode188.Tag = "adb logcat *:W";
            treeNode188.Text = "Warning";
            treeNode189.Name = "Knoten8";
            treeNode189.Tag = "adb logcat *:E";
            treeNode189.Text = "Error";
            treeNode190.Name = "Knoten9";
            treeNode190.Tag = "adb logcat *:F";
            treeNode190.Text = "Fatal";
            treeNode191.Name = "Knoten11";
            treeNode191.Tag = "adb logcat *:S";
            treeNode191.Text = "Silent";
            treeNode192.Name = "Knoten3";
            treeNode192.Text = "Filter";
            treeNode193.Name = "Knoten0";
            treeNode193.Text = "Logcat";
            treeNode194.Name = "Knoten5";
            treeNode194.Tag = "adb shell dumpsys";
            treeNode194.Text = "Dumpsys";
            treeNode195.Name = "Knoten21";
            treeNode195.Tag = "adb shell dmesg";
            treeNode195.Text = "Kernel Messages";
            treeNode196.Name = "Knoten20";
            treeNode196.Text = "Logs";
            treeNode197.Name = "Knoten2";
            treeNode197.Tag = "fastboot devices";
            treeNode197.Text = "Devices";
            treeNode198.Name = "Knoten4";
            treeNode198.Tag = "fastboot reboot";
            treeNode198.Text = "Reboot Normal";
            treeNode199.Name = "Knoten3";
            treeNode199.Tag = "fastboot reboot bootloader";
            treeNode199.Text = "Reboot Bootloader";
            treeNode200.Name = "Knoten1";
            treeNode200.Tag = "fastboot help";
            treeNode200.Text = "Help";
            treeNode201.Name = "Knoten3";
            treeNode201.Tag = "fastboot --version";
            treeNode201.Text = "Version";
            treeNode202.Name = "Knoten0";
            treeNode202.Text = "Fastboot";
            treeNode203.Name = "Knoten1";
            treeNode203.Tag = "adb help";
            treeNode203.Text = "Help";
            treeNode204.Name = "Knoten2";
            treeNode204.Tag = "adb version";
            treeNode204.Text = "Version";
            treeNode205.Name = "Knoten0";
            treeNode205.Text = "Adb";
            treeNode206.Name = "Knoten1";
            treeNode206.Tag = "#credits";
            treeNode206.Text = "Credits";
            treeNode207.Name = "Knoten0";
            treeNode207.Text = "About";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode146,
            treeNode151,
            treeNode168,
            treeNode175,
            treeNode180,
            treeNode196,
            treeNode202,
            treeNode207});
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
            this.cbx_customCommand.Size = new System.Drawing.Size(568, 21);
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
            this.rtb_console.Size = new System.Drawing.Size(808, 479);
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
            this.panel1.Size = new System.Drawing.Size(810, 481);
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
            this.tst_IpAdress.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_IpAdress.Name = "tst_IpAdress";
            this.tst_IpAdress.Size = new System.Drawing.Size(125, 19);
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

