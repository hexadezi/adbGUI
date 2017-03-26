using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class DpiChange : Form
    {
        private AdbOps adb;
        private FormMethods formMethods;

        public DpiChange(AdbOps adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            adb = adbFrm;
            formMethods = formMethodsFrm;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Btn_showDpi_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm density", formMethods.SelectedDevice());
        }

        private void Btn_setDpi_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm density " + txt_phoneDpi.Text, formMethods.SelectedDevice());
        }

        private void Btn_resetDpi_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm density reset", formMethods.SelectedDevice());
        }

        private void DpiChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}