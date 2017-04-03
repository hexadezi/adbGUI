namespace adbGUI.Forms
{
    partial class BackupRestore
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbx_BackupPackage = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_BackupPackage = new System.Windows.Forms.CheckBox();
            this.btn_BackupBrowse = new System.Windows.Forms.Button();
            this.cbo_BackupNoSystem = new System.Windows.Forms.CheckBox();
            this.cbo_BackupShared = new System.Windows.Forms.CheckBox();
            this.cbo_BackupWithApk = new System.Windows.Forms.CheckBox();
            this.btn_BackupStart = new System.Windows.Forms.Button();
            this.txt_BackupPathTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txt_RestorePath = new System.Windows.Forms.TextBox();
            this.btn_RestoreBrowse = new System.Windows.Forms.Button();
            this.btn_RestoreStart = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox8.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbx_BackupPackage);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.cbo_BackupPackage);
            this.groupBox8.Controls.Add(this.btn_BackupBrowse);
            this.groupBox8.Controls.Add(this.cbo_BackupNoSystem);
            this.groupBox8.Controls.Add(this.cbo_BackupShared);
            this.groupBox8.Controls.Add(this.cbo_BackupWithApk);
            this.groupBox8.Controls.Add(this.btn_BackupStart);
            this.groupBox8.Controls.Add(this.txt_BackupPathTo);
            this.groupBox8.Location = new System.Drawing.Point(12, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(493, 95);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Backup";
            // 
            // cbx_BackupPackage
            // 
            this.cbx_BackupPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_BackupPackage.FormattingEnabled = true;
            this.cbx_BackupPackage.Location = new System.Drawing.Point(177, 49);
            this.cbx_BackupPackage.Name = "cbx_BackupPackage";
            this.cbx_BackupPackage.Size = new System.Drawing.Size(229, 21);
            this.cbx_BackupPackage.TabIndex = 15;
            this.cbx_BackupPackage.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Package";
            this.label8.Visible = false;
            // 
            // cbo_BackupPackage
            // 
            this.cbo_BackupPackage.AutoSize = true;
            this.cbo_BackupPackage.Location = new System.Drawing.Point(6, 52);
            this.cbo_BackupPackage.Name = "cbo_BackupPackage";
            this.cbo_BackupPackage.Size = new System.Drawing.Size(109, 17);
            this.cbo_BackupPackage.TabIndex = 10;
            this.cbo_BackupPackage.Text = "Backup Package";
            this.cbo_BackupPackage.UseVisualStyleBackColor = true;
            this.cbo_BackupPackage.CheckedChanged += new System.EventHandler(this.Cbo_BackupPackage_CheckedChanged);
            // 
            // btn_BackupBrowse
            // 
            this.btn_BackupBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BackupBrowse.Location = new System.Drawing.Point(412, 19);
            this.btn_BackupBrowse.Name = "btn_BackupBrowse";
            this.btn_BackupBrowse.Size = new System.Drawing.Size(75, 23);
            this.btn_BackupBrowse.TabIndex = 8;
            this.btn_BackupBrowse.Text = "Save to";
            this.btn_BackupBrowse.UseVisualStyleBackColor = true;
            this.btn_BackupBrowse.Click += new System.EventHandler(this.Btn_BackupBrowse_Click);
            // 
            // cbo_BackupNoSystem
            // 
            this.cbo_BackupNoSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_BackupNoSystem.AutoSize = true;
            this.cbo_BackupNoSystem.Location = new System.Drawing.Point(150, 75);
            this.cbo_BackupNoSystem.Name = "cbo_BackupNoSystem";
            this.cbo_BackupNoSystem.Size = new System.Drawing.Size(77, 17);
            this.cbo_BackupNoSystem.TabIndex = 13;
            this.cbo_BackupNoSystem.Text = "No System";
            this.cbo_BackupNoSystem.UseVisualStyleBackColor = true;
            // 
            // cbo_BackupShared
            // 
            this.cbo_BackupShared.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_BackupShared.AutoSize = true;
            this.cbo_BackupShared.Location = new System.Drawing.Point(84, 75);
            this.cbo_BackupShared.Name = "cbo_BackupShared";
            this.cbo_BackupShared.Size = new System.Drawing.Size(60, 17);
            this.cbo_BackupShared.TabIndex = 12;
            this.cbo_BackupShared.Text = "Shared";
            this.cbo_BackupShared.UseVisualStyleBackColor = true;
            // 
            // cbo_BackupWithApk
            // 
            this.cbo_BackupWithApk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_BackupWithApk.AutoSize = true;
            this.cbo_BackupWithApk.Location = new System.Drawing.Point(6, 75);
            this.cbo_BackupWithApk.Name = "cbo_BackupWithApk";
            this.cbo_BackupWithApk.Size = new System.Drawing.Size(72, 17);
            this.cbo_BackupWithApk.TabIndex = 11;
            this.cbo_BackupWithApk.Text = "With APK";
            this.cbo_BackupWithApk.UseVisualStyleBackColor = true;
            // 
            // btn_BackupStart
            // 
            this.btn_BackupStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BackupStart.Location = new System.Drawing.Point(412, 48);
            this.btn_BackupStart.Name = "btn_BackupStart";
            this.btn_BackupStart.Size = new System.Drawing.Size(75, 23);
            this.btn_BackupStart.TabIndex = 9;
            this.btn_BackupStart.Text = "Backup";
            this.btn_BackupStart.UseVisualStyleBackColor = true;
            this.btn_BackupStart.Click += new System.EventHandler(this.Btn_BackupStart_Click);
            // 
            // txt_BackupPathTo
            // 
            this.txt_BackupPathTo.Location = new System.Drawing.Point(6, 21);
            this.txt_BackupPathTo.Name = "txt_BackupPathTo";
            this.txt_BackupPathTo.Size = new System.Drawing.Size(400, 20);
            this.txt_BackupPathTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(64, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Attention! Backup and restore seems broken in adb 1.0.39";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txt_RestorePath);
            this.groupBox14.Controls.Add(this.btn_RestoreBrowse);
            this.groupBox14.Controls.Add(this.btn_RestoreStart);
            this.groupBox14.Location = new System.Drawing.Point(12, 113);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(493, 55);
            this.groupBox14.TabIndex = 16;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Restore";
            // 
            // txt_RestorePath
            // 
            this.txt_RestorePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RestorePath.Location = new System.Drawing.Point(6, 22);
            this.txt_RestorePath.Name = "txt_RestorePath";
            this.txt_RestorePath.Size = new System.Drawing.Size(319, 20);
            this.txt_RestorePath.TabIndex = 14;
            // 
            // btn_RestoreBrowse
            // 
            this.btn_RestoreBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RestoreBrowse.Location = new System.Drawing.Point(331, 20);
            this.btn_RestoreBrowse.Name = "btn_RestoreBrowse";
            this.btn_RestoreBrowse.Size = new System.Drawing.Size(75, 23);
            this.btn_RestoreBrowse.TabIndex = 15;
            this.btn_RestoreBrowse.Text = "Open file";
            this.btn_RestoreBrowse.UseVisualStyleBackColor = true;
            this.btn_RestoreBrowse.Click += new System.EventHandler(this.Btn_RestoreBrowse_Click);
            // 
            // btn_RestoreStart
            // 
            this.btn_RestoreStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RestoreStart.Location = new System.Drawing.Point(412, 19);
            this.btn_RestoreStart.Name = "btn_RestoreStart";
            this.btn_RestoreStart.Size = new System.Drawing.Size(75, 23);
            this.btn_RestoreStart.TabIndex = 16;
            this.btn_RestoreStart.Text = "Restore";
            this.btn_RestoreStart.UseVisualStyleBackColor = true;
            this.btn_RestoreStart.Click += new System.EventHandler(this.Btn_RestoreStart_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 193);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BackupRestore";
            this.ShowIcon = false;
            this.Text = "BackupRestore";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbo_BackupPackage;
        private System.Windows.Forms.Button btn_BackupBrowse;
        private System.Windows.Forms.CheckBox cbo_BackupNoSystem;
        private System.Windows.Forms.CheckBox cbo_BackupShared;
        private System.Windows.Forms.CheckBox cbo_BackupWithApk;
        private System.Windows.Forms.Button btn_BackupStart;
        private System.Windows.Forms.TextBox txt_BackupPathTo;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox txt_RestorePath;
        private System.Windows.Forms.Button btn_RestoreBrowse;
        private System.Windows.Forms.Button btn_RestoreStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox cbx_BackupPackage;
    }
}