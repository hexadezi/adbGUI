using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class Density : Form
    {
        private CmdProcess adb;
        private FormMethods formMethods;

        public Density(CmdProcess adbFrm, FormMethods formMethodsFrm)
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
            adb.StartProcessing("adb shell wm density", formMethods.SelectedDevice());
        }

        private void Btn_setDpi_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("adb shell wm density " + txt_phoneDpi.Text, formMethods.SelectedDevice());
        }

        private void Btn_resetDpi_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("adb shell wm density reset", formMethods.SelectedDevice());
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