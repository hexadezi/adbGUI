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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Screenshot");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Screenrecord");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Resolution");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Density");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Shutdown");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Reboot Normal");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Reboot Recovery");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Sideload Mode");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Sleep Mode");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Power", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Get Prop");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Set Prop");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Processes");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Memory");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Battery Service State");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Alarm Manager State");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Uptime");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("CPU Info");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Diskstats");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Filesystem");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Network Traffic");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("WiFi Info");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Hosts");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Network Info");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Spoof MAC");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("All packages");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Libraries");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Features");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Install and Uninstall");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Dumpsys Input Diagnostics");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Kernel Messages");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Logcat Live");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Logcat Dump");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Verbose");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Debug");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Info");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Warning");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Error");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Fatal");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Silent");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode51,
            treeNode59});
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49,
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Version");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode62,
            treeNode63});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.connectedDevices = new System.Windows.Forms.TabPage();
            this.txt_devices = new System.Windows.Forms.TextBox();
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
            this.tabControl1.SuspendLayout();
            this.connectedDevices.SuspendLayout();
            this.backupAndRestore.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox14.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.connectedDevices);
            this.tabControl1.Controls.Add(this.backupAndRestore);
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox14, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 98);
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
            this.groupBox8.Size = new System.Drawing.Size(493, 92);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Backup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Attention: Backup semms broken in adb 1.0.39";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 49);
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
            this.txt_backup_packagename.Location = new System.Drawing.Point(250, 45);
            this.txt_backup_packagename.Name = "txt_backup_packagename";
            this.txt_backup_packagename.Size = new System.Drawing.Size(159, 20);
            this.txt_backup_packagename.TabIndex = 7;
            this.txt_backup_packagename.Visible = false;
            // 
            // cbo_backupPackage
            // 
            this.cbo_backupPackage.AutoSize = true;
            this.cbo_backupPackage.Location = new System.Drawing.Point(6, 48);
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
            this.btn_backupSaveFileDialog.Location = new System.Drawing.Point(253, 17);
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
            this.cb_backup_nosystem.Location = new System.Drawing.Point(415, 62);
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
            this.cb_backup_shared.Location = new System.Drawing.Point(415, 39);
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
            this.cb_backup_withapk.Location = new System.Drawing.Point(415, 17);
            this.cb_backup_withapk.Name = "cb_backup_withapk";
            this.cb_backup_withapk.Size = new System.Drawing.Size(72, 17);
            this.cb_backup_withapk.TabIndex = 11;
            this.cb_backup_withapk.Text = "With APK";
            this.cb_backup_withapk.UseVisualStyleBackColor = true;
            // 
            // btn_startBackup
            // 
            this.btn_startBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_startBackup.Location = new System.Drawing.Point(334, 16);
            this.btn_startBackup.Name = "btn_startBackup";
            this.btn_startBackup.Size = new System.Drawing.Size(75, 23);
            this.btn_startBackup.TabIndex = 9;
            this.btn_startBackup.Text = "Backup";
            this.btn_startBackup.UseVisualStyleBackColor = true;
            this.btn_startBackup.Click += new System.EventHandler(this.Btn_startBackup_Click);
            // 
            // txt_backupFilePathTo
            // 
            this.txt_backupFilePathTo.Location = new System.Drawing.Point(6, 19);
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
            this.groupBox14.Location = new System.Drawing.Point(502, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(493, 92);
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
            this.txt_restore_path.Size = new System.Drawing.Size(318, 20);
            this.txt_restore_path.TabIndex = 14;
            // 
            // btn_restoreOpenFileDialog
            // 
            this.btn_restoreOpenFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restoreOpenFileDialog.Location = new System.Drawing.Point(331, 20);
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
            this.btn_restoreBackup.Location = new System.Drawing.Point(412, 20);
            this.btn_restoreBackup.Name = "btn_restoreBackup";
            this.btn_restoreBackup.Size = new System.Drawing.Size(75, 23);
            this.btn_restoreBackup.TabIndex = 16;
            this.btn_restoreBackup.Text = "Restore";
            this.btn_restoreBackup.UseVisualStyleBackColor = true;
            this.btn_restoreBackup.Click += new System.EventHandler(this.Btn_restoreBackup_Click);
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
            treeNode7.Text = "Phone";
            treeNode8.Name = "Knoten31";
            treeNode8.Tag = "shell screencap -p > screen.png";
            treeNode8.Text = "Screenshot";
            treeNode8.ToolTipText = "Take a screenshot";
            treeNode9.Name = "Knoten0";
            treeNode9.Tag = "#screenrecord";
            treeNode9.Text = "Screenrecord";
            treeNode9.ToolTipText = "Record screen up to 3 minutes";
            treeNode10.Name = "Knoten1";
            treeNode10.Tag = "#resolution";
            treeNode10.Text = "Resolution";
            treeNode10.ToolTipText = "Change Resolution";
            treeNode11.Name = "Knoten2";
            treeNode11.Tag = "#density";
            treeNode11.Text = "Density";
            treeNode12.Name = "Knoten0";
            treeNode12.Text = "Display";
            treeNode13.Name = "Knoten1";
            treeNode13.Tag = "shell reboot -p";
            treeNode13.Text = "Shutdown";
            treeNode14.Name = "Knoten2";
            treeNode14.Tag = "reboot";
            treeNode14.Text = "Reboot Normal";
            treeNode15.Name = "Knoten3";
            treeNode15.Tag = "reboot bootloader";
            treeNode15.Text = "Reboot Bootloader";
            treeNode16.Name = "Knoten5";
            treeNode16.Tag = "reboot recovery";
            treeNode16.Text = "Reboot Recovery";
            treeNode17.Name = "Knoten4";
            treeNode17.Tag = "reboot sideload";
            treeNode17.Text = "Sideload Mode";
            treeNode18.Name = "Knoten6";
            treeNode18.Tag = "shell input keyevent POWER";
            treeNode18.Text = "Sleep Mode";
            treeNode19.Name = "Knoten0";
            treeNode19.Text = "Power";
            treeNode20.Name = "Knoten4";
            treeNode20.Tag = "shell getprop";
            treeNode20.Text = "Get Prop";
            treeNode21.Name = "Knoten1";
            treeNode21.Tag = "#prop";
            treeNode21.Text = "Set Prop";
            treeNode22.Name = "Knoten0";
            treeNode22.Text = "Prop";
            treeNode23.Name = "Knoten8";
            treeNode23.Tag = "shell ps";
            treeNode23.Text = "Processes";
            treeNode24.Name = "Knoten9";
            treeNode24.Tag = "shell dumpsys meminfo";
            treeNode24.Text = "Memory";
            treeNode25.Name = "Knoten1";
            treeNode25.Tag = "shell dumpsys battery";
            treeNode25.Text = "Battery Service State";
            treeNode26.Name = "Knoten2";
            treeNode26.Tag = "shell dumpsys batterystats";
            treeNode26.Text = "Collected Battery Stats";
            treeNode27.Name = "Knoten3";
            treeNode27.Tag = "shell dumpsys batterystats --reset";
            treeNode27.Text = "Reset Battery Stats";
            treeNode28.Name = "Knoten22";
            treeNode28.Tag = "";
            treeNode28.Text = "Battery";
            treeNode29.Name = "Knoten12";
            treeNode29.Tag = "shell dumpsys alarm";
            treeNode29.Text = "Alarm Manager State";
            treeNode30.Name = "Knoten16";
            treeNode30.Tag = "shell uptime";
            treeNode30.Text = "Uptime";
            treeNode31.Name = "Knoten24";
            treeNode31.Tag = "shell dumpsys cpuinfo";
            treeNode31.Text = "CPU Info";
            treeNode32.Name = "Knoten26";
            treeNode32.Tag = "shell dumpsys diskstats";
            treeNode32.Text = "Diskstats";
            treeNode33.Name = "Knoten28";
            treeNode33.Tag = "shell pm list permissions";
            treeNode33.Text = "Permissions";
            treeNode34.Name = "Knoten0";
            treeNode34.Tag = "shell df -h";
            treeNode34.Text = "Filesystem";
            treeNode35.Name = "Knoten0";
            treeNode35.Text = "System";
            treeNode36.Name = "Knoten7";
            treeNode36.Tag = "shell iftop";
            treeNode36.Text = "Network Traffic";
            treeNode37.Name = "Knoten25";
            treeNode37.Tag = "shell netstat";
            treeNode37.Text = "Netstat";
            treeNode38.Name = "Knoten23";
            treeNode38.Tag = "shell dumpsys wifi";
            treeNode38.Text = "WiFi Info";
            treeNode39.Name = "Knoten29";
            treeNode39.Tag = "shell cat /etc/hosts";
            treeNode39.Text = "Hosts";
            treeNode40.Name = "Knoten0";
            treeNode40.Tag = "shell ifconfig";
            treeNode40.Text = "Network Info";
            treeNode41.Name = "Knoten3";
            treeNode41.Tag = "#spoofmac";
            treeNode41.Text = "Spoof MAC";
            treeNode42.Name = "Knoten1";
            treeNode42.Text = "Network";
            treeNode43.Name = "Knoten11";
            treeNode43.Tag = "shell \"pm list packages -f | cut -c9- | sort\"";
            treeNode43.Text = "All packages";
            treeNode44.Name = "Knoten13";
            treeNode44.Tag = "shell pm list libraries";
            treeNode44.Text = "Libraries";
            treeNode45.Name = "Knoten10";
            treeNode45.Tag = "shell \"pm list features | cut -c9- | sort\\";
            treeNode45.Text = "Features";
            treeNode46.Name = "Knoten1";
            treeNode46.Tag = "#installuninstall";
            treeNode46.Text = "Install and Uninstall";
            treeNode47.Name = "Knoten2";
            treeNode47.Text = "Packages";
            treeNode48.Name = "Knoten5";
            treeNode48.Tag = "shell dumpsys";
            treeNode48.Text = "Dumpsys Input Diagnostics";
            treeNode49.Name = "Knoten21";
            treeNode49.Tag = "shell dmesg";
            treeNode49.Text = "Kernel Messages";
            treeNode50.Name = "Knoten1";
            treeNode50.Tag = "logcat";
            treeNode50.Text = "Logcat Live";
            treeNode51.Name = "Knoten6";
            treeNode51.Tag = "shell logcat -d";
            treeNode51.Text = "Logcat Dump";
            treeNode52.Name = "Knoten4";
            treeNode52.Tag = "logcat *:V";
            treeNode52.Text = "Verbose";
            treeNode53.Name = "Knoten5";
            treeNode53.Tag = "logcat *:D";
            treeNode53.Text = "Debug";
            treeNode54.Name = "Knoten6";
            treeNode54.Tag = "logcat *:I";
            treeNode54.Text = "Info";
            treeNode55.Name = "Knoten7";
            treeNode55.Tag = "logcat *:W";
            treeNode55.Text = "Warning";
            treeNode56.Name = "Knoten8";
            treeNode56.Tag = "logcat *:E";
            treeNode56.Text = "Error";
            treeNode57.Name = "Knoten9";
            treeNode57.Tag = "logcat *:F";
            treeNode57.Text = "Fatal";
            treeNode58.Name = "Knoten11";
            treeNode58.Tag = "logcat *:S";
            treeNode58.Text = "Silent";
            treeNode59.Name = "Knoten3";
            treeNode59.Text = "Filter";
            treeNode60.Name = "Knoten0";
            treeNode60.Text = "Logcat";
            treeNode61.Name = "Knoten20";
            treeNode61.Text = "Logs";
            treeNode62.Name = "Knoten1";
            treeNode62.Tag = "help";
            treeNode62.Text = "Help";
            treeNode63.Name = "Knoten2";
            treeNode63.Tag = "version";
            treeNode63.Text = "Version";
            treeNode64.Name = "Knoten0";
            treeNode64.Text = "Adb";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode12,
            treeNode19,
            treeNode35,
            treeNode42,
            treeNode47,
            treeNode61,
            treeNode64});
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
            this.cbx_customCommand.Location = new System.Drawing.Point(217, 530);
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
            this.rtb_console.Size = new System.Drawing.Size(803, 375);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.connectedDevices.ResumeLayout(false);
            this.connectedDevices.PerformLayout();
            this.backupAndRestore.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            private System.Windows.Forms.OpenFileDialog openFileDialog;
            private System.Windows.Forms.TabPage backupAndRestore;
            private System.Windows.Forms.Button btn_executeCommand;
            private System.Windows.Forms.Button btn_openShell;
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
            public System.Windows.Forms.TextBox txt_wirelessDeviceIp;
            private System.Windows.Forms.Button btn_connectWirelessDevice;
            private System.Windows.Forms.SaveFileDialog saveFileDialog;
            public System.Windows.Forms.TextBox txt_devices;
            private System.Windows.Forms.Button btn_disconnectWirelessDevices;
            public System.Windows.Forms.ComboBox cbx_connectedDevices;
            public System.Windows.Forms.TabControl tabControl1;
            public System.Windows.Forms.Button btn_killServer;
            private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TreeView trv_commandTreeView;
        public System.Windows.Forms.GroupBox gbox_wireless;
        public System.Windows.Forms.GroupBox gbox_devices;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consoleStop;
        private System.Windows.Forms.Button btn_consoleClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_adbUnroot;
        private System.Windows.Forms.Button btn_adbRoot;
        private System.Windows.Forms.ComboBox cbx_customCommand;
        private System.Windows.Forms.CheckBox cbo_clearEverytime;
    }
}

