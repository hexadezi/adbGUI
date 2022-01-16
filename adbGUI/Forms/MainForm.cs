using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using adbGUI.Methods;

namespace adbGUI.Forms
{
	public partial class MainForm : Form
	{
		readonly StringBuilder stringBuilder = new StringBuilder();

		const int RICHTEXTBOX_REFRSH_INTERVAL = 5;

		public MainForm()
		{
			InitializeComponent();
		}

		public void AppendToRichTextBox()
		{
			while (true)
			{
				lock (stringBuilder)
				{
					if (stringBuilder.Length > 0)
					{
						rtb_console.Invoke((MethodInvoker)(() => rtb_console.AppendText(stringBuilder.ToString())));
						stringBuilder.Clear();
					}
				}

				Thread.Sleep(RICHTEXTBOX_REFRSH_INTERVAL);
			}
		}

		public Form GetForm(string arg)
		{
			Type type = Type.GetType($"adbGUI.Forms.{arg}");
			Form frm = (Form)Activator.CreateInstance(type);
			return frm;
		}

		private void AppendReceivedData(object sender, DataReceivedEventArgs e)
		{
			lock (stringBuilder)
			{
				stringBuilder.AppendLine(e.Data);
			}
		}

		private void Btn_ConsoleClear_Click(object sender, EventArgs e)
		{
			rtb_console.Clear();
		}

		private void Btn_consoleStop_Click(object sender, EventArgs e)
		{
			CLI.KillChildProcessesAsync();
		}

		private void Btn_executeCommand_Click(object sender, EventArgs e)
		{
			var command = cbx_customCommand.Text;

			if (!string.IsNullOrEmpty(command))
			{
				cbx_customCommand.Items.Insert(0, command);
				HelperClass.Execute(command);
			}
		}

