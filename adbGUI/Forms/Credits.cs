using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            textBox1.Select(0, 0);
        }
    }
}
