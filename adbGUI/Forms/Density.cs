// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
    using Methods;
    using System;
    using System.Windows.Forms;

    public partial class Density : Form
    {
        private readonly CmdProcess _adb;
        private readonly FormMethods _formMethods;

        public Density(CmdProcess adbFrm, FormMethods formMethodsFrm)
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

        private void Btn_showDpi_Click(object sender, EventArgs e)
        {
            _adb.StartProcessing("adb shell wm density", _formMethods.SelectedDevice());
        }

        private void Btn_setDpi_Click(object sender, EventArgs e)
        {
            _adb.StartProcessing("adb shell wm density " + txt_phoneDpi.Text, _formMethods.SelectedDevice());
        }

        private void Btn_resetDpi_Click(object sender, EventArgs e)
        {
            _adb.StartProcessing("adb shell wm density reset", _formMethods.SelectedDevice());
        }

        private void DpiChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}