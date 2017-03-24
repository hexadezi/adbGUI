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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Max User");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("IMEI");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Accounts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Screenshot");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Shutdown");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Reboot Recovery");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Sideload Mode");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Sleep Mode");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Power", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Get build.prop");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Battery Info");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Activities");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Dumpsys Input Diagnostics");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36,
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("About");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode49,
            treeNode50});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.connectedDevices = new System.Windows.Forms.TabPage();
            this.txt_devices = new System.Windows.Forms.TextBox();
            this.phoneChanges = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btn_resetResolution = new System.Windows.Forms.Button();
            this.btn_showResolution = new System.Windows.Forms.Button();
            this.txt_phoneResolution = new System.Windows.Forms.TextBox();
            this.btn_setResolution = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btn_resetDpi = new System.Windows.Forms.Button();
            this.btn_showDpi = new System.Windows.Forms.Button();
            this.btn_setDpi = new System.Windows.Forms.Button();
            this.txt_phoneDpi = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_resetSpoofedMac = new System.Windows.Forms.Button();
            this.btn_setNewMac = new System.Windows.Forms.Button();
            this.btn_showMac = new System.Windows.Forms.Button();
            this.txt_phoneMacAdress = new System.Windows.Forms.TextBox();
            this.fileOperations = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_listPushDestination = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_pushFile = new System.Windows.Forms.Button();
            this.btn_push_openfile = new System.Windows.Forms.Button();
            this.txt_pushFilePathFrom = new System.Windows.Forms.TextBox();
            this.txt_pushFilePathTo = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btn_listPullDestination = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pullFile = new System.Windows.Forms.Button();
            this.btn_pullfolderBrowserDialog = new System.Windows.Forms.Button();
            this.txt_pullFilePathFrom = new System.Windows.Forms.TextBox();
            this.txt_pullFilePathTo = new System.Windows.Forms.TextBox();
            this.appsAndSideload = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbx_installedApps = new System.Windows.Forms.ComboBox();
            this.btn_installPackage = new System.Windows.Forms.Button();
            this.btn_refreshInstalledApps = new System.Windows.Forms.Button();
            this.btn_uninstallPackage = new System.Windows.Forms.Button();
            this.txt_packageFilePathTo = new System.Windows.Forms.TextBox();
            this.btn_packagesOpenFileDialog = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sideloadOpenFileDialog = new System.Windows.Forms.Button();
            this.txt_sideload_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sideloadFile = new System.Windows.Forms.Button();
            this.backupAndRestore = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_backup_packagename = new System.Windows.Forms.TextBox();
            this.cbo_backupPackage = new System.Windows.Forms.CheckBox();
            this.btn_backupSaveFileDialog = new System.Windows.Forms.Button();
            this.cb_backup_nosystem = new System.Windows.Forms.CheckBox();
            this.cb_backup_shared = new System.Windows.Forms.CheckBox();
            this.cb_backup_withapk = new System.Windows.Forms.CheckBox();
            this.btn_startBackup = new System.Windows.Forms.Button();
            this.txt_backupFilePathTo = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_restore_path = new System.Windows.Forms.TextBox();
            this.btn_restoreOpenFileDialog = new System.Windows.Forms.Button();
            this.btn_restoreBackup = new System.Windows.Forms.Button();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbox_wireless = new System.Windows.Forms.GroupBox();
            this.gbox_devices = new System.Windows.Forms.GroupBox();
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_customCommand = new System.Windows.Forms.ComboBox();
            this.btn_consoleStop = new System.Windows.Forms.Button();
            this.btn_consoleClear = new System.Windows.Forms.Button();
            timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.connectedDevices.SuspendLayout();
            this.phoneChanges.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.fileOperations.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.appsAndSideload.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.backupAndRestore.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbox_wireless.SuspendLayout();
            this.gbox_devices.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.connectedDevices);
            this.tabControl1.Controls.Add(this.phoneChanges);
            this.tabControl1.Controls.Add(this.fileOperations);
            this.tabControl1.Controls.Add(this.appsAndSideload);
            this.tabControl1.Controls.Add(this.backupAndRestore);
            this.tabControl1.Controls.Add(this.aboutTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 130);
            this.tabControl1.TabIndex = 6;
            // 
            // connectedDevices
            // 
            this.connectedDevices.Controls.Add(this.txt_devices);
            this.connectedDevices.Location = new System.Drawing.Point(4, 22);
            this.connectedDevices.Name = "connectedDevices";
            this.connectedDevices.Padding = new System.Windows.Forms.Padding(3);
            this.connectedDevices.Size = new System.Drawing.Size(1004, 104);
            this.connectedDevices.TabIndex = 0;
            this.connectedDevices.Text = "Connected Devices";
            this.connectedDevices.UseVisualStyleBackColor = true;
            // 
            // txt_devices
            // 
            this.txt_devices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_devices.Enabled = false;
            this.txt_devices.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_devices.Location = new System.Drawing.Point(6, 6);
            this.txt_devices.Multiline = true;
            this.txt_devices.Name = "txt_devices";
            this.txt_devices.Size = new System.Drawing.Size(992, 92);
            this.txt_devices.TabIndex = 5;
            // 
            // phoneChanges
            // 
            this.phoneChanges.Controls.Add(this.groupBox12);
            this.phoneChanges.Controls.Add(this.groupBox9);
            this.phoneChanges.Controls.Add(this.groupBox6);
            this.phoneChanges.Location = new System.Drawing.Point(4, 22);
            this.phoneChanges.Name = "phoneChanges";
            this.phoneChanges.Padding = new System.Windows.Forms.Padding(3);
            this.phoneChanges.Size = new System.Drawing.Size(1004, 104);
            this.phoneChanges.TabIndex = 3;
            this.phoneChanges.Text = "Phone Changes";
            this.phoneChanges.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btn_resetResolution);
            this.groupBox12.Controls.Add(this.btn_showResolution);
            this.groupBox12.Controls.Add(this.txt_phoneResolution);
            this.groupBox12.Controls.Add(this.btn_setResolution);
            this.groupBox12.Location = new System.Drawing.Point(165, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(151, 76);
            this.groupBox12.TabIndex = 14;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Resolution";
            // 
            // btn_resetResolution
            // 
            this.btn_resetResolution.Location = new System.Drawing.Point(78, 45);
            this.btn_resetResolution.Name = "btn_resetResolution";
            this.btn_resetResolution.Size = new System.Drawing.Size(66, 23);
            this.btn_resetResolution.TabIndex = 35;
            this.btn_resetResolution.Text = "Reset";
            this.btn_resetResolution.UseVisualStyleBackColor = true;
            this.btn_resetResolution.Click += new System.EventHandler(this.Btn_resetResolution_Click);
            // 
            // btn_showResolution
            // 
            this.btn_showResolution.Location = new System.Drawing.Point(6, 45);
            this.btn_showResolution.Name = "btn_showResolution";
            this.btn_showResolution.Size = new System.Drawing.Size(66, 23);
            this.btn_showResolution.TabIndex = 34;
            this.btn_showResolution.Text = "Show current DPI";
            this.btn_showResolution.UseVisualStyleBackColor = true;
            this.btn_showResolution.Click += new System.EventHandler(this.Btn_showResolution_Click);
            // 
            // txt_phoneResolution
            // 
            this.txt_phoneResolution.Location = new System.Drawing.Point(6, 19);
            this.txt_phoneResolution.Name = "txt_phoneResolution";
            this.txt_phoneResolution.Size = new System.Drawing.Size(83, 20);
            this.txt_phoneResolution.TabIndex = 32;
            this.txt_phoneResolution.Text = "1080x1920";
            this.txt_phoneResolution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_phoneResolution_KeyDown);
            // 
            // btn_setResolution
            // 
            this.btn_setResolution.Location = new System.Drawing.Point(95, 17);
            this.btn_setResolution.Name = "btn_setResolution";
            this.btn_setResolution.Size = new System.Drawing.Size(49, 23);
            this.btn_setResolution.TabIndex = 33;
            this.btn_setResolution.Text = "Set";
            this.btn_setResolution.UseVisualStyleBackColor = true;
            this.btn_setResolution.Click += new System.EventHandler(this.Btn_setResolution_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btn_resetDpi);
            this.groupBox9.Controls.Add(this.btn_showDpi);
            this.groupBox9.Controls.Add(this.btn_setDpi);
            this.groupBox9.Controls.Add(this.txt_phoneDpi);
            this.groupBox9.Location = new System.Drawing.Point(322, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(151, 76);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Change DPI";
            // 
            // btn_resetDpi
            // 
            this.btn_resetDpi.Location = new System.Drawing.Point(78, 45);
            this.btn_resetDpi.Name = "btn_resetDpi";
            this.btn_resetDpi.Size = new System.Drawing.Size(66, 23);
            this.btn_resetDpi.TabIndex = 31;
            this.btn_resetDpi.Text = "Reset";
            this.btn_resetDpi.UseVisualStyleBackColor = true;
            this.btn_resetDpi.Click += new System.EventHandler(this.Btn_resetDpi_Click);
            // 
            // btn_showDpi
            // 
            this.btn_showDpi.Location = new System.Drawing.Point(6, 45);
            this.btn_showDpi.Name = "btn_showDpi";
            this.btn_showDpi.Size = new System.Drawing.Size(66, 23);
            this.btn_showDpi.TabIndex = 30;
            this.btn_showDpi.Text = "Show current DPI";
            this.btn_showDpi.UseVisualStyleBackColor = true;
            this.btn_showDpi.Click += new System.EventHandler(this.Btn_showDpi_show_Click);
            // 
            // btn_setDpi
            // 
            this.btn_setDpi.Location = new System.Drawing.Point(105, 16);
            this.btn_setDpi.Name = "btn_setDpi";
            this.btn_setDpi.Size = new System.Drawing.Size(39, 23);
            this.btn_setDpi.TabIndex = 29;
            this.btn_setDpi.Text = "Set";
            this.btn_setDpi.UseVisualStyleBackColor = true;
            this.btn_setDpi.Click += new System.EventHandler(this.Btn_setDpi_Click);
            // 
            // txt_phoneDpi
            // 
            this.txt_phoneDpi.Location = new System.Drawing.Point(6, 19);
            this.txt_phoneDpi.Name = "txt_phoneDpi";
            this.txt_phoneDpi.Size = new System.Drawing.Size(93, 20);
            this.txt_phoneDpi.TabIndex = 28;
            this.txt_phoneDpi.Text = "480";
            this.txt_phoneDpi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_phoneDpi_KeyDown);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_resetSpoofedMac);
            this.groupBox6.Controls.Add(this.btn_setNewMac);
            this.groupBox6.Controls.Add(this.btn_showMac);
            this.groupBox6.Controls.Add(this.txt_phoneMacAdress);
            this.groupBox6.Location = new System.Drawing.Point(8, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(151, 76);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Spoof MAC";
            // 
            // btn_resetSpoofedMac
            // 
            this.btn_resetSpoofedMac.Location = new System.Drawing.Point(78, 46);
            this.btn_resetSpoofedMac.Name = "btn_resetSpoofedMac";
            this.btn_resetSpoofedMac.Size = new System.Drawing.Size(66, 23);
            this.btn_resetSpoofedMac.TabIndex = 27;
            this.btn_resetSpoofedMac.Text = "Reset";
            this.btn_resetSpoofedMac.UseVisualStyleBackColor = true;
            this.btn_resetSpoofedMac.Click += new System.EventHandler(this.Btn_resetSpoofedMac_Click);
            // 
            // btn_setNewMac
            // 
            this.btn_setNewMac.Location = new System.Drawing.Point(105, 20);
            this.btn_setNewMac.Name = "btn_setNewMac";
            this.btn_setNewMac.Size = new System.Drawing.Size(39, 23);
            this.btn_setNewMac.TabIndex = 25;
            this.btn_setNewMac.Text = "Set";
            this.btn_setNewMac.UseVisualStyleBackColor = true;
            this.btn_setNewMac.Click += new System.EventHandler(this.Btn_setNewMac_Click);
            // 
            // btn_showMac
            // 
            this.btn_showMac.Location = new System.Drawing.Point(6, 46);
            this.btn_showMac.Name = "btn_showMac";
            this.btn_showMac.Size = new System.Drawing.Size(66, 23);
            this.btn_showMac.TabIndex = 26;
            this.btn_showMac.Text = "Show";
            this.btn_showMac.UseVisualStyleBackColor = true;
            this.btn_showMac.Click += new System.EventHandler(this.Btn_showMac_Click);
            // 
            // txt_phoneMacAdress
            // 
            this.txt_phoneMacAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_phoneMacAdress.Location = new System.Drawing.Point(6, 22);
            this.txt_phoneMacAdress.Name = "txt_phoneMacAdress";
            this.txt_phoneMacAdress.Size = new System.Drawing.Size(93, 20);
            this.txt_phoneMacAdress.TabIndex = 24;
            this.txt_phoneMacAdress.Text = "00:11:22:33:44:55";
            this.txt_phoneMacAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_phoneMacAdress_KeyDown);
            // 
            // fileOperations
            // 
            this.fileOperations.Controls.Add(this.tableLayoutPanel3);
            this.fileOperations.Location = new System.Drawing.Point(4, 22);
            this.fileOperations.Name = "fileOperations";
            this.fileOperations.Padding = new System.Windows.Forms.Padding(3);
            this.fileOperations.Size = new System.Drawing.Size(1004, 104);
            this.fileOperations.TabIndex = 1;
            this.fileOperations.Text = "File Operations";
            this.fileOperations.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox10, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(992, 92);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.btn_listPushDestination);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.btn_pushFile);
            this.groupBox7.Controls.Add(this.btn_push_openfile);
            this.groupBox7.Controls.Add(this.txt_pushFilePathFrom);
            this.groupBox7.Controls.Add(this.txt_pushFilePathTo);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(490, 86);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Push Files";
            // 
            // btn_listPushDestination
            // 
            this.btn_listPushDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_listPushDestination.Location = new System.Drawing.Point(413, 55);
            this.btn_listPushDestination.Name = "btn_listPushDestination";
            this.btn_listPushDestination.Size = new System.Drawing.Size(72, 23);
            this.btn_listPushDestination.TabIndex = 7;
            this.btn_listPushDestination.Text = "List";
            this.btn_listPushDestination.UseVisualStyleBackColor = true;
            this.btn_listPushDestination.Click += new System.EventHandler(this.Btn_listPushDestination_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Destination";
            // 
            // btn_pushFile
            // 
            this.btn_pushFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pushFile.Location = new System.Drawing.Point(332, 56);
            this.btn_pushFile.Name = "btn_pushFile";
            this.btn_pushFile.Size = new System.Drawing.Size(75, 23);
            this.btn_pushFile.TabIndex = 6;
            this.btn_pushFile.Text = "Push";
            this.btn_pushFile.UseVisualStyleBackColor = true;
            this.btn_pushFile.Click += new System.EventHandler(this.Btn_pushFile_Click);
            // 
            // btn_push_openfile
            // 
            this.btn_push_openfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_push_openfile.Location = new System.Drawing.Point(332, 19);
            this.btn_push_openfile.Name = "btn_push_openfile";
            this.btn_push_openfile.Size = new System.Drawing.Size(152, 23);
            this.btn_push_openfile.TabIndex = 4;
            this.btn_push_openfile.Text = "Browse...";
            this.btn_push_openfile.UseVisualStyleBackColor = true;
            this.btn_push_openfile.Click += new System.EventHandler(this.Btn_push_openfile_Click);
            // 
            // txt_pushFilePathFrom
            // 
            this.txt_pushFilePathFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pushFilePathFrom.Location = new System.Drawing.Point(6, 58);
            this.txt_pushFilePathFrom.Name = "txt_pushFilePathFrom";
            this.txt_pushFilePathFrom.Size = new System.Drawing.Size(320, 20);
            this.txt_pushFilePathFrom.TabIndex = 5;
            this.txt_pushFilePathFrom.Text = "/sdcard/";
            this.txt_pushFilePathFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_pushFilePathFrom_KeyDown);
            // 
            // txt_pushFilePathTo
            // 
            this.txt_pushFilePathTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pushFilePathTo.Location = new System.Drawing.Point(6, 19);
            this.txt_pushFilePathTo.Name = "txt_pushFilePathTo";
            this.txt_pushFilePathTo.Size = new System.Drawing.Size(320, 20);
            this.txt_pushFilePathTo.TabIndex = 3;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.btn_listPullDestination);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.btn_pullFile);
            this.groupBox10.Controls.Add(this.btn_pullfolderBrowserDialog);
            this.groupBox10.Controls.Add(this.txt_pullFilePathFrom);
            this.groupBox10.Controls.Add(this.txt_pullFilePathTo);
            this.groupBox10.Location = new System.Drawing.Point(499, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(490, 86);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Pull Files";
            // 
            // btn_listPullDestination
            // 
            this.btn_listPullDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_listPullDestination.Location = new System.Drawing.Point(412, 58);
            this.btn_listPullDestination.Name = "btn_listPullDestination";
            this.btn_listPullDestination.Size = new System.Drawing.Size(72, 23);
            this.btn_listPullDestination.TabIndex = 8;
            this.btn_listPullDestination.Text = "List";
            this.btn_listPullDestination.UseVisualStyleBackColor = true;
            this.btn_listPullDestination.Click += new System.EventHandler(this.Btn_listPullDestination_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination";
            // 
            // btn_pullFile
            // 
            this.btn_pullFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pullFile.Location = new System.Drawing.Point(331, 58);
            this.btn_pullFile.Name = "btn_pullFile";
            this.btn_pullFile.Size = new System.Drawing.Size(75, 23);
            this.btn_pullFile.TabIndex = 10;
            this.btn_pullFile.Text = "Pull";
            this.btn_pullFile.UseVisualStyleBackColor = true;
            this.btn_pullFile.Click += new System.EventHandler(this.Btn_pullFile_Click);
            // 
            // btn_pullfolderBrowserDialog
            // 
            this.btn_pullfolderBrowserDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pullfolderBrowserDialog.Location = new System.Drawing.Point(331, 29);
            this.btn_pullfolderBrowserDialog.Name = "btn_pullfolderBrowserDialog";
            this.btn_pullfolderBrowserDialog.Size = new System.Drawing.Size(153, 23);
            this.btn_pullfolderBrowserDialog.TabIndex = 8;
            this.btn_pullfolderBrowserDialog.Text = "Browse...";
            this.btn_pullfolderBrowserDialog.UseVisualStyleBackColor = true;
            this.btn_pullfolderBrowserDialog.Click += new System.EventHandler(this.Btn_pullfolderBrowserDialog_Click);
            // 
            // txt_pullFilePathFrom
            // 
            this.txt_pullFilePathFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pullFilePathFrom.Location = new System.Drawing.Point(6, 60);
            this.txt_pullFilePathFrom.Name = "txt_pullFilePathFrom";
            this.txt_pullFilePathFrom.Size = new System.Drawing.Size(319, 20);
            this.txt_pullFilePathFrom.TabIndex = 9;
            this.txt_pullFilePathFrom.Text = "/sdcard/";
            this.txt_pullFilePathFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_pullFilePathFrom_KeyDown);
            // 
            // txt_pullFilePathTo
            // 
            this.txt_pullFilePathTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pullFilePathTo.Location = new System.Drawing.Point(6, 31);
            this.txt_pullFilePathTo.Name = "txt_pullFilePathTo";
            this.txt_pullFilePathTo.Size = new System.Drawing.Size(319, 20);
            this.txt_pullFilePathTo.TabIndex = 7;
            // 
            // appsAndSideload
            // 
            this.appsAndSideload.Controls.Add(this.tableLayoutPanel2);
            this.appsAndSideload.Location = new System.Drawing.Point(4, 22);
            this.appsAndSideload.Name = "appsAndSideload";
            this.appsAndSideload.Size = new System.Drawing.Size(1004, 104);
            this.appsAndSideload.TabIndex = 5;
            this.appsAndSideload.Text = "Apps and Sideload";
            this.appsAndSideload.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(998, 98);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbx_installedApps);
            this.groupBox3.Controls.Add(this.btn_installPackage);
            this.groupBox3.Controls.Add(this.btn_refreshInstalledApps);
            this.groupBox3.Controls.Add(this.btn_uninstallPackage);
            this.groupBox3.Controls.Add(this.txt_packageFilePathTo);
            this.groupBox3.Controls.Add(this.btn_packagesOpenFileDialog);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 92);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Install and Uninstall";
            // 
            // cbx_installedApps
            // 
            this.cbx_installedApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_installedApps.FormattingEnabled = true;
            this.cbx_installedApps.Location = new System.Drawing.Point(6, 59);
            this.cbx_installedApps.Name = "cbx_installedApps";
            this.cbx_installedApps.Size = new System.Drawing.Size(371, 21);
            this.cbx_installedApps.TabIndex = 6;
            // 
            // btn_installPackage
            // 
            this.btn_installPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_installPackage.Location = new System.Drawing.Point(412, 20);
            this.btn_installPackage.Name = "btn_installPackage";
            this.btn_installPackage.Size = new System.Drawing.Size(75, 23);
            this.btn_installPackage.TabIndex = 2;
            this.btn_installPackage.Text = "Install";
            this.btn_installPackage.UseVisualStyleBackColor = true;
            this.btn_installPackage.Click += new System.EventHandler(this.Btn_installPackage_Click_1);
            // 
            // btn_refreshInstalledApps
            // 
            this.btn_refreshInstalledApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refreshInstalledApps.BackgroundImage = global::adbGUI.Properties.Resources._1460414981_Update;
            this.btn_refreshInstalledApps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_refreshInstalledApps.Location = new System.Drawing.Point(383, 57);
            this.btn_refreshInstalledApps.Name = "btn_refreshInstalledApps";
            this.btn_refreshInstalledApps.Size = new System.Drawing.Size(23, 23);
            this.btn_refreshInstalledApps.TabIndex = 5;
            this.btn_refreshInstalledApps.UseVisualStyleBackColor = true;
            this.btn_refreshInstalledApps.Click += new System.EventHandler(this.Btn_refreshInstalledApps_Click);
            // 
            // btn_uninstallPackage
            // 
            this.btn_uninstallPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_uninstallPackage.Location = new System.Drawing.Point(412, 57);
            this.btn_uninstallPackage.Name = "btn_uninstallPackage";
            this.btn_uninstallPackage.Size = new System.Drawing.Size(75, 23);
            this.btn_uninstallPackage.TabIndex = 5;
            this.btn_uninstallPackage.Text = "Uninstall";
            this.btn_uninstallPackage.UseVisualStyleBackColor = true;
            this.btn_uninstallPackage.Click += new System.EventHandler(this.Btn_uninstallPackage_Click);
            // 
            // txt_packageFilePathTo
            // 
            this.txt_packageFilePathTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_packageFilePathTo.Location = new System.Drawing.Point(6, 22);
            this.txt_packageFilePathTo.Name = "txt_packageFilePathTo";
            this.txt_packageFilePathTo.Size = new System.Drawing.Size(319, 20);
            this.txt_packageFilePathTo.TabIndex = 0;
            // 
            // btn_packagesOpenFileDialog
            // 
            this.btn_packagesOpenFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_packagesOpenFileDialog.Location = new System.Drawing.Point(331, 20);
            this.btn_packagesOpenFileDialog.Name = "btn_packagesOpenFileDialog";
            this.btn_packagesOpenFileDialog.Size = new System.Drawing.Size(75, 23);
            this.btn_packagesOpenFileDialog.TabIndex = 1;
            this.btn_packagesOpenFileDialog.Text = "Browse...";
            this.btn_packagesOpenFileDialog.UseVisualStyleBackColor = true;
            this.btn_packagesOpenFileDialog.Click += new System.EventHandler(this.Btn_packagesOpenFileDialog_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_sideloadOpenFileDialog);
            this.groupBox2.Controls.Add(this.txt_sideload_path);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_sideloadFile);
            this.groupBox2.Location = new System.Drawing.Point(502, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sideload";
            // 
            // btn_sideloadOpenFileDialog
            // 
            this.btn_sideloadOpenFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sideloadOpenFileDialog.Location = new System.Drawing.Point(331, 56);
            this.btn_sideloadOpenFileDialog.Name = "btn_sideloadOpenFileDialog";
            this.btn_sideloadOpenFileDialog.Size = new System.Drawing.Size(75, 23);
            this.btn_sideloadOpenFileDialog.TabIndex = 1;
            this.btn_sideloadOpenFileDialog.Text = "Open file";
            this.btn_sideloadOpenFileDialog.UseVisualStyleBackColor = true;
            this.btn_sideloadOpenFileDialog.Click += new System.EventHandler(this.Btn_sideloadOpenFileDialog_Click);
            // 
            // txt_sideload_path
            // 
            this.txt_sideload_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sideload_path.Location = new System.Drawing.Point(6, 59);
            this.txt_sideload_path.Name = "txt_sideload_path";
            this.txt_sideload_path.Size = new System.Drawing.Size(319, 20);
            this.txt_sideload_path.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Enter Recovery in sideload mode    2. Choose the file, click sideload button";
            // 
            // btn_sideloadFile
            // 
            this.btn_sideloadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sideloadFile.Location = new System.Drawing.Point(412, 56);
            this.btn_sideloadFile.Name = "btn_sideloadFile";
            this.btn_sideloadFile.Size = new System.Drawing.Size(75, 23);
            this.btn_sideloadFile.TabIndex = 2;
            this.btn_sideloadFile.Text = "Sideload";
            this.btn_sideloadFile.UseVisualStyleBackColor = true;
            this.btn_sideloadFile.Click += new System.EventHandler(this.Btn_sideloadFile_Click);
            // 
            // backupAndRestore
            // 
            this.backupAndRestore.Controls.Add(this.tableLayoutPanel1);
            this.backupAndRestore.Location = new System.Drawing.Point(4, 22);
            this.backupAndRestore.Name = "backupAndRestore";
            this.backupAndRestore.Padding = new System.Windows.Forms.Padding(3);
            this.backupAndRestore.Size = new System.Drawing.Size(1004, 104);
            this.backupAndRestore.TabIndex = 2;
            this.backupAndRestore.Text = "Backup and Restore";
            this.backupAndRestore.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox14, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 95);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.txt_backup_packagename);
            this.groupBox8.Controls.Add(this.cbo_backupPackage);
            this.groupBox8.Controls.Add(this.btn_backupSaveFileDialog);
            this.groupBox8.Controls.Add(this.cb_backup_nosystem);
            this.groupBox8.Controls.Add(this.cb_backup_shared);
            this.groupBox8.Controls.Add(this.cb_backup_withapk);
            this.groupBox8.Controls.Add(this.btn_startBackup);
            this.groupBox8.Controls.Add(this.txt_backupFilePathTo);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(490, 89);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Backup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Attention: Backup semms broken in adb 1.0.39";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Package";
            this.label8.Visible = false;
            // 
            // txt_backup_packagename
            // 
            this.txt_backup_packagename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_backup_packagename.Location = new System.Drawing.Point(250, 48);
            this.txt_backup_packagename.Name = "txt_backup_packagename";
            this.txt_backup_packagename.Size = new System.Drawing.Size(156, 20);
            this.txt_backup_packagename.TabIndex = 7;
            this.txt_backup_packagename.Visible = false;
            // 
            // cbo_backupPackage
            // 
            this.cbo_backupPackage.AutoSize = true;
            this.cbo_backupPackage.Location = new System.Drawing.Point(6, 51);
            this.cbo_backupPackage.Name = "cbo_backupPackage";
            this.cbo_backupPackage.Size = new System.Drawing.Size(109, 17);
            this.cbo_backupPackage.TabIndex = 10;
            this.cbo_backupPackage.Text = "Backup Package";
            this.cbo_backupPackage.UseVisualStyleBackColor = true;
            this.cbo_backupPackage.CheckedChanged += new System.EventHandler(this.Cbo_backupPackage_CheckedChanged);
            // 
            // btn_backupSaveFileDialog
            // 
            this.btn_backupSaveFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_backupSaveFileDialog.Location = new System.Drawing.Point(250, 20);
            this.btn_backupSaveFileDialog.Name = "btn_backupSaveFileDialog";
            this.btn_backupSaveFileDialog.Size = new System.Drawing.Size(75, 23);
            this.btn_backupSaveFileDialog.TabIndex = 8;
            this.btn_backupSaveFileDialog.Text = "Save to";
            this.btn_backupSaveFileDialog.UseVisualStyleBackColor = true;
            this.btn_backupSaveFileDialog.Click += new System.EventHandler(this.Btn_backupSaveFileDialog_Click);
            // 
            // cb_backup_nosystem
            // 
            this.cb_backup_nosystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_backup_nosystem.AutoSize = true;
            this.cb_backup_nosystem.Location = new System.Drawing.Point(412, 65);
            this.cb_backup_nosystem.Name = "cb_backup_nosystem";
            this.cb_backup_nosystem.Size = new System.Drawing.Size(77, 17);
            this.cb_backup_nosystem.TabIndex = 13;
            this.cb_backup_nosystem.Text = "No System";
            this.cb_backup_nosystem.UseVisualStyleBackColor = true;
            // 
            // cb_backup_shared
            // 
            this.cb_backup_shared.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_backup_shared.AutoSize = true;
            this.cb_backup_shared.Location = new System.Drawing.Point(412, 42);
            this.cb_backup_shared.Name = "cb_backup_shared";
            this.cb_backup_shared.Size = new System.Drawing.Size(60, 17);
            this.cb_backup_shared.TabIndex = 12;
            this.cb_backup_shared.Text = "Shared";
            this.cb_backup_shared.UseVisualStyleBackColor = true;
            // 
            // cb_backup_withapk
            // 
            this.cb_backup_withapk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_backup_withapk.AutoSize = true;
            this.cb_backup_withapk.Location = new System.Drawing.Point(412, 20);
            this.cb_backup_withapk.Name = "cb_backup_withapk";
            this.cb_backup_withapk.Size = new System.Drawing.Size(72, 17);
            this.cb_backup_withapk.TabIndex = 11;
            this.cb_backup_withapk.Text = "With APK";
            this.cb_backup_withapk.UseVisualStyleBackColor = true;
            // 
            // btn_startBackup
            // 
            this.btn_startBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_startBackup.Location = new System.Drawing.Point(331, 19);
            this.btn_startBackup.Name = "btn_startBackup";
            this.btn_startBackup.Size = new System.Drawing.Size(75, 23);
            this.btn_startBackup.TabIndex = 9;
            this.btn_startBackup.Text = "Backup";
            this.btn_startBackup.UseVisualStyleBackColor = true;
            this.btn_startBackup.Click += new System.EventHandler(this.Btn_startBackup_Click);
            // 
            // txt_backupFilePathTo
            // 
            this.txt_backupFilePathTo.Location = new System.Drawing.Point(6, 22);
            this.txt_backupFilePathTo.Name = "txt_backupFilePathTo";
            this.txt_backupFilePathTo.Size = new System.Drawing.Size(238, 20);
            this.txt_backupFilePathTo.TabIndex = 6;
            // 
            // groupBox14
            // 
            this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox14.Controls.Add(this.label4);
            this.groupBox14.Controls.Add(this.txt_restore_path);
            this.groupBox14.Controls.Add(this.btn_restoreOpenFileDialog);
            this.groupBox14.Controls.Add(this.btn_restoreBackup);
            this.groupBox14.Location = new System.Drawing.Point(499, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(490, 89);
            this.groupBox14.TabIndex = 8;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Restore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Attention: Same with restore";
            // 
            // txt_restore_path
            // 
            this.txt_restore_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_restore_path.Location = new System.Drawing.Point(7, 22);
            this.txt_restore_path.Name = "txt_restore_path";
            this.txt_restore_path.Size = new System.Drawing.Size(315, 20);
            this.txt_restore_path.TabIndex = 14;
            // 
            // btn_restoreOpenFileDialog
            // 
            this.btn_restoreOpenFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restoreOpenFileDialog.Location = new System.Drawing.Point(328, 20);
            this.btn_restoreOpenFileDialog.Name = "btn_restoreOpenFileDialog";
            this.btn_restoreOpenFileDialog.Size = new System.Drawing.Size(75, 23);
            this.btn_restoreOpenFileDialog.TabIndex = 15;
            this.btn_restoreOpenFileDialog.Text = "Open file";
            this.btn_restoreOpenFileDialog.UseVisualStyleBackColor = true;
            this.btn_restoreOpenFileDialog.Click += new System.EventHandler(this.Btn_restoreOpenFileDialog_Click);
            // 
            // btn_restoreBackup
            // 
            this.btn_restoreBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restoreBackup.Location = new System.Drawing.Point(409, 20);
            this.btn_restoreBackup.Name = "btn_restoreBackup";
            this.btn_restoreBackup.Size = new System.Drawing.Size(75, 23);
            this.btn_restoreBackup.TabIndex = 16;
            this.btn_restoreBackup.Text = "Restore";
            this.btn_restoreBackup.UseVisualStyleBackColor = true;
            this.btn_restoreBackup.Click += new System.EventHandler(this.Btn_restoreBackup_Click);
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.label10);
            this.aboutTab.Location = new System.Drawing.Point(4, 22);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTab.Size = new System.Drawing.Size(1004, 104);
            this.aboutTab.TabIndex = 4;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "abdGUI 2.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btn_executeCommand.Location = new System.Drawing.Point(785, 530);
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
            this.trv_commandTreeView.Location = new System.Drawing.Point(12, 148);
            this.trv_commandTreeView.Name = "trv_commandTreeView";
            treeNode1.Name = "Knoten15";
            treeNode1.Tag = "shell pm list users";
            treeNode1.Text = "All User";
            treeNode2.Name = "Knoten17";
            treeNode2.Tag = "shell pm get-max-users";
            treeNode2.Text = "Max User";
            treeNode3.Name = "Knoten19";
            treeNode3.Tag = "shell service call iphonesubinfo 1";
            treeNode3.Text = "IMEI";
            treeNode4.Name = "Knoten27";
            treeNode4.Tag = "shell dumpsys account";
            treeNode4.Text = "Accounts";
            treeNode5.Name = "Knoten31";
            treeNode5.Tag = "shell screencap -p > screen.png";
            treeNode5.Text = "Screenshot";
            treeNode6.Name = "Knoten3";
            treeNode6.Text = "Phone";
            treeNode7.Name = "Knoten1";
            treeNode7.Tag = "shell reboot -p";
            treeNode7.Text = "Shutdown";
            treeNode8.Name = "Knoten2";
            treeNode8.Tag = "reboot";
            treeNode8.Text = "Reboot Normal";
            treeNode9.Name = "Knoten3";
            treeNode9.Tag = "reboot bootloader";
            treeNode9.Text = "Reboot Bootloader";
            treeNode10.Name = "Knoten5";
            treeNode10.Tag = "reboot recovery";
            treeNode10.Text = "Reboot Recovery";
            treeNode11.Name = "Knoten4";
            treeNode11.Tag = "reboot sideload";
            treeNode11.Text = "Sideload Mode";
            treeNode12.Name = "Knoten6";
            treeNode12.Tag = "shell input keyevent POWER";
            treeNode12.Text = "Sleep Mode";
            treeNode13.Name = "Knoten0";
            treeNode13.Text = "Power";
            treeNode14.Name = "Knoten4";
            treeNode14.Tag = "shell getprop";
            treeNode14.Text = "Get build.prop";
            treeNode15.Name = "Knoten8";
            treeNode15.Tag = "shell ps";
            treeNode15.Text = "Processes";
            treeNode16.Name = "Knoten9";
            treeNode16.Tag = "shell dumpsys meminfo";
            treeNode16.Text = "Memory";
            treeNode17.Name = "Knoten12";
            treeNode17.Tag = "shell dumpsys alarm";
            treeNode17.Text = "Alarm Manager State";
            treeNode18.Name = "Knoten16";
            treeNode18.Tag = "shell uptime";
            treeNode18.Text = "Uptime";
            treeNode19.Name = "Knoten22";
            treeNode19.Tag = "shell dumpsys battery";
            treeNode19.Text = "Battery Info";
            treeNode20.Name = "Knoten24";
            treeNode20.Tag = "shell dumpsys cpuinfo";
            treeNode20.Text = "CPU Info";
            treeNode21.Name = "Knoten26";
            treeNode21.Tag = "shell dumpsys diskstats";
            treeNode21.Text = "Diskstats";
            treeNode22.Name = "Knoten28";
            treeNode22.Tag = "shell pm list permissions";
            treeNode22.Text = "Permissions";
            treeNode23.Name = "Knoten30";
            treeNode23.Tag = "shell dumpsys activity";
            treeNode23.Text = "Activities";
            treeNode24.Name = "Knoten0";
            treeNode24.Tag = "shell df -h";
            treeNode24.Text = "Filesystem";
            treeNode25.Name = "Knoten0";
            treeNode25.Text = "System";
            treeNode26.Name = "Knoten7";
            treeNode26.Tag = "shell iftop";
            treeNode26.Text = "Network Traffic";
            treeNode27.Name = "Knoten25";
            treeNode27.Tag = "shell netstat";
            treeNode27.Text = "Netstat";
            treeNode28.Name = "Knoten23";
            treeNode28.Tag = "shell dumpsys wifi";
            treeNode28.Text = "WiFi Info";
            treeNode29.Name = "Knoten29";
            treeNode29.Tag = "shell cat /etc/hosts";
            treeNode29.Text = "Hosts";
            treeNode30.Name = "Knoten1";
            treeNode30.Text = "Network";
            treeNode31.Name = "Knoten11";
            treeNode31.Tag = "shell \"pm list packages -f | cut -c9- | sort\"";
            treeNode31.Text = "All packages";
            treeNode32.Name = "Knoten13";
            treeNode32.Tag = "shell pm list libraries";
            treeNode32.Text = "Libraries";
            treeNode33.Name = "Knoten10";
            treeNode33.Tag = "shell \"pm list features | cut -c9- | sort\\";
            treeNode33.Text = "Features";
            treeNode34.Name = "Knoten2";
            treeNode34.Text = "Packages";
            treeNode35.Name = "Knoten5";
            treeNode35.Tag = "shell dumpsys";
            treeNode35.Text = "Dumpsys Input Diagnostics";
            treeNode36.Name = "Knoten21";
            treeNode36.Tag = "shell dmesg";
            treeNode36.Text = "Kernel Messages";
            treeNode37.Name = "Knoten1";
            treeNode37.Tag = "logcat";
            treeNode37.Text = "Logcat Live";
            treeNode38.Name = "Knoten6";
            treeNode38.Tag = "shell logcat -d";
            treeNode38.Text = "Logcat Dump";
            treeNode39.Name = "Knoten4";
            treeNode39.Tag = "logcat *:V";
            treeNode39.Text = "Verbose";
            treeNode40.Name = "Knoten5";
            treeNode40.Tag = "logcat *:D";
            treeNode40.Text = "Debug";
            treeNode41.Name = "Knoten6";
            treeNode41.Tag = "logcat *:I";
            treeNode41.Text = "Info";
            treeNode42.Name = "Knoten7";
            treeNode42.Tag = "logcat *:W";
            treeNode42.Text = "Warning";
            treeNode43.Name = "Knoten8";
            treeNode43.Tag = "logcat *:E";
            treeNode43.Text = "Error";
            treeNode44.Name = "Knoten9";
            treeNode44.Tag = "logcat *:F";
            treeNode44.Text = "Fatal";
            treeNode45.Name = "Knoten11";
            treeNode45.Tag = "logcat *:S";
            treeNode45.Text = "Silent";
            treeNode46.Name = "Knoten3";
            treeNode46.Text = "Filter";
            treeNode47.Name = "Knoten0";
            treeNode47.Text = "Logcat";
            treeNode48.Name = "Knoten20";
            treeNode48.Text = "Logs";
            treeNode49.Name = "Knoten1";
            treeNode49.Tag = "help";
            treeNode49.Text = "Help";
            treeNode50.Name = "Knoten2";
            treeNode50.Tag = "version";
            treeNode50.Text = "About";
            treeNode51.Name = "Knoten0";
            treeNode51.Text = "Adb";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode13,
            treeNode25,
            treeNode30,
            treeNode34,
            treeNode48,
            treeNode51});
            this.trv_commandTreeView.Size = new System.Drawing.Size(199, 403);
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
            this.cbx_connectedDevices.SelectedIndexChanged += new System.EventHandler(this.Cbx_connectedDevices_SelectedIndexChanged);
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
            this.rtb_console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_console.BackColor = System.Drawing.Color.Black;
            this.rtb_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_console.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtb_console.HideSelection = false;
            this.rtb_console.Location = new System.Drawing.Point(-1, -1);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_console.Size = new System.Drawing.Size(805, 377);
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
            this.panel1.Location = new System.Drawing.Point(217, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 377);
            this.panel1.TabIndex = 12;
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
            this.cbx_customCommand.Location = new System.Drawing.Point(217, 530);
            this.cbx_customCommand.Name = "cbx_customCommand";
            this.cbx_customCommand.Size = new System.Drawing.Size(562, 21);
            this.cbx_customCommand.TabIndex = 12;
            this.toolTip.SetToolTip(this.cbx_customCommand, "Enter commands without adb.");
            this.cbx_customCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbx_customCommand_KeyDown);
            // 
            // btn_consoleStop
            // 
            this.btn_consoleStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consoleStop.Location = new System.Drawing.Point(947, 530);
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
            this.btn_consoleClear.Location = new System.Drawing.Point(866, 530);
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
            this.Controls.Add(this.cbx_customCommand);
            this.Controls.Add(this.btn_consoleStop);
            this.Controls.Add(this.btn_consoleClear);
            this.Controls.Add(this.tabControl1);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.connectedDevices.ResumeLayout(false);
            this.connectedDevices.PerformLayout();
            this.phoneChanges.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.fileOperations.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.appsAndSideload.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.backupAndRestore.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbox_wireless.ResumeLayout(false);
            this.gbox_wireless.PerformLayout();
            this.gbox_devices.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.TabPage connectedDevices;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.ToolTip toolTip;
            private System.Windows.Forms.Button btn_remountSystem;
            private System.Windows.Forms.TabPage fileOperations;
            private System.Windows.Forms.Button btn_sideloadFile;
            private System.Windows.Forms.GroupBox groupBox2;
            private System.Windows.Forms.TextBox txt_sideload_path;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Button btn_sideloadOpenFileDialog;
            private System.Windows.Forms.OpenFileDialog openFileDialog;
            private System.Windows.Forms.TabPage backupAndRestore;
            private System.Windows.Forms.GroupBox groupBox3;
            private System.Windows.Forms.TabPage phoneChanges;
            private System.Windows.Forms.Button btn_executeCommand;
            private System.Windows.Forms.Button btn_openShell;
            private System.Windows.Forms.TextBox txt_phoneMacAdress;
            private System.Windows.Forms.Button btn_setNewMac;
            private System.Windows.Forms.Button btn_resetSpoofedMac;
            private System.Windows.Forms.Button btn_showMac;
            private System.Windows.Forms.GroupBox groupBox6;
            private System.Windows.Forms.GroupBox groupBox7;
            private System.Windows.Forms.Button btn_pushFile;
            private System.Windows.Forms.Button btn_push_openfile;
            private System.Windows.Forms.TextBox txt_pushFilePathFrom;
            private System.Windows.Forms.TextBox txt_pushFilePathTo;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.TabPage aboutTab;
            private System.Windows.Forms.TextBox txt_packageFilePathTo;
            private System.Windows.Forms.Button btn_packagesOpenFileDialog;
            private System.Windows.Forms.Button btn_installPackage;
            private System.Windows.Forms.Button btn_uninstallPackage;
            private System.Windows.Forms.GroupBox groupBox10;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Button btn_pullFile;
            private System.Windows.Forms.Button btn_pullfolderBrowserDialog;
            private System.Windows.Forms.TextBox txt_pullFilePathFrom;
            private System.Windows.Forms.TextBox txt_pullFilePathTo;
            private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
            private System.Windows.Forms.GroupBox groupBox8;
            private System.Windows.Forms.Button btn_startBackup;
            private System.Windows.Forms.TextBox txt_backupFilePathTo;
            private System.Windows.Forms.CheckBox cb_backup_withapk;
            private System.Windows.Forms.CheckBox cb_backup_shared;
            private System.Windows.Forms.CheckBox cb_backup_nosystem;
            private System.Windows.Forms.Button btn_backupSaveFileDialog;
            private System.Windows.Forms.Button btn_restoreBackup;
            private System.Windows.Forms.Button btn_restoreOpenFileDialog;
            private System.Windows.Forms.TextBox txt_restore_path;
            private System.Windows.Forms.Label label8;
            private System.Windows.Forms.TextBox txt_backup_packagename;
            private System.Windows.Forms.CheckBox cbo_backupPackage;
            private System.Windows.Forms.GroupBox groupBox9;
            private System.Windows.Forms.Button btn_showDpi;
            private System.Windows.Forms.Button btn_setDpi;
            private System.Windows.Forms.TextBox txt_phoneDpi;
            private System.Windows.Forms.Button btn_resetDpi;
            public System.Windows.Forms.TextBox txt_wirelessDeviceIp;
            private System.Windows.Forms.Button btn_connectWirelessDevice;
            private System.Windows.Forms.GroupBox groupBox12;
            private System.Windows.Forms.Button btn_setResolution;
            private System.Windows.Forms.Button btn_resetResolution;
            private System.Windows.Forms.Button btn_showResolution;
            private System.Windows.Forms.TextBox txt_phoneResolution;
            private System.Windows.Forms.SaveFileDialog saveFileDialog;
            private System.Windows.Forms.Label label10;
            public System.Windows.Forms.TextBox txt_devices;
            private System.Windows.Forms.Button btn_disconnectWirelessDevices;
            public System.Windows.Forms.ComboBox cbx_connectedDevices;
            public System.Windows.Forms.TabControl tabControl1;
            public System.Windows.Forms.Button btn_killServer;
            private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button btn_refreshInstalledApps;
        private System.Windows.Forms.Button btn_listPushDestination;
        private System.Windows.Forms.Button btn_listPullDestination;
        private System.Windows.Forms.TreeView trv_commandTreeView;
        public System.Windows.Forms.ComboBox cbx_installedApps;
        public System.Windows.Forms.GroupBox gbox_wireless;
        public System.Windows.Forms.GroupBox gbox_devices;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consoleStop;
        private System.Windows.Forms.Button btn_consoleClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage appsAndSideload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_adbUnroot;
        private System.Windows.Forms.Button btn_adbRoot;
        private System.Windows.Forms.ComboBox cbx_customCommand;
    }
}

