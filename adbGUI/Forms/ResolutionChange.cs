// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
    using System;
    using System.Windows.Forms;
    using Methods;

    public partial class ResolutionChange : Form
    {
        private readonly CmdProcess _adb;
        private readonly FormMethods _formMethods;

        public ResolutionChange(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            _adb = adbFrm;
            _formMethods = formMethodsFrm;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            Close();
            return true;
        }

        private void Btn_ResolutionChangeSet_Click(object sender, EventArgs e)
        {
            _adb.StartProcessing("adb shell wm size " + txt_phoneResolution.Text, _formMethods.SelectedDevice());
        }

        private void Btn_ResolutionChangeReset_Click(object sender, EventArgs e)
        {
            _adb.StartProcessing("adb shell wm size reset", _formMethods.SelectedDevice());
        }

        private void Btn_ResolutionChangeShow_Click(object sender, EventArgs e)
        {
            _adb.StartProcessing("adb shell wm size", _formMethods.SelectedDevice());
        }

        private void Txt_phoneResolution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btn_ResolutionChangeSet.PerformClick();
            e.SuppressKeyPress = true;
        }
    }
}