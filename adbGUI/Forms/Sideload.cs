using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class Sideload : Form
    {
        AdbOps adb;
        FormMethods formMethods;

        public Sideload(AdbOps adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();

            adb = adbFrm;
            formMethods = formMethodsFrm;
        }

        private void Btn_SideloadStart_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_SideloadPath.Text))
            {
                var s = "sideload \"" + txt_SideloadPath.Text + "\"";
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
