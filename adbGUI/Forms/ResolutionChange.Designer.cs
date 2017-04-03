namespace adbGUI.Forms
{
    partial class ResolutionChange
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
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btn_ResolutionChangeReset = new System.Windows.Forms.Button();
            this.btn_ResolutionChangeShow = new System.Windows.Forms.Button();
            this.txt_phoneResolution = new System.Windows.Forms.TextBox();
            this.btn_ResolutionChangeSet = new System.Windows.Forms.Button();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btn_ResolutionChangeReset);
            this.groupBox12.Controls.Add(this.btn_ResolutionChangeShow);
            this.groupBox12.Controls.Add(this.txt_phoneResolution);
            this.groupBox12.Controls.Add(this.btn_ResolutionChangeSet);
            this.groupBox12.Location = new System.Drawing.Point(12, 12);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(321, 49);
            this.groupBox12.TabIndex = 15;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Resolution";
            // 
            // btn_ResolutionChangeReset
            // 
            this.btn_ResolutionChangeReset.Location = new System.Drawing.Point(156, 17);
            this.btn_ResolutionChangeReset.Name = "btn_ResolutionChangeReset";
            this.btn_ResolutionChangeReset.Size = new System.Drawing.Size(75, 23);
            this.btn_ResolutionChangeReset.TabIndex = 35;
            this.btn_ResolutionChangeReset.Text = "Reset";
            this.btn_ResolutionChangeReset.UseVisualStyleBackColor = true;
            this.btn_ResolutionChangeReset.Click += new System.EventHandler(this.Btn_ResolutionChangeReset_Click);
            // 
            // btn_ResolutionChangeShow
            // 
            this.btn_ResolutionChangeShow.Location = new System.Drawing.Point(237, 16);
            this.btn_ResolutionChangeShow.Name = "btn_ResolutionChangeShow";
            this.btn_ResolutionChangeShow.Size = new System.Drawing.Size(75, 23);
            this.btn_ResolutionChangeShow.TabIndex = 34;
            this.btn_ResolutionChangeShow.Text = "Show current DPI";
            this.btn_ResolutionChangeShow.UseVisualStyleBackColor = true;
            this.btn_ResolutionChangeShow.Click += new System.EventHandler(this.Btn_ResolutionChangeShow_Click);
            // 
            // txt_phoneResolution
            // 
            this.txt_phoneResolution.Location = new System.Drawing.Point(6, 19);
            this.txt_phoneResolution.Name = "txt_phoneResolution";
            this.txt_phoneResolution.Size = new System.Drawing.Size(63, 20);
            this.txt_phoneResolution.TabIndex = 32;
            this.txt_phoneResolution.Text = "1080x1920";
            this.txt_phoneResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_phoneResolution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_phoneResolution_KeyDown);
            // 
            // btn_ResolutionChangeSet
            // 
            this.btn_ResolutionChangeSet.Location = new System.Drawing.Point(75, 17);
            this.btn_ResolutionChangeSet.Name = "btn_ResolutionChangeSet";
            this.btn_ResolutionChangeSet.Size = new System.Drawing.Size(75, 23);
            this.btn_ResolutionChangeSet.TabIndex = 33;
            this.btn_ResolutionChangeSet.Text = "Set";
            this.btn_ResolutionChangeSet.UseVisualStyleBackColor = true;
            this.btn_ResolutionChangeSet.Click += new System.EventHandler(this.Btn_ResolutionChangeSet_Click);
            // 
            // ResolutionChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 73);
            this.Controls.Add(this.groupBox12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResolutionChange";
            this.Text = "ResolutionChange";
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btn_ResolutionChangeReset;
        private System.Windows.Forms.Button btn_ResolutionChangeShow;
        private System.Windows.Forms.TextBox txt_phoneResolution;
        private System.Windows.Forms.Button btn_ResolutionChangeSet;
    }
}