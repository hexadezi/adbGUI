using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI
{
      public partial class RebootMenu : Form
      {
            public RebootMenu()
            {
                  InitializeComponent();
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

            private void btn_rebootmenu_reboot_Click(object sender, EventArgs e)
            {
                  this.Close();

                  MainForm mainformm = new MainForm();

                  if (combo_rebootmenu.SelectedIndex == 0)
                  {
                        mainformm.callADB_wo("", "shell reboot -p");
                  }
                  else if (combo_rebootmenu.SelectedIndex == 1)
                  {
                        mainformm.callADB_wo("", "reboot");
                  }
                  else if (combo_rebootmenu.SelectedIndex == 2)
                  {
                        mainformm.callADB_wo("", "reboot bootloader");
                  }
                  else if (combo_rebootmenu.SelectedIndex == 3)
                  {
                        mainformm.callADB_wo("", "reboot recovery");

                  }

                  var rebootMenu = new RebootMenu();

            }
      }
}
