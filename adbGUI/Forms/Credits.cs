// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
	using adbGUI.Methods;
	using System;
    using System.Windows.Forms;

    public partial class Credits : ExtForm
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