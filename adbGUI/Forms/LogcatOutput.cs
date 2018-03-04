// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
    using System.Windows.Forms;

    public partial class LogcatOutput : Form
    {
        public LogcatOutput()
        {
            InitializeComponent();
        }

        private void LogcatOutput_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;
        }
    }
}