namespace adbGUI
{
      partial class RebootMenu
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
                  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RebootMenu));
                  this.combo_rebootmenu = new System.Windows.Forms.ComboBox();
                  this.btn_rebootmenu_reboot = new System.Windows.Forms.Button();
                  this.SuspendLayout();
                  // 
                  // combo_rebootmenu
                  // 
                  this.combo_rebootmenu.FormattingEnabled = true;
                  this.combo_rebootmenu.Items.AddRange(new object[] {
            "Shutdown Device",
            "Reboot Normal",
            "Reboot Bootloader",
            "Reboot Recovery"});
                  this.combo_rebootmenu.Location = new System.Drawing.Point(12, 12);
                  this.combo_rebootmenu.Name = "combo_rebootmenu";
                  this.combo_rebootmenu.Size = new System.Drawing.Size(196, 21);
                  this.combo_rebootmenu.TabIndex = 0;
                  // 
                  // btn_rebootmenu_reboot
                  // 
                  this.btn_rebootmenu_reboot.Dock = System.Windows.Forms.DockStyle.Bottom;
                  this.btn_rebootmenu_reboot.Location = new System.Drawing.Point(0, 43);
                  this.btn_rebootmenu_reboot.Name = "btn_rebootmenu_reboot";
                  this.btn_rebootmenu_reboot.Size = new System.Drawing.Size(220, 23);
                  this.btn_rebootmenu_reboot.TabIndex = 1;
                  this.btn_rebootmenu_reboot.Text = "Reboot";
                  this.btn_rebootmenu_reboot.UseVisualStyleBackColor = true;
                  this.btn_rebootmenu_reboot.Click += new System.EventHandler(this.btn_rebootmenu_reboot_Click);
                  // 
                  // RebootMenu
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(220, 66);
                  this.Controls.Add(this.btn_rebootmenu_reboot);
                  this.Controls.Add(this.combo_rebootmenu);
                  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                  this.Name = "RebootMenu";
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                  this.Text = "RebootMenu";
                  this.Load += new System.EventHandler(this.RebootMenu_Load);
                  this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.ComboBox combo_rebootmenu;
            private System.Windows.Forms.Button btn_rebootmenu_reboot;
      }
}