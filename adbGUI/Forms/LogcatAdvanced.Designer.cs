namespace adbGUI.Forms
{
    partial class LogcatAdvanced
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_LogcatAdvancedAlternativeBuffersCrash = new System.Windows.Forms.CheckBox();
            this.cbo_LogcatAdvancedAlternativeBuffersEvents = new System.Windows.Forms.CheckBox();
            this.cbo_LogcatAdvancedAlternativeBuffersRadio = new System.Windows.Forms.CheckBox();
            this.cbo_LogcatAdvancedAlternativeBuffersSystem = new System.Windows.Forms.CheckBox();
            this.cbo_LogcatAdvancedAlternativeBuffersDefault = new System.Windows.Forms.CheckBox();
            this.cbo_LogcatAdvancedAlternativeBuffersAll = new System.Windows.Forms.CheckBox();
            this.cbo_LogcatAdvancedAlternativeBuffersMain = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbo_LogcatAdvancedBypassRegEx = new System.Windows.Forms.CheckBox();
            this.txt_LogcatAdvancedQuitAfterNumberLines = new System.Windows.Forms.TextBox();
            this.txt_LogcatAdvancedPidFilter = new System.Windows.Forms.TextBox();
            this.txt_LogcatAdvancedRecentNumberOfLines = new System.Windows.Forms.TextBox();
            this.txt_LogcatAdvancedSpecifiedTime = new System.Windows.Forms.TextBox();
            this.btn_LogcatAdvancedStart = new System.Windows.Forms.Button();
            this.btn_LogcatAdvancedClearBuffers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_LogcatAdvancedRegularExpressions = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_LogcatAdvancedStop = new System.Windows.Forms.Button();
            this.btn_LogcatAdvancedShowBufferSize = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_LogcatAdvancedSetBufferSize = new System.Windows.Forms.Button();
            this.txt_LogcatAdvancedBufferSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.opt_LogcatAdvancedOutputFormatThreadTime = new System.Windows.Forms.RadioButton();
            this.opt_LogcatAdvancedOutputFormatBrief = new System.Windows.Forms.RadioButton();
            this.opt_LogcatAdvancedOutputFormatProcess = new System.Windows.Forms.RadioButton();
            this.opt_LogcatAdvancedOutputFormatTag = new System.Windows.Forms.RadioButton();
            this.opt_LogcatAdvancedOutputFormatTime = new System.Windows.Forms.RadioButton();
            this.opt_LogcatAdvancedOutputFormatRaw = new System.Windows.Forms.RadioButton();
            this.opt_LogcatAdvancedOutputFormatLong = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_LogcatAdvancedAlternativeBuffersCrash);
            this.groupBox1.Controls.Add(this.cbo_LogcatAdvancedAlternativeBuffersEvents);
            this.groupBox1.Controls.Add(this.cbo_LogcatAdvancedAlternativeBuffersRadio);
            this.groupBox1.Controls.Add(this.cbo_LogcatAdvancedAlternativeBuffersSystem);
            this.groupBox1.Controls.Add(this.cbo_LogcatAdvancedAlternativeBuffersDefault);
            this.groupBox1.Controls.Add(this.cbo_LogcatAdvancedAlternativeBuffersAll);
            this.groupBox1.Controls.Add(this.cbo_LogcatAdvancedAlternativeBuffersMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternative Log Buffers";
            // 
            // cbo_LogcatAdvancedAlternativeBuffersCrash
            // 
            this.cbo_LogcatAdvancedAlternativeBuffersCrash.AutoSize = true;
            this.cbo_LogcatAdvancedAlternativeBuffersCrash.Location = new System.Drawing.Point(236, 19);
            this.cbo_LogcatAdvancedAlternativeBuffersCrash.Name = "cbo_LogcatAdvancedAlternativeBuffersCrash";
            this.cbo_LogcatAdvancedAlternativeBuffersCrash.Size = new System.Drawing.Size(53, 17);
            this.cbo_LogcatAdvancedAlternativeBuffersCrash.TabIndex = 6;
            this.cbo_LogcatAdvancedAlternativeBuffersCrash.Text = "Crash";
            this.toolTip.SetToolTip(this.cbo_LogcatAdvancedAlternativeBuffersCrash, "View the crash log buffer (default)");
            this.cbo_LogcatAdvancedAlternativeBuffersCrash.UseVisualStyleBackColor = true;
            // 
            // cbo_LogcatAdvancedAlternativeBuffersEvents
            // 
            this.cbo_LogcatAdvancedAlternativeBuffersEvents.AutoSize = true;
            this.cbo_LogcatAdvancedAlternativeBuffersEvents.Location = new System.Drawing.Point(355, 19);
            this.cbo_LogcatAdvancedAlternativeBuffersEvents.Name = "cbo_LogcatAdvancedAlternativeBuffersEvents";
            this.cbo_LogcatAdvancedAlternativeBuffersEvents.Size = new System.Drawing.Size(59, 17);
            this.cbo_LogcatAdvancedAlternativeBuffersEvents.TabIndex = 4;
            this.cbo_LogcatAdvancedAlternativeBuffersEvents.Text = "Events";
            this.toolTip.SetToolTip(this.cbo_LogcatAdvancedAlternativeBuffersEvents, "View the interpreted binary system event buffer messages");
            this.cbo_LogcatAdvancedAlternativeBuffersEvents.UseVisualStyleBackColor = true;
            // 
            // cbo_LogcatAdvancedAlternativeBuffersRadio
            // 
            this.cbo_LogcatAdvancedAlternativeBuffersRadio.AutoSize = true;
            this.cbo_LogcatAdvancedAlternativeBuffersRadio.Location = new System.Drawing.Point(295, 19);
            this.cbo_LogcatAdvancedAlternativeBuffersRadio.Name = "cbo_LogcatAdvancedAlternativeBuffersRadio";
            this.cbo_LogcatAdvancedAlternativeBuffersRadio.Size = new System.Drawing.Size(54, 17);
            this.cbo_LogcatAdvancedAlternativeBuffersRadio.TabIndex = 3;
            this.cbo_LogcatAdvancedAlternativeBuffersRadio.Text = "Radio";
            this.toolTip.SetToolTip(this.cbo_LogcatAdvancedAlternativeBuffersRadio, "View the buffer that contains radio/telephony related messages");
            this.cbo_LogcatAdvancedAlternativeBuffersRadio.UseVisualStyleBackColor = true;
            // 
            // cbo_LogcatAdvancedAlternativeBuffersSystem
            // 
            this.cbo_LogcatAdvancedAlternativeBuffersSystem.AutoSize = true;
            this.cbo_LogcatAdvancedAlternativeBuffersSystem.Location = new System.Drawing.Point(170, 19);
            this.cbo_LogcatAdvancedAlternativeBuffersSystem.Name = "cbo_LogcatAdvancedAlternativeBuffersSystem";
            this.cbo_LogcatAdvancedAlternativeBuffersSystem.Size = new System.Drawing.Size(60, 17);
            this.cbo_LogcatAdvancedAlternativeBuffersSystem.TabIndex = 5;
            this.cbo_LogcatAdvancedAlternativeBuffersSystem.Text = "System";
            this.toolTip.SetToolTip(this.cbo_LogcatAdvancedAlternativeBuffersSystem, "View the system log buffer (default");
            this.cbo_LogcatAdvancedAlternativeBuffersSystem.UseVisualStyleBackColor = true;
            // 
            // cbo_LogcatAdvancedAlternativeBuffersDefault
            // 
            this.cbo_LogcatAdvancedAlternativeBuffersDefault.AutoSize = true;
            this.cbo_LogcatAdvancedAlternativeBuffersDefault.Location = new System.Drawing.Point(49, 19);
            this.cbo_LogcatAdvancedAlternativeBuffersDefault.Name = "cbo_LogcatAdvancedAlternativeBuffersDefault";
            this.cbo_LogcatAdvancedAlternativeBuffersDefault.Size = new System.Drawing.Size(60, 17);
            this.cbo_LogcatAdvancedAlternativeBuffersDefault.TabIndex = 2;
            this.cbo_LogcatAdvancedAlternativeBuffersDefault.Text = "Default";
            this.toolTip.SetToolTip(this.cbo_LogcatAdvancedAlternativeBuffersDefault, "Reports main, system, and crash buffers");
            this.cbo_LogcatAdvancedAlternativeBuffersDefault.UseVisualStyleBackColor = true;
            this.cbo_LogcatAdvancedAlternativeBuffersDefault.CheckedChanged += new System.EventHandler(this.Cbo_LogcatAdvancedAlternativeBuffersDefault_CheckedChanged);
            // 
            // cbo_LogcatAdvancedAlternativeBuffersAll
            // 
            this.cbo_LogcatAdvancedAlternativeBuffersAll.AutoSize = true;
            this.cbo_LogcatAdvancedAlternativeBuffersAll.Location = new System.Drawing.Point(6, 19);
            this.cbo_LogcatAdvancedAlternativeBuffersAll.Name = "cbo_LogcatAdvancedAlternativeBuffersAll";
            this.cbo_LogcatAdvancedAlternativeBuffersAll.Size = new System.Drawing.Size(37, 17);
            this.cbo_LogcatAdvancedAlternativeBuffersAll.TabIndex = 1;
            this.cbo_LogcatAdvancedAlternativeBuffersAll.Text = "All";
            this.toolTip.SetToolTip(this.cbo_LogcatAdvancedAlternativeBuffersAll, "View all buffers");
            this.cbo_LogcatAdvancedAlternativeBuffersAll.UseVisualStyleBackColor = true;
            this.cbo_LogcatAdvancedAlternativeBuffersAll.CheckedChanged += new System.EventHandler(this.Cbo_LogcatAdvancedAlternativeBuffersAll_CheckedChanged);
            // 
            // cbo_LogcatAdvancedAlternativeBuffersMain
            // 
            this.cbo_LogcatAdvancedAlternativeBuffersMain.AutoSize = true;
            this.cbo_LogcatAdvancedAlternativeBuffersMain.Location = new System.Drawing.Point(115, 19);
            this.cbo_LogcatAdvancedAlternativeBuffersMain.Name = "cbo_LogcatAdvancedAlternativeBuffersMain";
            this.cbo_LogcatAdvancedAlternativeBuffersMain.Size = new System.Drawing.Size(49, 17);
            this.cbo_LogcatAdvancedAlternativeBuffersMain.TabIndex = 0;
            this.cbo_LogcatAdvancedAlternativeBuffersMain.Text = "Main";
            this.toolTip.SetToolTip(this.cbo_LogcatAdvancedAlternativeBuffersMain, "View the main log buffer (default) does not contain system and crash log messages" +
        "");
            this.cbo_LogcatAdvancedAlternativeBuffersMain.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.UseFading = false;
            // 
            // cbo_LogcatAdvancedBypassRegEx
            // 
            this.cbo_LogcatAdvancedBypassRegEx.AutoSize = true;
            this.cbo_LogcatAdvancedBypassRegEx.Location = new System.Drawing.Point(6, 45);
            this.cbo_LogcatAdvancedBypassRegEx.Name = "cbo_LogcatAdvancedBypassRegEx";
            this.cbo_LogcatAdvancedBypassRegEx.Size = new System.Drawing.Size(153, 17);
            this.cbo_LogcatAdvancedBypassRegEx.TabIndex = 2;
            this.cbo_LogcatAdvancedBypassRegEx.Text = "Bypass regular expressions";
            this.toolTip.SetToolTip(this.cbo_LogcatAdvancedBypassRegEx, "Paired with regular expressions and max number of lines to let content bypass the" +
        " regex filter, but still stop at the right number of matches.");
            this.cbo_LogcatAdvancedBypassRegEx.UseVisualStyleBackColor = true;
            // 
            // txt_LogcatAdvancedQuitAfterNumberLines
            // 
            this.txt_LogcatAdvancedQuitAfterNumberLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LogcatAdvancedQuitAfterNumberLines.Location = new System.Drawing.Point(6, 19);
            this.txt_LogcatAdvancedQuitAfterNumberLines.Name = "txt_LogcatAdvancedQuitAfterNumberLines";
            this.txt_LogcatAdvancedQuitAfterNumberLines.Size = new System.Drawing.Size(130, 20);
            this.txt_LogcatAdvancedQuitAfterNumberLines.TabIndex = 0;
            this.toolTip.SetToolTip(this.txt_LogcatAdvancedQuitAfterNumberLines, "Quit after printing <count> number of lines and exits");
            this.txt_LogcatAdvancedQuitAfterNumberLines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_LogcatAdvancedQuitAfterNumberLines_KeyDown);
            // 
            // txt_LogcatAdvancedPidFilter
            // 
            this.txt_LogcatAdvancedPidFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LogcatAdvancedPidFilter.Location = new System.Drawing.Point(6, 19);
            this.txt_LogcatAdvancedPidFilter.Name = "txt_LogcatAdvancedPidFilter";
            this.txt_LogcatAdvancedPidFilter.Size = new System.Drawing.Size(118, 20);
            this.txt_LogcatAdvancedPidFilter.TabIndex = 0;
            this.toolTip.SetToolTip(this.txt_LogcatAdvancedPidFilter, "Only print logs from the given PID");
            // 
            // txt_LogcatAdvancedRecentNumberOfLines
            // 
            this.txt_LogcatAdvancedRecentNumberOfLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LogcatAdvancedRecentNumberOfLines.Location = new System.Drawing.Point(6, 19);
            this.txt_LogcatAdvancedRecentNumberOfLines.Name = "txt_LogcatAdvancedRecentNumberOfLines";
            this.txt_LogcatAdvancedRecentNumberOfLines.Size = new System.Drawing.Size(130, 20);
            this.txt_LogcatAdvancedRecentNumberOfLines.TabIndex = 0;
            this.toolTip.SetToolTip(this.txt_LogcatAdvancedRecentNumberOfLines, "Print only the most recent number of lines and exits");
            this.txt_LogcatAdvancedRecentNumberOfLines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_LogcatAdvancedRecentNumberOfLines_KeyDown);
            // 
            // txt_LogcatAdvancedSpecifiedTime
            // 
            this.txt_LogcatAdvancedSpecifiedTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LogcatAdvancedSpecifiedTime.Location = new System.Drawing.Point(6, 19);
            this.txt_LogcatAdvancedSpecifiedTime.Name = "txt_LogcatAdvancedSpecifiedTime";
            this.txt_LogcatAdvancedSpecifiedTime.Size = new System.Drawing.Size(101, 20);
            this.txt_LogcatAdvancedSpecifiedTime.TabIndex = 0;
            this.toolTip.SetToolTip(this.txt_LogcatAdvancedSpecifiedTime, "Print the most recent lines since the specified time\r\nExample: 03-30 20:43:00.000" +
        "");
            // 
            // btn_LogcatAdvancedStart
            // 
            this.btn_LogcatAdvancedStart.Location = new System.Drawing.Point(282, 295);
            this.btn_LogcatAdvancedStart.Name = "btn_LogcatAdvancedStart";
            this.btn_LogcatAdvancedStart.Size = new System.Drawing.Size(75, 23);
            this.btn_LogcatAdvancedStart.TabIndex = 1;
            this.btn_LogcatAdvancedStart.Text = "Start";
            this.btn_LogcatAdvancedStart.UseVisualStyleBackColor = true;
            this.btn_LogcatAdvancedStart.Click += new System.EventHandler(this.Btn_LogcatAdvancedStart_Click);
            // 
            // btn_LogcatAdvancedClearBuffers
            // 
            this.btn_LogcatAdvancedClearBuffers.Location = new System.Drawing.Point(152, 295);
            this.btn_LogcatAdvancedClearBuffers.Name = "btn_LogcatAdvancedClearBuffers";
            this.btn_LogcatAdvancedClearBuffers.Size = new System.Drawing.Size(124, 23);
            this.btn_LogcatAdvancedClearBuffers.TabIndex = 2;
            this.btn_LogcatAdvancedClearBuffers.Text = "Clear selected buffers";
            this.btn_LogcatAdvancedClearBuffers.UseVisualStyleBackColor = true;
            this.btn_LogcatAdvancedClearBuffers.Click += new System.EventHandler(this.Btn_LogcatAdvancedClearBuffers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_LogcatAdvancedBypassRegEx);
            this.groupBox2.Controls.Add(this.txt_LogcatAdvancedRegularExpressions);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Regular Expressions";
            // 
            // txt_LogcatAdvancedRegularExpressions
            // 
            this.txt_LogcatAdvancedRegularExpressions.Location = new System.Drawing.Point(6, 19);
            this.txt_LogcatAdvancedRegularExpressions.Name = "txt_LogcatAdvancedRegularExpressions";
            this.txt_LogcatAdvancedRegularExpressions.Size = new System.Drawing.Size(414, 20);
            this.txt_LogcatAdvancedRegularExpressions.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(248, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.regular-expressions.info";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // btn_LogcatAdvancedStop
            // 
            this.btn_LogcatAdvancedStop.Location = new System.Drawing.Point(363, 295);
            this.btn_LogcatAdvancedStop.Name = "btn_LogcatAdvancedStop";
            this.btn_LogcatAdvancedStop.Size = new System.Drawing.Size(75, 23);
            this.btn_LogcatAdvancedStop.TabIndex = 4;
            this.btn_LogcatAdvancedStop.Text = "Stop";
            this.btn_LogcatAdvancedStop.UseVisualStyleBackColor = true;
            this.btn_LogcatAdvancedStop.Click += new System.EventHandler(this.Btn_LogcatAdvancedStop_Click);
            // 
            // btn_LogcatAdvancedShowBufferSize
            // 
            this.btn_LogcatAdvancedShowBufferSize.Location = new System.Drawing.Point(204, 18);
            this.btn_LogcatAdvancedShowBufferSize.Name = "btn_LogcatAdvancedShowBufferSize";
            this.btn_LogcatAdvancedShowBufferSize.Size = new System.Drawing.Size(97, 22);
            this.btn_LogcatAdvancedShowBufferSize.TabIndex = 1;
            this.btn_LogcatAdvancedShowBufferSize.Text = "Show Buffer Size";
            this.btn_LogcatAdvancedShowBufferSize.UseVisualStyleBackColor = true;
            this.btn_LogcatAdvancedShowBufferSize.Click += new System.EventHandler(this.Btn_LogcatAdvancedNewBufferSize_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_LogcatAdvancedPidFilter);
            this.groupBox4.Location = new System.Drawing.Point(308, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 47);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Print logs from PID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_LogcatAdvancedRecentNumberOfLines);
            this.groupBox5.Location = new System.Drawing.Point(160, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(142, 47);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Print recent <count> lines";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_LogcatAdvancedQuitAfterNumberLines);
            this.groupBox3.Location = new System.Drawing.Point(12, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 47);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Print <count> lines";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_LogcatAdvancedSpecifiedTime);
            this.groupBox6.Location = new System.Drawing.Point(12, 187);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(113, 47);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Specific time";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_LogcatAdvancedSetBufferSize);
            this.groupBox7.Controls.Add(this.txt_LogcatAdvancedBufferSize);
            this.groupBox7.Controls.Add(this.btn_LogcatAdvancedShowBufferSize);
            this.groupBox7.Location = new System.Drawing.Point(131, 187);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(307, 47);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ring Buffer";
            // 
            // btn_LogcatAdvancedSetBufferSize
            // 
            this.btn_LogcatAdvancedSetBufferSize.Location = new System.Drawing.Point(123, 18);
            this.btn_LogcatAdvancedSetBufferSize.Name = "btn_LogcatAdvancedSetBufferSize";
            this.btn_LogcatAdvancedSetBufferSize.Size = new System.Drawing.Size(75, 22);
            this.btn_LogcatAdvancedSetBufferSize.TabIndex = 3;
            this.btn_LogcatAdvancedSetBufferSize.Text = "Set";
            this.btn_LogcatAdvancedSetBufferSize.UseVisualStyleBackColor = true;
            this.btn_LogcatAdvancedSetBufferSize.Click += new System.EventHandler(this.Btn_LogcatAdvancedSetBufferSize_Click);
            // 
            // txt_LogcatAdvancedBufferSize
            // 
            this.txt_LogcatAdvancedBufferSize.Location = new System.Drawing.Point(6, 19);
            this.txt_LogcatAdvancedBufferSize.Name = "txt_LogcatAdvancedBufferSize";
            this.txt_LogcatAdvancedBufferSize.Size = new System.Drawing.Size(111, 20);
            this.txt_LogcatAdvancedBufferSize.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Some options will not work on some devices. All commands were successfully execut" +
    "ed on LineageOS.";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.opt_LogcatAdvancedOutputFormatBrief);
            this.groupBox8.Controls.Add(this.opt_LogcatAdvancedOutputFormatProcess);
            this.groupBox8.Controls.Add(this.opt_LogcatAdvancedOutputFormatTag);
            this.groupBox8.Controls.Add(this.opt_LogcatAdvancedOutputFormatRaw);
            this.groupBox8.Controls.Add(this.opt_LogcatAdvancedOutputFormatLong);
            this.groupBox8.Controls.Add(this.opt_LogcatAdvancedOutputFormatTime);
            this.groupBox8.Controls.Add(this.opt_LogcatAdvancedOutputFormatThreadTime);
            this.groupBox8.Location = new System.Drawing.Point(12, 240);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(426, 49);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Output Format";
            // 
            // opt_LogcatAdvancedOutputFormatThreadTime
            // 
            this.opt_LogcatAdvancedOutputFormatThreadTime.AutoSize = true;
            this.opt_LogcatAdvancedOutputFormatThreadTime.Checked = true;
            this.opt_LogcatAdvancedOutputFormatThreadTime.Location = new System.Drawing.Point(6, 19);
            this.opt_LogcatAdvancedOutputFormatThreadTime.Name = "opt_LogcatAdvancedOutputFormatThreadTime";
            this.opt_LogcatAdvancedOutputFormatThreadTime.Size = new System.Drawing.Size(78, 17);
            this.opt_LogcatAdvancedOutputFormatThreadTime.TabIndex = 13;
            this.opt_LogcatAdvancedOutputFormatThreadTime.TabStop = true;
            this.opt_LogcatAdvancedOutputFormatThreadTime.Text = "Threadtime";
            this.toolTip.SetToolTip(this.opt_LogcatAdvancedOutputFormatThreadTime, "(Default) Display the date, invocation time, priority, tag, and the PID and TID o" +
        "f the thread issuing the message");
            this.opt_LogcatAdvancedOutputFormatThreadTime.UseVisualStyleBackColor = true;
            // 
            // opt_LogcatAdvancedOutputFormatBrief
            // 
            this.opt_LogcatAdvancedOutputFormatBrief.AutoSize = true;
            this.opt_LogcatAdvancedOutputFormatBrief.Location = new System.Drawing.Point(371, 19);
            this.opt_LogcatAdvancedOutputFormatBrief.Name = "opt_LogcatAdvancedOutputFormatBrief";
            this.opt_LogcatAdvancedOutputFormatBrief.Size = new System.Drawing.Size(46, 17);
            this.opt_LogcatAdvancedOutputFormatBrief.TabIndex = 14;
            this.opt_LogcatAdvancedOutputFormatBrief.TabStop = true;
            this.opt_LogcatAdvancedOutputFormatBrief.Text = "Brief";
            this.toolTip.SetToolTip(this.opt_LogcatAdvancedOutputFormatBrief, "Display priority/tag and PID of the process issuing the message");
            this.opt_LogcatAdvancedOutputFormatBrief.UseVisualStyleBackColor = true;
            // 
            // opt_LogcatAdvancedOutputFormatProcess
            // 
            this.opt_LogcatAdvancedOutputFormatProcess.AutoSize = true;
            this.opt_LogcatAdvancedOutputFormatProcess.Location = new System.Drawing.Point(302, 19);
            this.opt_LogcatAdvancedOutputFormatProcess.Name = "opt_LogcatAdvancedOutputFormatProcess";
            this.opt_LogcatAdvancedOutputFormatProcess.Size = new System.Drawing.Size(63, 17);
            this.opt_LogcatAdvancedOutputFormatProcess.TabIndex = 15;
            this.opt_LogcatAdvancedOutputFormatProcess.TabStop = true;
            this.opt_LogcatAdvancedOutputFormatProcess.Text = "Process";
            this.toolTip.SetToolTip(this.opt_LogcatAdvancedOutputFormatProcess, "Display PID only.");
            this.opt_LogcatAdvancedOutputFormatProcess.UseVisualStyleBackColor = true;
            // 
            // opt_LogcatAdvancedOutputFormatTag
            // 
            this.opt_LogcatAdvancedOutputFormatTag.AutoSize = true;
            this.opt_LogcatAdvancedOutputFormatTag.Location = new System.Drawing.Point(252, 19);
            this.opt_LogcatAdvancedOutputFormatTag.Name = "opt_LogcatAdvancedOutputFormatTag";
            this.opt_LogcatAdvancedOutputFormatTag.Size = new System.Drawing.Size(44, 17);
            this.opt_LogcatAdvancedOutputFormatTag.TabIndex = 16;
            this.opt_LogcatAdvancedOutputFormatTag.TabStop = true;
            this.opt_LogcatAdvancedOutputFormatTag.Text = "Tag";
            this.toolTip.SetToolTip(this.opt_LogcatAdvancedOutputFormatTag, "Display the priority/tag only");
            this.opt_LogcatAdvancedOutputFormatTag.UseVisualStyleBackColor = true;
            // 
            // opt_LogcatAdvancedOutputFormatTime
            // 
            this.opt_LogcatAdvancedOutputFormatTime.AutoSize = true;
            this.opt_LogcatAdvancedOutputFormatTime.Location = new System.Drawing.Point(145, 19);
            this.opt_LogcatAdvancedOutputFormatTime.Name = "opt_LogcatAdvancedOutputFormatTime";
            this.opt_LogcatAdvancedOutputFormatTime.Size = new System.Drawing.Size(48, 17);
            this.opt_LogcatAdvancedOutputFormatTime.TabIndex = 17;
            this.opt_LogcatAdvancedOutputFormatTime.TabStop = true;
            this.opt_LogcatAdvancedOutputFormatTime.Text = "Time";
            this.toolTip.SetToolTip(this.opt_LogcatAdvancedOutputFormatTime, "Display the date, invocation time, priority/tag, and PID of the process issuing t" +
        "he message");
            this.opt_LogcatAdvancedOutputFormatTime.UseVisualStyleBackColor = true;
            // 
            // opt_LogcatAdvancedOutputFormatRaw
            // 
            this.opt_LogcatAdvancedOutputFormatRaw.AutoSize = true;
            this.opt_LogcatAdvancedOutputFormatRaw.Location = new System.Drawing.Point(199, 19);
            this.opt_LogcatAdvancedOutputFormatRaw.Name = "opt_LogcatAdvancedOutputFormatRaw";
            this.opt_LogcatAdvancedOutputFormatRaw.Size = new System.Drawing.Size(47, 17);
            this.opt_LogcatAdvancedOutputFormatRaw.TabIndex = 18;
            this.opt_LogcatAdvancedOutputFormatRaw.TabStop = true;
            this.opt_LogcatAdvancedOutputFormatRaw.Text = "Raw";
            this.toolTip.SetToolTip(this.opt_LogcatAdvancedOutputFormatRaw, "Display the raw log message, with no other metadata fields");
            this.opt_LogcatAdvancedOutputFormatRaw.UseVisualStyleBackColor = true;
            // 
            // opt_LogcatAdvancedOutputFormatLong
            // 
            this.opt_LogcatAdvancedOutputFormatLong.AutoSize = true;
            this.opt_LogcatAdvancedOutputFormatLong.Location = new System.Drawing.Point(90, 19);
            this.opt_LogcatAdvancedOutputFormatLong.Name = "opt_LogcatAdvancedOutputFormatLong";
            this.opt_LogcatAdvancedOutputFormatLong.Size = new System.Drawing.Size(49, 17);
            this.opt_LogcatAdvancedOutputFormatLong.TabIndex = 19;
            this.opt_LogcatAdvancedOutputFormatLong.TabStop = true;
            this.opt_LogcatAdvancedOutputFormatLong.Text = "Long";
            this.toolTip.SetToolTip(this.opt_LogcatAdvancedOutputFormatLong, "Display all metadata fields and separate messages with blank lines");
            this.opt_LogcatAdvancedOutputFormatLong.UseVisualStyleBackColor = true;
            // 
            // LogcatAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 357);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_LogcatAdvancedStop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_LogcatAdvancedClearBuffers);
            this.Controls.Add(this.btn_LogcatAdvancedStart);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LogcatAdvanced";
            this.ShowInTaskbar = false;
            this.Text = "LogcatAdvanced";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbo_LogcatAdvancedAlternativeBuffersRadio;
        private System.Windows.Forms.CheckBox cbo_LogcatAdvancedAlternativeBuffersDefault;
        private System.Windows.Forms.CheckBox cbo_LogcatAdvancedAlternativeBuffersAll;
        private System.Windows.Forms.CheckBox cbo_LogcatAdvancedAlternativeBuffersMain;
        private System.Windows.Forms.CheckBox cbo_LogcatAdvancedAlternativeBuffersCrash;
        private System.Windows.Forms.CheckBox cbo_LogcatAdvancedAlternativeBuffersSystem;
        private System.Windows.Forms.CheckBox cbo_LogcatAdvancedAlternativeBuffersEvents;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_LogcatAdvancedStart;
        private System.Windows.Forms.Button btn_LogcatAdvancedClearBuffers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_LogcatAdvancedRegularExpressions;
        private System.Windows.Forms.Button btn_LogcatAdvancedStop;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox cbo_LogcatAdvancedBypassRegEx;
        private System.Windows.Forms.TextBox txt_LogcatAdvancedQuitAfterNumberLines;
        private System.Windows.Forms.Button btn_LogcatAdvancedShowBufferSize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_LogcatAdvancedPidFilter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_LogcatAdvancedRecentNumberOfLines;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_LogcatAdvancedSpecifiedTime;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_LogcatAdvancedSetBufferSize;
        private System.Windows.Forms.TextBox txt_LogcatAdvancedBufferSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton opt_LogcatAdvancedOutputFormatThreadTime;
        private System.Windows.Forms.RadioButton opt_LogcatAdvancedOutputFormatBrief;
        private System.Windows.Forms.RadioButton opt_LogcatAdvancedOutputFormatProcess;
        private System.Windows.Forms.RadioButton opt_LogcatAdvancedOutputFormatTag;
        private System.Windows.Forms.RadioButton opt_LogcatAdvancedOutputFormatTime;
        private System.Windows.Forms.RadioButton opt_LogcatAdvancedOutputFormatRaw;
        private System.Windows.Forms.RadioButton opt_LogcatAdvancedOutputFormatLong;
    }
}