		private void Cbx_customCommand_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) btn_executeCommand.PerformClick();
		}

		private void CloseApplication()
		{
			Debug.WriteLine("Shutting down...");

			Debug.WriteLine("  > Killing all child processes...");
			CLI.StopWithShell();

			Debug.WriteLine("  > Closing application...");
			Environment.Exit(0);
		}

		private void DevicesWatcher_DevicesChanged(object sender, List<string> e)
		{
			HelperClass.SelectedDevice = "";
			tsc_ConnectedDevices.ComboBox.Invoke((MethodInvoker)(() => tsc_ConnectedDevices.ComboBox.DataSource = e));
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			CloseApplication();
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
			{

				if ((!cbx_customCommand.Focused || String.IsNullOrWhiteSpace(cbx_customCommand.SelectedText)) && String.IsNullOrWhiteSpace(rtb_console.SelectedText))
				{
					Debug.WriteLine("Keypress detected: CTRL + C");
					CLI.KillChildProcessesAsync();
					e.Handled = e.SuppressKeyPress = true;
				}

			}
			else if (e.KeyCode == Keys.Escape)
			{
				Debug.WriteLine("Keypress detected: ESC");
				CloseApplication();
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// Begin and cancel so the RichTextBox will stay clean. Otherwise it will start in line 2.
			CLI.Commandline.BeginOutputReadLine();
			CLI.Commandline.CancelOutputRead();

			Thread.Sleep(50);

			CLI.Commandline.BeginOutputReadLine();
			CLI.Commandline.BeginErrorReadLine();

			CLI.Commandline.ErrorDataReceived += AppendReceivedData;
			CLI.Commandline.OutputDataReceived += AppendReceivedData;

			HelperClass.BeforeExecute += (s, ee) =>
			{
				if (HelperClass.AlwaysClearConsole) { rtb_console.Invoke((MethodInvoker)(() => rtb_console.Clear())); }
			};


			// We start a thread which continuously (see RICHTEXTBOX_REFRSH_INTERVAL) 
			// reads stringBuilder and fills the RichTextBox and then empties stringBuilder.
			new Thread(AppendToRichTextBox).Start();

			DevicesWatcher.DevicesChanged += DevicesWatcher_DevicesChanged;
			DevicesWatcher.Start();

			trv_commandTreeView.ExpandAll();
			trv_commandTreeView.SelectedNode = trv_commandTreeView.Nodes[0];

			//Select custom command control
			cbx_customCommand.Select();
		}
		private void Rtb_console_Resize(object sender, EventArgs e)
		{
			rtb_console.ScrollToCaret();
		}

		private void Trv_commandTreeView_DoubleClick(object sender, EventArgs e)
		{
			// Check if cursor is above a node
			Point localPosition = trv_commandTreeView.PointToClient(Cursor.Position);
			TreeViewHitTestInfo hitTestInfo = trv_commandTreeView.HitTest(localPosition);
			if (hitTestInfo.Location != TreeViewHitTestLocations.Label) { return; }

			//   To see what should be executed, the property "tag" is read. 
			//   
			//   If it starts with #, it means that a new window must be created. The name of the window follows the symbol.
			//   
			//   If it starts with %, it means that something custom must be executed.
			//   
			//   Otherwise the string is executed with CLI.

			string tag = trv_commandTreeView.SelectedNode.Tag.ToString();

			if (string.IsNullOrEmpty(tag)) return;

			else if (tag.StartsWith("%"))
			{
				switch (tag)
				{
					case "%screenshot":
						if (!string.IsNullOrEmpty(HelperClass.SelectedDevice))
						{
							saveFileDialog.FileName =
								"screenshot_" + DateTime.Now.ToString(@"ddMMyyyy_HHmmss")
									.Replace(' ', '_').Replace(':', '.');
							saveFileDialog.Filter = @"PNG Image(.png)|*.png";
							if (saveFileDialog.ShowDialog() == DialogResult.OK)
							{
								HelperClass.Execute("adb exec-out screencap -p > " + saveFileDialog.FileName);
							}
						}

						break;

					default:
						throw new NotImplementedException();
				}
			}

			else if (tag.StartsWith("#"))
			{

				Form frm = GetForm(tag.Substring(1));

				Form t = Application.OpenForms[frm.Text];

				if (t == null)
				{
					frm.Show();
				}
				else
				{
					t.Focus();
				}
			}

			else
			{
				HelperClass.Execute(tag);
			}
		}

		private void Tsb_AdbRoot_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb root");
		}

		private void Tsb_AdbUnroot_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb unroot");
		}

		private void Tsb_KillServer_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb kill-server");
		}

		private void Tsb_OpenShell_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(HelperClass.SelectedDevice))
			{
				var serial = "";

				serial += "-s " + HelperClass.SelectedDevice + " ";

				using (var process = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "cmd",
						Arguments = "/K adb " + serial + " shell"
					}
				})
				{
					process.Start();
				}
			}
		}

		private void Tsb_Power_Click(object sender, EventArgs e)
		{
			switch (sender.ToString())
			{
				case "Reboot Normal":
					HelperClass.Execute("adb reboot");
					break;
				case "Reboot Recovery":
					HelperClass.Execute("adb reboot recovery");
					break;
				case "Reboot Bootloader":
					HelperClass.Execute("adb reboot bootloader");
					break;
				case "Reboot Fastboot":
					HelperClass.Execute("adb reboot fastboot");
					break;
                                case "Reboot Emergency Download (Qualcomm Only)":
					HelperClass.Execute("adb reboot edl");
					break;
				case "Samsung Odin/Download mode (Samsung only)":
					HelperClass.Execute("adb reboot download");
					break;
				case "Sideload Mode":
					HelperClass.Execute("adb reboot sideload");
					break;
				case "Power menu":
					HelperClass.Execute("adb shell input keyevent --longpress 26");
					break;
				case "Lock":
					HelperClass.Execute("adb shell input keyevent 223");
					break;
				case "Wake":
					HelperClass.Execute("adb shell input keyevent 224");
					break;
				case "Shutdown":
					HelperClass.Execute("adb shell reboot -p");
					break;
				case "Sleep":
					HelperClass.Execute("adb shell input keyevent POWER");
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private void Tsc_ConnectedDevices_SelectedIndexChanged(object sender, EventArgs e)
		{
			HelperClass.SelectedDevice = tsc_ConnectedDevices.SelectedItem.ToString();
		}

		private void Tsm_WirelessConnect_Click(object sender, EventArgs e)
		{
			var r = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}:\d{1,5}$");

			var ipadress = tst_IpAdress.Text;

			if (r.Match(ipadress).Success)
				HelperClass.Execute("adb connect " + ipadress, false);
			else
				MessageBox.Show(@"Please enter a valid IP adress", @"Error", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
		}

		private void Tsm_WirelessDisconnect_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb disconnect", false);
		}

		private void Tsb_AlwayClearConsole_CheckedChanged(object sender, EventArgs e)
		{
			HelperClass.AlwaysClearConsole = ((ToolStripButton)sender).Checked;
		}
	}
}
