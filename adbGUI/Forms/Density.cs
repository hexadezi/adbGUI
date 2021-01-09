// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
    using System;
    using System.Windows.Forms;
    using Methods;

    public partial class Density : ExtForm
    {
        public Density()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            Close();
            return true;
        }

        private void Btn_showDpi_Click(object sender, EventArgs e)
        {
            HelperClass.Execute("adb shell wm density");
        }

        private void Btn_setDpi_Click(object sender, EventArgs e)
        {
            HelperClass.Execute("adb shell wm density " + txt_phoneDpi.Text);
        }

        private void Btn_resetDpi_Click(object sender, EventArgs e)
        {
            HelperClass.Execute("adb shell wm density reset");
        }

        private void DpiChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}