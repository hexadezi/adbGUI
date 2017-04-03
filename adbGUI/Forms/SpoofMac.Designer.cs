namespace adbGUI.Forms
{
    partial class SpoofMac
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_SpoofMacReset = new System.Windows.Forms.Button();
            this.btn_SpoofMacSet = new System.Windows.Forms.Button();
            this.btn_SpoofMacShow = new System.Windows.Forms.Button();
            this.txt_SpoofMacAdress = new System.Windows.Forms.TextBox();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_SpoofMacReset);
            this.groupBox6.Controls.Add(this.btn_SpoofMacSet);
            this.groupBox6.Controls.Add(this.btn_SpoofMacShow);
            this.groupBox6.Controls.Add(this.txt_SpoofMacAdress);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(357, 49);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Spoof MAC";
            // 
            // btn_SpoofMacReset
            // 
            this.btn_SpoofMacReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_SpoofMacReset.Location = new System.Drawing.Point(194, 18);
            this.btn_SpoofMacReset.Name = "btn_SpoofMacReset";
            this.btn_SpoofMacReset.Size = new System.Drawing.Size(75, 22);
            this.btn_SpoofMacReset.TabIndex = 27;
            this.btn_SpoofMacReset.Text = "Reset";
            this.btn_SpoofMacReset.UseVisualStyleBackColor = true;
            this.btn_SpoofMacReset.Click += new System.EventHandler(this.Btn_SpoofMacReset_Click);
            // 
            // btn_SpoofMacSet
            // 
            this.btn_SpoofMacSet.Location = new System.Drawing.Point(113, 18);
            this.btn_SpoofMacSet.Name = "btn_SpoofMacSet";
            this.btn_SpoofMacSet.Size = new System.Drawing.Size(75, 22);
            this.btn_SpoofMacSet.TabIndex = 25;
            this.btn_SpoofMacSet.Text = "Set";
            this.btn_SpoofMacSet.UseVisualStyleBackColor = true;
            this.btn_SpoofMacSet.Click += new System.EventHandler(this.Btn_SpoofMacSet_Click);
            // 
            // btn_SpoofMacShow
            // 
            this.btn_SpoofMacShow.Location = new System.Drawing.Point(275, 18);
            this.btn_SpoofMacShow.Name = "btn_SpoofMacShow";
            this.btn_SpoofMacShow.Size = new System.Drawing.Size(75, 22);
            this.btn_SpoofMacShow.TabIndex = 26;
            this.btn_SpoofMacShow.Text = "Show";
            this.btn_SpoofMacShow.UseVisualStyleBackColor = true;
            this.btn_SpoofMacShow.Click += new System.EventHandler(this.Btn_SpoofMacShow_Click);
            // 
            // txt_SpoofMacAdress
            // 
            this.txt_SpoofMacAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_SpoofMacAdress.Location = new System.Drawing.Point(6, 19);
            this.txt_SpoofMacAdress.Name = "txt_SpoofMacAdress";
            this.txt_SpoofMacAdress.Size = new System.Drawing.Size(101, 20);
            this.txt_SpoofMacAdress.TabIndex = 24;
            this.txt_SpoofMacAdress.Text = "00:11:22:33:44:55";
            this.txt_SpoofMacAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SpoofMacAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_SpoofMacAdress_KeyDown);
            // 
            // SpoofMac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 73);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SpoofMac";
            this.Text = "SpoofMac";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_SpoofMacReset;
        private System.Windows.Forms.Button btn_SpoofMacSet;
        private System.Windows.Forms.Button btn_SpoofMacShow;
        private System.Windows.Forms.TextBox txt_SpoofMacAdress;
    }
}