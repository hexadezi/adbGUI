using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class ResolutionChange : Form
    {
        private AdbOps adb;
        private FormMethods formMethods;

        public ResolutionChange(AdbOps adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            adb = adbFrm;
            formMethods = formMethodsFrm;
        }

        private void Btn_ResolutionChangeSet_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size " + txt_phoneResolution.Text, formMethods.SelectedDevice());
        }

        private void btn_ResolutionChangeReset_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size reset", formMethods.SelectedDevice());
        }

        private void btn_ResolutionChangeShow_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size", formMethods.SelectedDevice());
        }

        private void txt_phoneResolution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ResolutionChangeSet.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}