// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
    using Methods;
    using System;
    using System.Windows.Forms;

    public partial class SetProp : Form
    {
        private readonly CmdProcess _adb;
        private readonly FormMethods _formMethods;

        public SetProp(CmdProcess adbFrm, FormMethods fMethods)
        {
            _adb = adbFrm;
            _formMethods = fMethods;
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            Close();
            return true;
        }

        private void Btn_setProp_Click(object sender, EventArgs e)
        {
            _adb.StartProcessing("adb shell su root setprop " + txt_setPropKey.Text + " " + txt_setPropValue.Text,
                _formMethods.SelectedDevice());
        }
    }
}