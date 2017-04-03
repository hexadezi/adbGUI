using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class SetProp : Form
    {
        private CmdProcess adb;
        private FormMethods formMethods;

        public SetProp(CmdProcess adbFrm, FormMethods fMethods)
        {
            adb = adbFrm;
            formMethods = fMethods;
            InitializeComponent();
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

        private void Btn_setProp_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("adb shell su root setprop " + txt_setPropKey.Text + " " + txt_setPropValue.Text, formMethods.SelectedDevice());
        }

        private void SetProp_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}