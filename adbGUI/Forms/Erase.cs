namespace adbGUI.Forms
{
    using System;
    using System.Windows.Forms;
    using Methods;

    public partial class Erase : Form
    {
        private readonly CmdProcess _adb;
        private readonly FormMethods _formMethods;

        public Erase(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            _adb = adbFrm;
            _formMethods = formMethodsFrm;
        }

        private void Btn_Erase_Click(object sender, EventArgs e)
        {
            if (txt_Erase.Text == "")
            {
                MessageBox.Show(@"Please specify a partition to erase!", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var s = "fastboot erase " + txt_Erase.Text;
                _adb.StartProcessing(s, _formMethods.SelectedDevice());
            }
        }
    }
}
