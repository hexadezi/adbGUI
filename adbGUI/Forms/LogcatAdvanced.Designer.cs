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
            this.btn_LogcatAdvancedStart = new System.Windows.Forms.Button();
            this.btn_LogcatAdvancedClearBuffers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LogcatAdvancedRegularExpressions = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_LogcatAdvancedStop = new System.Windows.Forms.Button();
            this.btn_LogcatAdvancedNewBufferSize = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_LogcatAdvancedPidFilter = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_LogcatAdvancedRecentNumberOfLines = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.cbo_LogcatAdvancedBypassRegEx.Location = new System.Drawing.Point(267, 47);
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
            this.toolTip.SetToolTip(this.txt_LogcatAdvancedQuitAfterNumberLines, "Quit after printing <count> number of lines. This is meant to be paired with regu" +
        "lar expressions, but will work on its own.");
            this.txt_LogcatAdvancedQuitAfterNumberLines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_LogcatAdvancedQuitAfterNumberLines_KeyDown);
            // 
            // btn_LogcatAdvancedStart
            // 
            this.btn_LogcatAdvancedStart.Location = new System.Drawing.Point(282, 284);
            this.btn_LogcatAdvancedStart.Name = "btn_LogcatAdvancedStart";
            this.btn_LogcatAdvancedStart.Size = new System.Drawing.Size(75, 23);
            this.btn_LogcatAdvancedStart.TabIndex = 1;
            this.btn_LogcatAdvancedStart.Text = "Start";
            this.btn_LogcatAdvancedStart.UseVisualStyleBackColor = true;
            this.btn_LogcatAdvancedStart.Click += new System.EventHandler(this.Btn_LogcatAdvancedStart_Click);
            // 
            // btn_LogcatAdvancedClearBuffers
            // 
            this.btn_LogcatAdvancedClearBuffers.Location = new System.Drawing.Point(152, 284);
            this.btn_LogcatAdvancedClearBuffers.Name = "btn_LogcatAdvancedClearBuffers";
            this.btn_LogcatAdvancedClearBuffers.Size = new System.Drawing.Size(124, 23);
            this.btn_LogcatAdvancedClearBuffers.TabIndex = 2;
            this.btn_LogcatAdvancedClearBuffers.Text = "Clear selected buffers";
            this.btn_LogcatAdvancedClearBuffers.UseVisualStyleBackColor = true;
            this.btn_LogcatAdvancedClearBuffers.Click += new System.EventHandler(this.Btn_LogcatAdvancedClearBuffers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbo_LogcatAdvancedBypassRegEx);
            this.groupBox2.Controls.Add(this.txt_LogcatAdvancedRegularExpressions);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Regular Expressions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quit after printing <count> number of lines";
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
            this.linkLabel1.Location = new System.Drawing.Point(4, 68);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.regular-expressions.info";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // btn_LogcatAdvancedStop
            // 
            this.btn_LogcatAdvancedStop.Location = new System.Drawing.Point(363, 284);
            this.btn_LogcatAdvancedStop.Name = "btn_LogcatAdvancedStop";
            this.btn_LogcatAdvancedStop.Size = new System.Drawing.Size(75, 23);
            this.btn_LogcatAdvancedStop.TabIndex = 4;
            this.btn_LogcatAdvancedStop.Text = "Stop";
            this.btn_LogcatAdvancedStop.UseVisualStyleBackColor = true;
            this.btn_LogcatAdvancedStop.Click += new System.EventHandler(this.Btn_LogcatAdvancedStop_Click);
            // 
            // btn_LogcatAdvancedNewBufferSize
            // 
            this.btn_LogcatAdvancedNewBufferSize.Location = new System.Drawing.Point(49, 284);
            this.btn_LogcatAdvancedNewBufferSize.Name = "btn_LogcatAdvancedNewBufferSize";
            this.btn_LogcatAdvancedNewBufferSize.Size = new System.Drawing.Size(97, 23);
            this.btn_LogcatAdvancedNewBufferSize.TabIndex = 1;
            this.btn_LogcatAdvancedNewBufferSize.Text = "Show Buffer Size";
            this.btn_LogcatAdvancedNewBufferSize.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_LogcatAdvancedPidFilter);
            this.groupBox4.Location = new System.Drawing.Point(308, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 45);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Print logs from PID";
            // 
            // txt_LogcatAdvancedPidFilter
            // 
            this.txt_LogcatAdvancedPidFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LogcatAdvancedPidFilter.Location = new System.Drawing.Point(6, 19);
            this.txt_LogcatAdvancedPidFilter.Name = "txt_LogcatAdvancedPidFilter";
            this.txt_LogcatAdvancedPidFilter.Size = new System.Drawing.Size(118, 20);
            this.txt_LogcatAdvancedPidFilter.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_LogcatAdvancedRecentNumberOfLines);
            this.groupBox5.Location = new System.Drawing.Point(160, 155);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(142, 45);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Print recent <count> lines";
            // 
            // txt_LogcatAdvancedRecentNumberOfLines
            // 
            this.txt_LogcatAdvancedRecentNumberOfLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LogcatAdvancedRecentNumberOfLines.Location = new System.Drawing.Point(6, 19);
            this.txt_LogcatAdvancedRecentNumberOfLines.Name = "txt_LogcatAdvancedRecentNumberOfLines";
            this.txt_LogcatAdvancedRecentNumberOfLines.Size = new System.Drawing.Size(130, 20);
            this.txt_LogcatAdvancedRecentNumberOfLines.TabIndex = 0;
            this.txt_LogcatAdvancedRecentNumberOfLines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_LogcatAdvancedRecentNumberOfLines_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_LogcatAdvancedQuitAfterNumberLines);
            this.groupBox3.Location = new System.Drawing.Point(12, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 45);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Print <count> lines";
            // 
            // LogcatAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 319);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_LogcatAdvancedNewBufferSize);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_LogcatAdvancedNewBufferSize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_LogcatAdvancedPidFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_LogcatAdvancedRecentNumberOfLines;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}