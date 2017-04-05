namespace adbGUI.Forms
{
    partial class ScreenRecord
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
            this.txt_screenRecordResolution = new System.Windows.Forms.TextBox();
            this.txt_ScreenRecordBitrate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trb_screenRecordTimeLimit = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_screenRecordSeconds = new System.Windows.Forms.Label();
            this.btn_screenRecordStart = new System.Windows.Forms.Button();
            this.cbo_ScreenRecordRotate = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_ScreenRecordCustomResolution = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btn_SreenRecordAbort = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trb_screenRecordTimeLimit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_screenRecordResolution
            // 
            this.txt_screenRecordResolution.Enabled = false;
            this.txt_screenRecordResolution.Location = new System.Drawing.Point(6, 42);
            this.txt_screenRecordResolution.Name = "txt_screenRecordResolution";
            this.txt_screenRecordResolution.Size = new System.Drawing.Size(69, 20);
            this.txt_screenRecordResolution.TabIndex = 0;
            this.txt_screenRecordResolution.Text = "1920x1080";
            // 
            // txt_ScreenRecordBitrate
            // 
            this.txt_ScreenRecordBitrate.Location = new System.Drawing.Point(6, 42);
            this.txt_ScreenRecordBitrate.Name = "txt_ScreenRecordBitrate";
            this.txt_ScreenRecordBitrate.Size = new System.Drawing.Size(69, 20);
            this.txt_ScreenRecordBitrate.TabIndex = 1;
            this.txt_ScreenRecordBitrate.Text = "4000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitrate in bytes";
            // 
            // trb_screenRecordTimeLimit
            // 
            this.trb_screenRecordTimeLimit.Location = new System.Drawing.Point(6, 32);
            this.trb_screenRecordTimeLimit.Maximum = 180;
            this.trb_screenRecordTimeLimit.Minimum = 5;
            this.trb_screenRecordTimeLimit.Name = "trb_screenRecordTimeLimit";
            this.trb_screenRecordTimeLimit.Size = new System.Drawing.Size(194, 45);
            this.trb_screenRecordTimeLimit.TabIndex = 4;
            this.trb_screenRecordTimeLimit.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trb_screenRecordTimeLimit.Value = 180;
            this.trb_screenRecordTimeLimit.Scroll += new System.EventHandler(this.Trb_screenRecord_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds: ";
            // 
            // lbl_screenRecordSeconds
            // 
            this.lbl_screenRecordSeconds.AutoSize = true;
            this.lbl_screenRecordSeconds.Location = new System.Drawing.Point(67, 16);
            this.lbl_screenRecordSeconds.Name = "lbl_screenRecordSeconds";
            this.lbl_screenRecordSeconds.Size = new System.Drawing.Size(25, 13);
            this.lbl_screenRecordSeconds.TabIndex = 6;
            this.lbl_screenRecordSeconds.Text = "180";
            // 
            // btn_screenRecordStart
            // 
            this.btn_screenRecordStart.Location = new System.Drawing.Point(12, 230);
            this.btn_screenRecordStart.Name = "btn_screenRecordStart";
            this.btn_screenRecordStart.Size = new System.Drawing.Size(100, 23);
            this.btn_screenRecordStart.TabIndex = 7;
            this.btn_screenRecordStart.Text = "Start";
            this.btn_screenRecordStart.UseVisualStyleBackColor = true;
            this.btn_screenRecordStart.Click += new System.EventHandler(this.Btn_screenRecordStart_Click);
            // 
            // cbo_ScreenRecordRotate
            // 
            this.cbo_ScreenRecordRotate.AutoSize = true;
            this.cbo_ScreenRecordRotate.Location = new System.Drawing.Point(9, 19);
            this.cbo_ScreenRecordRotate.Name = "cbo_ScreenRecordRotate";
            this.cbo_ScreenRecordRotate.Size = new System.Drawing.Size(147, 17);
            this.cbo_ScreenRecordRotate.TabIndex = 12;
            this.cbo_ScreenRecordRotate.Text = "Rotate output 90 degrees";
            this.cbo_ScreenRecordRotate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_ScreenRecordCustomResolution);
            this.groupBox1.Controls.Add(this.txt_screenRecordResolution);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resolution";
            // 
            // cbo_ScreenRecordCustomResolution
            // 
            this.cbo_ScreenRecordCustomResolution.AutoSize = true;
            this.cbo_ScreenRecordCustomResolution.Location = new System.Drawing.Point(6, 19);
            this.cbo_ScreenRecordCustomResolution.Name = "cbo_ScreenRecordCustomResolution";
            this.cbo_ScreenRecordCustomResolution.Size = new System.Drawing.Size(61, 17);
            this.cbo_ScreenRecordCustomResolution.TabIndex = 1;
            this.cbo_ScreenRecordCustomResolution.Text = "Custom";
            this.cbo_ScreenRecordCustomResolution.UseVisualStyleBackColor = true;
            this.cbo_ScreenRecordCustomResolution.CheckedChanged += new System.EventHandler(this.Cbo_ScreenRecordCustomResolution_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ScreenRecordBitrate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(118, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 70);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bitrate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbl_screenRecordSeconds);
            this.groupBox3.Controls.Add(this.trb_screenRecordTimeLimit);
            this.groupBox3.Location = new System.Drawing.Point(12, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 85);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Limit";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbo_ScreenRecordRotate);
            this.groupBox5.Location = new System.Drawing.Point(12, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 46);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rotate";
            // 
            // btn_SreenRecordAbort
            // 
            this.btn_SreenRecordAbort.Location = new System.Drawing.Point(118, 230);
            this.btn_SreenRecordAbort.Name = "btn_SreenRecordAbort";
            this.btn_SreenRecordAbort.Size = new System.Drawing.Size(100, 23);
            this.btn_SreenRecordAbort.TabIndex = 18;
            this.btn_SreenRecordAbort.Text = "Abort";
            this.btn_SreenRecordAbort.UseVisualStyleBackColor = true;
            this.btn_SreenRecordAbort.Click += new System.EventHandler(this.Btn_SreenRecordAbort_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ScreenRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 265);
            this.Controls.Add(this.btn_SreenRecordAbort);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_screenRecordStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ScreenRecord";
            this.Text = "ScreenRecord";
            ((System.ComponentModel.ISupportInitialize)(this.trb_screenRecordTimeLimit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_screenRecordResolution;
        private System.Windows.Forms.TextBox txt_ScreenRecordBitrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trb_screenRecordTimeLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_screenRecordSeconds;
        private System.Windows.Forms.Button btn_screenRecordStart;
        private System.Windows.Forms.CheckBox cbo_ScreenRecordRotate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbo_ScreenRecordCustomResolution;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btn_SreenRecordAbort;
        private System.Windows.Forms.Timer timer;
    }
}