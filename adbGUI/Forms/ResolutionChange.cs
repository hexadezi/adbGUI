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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Btn_ResolutionChangeSet_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size " + txt_phoneResolution.Text, formMethods.SelectedDevice());
        }

        private void Btn_ResolutionChangeReset_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size reset", formMethods.SelectedDevice());
        }

        private void Btn_ResolutionChangeShow_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell wm size", formMethods.SelectedDevice());
        }

        private void Txt_phoneResolution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ResolutionChangeSet.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void ResolutionChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}