namespace adbGUI.Forms
{
    using System;
    using System.Windows.Forms;
    using Methods;

    public partial class Flash : Form
    {
        private readonly CmdProcess _adb;
        private readonly FormMethods _formMethods;

        public Flash(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            _adb = adbFrm;
            _formMethods = formMethodsFrm;
        }

        private void Btn_FlashBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = " "; //This is not a normal whitespace. ALT + 255
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ValidateNames = false;
            openFileDialog.Filter = @"Image Files(*.img; *.bin) | *.img;*.bin";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            if (openFileDialog.SafeFileName == " ") //This is not a normal whitespace. ALT + 255
                txt_FlashImageFile.Text =
                    openFileDialog.FileName.Remove(openFileDialog.FileName.Length - 2, 2);
            else
                txt_FlashImageFile.Text = openFileDialog.FileName;
        }

        private void Btn_Flash_Click(object sender, EventArgs e)
        {
            if (txt_FlashImageFile.Text == "" || txt_FlashToPartition.Text == "")
            {
                MessageBox.Show(@"Please select a file and specify a destination partition!", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var s = $"fastboot flash {txt_FlashToPartition.Text} {txt_FlashImageFile.Text}";
                _adb.StartProcessing(s, _formMethods.SelectedDevice());
            }
        }
    }
}
