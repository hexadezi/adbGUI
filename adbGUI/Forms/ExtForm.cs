using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Forms
{
	public class ExtForm : Form
	{
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			switch (keyData)
			{
				case Keys.Escape:
					Debug.WriteLine("Keypress detected. Closing ExtForm...");
					Close();
					return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}
