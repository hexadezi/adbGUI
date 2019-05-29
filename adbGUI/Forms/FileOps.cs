// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
    using Methods;
    using System;
    using System.Windows.Forms;

    public partial class FileOps : Form
    {
        private readonly CmdProcess _adb;
        private readonly FormMethods _formMethods;

        public FileOps(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            _adb = adbFrm;
            _formMethods = formMethodsFrm;
        }

        private void Btn_FileOpsPullBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = @"Where should the file be saved?";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                txt_FileOpsPullTo.Text = folderBrowserDialog.SelectedPath;
        }

        private void Btn_FileOpsPullList_Click(object sender, EventArgs e)
        {
            var path = txt_FileOpsPullFrom.Text;
            _adb.StartProcessing("adb shell ls -la " + path + " -F", _formMethods.SelectedDevice());
        }

        private void Btn_FileOpsPullPull_Click(object sender, EventArgs e)
        {
            if (txt_FileOpsPullTo.Text?.Length == 0 || txt_FileOpsPullFrom.Text?.Length == 0)
            {
                MessageBox.Show(@"Please select a file and chose destination!", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var s = "adb pull \"" + txt_FileOpsPullFrom.Text + "\" \"" + txt_FileOpsPullTo.Text + "\"";
                _adb.StartProcessing(s, _formMethods.SelectedDevice());
            }
        }

        private void Btn_FileOpsPushBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = " "; //This is not a normal whitespace. ALT + 255
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ValidateNames = false;
            openFileDialog.Filter = @"All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
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

        private void Btn_FileOpsPushList_Click(object sender, EventArgs e)
        {
            var path = txt_FileOpsPushTo.Text;
            _adb.StartProcessing("adb shell ls -la " + path + " -F", _formMethods.SelectedDevice());
        }

        private void Btn_FileOpsPushPush_Click(object sender, EventArgs e)
        {
            if (txt_FileOpsPushTo.Text?.Length == 0 || txt_FileOpsPushFrom.Text?.Length == 0)
            {
                MessageBox.Show(@"Please select a file and chose destination!", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var s = "adb push \"" + txt_FileOpsPushFrom.Text + "\" \"" + txt_FileOpsPushTo.Text + "\"";
                _adb.StartProcessing(s, _formMethods.SelectedDevice());
            }
        }
    }
}