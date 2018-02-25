using System;
using System.Windows.Forms;
using adbGUI.Methods;

namespace adbGUI.Forms
{
    public partial class Sideload : Form
    {
        private readonly CmdProcess _adb;
        private readonly FormMethods _formMethods;

        public Sideload(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();

            _adb = adbFrm;
            _formMethods = formMethodsFrm;
        }

        private void Btn_SideloadStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_SideloadPath.Text))
            {
                var s = "adb sideload \"" + txt_SideloadPath.Text + "\"";
                _adb.StartProcessing(s, _formMethods.SelectedDevice());
            }
            else
            {
                MessageBox.Show(@"Please select a file!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SideloadBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = @" .zip|*.zip";

            if (openFileDialog.ShowDialog() == DialogResult.OK) txt_SideloadPath.Text = openFileDialog.FileName;
        }
    }
}