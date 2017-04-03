using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class FileOps : Form
    {
        private CmdProcess adb;
        private FormMethods formMethods;

        public FileOps(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            adb = adbFrm;
            formMethods = formMethodsFrm;
        }

        private void Btn_FileOpsPushBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = " "; //This is not a normal whitespace. ALT + 255
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ValidateNames = false;
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.SafeFileName == " ") //This is not a normal whitespace. ALT + 255
                {
                    txt_FileOpsPushTo.Text =
                          openFileDialog.FileName.Remove(openFileDialog.FileName.Length - 2, 2);
                }
                else
                {
                    txt_FileOpsPushFrom.Text = openFileDialog.FileName;
                }
            }
        }

        private void Btn_FileOpsPushPush_Click(object sender, EventArgs e)
        {
            if (txt_FileOpsPushTo.Text == "" || txt_FileOpsPushFrom.Text == "")
            {
                MessageBox.Show("Please select a file and chose destination!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var s = "adb push \"" + txt_FileOpsPushFrom.Text + "\"" + " \"" + txt_FileOpsPushTo.Text + "\"";
                adb.StartProcessing(s, formMethods.SelectedDevice());
            }
        }

        private void Btn_FileOpsPushList_Click(object sender, EventArgs e)
        {
            string path = txt_FileOpsPushTo.Text;
            adb.StartProcessing("adb shell ls -la " + path + " -F", formMethods.SelectedDevice());
        }

        private void Btn_FileOpsPullBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Where should the file be saved?";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_FileOpsPullTo.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Btn_FileOpsPullPull_Click(object sender, EventArgs e)
        {
            if (txt_FileOpsPullTo.Text == "" || txt_FileOpsPullFrom.Text == "")
            {
                MessageBox.Show("Please select a file and chose destination!", "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
            else
            {
                var s = "adb pull \"" + txt_FileOpsPullFrom.Text + "\"" + " \"" + txt_FileOpsPullTo.Text + "\"";
                adb.StartProcessing(s, formMethods.SelectedDevice());
            }
        }

        private void Btn_FileOpsPullList_Click(object sender, EventArgs e)
        {
            string path = txt_FileOpsPullFrom.Text;
            adb.StartProcessing("adb shell ls -la " + path + " -F", formMethods.SelectedDevice());
        }
    }
}