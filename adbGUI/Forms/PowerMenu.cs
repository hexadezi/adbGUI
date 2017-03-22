using System;
using System.CodeDom;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace adbGUI
{
    public partial class PowerMenu : Form
    {
        AdbOps adb = new AdbOps();

        FormMethods formMethods;

        public PowerMenu(MainForm frm)
        {
            InitializeComponent();
            formMethods = frm.formMethods;
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

        private void Btn_rebootmenu_reboot_Click(object sender, EventArgs e)
        {
            Close();

            MainForm mainform = Application.OpenForms.OfType<MainForm>().Single();

            string serial = " -s " + mainform.cbx_connectedDevices.SelectedItem.ToString(); ;

            string cmd = null;

            switch (combo_rebootmenu.SelectedIndex)
            {
                case 0:
                    //StandardIO.AdbCMDBackground("", "shell reboot -p", serial);
                    cmd = "shell reboot -p";
                    break;
                case 1:
                    //StandardIO.AdbCMDBackground("", "reboot", serial);
                    cmd = "reboot";
                    break;
                case 2:
                    //StandardIO.AdbCMDBackground("", "reboot bootloader", serial);
                    cmd = "reboot bootloader";
                    break;
                case 3:
                    //StandardIO.AdbCMDBackground("", "reboot recovery", serial);
                    cmd = "reboot recovery";
                    break;
            }

            adb.StartProcessing(cmd, formMethods.SelectedDevice());

        }
    }
}
