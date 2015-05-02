using System;
using System.Windows.Forms;

namespace adbGUI
{
      public partial class RebootMenu : Form
      {
            public RebootMenu(int givenInt)
            {
                  InitializeComponent();
                  devices = givenInt;
            }
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                  if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
                  Close();
                  return true;
            }
            private void RebootMenu_Load(object sender, EventArgs e)
            {
                  combo_rebootmenu.SelectedIndex = 0;
            }


            private readonly int devices;

            private void btn_rebootmenu_reboot_Click(object sender, EventArgs e)
            {
                  MainForm mainform = new MainForm();

                  if (devices == 4)
                  {
                        this.Close();

                        if (combo_rebootmenu.SelectedIndex == 0)
                        {
                              mainform.callADB_wo("", "shell reboot -p");
                        }
                        else if (combo_rebootmenu.SelectedIndex == 1)
                        {
                              mainform.callADB_wo("", "reboot");
                        }
                        else if (combo_rebootmenu.SelectedIndex == 2)
                        {
                              mainform.callADB_wo("", "reboot bootloader");
                        }
                        else if (combo_rebootmenu.SelectedIndex == 3)
                        {
                              mainform.callADB_wo("", "reboot recovery");
                        }

                  }
                  else
                  {
                        MessageBox.Show("No or more devices connected. \r\nIf more than one device is connected, then type in the serial in the main tab.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }

            }
      }
}
