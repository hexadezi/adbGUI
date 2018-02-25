using System.Windows.Forms;

namespace adbGUI.Forms
{
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