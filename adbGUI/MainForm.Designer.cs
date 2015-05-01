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
                  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
                  this.tabControl1 = new System.Windows.Forms.TabControl();
                  this.tabPage1 = new System.Windows.Forms.TabPage();
                  this.groupBox13 = new System.Windows.Forms.GroupBox();
                  this.txt_serialno = new System.Windows.Forms.TextBox();
                  this.groupBox11 = new System.Windows.Forms.GroupBox();
                  this.txt_ip = new System.Windows.Forms.TextBox();
                  this.btn_connect = new System.Windows.Forms.Button();
                  this.groupBox4 = new System.Windows.Forms.GroupBox();
                  this.btn_run = new System.Windows.Forms.Button();
                  this.txt_customcommand = new System.Windows.Forms.TextBox();
                  this.groupBox1 = new System.Windows.Forms.GroupBox();
                  this.btn_reboot = new System.Windows.Forms.Button();
                  this.btn_remountsystem = new System.Windows.Forms.Button();
                  this.btnKillserver = new System.Windows.Forms.Button();
                  this.btn_openshell = new System.Windows.Forms.Button();
                  this.txt_devices = new System.Windows.Forms.TextBox();
                  this.tabPage4 = new System.Windows.Forms.TabPage();
                  this.groupBox12 = new System.Windows.Forms.GroupBox();
                  this.btn_phoneinformation_resetsize = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_showsize = new System.Windows.Forms.Button();
                  this.txt_phoneinformation_resolution = new System.Windows.Forms.TextBox();
                  this.btn_phoneinformation_setsize = new System.Windows.Forms.Button();
                  this.groupBox9 = new System.Windows.Forms.GroupBox();
                  this.btn_phoneinformation_resetdpi = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_show = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_changedpi = new System.Windows.Forms.Button();
                  this.txt_phoneinformation_dpi = new System.Windows.Forms.TextBox();
                  this.groupBox6 = new System.Windows.Forms.GroupBox();
                  this.button2 = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_spoofmac = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_showmac = new System.Windows.Forms.Button();
                  this.txt_phoneinformation_mac = new System.Windows.Forms.TextBox();
                  this.groupBox5 = new System.Windows.Forms.GroupBox();
                  this.btnAlarm = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_screenshot = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_activities = new System.Windows.Forms.Button();
                  this.btn_phoninformation_hosts = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_uptime = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_netstat = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_diskstats = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_accounts = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_cpuinfo = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_wifiinfo = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_battery = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_dmesg = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_getimei = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_permissions = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_maxusers = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_users = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_libraries = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_features = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_processes = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_meminfo = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_dumpsys = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_logcat = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_installedpackages = new System.Windows.Forms.Button();
                  this.btn_phoneinformation_getprop = new System.Windows.Forms.Button();
                  this.tabPage2 = new System.Windows.Forms.TabPage();
                  this.groupBox10 = new System.Windows.Forms.GroupBox();
                  this.label2 = new System.Windows.Forms.Label();
                  this.btn_pull_pull = new System.Windows.Forms.Button();
                  this.btn_pull_saveto = new System.Windows.Forms.Button();
                  this.txt_pull_pathfrom = new System.Windows.Forms.TextBox();
                  this.txt_pull_pathto = new System.Windows.Forms.TextBox();
                  this.groupBox7 = new System.Windows.Forms.GroupBox();
                  this.label5 = new System.Windows.Forms.Label();
                  this.btn_push_push = new System.Windows.Forms.Button();
                  this.btn_push_openfile = new System.Windows.Forms.Button();
                  this.txt_push_tofilepath = new System.Windows.Forms.TextBox();
                  this.txt_push_fromfilepath = new System.Windows.Forms.TextBox();
                  this.groupBox2 = new System.Windows.Forms.GroupBox();
                  this.button1 = new System.Windows.Forms.Button();
                  this.txt_sideload_path = new System.Windows.Forms.TextBox();
                  this.label1 = new System.Windows.Forms.Label();
                  this.btn_sideload_sideload = new System.Windows.Forms.Button();
                  this.tabPage3 = new System.Windows.Forms.TabPage();
                  this.groupBox8 = new System.Windows.Forms.GroupBox();
                  this.label8 = new System.Windows.Forms.Label();
                  this.txt_backup_packagename = new System.Windows.Forms.TextBox();
                  this.cb_backup_package = new System.Windows.Forms.CheckBox();
                  this.btn_restore_restore = new System.Windows.Forms.Button();
                  this.btn_restore_openfile = new System.Windows.Forms.Button();
                  this.label4 = new System.Windows.Forms.Label();
                  this.txt_restore_path = new System.Windows.Forms.TextBox();
                  this.btn_backup_saveto = new System.Windows.Forms.Button();
                  this.cb_backup_nosystem = new System.Windows.Forms.CheckBox();
                  this.cb_backup_shared = new System.Windows.Forms.CheckBox();
                  this.cb_backup_withapk = new System.Windows.Forms.CheckBox();
                  this.label3 = new System.Windows.Forms.Label();
                  this.btn_backup_backup = new System.Windows.Forms.Button();
                  this.txt_backup_path = new System.Windows.Forms.TextBox();
                  this.groupBox3 = new System.Windows.Forms.GroupBox();
                  this.btn_packages_installed = new System.Windows.Forms.Button();
                  this.btn_packages_install = new System.Windows.Forms.Button();
                  this.txt_packages_package = new System.Windows.Forms.TextBox();
                  this.btn_packages_uninstall = new System.Windows.Forms.Button();
                  this.txt_packages_path = new System.Windows.Forms.TextBox();
                  this.btn_packages_open = new System.Windows.Forms.Button();
                  this.tabPage5 = new System.Windows.Forms.TabPage();
                  this.label10 = new System.Windows.Forms.Label();
                  this.label9 = new System.Windows.Forms.Label();
                  this.btn_donate = new System.Windows.Forms.Button();
                  this.button4 = new System.Windows.Forms.Button();
                  this.button3 = new System.Windows.Forms.Button();
                  this.label7 = new System.Windows.Forms.Label();
                  this.label6 = new System.Windows.Forms.Label();
                  this.toolTip = new System.Windows.Forms.ToolTip(this.components);
                  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
                  this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
                  this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
                  this.tabControl1.SuspendLayout();
                  this.tabPage1.SuspendLayout();
                  this.groupBox13.SuspendLayout();
                  this.groupBox11.SuspendLayout();
                  this.groupBox4.SuspendLayout();
                  this.groupBox1.SuspendLayout();
                  this.tabPage4.SuspendLayout();
                  this.groupBox12.SuspendLayout();
                  this.groupBox9.SuspendLayout();
                  this.groupBox6.SuspendLayout();
                  this.groupBox5.SuspendLayout();
                  this.tabPage2.SuspendLayout();
                  this.groupBox10.SuspendLayout();
                  this.groupBox7.SuspendLayout();
                  this.groupBox2.SuspendLayout();
                  this.tabPage3.SuspendLayout();
                  this.groupBox8.SuspendLayout();
                  this.groupBox3.SuspendLayout();
                  this.tabPage5.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // tabControl1
                  // 
                  this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.tabControl1.Controls.Add(this.tabPage1);
                  this.tabControl1.Controls.Add(this.tabPage4);
                  this.tabControl1.Controls.Add(this.tabPage2);
                  this.tabControl1.Controls.Add(this.tabPage3);
                  this.tabControl1.Controls.Add(this.tabPage5);
                  this.tabControl1.Location = new System.Drawing.Point(12, 12);
                  this.tabControl1.Name = "tabControl1";
                  this.tabControl1.SelectedIndex = 0;
                  this.tabControl1.Size = new System.Drawing.Size(518, 306);
                  this.tabControl1.TabIndex = 6;
                  // 
                  // tabPage1
                  // 
                  this.tabPage1.Controls.Add(this.groupBox13);
                  this.tabPage1.Controls.Add(this.groupBox11);
                  this.tabPage1.Controls.Add(this.groupBox4);
                  this.tabPage1.Controls.Add(this.groupBox1);
                  this.tabPage1.Controls.Add(this.txt_devices);
                  this.tabPage1.Location = new System.Drawing.Point(4, 22);
                  this.tabPage1.Name = "tabPage1";
                  this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
                  this.tabPage1.Size = new System.Drawing.Size(510, 280);
                  this.tabPage1.TabIndex = 0;
                  this.tabPage1.Text = "All Commands";
                  this.tabPage1.UseVisualStyleBackColor = true;
                  // 
                  // groupBox13
                  // 
                  this.groupBox13.Controls.Add(this.txt_serialno);
                  this.groupBox13.Location = new System.Drawing.Point(264, 60);
                  this.groupBox13.Name = "groupBox13";
                  this.groupBox13.Size = new System.Drawing.Size(240, 47);
                  this.groupBox13.TabIndex = 4;
                  this.groupBox13.TabStop = false;
                  this.groupBox13.Text = "Serial Number";
                  // 
                  // txt_serialno
                  // 
                  this.txt_serialno.Location = new System.Drawing.Point(6, 19);
                  this.txt_serialno.Name = "txt_serialno";
                  this.txt_serialno.Size = new System.Drawing.Size(229, 20);
                  this.txt_serialno.TabIndex = 12;
                  // 
                  // groupBox11
                  // 
                  this.groupBox11.Controls.Add(this.txt_ip);
                  this.groupBox11.Controls.Add(this.btn_connect);
                  this.groupBox11.Location = new System.Drawing.Point(6, 60);
                  this.groupBox11.Name = "groupBox11";
                  this.groupBox11.Size = new System.Drawing.Size(252, 47);
                  this.groupBox11.TabIndex = 3;
                  this.groupBox11.TabStop = false;
                  this.groupBox11.Text = "Wireless ADB";
                  // 
                  // txt_ip
                  // 
                  this.txt_ip.Location = new System.Drawing.Point(7, 19);
                  this.txt_ip.Name = "txt_ip";
                  this.txt_ip.Size = new System.Drawing.Size(159, 20);
                  this.txt_ip.TabIndex = 10;
                  this.txt_ip.Text = "192.168.0.100";
                  this.txt_ip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ip_KeyDown);
                  // 
                  // btn_connect
                  // 
                  this.btn_connect.Location = new System.Drawing.Point(172, 17);
                  this.btn_connect.Name = "btn_connect";
                  this.btn_connect.Size = new System.Drawing.Size(75, 23);
                  this.btn_connect.TabIndex = 11;
                  this.btn_connect.Text = "Connect";
                  this.btn_connect.UseVisualStyleBackColor = true;
                  this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
                  // 
                  // groupBox4
                  // 
                  this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.groupBox4.Controls.Add(this.btn_run);
                  this.groupBox4.Controls.Add(this.txt_customcommand);
                  this.groupBox4.Location = new System.Drawing.Point(6, 113);
                  this.groupBox4.Name = "groupBox4";
                  this.groupBox4.Size = new System.Drawing.Size(498, 46);
                  this.groupBox4.TabIndex = 1;
                  this.groupBox4.TabStop = false;
                  this.groupBox4.Text = "Custom Command";
                  // 
                  // btn_run
                  // 
                  this.btn_run.Location = new System.Drawing.Point(415, 17);
                  this.btn_run.Name = "btn_run";
                  this.btn_run.Size = new System.Drawing.Size(78, 23);
                  this.btn_run.TabIndex = 1;
                  this.btn_run.Text = "Run";
                  this.btn_run.UseVisualStyleBackColor = true;
                  this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
                  // 
                  // txt_customcommand
                  // 
                  this.txt_customcommand.Location = new System.Drawing.Point(4, 19);
                  this.txt_customcommand.Name = "txt_customcommand";
                  this.txt_customcommand.Size = new System.Drawing.Size(405, 20);
                  this.txt_customcommand.TabIndex = 0;
                  this.toolTip.SetToolTip(this.txt_customcommand, "You dont need to write \"adb\", If you have a path or file with spaces, then you ne" +
        "ed to put the path or filename in quotation marks.\r\n");
                  this.txt_customcommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_customcommand_KeyDown);
                  // 
                  // groupBox1
                  // 
                  this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.groupBox1.Controls.Add(this.btn_reboot);
                  this.groupBox1.Controls.Add(this.btn_remountsystem);
                  this.groupBox1.Controls.Add(this.btnKillserver);
                  this.groupBox1.Controls.Add(this.btn_openshell);
                  this.groupBox1.Location = new System.Drawing.Point(6, 6);
                  this.groupBox1.Name = "groupBox1";
                  this.groupBox1.Size = new System.Drawing.Size(498, 48);
                  this.groupBox1.TabIndex = 2;
                  this.groupBox1.TabStop = false;
                  this.groupBox1.Text = "Standard";
                  // 
                  // btn_reboot
                  // 
                  this.btn_reboot.Location = new System.Drawing.Point(172, 19);
                  this.btn_reboot.Name = "btn_reboot";
                  this.btn_reboot.Size = new System.Drawing.Size(156, 23);
                  this.btn_reboot.TabIndex = 4;
                  this.btn_reboot.Text = "Power Menu";
                  this.toolTip.SetToolTip(this.btn_reboot, "Reboot the device");
                  this.btn_reboot.UseVisualStyleBackColor = true;
                  this.btn_reboot.Click += new System.EventHandler(this.btn_reboot_Click);
                  // 
                  // btn_remountsystem
                  // 
                  this.btn_remountsystem.Location = new System.Drawing.Point(71, 19);
                  this.btn_remountsystem.Name = "btn_remountsystem";
                  this.btn_remountsystem.Size = new System.Drawing.Size(95, 23);
                  this.btn_remountsystem.TabIndex = 9;
                  this.btn_remountsystem.Text = "Remount System";
                  this.toolTip.SetToolTip(this.btn_remountsystem, "Remounts the /system partition on the device read-write");
                  this.btn_remountsystem.UseVisualStyleBackColor = true;
                  this.btn_remountsystem.Click += new System.EventHandler(this.btn_remountsystem_Click);
                  // 
                  // btnKillserver
                  // 
                  this.btnKillserver.AccessibleDescription = "";
                  this.btnKillserver.Location = new System.Drawing.Point(7, 19);
                  this.btnKillserver.Name = "btnKillserver";
                  this.btnKillserver.Size = new System.Drawing.Size(58, 23);
                  this.btnKillserver.TabIndex = 6;
                  this.btnKillserver.Text = "Restart";
                  this.toolTip.SetToolTip(this.btnKillserver, "Kill the server if it is running");
                  this.btnKillserver.UseVisualStyleBackColor = true;
                  this.btnKillserver.Click += new System.EventHandler(this.btnKillserver_Click);
                  // 
                  // btn_openshell
                  // 
                  this.btn_openshell.AccessibleDescription = "";
                  this.btn_openshell.Location = new System.Drawing.Point(333, 19);
                  this.btn_openshell.Name = "btn_openshell";
                  this.btn_openshell.Size = new System.Drawing.Size(159, 23);
                  this.btn_openshell.TabIndex = 5;
                  this.btn_openshell.Text = "Open Shell";
                  this.toolTip.SetToolTip(this.btn_openshell, "Open the shell");
                  this.btn_openshell.UseVisualStyleBackColor = true;
                  this.btn_openshell.Click += new System.EventHandler(this.btn_openshell_Click);
                  // 
                  // txt_devices
                  // 
                  this.txt_devices.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.txt_devices.Location = new System.Drawing.Point(6, 165);
                  this.txt_devices.Multiline = true;
                  this.txt_devices.Name = "txt_devices";
                  this.txt_devices.ReadOnly = true;
                  this.txt_devices.Size = new System.Drawing.Size(498, 109);
                  this.txt_devices.TabIndex = 5;
                  // 
                  // tabPage4
                  // 
                  this.tabPage4.Controls.Add(this.groupBox12);
                  this.tabPage4.Controls.Add(this.groupBox9);
                  this.tabPage4.Controls.Add(this.groupBox6);
                  this.tabPage4.Controls.Add(this.groupBox5);
                  this.tabPage4.Location = new System.Drawing.Point(4, 22);
                  this.tabPage4.Name = "tabPage4";
                  this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
                  this.tabPage4.Size = new System.Drawing.Size(510, 280);
                  this.tabPage4.TabIndex = 3;
                  this.tabPage4.Text = "Phone Information";
                  this.tabPage4.UseVisualStyleBackColor = true;
                  // 
                  // groupBox12
                  // 
                  this.groupBox12.Controls.Add(this.btn_phoneinformation_resetsize);
                  this.groupBox12.Controls.Add(this.btn_phoneinformation_showsize);
                  this.groupBox12.Controls.Add(this.txt_phoneinformation_resolution);
                  this.groupBox12.Controls.Add(this.btn_phoneinformation_setsize);
                  this.groupBox12.Location = new System.Drawing.Point(354, 183);
                  this.groupBox12.Name = "groupBox12";
                  this.groupBox12.Size = new System.Drawing.Size(150, 91);
                  this.groupBox12.TabIndex = 14;
                  this.groupBox12.TabStop = false;
                  this.groupBox12.Text = "Resolution";
                  // 
                  // btn_phoneinformation_resetsize
                  // 
                  this.btn_phoneinformation_resetsize.Location = new System.Drawing.Point(78, 45);
                  this.btn_phoneinformation_resetsize.Name = "btn_phoneinformation_resetsize";
                  this.btn_phoneinformation_resetsize.Size = new System.Drawing.Size(66, 23);
                  this.btn_phoneinformation_resetsize.TabIndex = 42;
                  this.btn_phoneinformation_resetsize.Text = "Reset";
                  this.btn_phoneinformation_resetsize.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_resetsize.Click += new System.EventHandler(this.button6_Click);
                  // 
                  // btn_phoneinformation_showsize
                  // 
                  this.btn_phoneinformation_showsize.Location = new System.Drawing.Point(6, 45);
                  this.btn_phoneinformation_showsize.Name = "btn_phoneinformation_showsize";
                  this.btn_phoneinformation_showsize.Size = new System.Drawing.Size(66, 23);
                  this.btn_phoneinformation_showsize.TabIndex = 41;
                  this.btn_phoneinformation_showsize.Text = "Show current DPI";
                  this.btn_phoneinformation_showsize.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_showsize.Click += new System.EventHandler(this.button7_Click);
                  // 
                  // txt_phoneinformation_resolution
                  // 
                  this.txt_phoneinformation_resolution.Location = new System.Drawing.Point(6, 19);
                  this.txt_phoneinformation_resolution.Name = "txt_phoneinformation_resolution";
                  this.txt_phoneinformation_resolution.Size = new System.Drawing.Size(83, 20);
                  this.txt_phoneinformation_resolution.TabIndex = 6;
                  this.txt_phoneinformation_resolution.Text = "1080x1920";
                  this.txt_phoneinformation_resolution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_phoneinformation_resolution_KeyDown);
                  // 
                  // btn_phoneinformation_setsize
                  // 
                  this.btn_phoneinformation_setsize.Location = new System.Drawing.Point(95, 17);
                  this.btn_phoneinformation_setsize.Name = "btn_phoneinformation_setsize";
                  this.btn_phoneinformation_setsize.Size = new System.Drawing.Size(49, 23);
                  this.btn_phoneinformation_setsize.TabIndex = 5;
                  this.btn_phoneinformation_setsize.Text = "Set";
                  this.btn_phoneinformation_setsize.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_setsize.Click += new System.EventHandler(this.button5_Click);
                  // 
                  // groupBox9
                  // 
                  this.groupBox9.Controls.Add(this.btn_phoneinformation_resetdpi);
                  this.groupBox9.Controls.Add(this.btn_phoneinformation_show);
                  this.groupBox9.Controls.Add(this.btn_phoneinformation_changedpi);
                  this.groupBox9.Controls.Add(this.txt_phoneinformation_dpi);
                  this.groupBox9.Location = new System.Drawing.Point(354, 93);
                  this.groupBox9.Name = "groupBox9";
                  this.groupBox9.Size = new System.Drawing.Size(150, 84);
                  this.groupBox9.TabIndex = 13;
                  this.groupBox9.TabStop = false;
                  this.groupBox9.Text = "Change DPI";
                  // 
                  // btn_phoneinformation_resetdpi
                  // 
                  this.btn_phoneinformation_resetdpi.Location = new System.Drawing.Point(78, 45);
                  this.btn_phoneinformation_resetdpi.Name = "btn_phoneinformation_resetdpi";
                  this.btn_phoneinformation_resetdpi.Size = new System.Drawing.Size(66, 23);
                  this.btn_phoneinformation_resetdpi.TabIndex = 40;
                  this.btn_phoneinformation_resetdpi.Text = "Reset";
                  this.btn_phoneinformation_resetdpi.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_resetdpi.Click += new System.EventHandler(this.btn_phoneinformation_resetdpi_Click);
                  // 
                  // btn_phoneinformation_show
                  // 
                  this.btn_phoneinformation_show.Location = new System.Drawing.Point(6, 45);
                  this.btn_phoneinformation_show.Name = "btn_phoneinformation_show";
                  this.btn_phoneinformation_show.Size = new System.Drawing.Size(66, 23);
                  this.btn_phoneinformation_show.TabIndex = 30;
                  this.btn_phoneinformation_show.Text = "Show current DPI";
                  this.btn_phoneinformation_show.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_show.Click += new System.EventHandler(this.btn_phoneinformation_show_Click);
                  // 
                  // btn_phoneinformation_changedpi
                  // 
                  this.btn_phoneinformation_changedpi.Location = new System.Drawing.Point(105, 16);
                  this.btn_phoneinformation_changedpi.Name = "btn_phoneinformation_changedpi";
                  this.btn_phoneinformation_changedpi.Size = new System.Drawing.Size(39, 23);
                  this.btn_phoneinformation_changedpi.TabIndex = 29;
                  this.btn_phoneinformation_changedpi.Text = "Set";
                  this.btn_phoneinformation_changedpi.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_changedpi.Click += new System.EventHandler(this.btn_phoneinformation_changedpi_Click);
                  // 
                  // txt_phoneinformation_dpi
                  // 
                  this.txt_phoneinformation_dpi.Location = new System.Drawing.Point(6, 19);
                  this.txt_phoneinformation_dpi.Name = "txt_phoneinformation_dpi";
                  this.txt_phoneinformation_dpi.Size = new System.Drawing.Size(93, 20);
                  this.txt_phoneinformation_dpi.TabIndex = 28;
                  this.txt_phoneinformation_dpi.Text = "480";
                  this.txt_phoneinformation_dpi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_phoneinformation_dpi_KeyDown);
                  // 
                  // groupBox6
                  // 
                  this.groupBox6.Controls.Add(this.button2);
                  this.groupBox6.Controls.Add(this.btn_phoneinformation_spoofmac);
                  this.groupBox6.Controls.Add(this.btn_phoneinformation_showmac);
                  this.groupBox6.Controls.Add(this.txt_phoneinformation_mac);
                  this.groupBox6.Location = new System.Drawing.Point(354, 6);
                  this.groupBox6.Name = "groupBox6";
                  this.groupBox6.Size = new System.Drawing.Size(150, 76);
                  this.groupBox6.TabIndex = 12;
                  this.groupBox6.TabStop = false;
                  this.groupBox6.Text = "Spoof MAC";
                  // 
                  // button2
                  // 
                  this.button2.Location = new System.Drawing.Point(78, 46);
                  this.button2.Name = "button2";
                  this.button2.Size = new System.Drawing.Size(66, 23);
                  this.button2.TabIndex = 27;
                  this.button2.Text = "Restore";
                  this.button2.UseVisualStyleBackColor = true;
                  this.button2.Click += new System.EventHandler(this.button2_Click);
                  // 
                  // btn_phoneinformation_spoofmac
                  // 
                  this.btn_phoneinformation_spoofmac.Location = new System.Drawing.Point(105, 20);
                  this.btn_phoneinformation_spoofmac.Name = "btn_phoneinformation_spoofmac";
                  this.btn_phoneinformation_spoofmac.Size = new System.Drawing.Size(39, 23);
                  this.btn_phoneinformation_spoofmac.TabIndex = 25;
                  this.btn_phoneinformation_spoofmac.Text = "Set";
                  this.btn_phoneinformation_spoofmac.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_spoofmac.Click += new System.EventHandler(this.btn_phoneinformation_spoofmac_Click);
                  // 
                  // btn_phoneinformation_showmac
                  // 
                  this.btn_phoneinformation_showmac.Location = new System.Drawing.Point(6, 46);
                  this.btn_phoneinformation_showmac.Name = "btn_phoneinformation_showmac";
                  this.btn_phoneinformation_showmac.Size = new System.Drawing.Size(66, 23);
                  this.btn_phoneinformation_showmac.TabIndex = 26;
                  this.btn_phoneinformation_showmac.Text = "Show";
                  this.btn_phoneinformation_showmac.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_showmac.Click += new System.EventHandler(this.btn_phoneinformation_showmac_Click);
                  // 
                  // txt_phoneinformation_mac
                  // 
                  this.txt_phoneinformation_mac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
                  this.txt_phoneinformation_mac.Location = new System.Drawing.Point(6, 22);
                  this.txt_phoneinformation_mac.Name = "txt_phoneinformation_mac";
                  this.txt_phoneinformation_mac.Size = new System.Drawing.Size(93, 20);
                  this.txt_phoneinformation_mac.TabIndex = 24;
                  this.txt_phoneinformation_mac.Text = "00:11:22:33:44:55";
                  this.txt_phoneinformation_mac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_phoneinformation_mac_KeyDown);
                  // 
                  // groupBox5
                  // 
                  this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.groupBox5.Controls.Add(this.btnAlarm);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_screenshot);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_activities);
                  this.groupBox5.Controls.Add(this.btn_phoninformation_hosts);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_uptime);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_netstat);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_diskstats);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_accounts);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_cpuinfo);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_wifiinfo);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_battery);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_dmesg);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_getimei);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_permissions);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_maxusers);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_users);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_libraries);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_features);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_processes);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_meminfo);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_dumpsys);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_logcat);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_installedpackages);
                  this.groupBox5.Controls.Add(this.btn_phoneinformation_getprop);
                  this.groupBox5.Location = new System.Drawing.Point(6, 6);
                  this.groupBox5.Name = "groupBox5";
                  this.groupBox5.Size = new System.Drawing.Size(342, 268);
                  this.groupBox5.TabIndex = 1;
                  this.groupBox5.TabStop = false;
                  this.groupBox5.Text = "Phone Information";
                  // 
                  // btnAlarm
                  // 
                  this.btnAlarm.Location = new System.Drawing.Point(118, 77);
                  this.btnAlarm.Name = "btnAlarm";
                  this.btnAlarm.Size = new System.Drawing.Size(106, 23);
                  this.btnAlarm.TabIndex = 26;
                  this.btnAlarm.Text = "Alarm State";
                  this.btnAlarm.UseVisualStyleBackColor = true;
                  this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
                  // 
                  // btn_phoneinformation_screenshot
                  // 
                  this.btn_phoneinformation_screenshot.Location = new System.Drawing.Point(230, 222);
                  this.btn_phoneinformation_screenshot.Name = "btn_phoneinformation_screenshot";
                  this.btn_phoneinformation_screenshot.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_screenshot.TabIndex = 25;
                  this.btn_phoneinformation_screenshot.Text = "Screenshot";
                  this.btn_phoneinformation_screenshot.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_screenshot.Click += new System.EventHandler(this.btn_phoneinformation_screenshot_Click);
                  // 
                  // btn_phoneinformation_activities
                  // 
                  this.btn_phoneinformation_activities.Location = new System.Drawing.Point(118, 222);
                  this.btn_phoneinformation_activities.Name = "btn_phoneinformation_activities";
                  this.btn_phoneinformation_activities.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_activities.TabIndex = 24;
                  this.btn_phoneinformation_activities.Text = "Activities";
                  this.btn_phoneinformation_activities.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_activities.Click += new System.EventHandler(this.btn_phoneinformation_activities_Click);
                  // 
                  // btn_phoninformation_hosts
                  // 
                  this.btn_phoninformation_hosts.Location = new System.Drawing.Point(6, 222);
                  this.btn_phoninformation_hosts.Name = "btn_phoninformation_hosts";
                  this.btn_phoninformation_hosts.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoninformation_hosts.TabIndex = 23;
                  this.btn_phoninformation_hosts.Text = "Hosts";
                  this.btn_phoninformation_hosts.UseVisualStyleBackColor = true;
                  this.btn_phoninformation_hosts.Click += new System.EventHandler(this.btn_phoninformation_hosts_Click);
                  // 
                  // btn_phoneinformation_uptime
                  // 
                  this.btn_phoneinformation_uptime.Location = new System.Drawing.Point(230, 106);
                  this.btn_phoneinformation_uptime.Name = "btn_phoneinformation_uptime";
                  this.btn_phoneinformation_uptime.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_uptime.TabIndex = 19;
                  this.btn_phoneinformation_uptime.Text = "Uptime";
                  this.btn_phoneinformation_uptime.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_uptime.Click += new System.EventHandler(this.btn_phoneinformation_uptime_Click);
                  // 
                  // btn_phoneinformation_netstat
                  // 
                  this.btn_phoneinformation_netstat.Location = new System.Drawing.Point(230, 164);
                  this.btn_phoneinformation_netstat.Name = "btn_phoneinformation_netstat";
                  this.btn_phoneinformation_netstat.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_netstat.TabIndex = 21;
                  this.btn_phoneinformation_netstat.Text = "Netstat";
                  this.btn_phoneinformation_netstat.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_netstat.Click += new System.EventHandler(this.btn_phoneinformation_netstat_Click);
                  // 
                  // btn_phoneinformation_diskstats
                  // 
                  this.btn_phoneinformation_diskstats.Location = new System.Drawing.Point(6, 193);
                  this.btn_phoneinformation_diskstats.Name = "btn_phoneinformation_diskstats";
                  this.btn_phoneinformation_diskstats.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_diskstats.TabIndex = 6;
                  this.btn_phoneinformation_diskstats.Text = "Diskstats";
                  this.btn_phoneinformation_diskstats.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_diskstats.Click += new System.EventHandler(this.btn_phoneinformation_diskstats_Click);
                  // 
                  // btn_phoneinformation_accounts
                  // 
                  this.btn_phoneinformation_accounts.Location = new System.Drawing.Point(118, 193);
                  this.btn_phoneinformation_accounts.Name = "btn_phoneinformation_accounts";
                  this.btn_phoneinformation_accounts.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_accounts.TabIndex = 14;
                  this.btn_phoneinformation_accounts.Text = "Accounts";
                  this.btn_phoneinformation_accounts.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_accounts.Click += new System.EventHandler(this.btn_phoneinformation_accounts_Click);
                  // 
                  // btn_phoneinformation_cpuinfo
                  // 
                  this.btn_phoneinformation_cpuinfo.Location = new System.Drawing.Point(118, 164);
                  this.btn_phoneinformation_cpuinfo.Name = "btn_phoneinformation_cpuinfo";
                  this.btn_phoneinformation_cpuinfo.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_cpuinfo.TabIndex = 13;
                  this.btn_phoneinformation_cpuinfo.Text = "CPU Info";
                  this.btn_phoneinformation_cpuinfo.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_cpuinfo.Click += new System.EventHandler(this.btn_phoneinformation_cpuinfo_Click);
                  // 
                  // btn_phoneinformation_wifiinfo
                  // 
                  this.btn_phoneinformation_wifiinfo.Location = new System.Drawing.Point(6, 164);
                  this.btn_phoneinformation_wifiinfo.Name = "btn_phoneinformation_wifiinfo";
                  this.btn_phoneinformation_wifiinfo.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_wifiinfo.TabIndex = 5;
                  this.btn_phoneinformation_wifiinfo.Text = "WiFi Info";
                  this.btn_phoneinformation_wifiinfo.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_wifiinfo.Click += new System.EventHandler(this.btn_phoneinformation_wifiinfo_Click);
                  // 
                  // btn_phoneinformation_battery
                  // 
                  this.btn_phoneinformation_battery.Location = new System.Drawing.Point(230, 135);
                  this.btn_phoneinformation_battery.Name = "btn_phoneinformation_battery";
                  this.btn_phoneinformation_battery.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_battery.TabIndex = 20;
                  this.btn_phoneinformation_battery.Text = "Battery Stats";
                  this.btn_phoneinformation_battery.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_battery.Click += new System.EventHandler(this.btn_phoneinformation_battery_Click);
                  // 
                  // btn_phoneinformation_dmesg
                  // 
                  this.btn_phoneinformation_dmesg.Location = new System.Drawing.Point(118, 135);
                  this.btn_phoneinformation_dmesg.Name = "btn_phoneinformation_dmesg";
                  this.btn_phoneinformation_dmesg.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_dmesg.TabIndex = 12;
                  this.btn_phoneinformation_dmesg.Text = "Kernel Debugging";
                  this.btn_phoneinformation_dmesg.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_dmesg.Click += new System.EventHandler(this.btn_phoneinformation_dmesg_Click);
                  // 
                  // btn_phoneinformation_getimei
                  // 
                  this.btn_phoneinformation_getimei.Location = new System.Drawing.Point(6, 135);
                  this.btn_phoneinformation_getimei.Name = "btn_phoneinformation_getimei";
                  this.btn_phoneinformation_getimei.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_getimei.TabIndex = 4;
                  this.btn_phoneinformation_getimei.Text = "Get IMEI";
                  this.btn_phoneinformation_getimei.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_getimei.Click += new System.EventHandler(this.btn_phoneinformation_getimei_Click);
                  // 
                  // btn_phoneinformation_permissions
                  // 
                  this.btn_phoneinformation_permissions.Location = new System.Drawing.Point(230, 193);
                  this.btn_phoneinformation_permissions.Name = "btn_phoneinformation_permissions";
                  this.btn_phoneinformation_permissions.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_permissions.TabIndex = 22;
                  this.btn_phoneinformation_permissions.Text = "Permissions";
                  this.btn_phoneinformation_permissions.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_permissions.Click += new System.EventHandler(this.btn_phoneinformation_permissions_Click);
                  // 
                  // btn_phoneinformation_maxusers
                  // 
                  this.btn_phoneinformation_maxusers.Location = new System.Drawing.Point(118, 106);
                  this.btn_phoneinformation_maxusers.Name = "btn_phoneinformation_maxusers";
                  this.btn_phoneinformation_maxusers.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_maxusers.TabIndex = 11;
                  this.btn_phoneinformation_maxusers.Text = "Max Users";
                  this.btn_phoneinformation_maxusers.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_maxusers.Click += new System.EventHandler(this.btn_phoneinformation_maxusers_Click);
                  // 
                  // btn_phoneinformation_users
                  // 
                  this.btn_phoneinformation_users.Location = new System.Drawing.Point(6, 106);
                  this.btn_phoneinformation_users.Name = "btn_phoneinformation_users";
                  this.btn_phoneinformation_users.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_users.TabIndex = 3;
                  this.btn_phoneinformation_users.Text = "All Users";
                  this.btn_phoneinformation_users.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_users.Click += new System.EventHandler(this.btn_phoneinformation_users_Click);
                  // 
                  // btn_phoneinformation_libraries
                  // 
                  this.btn_phoneinformation_libraries.Location = new System.Drawing.Point(230, 77);
                  this.btn_phoneinformation_libraries.Name = "btn_phoneinformation_libraries";
                  this.btn_phoneinformation_libraries.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_libraries.TabIndex = 18;
                  this.btn_phoneinformation_libraries.Text = "Libraries";
                  this.btn_phoneinformation_libraries.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_libraries.Click += new System.EventHandler(this.btn_phoneinformation_libraries_Click);
                  // 
                  // btn_phoneinformation_features
                  // 
                  this.btn_phoneinformation_features.Location = new System.Drawing.Point(230, 48);
                  this.btn_phoneinformation_features.Name = "btn_phoneinformation_features";
                  this.btn_phoneinformation_features.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_features.TabIndex = 17;
                  this.btn_phoneinformation_features.Text = "Features";
                  this.btn_phoneinformation_features.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_features.Click += new System.EventHandler(this.btn_phoneinformation_features_Click);
                  // 
                  // btn_phoneinformation_processes
                  // 
                  this.btn_phoneinformation_processes.Location = new System.Drawing.Point(6, 48);
                  this.btn_phoneinformation_processes.Name = "btn_phoneinformation_processes";
                  this.btn_phoneinformation_processes.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_processes.TabIndex = 1;
                  this.btn_phoneinformation_processes.Text = "Show Processes";
                  this.btn_phoneinformation_processes.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_processes.Click += new System.EventHandler(this.btn_phoneinformation_processes_Click);
                  // 
                  // btn_phoneinformation_meminfo
                  // 
                  this.btn_phoneinformation_meminfo.Location = new System.Drawing.Point(118, 48);
                  this.btn_phoneinformation_meminfo.Name = "btn_phoneinformation_meminfo";
                  this.btn_phoneinformation_meminfo.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_meminfo.TabIndex = 9;
                  this.btn_phoneinformation_meminfo.Text = "Memory Info";
                  this.btn_phoneinformation_meminfo.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_meminfo.Click += new System.EventHandler(this.btn_phoneinformation_meminfo_Click);
                  // 
                  // btn_phoneinformation_dumpsys
                  // 
                  this.btn_phoneinformation_dumpsys.Location = new System.Drawing.Point(118, 19);
                  this.btn_phoneinformation_dumpsys.Name = "btn_phoneinformation_dumpsys";
                  this.btn_phoneinformation_dumpsys.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_dumpsys.TabIndex = 8;
                  this.btn_phoneinformation_dumpsys.Text = "Dumpsys";
                  this.btn_phoneinformation_dumpsys.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_dumpsys.Click += new System.EventHandler(this.btn_phoneinformation_dumpsys_Click);
                  // 
                  // btn_phoneinformation_logcat
                  // 
                  this.btn_phoneinformation_logcat.Location = new System.Drawing.Point(230, 19);
                  this.btn_phoneinformation_logcat.Name = "btn_phoneinformation_logcat";
                  this.btn_phoneinformation_logcat.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_logcat.TabIndex = 16;
                  this.btn_phoneinformation_logcat.Text = "Logcat";
                  this.btn_phoneinformation_logcat.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_logcat.Click += new System.EventHandler(this.btn_phoneinformation_logcat_Click);
                  // 
                  // btn_phoneinformation_installedpackages
                  // 
                  this.btn_phoneinformation_installedpackages.Location = new System.Drawing.Point(6, 77);
                  this.btn_phoneinformation_installedpackages.Name = "btn_phoneinformation_installedpackages";
                  this.btn_phoneinformation_installedpackages.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_installedpackages.TabIndex = 2;
                  this.btn_phoneinformation_installedpackages.Text = "All Packages";
                  this.btn_phoneinformation_installedpackages.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_installedpackages.Click += new System.EventHandler(this.btn_phoneinformation_installedpackages_Click);
                  // 
                  // btn_phoneinformation_getprop
                  // 
                  this.btn_phoneinformation_getprop.Location = new System.Drawing.Point(6, 19);
                  this.btn_phoneinformation_getprop.Name = "btn_phoneinformation_getprop";
                  this.btn_phoneinformation_getprop.Size = new System.Drawing.Size(106, 23);
                  this.btn_phoneinformation_getprop.TabIndex = 0;
                  this.btn_phoneinformation_getprop.Text = "Get Prop";
                  this.btn_phoneinformation_getprop.UseVisualStyleBackColor = true;
                  this.btn_phoneinformation_getprop.Click += new System.EventHandler(this.btn_phoneinformation_getprop_Click);
                  // 
                  // tabPage2
                  // 
                  this.tabPage2.Controls.Add(this.groupBox10);
                  this.tabPage2.Controls.Add(this.groupBox7);
                  this.tabPage2.Controls.Add(this.groupBox2);
                  this.tabPage2.Location = new System.Drawing.Point(4, 22);
                  this.tabPage2.Name = "tabPage2";
                  this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
                  this.tabPage2.Size = new System.Drawing.Size(510, 280);
                  this.tabPage2.TabIndex = 1;
                  this.tabPage2.Text = "Files";
                  this.tabPage2.UseVisualStyleBackColor = true;
                  // 
                  // groupBox10
                  // 
                  this.groupBox10.Controls.Add(this.label2);
                  this.groupBox10.Controls.Add(this.btn_pull_pull);
                  this.groupBox10.Controls.Add(this.btn_pull_saveto);
                  this.groupBox10.Controls.Add(this.txt_pull_pathfrom);
                  this.groupBox10.Controls.Add(this.txt_pull_pathto);
                  this.groupBox10.Location = new System.Drawing.Point(6, 189);
                  this.groupBox10.Name = "groupBox10";
                  this.groupBox10.Size = new System.Drawing.Size(498, 85);
                  this.groupBox10.TabIndex = 3;
                  this.groupBox10.TabStop = false;
                  this.groupBox10.Text = "Pull Files";
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
                  // btn_pull_pull
                  // 
                  this.btn_pull_pull.Location = new System.Drawing.Point(417, 55);
                  this.btn_pull_pull.Name = "btn_pull_pull";
                  this.btn_pull_pull.Size = new System.Drawing.Size(75, 23);
                  this.btn_pull_pull.TabIndex = 10;
                  this.btn_pull_pull.Text = "Pull";
                  this.btn_pull_pull.UseVisualStyleBackColor = true;
                  this.btn_pull_pull.Click += new System.EventHandler(this.btn_pull_pull_Click);
                  // 
                  // btn_pull_saveto
                  // 
                  this.btn_pull_saveto.Location = new System.Drawing.Point(417, 29);
                  this.btn_pull_saveto.Name = "btn_pull_saveto";
                  this.btn_pull_saveto.Size = new System.Drawing.Size(75, 23);
                  this.btn_pull_saveto.TabIndex = 8;
                  this.btn_pull_saveto.Text = "Savte to";
                  this.btn_pull_saveto.UseVisualStyleBackColor = true;
                  this.btn_pull_saveto.Click += new System.EventHandler(this.btn_pull_saveto_Click);
                  // 
                  // txt_pull_pathfrom
                  // 
                  this.txt_pull_pathfrom.Location = new System.Drawing.Point(6, 57);
                  this.txt_pull_pathfrom.Name = "txt_pull_pathfrom";
                  this.txt_pull_pathfrom.Size = new System.Drawing.Size(405, 20);
                  this.txt_pull_pathfrom.TabIndex = 9;
                  this.txt_pull_pathfrom.Text = "/sdcard/";
                  this.txt_pull_pathfrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pull_pathfrom_KeyDown);
                  // 
                  // txt_pull_pathto
                  // 
                  this.txt_pull_pathto.Location = new System.Drawing.Point(6, 31);
                  this.txt_pull_pathto.Name = "txt_pull_pathto";
                  this.txt_pull_pathto.Size = new System.Drawing.Size(405, 20);
                  this.txt_pull_pathto.TabIndex = 7;
                  // 
                  // groupBox7
                  // 
                  this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.groupBox7.Controls.Add(this.label5);
                  this.groupBox7.Controls.Add(this.btn_push_push);
                  this.groupBox7.Controls.Add(this.btn_push_openfile);
                  this.groupBox7.Controls.Add(this.txt_push_tofilepath);
                  this.groupBox7.Controls.Add(this.txt_push_fromfilepath);
                  this.groupBox7.Location = new System.Drawing.Point(6, 98);
                  this.groupBox7.Name = "groupBox7";
                  this.groupBox7.Size = new System.Drawing.Size(498, 85);
                  this.groupBox7.TabIndex = 2;
                  this.groupBox7.TabStop = false;
                  this.groupBox7.Text = "Push Files";
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
                  // btn_push_push
                  // 
                  this.btn_push_push.Location = new System.Drawing.Point(417, 56);
                  this.btn_push_push.Name = "btn_push_push";
                  this.btn_push_push.Size = new System.Drawing.Size(75, 23);
                  this.btn_push_push.TabIndex = 6;
                  this.btn_push_push.Text = "Push";
                  this.btn_push_push.UseVisualStyleBackColor = true;
                  this.btn_push_push.Click += new System.EventHandler(this.btn_push_push_Click);
                  // 
                  // btn_push_openfile
                  // 
                  this.btn_push_openfile.Location = new System.Drawing.Point(417, 17);
                  this.btn_push_openfile.Name = "btn_push_openfile";
                  this.btn_push_openfile.Size = new System.Drawing.Size(75, 23);
                  this.btn_push_openfile.TabIndex = 4;
                  this.btn_push_openfile.Text = "Open file";
                  this.btn_push_openfile.UseVisualStyleBackColor = true;
                  this.btn_push_openfile.Click += new System.EventHandler(this.btn_push_openfile_Click);
                  // 
                  // txt_push_tofilepath
                  // 
                  this.txt_push_tofilepath.Location = new System.Drawing.Point(6, 58);
                  this.txt_push_tofilepath.Name = "txt_push_tofilepath";
                  this.txt_push_tofilepath.Size = new System.Drawing.Size(405, 20);
                  this.txt_push_tofilepath.TabIndex = 5;
                  this.txt_push_tofilepath.Text = "/sdcard/";
                  this.txt_push_tofilepath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_push_tofilepath_KeyDown);
                  // 
                  // txt_push_fromfilepath
                  // 
                  this.txt_push_fromfilepath.Location = new System.Drawing.Point(6, 19);
                  this.txt_push_fromfilepath.Name = "txt_push_fromfilepath";
                  this.txt_push_fromfilepath.Size = new System.Drawing.Size(405, 20);
                  this.txt_push_fromfilepath.TabIndex = 3;
                  // 
                  // groupBox2
                  // 
                  this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.groupBox2.Controls.Add(this.button1);
                  this.groupBox2.Controls.Add(this.txt_sideload_path);
                  this.groupBox2.Controls.Add(this.label1);
                  this.groupBox2.Controls.Add(this.btn_sideload_sideload);
                  this.groupBox2.Location = new System.Drawing.Point(6, 6);
                  this.groupBox2.Name = "groupBox2";
                  this.groupBox2.Size = new System.Drawing.Size(498, 86);
                  this.groupBox2.TabIndex = 1;
                  this.groupBox2.TabStop = false;
                  this.groupBox2.Text = "Sideload";
                  // 
                  // button1
                  // 
                  this.button1.Location = new System.Drawing.Point(333, 53);
                  this.button1.Name = "button1";
                  this.button1.Size = new System.Drawing.Size(75, 23);
                  this.button1.TabIndex = 1;
                  this.button1.Text = "Open file";
                  this.button1.UseVisualStyleBackColor = true;
                  this.button1.Click += new System.EventHandler(this.button1_Click);
                  // 
                  // txt_sideload_path
                  // 
                  this.txt_sideload_path.Location = new System.Drawing.Point(6, 55);
                  this.txt_sideload_path.Name = "txt_sideload_path";
                  this.txt_sideload_path.Size = new System.Drawing.Size(321, 20);
                  this.txt_sideload_path.TabIndex = 0;
                  // 
                  // label1
                  // 
                  this.label1.AutoSize = true;
                  this.label1.Location = new System.Drawing.Point(3, 22);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(195, 26);
                  this.label1.TabIndex = 1;
                  this.label1.Text = "1.  Enter Recovery in Sideload mode\r\n2.  Choose the file, click sideload button";
                  // 
                  // btn_sideload_sideload
                  // 
                  this.btn_sideload_sideload.Location = new System.Drawing.Point(414, 53);
                  this.btn_sideload_sideload.Name = "btn_sideload_sideload";
                  this.btn_sideload_sideload.Size = new System.Drawing.Size(75, 23);
                  this.btn_sideload_sideload.TabIndex = 2;
                  this.btn_sideload_sideload.Text = "Sideload";
                  this.btn_sideload_sideload.UseVisualStyleBackColor = true;
                  this.btn_sideload_sideload.Click += new System.EventHandler(this.btn_sideload_sideload_Click);
                  // 
                  // tabPage3
                  // 
                  this.tabPage3.Controls.Add(this.groupBox8);
                  this.tabPage3.Controls.Add(this.groupBox3);
                  this.tabPage3.Location = new System.Drawing.Point(4, 22);
                  this.tabPage3.Name = "tabPage3";
                  this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
                  this.tabPage3.Size = new System.Drawing.Size(510, 280);
                  this.tabPage3.TabIndex = 2;
                  this.tabPage3.Text = "Apps Backup";
                  this.tabPage3.UseVisualStyleBackColor = true;
                  // 
                  // groupBox8
                  // 
                  this.groupBox8.Controls.Add(this.label8);
                  this.groupBox8.Controls.Add(this.txt_backup_packagename);
                  this.groupBox8.Controls.Add(this.cb_backup_package);
                  this.groupBox8.Controls.Add(this.btn_restore_restore);
                  this.groupBox8.Controls.Add(this.btn_restore_openfile);
                  this.groupBox8.Controls.Add(this.label4);
                  this.groupBox8.Controls.Add(this.txt_restore_path);
                  this.groupBox8.Controls.Add(this.btn_backup_saveto);
                  this.groupBox8.Controls.Add(this.cb_backup_nosystem);
                  this.groupBox8.Controls.Add(this.cb_backup_shared);
                  this.groupBox8.Controls.Add(this.cb_backup_withapk);
                  this.groupBox8.Controls.Add(this.label3);
                  this.groupBox8.Controls.Add(this.btn_backup_backup);
                  this.groupBox8.Controls.Add(this.txt_backup_path);
                  this.groupBox8.Location = new System.Drawing.Point(6, 111);
                  this.groupBox8.Name = "groupBox8";
                  this.groupBox8.Size = new System.Drawing.Size(498, 163);
                  this.groupBox8.TabIndex = 7;
                  this.groupBox8.TabStop = false;
                  this.groupBox8.Text = "Backup and Restore";
                  // 
                  // label8
                  // 
                  this.label8.AutoSize = true;
                  this.label8.Location = new System.Drawing.Point(218, 27);
                  this.label8.Name = "label8";
                  this.label8.Size = new System.Drawing.Size(83, 13);
                  this.label8.TabIndex = 14;
                  this.label8.Text = "Wich package?";
                  this.label8.Visible = false;
                  // 
                  // txt_backup_packagename
                  // 
                  this.txt_backup_packagename.Location = new System.Drawing.Point(221, 43);
                  this.txt_backup_packagename.Name = "txt_backup_packagename";
                  this.txt_backup_packagename.Size = new System.Drawing.Size(109, 20);
                  this.txt_backup_packagename.TabIndex = 7;
                  this.txt_backup_packagename.Visible = false;
                  // 
                  // cb_backup_package
                  // 
                  this.cb_backup_package.AutoSize = true;
                  this.cb_backup_package.Location = new System.Drawing.Point(7, 69);
                  this.cb_backup_package.Name = "cb_backup_package";
                  this.cb_backup_package.Size = new System.Drawing.Size(109, 17);
                  this.cb_backup_package.TabIndex = 10;
                  this.cb_backup_package.Text = "Backup Package";
                  this.cb_backup_package.UseVisualStyleBackColor = true;
                  this.cb_backup_package.CheckedChanged += new System.EventHandler(this.cb_backup_package_CheckedChanged);
                  // 
                  // btn_restore_restore
                  // 
                  this.btn_restore_restore.Location = new System.Drawing.Point(418, 116);
                  this.btn_restore_restore.Name = "btn_restore_restore";
                  this.btn_restore_restore.Size = new System.Drawing.Size(75, 23);
                  this.btn_restore_restore.TabIndex = 16;
                  this.btn_restore_restore.Text = "Restore";
                  this.btn_restore_restore.UseVisualStyleBackColor = true;
                  this.btn_restore_restore.Click += new System.EventHandler(this.btn_restore_restore_Click);
                  // 
                  // btn_restore_openfile
                  // 
                  this.btn_restore_openfile.Location = new System.Drawing.Point(337, 117);
                  this.btn_restore_openfile.Name = "btn_restore_openfile";
                  this.btn_restore_openfile.Size = new System.Drawing.Size(75, 23);
                  this.btn_restore_openfile.TabIndex = 15;
                  this.btn_restore_openfile.Text = "Open file";
                  this.btn_restore_openfile.UseVisualStyleBackColor = true;
                  this.btn_restore_openfile.Click += new System.EventHandler(this.btn_restore_openfile_Click);
                  // 
                  // label4
                  // 
                  this.label4.AutoSize = true;
                  this.label4.Location = new System.Drawing.Point(7, 103);
                  this.label4.Name = "label4";
                  this.label4.Size = new System.Drawing.Size(44, 13);
                  this.label4.TabIndex = 9;
                  this.label4.Text = "Restore";
                  // 
                  // txt_restore_path
                  // 
                  this.txt_restore_path.Location = new System.Drawing.Point(7, 119);
                  this.txt_restore_path.Name = "txt_restore_path";
                  this.txt_restore_path.Size = new System.Drawing.Size(324, 20);
                  this.txt_restore_path.TabIndex = 14;
                  // 
                  // btn_backup_saveto
                  // 
                  this.btn_backup_saveto.Location = new System.Drawing.Point(336, 41);
                  this.btn_backup_saveto.Name = "btn_backup_saveto";
                  this.btn_backup_saveto.Size = new System.Drawing.Size(75, 23);
                  this.btn_backup_saveto.TabIndex = 8;
                  this.btn_backup_saveto.Text = "Save to";
                  this.btn_backup_saveto.UseVisualStyleBackColor = true;
                  this.btn_backup_saveto.Click += new System.EventHandler(this.btn_backup_saveto_Click);
                  // 
                  // cb_backup_nosystem
                  // 
                  this.cb_backup_nosystem.AutoSize = true;
                  this.cb_backup_nosystem.Location = new System.Drawing.Point(258, 69);
                  this.cb_backup_nosystem.Name = "cb_backup_nosystem";
                  this.cb_backup_nosystem.Size = new System.Drawing.Size(77, 17);
                  this.cb_backup_nosystem.TabIndex = 13;
                  this.cb_backup_nosystem.Text = "No System";
                  this.cb_backup_nosystem.UseVisualStyleBackColor = true;
                  // 
                  // cb_backup_shared
                  // 
                  this.cb_backup_shared.AutoSize = true;
                  this.cb_backup_shared.Location = new System.Drawing.Point(193, 69);
                  this.cb_backup_shared.Name = "cb_backup_shared";
                  this.cb_backup_shared.Size = new System.Drawing.Size(60, 17);
                  this.cb_backup_shared.TabIndex = 12;
                  this.cb_backup_shared.Text = "Shared";
                  this.cb_backup_shared.UseVisualStyleBackColor = true;
                  // 
                  // cb_backup_withapk
                  // 
                  this.cb_backup_withapk.AutoSize = true;
                  this.cb_backup_withapk.Location = new System.Drawing.Point(117, 69);
                  this.cb_backup_withapk.Name = "cb_backup_withapk";
                  this.cb_backup_withapk.Size = new System.Drawing.Size(72, 17);
                  this.cb_backup_withapk.TabIndex = 11;
                  this.cb_backup_withapk.Text = "With APK";
                  this.cb_backup_withapk.UseVisualStyleBackColor = true;
                  // 
                  // label3
                  // 
                  this.label3.AutoSize = true;
                  this.label3.Location = new System.Drawing.Point(3, 27);
                  this.label3.Name = "label3";
                  this.label3.Size = new System.Drawing.Size(44, 13);
                  this.label3.TabIndex = 3;
                  this.label3.Text = "Backup";
                  // 
                  // btn_backup_backup
                  // 
                  this.btn_backup_backup.Location = new System.Drawing.Point(417, 41);
                  this.btn_backup_backup.Name = "btn_backup_backup";
                  this.btn_backup_backup.Size = new System.Drawing.Size(75, 23);
                  this.btn_backup_backup.TabIndex = 9;
                  this.btn_backup_backup.Text = "Backup";
                  this.btn_backup_backup.UseVisualStyleBackColor = true;
                  this.btn_backup_backup.Click += new System.EventHandler(this.btn_backup_backup_Click);
                  // 
                  // txt_backup_path
                  // 
                  this.txt_backup_path.Location = new System.Drawing.Point(6, 43);
                  this.txt_backup_path.Name = "txt_backup_path";
                  this.txt_backup_path.Size = new System.Drawing.Size(324, 20);
                  this.txt_backup_path.TabIndex = 6;
                  // 
                  // groupBox3
                  // 
                  this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.groupBox3.Controls.Add(this.btn_packages_installed);
                  this.groupBox3.Controls.Add(this.btn_packages_install);
                  this.groupBox3.Controls.Add(this.txt_packages_package);
                  this.groupBox3.Controls.Add(this.btn_packages_uninstall);
                  this.groupBox3.Controls.Add(this.txt_packages_path);
                  this.groupBox3.Controls.Add(this.btn_packages_open);
                  this.groupBox3.Location = new System.Drawing.Point(6, 6);
                  this.groupBox3.Name = "groupBox3";
                  this.groupBox3.Size = new System.Drawing.Size(498, 99);
                  this.groupBox3.TabIndex = 6;
                  this.groupBox3.TabStop = false;
                  this.groupBox3.Text = "Install and Uninstall";
                  // 
                  // btn_packages_installed
                  // 
                  this.btn_packages_installed.Location = new System.Drawing.Point(336, 57);
                  this.btn_packages_installed.Name = "btn_packages_installed";
                  this.btn_packages_installed.Size = new System.Drawing.Size(75, 23);
                  this.btn_packages_installed.TabIndex = 4;
                  this.btn_packages_installed.Text = "Installed";
                  this.btn_packages_installed.UseVisualStyleBackColor = true;
                  this.btn_packages_installed.Click += new System.EventHandler(this.btn_packages_installed_Click);
                  // 
                  // btn_packages_install
                  // 
                  this.btn_packages_install.Location = new System.Drawing.Point(417, 20);
                  this.btn_packages_install.Name = "btn_packages_install";
                  this.btn_packages_install.Size = new System.Drawing.Size(75, 23);
                  this.btn_packages_install.TabIndex = 2;
                  this.btn_packages_install.Text = "Install";
                  this.btn_packages_install.UseVisualStyleBackColor = true;
                  this.btn_packages_install.Click += new System.EventHandler(this.btn_packages_install_Click_1);
                  // 
                  // txt_packages_package
                  // 
                  this.txt_packages_package.Location = new System.Drawing.Point(6, 59);
                  this.txt_packages_package.Name = "txt_packages_package";
                  this.txt_packages_package.Size = new System.Drawing.Size(324, 20);
                  this.txt_packages_package.TabIndex = 3;
                  // 
                  // btn_packages_uninstall
                  // 
                  this.btn_packages_uninstall.Location = new System.Drawing.Point(417, 57);
                  this.btn_packages_uninstall.Name = "btn_packages_uninstall";
                  this.btn_packages_uninstall.Size = new System.Drawing.Size(75, 23);
                  this.btn_packages_uninstall.TabIndex = 5;
                  this.btn_packages_uninstall.Text = "Uninstall";
                  this.btn_packages_uninstall.UseVisualStyleBackColor = true;
                  this.btn_packages_uninstall.Click += new System.EventHandler(this.btn_packages_uninstall_Click);
                  // 
                  // txt_packages_path
                  // 
                  this.txt_packages_path.Location = new System.Drawing.Point(6, 22);
                  this.txt_packages_path.Name = "txt_packages_path";
                  this.txt_packages_path.Size = new System.Drawing.Size(324, 20);
                  this.txt_packages_path.TabIndex = 0;
                  // 
                  // btn_packages_open
                  // 
                  this.btn_packages_open.Location = new System.Drawing.Point(336, 20);
                  this.btn_packages_open.Name = "btn_packages_open";
                  this.btn_packages_open.Size = new System.Drawing.Size(75, 23);
                  this.btn_packages_open.TabIndex = 1;
                  this.btn_packages_open.Text = "Open file";
                  this.btn_packages_open.UseVisualStyleBackColor = true;
                  this.btn_packages_open.Click += new System.EventHandler(this.btn_packages_open_Click);
                  // 
                  // tabPage5
                  // 
                  this.tabPage5.Controls.Add(this.label10);
                  this.tabPage5.Controls.Add(this.label9);
                  this.tabPage5.Controls.Add(this.btn_donate);
                  this.tabPage5.Controls.Add(this.button4);
                  this.tabPage5.Controls.Add(this.button3);
                  this.tabPage5.Controls.Add(this.label7);
                  this.tabPage5.Controls.Add(this.label6);
                  this.tabPage5.Location = new System.Drawing.Point(4, 22);
                  this.tabPage5.Name = "tabPage5";
                  this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
                  this.tabPage5.Size = new System.Drawing.Size(510, 280);
                  this.tabPage5.TabIndex = 4;
                  this.tabPage5.Text = "About";
                  this.tabPage5.UseVisualStyleBackColor = true;
                  // 
                  // label10
                  // 
                  this.label10.AutoSize = true;
                  this.label10.Location = new System.Drawing.Point(6, 158);
                  this.label10.Name = "label10";
                  this.label10.Size = new System.Drawing.Size(62, 13);
                  this.label10.TabIndex = 5;
                  this.label10.Text = "abdGUI 1.1";
                  // 
                  // label9
                  // 
                  this.label9.AutoSize = true;
                  this.label9.Location = new System.Drawing.Point(6, 184);
                  this.label9.Name = "label9";
                  this.label9.Size = new System.Drawing.Size(156, 78);
                  this.label9.TabIndex = 4;
                  this.label9.Text = "Thanks to:\r\nstackoverflow.com\r\nxda-developers.com\r\nPixel Buddah for programm icon" +
    "\r\nSaloni Sinha for the beer icon\r\nAndrea Soragna for viewer icon";
                  // 
                  // btn_donate
                  // 
                  this.btn_donate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.btn_donate.ForeColor = System.Drawing.Color.Black;
                  this.btn_donate.Image = ((System.Drawing.Image)(resources.GetObject("btn_donate.Image")));
                  this.btn_donate.Location = new System.Drawing.Point(348, 208);
                  this.btn_donate.Name = "btn_donate";
                  this.btn_donate.Size = new System.Drawing.Size(156, 66);
                  this.btn_donate.TabIndex = 0;
                  this.btn_donate.Text = "Buy me a beer";
                  this.btn_donate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                  this.btn_donate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                  this.btn_donate.UseVisualStyleBackColor = true;
                  this.btn_donate.Click += new System.EventHandler(this.btn_donate_Click);
                  // 
                  // button4
                  // 
                  this.button4.Location = new System.Drawing.Point(348, 179);
                  this.button4.Name = "button4";
                  this.button4.Size = new System.Drawing.Size(75, 23);
                  this.button4.TabIndex = 1;
                  this.button4.Text = "ADB Help";
                  this.button4.UseVisualStyleBackColor = true;
                  this.button4.Click += new System.EventHandler(this.button4_Click);
                  // 
                  // button3
                  // 
                  this.button3.Location = new System.Drawing.Point(429, 179);
                  this.button3.Name = "button3";
                  this.button3.Size = new System.Drawing.Size(75, 23);
                  this.button3.TabIndex = 2;
                  this.button3.Text = "About ADB";
                  this.button3.UseVisualStyleBackColor = true;
                  this.button3.Click += new System.EventHandler(this.button3_Click);
                  // 
                  // label7
                  // 
                  this.label7.AutoSize = true;
                  this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.label7.Location = new System.Drawing.Point(11, 118);
                  this.label7.Name = "label7";
                  this.label7.Size = new System.Drawing.Size(80, 12);
                  this.label7.TabIndex = 2;
                  this.label7.Text = "Thomas A. Edison";
                  // 
                  // label6
                  // 
                  this.label6.AutoSize = true;
                  this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
                  this.label6.Location = new System.Drawing.Point(7, 106);
                  this.label6.Name = "label6";
                  this.label6.Size = new System.Drawing.Size(265, 12);
                  this.label6.TabIndex = 0;
                  this.label6.Text = "“I have not failed. I\'ve just found 10,000 ways that won\'t work.”";
                  // 
                  // openFileDialog1
                  // 
                  this.openFileDialog1.FileName = "openFileDialog1";
                  // 
                  // MainForm
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(542, 329);
                  this.Controls.Add(this.tabControl1);
                  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                  this.MaximizeBox = false;
                  this.Name = "MainForm";
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                  this.Text = "adbGUI - Server is running";
                  this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
                  this.Load += new System.EventHandler(this.Form1_Load);
                  this.tabControl1.ResumeLayout(false);
                  this.tabPage1.ResumeLayout(false);
                  this.tabPage1.PerformLayout();
                  this.groupBox13.ResumeLayout(false);
                  this.groupBox13.PerformLayout();
                  this.groupBox11.ResumeLayout(false);
                  this.groupBox11.PerformLayout();
                  this.groupBox4.ResumeLayout(false);
                  this.groupBox4.PerformLayout();
                  this.groupBox1.ResumeLayout(false);
                  this.tabPage4.ResumeLayout(false);
                  this.groupBox12.ResumeLayout(false);
                  this.groupBox12.PerformLayout();
                  this.groupBox9.ResumeLayout(false);
                  this.groupBox9.PerformLayout();
                  this.groupBox6.ResumeLayout(false);
                  this.groupBox6.PerformLayout();
                  this.groupBox5.ResumeLayout(false);
                  this.tabPage2.ResumeLayout(false);
                  this.groupBox10.ResumeLayout(false);
                  this.groupBox10.PerformLayout();
                  this.groupBox7.ResumeLayout(false);
                  this.groupBox7.PerformLayout();
                  this.groupBox2.ResumeLayout(false);
                  this.groupBox2.PerformLayout();
                  this.tabPage3.ResumeLayout(false);
                  this.groupBox8.ResumeLayout(false);
                  this.groupBox8.PerformLayout();
                  this.groupBox3.ResumeLayout(false);
                  this.groupBox3.PerformLayout();
                  this.tabPage5.ResumeLayout(false);
                  this.tabPage5.PerformLayout();
                  this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.TabControl tabControl1;
            private System.Windows.Forms.TabPage tabPage1;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.ToolTip toolTip;
            private System.Windows.Forms.Button btnKillserver;
            private System.Windows.Forms.Button btn_reboot;
            private System.Windows.Forms.Button btn_remountsystem;
            private System.Windows.Forms.TabPage tabPage2;
            private System.Windows.Forms.Button btn_sideload_sideload;
            private System.Windows.Forms.GroupBox groupBox2;
            private System.Windows.Forms.TextBox txt_sideload_path;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.OpenFileDialog openFileDialog1;
            private System.Windows.Forms.TabPage tabPage3;
            private System.Windows.Forms.GroupBox groupBox3;
            private System.Windows.Forms.TabPage tabPage4;
            private System.Windows.Forms.GroupBox groupBox4;
            private System.Windows.Forms.Button btn_run;
            private System.Windows.Forms.TextBox txt_customcommand;
            private System.Windows.Forms.Button btn_openshell;
            private System.Windows.Forms.GroupBox groupBox5;
            private System.Windows.Forms.Button btn_phoneinformation_getprop;
            private System.Windows.Forms.Button btn_phoneinformation_installedpackages;
            private System.Windows.Forms.Button btn_phoneinformation_logcat;
            private System.Windows.Forms.TextBox txt_phoneinformation_mac;
            private System.Windows.Forms.Button btn_phoneinformation_spoofmac;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.Button btn_phoneinformation_showmac;
            private System.Windows.Forms.GroupBox groupBox6;
            private System.Windows.Forms.GroupBox groupBox7;
            private System.Windows.Forms.Button btn_push_push;
            private System.Windows.Forms.Button btn_push_openfile;
            private System.Windows.Forms.TextBox txt_push_tofilepath;
            private System.Windows.Forms.TextBox txt_push_fromfilepath;
            private System.Windows.Forms.Button btn_phoneinformation_dumpsys;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Button btn_phoneinformation_meminfo;
            private System.Windows.Forms.TabPage tabPage5;
            private System.Windows.Forms.Button btn_phoneinformation_processes;
            private System.Windows.Forms.Button button3;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.Label label7;
            private System.Windows.Forms.TextBox txt_packages_path;
            private System.Windows.Forms.Button btn_packages_open;
            private System.Windows.Forms.Button btn_packages_install;
            private System.Windows.Forms.TextBox txt_packages_package;
            private System.Windows.Forms.Button btn_packages_uninstall;
            private System.Windows.Forms.Button btn_packages_installed;
            private System.Windows.Forms.GroupBox groupBox10;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Button btn_pull_pull;
            private System.Windows.Forms.Button btn_pull_saveto;
            private System.Windows.Forms.TextBox txt_pull_pathfrom;
            private System.Windows.Forms.TextBox txt_pull_pathto;
            private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
            private System.Windows.Forms.Button button4;
            private System.Windows.Forms.Button btn_phoneinformation_features;
            private System.Windows.Forms.Button btn_phoneinformation_libraries;
            private System.Windows.Forms.Button btn_phoneinformation_users;
            private System.Windows.Forms.Button btn_phoneinformation_maxusers;
            private System.Windows.Forms.Button btn_phoneinformation_permissions;
            private System.Windows.Forms.Button btn_phoneinformation_getimei;
            private System.Windows.Forms.Button btn_phoneinformation_dmesg;
            private System.Windows.Forms.Button btn_phoneinformation_battery;
            private System.Windows.Forms.Button btn_phoneinformation_wifiinfo;
            private System.Windows.Forms.Button btn_phoneinformation_accounts;
            private System.Windows.Forms.Button btn_phoneinformation_cpuinfo;
            private System.Windows.Forms.GroupBox groupBox8;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Button btn_backup_backup;
            private System.Windows.Forms.TextBox txt_backup_path;
            private System.Windows.Forms.CheckBox cb_backup_withapk;
            private System.Windows.Forms.CheckBox cb_backup_shared;
            private System.Windows.Forms.CheckBox cb_backup_nosystem;
            private System.Windows.Forms.Button btn_backup_saveto;
            private System.Windows.Forms.Button btn_restore_restore;
            private System.Windows.Forms.Button btn_restore_openfile;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.TextBox txt_restore_path;
            private System.Windows.Forms.Label label8;
            private System.Windows.Forms.TextBox txt_backup_packagename;
            private System.Windows.Forms.CheckBox cb_backup_package;
            private System.Windows.Forms.Button btn_phoneinformation_diskstats;
            private System.Windows.Forms.Button btn_phoneinformation_netstat;
            private System.Windows.Forms.Button btn_phoneinformation_uptime;
            private System.Windows.Forms.Button btn_donate;
            private System.Windows.Forms.Label label9;
            private System.Windows.Forms.GroupBox groupBox9;
            private System.Windows.Forms.Button btn_phoneinformation_show;
            private System.Windows.Forms.Button btn_phoneinformation_changedpi;
            private System.Windows.Forms.TextBox txt_phoneinformation_dpi;
            private System.Windows.Forms.Button btn_phoneinformation_resetdpi;
            private System.Windows.Forms.GroupBox groupBox11;
            private System.Windows.Forms.TextBox txt_ip;
            private System.Windows.Forms.Button btn_connect;
            private System.Windows.Forms.GroupBox groupBox12;
            private System.Windows.Forms.Button btn_phoneinformation_setsize;
            private System.Windows.Forms.Button btn_phoneinformation_resetsize;
            private System.Windows.Forms.Button btn_phoneinformation_showsize;
            private System.Windows.Forms.TextBox txt_phoneinformation_resolution;
            private System.Windows.Forms.SaveFileDialog saveFileDialog1;
            private System.Windows.Forms.Button btn_phoninformation_hosts;
            private System.Windows.Forms.Button btn_phoneinformation_activities;
            private System.Windows.Forms.Button btn_phoneinformation_screenshot;
            private System.Windows.Forms.Label label10;
            private System.Windows.Forms.TextBox txt_serialno;
            private System.Windows.Forms.GroupBox groupBox13;
            private System.Windows.Forms.TextBox txt_devices;
            private System.Windows.Forms.Button btnAlarm;
      }
}

