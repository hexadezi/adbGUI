using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class Sideload : Form
    {
        private CmdProcess adb;
        private FormMethods formMethods;

        public Sideload(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();

            adb = adbFrm;
            formMethods = formMethodsFrm;
        }

        private void Btn_SideloadStart_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_SideloadPath.Text))
            {
                var s = "adb sideload \"" + txt_SideloadPath.Text + "\"";
                adb.StartProcessing(s, formMethods.SelectedDevice());
            }
            else
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SideloadBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = @" .zip|*.zip";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_SideloadPath.Text = openFileDialog.FileName;
            }
        }
    }
}