namespace adbGUI.Forms
{
    partial class FileOps
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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_FileOpsPullList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_FileOpsPullPull = new System.Windows.Forms.Button();
            this.btn_FileOpsPullBrowse = new System.Windows.Forms.Button();
            this.txt_FileOpsPullFrom = new System.Windows.Forms.TextBox();
            this.txt_FileOpsPullTo = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_FileOpsPushList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_FileOpsPushPush = new System.Windows.Forms.Button();
            this.btn_FileOpsPushBrowse = new System.Windows.Forms.Button();
            this.txt_FileOpsPushTo = new System.Windows.Forms.TextBox();
            this.txt_FileOpsPushFrom = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.btn_FileOpsPullList);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.btn_FileOpsPullPull);
            this.groupBox10.Controls.Add(this.btn_FileOpsPullBrowse);
            this.groupBox10.Controls.Add(this.txt_FileOpsPullFrom);
            this.groupBox10.Controls.Add(this.txt_FileOpsPullTo);
            this.groupBox10.Location = new System.Drawing.Point(16, 133);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox10.Size = new System.Drawing.Size(657, 112);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Pull Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "From";
            // 
            // btn_FileOpsPullList
            // 
            this.btn_FileOpsPullList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FileOpsPullList.Location = new System.Drawing.Point(553, 78);
            this.btn_FileOpsPullList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_FileOpsPullList.Name = "btn_FileOpsPullList";
            this.btn_FileOpsPullList.Size = new System.Drawing.Size(96, 27);
            this.btn_FileOpsPullList.TabIndex = 8;
            this.btn_FileOpsPullList.Text = "List";
            this.btn_FileOpsPullList.UseVisualStyleBackColor = true;
            this.btn_FileOpsPullList.Click += new System.EventHandler(this.Btn_FileOpsPullList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // btn_FileOpsPullPull
            // 
            this.btn_FileOpsPullPull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FileOpsPullPull.Location = new System.Drawing.Point(445, 78);
            this.btn_FileOpsPullPull.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_FileOpsPullPull.Name = "btn_FileOpsPullPull";
            this.btn_FileOpsPullPull.Size = new System.Drawing.Size(100, 27);
            this.btn_FileOpsPullPull.TabIndex = 10;
            this.btn_FileOpsPullPull.Text = "Pull";
            this.btn_FileOpsPullPull.UseVisualStyleBackColor = true;
            this.btn_FileOpsPullPull.Click += new System.EventHandler(this.Btn_FileOpsPullPull_Click);
            // 
            // btn_FileOpsPullBrowse
            // 
            this.btn_FileOpsPullBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FileOpsPullBrowse.Location = new System.Drawing.Point(445, 35);
            this.btn_FileOpsPullBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_FileOpsPullBrowse.Name = "btn_FileOpsPullBrowse";
            this.btn_FileOpsPullBrowse.Size = new System.Drawing.Size(204, 27);
            this.btn_FileOpsPullBrowse.TabIndex = 8;
            this.btn_FileOpsPullBrowse.Text = "Browse...";
            this.btn_FileOpsPullBrowse.UseVisualStyleBackColor = true;
            this.btn_FileOpsPullBrowse.Click += new System.EventHandler(this.Btn_FileOpsPullBrowse_Click);
            // 
            // txt_FileOpsPullFrom
            // 
            this.txt_FileOpsPullFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileOpsPullFrom.Location = new System.Drawing.Point(8, 81);
            this.txt_FileOpsPullFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_FileOpsPullFrom.Name = "txt_FileOpsPullFrom";
            this.txt_FileOpsPullFrom.Size = new System.Drawing.Size(428, 25);
            this.txt_FileOpsPullFrom.TabIndex = 9;
            this.txt_FileOpsPullFrom.Text = "/sdcard/";
            // 
            // txt_FileOpsPullTo
            // 
            this.txt_FileOpsPullTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileOpsPullTo.Location = new System.Drawing.Point(8, 37);
            this.txt_FileOpsPullTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_FileOpsPullTo.Name = "txt_FileOpsPullTo";
            this.txt_FileOpsPullTo.Size = new System.Drawing.Size(428, 25);
            this.txt_FileOpsPullTo.TabIndex = 7;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.btn_FileOpsPushList);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.btn_FileOpsPushPush);
            this.groupBox7.Controls.Add(this.btn_FileOpsPushBrowse);
            this.groupBox7.Controls.Add(this.txt_FileOpsPushTo);
            this.groupBox7.Controls.Add(this.txt_FileOpsPushFrom);
            this.groupBox7.Location = new System.Drawing.Point(16, 14);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(657, 112);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Push Files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "From";
            // 
            // btn_FileOpsPushList
            // 
            this.btn_FileOpsPushList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FileOpsPushList.Location = new System.Drawing.Point(555, 77);
            this.btn_FileOpsPushList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_FileOpsPushList.Name = "btn_FileOpsPushList";
            this.btn_FileOpsPushList.Size = new System.Drawing.Size(96, 27);
            this.btn_FileOpsPushList.TabIndex = 7;
            this.btn_FileOpsPushList.Text = "List";
            this.btn_FileOpsPushList.UseVisualStyleBackColor = true;
            this.btn_FileOpsPushList.Click += new System.EventHandler(this.Btn_FileOpsPushList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "To";
            // 
            // btn_FileOpsPushPush
            // 
            this.btn_FileOpsPushPush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FileOpsPushPush.Location = new System.Drawing.Point(447, 78);
            this.btn_FileOpsPushPush.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_FileOpsPushPush.Name = "btn_FileOpsPushPush";
            this.btn_FileOpsPushPush.Size = new System.Drawing.Size(100, 27);
            this.btn_FileOpsPushPush.TabIndex = 6;
            this.btn_FileOpsPushPush.Text = "Push";
            this.btn_FileOpsPushPush.UseVisualStyleBackColor = true;
            this.btn_FileOpsPushPush.Click += new System.EventHandler(this.Btn_FileOpsPushPush_Click);
            // 
            // btn_FileOpsPushBrowse
            // 
            this.btn_FileOpsPushBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FileOpsPushBrowse.Location = new System.Drawing.Point(447, 37);
            this.btn_FileOpsPushBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_FileOpsPushBrowse.Name = "btn_FileOpsPushBrowse";
            this.btn_FileOpsPushBrowse.Size = new System.Drawing.Size(203, 27);
            this.btn_FileOpsPushBrowse.TabIndex = 4;
            this.btn_FileOpsPushBrowse.Text = "Browse...";
            this.btn_FileOpsPushBrowse.UseVisualStyleBackColor = true;
            this.btn_FileOpsPushBrowse.Click += new System.EventHandler(this.Btn_FileOpsPushBrowse_Click);
            // 
            // txt_FileOpsPushTo
            // 
            this.txt_FileOpsPushTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileOpsPushTo.Location = new System.Drawing.Point(8, 81);
            this.txt_FileOpsPushTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_FileOpsPushTo.Name = "txt_FileOpsPushTo";
            this.txt_FileOpsPushTo.Size = new System.Drawing.Size(429, 25);
            this.txt_FileOpsPushTo.TabIndex = 5;
            this.txt_FileOpsPushTo.Text = "/sdcard/";
            // 
            // txt_FileOpsPushFrom
            // 
            this.txt_FileOpsPushFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileOpsPushFrom.Location = new System.Drawing.Point(8, 37);
            this.txt_FileOpsPushFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_FileOpsPushFrom.Name = "txt_FileOpsPushFrom";
            this.txt_FileOpsPushFrom.Size = new System.Drawing.Size(429, 25);
            this.txt_FileOpsPushFrom.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FileOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 258);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FileOps";
            this.ShowIcon = false;
            this.Text = "FileOps";
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btn_FileOpsPullList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_FileOpsPullPull;
        private System.Windows.Forms.Button btn_FileOpsPullBrowse;
        private System.Windows.Forms.TextBox txt_FileOpsPullFrom;
        private System.Windows.Forms.TextBox txt_FileOpsPullTo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_FileOpsPushList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_FileOpsPushPush;
        private System.Windows.Forms.Button btn_FileOpsPushBrowse;
        private System.Windows.Forms.TextBox txt_FileOpsPushTo;
        private System.Windows.Forms.TextBox txt_FileOpsPushFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}